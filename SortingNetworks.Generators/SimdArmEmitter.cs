using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Emits SIMD-accelerated sorting network code for ARM (AdvSimd/NEON).
    /// All vectors are Vector128&lt;byte&gt; and elements are cast to their typed
    /// forms only for Min/Max operations.
    /// </summary>
    internal static class SimdArmEmitter
    {
        /// <summary>
        /// Returns true if this type can be SIMD-accelerated on ARM.
        /// 64-bit types are not supported (no AdvSimd 64-bit integer comparison).
        /// </summary>
        internal static bool CanEmit(SpecialType specialType, int size)
        {
            int elemBytes = ElementSize(specialType);
            if (elemBytes <= 0) return false;
            int maxElements = MaxElements(elemBytes);
            if (size > maxElements) return false;
            int minSize = MinSimdSize(elemBytes);
            return size >= minSize;
        }

        /// <summary>
        /// Returns the SIMD guard condition string for the given element type on ARM.
        /// All supported types require AdvSimd.Arm64 (for VectorTableLookup).
        /// </summary>
        internal static string GetGuardCondition(SpecialType specialType)
        {
            int elemBytes = ElementSize(specialType);
            switch (elemBytes)
            {
                case 1: return "System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.IsSupported";
                case 2: return "System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.IsSupported";
                case 4: return "System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.IsSupported";
                default: return "false";
            }
        }

        /// <summary>
        /// Emits a SIMD sort method + dispatch from the public Sort method.
        /// Returns the SIMD method source and the dispatch check to insert into Sort.
        /// </summary>
        internal static (string MethodSource, string DispatchCode) Emit(int size, string typeName, SpecialType specialType, List<List<(int A, int B)>> steps)
        {
            int elemBytes = ElementSize(specialType);

            switch (elemBytes)
            {
                case 1: return EmitByte(size, typeName, specialType, steps);
                case 2: return EmitShort(size, typeName, specialType, steps);
                case 4: return EmitInt32(size, typeName, specialType, steps);
                default: return ("", "");
            }
        }

        // --- Byte (8-bit) types: 1-4 Vector128<byte> ---

        private static (string, string) EmitByte(int size, string typeName, SpecialType specialType, List<List<(int A, int B)>> steps)
        {
            if (size > 64) return ("", "");

            int regSize = 16;
            int elemBytes = 1;
            int numRegs = (size + regSize - 1) / regSize;
            int totalSlots = numRegs * regSize;

            var sb = new StringBuilder();
            string suffix = $"_{typeName}";

            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimdArm{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            EmitEarlyExit(sb, size, typeName);
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load
            if (numRegs == 1)
            {
                sb.AppendLine("            var v0 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref first);");
            }
            else
            {
                EmitLoad(sb, numRegs, regSize, elemBytes, size);
            }

            // Emit steps
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];

                byte[] perm = new byte[totalSlots];
                for (int i = 0; i < totalSlots; i++) perm[i] = (byte)i;
                foreach (var (a, b) in step) { perm[a] = (byte)b; perm[b] = (byte)a; }

                byte[] blend = new byte[totalSlots];
                foreach (var (a, b) in step) blend[Math.Max(a, b)] = 0xFF;

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");

                if (numRegs == 1)
                {
                    // Single register: Vector128.Shuffle
                    byte[] mask = new byte[16];
                    for (int i = 0; i < 16; i++) mask[i] = perm[i];

                    sb.AppendLine($"                var shuffled = System.Runtime.Intrinsics.Vector128.Shuffle(v0, {FmtVec128(mask)});");
                    sb.AppendLine($"                var mins = {MinExpr(specialType, "v0", "shuffled")};");
                    sb.AppendLine($"                var maxs = {MaxExpr(specialType, "v0", "shuffled")};");

                    byte[] blendSlice = new byte[16];
                    Array.Copy(blend, 0, blendSlice, 0, 16);
                    EmitBlend(sb, "v0", blendSlice, "mins", "maxs");
                }
                else
                {
                    // Multi-register: per-register shuffle + min/max/blend
                    EmitByteShufflePhase(sb, perm, totalSlots, regSize, numRegs);
                    EmitMinMaxBlendPhase(sb, perm, blend, totalSlots, regSize, numRegs, 1, specialType);
                }

                sb.AppendLine("            }");
            }

            // Store
            sb.AppendLine();
            if (numRegs == 1)
            {
                sb.AppendLine("            v0.StoreUnsafe(ref first);");
            }
            else
            {
                EmitStore(sb, numRegs, regSize, elemBytes, size);
            }

            sb.AppendLine("        }");

            string dispatch =
                $"            if (System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimdArm{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatch);
        }

        /// <summary>
        /// Emit shuffle phase for byte types with 2 registers.
        /// Uses Vector128.Shuffle for intra-vector, VectorTableLookup for cross-vector.
        /// </summary>
        private static void EmitByteShufflePhase(StringBuilder sb, byte[] perm, int totalSlots, int regSize, int numRegs)
        {
            for (int d = 0; d < numRegs; d++)
            {
                if (!IsVectorModified(perm, d, regSize, totalSlots)) continue;

                bool allFromSame = true;
                int srcReg = perm[d * regSize] / regSize;
                for (int j = 1; j < regSize; j++)
                {
                    if (perm[d * regSize + j] / regSize != srcReg)
                    {
                        allFromSame = false;
                        break;
                    }
                }

                if (allFromSame)
                {
                    byte[] mask = new byte[16];
                    for (int j = 0; j < 16; j++) mask[j] = (byte)(perm[d * regSize + j] % regSize);

                    bool isIdentity = true;
                    for (int j = 0; j < 16; j++) if (mask[j] != j) { isIdentity = false; break; }

                    if (isIdentity)
                        sb.AppendLine($"                var s{d} = v{srcReg};");
                    else
                        sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Vector128.Shuffle(v{srcReg}, {FmtVec128(mask)});");
                }
                else
                {
                    // Cross-register: VectorTableLookup with up to 4 registers
                    byte[] indices = new byte[16];
                    for (int j = 0; j < 16; j++)
                    {
                        int srcPos = perm[d * regSize + j];
                        int sr = srcPos / regSize;
                        int sl = srcPos % regSize;
                        indices[j] = (byte)(sr * 16 + sl);
                    }
                    string tableTuple = BuildTableTuple(numRegs);
                    sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.VectorTableLookup({tableTuple}, {FmtVec128(indices)});");
                }
            }
        }

        // --- Short (16-bit) types: 1-8 Vector128<byte> ---

        private static (string, string) EmitShort(int size, string typeName, SpecialType specialType, List<List<(int A, int B)>> steps)
        {
            if (size > 64) return ("", "");

            int regSize = 8;
            int elemBytes = 2;
            int numRegs = (size + regSize - 1) / regSize;
            int totalSlots = numRegs * regSize;

            var sb = new StringBuilder();
            string suffix = $"_{typeName}";

            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimdArm{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            EmitEarlyExit(sb, size, typeName);
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load
            EmitLoad(sb, numRegs, regSize, elemBytes, size);

            // Emit steps
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];

                int[] perm = Enumerable.Range(0, totalSlots).ToArray();
                foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

                bool[] isMaxPos = new bool[totalSlots];
                foreach (var (a, b) in step) isMaxPos[Math.Max(a, b)] = true;

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");

                // Shuffle phase: use Vector128.Shuffle (TBL1) for intra-register,
                // VectorTableLookup (TBL4) only for cross-register shuffles
                for (int d = 0; d < numRegs; d++)
                {
                    if (!IsVectorModified(perm, d, regSize, totalSlots)) continue;
                    EmitShortShuffle(sb, perm, d, regSize, elemBytes, totalSlots, numRegs, size);
                }

                // Min/Max/Blend phase
                for (int d = 0; d < numRegs; d++)
                {
                    if (!IsVectorModified(perm, d, regSize, totalSlots)) continue;

                    byte[] blendSlice = BuildBlendSlice(isMaxPos, d, regSize, elemBytes);
                    EmitMinMaxBlendForRegister(sb, d, blendSlice, specialType);
                }

                sb.AppendLine("            }");
            }

            // Store
            sb.AppendLine();
            EmitStore(sb, numRegs, regSize, elemBytes, size);
            sb.AppendLine("        }");

            string dispatch =
                $"            if (System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimdArm{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatch);
        }

        /// <summary>
        /// Emit the shuffle for a single destination register in the short (16-bit) path.
        /// Uses Vector128.Shuffle (TBL1) for intra-vector, VectorTableLookup for cross-vector.
        /// This avoids expensive TBL4 instructions on processors like Ampere Altra where
        /// TBL4 has significantly higher latency than TBL1.
        /// </summary>
        private static void EmitShortShuffle(StringBuilder sb, int[] perm, int d, int regSize, int elemBytes, int totalSlots, int numRegs, int size)
        {
            // Check if all active (non-padding) sources come from a single register
            int singleSrc = -1;
            bool allFromSame = true;
            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos >= size) break; // skip padding lanes
                int sr = perm[pos] / regSize;
                if (singleSrc == -1) singleSrc = sr;
                else if (sr != singleSrc) { allFromSame = false; break; }
            }

            if (allFromSame)
            {
                // Intra-vector: Vector128.Shuffle (TBL1)
                byte[] mask = new byte[16];
                for (int j = 0; j < regSize; j++)
                {
                    int pos = d * regSize + j;
                    if (pos < size)
                    {
                        int srcLane = perm[pos] % regSize;
                        for (int k = 0; k < elemBytes; k++)
                            mask[j * elemBytes + k] = (byte)(srcLane * elemBytes + k);
                    }
                    else
                    {
                        // Padding lane: use 0x80 to zero it out
                        for (int k = 0; k < elemBytes; k++)
                            mask[j * elemBytes + k] = 0x80;
                    }
                }

                bool isIdentity = true;
                for (int j = 0; j < regSize; j++)
                {
                    int pos = d * regSize + j;
                    if (pos < size && perm[pos] != pos) { isIdentity = false; break; }
                }

                if (isIdentity)
                    sb.AppendLine($"                var s{d} = v{singleSrc};");
                else
                    sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Vector128.Shuffle(v{singleSrc}, {FmtVec128(mask)});");
            }
            else if (numRegs <= 4)
            {
                // Cross-vector with ≤4 registers: single VectorTableLookup
                byte[] indices = BuildTblByteIndices(perm, d, regSize, elemBytes, totalSlots);
                string tableTuple = BuildTableTuple(numRegs);
                sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.VectorTableLookup({tableTuple}, {FmtVec128(indices)});");
            }
            else
            {
                // Cross-vector with >4 registers: multi-stage TBL
                EmitMultiStageTblShuffle(sb, perm, d, regSize, elemBytes, totalSlots, numRegs);
            }
        }

        // --- Int32 (32-bit) types: 1-16 Vector128<byte> ---

        private static (string, string) EmitInt32(int size, string typeName, SpecialType specialType, List<List<(int A, int B)>> steps)
        {
            if (size > 64) return ("", "");

            int regSize = 4;
            int elemBytes = 4;
            int numRegs = (size + regSize - 1) / regSize;
            int totalSlots = numRegs * regSize;

            var sb = new StringBuilder();
            string suffix = $"_{typeName}";

            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimdArm{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            EmitEarlyExit(sb, size, typeName);
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load
            EmitLoad(sb, numRegs, regSize, elemBytes, size);

            // Emit steps
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];

                int[] perm = Enumerable.Range(0, totalSlots).ToArray();
                foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

                bool[] isMaxPos = new bool[totalSlots];
                foreach (var (a, b) in step) isMaxPos[Math.Max(a, b)] = true;

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");

                // Shuffle phase
                for (int d = 0; d < numRegs; d++)
                {
                    if (!IsVectorModified(perm, d, regSize, totalSlots)) continue;
                    EmitInt32Shuffle(sb, perm, d, regSize, elemBytes, totalSlots, numRegs);
                }

                // Min/Max/Blend phase
                for (int d = 0; d < numRegs; d++)
                {
                    if (!IsVectorModified(perm, d, regSize, totalSlots)) continue;

                    byte[] blendSlice = BuildBlendSlice(isMaxPos, d, regSize, elemBytes);
                    EmitMinMaxBlendForRegister(sb, d, blendSlice, specialType);
                }

                sb.AppendLine("            }");
            }

            // Store
            sb.AppendLine();
            EmitStore(sb, numRegs, regSize, elemBytes, size);
            sb.AppendLine("        }");

            string dispatch =
                $"            if (System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimdArm{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatch);
        }

        /// <summary>
        /// Emit the shuffle for a single destination register in the int32 path.
        /// Uses Vector128.Shuffle for intra-vector, VectorTableLookup for ≤4 regs,
        /// and two-stage TBL for 5-8 registers.
        /// </summary>
        private static void EmitInt32Shuffle(StringBuilder sb, int[] perm, int d, int regSize, int elemBytes, int totalSlots, int numRegs)
        {
            // Check if all sources from a single register
            int singleSrc = -1;
            bool allFromSame = true;
            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos >= totalSlots) break;
                int sr = perm[pos] / regSize;
                if (singleSrc == -1) singleSrc = sr;
                else if (sr != singleSrc) { allFromSame = false; break; }
            }

            if (allFromSame)
            {
                // Intra-vector: Vector128.Shuffle
                byte[] mask = new byte[16];
                for (int j = 0; j < regSize; j++)
                {
                    int pos = d * regSize + j;
                    if (pos < totalSlots)
                    {
                        int srcLane = perm[pos] % regSize;
                        for (int k = 0; k < elemBytes; k++)
                            mask[j * elemBytes + k] = (byte)(srcLane * elemBytes + k);
                    }
                    else
                    {
                        for (int k = 0; k < elemBytes; k++)
                            mask[j * elemBytes + k] = 0x80;
                    }
                }

                bool isIdentity = true;
                for (int j = 0; j < regSize; j++)
                {
                    int pos = d * regSize + j;
                    if (pos < totalSlots && perm[pos] != pos) { isIdentity = false; break; }
                }

                if (isIdentity)
                    sb.AppendLine($"                var s{d} = v{singleSrc};");
                else
                    sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Vector128.Shuffle(v{singleSrc}, {FmtVec128(mask)});");
            }
            else if (numRegs <= 4)
            {
                // Cross-vector with ≤4 registers: single VectorTableLookup
                byte[] indices = BuildTblByteIndices(perm, d, regSize, elemBytes, totalSlots);
                string tableTuple = BuildTableTuple(numRegs);
                sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.VectorTableLookup({tableTuple}, {FmtVec128(indices)});");
            }
            else
            {
                // Cross-vector with >4 registers: multi-stage TBL
                EmitMultiStageTblShuffle(sb, perm, d, regSize, elemBytes, totalSlots, numRegs);
            }
        }

        // --- Shared helpers for load/store/shuffle/blend ---

        /// <summary>
        /// Emits load instructions for multi-register patterns (short/int).
        /// Full registers use ReadUnaligned; the last partial register uses
        /// AdvSimd.ExtractVector128 to shift right and zero-fill.
        /// </summary>
        private static void EmitLoad(StringBuilder sb, int numRegs, int regSize, int elemBytes, int size)
        {
            for (int vi = 0; vi < numRegs; vi++)
            {
                int offset = vi * 16;
                int elemsInThisVec = Math.Min(regSize, size - vi * regSize);

                if (vi < numRegs - 1 || elemsInThisVec == regSize)
                {
                    string offsetExpr = offset == 0
                        ? "first"
                        : $"System.Runtime.CompilerServices.Unsafe.Add(ref first, {offset})";
                    sb.AppendLine($"            var v{vi} = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref {offsetExpr});");
                }
                else
                {
                    int readOffset = (size - regSize) * elemBytes;
                    int shiftBytes = (numRegs * regSize - size) * elemBytes;
                    sb.AppendLine($"            var v{vi} = System.Runtime.Intrinsics.Arm.AdvSimd.ExtractVector128(");
                    sb.AppendLine($"                System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset})),");
                    sb.AppendLine($"                System.Runtime.Intrinsics.Vector128<byte>.Zero,");
                    sb.AppendLine($"                {shiftBytes});");
                }
            }
        }

        /// <summary>
        /// Emits store instructions in reverse order so that earlier registers
        /// overwrite the overlap region created by partial last-register stores.
        /// </summary>
        private static void EmitStore(StringBuilder sb, int numRegs, int regSize, int elemBytes, int size)
        {
            for (int vi = numRegs - 1; vi >= 0; vi--)
            {
                int elemsInThisVec = Math.Min(regSize, size - vi * regSize);
                int offset = vi * 16;

                if (vi < numRegs - 1 || elemsInThisVec == regSize)
                {
                    if (offset == 0)
                        sb.AppendLine($"            v{vi}.StoreUnsafe(ref first);");
                    else
                        sb.AppendLine($"            v{vi}.StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {offset}));");
                }
                else
                {
                    // Partial: shift left then store at overlapping position
                    int readOffset = (size - regSize) * elemBytes;
                    int shiftBytes = (numRegs * regSize - size) * elemBytes;
                    int storeShift = 16 - shiftBytes;
                    sb.AppendLine($"            System.Runtime.Intrinsics.Arm.AdvSimd.ExtractVector128(System.Runtime.Intrinsics.Vector128<byte>.Zero, v{vi}, {storeShift})");
                    sb.AppendLine($"                .StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset}));");
                }
            }
        }

        /// <summary>
        /// Builds TBL byte indices for a single destination register.
        /// Maps each element's permutation to the byte-level indices within
        /// the 64-byte table formed by up to 4 Vector128 registers.
        /// </summary>
        private static byte[] BuildTblByteIndices(int[] perm, int d, int regSize, int elemBytes, int totalSlots)
        {
            byte[] indices = new byte[16];
            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos < totalSlots)
                {
                    int src = perm[pos];
                    int srcReg = src / regSize;
                    int srcLane = src % regSize;
                    int byteOffset = srcReg * 16 + srcLane * elemBytes;
                    for (int k = 0; k < elemBytes; k++)
                        indices[j * elemBytes + k] = (byte)(byteOffset + k);
                }
                else
                {
                    for (int k = 0; k < elemBytes; k++)
                        indices[j * elemBytes + k] = 0xFF;
                }
            }
            return indices;
        }

        /// <summary>
        /// Builds the byte-level blend mask for a single register.
        /// For each element that is a "max" position, all N bytes are set to 0xFF.
        /// </summary>
        private static byte[] BuildBlendSlice(bool[] isMaxPos, int d, int regSize, int elemBytes)
        {
            byte[] blendSlice = new byte[16];
            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos < isMaxPos.Length && isMaxPos[pos])
                {
                    for (int k = 0; k < elemBytes; k++)
                        blendSlice[j * elemBytes + k] = 0xFF;
                }
            }
            return blendSlice;
        }

        /// <summary>
        /// Builds a table tuple string for VectorTableLookup with up to 4 registers.
        /// Missing registers are padded with Vector128&lt;byte&gt;.Zero.
        /// </summary>
        private static string BuildTableTuple(int numRegs)
        {
            int count = Math.Min(numRegs, 4);
            var parts = new string[4];
            for (int i = 0; i < 4; i++)
                parts[i] = i < count ? $"v{i}" : "System.Runtime.Intrinsics.Vector128<byte>.Zero";
            return $"({string.Join(", ", parts)})";
        }

        /// <summary>
        /// Builds a table tuple string for a group of 4 registers starting at <paramref name="groupStart"/>.
        /// Missing registers are padded with Vector128&lt;byte&gt;.Zero.
        /// </summary>
        private static string BuildTableTupleForGroup(int groupStart, int numRegs)
        {
            var parts = new string[4];
            for (int i = 0; i < 4; i++)
            {
                int regIdx = groupStart + i;
                parts[i] = regIdx < numRegs ? $"v{regIdx}" : "System.Runtime.Intrinsics.Vector128<byte>.Zero";
            }
            return $"({string.Join(", ", parts)})";
        }

        /// <summary>
        /// Emits a multi-stage TBL shuffle for cross-register permutations with >4 registers.
        /// Divides registers into groups of 4. The first group with data uses VectorTableLookup,
        /// subsequent groups use VectorTableLookupExtension.
        /// </summary>
        private static void EmitMultiStageTblShuffle(StringBuilder sb, int[] perm, int d, int regSize, int elemBytes, int totalSlots, int numRegs)
        {
            int numGroups = (numRegs + 3) / 4;

            // Build per-group index arrays
            byte[][] groupIndices = new byte[numGroups][];
            for (int g = 0; g < numGroups; g++)
            {
                groupIndices[g] = new byte[16];
                for (int i = 0; i < 16; i++) groupIndices[g][i] = 0xFF;
            }

            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos >= totalSlots) continue;

                int src = perm[pos];
                int srcReg = src / regSize;
                int srcLane = src % regSize;
                int group = srcReg / 4;
                int regInGroup = srcReg % 4;

                int byteOffset = regInGroup * 16 + srcLane * elemBytes;
                for (int k = 0; k < elemBytes; k++)
                {
                    groupIndices[group][j * elemBytes + k] = (byte)(byteOffset + k);
                }
            }

            // Find which groups have data
            bool[] hasData = new bool[numGroups];
            for (int g = 0; g < numGroups; g++)
                hasData[g] = groupIndices[g].Any(b => b != 0xFF);

            // Emit: first group with data uses VectorTableLookup, rest use VectorTableLookupExtension
            bool firstEmitted = false;
            for (int g = 0; g < numGroups; g++)
            {
                if (!hasData[g]) continue;

                string tuple = BuildTableTupleForGroup(g * 4, numRegs);

                if (!firstEmitted)
                {
                    sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.VectorTableLookup({tuple}, {FmtVec128(groupIndices[g])});");
                    firstEmitted = true;
                }
                else
                {
                    sb.AppendLine($"                s{d} = System.Runtime.Intrinsics.Arm.AdvSimd.Arm64.VectorTableLookupExtension(s{d}, {tuple}, {FmtVec128(groupIndices[g])});");
                }
            }
        }

        /// <summary>
        /// Returns true if any element in register d has a non-identity permutation.
        /// </summary>
        private static bool IsVectorModified(int[] perm, int d, int regSize, int totalSlots)
        {
            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos < totalSlots && perm[pos] != pos)
                    return true;
            }
            return false;
        }

        private static bool IsVectorModified(byte[] perm, int d, int regSize, int totalSlots)
        {
            for (int j = 0; j < regSize; j++)
            {
                int pos = d * regSize + j;
                if (pos < totalSlots && perm[pos] != pos)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Emits min/max/blend for a single register using ConditionalSelect.
        /// Optimizes for all-min and all-max cases.
        /// </summary>
        private static void EmitMinMaxBlendForRegister(StringBuilder sb, int d, byte[] blendSlice, SpecialType specialType)
        {
            bool allMin = blendSlice.All(v => v == 0);
            bool allMax = blendSlice.All(v => v == 0xFF);

            if (allMin)
            {
                sb.AppendLine($"                v{d} = {MinExpr(specialType, $"v{d}", $"s{d}")};");
            }
            else if (allMax)
            {
                sb.AppendLine($"                v{d} = {MaxExpr(specialType, $"v{d}", $"s{d}")};");
            }
            else
            {
                sb.AppendLine($"                var min{d} = {MinExpr(specialType, $"v{d}", $"s{d}")};");
                sb.AppendLine($"                var max{d} = {MaxExpr(specialType, $"v{d}", $"s{d}")};");
                sb.AppendLine($"                v{d} = System.Runtime.Intrinsics.Vector128.ConditionalSelect({FmtVec128(blendSlice)}, max{d}, min{d});");
            }
        }

        /// <summary>
        /// Emits a blend assignment for a named variable (single-register byte path).
        /// </summary>
        private static void EmitBlend(StringBuilder sb, string varName, byte[] blendSlice, string minsName, string maxsName)
        {
            bool allMin = blendSlice.All(v => v == 0);
            bool allMax = blendSlice.All(v => v == 0xFF);

            if (allMin)
                sb.AppendLine($"                {varName} = {minsName};");
            else if (allMax)
                sb.AppendLine($"                {varName} = {maxsName};");
            else
                sb.AppendLine($"                {varName} = System.Runtime.Intrinsics.Vector128.ConditionalSelect({FmtVec128(blendSlice)}, {maxsName}, {minsName});");
        }

        /// <summary>
        /// Emits min/max/blend for each register in the byte 2-register path.
        /// </summary>
        private static void EmitMinMaxBlendPhase(StringBuilder sb, byte[] perm, byte[] blend, int totalSlots, int regSize, int numRegs, int elemBytes, SpecialType specialType)
        {
            for (int d = 0; d < numRegs; d++)
            {
                if (!IsVectorModified(perm, d, regSize, totalSlots)) continue;

                byte[] blendSlice = new byte[16];
                for (int j = 0; j < 16; j++) blendSlice[j] = blend[d * regSize + j];

                bool allMin = blendSlice.All(v => v == 0);
                bool allMax = blendSlice.All(v => v == 0xFF);

                if (allMin)
                {
                    sb.AppendLine($"                v{d} = {MinExpr(specialType, $"v{d}", $"s{d}")};");
                }
                else if (allMax)
                {
                    sb.AppendLine($"                v{d} = {MaxExpr(specialType, $"v{d}", $"s{d}")};");
                }
                else
                {
                    sb.AppendLine($"                var min{d} = {MinExpr(specialType, $"v{d}", $"s{d}")};");
                    sb.AppendLine($"                var max{d} = {MaxExpr(specialType, $"v{d}", $"s{d}")};");
                    sb.AppendLine($"                v{d} = System.Runtime.Intrinsics.Vector128.ConditionalSelect({FmtVec128(blendSlice)}, max{d}, min{d});");
                }
            }
        }

        // --- Type helpers ---

        private static int ElementSize(SpecialType specialType)
        {
            switch (specialType)
            {
                case SpecialType.System_Byte: case SpecialType.System_SByte: return 1;
                case SpecialType.System_Int16: case SpecialType.System_UInt16: case SpecialType.System_Char: return 2;
                case SpecialType.System_Int32: case SpecialType.System_UInt32: case SpecialType.System_Single: return 4;
                case SpecialType.System_Int64: case SpecialType.System_UInt64: case SpecialType.System_Double: return 8;
                default: return -1;
            }
        }

        private static int MaxElements(int elemBytes)
        {
            switch (elemBytes)
            {
                case 1: return 64;   // 4 × Vector128<byte>
                case 2: return 64;   // 8 × Vector128<byte>
                case 4: return 64;   // 16 × Vector128<byte>
                default: return 0;   // 64-bit not supported on ARM
            }
        }

        private static int MinSimdSize(int elemBytes)
        {
            switch (elemBytes)
            {
                case 1: return 16;  // Vector128 is 16 bytes; sizes < 16 would over-read
                case 2: return 8;
                case 4: return 8;
                default: return int.MaxValue;
            }
        }

        /// <summary>
        /// Emits an early-exit check that returns immediately if the input is already sorted.
        /// </summary>
        private static void EmitEarlyExit(StringBuilder sb, int size, string typeName)
        {
            sb.AppendLine($"            // Early exit if already sorted");
            sb.AppendLine("            {");
            sb.AppendLine($"                ref {typeName} r = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");
            sb.AppendLine($"                for (int i = 0; i < {size - 1}; i++)");
            sb.AppendLine("                {");
            sb.AppendLine($"                    if (System.Runtime.CompilerServices.Unsafe.Add(ref r, i) > System.Runtime.CompilerServices.Unsafe.Add(ref r, i + 1))");
            sb.AppendLine("                        goto notSorted;");
            sb.AppendLine("                }");
            sb.AppendLine("                return;");
            sb.AppendLine("                notSorted:;");
            sb.AppendLine("            }");
            sb.AppendLine();
        }

        // --- Formatting helpers ---

        private static string FmtVec128(byte[] values) =>
            $"System.Runtime.Intrinsics.Vector128.Create((byte){string.Join(", ", values.Select(v => $"0x{v:X2}"))})";

        // --- Min/Max expression helpers ---

        private static string MinExpr(SpecialType specialType, string v, string s)
        {
            switch (specialType)
            {
                case SpecialType.System_Byte:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}, {s})";
                case SpecialType.System_SByte:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}.AsSByte(), {s}.AsSByte()).AsByte()";
                case SpecialType.System_Int16:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}.AsInt16(), {s}.AsInt16()).AsByte()";
                case SpecialType.System_UInt16:
                case SpecialType.System_Char:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}.AsUInt16(), {s}.AsUInt16()).AsByte()";
                case SpecialType.System_Int32:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}.AsInt32(), {s}.AsInt32()).AsByte()";
                case SpecialType.System_UInt32:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}.AsUInt32(), {s}.AsUInt32()).AsByte()";
                case SpecialType.System_Single:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Min({v}.AsSingle(), {s}.AsSingle()).AsByte()";
                default:
                    return "";
            }
        }

        private static string MaxExpr(SpecialType specialType, string v, string s)
        {
            switch (specialType)
            {
                case SpecialType.System_Byte:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}, {s})";
                case SpecialType.System_SByte:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}.AsSByte(), {s}.AsSByte()).AsByte()";
                case SpecialType.System_Int16:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}.AsInt16(), {s}.AsInt16()).AsByte()";
                case SpecialType.System_UInt16:
                case SpecialType.System_Char:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}.AsUInt16(), {s}.AsUInt16()).AsByte()";
                case SpecialType.System_Int32:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}.AsInt32(), {s}.AsInt32()).AsByte()";
                case SpecialType.System_UInt32:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}.AsUInt32(), {s}.AsUInt32()).AsByte()";
                case SpecialType.System_Single:
                    return $"System.Runtime.Intrinsics.Arm.AdvSimd.Max({v}.AsSingle(), {s}.AsSingle()).AsByte()";
                default:
                    return "";
            }
        }
    }
}
