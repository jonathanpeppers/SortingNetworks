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

// Step sizes from the depth-13 network for 28 channels (arXiv:2511.04107).
int[] network28StepSizes = [14, 14, 14, 14, 13, 14, 11, 10, 10, 10, 12, 12, 11];

// --- Main ---

string baseDir = args.Length > 0 ? args[0] : "SortingNetworks";

string apiPath = Path.Combine(baseDir, "NetworkSort.cs");
using (var w = new StreamWriter(apiPath, false, new UTF8Encoding(false)))
    WriteApiFile(w);
Console.WriteLine($"Generated {apiPath}");

string unrolledPath = Path.Combine(baseDir, "NetworkSort.Unrolled.cs");
using (var w = new StreamWriter(unrolledPath, false, new UTF8Encoding(false)))
    WriteUnrolledFile(w);
Console.WriteLine($"Generated {unrolledPath}");

string simdPath = Path.Combine(baseDir, "NetworkSort.Simd.cs");
using (var w = new StreamWriter(simdPath, false, new UTF8Encoding(false)))
    WriteSimdFile(w);
Console.WriteLine($"Generated {simdPath}");

// Print stats
for (int n = 27; n <= 28; n++)
{
    var pairs = GetNetwork(n);
    var steps = GetNetworkSteps(n);
    Console.WriteLine($"  Sort{n}: {pairs.Count} compare-swaps, {steps.Count} SIMD steps");
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

// --- SIMD helpers ---

List<List<(int A, int B)>> GetNetwork28Steps()
{
    var pairs = GetNetwork28();
    var steps = new List<List<(int A, int B)>>();
    int idx = 0;
    foreach (int size in network28StepSizes)
    {
        var step = pairs.GetRange(idx, size);
        // Validate each step is a disjoint matching (no element in two pairs)
        var used = new HashSet<int>();
        foreach (var (a, b) in step)
            if (!used.Add(a) || !used.Add(b))
                throw new InvalidOperationException($"SIMD step {steps.Count}: pair ({a},{b}) overlaps with another pair.");
        steps.Add(step);
        idx += size;
    }
    if (idx != pairs.Count)
        throw new InvalidOperationException($"network28StepSizes covers {idx} of {pairs.Count} pairs.");
    return steps;
}

List<List<(int A, int B)>> GetNetwork27Steps()
{
    var steps = new List<List<(int A, int B)>>();
    foreach (var step in GetNetwork28Steps())
    {
        var filtered = step.Where(p => p.A < 27 && p.B < 27).ToList();
        if (filtered.Count > 0)
            steps.Add(filtered);
    }
    return steps;
}

List<List<(int A, int B)>> GetNetworkSteps(int n) => n switch
{
    28 => GetNetwork28Steps(),
    27 => GetNetwork27Steps(),
    _ => throw new ArgumentException($"SIMD steps only for n=27,28"),
};

bool StepNeedsCrossLane(List<(int A, int B)> step) =>
    step.Any(p => (p.A < 16) != (p.B < 16));

int[] ComputeShufflePerm(List<(int A, int B)> step)
{
    int[] perm = Enumerable.Range(0, 32).ToArray();
    foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }
    return perm;
}

byte[] ComputeBlendMask(List<(int A, int B)> step)
{
    byte[] blend = new byte[32];
    foreach (var (a, b) in step)
        blend[Math.Max(a, b)] = 0xFF;
    return blend;
}

(byte[] MaskLo, byte[] MaskHi) ComputeCrossLaneMasks(int[] perm)
{
    byte[] maskLo = new byte[32], maskHi = new byte[32];
    for (int i = 0; i < 32; i++)
    {
        int src = perm[i];
        if (src < 16) { maskLo[i] = (byte)src; maskHi[i] = 0x80; }
        else { maskLo[i] = 0x80; maskHi[i] = (byte)(src - 16); }
    }
    return (maskLo, maskHi);
}

byte[] ComputeIntraLaneMask(int[] perm)
{
    byte[] mask = perm.Select(v => (byte)v).ToArray();
    for (int i = 16; i < 32; i++)
        if (mask[i] >= 16) mask[i] -= 16;
    return mask;
}

string FmtVec256(byte[] values) =>
    $"Vector256.Create((byte){string.Join(", ", values.Select(v => $"0x{v:X2}"))})";

string MinExpr(string typeName, string v, string s) => typeName switch
{
    "sbyte" => $"Avx2.Min({v}.AsSByte(), {s}.AsSByte()).AsByte()",
    _ => $"Avx2.Min({v}, {s})",
};

string MaxExpr(string typeName, string v, string s) => typeName switch
{
    "sbyte" => $"Avx2.Max({v}.AsSByte(), {s}.AsSByte()).AsByte()",
    _ => $"Avx2.Max({v}, {s})",
};

// --- Code generation ---

void WriteFileHeader(StreamWriter w)
{
    w.Write("""
        using System.Runtime.CompilerServices;
        using System.Runtime.InteropServices;

        namespace SortingNetworks;

        // <auto-generated>
        // This file was generated by generate_unrolled.cs
        // Do not edit manually.
        // </auto-generated>


        """);
}

void WriteUnrolledMethod(StreamWriter w, int n, List<(int A, int B)> pairs, string typeName)
{
    if (n <= 8)
        w.WriteLine("    [MethodImpl(MethodImplOptions.AggressiveInlining)]");
    w.WriteLine($"    private static void Sort{n}(ref {typeName} first)");
    w.WriteLine("    {");
    w.WriteLine($"        {typeName} e0 = first;");
    for (int i = 1; i < n; i++)
        w.WriteLine($"        {typeName} e{i} = Unsafe.Add(ref first, {i});");
    w.WriteLine();
    foreach (var (a, b) in pairs)
    {
        if (typeName == "string")
            w.WriteLine($"        if (string.CompareOrdinal(e{a}, e{b}) > 0) {{ {typeName} temp = e{a}; e{a} = e{b}; e{b} = temp; }}");
        else
            w.WriteLine($"        if (e{a} > e{b}) {{ {typeName} temp = e{a}; e{a} = e{b}; e{b} = temp; }}");
    }
    w.WriteLine();
    w.WriteLine("        first = e0;");
    for (int i = 1; i < n; i++)
        w.WriteLine($"        Unsafe.Add(ref first, {i}) = e{i};");
    w.WriteLine("    }");
}

void WriteSimdSortMethod(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int loadOffset = n - 16;
    int shiftAmount = 32 - n;
    string suffix = typeName != "byte" ? $"_{typeName}" : "";
    string refCast = typeName == "sbyte"
        ? $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));"
        : "ref byte first = ref MemoryMarshal.GetReference(span);";

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        {refCast}");
    w.WriteLine("        var lo = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);");
    w.WriteLine("        var hi = Sse2.ShiftRightLogical128BitLane(");
    w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {loadOffset})),");
    w.WriteLine($"            {shiftAmount});");
    w.WriteLine("        var vec = Vector256.Create(lo, hi);");

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        var perm = ComputeShufflePerm(step);
        var blend = ComputeBlendMask(step);
        bool cross = StepNeedsCrossLane(step);
        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");

        if (cross)
        {
            var (maskLo, maskHi) = ComputeCrossLaneMasks(perm);
            w.WriteLine("        {");
            w.WriteLine("            var loLo = Avx2.Permute2x128(vec, vec, 0x00);");
            w.WriteLine("            var hiHi = Avx2.Permute2x128(vec, vec, 0x11);");
            w.WriteLine($"            var fromLo = Avx2.Shuffle(loLo, {FmtVec256(maskLo)});");
            w.WriteLine($"            var fromHi = Avx2.Shuffle(hiHi, {FmtVec256(maskHi)});");
            w.WriteLine("            var shuffled = Avx2.Or(fromLo, fromHi);");
            w.WriteLine($"            var mins = {MinExpr(typeName, "vec", "shuffled")};");
            w.WriteLine($"            var maxs = {MaxExpr(typeName, "vec", "shuffled")};");
            w.WriteLine($"            vec = Avx2.BlendVariable(mins, maxs, {FmtVec256(blend)});");
            w.WriteLine("        }");
        }
        else
        {
            var mask = ComputeIntraLaneMask(perm);
            w.WriteLine("        {");
            w.WriteLine($"            var shuffled = Avx2.Shuffle(vec, {FmtVec256(mask)});");
            w.WriteLine($"            var mins = {MinExpr(typeName, "vec", "shuffled")};");
            w.WriteLine($"            var maxs = {MaxExpr(typeName, "vec", "shuffled")};");
            w.WriteLine($"            vec = Avx2.BlendVariable(mins, maxs, {FmtVec256(blend)});");
            w.WriteLine("        }");
        }
    }

    w.WriteLine();
    w.WriteLine("        lo = vec.GetLower();");
    w.WriteLine("        hi = vec.GetUpper();");
    w.WriteLine($"        Sse2.ShiftLeftLogical128BitLane(hi, {shiftAmount})");
    w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {loadOffset}));");
    w.WriteLine("        lo.StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteSimdFile(StreamWriter w)
{
    w.Write("""
        using System.Runtime.CompilerServices;
        using System.Runtime.InteropServices;
        using System.Runtime.Intrinsics;
        using System.Runtime.Intrinsics.X86;

        namespace SortingNetworks;

        // <auto-generated>
        // This file was generated by generate_unrolled.cs
        // Do not edit manually.
        // </auto-generated>

        public static partial class NetworkSort
        {

        """);

    bool first = true;
    foreach (string typeName in new[] { "byte", "sbyte" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            if (!first) w.WriteLine();
            WriteSimdSortMethod(w, n, steps, typeName);
            first = false;
        }
    }

    w.WriteLine("}");
}

void WritePublicApi(StreamWriter w, string t)
{
    string suffix = t != "byte" ? $"_{t}" : "";
    bool hasSimd = t == "byte" || t == "sbyte";

    w.WriteLine("    /// <summary>");
    w.WriteLine($"    /// Sorts a span of {t} using a sorting network when possible.");
    w.WriteLine("    /// </summary>");
    w.WriteLine($"    public static void Sort(Span<{t}> span)");
    w.WriteLine("    {");
    w.WriteLine("        int n = span.Length;");
    w.WriteLine("        if (n == 27 || n == 28)");
    w.WriteLine("        {");
    if (hasSimd)
    {
        w.WriteLine("            if (Avx2.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimd27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimd28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
    }
    w.WriteLine($"            ref {t} first = ref MemoryMarshal.GetReference(span);");
    w.WriteLine("            if (n == 27)");
    w.WriteLine("                Sort27(ref first);");
    w.WriteLine("            else");
    w.WriteLine("                Sort28(ref first);");
    w.WriteLine("            return;");
    w.WriteLine("        }");
    w.WriteLine();
    w.WriteLine("        span.Sort();");
    w.WriteLine("    }");
    w.WriteLine();
    w.Write($$"""
            /// <summary>
            /// Sorts an array of {{t}} using a sorting network when possible.
            /// </summary>
            public static void Sort({{t}}[] array)
            {
                ArgumentNullException.ThrowIfNull(array);
                Sort(array.AsSpan());
            }

            /// <summary>
            /// Sorts a span of {{t}} using a sorting network when possible,
            /// with a custom comparer.
            /// </summary>
            public static void Sort(Span<{{t}}> span, IComparer<{{t}}>? comparer)
            {
                comparer ??= Comparer<{{t}}>.Default;
                int n = span.Length;
                if (n == 27 || n == 28)
                {
                    ApplyNetworkWithComparer(span, NetworkData.GetNetwork(n), comparer);
                    return;
                }

                span.Sort(comparer);
            }

            /// <summary>
            /// Sorts an array of {{t}} using a sorting network when possible,
            /// with a custom comparer.
            /// </summary>
            public static void Sort({{t}}[] array, IComparer<{{t}}>? comparer)
            {
                ArgumentNullException.ThrowIfNull(array);
                Sort(array.AsSpan(), comparer);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void ApplyNetworkWithComparer(Span<{{t}}> span, int[] network, IComparer<{{t}}> comparer)
            {
                ref {{t}} first = ref MemoryMarshal.GetReference(span);
                for (int i = 0; i < network.Length; i += 2)
                {
                    ref {{t}} a = ref Unsafe.Add(ref first, network[i]);
                    ref {{t}} b = ref Unsafe.Add(ref first, network[i + 1]);
                    if (comparer.Compare(a, b) > 0)
                    {
                        {{t}} temp = a;
                        a = b;
                        b = temp;
                    }
                }
            }

        """);
}

void WriteStringApi(StreamWriter w)
{
    w.Write("""
            /// <summary>
            /// Sorts a span of string using a sorting network when possible.
            /// Uses ordinal comparison for maximum performance.
            /// </summary>
            public static void Sort(Span<string> span)
            {
                int n = span.Length;
                if (n == 27 || n == 28)
                {
                    ref string first = ref MemoryMarshal.GetReference(span);
                    if (n == 27)
                        Sort27(ref first);
                    else
                        Sort28(ref first);
                    return;
                }

                span.Sort(StringComparer.Ordinal);
            }

            /// <summary>
            /// Sorts an array of string using a sorting network when possible.
            /// Uses ordinal comparison for maximum performance.
            /// </summary>
            public static void Sort(string[] array)
            {
                ArgumentNullException.ThrowIfNull(array);
                Sort(array.AsSpan());
            }

            /// <summary>
            /// Sorts a span of string using a sorting network when possible,
            /// with a custom comparer.
            /// </summary>
            public static void Sort(Span<string> span, IComparer<string>? comparer)
            {
                comparer ??= Comparer<string>.Default;
                int n = span.Length;
                if (n == 27 || n == 28)
                {
                    ApplyNetworkWithComparer(span, NetworkData.GetNetwork(n), comparer);
                    return;
                }

                span.Sort(comparer);
            }

            /// <summary>
            /// Sorts an array of string using a sorting network when possible,
            /// with a custom comparer.
            /// </summary>
            public static void Sort(string[] array, IComparer<string>? comparer)
            {
                ArgumentNullException.ThrowIfNull(array);
                Sort(array.AsSpan(), comparer);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void ApplyNetworkWithComparer(Span<string> span, int[] network, IComparer<string> comparer)
            {
                ref string first = ref MemoryMarshal.GetReference(span);
                for (int i = 0; i < network.Length; i += 2)
                {
                    ref string a = ref Unsafe.Add(ref first, network[i]);
                    ref string b = ref Unsafe.Add(ref first, network[i + 1]);
                    if (comparer.Compare(a, b) > 0)
                    {
                        string temp = a;
                        a = b;
                        b = temp;
                    }
                }
            }

        """);
}

void WriteGenericSortT(StreamWriter w)
{
    w.Write("""
            /// <summary>
            /// Sorts an array of <typeparamref name="T"/> using a sorting network when possible.
            /// </summary>
            public static void Sort<T>(T[] array, IComparer<T> comparer)
            {
                ArgumentNullException.ThrowIfNull(array);
                ArgumentNullException.ThrowIfNull(comparer);
                int n = array.Length;
                if (n == 27 || n == 28)
                {
                    int[] network = NetworkData.GetNetwork(n);
                    for (int i = 0; i < network.Length; i += 2)
                    {
                        int ai = network[i], bi = network[i + 1];
                        if (comparer.Compare(array[ai], array[bi]) > 0)
                        {
                            T temp = array[ai];
                            array[ai] = array[bi];
                            array[bi] = temp;
                        }
                    }
                    return;
                }

                Array.Sort(array, comparer);
            }

        """);
}

void WriteApiFile(StreamWriter w)
{
    w.Write("""
        using System.Runtime.CompilerServices;
        using System.Runtime.InteropServices;
        using System.Runtime.Intrinsics.X86;

        namespace SortingNetworks;

        // <auto-generated>
        // This file was generated by generate_unrolled.cs
        // Do not edit manually.
        // </auto-generated>

        /// <summary>
        /// Provides sorting-network-based sorting for small collections.
        /// Uses fixed compare-and-swap networks for sizes up to 28, including
        /// depth-13 networks for 27 and 28 channels from arXiv:2511.04107.
        /// Falls back to the default .NET sort for larger inputs.
        /// </summary>
        public static partial class NetworkSort
        {

        """);

    for (int i = 0; i < primitiveTypes.Length; i++)
    {
        if (i > 0) w.WriteLine();
        WritePublicApi(w, primitiveTypes[i]);
    }

    w.WriteLine();
    WriteStringApi(w);

    w.WriteLine();
    WriteGenericSortT(w);

    w.WriteLine("}");
}

void WriteUnrolledFile(StreamWriter w)
{
    WriteFileHeader(w);
    w.WriteLine("public static partial class NetworkSort");
    w.WriteLine("{");

    bool firstMethod = true;
    foreach (string typeName in primitiveTypes.Concat(["string"]))
    {
        foreach (int n in new[] { 27, 28 })
        {
            var pairs = GetNetwork(n);
            if (!firstMethod) w.WriteLine();
            WriteUnrolledMethod(w, n, pairs, typeName);
            firstMethod = false;
        }
    }

    w.WriteLine("}");
}
