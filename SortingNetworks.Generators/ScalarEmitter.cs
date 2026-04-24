using System.Text;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Emits unrolled scalar compare-and-swap sorting network code.
    /// Follows the same patterns as the existing NetworkSort.Unrolled.cs:
    /// uses ref + Unsafe.Add for element access, inline compare-and-swap.
    /// </summary>
    internal static class ScalarEmitter
    {
        /// <summary>
        /// Emits a scalar Sort method for the given network size and element type.
        /// </summary>
        internal static string EmitSortMethod(int size, string typeName, int[] network)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]");
            sb.AppendLine($"        private static void SortScalar{size}(System.Span<{typeName}> span)");
            sb.AppendLine($"        {{");
            sb.AppendLine($"            ref {typeName} first = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");

            // Load elements into local variables
            for (int i = 0; i < size; i++)
            {
                sb.AppendLine($"            {typeName} e{i} = System.Runtime.CompilerServices.Unsafe.Add(ref first, {i});");
            }
            sb.AppendLine();

            // Emit compare-and-swap for each pair
            for (int i = 0; i < network.Length; i += 2)
            {
                int a = network[i];
                int b = network[i + 1];
                sb.AppendLine($"            if (e{a} > e{b}) {{ {typeName} t = e{a}; e{a} = e{b}; e{b} = t; }}");
            }
            sb.AppendLine();

            // Write back
            for (int i = 0; i < size; i++)
            {
                sb.AppendLine($"            System.Runtime.CompilerServices.Unsafe.Add(ref first, {i}) = e{i};");
            }

            sb.AppendLine($"        }}");
            return sb.ToString();
        }
    }
}
