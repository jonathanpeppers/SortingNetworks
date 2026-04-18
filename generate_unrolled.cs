/// Generate unrolled sorting network methods for SortingNetworks.
/// Usage: dotnet run generate_unrolled.cs

using System.Text;

// Primitive .NET types to specialize (all sortable primitives)
string[] primitiveTypes =
[
    "byte", "sbyte", "short", "ushort",
    "int", "uint", "long", "ulong",
    "nint", "nuint", "char", "float", "double",
];

// --- Network28 from the paper ---
int[] network28Flat =
[
    0,27, 1,26, 2,25, 3,24, 4,23, 5,22, 6,21, 7,20, 8,9, 10,11, 12,15, 13,14, 16,17, 18,19,
    0,1, 2,3, 4,5, 6,7, 8,10, 9,11, 12,14, 13,15, 16,18, 17,19, 20,21, 22,23, 24,25, 26,27,
    0,2, 1,3, 4,6, 5,7, 8,19, 9,12, 10,14, 11,16, 13,17, 15,18, 20,22, 21,23, 24,26, 25,27,
    0,4, 1,5, 2,20, 3,21, 6,24, 7,25, 8,13, 9,11, 10,17, 12,15, 14,19, 16,18, 22,26, 23,27,
    1,2, 3,24, 4,6, 5,22, 7,20, 8,9, 10,12, 11,13, 14,16, 15,17, 18,19, 21,23, 25,26,
    0,8, 1,4, 2,6, 3,9, 5,7, 10,11, 12,13, 14,15, 16,17, 18,24, 19,27, 20,22, 21,25, 23,26,
    1,10, 2,13, 4,8, 5,12, 6,9, 7,20, 14,25, 15,22, 17,26, 18,21, 19,23,
    3,4, 6,14, 7,11, 8,15, 9,17, 10,18, 12,19, 13,21, 16,20, 23,24,
    2,4, 5,6, 7,8, 9,13, 11,15, 12,16, 14,18, 19,20, 21,22, 23,25,
    2,7, 4,8, 6,10, 9,11, 12,14, 13,15, 16,18, 17,21, 19,23, 20,25,
    1,3, 4,7, 5,6, 8,9, 10,12, 11,16, 13,14, 15,17, 18,19, 20,23, 21,22, 24,26,
    2,3, 4,5, 6,7, 8,10, 9,12, 11,13, 14,16, 15,18, 17,19, 20,21, 22,23, 24,25,
    3,4, 5,6, 7,8, 9,10, 11,12, 13,14, 15,16, 17,18, 19,20, 21,22, 23,24,
];

// --- Main ---

string baseDir = args.Length > 0 ? args[0] : "SortingNetworks";

string apiPath = Path.Combine(baseDir, "NetworkSort.cs");
string apiOutput = GenerateApiFile();
File.WriteAllText(apiPath, apiOutput, new UTF8Encoding(false));
Console.WriteLine($"Generated {apiPath}");

string unrolledPath = Path.Combine(baseDir, "NetworkSort.Unrolled.cs");
string unrolledOutput = GenerateUnrolledFile();
File.WriteAllText(unrolledPath, unrolledOutput, new UTF8Encoding(false));
Console.WriteLine($"Generated {unrolledPath}");

// Print stats
for (int n = 27; n <= 28; n++)
{
    var pairs = GetNetwork(n);
    Console.WriteLine($"  Sort{n}: {pairs.Count} compare-swaps");
}
Console.WriteLine($"  Types: {string.Join(", ", primitiveTypes)}");

// --- Batcher's odd-even merge sort network generator ---

void BatcherSort(int lo, int hi, int n, List<(int A, int B)> pairs)
{
    if (lo >= hi) return;
    int mid = lo + (hi - lo) / 2;
    BatcherSort(lo, mid, n, pairs);
    BatcherSort(mid + 1, hi, n, pairs);
    BatcherMerge(lo, hi, 1, n, pairs);
}

void BatcherMerge(int lo, int hi, int step, int n, List<(int A, int B)> pairs)
{
    int doubleStep = step * 2;
    if (doubleStep > hi - lo)
    {
        if (lo < n && lo + step < n)
            pairs.Add((lo, lo + step));
        return;
    }
    BatcherMerge(lo, hi, doubleStep, n, pairs);
    BatcherMerge(lo + step, hi, doubleStep, n, pairs);
    for (int i = lo + step; i + step <= hi; i += doubleStep)
    {
        if (i < n && i + step < n)
            pairs.Add((i, i + step));
    }
}

List<(int A, int B)> GenerateBatcherNetwork(int n)
{
    int p = 1;
    while (p < n) p <<= 1;
    var pairs = new List<(int A, int B)>();
    BatcherSort(0, p - 1, n, pairs);
    return pairs;
}

List<(int A, int B)> GetNetwork28()
{
    var pairs = new List<(int A, int B)>();
    for (int i = 0; i < network28Flat.Length; i += 2)
        pairs.Add((network28Flat[i], network28Flat[i + 1]));
    return pairs;
}

List<(int A, int B)> GetNetwork27()
{
    var pairs = new List<(int A, int B)>();
    foreach (var (a, b) in GetNetwork28())
    {
        if (a < 27 && b < 27)
            pairs.Add((a, b));
    }
    return pairs;
}

List<(int A, int B)> GetNetwork(int n) => n switch
{
    28 => GetNetwork28(),
    27 => GetNetwork27(),
    _ => GenerateBatcherNetwork(n),
};

// --- Code generation ---

string GenerateUnrolledMethod(int n, List<(int A, int B)> pairs, string typeName)
{
    var lines = new List<string>();
    if (n <= 8)
        lines.Add("    [MethodImpl(MethodImplOptions.AggressiveInlining)]");
    lines.Add($"    private static void Sort{n}(ref {typeName} first)");
    lines.Add("    {");
    lines.Add($"        {typeName} e0 = first;");
    for (int i = 1; i < n; i++)
        lines.Add($"        {typeName} e{i} = Unsafe.Add(ref first, {i});");
    lines.Add("");
    foreach (var (a, b) in pairs)
        lines.Add($"        if (e{a} > e{b}) {{ {typeName} temp = e{a}; e{a} = e{b}; e{b} = temp; }}");
    lines.Add("");
    lines.Add("        first = e0;");
    for (int i = 1; i < n; i++)
        lines.Add($"        Unsafe.Add(ref first, {i}) = e{i};");
    lines.Add("    }");
    return string.Join("\n", lines);
}

string GeneratePublicApi(string typeName)
{
    var lines = new List<string>();

    // Sort(Span<T>)
    lines.Add("    /// <summary>");
    lines.Add($"    /// Sorts a span of {typeName} using a sorting network when possible.");
    lines.Add("    /// </summary>");
    lines.Add($"    public static void Sort(Span<{typeName}> span)");
    lines.Add("    {");
    lines.Add("        int n = span.Length;");
    lines.Add("        if (n == 27 || n == 28)");
    lines.Add("        {");
    lines.Add($"            ref {typeName} first = ref MemoryMarshal.GetReference(span);");
    lines.Add("            if (n == 27)");
    lines.Add("                Sort27(ref first);");
    lines.Add("            else");
    lines.Add("                Sort28(ref first);");
    lines.Add("            return;");
    lines.Add("        }");
    lines.Add("");
    lines.Add("        span.Sort();");
    lines.Add("    }");
    lines.Add("");

    // Sort(T[])
    lines.Add("    /// <summary>");
    lines.Add($"    /// Sorts an array of {typeName} using a sorting network when possible.");
    lines.Add("    /// </summary>");
    lines.Add($"    public static void Sort({typeName}[] array)");
    lines.Add("    {");
    lines.Add("        ArgumentNullException.ThrowIfNull(array);");
    lines.Add("        Sort(array.AsSpan());");
    lines.Add("    }");
    lines.Add("");

    // Sort(Span<T>, IComparer<T>?)
    lines.Add("    /// <summary>");
    lines.Add($"    /// Sorts a span of {typeName} using a sorting network when possible,");
    lines.Add("    /// with a custom comparer.");
    lines.Add("    /// </summary>");
    lines.Add($"    public static void Sort(Span<{typeName}> span, IComparer<{typeName}>? comparer)");
    lines.Add("    {");
    lines.Add($"        comparer ??= Comparer<{typeName}>.Default;");
    lines.Add("        int n = span.Length;");
    lines.Add("        if (n == 27 || n == 28)");
    lines.Add("        {");
    lines.Add("            ApplyNetworkWithComparer(span, NetworkData.GetNetwork(n), comparer);");
    lines.Add("            return;");
    lines.Add("        }");
    lines.Add("");
    lines.Add("        span.Sort(comparer);");
    lines.Add("    }");
    lines.Add("");

    // Sort(T[], IComparer<T>?)
    lines.Add("    /// <summary>");
    lines.Add($"    /// Sorts an array of {typeName} using a sorting network when possible,");
    lines.Add("    /// with a custom comparer.");
    lines.Add("    /// </summary>");
    lines.Add($"    public static void Sort({typeName}[] array, IComparer<{typeName}>? comparer)");
    lines.Add("    {");
    lines.Add("        ArgumentNullException.ThrowIfNull(array);");
    lines.Add("        Sort(array.AsSpan(), comparer);");
    lines.Add("    }");
    lines.Add("");

    // ApplyNetworkWithComparer
    lines.Add("    [MethodImpl(MethodImplOptions.AggressiveInlining)]");
    lines.Add($"    private static void ApplyNetworkWithComparer(Span<{typeName}> span, int[] network, IComparer<{typeName}> comparer)");
    lines.Add("    {");
    lines.Add($"        ref {typeName} first = ref MemoryMarshal.GetReference(span);");
    lines.Add("        for (int i = 0; i < network.Length; i += 2)");
    lines.Add("        {");
    lines.Add($"            ref {typeName} a = ref Unsafe.Add(ref first, network[i]);");
    lines.Add($"            ref {typeName} b = ref Unsafe.Add(ref first, network[i + 1]);");
    lines.Add("            if (comparer.Compare(a, b) > 0)");
    lines.Add("            {");
    lines.Add($"                {typeName} temp = a;");
    lines.Add("                a = b;");
    lines.Add("                b = temp;");
    lines.Add("            }");
    lines.Add("        }");
    lines.Add("    }");

    return string.Join("\n", lines);
}

string GenerateApiFile()
{
    var lines = new List<string>();
    lines.Add("using System.Runtime.CompilerServices;");
    lines.Add("using System.Runtime.InteropServices;");
    lines.Add("");
    lines.Add("namespace SortingNetworks;");
    lines.Add("");
    lines.Add("// <auto-generated>");
    lines.Add("// This file was generated by generate_unrolled.cs");
    lines.Add("// Do not edit manually.");
    lines.Add("// </auto-generated>");
    lines.Add("");
    lines.Add("/// <summary>");
    lines.Add("/// Provides sorting-network-based sorting for small collections.");
    lines.Add("/// Uses fixed compare-and-swap networks for sizes up to 28, including");
    lines.Add("/// depth-13 networks for 27 and 28 channels from arXiv:2511.04107.");
    lines.Add("/// Falls back to the default .NET sort for larger inputs.");
    lines.Add("/// </summary>");
    lines.Add("public static partial class NetworkSort");
    lines.Add("{");

    for (int i = 0; i < primitiveTypes.Length; i++)
    {
        if (i > 0) lines.Add("");
        lines.Add(GeneratePublicApi(primitiveTypes[i]));
    }

    lines.Add("");
    lines.Add("    /// <summary>");
    lines.Add("    /// Sorts an array of <typeparamref name=\"T\"/> using a sorting network when possible.");
    lines.Add("    /// </summary>");
    lines.Add("    public static void Sort<T>(T[] array, IComparer<T> comparer)");
    lines.Add("    {");
    lines.Add("        ArgumentNullException.ThrowIfNull(array);");
    lines.Add("        ArgumentNullException.ThrowIfNull(comparer);");
    lines.Add("        int n = array.Length;");
    lines.Add("        if (n == 27 || n == 28)");
    lines.Add("        {");
    lines.Add("            int[] network = NetworkData.GetNetwork(n);");
    lines.Add("            for (int i = 0; i < network.Length; i += 2)");
    lines.Add("            {");
    lines.Add("                int ai = network[i], bi = network[i + 1];");
    lines.Add("                if (comparer.Compare(array[ai], array[bi]) > 0)");
    lines.Add("                {");
    lines.Add("                    T temp = array[ai];");
    lines.Add("                    array[ai] = array[bi];");
    lines.Add("                    array[bi] = temp;");
    lines.Add("                }");
    lines.Add("            }");
    lines.Add("            return;");
    lines.Add("        }");
    lines.Add("");
    lines.Add("        Array.Sort(array, comparer);");
    lines.Add("    }");

    lines.Add("}");
    lines.Add("");
    return string.Join("\n", lines);
}

string GenerateUnrolledFile()
{
    var lines = new List<string>();
    lines.Add("using System.Runtime.CompilerServices;");
    lines.Add("using System.Runtime.InteropServices;");
    lines.Add("");
    lines.Add("namespace SortingNetworks;");
    lines.Add("");
    lines.Add("// <auto-generated>");
    lines.Add("// This file was generated by generate_unrolled.cs");
    lines.Add("// Do not edit manually.");
    lines.Add("// </auto-generated>");
    lines.Add("");
    lines.Add("public static partial class NetworkSort");
    lines.Add("{");

    bool firstMethod = true;
    foreach (string typeName in primitiveTypes)
    {
        foreach (int n in new[] { 27, 28 })
        {
            var pairs = GetNetwork(n);
            if (!firstMethod) lines.Add("");
            lines.Add(GenerateUnrolledMethod(n, pairs, typeName));
            firstMethod = false;
        }
    }

    lines.Add("}");
    lines.Add("");
    return string.Join("\n", lines);
}
