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
            sb.AppendLine($"        private static void Sort{size}(ref {typeName} first)");
            sb.AppendLine($"        {{");

            // Load elements into local variables — e0 = first, rest use Unsafe.Add
            sb.AppendLine($"            {typeName} e0 = first;");
            for (int i = 1; i < size; i++)
            {
                sb.AppendLine($"            {typeName} e{i} = System.Runtime.CompilerServices.Unsafe.Add(ref first, {i});");
            }
            sb.AppendLine();

            // Emit compare-and-swap for each pair
            for (int i = 0; i < network.Length; i += 2)
            {
                int a = network[i];
                int b = network[i + 1];
                sb.AppendLine($"            if (e{a} > e{b}) {{ {typeName} temp = e{a}; e{a} = e{b}; e{b} = temp; }}");
            }
            sb.AppendLine();

            // Write back
            sb.AppendLine($"            first = e0;");
            for (int i = 1; i < size; i++)
            {
                sb.AppendLine($"            System.Runtime.CompilerServices.Unsafe.Add(ref first, {i}) = e{i};");
            }

            sb.AppendLine($"        }}");
            return sb.ToString();
        }
    }
}
