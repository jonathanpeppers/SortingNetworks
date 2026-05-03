using System.Text;
using Microsoft.CodeAnalysis;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Emits unrolled scalar sorting code for a given network size and element type.
    /// Uses ref + Unsafe.Add for element access. For numeric types with
    /// System.Math.Min/Max overloads:
    /// - Default (branchless=null): emits a runtime X86Base.IsSupported check with
    ///   branchless min/max on x86 and branching if/swap elsewhere.
    /// - Branchless=true: emits only Math.Min/Max swaps.
    /// - Branchless=false: emits only branching if/swap.
    /// For char, string, and custom types, always emits branching if/swap.
    /// </summary>
    internal static class ScalarEmitter
    {
        /// <summary>
        /// Returns true if the given <see cref="SpecialType"/> has direct
        /// System.Math.Min/Max overloads suitable for branchless emission.
        /// Excludes char/nint/nuint (no Math.Min/Max overloads).
        /// Float/double are included — NaN is unsupported (see issues #10, #11).
        /// </summary>
        internal static bool SupportsBranchlessMinMax(SpecialType specialType) => specialType switch
        {
            SpecialType.System_Byte => true,
            SpecialType.System_SByte => true,
            SpecialType.System_Int16 => true,
            SpecialType.System_UInt16 => true,
            SpecialType.System_Int32 => true,
            SpecialType.System_UInt32 => true,
            SpecialType.System_Int64 => true,
            SpecialType.System_UInt64 => true,
            SpecialType.System_Single => true,
            SpecialType.System_Double => true,
            _ => false,
        };

        /// <summary>
        /// Emits a scalar Sort method for the given network size and element type.
        /// <paramref name="branchless"/>: null = auto (runtime platform check), true = force branchless, false = force branching.
        /// </summary>
        internal static string EmitSortMethod(int size, string typeName, SpecialType specialType, int[] network, bool useCompareTo = false, bool? branchless = null)
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

            // Determine swap strategy
            bool isString = typeName == "string";
            bool canUseMathMinMax = !useCompareTo && !isString && SupportsBranchlessMinMax(specialType);

            if (canUseMathMinMax && branchless == true)
            {
                // Force branchless: Math.Min/Max only
                EmitComparators(sb, network, typeName, branchless: true, indent: "            ");
            }
            else if (canUseMathMinMax && branchless != false)
            {
                // Auto-detect (branchless == null): emit runtime platform check
                // The JIT treats X86Base.IsSupported as a constant and dead-code-eliminates the unused branch
                sb.AppendLine("            if (System.Runtime.Intrinsics.X86.X86Base.IsSupported)");
                sb.AppendLine("            {");
                EmitComparators(sb, network, typeName, branchless: true, indent: "                ");
                sb.AppendLine("            }");
                sb.AppendLine("            else");
                sb.AppendLine("            {");
                EmitComparators(sb, network, typeName, branchless: false, indent: "                ");
                sb.AppendLine("            }");
            }
            else
            {
                // Force branching, or type doesn't support Math.Min/Max
                EmitComparators(sb, network, typeName, branchless: false, indent: "            ",
                    useCompareTo: useCompareTo, isString: isString);
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

        private static void EmitComparators(StringBuilder sb, int[] network, string typeName, bool branchless, string indent, bool useCompareTo = false, bool isString = false)
        {
            for (int i = 0; i < network.Length; i += 2)
            {
                int a = network[i];
                int b = network[i + 1];
                if (branchless)
                {
                    sb.AppendLine($"{indent}{{ {typeName} t0 = System.Math.Min(e{a}, e{b}); {typeName} t1 = System.Math.Max(e{a}, e{b}); e{a} = t0; e{b} = t1; }}");
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
                    sb.AppendLine($"{indent}if ({condition}) {{ {typeName} temp = e{a}; e{a} = e{b}; e{b} = temp; }}");
                }
            }
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
