using System.Collections.Generic;
using System.Text;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Emits unrolled scalar compare-and-swap sorting network code.
    /// Emits unrolled scalar sorting code for a given network size and element type.
    /// uses ref + Unsafe.Add for element access, inline compare-and-swap.
    /// </summary>
    internal static class ScalarEmitter
    {
        /// <summary>
        /// Types that have direct System.Math.Min/Max overloads.
        /// The JIT lowers these to branchless cmov instructions on x64.
        /// </summary>
        private static readonly HashSet<string> MathMinMaxTypes = new HashSet<string>
        {
            "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double"
        };

        /// <summary>
        /// Emits a scalar Sort method for the given network size and element type.
        /// </summary>
        internal static string EmitSortMethod(int size, string typeName, int[] network, bool useCompareTo = false)
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
            bool isString = typeName == "string";
            bool useMathMinMax = !useCompareTo && !isString && MathMinMaxTypes.Contains(typeName);
            for (int i = 0; i < network.Length; i += 2)
            {
                int a = network[i];
                int b = network[i + 1];
                if (useMathMinMax)
                {
                    // Branchless: Math.Min/Max → JIT emits cmov on x64
                    sb.AppendLine($"            {{ {typeName} t0 = System.Math.Min(e{a}, e{b}); {typeName} t1 = System.Math.Max(e{a}, e{b}); e{a} = t0; e{b} = t1; }}");
                }
                else
                {
                    string condition;
                    if (useCompareTo)
                        condition = $"e{a}.CompareTo(e{b}) > 0";
                    else if (isString)
                        condition = $"string.CompareOrdinal(e{a}, e{b}) > 0";
                    else
                        condition = $"e{a} > e{b}";
                    sb.AppendLine($"            if ({condition}) {{ {typeName} temp = e{a}; e{a} = e{b}; e{b} = temp; }}");
                }
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

        /// <summary>
        /// Emits a static readonly int[] field containing the network comparator pairs for a given size.
        /// </summary>
        internal static string EmitNetworkDataField(int size, int[] network)
        {
            var sb = new StringBuilder();
            sb.Append($"        private static readonly int[] Network{size} = new int[] {{ ");
            for (int i = 0; i < network.Length; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(network[i]);
            }
            sb.AppendLine(" };");
            return sb.ToString();
        }

        /// <summary>
        /// Emits a private ApplyNetworkWithComparer method for the given element type.
        /// Uses a loop-based pattern to apply the network with a comparer.
        /// </summary>
        internal static string EmitApplyNetworkWithComparer(string typeName)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]");
            sb.AppendLine($"        private static void ApplyNetworkWithComparer(System.Span<{typeName}> span, int[] network, System.Collections.Generic.IComparer<{typeName}> comparer)");
            sb.AppendLine($"        {{");
            sb.AppendLine($"            ref {typeName} first = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");
            sb.AppendLine($"            for (int i = 0; i < network.Length; i += 2)");
            sb.AppendLine($"            {{");
            sb.AppendLine($"                ref {typeName} a = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, network[i]);");
            sb.AppendLine($"                ref {typeName} b = ref System.Runtime.CompilerServices.Unsafe.Add(ref first, network[i + 1]);");
            sb.AppendLine($"                if (comparer.Compare(a, b) > 0)");
            sb.AppendLine($"                {{");
            sb.AppendLine($"                    {typeName} temp = a;");
            sb.AppendLine($"                    a = b;");
            sb.AppendLine($"                    b = temp;");
            sb.AppendLine($"                }}");
            sb.AppendLine($"            }}");
            sb.AppendLine($"        }}");
            return sb.ToString();
        }
    }
}
