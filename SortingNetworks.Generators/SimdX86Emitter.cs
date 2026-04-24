using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Emits SIMD-accelerated sorting network code for x86 (AVX2/AVX-512).
    /// Each element type uses a different vector strategy based on element width.
    /// </summary>
    internal static class SimdX86Emitter
    {
        /// <summary>
        /// Returns true if this type can be SIMD-accelerated on x86.
        /// </summary>
        internal static bool CanEmit(string typeName, int size)
        {
            int elemBytes = ElementSize(typeName);
            if (elemBytes <= 0) return false;
            // Max elements we can handle: 4 vectors worth
            int maxElements = MaxElements(elemBytes);
            if (size > maxElements) return false;
            // Min size for SIMD to be worthwhile
            int minSize = MinSimdSize(elemBytes);
            return size >= minSize;
        }

        /// <summary>
        /// Emits a SIMD sort method + dispatch from the public Sort method.
        /// Returns the SIMD method source and the dispatch check to insert into Sort.
        /// </summary>
        internal static (string MethodSource, string DispatchCode) Emit(int size, string typeName, List<List<(int A, int B)>> steps)
        {
            int elemBytes = ElementSize(typeName);

            switch (elemBytes)
            {
                case 1: return EmitByte(size, typeName, steps);
                case 2: return EmitShort(size, typeName, steps);
                case 4: return EmitInt32(size, typeName, steps);
                case 8: return EmitInt64(size, typeName, steps);
                default: return ("", "");
            }
        }

        /// <summary>
        /// Decomposes a flat network array into layers (steps) of disjoint comparator pairs.
        /// Uses a depth-tracking algorithm that respects the ordering of comparators:
        /// each pair is placed in the earliest layer AFTER the last layer where any of
        /// its indices was used. This ensures data dependencies are preserved.
        /// </summary>
        internal static List<List<(int A, int B)>> DecomposeIntoSteps(int[] network)
        {
            var steps = new List<List<(int A, int B)>>();
            // Track the last layer where each index was involved
            var lastUsed = new Dictionary<int, int>();

            for (int i = 0; i < network.Length; i += 2)
            {
                int a = network[i], b = network[i + 1];

                // Find the earliest valid layer: must be after both a and b were last used
                int lastA = lastUsed.ContainsKey(a) ? lastUsed[a] : -1;
                int lastB = lastUsed.ContainsKey(b) ? lastUsed[b] : -1;
                int depth = Math.Max(lastA, lastB) + 1;

                while (steps.Count <= depth)
                    steps.Add(new List<(int A, int B)>());

                steps[depth].Add((a, b));
                lastUsed[a] = depth;
                lastUsed[b] = depth;
            }
            return steps;
        }

        // --- Byte (8-bit) types: single Vector256 for sizes ≤ 32 ---

        private static (string, string) EmitByte(int size, string typeName, List<List<(int A, int B)>> steps)
        {
            if (size > 32) return ("", "");

            var sb = new StringBuilder();
            string suffix = typeName == "byte" ? "" : $"_{typeName}";

            // Method signature
            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimd{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load into Vector256<byte>
            if (size <= 16)
            {
                sb.AppendLine("            var lo = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref first);");
                sb.AppendLine("            var vec = System.Runtime.Intrinsics.Vector256.Create(lo, System.Runtime.Intrinsics.Vector128<byte>.Zero);");
            }
            else if (size == 32)
            {
                sb.AppendLine("            var vec = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector256<byte>>(ref first);");
            }
            else
            {
                int hiReadOffset = size - 16;
                int shiftBytes = 32 - size;
                sb.AppendLine("            var lo = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref first);");
                sb.AppendLine($"            var hi = System.Runtime.Intrinsics.Vector128.Shuffle(");
                sb.AppendLine($"                System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {hiReadOffset})),");
                // Build shift-right mask
                var shiftMask = new byte[16];
                for (int i = 0; i < 16; i++)
                {
                    int src = i + shiftBytes;
                    shiftMask[i] = src < 16 ? (byte)src : (byte)0x80;
                }
                sb.AppendLine($"                {FmtVec128(shiftMask)});");
                sb.AppendLine("            var vec = System.Runtime.Intrinsics.Vector256.Create(lo, hi);");
            }

            // Emit each step
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];
                // Build permutation
                byte[] perm = new byte[32];
                for (int i = 0; i < 32; i++) perm[i] = (byte)i;
                foreach (var (a, b) in step) { perm[a] = (byte)b; perm[b] = (byte)a; }

                // Build blend mask
                byte[] blend = new byte[32];
                foreach (var (a, b) in step)
                    blend[Math.Max(a, b)] = 0xFF;

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");
                sb.AppendLine($"                var shuffled = System.Runtime.Intrinsics.Vector256.Shuffle(vec, {FmtVec256(perm)});");
                sb.AppendLine($"                var mins = {MinExprByte(typeName, "vec", "shuffled")};");
                sb.AppendLine($"                var maxs = {MaxExprByte(typeName, "vec", "shuffled")};");
                sb.AppendLine($"                vec = System.Runtime.Intrinsics.Vector256.ConditionalSelect({FmtVec256(blend)}, maxs, mins);");
                sb.AppendLine("            }");
            }

            // Store results
            sb.AppendLine();
            if (size <= 16)
            {
                sb.AppendLine("            vec.GetLower().StoreUnsafe(ref first);");
            }
            else if (size == 32)
            {
                sb.AppendLine("            vec.StoreUnsafe(ref first);");
            }
            else
            {
                int hiReadOffset = size - 16;
                int shiftBytes = 32 - size;
                // Build shift-left mask
                var storeMask = new byte[16];
                for (int i = 0; i < 16; i++)
                {
                    int src = i - shiftBytes;
                    storeMask[i] = src >= 0 ? (byte)src : (byte)0x80;
                }
                sb.AppendLine($"            System.Runtime.Intrinsics.Vector128.Shuffle(vec.GetUpper(), {FmtVec128(storeMask)})");
                sb.AppendLine($"                .StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {hiReadOffset}));");
                sb.AppendLine("            vec.GetLower().StoreUnsafe(ref first);");
            }

            sb.AppendLine("        }");

            // Dispatch code
            string dispatchSb =
                $"            if (System.Runtime.Intrinsics.X86.Avx2.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimd{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatchSb);
        }

        // --- 16-bit types: 4x Vector128 with AVX-512 PermuteVar32x16 ---

        private static (string, string) EmitShort(int size, string typeName, List<List<(int A, int B)>> steps)
        {
            // AVX-512 BW: single Vector512 for ≤ 32 elements
            if (size > 32) return ("", "");

            var sb = new StringBuilder();
            string suffix = $"_{typeName}";
            int totalBytes = size * 2;

            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimd{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load into 4x Vector128, then combine into Vector512
            if (size <= 8)
            {
                sb.AppendLine("            var v0 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref first);");
                sb.AppendLine("            var vec = System.Runtime.Intrinsics.Vector512.Create(System.Runtime.Intrinsics.Vector256.Create(v0, System.Runtime.Intrinsics.Vector128<byte>.Zero), System.Runtime.Intrinsics.Vector256<byte>.Zero).AsUInt16();");
            }
            else if (size <= 16)
            {
                sb.AppendLine("            var v0 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref first);");
                sb.AppendLine("            var v1 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, 16));");
                sb.AppendLine("            var vec = System.Runtime.Intrinsics.Vector512.Create(System.Runtime.Intrinsics.Vector256.Create(v0, v1), System.Runtime.Intrinsics.Vector256<byte>.Zero).AsUInt16();");
            }
            else
            {
                int v3ReadOffset = (size - 8) * 2;
                int v3ShiftBytes = (32 - size) * 2;
                sb.AppendLine("            var v0 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref first);");
                sb.AppendLine("            var v1 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, 16));");
                sb.AppendLine("            var v2 = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, 32));");
                sb.AppendLine($"            var v3 = System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(");
                sb.AppendLine($"                System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {v3ReadOffset})),");
                sb.AppendLine($"                {v3ShiftBytes});");
                sb.AppendLine("            var vec = System.Runtime.Intrinsics.Vector512.Create(System.Runtime.Intrinsics.Vector256.Create(v0, v1), System.Runtime.Intrinsics.Vector256.Create(v2, v3)).AsUInt16();");
            }

            // Emit steps
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];
                ushort[] perm = new ushort[32];
                for (int i = 0; i < 32; i++) perm[i] = (ushort)i;
                foreach (var (a, b) in step) { perm[a] = (ushort)b; perm[b] = (ushort)a; }

                ushort[] blend = new ushort[32];
                foreach (var (a, b) in step) blend[Math.Max(a, b)] = 0xFFFF;

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");
                sb.AppendLine($"                var shuffled = System.Runtime.Intrinsics.X86.Avx512BW.PermuteVar32x16(vec, {FmtVec512UShort(perm)});");
                sb.AppendLine($"                var mins = {MinExprShort(typeName, "vec", "shuffled")};");
                sb.AppendLine($"                var maxs = {MaxExprShort(typeName, "vec", "shuffled")};");
                sb.AppendLine($"                vec = System.Runtime.Intrinsics.Vector512.ConditionalSelect({FmtVec512UShort(blend)}, maxs, mins);");
                sb.AppendLine("            }");
            }

            // Store
            sb.AppendLine();
            sb.AppendLine("            var result = vec.AsByte();");
            sb.AppendLine("            var lo256 = result.GetLower();");
            if (size <= 8)
            {
                sb.AppendLine("            lo256.GetLower().StoreUnsafe(ref first);");
            }
            else if (size <= 16)
            {
                sb.AppendLine("            lo256.StoreUnsafe(ref first);");
            }
            else
            {
                int v3ReadOffset = (size - 8) * 2;
                int v3ShiftBytes = (32 - size) * 2;
                sb.AppendLine("            var hi256 = result.GetUpper();");
                sb.AppendLine("            var hiLo = hi256.GetLower();");
                sb.AppendLine("            var hiHi = hi256.GetUpper();");
                sb.AppendLine($"            System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(hiHi, {v3ShiftBytes})");
                sb.AppendLine($"                .StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {v3ReadOffset}));");
                sb.AppendLine("            hiLo.StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, 32));");
                sb.AppendLine("            lo256.StoreUnsafe(ref first);");
            }
            sb.AppendLine("        }");

            string dispatchSb =
                $"            if (System.Runtime.Intrinsics.X86.Avx512BW.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimd{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatchSb);
        }

        // --- 32-bit types: multi-Vector256 with AVX2 ---

        private static (string, string) EmitInt32(int size, string typeName, List<List<(int A, int B)>> steps)
        {
            if (size > 32) return ("", "");

            int regSize = 8; // Vector256<int> holds 8 elements
            int numRegs = (size + regSize - 1) / regSize;
            // Pad to numRegs * regSize virtual elements
            int totalSlots = numRegs * regSize;

            var sb = new StringBuilder();
            string suffix = $"_{typeName}";

            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimd{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load vectors
            for (int vi = 0; vi < numRegs; vi++)
            {
                int offset = vi * 32; // 8 ints * 4 bytes
                int elemsInThisVec = Math.Min(regSize, size - vi * regSize);

                if (vi < numRegs - 1 || elemsInThisVec == regSize)
                {
                    sb.AppendLine($"            var v{vi} = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector256<byte>>(ref {(offset == 0 ? "first" : $"System.Runtime.CompilerServices.Unsafe.Add(ref first, {offset})")}).AsInt32();");
                }
                else
                {
                    // Partial last vector - read overlapping and shift
                    int readOffset = (size - 4) * 4; // read last 4 elements (one Vector128 worth)
                    int shiftBytes = (vi * regSize - (size - 4)) * 4; // how many bytes to skip from the overlapping read
                    if (shiftBytes == 0)
                    {
                        sb.AppendLine($"            var v{vi} = System.Runtime.Intrinsics.Vector256.Create(");
                        sb.AppendLine($"                System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset})),");
                        sb.AppendLine("                System.Runtime.Intrinsics.Vector128<byte>.Zero).AsInt32();");
                    }
                    else if (elemsInThisVec <= 4)
                    {
                        sb.AppendLine($"            var v{vi} = System.Runtime.Intrinsics.Vector256.Create(");
                        sb.AppendLine($"                System.Runtime.Intrinsics.X86.Sse2.ShiftRightLogical128BitLane(");
                        sb.AppendLine($"                    System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector128<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset})),");
                        sb.AppendLine($"                    {shiftBytes}),");
                        sb.AppendLine("                System.Runtime.Intrinsics.Vector128<byte>.Zero).AsInt32();");
                    }
                    else
                    {
                        // More than 4 elements but less than 8 - read full Vector256 overlapping
                        int readOffset256 = (size - regSize) * 4;
                        // Shift entire vector right
                        int shiftElems = regSize - elemsInThisVec;
                        // Use PermuteVar8x32 to shift elements
                        int[] shiftPerm = new int[8];
                        for (int j = 0; j < 8; j++)
                            shiftPerm[j] = j + shiftElems < 8 ? j + shiftElems : 0;
                        sb.AppendLine($"            var v{vi} = System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(");
                        sb.AppendLine($"                System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector256<byte>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset256})).AsInt32(),");
                        sb.AppendLine($"                {FmtVec256Int(shiftPerm)});");
                        // Zero out unused lanes
                        int[] zeroMask = new int[8];
                        for (int j = 0; j < elemsInThisVec; j++) zeroMask[j] = -1;
                        sb.AppendLine($"            v{vi} = System.Runtime.Intrinsics.Vector256.BitwiseAnd(v{vi}, {FmtVec256Int(zeroMask)});");
                    }
                }
            }

            // Emit steps
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];
                int[] perm = Enumerable.Range(0, totalSlots).ToArray();
                foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

                int[] blendMask = new int[totalSlots];
                foreach (var (a, b) in step) blendMask[Math.Max(a, b)] = unchecked((int)0xFFFFFFFF);

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");

                // Build shuffled companion for each vector
                for (int d = 0; d < numRegs; d++)
                {
                    // Check if this vector participates in any swap
                    bool vectorModified = false;
                    for (int j = 0; j < regSize; j++)
                    {
                        int pos = d * regSize + j;
                        if (pos < totalSlots && perm[pos] != pos) { vectorModified = true; break; }
                    }
                    if (!vectorModified) continue;

                    // Group sources by which vector they come from
                    var sourceMap = new Dictionary<int, List<(int destLane, int srcLane)>>();
                    for (int j = 0; j < regSize; j++)
                    {
                        int pos = d * regSize + j;
                        if (pos >= totalSlots) break;
                        int srcPos = perm[pos];
                        int srcVec = srcPos / regSize;
                        int srcLane = srcPos % regSize;
                        if (!sourceMap.ContainsKey(srcVec))
                            sourceMap[srcVec] = new List<(int, int)>();
                        sourceMap[srcVec].Add((j, srcLane));
                    }

                    if (sourceMap.Count == 1 && sourceMap.ContainsKey(d))
                    {
                        // Intra-vector permute
                        int[] indices = new int[regSize];
                        for (int j = 0; j < regSize; j++)
                            indices[j] = perm[d * regSize + j] % regSize;

                        bool isIdentity = true;
                        for (int j = 0; j < regSize; j++)
                            if (indices[j] != j) { isIdentity = false; break; }

                        if (!isIdentity)
                            sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(v{d}, {FmtVec256Int(indices)});");
                        else
                            sb.AppendLine($"                var s{d} = v{d};");
                    }
                    else
                    {
                        // Cross-vector shuffle
                        bool firstSource = true;
                        foreach (var kvp in sourceMap.OrderBy(k => k.Key))
                        {
                            int srcVec = kvp.Key;
                            var lanes = kvp.Value;
                            int[] indices = new int[regSize];
                            foreach (var (destLane, srcLane) in lanes)
                                indices[destLane] = srcLane;

                            int blendBits = 0;
                            foreach (var (destLane, _) in lanes)
                                blendBits |= 1 << destLane;

                            if (firstSource)
                            {
                                sb.AppendLine($"                var s{d} = System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(v{srcVec}, {FmtVec256Int(indices)});");
                                firstSource = false;
                            }
                            else
                            {
                                sb.AppendLine($"                s{d} = System.Runtime.Intrinsics.X86.Avx2.Blend(s{d}, System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(v{srcVec}, {FmtVec256Int(indices)}), 0x{blendBits:X2});");
                            }
                        }
                    }
                }

                // Min, Max, Blend for each vector
                for (int d = 0; d < numRegs; d++)
                {
                    bool vectorModified = false;
                    for (int j = 0; j < regSize; j++)
                    {
                        int pos = d * regSize + j;
                        if (pos < totalSlots && perm[pos] != pos) { vectorModified = true; break; }
                    }
                    if (!vectorModified) continue;

                    int blendImm = 0;
                    for (int j = 0; j < regSize; j++)
                    {
                        int pos = d * regSize + j;
                        if (pos < totalSlots && blendMask[pos] != 0)
                            blendImm |= 1 << j;
                    }

                    if (blendImm == 0x00)
                    {
                        sb.AppendLine($"                v{d} = {MinExprInt(typeName, $"v{d}", $"s{d}")};");
                    }
                    else if (blendImm == 0xFF)
                    {
                        sb.AppendLine($"                v{d} = {MaxExprInt(typeName, $"v{d}", $"s{d}")};");
                    }
                    else
                    {
                        sb.AppendLine($"                var min{d} = {MinExprInt(typeName, $"v{d}", $"s{d}")};");
                        sb.AppendLine($"                var max{d} = {MaxExprInt(typeName, $"v{d}", $"s{d}")};");
                        sb.AppendLine($"                v{d} = System.Runtime.Intrinsics.X86.Avx2.Blend(min{d}, max{d}, 0x{blendImm:X2});");
                    }
                }

                sb.AppendLine("            }");
            }

            // Store results (reverse order for overlapping writes)
            sb.AppendLine();
            for (int vi = numRegs - 1; vi >= 0; vi--)
            {
                int elemsInThisVec = Math.Min(regSize, size - vi * regSize);
                int offset = vi * 32;

                if (vi < numRegs - 1 || elemsInThisVec == regSize)
                {
                    if (offset == 0)
                        sb.AppendLine($"            v{vi}.AsByte().StoreUnsafe(ref first);");
                    else
                        sb.AppendLine($"            v{vi}.AsByte().StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {offset}));");
                }
                else
                {
                    // Partial last vector - write back with shift
                    int readOffset = (size - 4) * 4;
                    int shiftBytes = (vi * regSize - (size - 4)) * 4;
                    if (shiftBytes == 0)
                    {
                        sb.AppendLine($"            v{vi}.GetLower().AsByte().StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset}));");
                    }
                    else if (elemsInThisVec <= 4)
                    {
                        sb.AppendLine($"            System.Runtime.Intrinsics.X86.Sse2.ShiftLeftLogical128BitLane(v{vi}.GetLower().AsByte(), {shiftBytes})");
                        sb.AppendLine($"                .StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset}));");
                    }
                    else
                    {
                        // Reverse the shift permutation
                        int shiftElems = regSize - elemsInThisVec;
                        int[] storePerm = new int[8];
                        for (int j = 0; j < 8; j++)
                            storePerm[j] = j >= shiftElems ? j - shiftElems : 0;
                        int writeOffset = (size - regSize) * 4;
                        sb.AppendLine($"            System.Runtime.Intrinsics.X86.Avx2.PermuteVar8x32(v{vi}, {FmtVec256Int(storePerm)})");
                        sb.AppendLine($"                .AsByte().StoreUnsafe(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {writeOffset}));");
                    }
                }
            }
            sb.AppendLine("        }");

            string dispatch =
                $"            if (System.Runtime.Intrinsics.X86.Avx2.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimd{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatch);
        }

        // --- 64-bit types: multi-Vector256 or AVX-512 ---

        private static (string, string) EmitInt64(int size, string typeName, List<List<(int A, int B)>> steps)
        {
            // AVX-512 required for 64-bit SIMD sort
            if (size > 32) return ("", "");

            int regSize = 8; // Vector512<long> holds 8 elements
            int numRegs = (size + regSize - 1) / regSize;
            int totalSlots = numRegs * regSize;

            var sb = new StringBuilder();
            string suffix = $"_{typeName}";

            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveOptimization)]");
            sb.AppendLine($"        private static void SortSimd{size}{suffix}(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            sb.AppendLine($"            ref byte first = ref System.Runtime.CompilerServices.Unsafe.As<{typeName}, byte>(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span));");

            // Load vectors
            for (int vi = 0; vi < numRegs; vi++)
            {
                int offset = vi * 64;
                int elemsInThisVec = Math.Min(regSize, size - vi * regSize);

                if (vi < numRegs - 1 || elemsInThisVec == regSize)
                {
                    sb.AppendLine($"            var v{vi} = System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector512<long>>(ref {(offset == 0 ? "first" : $"System.Runtime.CompilerServices.Unsafe.Add(ref first, {offset})")});");
                }
                else
                {
                    // Partial last vector
                    int readOffset = (size - regSize) * 8;
                    int shiftAmount = totalSlots - size;
                    long[] loadPerm = new long[8];
                    for (int i = 0; i < 8; i++)
                        loadPerm[i] = (i < 8 - shiftAmount) ? (i + shiftAmount) : 0;
                    sb.AppendLine($"            var v{vi} = System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64(");
                    sb.AppendLine($"                System.Runtime.CompilerServices.Unsafe.ReadUnaligned<System.Runtime.Intrinsics.Vector512<long>>(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset})),");
                    sb.AppendLine($"                {FmtVec512Long(loadPerm)});");
                }
            }

            // Emit steps
            for (int si = 0; si < steps.Count; si++)
            {
                var step = steps[si];
                int[] perm = Enumerable.Range(0, totalSlots).ToArray();
                foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

                long[] blend = new long[totalSlots];
                foreach (var (a, b) in step)
                    blend[Math.Max(a, b)] = -1L;

                string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

                sb.AppendLine();
                sb.AppendLine($"            // Step {si}: {pairStr}");
                sb.AppendLine("            {");

                // Shuffle phase
                for (int vi = 0; vi < numRegs; vi++)
                {
                    bool isIdentity = true;
                    for (int j = 0; j < regSize; j++)
                    {
                        if (perm[vi * regSize + j] != vi * regSize + j) { isIdentity = false; break; }
                    }
                    if (isIdentity) continue;

                    // Check if all sources from single vector
                    bool allFromSame = true;
                    int singleSrc = perm[vi * regSize] / regSize;
                    for (int j = 1; j < regSize; j++)
                    {
                        if (perm[vi * regSize + j] / regSize != singleSrc) { allFromSame = false; break; }
                    }

                    if (allFromSame)
                    {
                        long[] idx = new long[8];
                        for (int j = 0; j < 8; j++) idx[j] = perm[vi * regSize + j] % regSize;
                        sb.AppendLine($"                var shuffled{vi} = System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64(v{singleSrc}, {FmtVec512Long(idx)});");
                    }
                    else
                    {
                        // Cross-vector: use PermuteVar8x64x2 with pairs
                        bool needsLo = false, needsHi = false;
                        long[] idxLo = new long[8], idxHi = new long[8];
                        long[] selectHi = new long[8];
                        int midpoint = numRegs / 2 * regSize;

                        for (int j = 0; j < regSize; j++)
                        {
                            int src = perm[vi * regSize + j];
                            if (src < midpoint || numRegs <= 2)
                            {
                                idxLo[j] = src;
                                needsLo = true;
                            }
                            else
                            {
                                idxHi[j] = src - midpoint;
                                selectHi[j] = -1L;
                                needsHi = true;
                            }
                        }

                        if (needsLo && !needsHi && numRegs >= 2)
                        {
                            sb.AppendLine($"                var shuffled{vi} = System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64x2(v0, {FmtVec512Long(idxLo)}, v{Math.Min(1, numRegs - 1)});");
                        }
                        else if (!needsLo && needsHi)
                        {
                            sb.AppendLine($"                var shuffled{vi} = System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64x2(v{midpoint / regSize}, {FmtVec512Long(idxHi)}, v{Math.Min(midpoint / regSize + 1, numRegs - 1)});");
                        }
                        else
                        {
                            sb.AppendLine($"                var fromLo{vi} = System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64x2(v0, {FmtVec512Long(idxLo)}, v{Math.Min(1, numRegs - 1)});");
                            sb.AppendLine($"                var fromHi{vi} = System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64x2(v{midpoint / regSize}, {FmtVec512Long(idxHi)}, v{Math.Min(midpoint / regSize + 1, numRegs - 1)});");
                            sb.AppendLine($"                var shuffled{vi} = System.Runtime.Intrinsics.Vector512.ConditionalSelect({FmtVec512Long(selectHi)}, fromHi{vi}, fromLo{vi});");
                        }
                    }
                }

                // Min/Max/Blend phase
                for (int vi = 0; vi < numRegs; vi++)
                {
                    bool isIdentity = true;
                    for (int j = 0; j < regSize; j++)
                    {
                        if (perm[vi * regSize + j] != vi * regSize + j) { isIdentity = false; break; }
                    }
                    if (isIdentity) continue;

                    long[] blendSlice = new long[8];
                    for (int j = 0; j < 8; j++) blendSlice[j] = blend[vi * regSize + j];

                    bool allMin = blendSlice.All(v => v == 0);
                    bool allMax = blendSlice.All(v => v == -1L);

                    if (allMin)
                        sb.AppendLine($"                v{vi} = {MinExprLong(typeName, $"v{vi}", $"shuffled{vi}")};");
                    else if (allMax)
                        sb.AppendLine($"                v{vi} = {MaxExprLong(typeName, $"v{vi}", $"shuffled{vi}")};");
                    else
                    {
                        sb.AppendLine($"                var mins{vi} = {MinExprLong(typeName, $"v{vi}", $"shuffled{vi}")};");
                        sb.AppendLine($"                var maxs{vi} = {MaxExprLong(typeName, $"v{vi}", $"shuffled{vi}")};");
                        sb.AppendLine($"                v{vi} = System.Runtime.Intrinsics.Vector512.ConditionalSelect({FmtVec512Long(blendSlice)}, maxs{vi}, mins{vi});");
                    }
                }

                sb.AppendLine("            }");
            }

            // Store
            sb.AppendLine();
            for (int vi = numRegs - 1; vi >= 0; vi--)
            {
                int elemsInThisVec = Math.Min(regSize, size - vi * regSize);
                int offset = vi * 64;

                if (vi < numRegs - 1 || elemsInThisVec == regSize)
                {
                    if (offset == 0)
                        sb.AppendLine($"            System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref first, v{vi});");
                    else
                        sb.AppendLine($"            System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {offset}), v{vi});");
                }
                else
                {
                    int readOffset = (size - regSize) * 8;
                    int shiftAmount = totalSlots - size;
                    long[] storePerm = new long[8];
                    for (int i = 0; i < 8; i++)
                        storePerm[i] = (i >= shiftAmount) ? (i - shiftAmount) : 0;
                    sb.AppendLine($"            System.Runtime.CompilerServices.Unsafe.WriteUnaligned(ref System.Runtime.CompilerServices.Unsafe.Add(ref first, {readOffset}),");
                    sb.AppendLine($"                System.Runtime.Intrinsics.X86.Avx512F.PermuteVar8x64(v{vi}, {FmtVec512Long(storePerm)}));");
                }
            }
            sb.AppendLine("        }");

            string dispatch =
                $"            if (System.Runtime.Intrinsics.X86.Avx512F.IsSupported)\n" +
                $"            {{\n" +
                $"                SortSimd{size}{suffix}(span);\n" +
                $"                return;\n" +
                $"            }}\n";

            return (sb.ToString(), dispatch);
        }

        // --- Helper methods ---

        private static int ElementSize(string typeName)
        {
            switch (typeName)
            {
                case "byte": case "sbyte": return 1;
                case "short": case "ushort": case "char": return 2;
                case "int": case "uint": case "float": return 4;
                case "long": case "ulong": case "double": return 8;
                default: return -1;
            }
        }

        private static int MaxElements(int elemBytes)
        {
            // Max elements we support with SIMD
            switch (elemBytes)
            {
                case 1: return 32;   // Vector256<byte>
                case 2: return 32;   // Vector512<ushort>
                case 4: return 32;   // 4x Vector256<int>
                case 8: return 32;   // 4x Vector512<long>
                default: return 0;
            }
        }

        private static int MinSimdSize(int elemBytes)
        {
            // Minimum size for SIMD to be worthwhile and correct
            switch (elemBytes)
            {
                case 1: return 8;    // Need enough bytes for Vector128
                case 2: return 8;    // Need enough shorts for Vector128
                case 4: return 8;    // One full Vector256<int>
                case 8: return 8;    // One full Vector512<long>
                default: return int.MaxValue;
            }
        }

        private static string FmtVec128(byte[] values) =>
            $"System.Runtime.Intrinsics.Vector128.Create((byte){string.Join(", ", values.Select(v => $"0x{v:X2}"))})";

        private static string FmtVec256(byte[] values) =>
            $"System.Runtime.Intrinsics.Vector256.Create((byte){string.Join(", ", values.Select(v => $"0x{v:X2}"))})";

        private static string FmtVec256Int(int[] values) =>
            $"System.Runtime.Intrinsics.Vector256.Create({string.Join(", ", values)})";

        private static string FmtVec512UShort(ushort[] values) =>
            $"System.Runtime.Intrinsics.Vector512.Create((ushort){string.Join(", ", values.Select(v => $"0x{v:X4}"))})";

        private static string FmtVec512Long(long[] values) =>
            $"System.Runtime.Intrinsics.Vector512.Create({string.Join(", ", values.Select(v => $"{v}L"))})";

        private static string MinExprByte(string typeName, string v, string s) =>
            typeName == "sbyte"
                ? $"System.Runtime.Intrinsics.Vector256.Min({v}.AsSByte(), {s}.AsSByte()).AsByte()"
                : $"System.Runtime.Intrinsics.Vector256.Min({v}, {s})";

        private static string MaxExprByte(string typeName, string v, string s) =>
            typeName == "sbyte"
                ? $"System.Runtime.Intrinsics.Vector256.Max({v}.AsSByte(), {s}.AsSByte()).AsByte()"
                : $"System.Runtime.Intrinsics.Vector256.Max({v}, {s})";

        private static string MinExprShort(string typeName, string v, string s) =>
            typeName == "short"
                ? $"System.Runtime.Intrinsics.X86.Avx512BW.Min({v}.AsInt16(), {s}.AsInt16()).AsUInt16()"
                : $"System.Runtime.Intrinsics.X86.Avx512BW.Min({v}, {s})";

        private static string MaxExprShort(string typeName, string v, string s) =>
            typeName == "short"
                ? $"System.Runtime.Intrinsics.X86.Avx512BW.Max({v}.AsInt16(), {s}.AsInt16()).AsUInt16()"
                : $"System.Runtime.Intrinsics.X86.Avx512BW.Max({v}, {s})";

        private static string MinExprInt(string typeName, string v, string s)
        {
            switch (typeName)
            {
                case "uint": return $"System.Runtime.Intrinsics.X86.Avx2.Min({v}.AsUInt32(), {s}.AsUInt32()).AsInt32()";
                case "float": return $"System.Runtime.Intrinsics.X86.Avx.Min({v}.AsSingle(), {s}.AsSingle()).AsInt32()";
                default: return $"System.Runtime.Intrinsics.X86.Avx2.Min({v}, {s})";
            }
        }

        private static string MaxExprInt(string typeName, string v, string s)
        {
            switch (typeName)
            {
                case "uint": return $"System.Runtime.Intrinsics.X86.Avx2.Max({v}.AsUInt32(), {s}.AsUInt32()).AsInt32()";
                case "float": return $"System.Runtime.Intrinsics.X86.Avx.Max({v}.AsSingle(), {s}.AsSingle()).AsInt32()";
                default: return $"System.Runtime.Intrinsics.X86.Avx2.Max({v}, {s})";
            }
        }

        private static string MinExprLong(string typeName, string v, string s)
        {
            switch (typeName)
            {
                case "ulong": return $"System.Runtime.Intrinsics.X86.Avx512F.Min({v}.AsUInt64(), {s}.AsUInt64()).AsInt64()";
                case "double": return $"System.Runtime.Intrinsics.X86.Avx512F.Min({v}.AsDouble(), {s}.AsDouble()).AsInt64()";
                default: return $"System.Runtime.Intrinsics.X86.Avx512F.Min({v}, {s})";
            }
        }

        private static string MaxExprLong(string typeName, string v, string s)
        {
            switch (typeName)
            {
                case "ulong": return $"System.Runtime.Intrinsics.X86.Avx512F.Max({v}.AsUInt64(), {s}.AsUInt64()).AsInt64()";
                case "double": return $"System.Runtime.Intrinsics.X86.Avx512F.Max({v}.AsDouble(), {s}.AsDouble()).AsInt64()";
                default: return $"System.Runtime.Intrinsics.X86.Avx512F.Max({v}, {s})";
            }
        }
    }
}
