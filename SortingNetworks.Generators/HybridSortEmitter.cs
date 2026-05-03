using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Emits hybrid sorting code that combines quicksort partitioning
    /// for large arrays with sorting-network base cases for small sub-arrays.
    /// Generates Sort, PartialSort, and NthElement methods.
    /// </summary>
    internal static class HybridSortEmitter
    {
        private const int BaseThreshold = 64;

        /// <summary>
        /// Emits all hybrid sort methods for the given element type.
        /// Does NOT emit the shared network data — call <see cref="EmitNetworkData"/> once separately.
        /// </summary>
        internal static string Emit(string typeName, SpecialType specialType)
        {
            var sb = new StringBuilder();

            bool isString = typeName == "string";
            int elemSize = GetElementSize(specialType);
            bool canSimdPartition = CanEmitSimdPartition(specialType);

            // Emit Sort(Span<T>) and Sort(T[])
            EmitSortMethods(sb, typeName, isString);

            // Emit PartialSort(Span<T>, int k) and overload
            EmitPartialSortMethods(sb, typeName);

            // Emit NthElement(Span<T>, int n) and overload
            EmitNthElementMethods(sb, typeName);

            // Emit private HybridQuickSort
            EmitHybridQuickSort(sb, typeName, isString);

            // Emit private HybridQuickSelect (for PartialSort/NthElement)
            EmitHybridQuickSelect(sb, typeName, isString);

            // Emit private SortSmall
            EmitSortSmall(sb, typeName, isString);

            // Emit MedianOfThree
            EmitMedianOfThree(sb, typeName, isString);

            // Emit ScalarPartition3Way
            EmitScalarPartition3Way(sb, typeName, isString);

            // Emit SIMD partition if applicable
            if (canSimdPartition)
            {
                EmitSimdPartition(sb, typeName, specialType, elemSize);
            }

            return sb.ToString();
        }

        private static void EmitSortMethods(StringBuilder sb, string typeName, bool isString)
        {
            sb.AppendLine($"        /// <summary>Sorts a span of {typeName} using a hybrid quicksort with sorting network base case.</summary>");
            sb.AppendLine($"        public static void Sort(System.Span<{typeName}> span)");
            sb.AppendLine("        {");
            sb.AppendLine("            if (span.Length <= 1) return;");
            sb.AppendLine($"            if (span.Length <= {BaseThreshold})");
            sb.AppendLine("            {");
            sb.AppendLine($"                HybridSortSmall(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span), span.Length);");
            sb.AppendLine("                return;");
            sb.AppendLine("            }");
            sb.AppendLine("            int depthLimit = 2 * System.Numerics.BitOperations.Log2((uint)span.Length);");
            sb.AppendLine("            HybridQuickSort(span, depthLimit);");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine($"        /// <summary>Sorts an array of {typeName} using a hybrid quicksort with sorting network base case.</summary>");
            sb.AppendLine($"        public static void Sort({typeName}[] array)");
            sb.AppendLine("        {");
            sb.AppendLine("            System.ArgumentNullException.ThrowIfNull(array);");
            sb.AppendLine($"            Sort((System.Span<{typeName}>)array);");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitPartialSortMethods(StringBuilder sb, string typeName)
        {
            sb.AppendLine($"        /// <summary>Partially sorts a span so that the first <paramref name=\"k\"/> elements are the smallest in sorted order.</summary>");
            sb.AppendLine($"        public static void PartialSort(System.Span<{typeName}> span, int k)");
            sb.AppendLine("        {");
            sb.AppendLine("            if (k < 0 || k > span.Length) throw new System.ArgumentOutOfRangeException(nameof(k));");
            sb.AppendLine("            if (k <= 0 || span.Length <= 1) return;");
            sb.AppendLine("            HybridQuickSelect(span, k);");
            sb.AppendLine($"            var left = span.Slice(0, k);");
            sb.AppendLine($"            if (left.Length <= {BaseThreshold})");
            sb.AppendLine($"                HybridSortSmall(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(left), left.Length);");
            sb.AppendLine("            else");
            sb.AppendLine("            {");
            sb.AppendLine("                int depthLimit = 2 * System.Numerics.BitOperations.Log2((uint)left.Length);");
            sb.AppendLine("                HybridQuickSort(left, depthLimit);");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine($"        /// <summary>Partially sorts an array so that the first <paramref name=\"k\"/> elements are the smallest in sorted order.</summary>");
            sb.AppendLine($"        public static void PartialSort({typeName}[] array, int k)");
            sb.AppendLine("        {");
            sb.AppendLine("            System.ArgumentNullException.ThrowIfNull(array);");
            sb.AppendLine($"            PartialSort((System.Span<{typeName}>)array, k);");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitNthElementMethods(StringBuilder sb, string typeName)
        {
            sb.AppendLine($"        /// <summary>Rearranges elements so that the element at index <paramref name=\"n\"/> is the element that would be there if the span were sorted.</summary>");
            sb.AppendLine($"        public static void NthElement(System.Span<{typeName}> span, int n)");
            sb.AppendLine("        {");
            sb.AppendLine("            if (n < 0 || n >= span.Length) throw new System.ArgumentOutOfRangeException(nameof(n));");
            sb.AppendLine("            if (span.Length <= 1) return;");
            sb.AppendLine("            HybridQuickSelect(span, n + 1);");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine($"        /// <summary>Rearranges elements so that the element at index <paramref name=\"n\"/> is the element that would be there if the array were sorted.</summary>");
            sb.AppendLine($"        public static void NthElement({typeName}[] array, int n)");
            sb.AppendLine("        {");
            sb.AppendLine("            System.ArgumentNullException.ThrowIfNull(array);");
            sb.AppendLine($"            NthElement((System.Span<{typeName}>)array, n);");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitHybridQuickSort(StringBuilder sb, string typeName, bool isString)
        {
            string gt = GetGreaterThan(typeName, isString);

            sb.AppendLine($"        private static void HybridQuickSort(System.Span<{typeName}> span, int depthLimit)");
            sb.AppendLine("        {");
            sb.AppendLine($"            while (span.Length > {BaseThreshold})");
            sb.AppendLine("            {");
            sb.AppendLine("                if (depthLimit == 0)");
            sb.AppendLine("                {");
            sb.AppendLine("                    System.MemoryExtensions.Sort(span);");
            sb.AppendLine("                    return;");
            sb.AppendLine("                }");
            sb.AppendLine("                depthLimit--;");
            sb.AppendLine();
            sb.AppendLine($"                ref {typeName} first = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");
            sb.AppendLine($"                {typeName} pivot = HybridMedianOfThree(");
            sb.AppendLine("                    first,");
            sb.AppendLine("                    System.Runtime.CompilerServices.Unsafe.Add(ref first, span.Length / 2),");
            sb.AppendLine("                    System.Runtime.CompilerServices.Unsafe.Add(ref first, span.Length - 1));");
            sb.AppendLine();
            sb.AppendLine("                HybridPartition3Way(span, pivot, out int lt, out int gt);");
            sb.AppendLine();
            sb.AppendLine("                // Recurse on the smaller side, iterate on the larger");
            sb.AppendLine("                var left = span.Slice(0, lt);");
            sb.AppendLine("                var right = span.Slice(gt);");
            sb.AppendLine("                if (left.Length <= right.Length)");
            sb.AppendLine("                {");
            sb.AppendLine($"                    if (left.Length > 1)");
            sb.AppendLine("                    {");
            sb.AppendLine($"                        if (left.Length <= {BaseThreshold})");
            sb.AppendLine($"                            HybridSortSmall(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(left), left.Length);");
            sb.AppendLine("                        else");
            sb.AppendLine("                            HybridQuickSort(left, depthLimit);");
            sb.AppendLine("                    }");
            sb.AppendLine("                    span = right;");
            sb.AppendLine("                }");
            sb.AppendLine("                else");
            sb.AppendLine("                {");
            sb.AppendLine($"                    if (right.Length > 1)");
            sb.AppendLine("                    {");
            sb.AppendLine($"                        if (right.Length <= {BaseThreshold})");
            sb.AppendLine($"                            HybridSortSmall(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(right), right.Length);");
            sb.AppendLine("                        else");
            sb.AppendLine("                            HybridQuickSort(right, depthLimit);");
            sb.AppendLine("                    }");
            sb.AppendLine("                    span = left;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine();
            sb.AppendLine($"            if (span.Length > 1)");
            sb.AppendLine($"                HybridSortSmall(ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span), span.Length);");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitHybridQuickSelect(StringBuilder sb, string typeName, bool isString)
        {
            sb.AppendLine($"        private static void HybridQuickSelect(System.Span<{typeName}> span, int k)");
            sb.AppendLine("        {");
            sb.AppendLine("            while (span.Length > 1)");
            sb.AppendLine("            {");
            sb.AppendLine($"                ref {typeName} first = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");
            sb.AppendLine($"                {typeName} pivot = HybridMedianOfThree(");
            sb.AppendLine("                    first,");
            sb.AppendLine("                    System.Runtime.CompilerServices.Unsafe.Add(ref first, span.Length / 2),");
            sb.AppendLine("                    System.Runtime.CompilerServices.Unsafe.Add(ref first, span.Length - 1));");
            sb.AppendLine();
            sb.AppendLine("                HybridPartition3Way(span, pivot, out int lt, out int gt);");
            sb.AppendLine();
            sb.AppendLine("                if (k <= lt)");
            sb.AppendLine("                    span = span.Slice(0, lt);");
            sb.AppendLine("                else if (k > gt)");
            sb.AppendLine("                    { span = span.Slice(gt); k -= gt; }");
            sb.AppendLine("                else");
            sb.AppendLine("                    return; // k-th element is in the pivot region");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitSortSmall(StringBuilder sb, string typeName, bool isString)
        {
            string condition = GetGreaterThanForRef(typeName, isString, "a", "b");

            sb.AppendLine("        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]");
            sb.AppendLine($"        private static void HybridSortSmall(ref {typeName} first, int length)");
            sb.AppendLine("        {");
            sb.AppendLine("            int offset = HybridGetNetworkOffset(length);");
            sb.AppendLine("            int pairCount = HybridGetNetworkOffset(length + 1) - offset;");
            sb.AppendLine("            byte[] data = HybridNetworkData;");
            sb.AppendLine("            for (int i = 0; i < pairCount; i += 2)");
            sb.AppendLine("            {");
            sb.AppendLine($"                ref {typeName} a = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, data[offset + i]);");
            sb.AppendLine($"                ref {typeName} b = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, data[offset + i + 1]);");
            sb.AppendLine($"                if ({condition})");
            sb.AppendLine("                {");
            sb.AppendLine($"                    {typeName} temp = a;");
            sb.AppendLine("                    a = b;");
            sb.AppendLine("                    b = temp;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitMedianOfThree(StringBuilder sb, string typeName, bool isString)
        {
            string gt = GetGreaterThan(typeName, isString);

            sb.AppendLine("        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]");
            sb.AppendLine($"        private static {typeName} HybridMedianOfThree({typeName} a, {typeName} b, {typeName} c)");
            sb.AppendLine("        {");
            sb.AppendLine($"            if ({gt.Replace("$a", "a").Replace("$b", "b")}) {{ {typeName} t = a; a = b; b = t; }}");
            sb.AppendLine($"            if ({gt.Replace("$a", "b").Replace("$b", "c")}) {{ b = c; if ({gt.Replace("$a", "a").Replace("$b", "b")}) b = a; }}");
            sb.AppendLine("            return b;");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitScalarPartition3Way(StringBuilder sb, string typeName, bool isString)
        {
            string lt = GetLessThan(typeName, isString);
            string gt = GetGreaterThan(typeName, isString);

            sb.AppendLine($"        private static void HybridPartition3Way(System.Span<{typeName}> span, {typeName} pivot, out int ltEnd, out int gtStart)");
            sb.AppendLine("        {");
            sb.AppendLine($"            ref {typeName} first = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");
            sb.AppendLine("            int lo = 0;");
            sb.AppendLine("            int mid = 0;");
            sb.AppendLine("            int hi = span.Length - 1;");
            sb.AppendLine("            while (mid <= hi)");
            sb.AppendLine("            {");
            sb.AppendLine($"                ref {typeName} elem = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, mid);");
            sb.AppendLine($"                if ({lt.Replace("$a", "elem").Replace("$b", "pivot")})");
            sb.AppendLine("                {");
            sb.AppendLine($"                    ref {typeName} target = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, lo);");
            sb.AppendLine($"                    {typeName} temp = target;");
            sb.AppendLine("                    target = elem;");
            sb.AppendLine("                    elem = temp;");
            sb.AppendLine("                    lo++;");
            sb.AppendLine("                    mid++;");
            sb.AppendLine("                }");
            sb.AppendLine($"                else if ({gt.Replace("$a", "elem").Replace("$b", "pivot")})");
            sb.AppendLine("                {");
            sb.AppendLine($"                    ref {typeName} target = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, hi);");
            sb.AppendLine($"                    {typeName} temp = target;");
            sb.AppendLine("                    target = elem;");
            sb.AppendLine("                    elem = temp;");
            sb.AppendLine("                    hi--;");
            sb.AppendLine("                }");
            sb.AppendLine("                else");
            sb.AppendLine("                {");
            sb.AppendLine("                    mid++;");
            sb.AppendLine("                }");
            sb.AppendLine("            }");
            sb.AppendLine("            ltEnd = lo;");
            sb.AppendLine("            gtStart = hi + 1;");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        private static void EmitSimdPartition(StringBuilder sb, string typeName, SpecialType specialType, int elemSize)
        {
            // SIMD partition is a future optimization on top of the scalar 3-way partition.
            // The scalar partition is always correct and sufficient for correctness.
            // AVX-512F Compress (for 32/64-bit) and AVX-512 VBMI2 Compress (for 8/16-bit)
            // can be used here for a vectorized partition step.
            // TODO: Implement SIMD partition using Avx512F.Compress / Avx512Vbmi2.Compress
        }

        internal static string EmitNetworkData()
        {
            var sb = new StringBuilder();
            // Build compact byte array of all sorting networks for sizes 2-64
            // Format: pairs are stored contiguously, offset table maps size -> start position
            var allNetworkPairs = new List<byte>();
            var offsets = new int[BaseThreshold + 2]; // offsets[size] = start index for size, offsets[65] = end

            for (int size = 2; size <= BaseThreshold; size++)
            {
                offsets[size] = allNetworkPairs.Count;
                var network = NetworkDatabase.GetNetwork(size);
                if (network == null)
                    network = BatcherNetworkBuilder.Generate(size);

                for (int i = 0; i < network.Length; i++)
                {
                    allNetworkPairs.Add((byte)network[i]);
                }
            }
            offsets[BaseThreshold + 1] = allNetworkPairs.Count;

            // Emit the offset lookup method
            sb.AppendLine("        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]");
            sb.AppendLine("        private static int HybridGetNetworkOffset(int size)");
            sb.AppendLine("        {");
            sb.AppendLine("            return HybridNetworkOffsets[size];");
            sb.AppendLine("        }");
            sb.AppendLine();

            // Emit the offset table as a static readonly array (avoids per-access allocation)
            sb.Append("        private static readonly int[] HybridNetworkOffsets = [");
            for (int i = 0; i < offsets.Length; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(offsets[i]);
            }
            sb.AppendLine("];");
            sb.AppendLine();

            // Emit the network data as a static readonly byte array (avoids per-access allocation)
            sb.Append("        private static readonly byte[] HybridNetworkData = [");
            for (int i = 0; i < allNetworkPairs.Count; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(allNetworkPairs[i]);
            }
            sb.AppendLine("];");
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Returns whether SIMD partition can be emitted for this type.
        /// </summary>
        internal static bool CanEmitSimdPartition(SpecialType specialType)
        {
            return specialType switch
            {
                SpecialType.System_Byte => true,
                SpecialType.System_SByte => true,
                SpecialType.System_Int16 => true,
                SpecialType.System_UInt16 => true,
                SpecialType.System_Char => true,
                SpecialType.System_Int32 => true,
                SpecialType.System_UInt32 => true,
                SpecialType.System_Single => true,
                SpecialType.System_Int64 => true,
                SpecialType.System_UInt64 => true,
                SpecialType.System_Double => true,
                _ => false,
            };
        }

        private static int GetElementSize(SpecialType specialType)
        {
            return specialType switch
            {
                SpecialType.System_Byte => 1,
                SpecialType.System_SByte => 1,
                SpecialType.System_Int16 => 2,
                SpecialType.System_UInt16 => 2,
                SpecialType.System_Char => 2,
                SpecialType.System_Int32 => 4,
                SpecialType.System_UInt32 => 4,
                SpecialType.System_Single => 4,
                SpecialType.System_Int64 => 8,
                SpecialType.System_UInt64 => 8,
                SpecialType.System_Double => 8,
                _ => 0,
            };
        }

        /// <summary>
        /// Returns a "greater than" comparison expression template with $a and $b placeholders.
        /// </summary>
        private static string GetGreaterThan(string typeName, bool isString)
        {
            if (isString) return "string.CompareOrdinal($a, $b) > 0";
            return "$a > $b";
        }

        /// <summary>
        /// Returns a "less than" comparison expression template with $a and $b placeholders.
        /// </summary>
        private static string GetLessThan(string typeName, bool isString)
        {
            if (isString) return "string.CompareOrdinal($a, $b) < 0";
            return "$a < $b";
        }

        /// <summary>
        /// Returns a "greater than" comparison for named ref variables.
        /// </summary>
        private static string GetGreaterThanForRef(string typeName, bool isString, string a, string b)
        {
            if (isString) return $"string.CompareOrdinal({a}, {b}) > 0";
            return $"{a} > {b}";
        }
    }
}
