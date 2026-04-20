/// Generate unrolled sorting network methods for SortingNetworks.
/// Usage: dotnet run scripts/generate_unrolled.cs

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

string armSimdPath = Path.Combine(baseDir, "NetworkSort.Simd.Arm.cs");
using (var w = new StreamWriter(armSimdPath, false, new UTF8Encoding(false)))
    WriteArmSimdFile(w);
Console.WriteLine($"Generated {armSimdPath}");

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

// --- Format helpers ---

string FmtVec128(byte[] values) =>
    $"Vector128.Create((byte){string.Join(", ", values.Select(v => $"0x{v:X2}"))})";

byte[] BlendLo(byte[] blend) => blend[..16];
byte[] BlendHi(byte[] blend) => blend[16..];

// --- Unified cross-platform helpers ---

byte[] ComputeFullPerm256(int[] perm) =>
    perm.Select(v => (byte)v).ToArray();

(byte[] FromLo, byte[] FromHi) SplitShuffle128(int[] perm, int halfOffset)
{
    byte[] fromLo = new byte[16], fromHi = new byte[16];
    for (int i = 0; i < 16; i++)
    {
        int src = perm[i + halfOffset];
        if (src < 16) { fromLo[i] = (byte)src; fromHi[i] = 0x80; }
        else { fromLo[i] = 0x80; fromHi[i] = (byte)(src - 16); }
    }
    return (fromLo, fromHi);
}

bool Shuffle128NeedsCross(int[] perm, int halfOffset)
{
    for (int i = 0; i < 16; i++)
    {
        int src = perm[i + halfOffset];
        int halfSrc = src < 16 ? 0 : 1;
        int halfDst = halfOffset < 16 ? 0 : 1;
        if (halfSrc != halfDst) return true;
    }
    return false;
}

byte[] ComputeShiftRightMask(int shiftAmount)
{
    byte[] mask = new byte[16];
    for (int i = 0; i < 16; i++)
    {
        int src = i + shiftAmount;
        mask[i] = src < 16 ? (byte)src : (byte)0x80;
    }
    return mask;
}

byte[] ComputeShiftLeftMask(int shiftAmount)
{
    byte[] mask = new byte[16];
    for (int i = 0; i < 16; i++)
    {
        int src = i - shiftAmount;
        mask[i] = src >= 0 ? (byte)src : (byte)0x80;
    }
    return mask;
}

string UnifiedMinExpr256(string typeName, string v, string s) => typeName switch
{
    "sbyte" => $"Vector256.Min({v}.AsSByte(), {s}.AsSByte()).AsByte()",
    _ => $"Vector256.Min({v}, {s})",
};

string UnifiedMaxExpr256(string typeName, string v, string s) => typeName switch
{
    "sbyte" => $"Vector256.Max({v}.AsSByte(), {s}.AsSByte()).AsByte()",
    _ => $"Vector256.Max({v}, {s})",
};

string UnifiedMinExpr128(string typeName, string v, string s) => typeName switch
{
    "sbyte" => $"Vector128.Min({v}.AsSByte(), {s}.AsSByte()).AsByte()",
    _ => $"Vector128.Min({v}, {s})",
};

string UnifiedMaxExpr128(string typeName, string v, string s) => typeName switch
{
    "sbyte" => $"Vector128.Max({v}.AsSByte(), {s}.AsSByte()).AsByte()",
    _ => $"Vector128.Max({v}, {s})",
};

string ArmMinExpr16(string typeName, string v, string s) => typeName switch
{
    "short" => $"AdvSimd.Min({v}.AsInt16(), {s}.AsInt16()).AsByte()",
    _ => $"AdvSimd.Min({v}.AsUInt16(), {s}.AsUInt16()).AsByte()",
};

string ArmMaxExpr16(string typeName, string v, string s) => typeName switch
{
    "short" => $"AdvSimd.Max({v}.AsInt16(), {s}.AsInt16()).AsByte()",
    _ => $"AdvSimd.Max({v}.AsUInt16(), {s}.AsUInt16()).AsByte()",
};

string ArmMinExpr32(string typeName, string v, string s) => typeName switch
{
    "int" => $"AdvSimd.Min({v}.AsInt32(), {s}.AsInt32()).AsByte()",
    "uint" => $"AdvSimd.Min({v}.AsUInt32(), {s}.AsUInt32()).AsByte()",
    _ => $"AdvSimd.Min({v}.AsSingle(), {s}.AsSingle()).AsByte()",
};

string ArmMaxExpr32(string typeName, string v, string s) => typeName switch
{
    "int" => $"AdvSimd.Max({v}.AsInt32(), {s}.AsInt32()).AsByte()",
    "uint" => $"AdvSimd.Max({v}.AsUInt32(), {s}.AsUInt32()).AsByte()",
    _ => $"AdvSimd.Max({v}.AsSingle(), {s}.AsSingle()).AsByte()",
};

string FmtVec256(byte[] values) =>
    $"Vector256.Create((byte){string.Join(", ", values.Select(v => $"0x{v:X2}"))})";

string FmtVec512_UShort(ushort[] values) =>
    $"Vector512.Create((ushort){string.Join(", ", values.Select(v => $"0x{v:X4}"))})";

string FmtVec512_Long(long[] values) =>
    $"Vector512.Create({string.Join(", ", values.Select(v => $"{v}L"))})";

string MinExpr16(string typeName, string v, string s) => typeName switch
{
    "short" => $"Avx512BW.Min({v}.AsInt16(), {s}.AsInt16()).AsUInt16()",
    _ => $"Avx512BW.Min({v}, {s})",
};

string MaxExpr16(string typeName, string v, string s) => typeName switch
{
    "short" => $"Avx512BW.Max({v}.AsInt16(), {s}.AsInt16()).AsUInt16()",
    _ => $"Avx512BW.Max({v}, {s})",
};

string FmtVec256_Int(int[] values) =>
    $"Vector256.Create({string.Join(", ", values)})";

string FmtVec256_Long(long[] values) =>
    $"Vector256.Create({string.Join(", ", values.Select(v => $"{v}L"))})";

string MinExpr32(string typeName, string v, string s) => typeName switch
{
    "uint" => $"Avx2.Min({v}.AsUInt32(), {s}.AsUInt32()).AsInt32()",
    _ => $"Avx2.Min({v}, {s})",
};

string MaxExpr32(string typeName, string v, string s) => typeName switch
{
    "uint" => $"Avx2.Max({v}.AsUInt32(), {s}.AsUInt32()).AsInt32()",
    _ => $"Avx2.Max({v}, {s})",
};

string FmtVec512_Int(int[] values) =>
    $"Vector512.Create({string.Join(", ", values)})";

string MinExpr32_512(string typeName, string v, string s) => typeName switch
{
    "int" => $"Avx512F.Min({v}, {s})",
    "uint" => $"Avx512F.Min({v}.AsUInt32(), {s}.AsUInt32()).AsInt32()",
    "float" => $"Avx512F.Min({v}.AsSingle(), {s}.AsSingle()).AsInt32()",
    _ => throw new ArgumentException($"Unsupported 32-bit type: {typeName}"),
};

string MaxExpr32_512(string typeName, string v, string s) => typeName switch
{
    "int" => $"Avx512F.Max({v}, {s})",
    "uint" => $"Avx512F.Max({v}.AsUInt32(), {s}.AsUInt32()).AsInt32()",
    "float" => $"Avx512F.Max({v}.AsSingle(), {s}.AsSingle()).AsInt32()",
    _ => throw new ArgumentException($"Unsupported 32-bit type: {typeName}"),
};

string MinExpr64(string typeName, string v, string s) => typeName switch
{
    "long" => $"Avx512F.Min({v}, {s})",
    "ulong" => $"Avx512F.Min({v}.AsUInt64(), {s}.AsUInt64()).AsInt64()",
    _ => throw new ArgumentException($"Unsupported 64-bit type: {typeName}"),
};

string MaxExpr64(string typeName, string v, string s) => typeName switch
{
    "long" => $"Avx512F.Max({v}, {s})",
    "ulong" => $"Avx512F.Max({v}.AsUInt64(), {s}.AsUInt64()).AsInt64()",
    _ => throw new ArgumentException($"Unsupported 64-bit type: {typeName}"),
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

void WriteUnifiedByteSortMethod256(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int loadOffset = n - 16;
    int shiftAmount = 32 - n;
    string suffix = typeName != "byte" ? $"_{typeName}" : "";
    string refCast = typeName == "sbyte"
        ? $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));"
        : "ref byte first = ref MemoryMarshal.GetReference(span);";

    var shiftRightMask = ComputeShiftRightMask(shiftAmount);
    var shiftLeftMask = ComputeShiftLeftMask(shiftAmount);

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        {refCast}");
    w.WriteLine("        var lo = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);");
    w.WriteLine($"        var hi = Vector128.Shuffle(");
    w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {loadOffset})),");
    w.WriteLine($"            {FmtVec128(shiftRightMask)});");
    w.WriteLine("        var vec = Vector256.Create(lo, hi);");

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        var perm = ComputeShufflePerm(step);
        var blend = ComputeBlendMask(step);
        var fullPerm = ComputeFullPerm256(perm);
        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");
        w.WriteLine($"            var shuffled = Vector256.Shuffle(vec, {FmtVec256(fullPerm)});");
        w.WriteLine($"            var mins = {UnifiedMinExpr256(typeName, "vec", "shuffled")};");
        w.WriteLine($"            var maxs = {UnifiedMaxExpr256(typeName, "vec", "shuffled")};");
        w.WriteLine($"            vec = Vector256.ConditionalSelect({FmtVec256(blend)}, maxs, mins);");
        w.WriteLine("        }");
    }

    w.WriteLine();
    w.WriteLine("        lo = vec.GetLower();");
    w.WriteLine("        hi = vec.GetUpper();");
    w.WriteLine($"        Vector128.Shuffle(hi, {FmtVec128(shiftLeftMask)})");
    w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {loadOffset}));");
    w.WriteLine("        lo.StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteUnifiedByteSortMethod128(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int loadOffset = n - 16;
    int shiftAmount = 32 - n;
    string suffix = typeName != "byte" ? $"_{typeName}" : "";
    string refCast = typeName == "sbyte"
        ? $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));"
        : "ref byte first = ref MemoryMarshal.GetReference(span);";

    var shiftRightMask = ComputeShiftRightMask(shiftAmount);
    var shiftLeftMask = ComputeShiftLeftMask(shiftAmount);

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd128_{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        {refCast}");
    w.WriteLine("        var vecLo = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);");
    w.WriteLine($"        var vecHi = Vector128.Shuffle(");
    w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {loadOffset})),");
    w.WriteLine($"            {FmtVec128(shiftRightMask)});");

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        var perm = ComputeShufflePerm(step);
        var blend = ComputeBlendMask(step);
        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        var (loFromLo, loFromHi) = SplitShuffle128(perm, 0);
        var (hiFromLo, hiFromHi) = SplitShuffle128(perm, 16);
        bool loCross = Shuffle128NeedsCross(perm, 0);
        bool hiCross = Shuffle128NeedsCross(perm, 16);

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");

        if (loCross)
        {
            w.WriteLine($"            var shuffledLo = Vector128.Shuffle(vecLo, {FmtVec128(loFromLo)}) | Vector128.Shuffle(vecHi, {FmtVec128(loFromHi)});");
        }
        else
        {
            w.WriteLine($"            var shuffledLo = Vector128.Shuffle(vecLo, {FmtVec128(loFromLo)});");
        }

        if (hiCross)
        {
            w.WriteLine($"            var shuffledHi = Vector128.Shuffle(vecLo, {FmtVec128(hiFromLo)}) | Vector128.Shuffle(vecHi, {FmtVec128(hiFromHi)});");
        }
        else
        {
            w.WriteLine($"            var shuffledHi = Vector128.Shuffle(vecHi, {FmtVec128(hiFromHi)});");
        }

        w.WriteLine($"            var minsLo = {UnifiedMinExpr128(typeName, "vecLo", "shuffledLo")};");
        w.WriteLine($"            var maxsLo = {UnifiedMaxExpr128(typeName, "vecLo", "shuffledLo")};");
        w.WriteLine($"            var minsHi = {UnifiedMinExpr128(typeName, "vecHi", "shuffledHi")};");
        w.WriteLine($"            var maxsHi = {UnifiedMaxExpr128(typeName, "vecHi", "shuffledHi")};");
        w.WriteLine($"            vecLo = Vector128.ConditionalSelect({FmtVec128(BlendLo(blend))}, maxsLo, minsLo);");
        w.WriteLine($"            vecHi = Vector128.ConditionalSelect({FmtVec128(BlendHi(blend))}, maxsHi, minsHi);");
        w.WriteLine("        }");
    }

    w.WriteLine();
    w.WriteLine($"        Vector128.Shuffle(vecHi, {FmtVec128(shiftLeftMask)})");
    w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {loadOffset}));");
    w.WriteLine("        vecLo.StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteSimdSortMethod16(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int v3ReadOffset = (n - 8) * 2;
    int v3ShiftBytes = (32 - n) * 2;
    string suffix = $"_{typeName}";
    string refCast = $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));";

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        {refCast}");
    w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);");
    w.WriteLine("        var v1 = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, 16));");
    w.WriteLine("        var v2 = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, 32));");
    w.WriteLine($"        var v3 = Sse2.ShiftRightLogical128BitLane(");
    w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {v3ReadOffset})),");
    w.WriteLine($"            {v3ShiftBytes});");
    w.WriteLine("        var vec = Vector512.Create(Vector256.Create(v0, v1), Vector256.Create(v2, v3)).AsUInt16();");

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        ushort[] perm = new ushort[32];
        for (int i = 0; i < 32; i++) perm[i] = (ushort)i;
        foreach (var (a, b) in step) { perm[a] = (ushort)b; perm[b] = (ushort)a; }

        ushort[] blend = new ushort[32];
        foreach (var (a, b) in step)
            blend[Math.Max(a, b)] = 0xFFFF;

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");
        w.WriteLine($"            var shuffled = Avx512BW.PermuteVar32x16(vec, {FmtVec512_UShort(perm)});");
        w.WriteLine($"            var mins = {MinExpr16(typeName, "vec", "shuffled")};");
        w.WriteLine($"            var maxs = {MaxExpr16(typeName, "vec", "shuffled")};");
        w.WriteLine($"            vec = Vector512.ConditionalSelect({FmtVec512_UShort(blend)}, maxs, mins);");
        w.WriteLine("        }");
    }

    w.WriteLine();
    w.WriteLine("        var result = vec.AsByte();");
    w.WriteLine("        var lo256 = result.GetLower();");
    w.WriteLine("        var hi256 = result.GetUpper();");
    w.WriteLine("        var hiLo = hi256.GetLower();");
    w.WriteLine("        var hiHi = hi256.GetUpper();");
    w.WriteLine($"        Sse2.ShiftLeftLogical128BitLane(hiHi, {v3ShiftBytes})");
    w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {v3ReadOffset}));");
    w.WriteLine("        hiLo.StoreUnsafe(ref Unsafe.Add(ref first, 32));");
    w.WriteLine("        lo256.StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteSimdSortMethod32_Avx2(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int v3ReadOffset = (n - 4) * 4;
    int v3ShiftBytes = (28 - n) * 4;
    string suffix = $"_{typeName}";
    string refCast = $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));";

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        {refCast}");
    w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector256<byte>>(ref first).AsInt32();");
    w.WriteLine("        var v1 = Unsafe.ReadUnaligned<Vector256<byte>>(ref Unsafe.Add(ref first, 32)).AsInt32();");
    w.WriteLine("        var v2 = Unsafe.ReadUnaligned<Vector256<byte>>(ref Unsafe.Add(ref first, 64)).AsInt32();");
    if (v3ShiftBytes == 0)
    {
        w.WriteLine($"        var v3 = Vector256.Create(");
        w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {v3ReadOffset})),");
        w.WriteLine("            Vector128<byte>.Zero).AsInt32();");
    }
    else
    {
        w.WriteLine($"        var v3 = Vector256.Create(");
        w.WriteLine("            Sse2.ShiftRightLogical128BitLane(");
        w.WriteLine($"                Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {v3ReadOffset})),");
        w.WriteLine($"                {v3ShiftBytes}),");
        w.WriteLine("            Vector128<byte>.Zero).AsInt32();");
    }

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        int[] perm = Enumerable.Range(0, 32).ToArray();
        foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

        int[] blendMask = new int[32];
        foreach (var (a, b) in step)
            blendMask[Math.Max(a, b)] = unchecked((int)0xFFFFFFFF);

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");

        // Build shuffled companion for each of the 4 vectors
        for (int d = 0; d < 4; d++)
        {
            // Group sources by which vector they come from
            var sourceMap = new Dictionary<int, List<(int destLane, int srcLane)>>();
            for (int j = 0; j < 8; j++)
            {
                int pos = d * 8 + j;
                if (pos >= 32) break;
                int srcPos = perm[pos];
                int srcVec = srcPos / 8;
                int srcLane = srcPos % 8;
                if (!sourceMap.ContainsKey(srcVec))
                    sourceMap[srcVec] = new List<(int, int)>();
                sourceMap[srcVec].Add((j, srcLane));
            }

            if (sourceMap.Count == 1 && sourceMap.ContainsKey(d))
            {
                // All sources from same vector (intra-vector permute)
                int[] indices = new int[8];
                for (int j = 0; j < 8; j++)
                    indices[j] = perm[d * 8 + j] % 8;

                bool isIdentity = true;
                for (int j = 0; j < 8; j++)
                    if (indices[j] != j) { isIdentity = false; break; }

                if (!isIdentity)
                    w.WriteLine($"            var s{d} = Avx2.PermuteVar8x32(v{d}, {FmtVec256_Int(indices)});");
                else
                    w.WriteLine($"            var s{d} = v{d};");
            }
            else
            {
                // Cross-vector shuffle
                bool firstSource = true;
                for (int srcVec = 0; srcVec < 4; srcVec++)
                {
                    if (!sourceMap.TryGetValue(srcVec, out var lanes))
                        continue;
                    int[] indices = new int[8];
                    foreach (var (destLane, srcLane) in lanes)
                        indices[destLane] = srcLane;

                    int blendBits = 0;
                    foreach (var (destLane, _) in lanes)
                        blendBits |= 1 << destLane;

                    if (firstSource)
                    {
                        w.WriteLine($"            var s{d} = Avx2.PermuteVar8x32(v{srcVec}, {FmtVec256_Int(indices)});");
                        firstSource = false;
                    }
                    else
                    {
                        w.WriteLine($"            s{d} = Avx2.Blend(s{d}, Avx2.PermuteVar8x32(v{srcVec}, {FmtVec256_Int(indices)}), 0x{blendBits:X2});");
                    }
                }
            }
        }

        // Min, Max, Blend for each vector
        for (int d = 0; d < 4; d++)
        {
            // Check if any element in this vector participates in a swap
            bool vectorModified = false;
            for (int j = 0; j < 8; j++)
            {
                int pos = d * 8 + j;
                if (pos < 32 && perm[pos] != pos)
                {
                    vectorModified = true;
                    break;
                }
            }

            if (!vectorModified) continue;

            int blendImm = 0;
            for (int j = 0; j < 8; j++)
            {
                if (blendMask[d * 8 + j] != 0)
                    blendImm |= 1 << j;
            }

            if (blendImm == 0x00)
            {
                w.WriteLine($"            v{d} = {MinExpr32(typeName, $"v{d}", $"s{d}")};");
            }
            else if (blendImm == 0xFF)
            {
                w.WriteLine($"            v{d} = {MaxExpr32(typeName, $"v{d}", $"s{d}")};");
            }
            else
            {
                w.WriteLine($"            var min{d} = {MinExpr32(typeName, $"v{d}", $"s{d}")};");
                w.WriteLine($"            var max{d} = {MaxExpr32(typeName, $"v{d}", $"s{d}")};");
                w.WriteLine($"            v{d} = Avx2.Blend(min{d}, max{d}, 0x{blendImm:X2});");
            }
        }

        w.WriteLine("        }");
    }

    // Store results (reverse order for overlapping writes)
    w.WriteLine();
    if (v3ShiftBytes == 0)
    {
        w.WriteLine($"        v3.GetLower().AsByte().StoreUnsafe(ref Unsafe.Add(ref first, {v3ReadOffset}));");
    }
    else
    {
        w.WriteLine($"        Sse2.ShiftLeftLogical128BitLane(v3.GetLower().AsByte(), {v3ShiftBytes})");
        w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {v3ReadOffset}));");
    }
    w.WriteLine("        v2.AsByte().StoreUnsafe(ref Unsafe.Add(ref first, 64));");
    w.WriteLine("        v1.AsByte().StoreUnsafe(ref Unsafe.Add(ref first, 32));");
    w.WriteLine("        v0.AsByte().StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteSimdSortMethod64(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int shiftAmount = 32 - n;
    int v3ReadByteOffset = (n - 8) * 8;
    string suffix = $"_{typeName}";

    // Load permutation: shift elements so positions n..n+shiftAmount-1 map to lanes 0..
    long[] loadPerm = new long[8];
    for (int i = 0; i < 8; i++)
        loadPerm[i] = (i < 8 - shiftAmount) ? (i + shiftAmount) : 0;

    // Store permutation: reverse of load
    long[] storePerm = new long[8];
    for (int i = 0; i < 8; i++)
        storePerm[i] = (i >= shiftAmount) ? (i - shiftAmount) : 0;

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));");
    w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector512<long>>(ref first);");
    w.WriteLine("        var v1 = Unsafe.ReadUnaligned<Vector512<long>>(ref Unsafe.Add(ref first, 64));");
    w.WriteLine("        var v2 = Unsafe.ReadUnaligned<Vector512<long>>(ref Unsafe.Add(ref first, 128));");
    w.WriteLine($"        var v3 = Avx512F.PermuteVar8x64(");
    w.WriteLine($"            Unsafe.ReadUnaligned<Vector512<long>>(ref Unsafe.Add(ref first, {v3ReadByteOffset})),");
    w.WriteLine($"            {FmtVec512_Long(loadPerm)});");

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        int[] perm32 = Enumerable.Range(0, 32).ToArray();
        foreach (var (a, b) in step) { perm32[a] = b; perm32[b] = a; }

        long[] blend32 = new long[32];
        foreach (var (a, b) in step)
            blend32[Math.Max(a, b)] = -1L; // all 1s

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");

        // Phase 1: Compute all shuffled vectors before modifying any v
        for (int vi = 0; vi < 4; vi++)
        {
            bool isIdentity = true;
            for (int j = 0; j < 8; j++)
            {
                if (perm32[vi * 8 + j] != vi * 8 + j) { isIdentity = false; break; }
            }
            if (isIdentity)
                continue;

            // Determine source distribution
            bool needsPair01 = false, needsPair23 = false;
            long[] idx01 = new long[8];
            long[] idx23 = new long[8];
            long[] selectFrom23 = new long[8];

            for (int j = 0; j < 8; j++)
            {
                int src = perm32[vi * 8 + j];
                if (src < 16)
                {
                    idx01[j] = src;
                    needsPair01 = true;
                }
                else
                {
                    idx23[j] = src - 16;
                    selectFrom23[j] = -1L;
                    needsPair23 = true;
                }
            }

            // Check if all from a single vector (most efficient)
            bool allFromSameVector = true;
            int singleSrcVec = perm32[vi * 8] / 8;
            for (int j = 1; j < 8; j++)
            {
                if (perm32[vi * 8 + j] / 8 != singleSrcVec)
                {
                    allFromSameVector = false;
                    break;
                }
            }

            if (allFromSameVector)
            {
                long[] idx = new long[8];
                for (int j = 0; j < 8; j++)
                    idx[j] = perm32[vi * 8 + j] % 8;
                w.WriteLine($"            var shuffled{vi} = Avx512F.PermuteVar8x64(v{singleSrcVec}, {FmtVec512_Long(idx)});");
            }
            else if (needsPair01 && !needsPair23)
            {
                w.WriteLine($"            var shuffled{vi} = Avx512F.PermuteVar8x64x2(v0, {FmtVec512_Long(idx01)}, v1);");
            }
            else if (!needsPair01 && needsPair23)
            {
                w.WriteLine($"            var shuffled{vi} = Avx512F.PermuteVar8x64x2(v2, {FmtVec512_Long(idx23)}, v3);");
            }
            else
            {
                w.WriteLine($"            var fromPair01_{vi} = Avx512F.PermuteVar8x64x2(v0, {FmtVec512_Long(idx01)}, v1);");
                w.WriteLine($"            var fromPair23_{vi} = Avx512F.PermuteVar8x64x2(v2, {FmtVec512_Long(idx23)}, v3);");
                w.WriteLine($"            var shuffled{vi} = Vector512.ConditionalSelect({FmtVec512_Long(selectFrom23)}, fromPair23_{vi}, fromPair01_{vi});");
            }
        }

        // Phase 2: Apply min/max/blend to update vectors
        for (int vi = 0; vi < 4; vi++)
        {
            bool isIdentity = true;
            for (int j = 0; j < 8; j++)
            {
                if (perm32[vi * 8 + j] != vi * 8 + j) { isIdentity = false; break; }
            }
            if (isIdentity)
                continue;

            long[] blendMask = new long[8];
            for (int j = 0; j < 8; j++)
                blendMask[j] = blend32[vi * 8 + j];

            bool allMin = blendMask.All(v => v == 0);
            bool allMax = blendMask.All(v => v == -1L);

            if (typeName == "double")
            {
                if (allMin)
                {
                    w.WriteLine($"            var gt{vi} = Avx512F.CompareGreaterThan(v{vi}.AsDouble(), shuffled{vi}.AsDouble()).AsInt64();");
                    w.WriteLine($"            v{vi} = Vector512.ConditionalSelect(gt{vi}, shuffled{vi}, v{vi});");
                }
                else if (allMax)
                {
                    w.WriteLine($"            var gt{vi} = Avx512F.CompareGreaterThan(v{vi}.AsDouble(), shuffled{vi}.AsDouble()).AsInt64();");
                    w.WriteLine($"            v{vi} = Vector512.ConditionalSelect(gt{vi}, v{vi}, shuffled{vi});");
                }
                else
                {
                    // Use CompareGreaterThan + ConditionalSelect to match scalar
                    // `if (a > b) { swap }` semantics for NaN and ±0.
                    w.WriteLine($"            var gt{vi} = Avx512F.CompareGreaterThan(v{vi}.AsDouble(), shuffled{vi}.AsDouble()).AsInt64();");
                    w.WriteLine($"            var mins{vi} = Vector512.ConditionalSelect(gt{vi}, shuffled{vi}, v{vi});");
                    w.WriteLine($"            var maxs{vi} = Vector512.ConditionalSelect(gt{vi}, v{vi}, shuffled{vi});");
                    w.WriteLine($"            v{vi} = Vector512.ConditionalSelect({FmtVec512_Long(blendMask)}, maxs{vi}, mins{vi});");
                }
            }
            else
            {
                if (allMin)
                {
                    w.WriteLine($"            v{vi} = {MinExpr64(typeName, $"v{vi}", $"shuffled{vi}")};");
                }
                else if (allMax)
                {
                    w.WriteLine($"            v{vi} = {MaxExpr64(typeName, $"v{vi}", $"shuffled{vi}")};");
                }
                else
                {
                    w.WriteLine($"            var mins{vi} = {MinExpr64(typeName, $"v{vi}", $"shuffled{vi}")};");
                    w.WriteLine($"            var maxs{vi} = {MaxExpr64(typeName, $"v{vi}", $"shuffled{vi}")};");
                    w.WriteLine($"            v{vi} = Vector512.ConditionalSelect({FmtVec512_Long(blendMask)}, maxs{vi}, mins{vi});");
                }
            }
        }

        w.WriteLine("        }");
    }

    w.WriteLine();
    w.WriteLine($"        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, {v3ReadByteOffset}),");
    w.WriteLine($"            Avx512F.PermuteVar8x64(v3, {FmtVec512_Long(storePerm)}));");
    w.WriteLine("        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, 128), v2);");
    w.WriteLine("        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, 64), v1);");
    w.WriteLine("        Unsafe.WriteUnaligned(ref first, v0);");
    w.WriteLine("    }");
}

void WriteSimdSortMethodFloat(StreamWriter w, int n, List<List<(int A, int B)>> steps)
{
    int regSize = 8;
    int numRegs = (n + regSize - 1) / regSize;
    int lastRegElems = n - (numRegs - 1) * regSize;
    int lastRegOffset = (numRegs - 1) * regSize * 4;

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimd{n}_float(Span<float> span)");
    w.WriteLine("    {");
    w.WriteLine("        ref byte first = ref Unsafe.As<float, byte>(ref MemoryMarshal.GetReference(span));");

    for (int ri = 0; ri < numRegs - 1; ri++)
    {
        if (ri == 0)
            w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector256<float>>(ref first);");
        else
            w.WriteLine($"        var v{ri} = Unsafe.ReadUnaligned<Vector256<float>>(ref Unsafe.Add(ref first, {ri * 32}));");
    }

    if (lastRegElems >= regSize)
    {
        w.WriteLine($"        var v{numRegs - 1} = Unsafe.ReadUnaligned<Vector256<float>>(ref Unsafe.Add(ref first, {lastRegOffset}));");
    }
    else if (lastRegElems == 4)
    {
        w.WriteLine($"        var v{numRegs - 1} = Vector256.Create(");
        w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<float>>(ref Unsafe.Add(ref first, {lastRegOffset})),");
        w.WriteLine("            Vector128<float>.Zero);");
    }
    else
    {
        int overlapOffset = (n - 4) * 4;
        int shiftBytes = (4 - lastRegElems) * 4;
        w.WriteLine($"        var v{numRegs - 1} = Vector256.Create(");
        w.WriteLine($"            Sse2.ShiftRightLogical128BitLane(");
        w.WriteLine($"                Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {overlapOffset})),");
        w.WriteLine($"                {shiftBytes}).AsSingle(),");
        w.WriteLine("            Vector128<float>.Zero);");
    }

    int totalSlots = numRegs * regSize;

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        int[] perm = Enumerable.Range(0, totalSlots).ToArray();
        foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }
        bool[] isMax = new bool[totalSlots];
        foreach (var (a, b) in step) isMax[Math.Max(a, b)] = true;

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));
        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");

        // Identify active registers
        var activeRegs = new List<int>();
        for (int tri = 0; tri < numRegs; tri++)
        {
            int baseElem = tri * regSize;
            bool hasWork = false;
            for (int lane = 0; lane < regSize; lane++)
                if (perm[baseElem + lane] != baseElem + lane) { hasWork = true; break; }
            if (hasWork) activeRegs.Add(tri);
        }

        // Pass 1: compute all shuffled vectors from unmodified registers
        foreach (int tri in activeRegs)
        {
            int baseElem = tri * regSize;
            var sourceGroups = new Dictionary<int, List<(int destLane, int srcLane)>>();
            for (int lane = 0; lane < regSize; lane++)
            {
                int srcElem = perm[baseElem + lane];
                int srcReg = srcElem / regSize;
                int srcLane = srcElem % regSize;
                if (!sourceGroups.ContainsKey(srcReg))
                    sourceGroups[srcReg] = [];
                sourceGroups[srcReg].Add((lane, srcLane));
            }

            var sortedSources = sourceGroups.Keys.OrderBy(k => k).ToList();

            if (sortedSources.Count == 1 && sortedSources[0] == tri)
            {
                int[] permIdx = new int[regSize];
                for (int lane = 0; lane < regSize; lane++)
                    permIdx[lane] = perm[baseElem + lane] % regSize;
                w.WriteLine($"            var shuffled{tri} = Avx2.PermuteVar8x32(v{tri}, {FmtVec256_Int(permIdx)});");
            }
            else
            {
                foreach (int srcReg in sortedSources)
                {
                    int[] permIdx = new int[regSize];
                    for (int lane = 0; lane < regSize; lane++)
                        permIdx[lane] = lane;
                    foreach (var (destLane, srcLane) in sourceGroups[srcReg])
                        permIdx[destLane] = srcLane;
                    w.WriteLine($"            var from{tri}_{srcReg} = Avx2.PermuteVar8x32(v{srcReg}, {FmtVec256_Int(permIdx)});");
                }

                if (sortedSources.Count == 1)
                {
                    w.WriteLine($"            var shuffled{tri} = from{tri}_{sortedSources[0]};");
                }
                else
                {
                    string prev = $"from{tri}_{sortedSources[0]}";
                    for (int bi = 1; bi < sortedSources.Count; bi++)
                    {
                        int srcReg = sortedSources[bi];
                        int[] blendMask = new int[regSize];
                        foreach (var (destLane, _) in sourceGroups[srcReg])
                            blendMask[destLane] = -1;
                        string next = bi < sortedSources.Count - 1 ? $"blend{tri}_{bi}" : $"shuffled{tri}";
                        w.WriteLine($"            var {next} = Avx.BlendVariable({prev}, from{tri}_{srcReg}, {FmtVec256_Int(blendMask)}.AsSingle());");
                        prev = next;
                    }
                }
            }
        }

        // Pass 2: apply min/max/blend using shuffled vectors
        foreach (int tri in activeRegs)
        {
            int baseElem = tri * regSize;
            int[] maxMask = new int[regSize];
            for (int lane = 0; lane < regSize; lane++)
                if (isMax[baseElem + lane]) maxMask[lane] = -1;
            bool allMin = maxMask.All(v => v == 0);
            bool allMax = maxMask.All(v => v == -1);
            if (allMin)
            {
                w.WriteLine($"            v{tri} = Avx.Min(v{tri}, shuffled{tri});");
            }
            else if (allMax)
            {
                w.WriteLine($"            v{tri} = Avx.Max(v{tri}, shuffled{tri});");
            }
            else
            {
                w.WriteLine($"            var mins{tri} = Avx.Min(v{tri}, shuffled{tri});");
                w.WriteLine($"            var maxs{tri} = Avx.Max(v{tri}, shuffled{tri});");
                w.WriteLine($"            v{tri} = Avx.BlendVariable(mins{tri}, maxs{tri}, {FmtVec256_Int(maxMask)}.AsSingle());");
            }
        }

        w.WriteLine("        }");
    }

    w.WriteLine();
    if (lastRegElems < 4)
    {
        int overlapOffset = (n - 4) * 4;
        int shiftBytes = (4 - lastRegElems) * 4;
        w.WriteLine($"        Sse2.ShiftLeftLogical128BitLane(v{numRegs - 1}.GetLower().AsByte(), {shiftBytes})");
        w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {overlapOffset}));");
    }
    else if (lastRegElems == 4)
    {
        w.WriteLine($"        v{numRegs - 1}.GetLower().AsByte().StoreUnsafe(ref Unsafe.Add(ref first, {lastRegOffset}));");
    }
    else
    {
        w.WriteLine($"        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, {lastRegOffset}), v{numRegs - 1});");
    }

    for (int ri = numRegs - 2; ri >= 0; ri--)
    {
        if (ri == 0)
            w.WriteLine("        Unsafe.WriteUnaligned(ref first, v0);");
        else
            w.WriteLine($"        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, {ri * 32}), v{ri});");
    }
    w.WriteLine("    }");
}

void WriteSimdSortMethodDouble(StreamWriter w, int n, List<List<(int A, int B)>> steps, string methodSuffix)
{
    int regSize = 4;
    int numRegs = (n + regSize - 1) / regSize;
    int lastRegElems = n - (numRegs - 1) * regSize;
    int lastRegOffset = (numRegs - 1) * 32;

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void {methodSuffix}{n}_double(Span<double> span)");
    w.WriteLine("    {");
    w.WriteLine("        ref byte first = ref Unsafe.As<double, byte>(ref MemoryMarshal.GetReference(span));");

    for (int ri = 0; ri < numRegs - 1; ri++)
    {
        if (ri == 0)
            w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector256<double>>(ref first);");
        else
            w.WriteLine($"        var v{ri} = Unsafe.ReadUnaligned<Vector256<double>>(ref Unsafe.Add(ref first, {ri * 32}));");
    }

    if (lastRegElems == regSize)
    {
        w.WriteLine($"        var v{numRegs - 1} = Unsafe.ReadUnaligned<Vector256<double>>(ref Unsafe.Add(ref first, {lastRegOffset}));");
    }
    else
    {
        int overlapOffset = (n - regSize) * 8;
        int shift = regSize - lastRegElems;
        byte control = 0;
        for (int d = 0; d < 4; d++)
        {
            int s = (d + shift) % 4;
            control |= (byte)(s << (d * 2));
        }
        w.WriteLine($"        var v{numRegs - 1} = Avx2.Permute4x64(");
        w.WriteLine($"            Unsafe.ReadUnaligned<Vector256<double>>(ref Unsafe.Add(ref first, {overlapOffset})),");
        w.WriteLine($"            0x{control:X2});");
    }

    int totalSlots = numRegs * regSize;

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        int[] perm = Enumerable.Range(0, totalSlots).ToArray();
        foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }
        bool[] isMax = new bool[totalSlots];
        foreach (var (a, b) in step) isMax[Math.Max(a, b)] = true;

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));
        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");

        // Identify active registers
        var activeRegs = new List<int>();
        for (int tri = 0; tri < numRegs; tri++)
        {
            int baseElem = tri * regSize;
            bool hasWork = false;
            for (int lane = 0; lane < regSize; lane++)
                if (perm[baseElem + lane] != baseElem + lane) { hasWork = true; break; }
            if (hasWork) activeRegs.Add(tri);
        }

        // Pass 1: compute all shuffled vectors from unmodified registers
        foreach (int tri in activeRegs)
        {
            int baseElem = tri * regSize;
            var sourceGroups = new Dictionary<int, List<(int destLane, int srcLane)>>();
            for (int lane = 0; lane < regSize; lane++)
            {
                int srcElem = perm[baseElem + lane];
                int srcReg = srcElem / regSize;
                int srcLane = srcElem % regSize;
                if (!sourceGroups.ContainsKey(srcReg))
                    sourceGroups[srcReg] = [];
                sourceGroups[srcReg].Add((lane, srcLane));
            }

            var sortedSources = sourceGroups.Keys.OrderBy(k => k).ToList();

            if (sortedSources.Count == 1 && sortedSources[0] == tri)
            {
                int[] srcLanes = new int[regSize];
                for (int lane = 0; lane < regSize; lane++)
                    srcLanes[lane] = perm[baseElem + lane] % regSize;
                byte ctrl = (byte)(srcLanes[0] | (srcLanes[1] << 2) | (srcLanes[2] << 4) | (srcLanes[3] << 6));
                w.WriteLine($"            var shuffled{tri} = Avx2.Permute4x64(v{tri}, 0x{ctrl:X2});");
            }
            else
            {
                foreach (int srcReg in sortedSources)
                {
                    int[] srcLanes = new int[regSize];
                    for (int lane = 0; lane < regSize; lane++)
                        srcLanes[lane] = lane;
                    foreach (var (destLane, srcLane) in sourceGroups[srcReg])
                        srcLanes[destLane] = srcLane;
                    byte ctrl = (byte)(srcLanes[0] | (srcLanes[1] << 2) | (srcLanes[2] << 4) | (srcLanes[3] << 6));
                    w.WriteLine($"            var from{tri}_{srcReg} = Avx2.Permute4x64(v{srcReg}, 0x{ctrl:X2});");
                }

                if (sortedSources.Count == 1)
                {
                    w.WriteLine($"            var shuffled{tri} = from{tri}_{sortedSources[0]};");
                }
                else
                {
                    string prev = $"from{tri}_{sortedSources[0]}";
                    for (int bi = 1; bi < sortedSources.Count; bi++)
                    {
                        int srcReg = sortedSources[bi];
                        long[] blendMask = new long[regSize];
                        foreach (var (destLane, _) in sourceGroups[srcReg])
                            blendMask[destLane] = -1L;
                        string next = bi < sortedSources.Count - 1 ? $"blend{tri}_{bi}" : $"shuffled{tri}";
                        w.WriteLine($"            var {next} = Avx.BlendVariable({prev}, from{tri}_{srcReg}, {FmtVec256_Long(blendMask)}.AsDouble());");
                        prev = next;
                    }
                }
            }
        }

        // Pass 2: apply min/max/blend using shuffled vectors
        foreach (int tri in activeRegs)
        {
            int baseElem = tri * regSize;
            long[] maxMask = new long[regSize];
            for (int lane = 0; lane < regSize; lane++)
                if (isMax[baseElem + lane]) maxMask[lane] = -1L;
            bool allMin = maxMask.All(v => v == 0);
            bool allMax = maxMask.All(v => v == -1L);
            if (allMin)
            {
                w.WriteLine($"            v{tri} = Avx.Min(v{tri}, shuffled{tri});");
            }
            else if (allMax)
            {
                w.WriteLine($"            v{tri} = Avx.Max(v{tri}, shuffled{tri});");
            }
            else
            {
                w.WriteLine($"            var mins{tri} = Avx.Min(v{tri}, shuffled{tri});");
                w.WriteLine($"            var maxs{tri} = Avx.Max(v{tri}, shuffled{tri});");
                w.WriteLine($"            v{tri} = Avx.BlendVariable(mins{tri}, maxs{tri}, {FmtVec256_Long(maxMask)}.AsDouble());");
            }
        }

        w.WriteLine("        }");
    }

    w.WriteLine();
    if (lastRegElems < regSize)
    {
        int overlapOffset = (n - regSize) * 8;
        int shift = regSize - lastRegElems;
        byte control = 0;
        for (int d = 0; d < 4; d++)
        {
            int s = (d - shift + 4) % 4;
            control |= (byte)(s << (d * 2));
        }
        w.WriteLine($"        Avx2.Permute4x64(v{numRegs - 1}, 0x{control:X2}).AsByte()");
        w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {overlapOffset}));");
    }
    else
    {
        w.WriteLine($"        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, {lastRegOffset}), v{numRegs - 1});");
    }

    for (int ri = numRegs - 2; ri >= 0; ri--)
    {
        if (ri == 0)
            w.WriteLine("        Unsafe.WriteUnaligned(ref first, v0);");
        else
            w.WriteLine($"        Unsafe.WriteUnaligned(ref Unsafe.Add(ref first, {ri * 32}), v{ri});");
    }
    w.WriteLine("    }");
}

void WriteSimdSortMethod32_Avx512(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int totalSlots = 32;

    string refCast = typeName switch
    {
        "uint" => "Unsafe.As<uint, int>(ref ",
        "float" => "Unsafe.As<float, int>(ref ",
        _ => "",
    };
    string refCastEnd = typeName != "int" ? ")" : "";

    w.WriteLine($$"""
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static void SortSimd{{n}}_512_{{typeName}}(Span<{{typeName}}> span)
        {
            ref int first = ref {{refCast}}MemoryMarshal.GetReference(span){{refCastEnd}};

            // Load: vec0 = elements [0..15], vec1 = elements [16..{{n - 1}}] padded with int.MaxValue
            var vec0 = Unsafe.ReadUnaligned<Vector512<int>>(ref Unsafe.As<int, byte>(ref first));
            var q0 = Unsafe.ReadUnaligned<Vector128<int>>(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 16)));
            var q1 = Unsafe.ReadUnaligned<Vector128<int>>(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 20)));
    """);

    if (n == 27)
    {
        w.WriteLine("""
                var lastThree = Unsafe.ReadUnaligned<Vector128<int>>(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 23)));
                var q2 = Sse2.ShiftRightLogical128BitLane(lastThree, 4);
                var vec1 = Vector512.Create(Vector256.Create(q0, q1), Vector256.Create(q2, Vector128.Create(int.MaxValue)));
        """);
    }
    else
    {
        w.WriteLine("""
                var q2 = Unsafe.ReadUnaligned<Vector128<int>>(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 24)));
                var vec1 = Vector512.Create(Vector256.Create(q0, q1), Vector256.Create(q2, Vector128.Create(int.MaxValue)));
        """);
    }

    bool declaredS0 = false, declaredS1 = false;
    bool declaredMin0 = false, declaredMax0 = false;
    bool declaredMin1 = false, declaredMax1 = false;

    for (int stepIdx = 0; stepIdx < steps.Count; stepIdx++)
    {
        var step = steps[stepIdx];

        int[] permA = new int[totalSlots];
        int[] permB = new int[totalSlots];

        for (int i = 0; i < totalSlots; i++)
        {
            permA[i] = i;
            permB[i] = i;
        }

        foreach (var (a, b) in step)
        {
            permA[a] = b;
            permA[b] = a;
            permB[a] = b;
            permB[b] = a;
        }

        int[] indicesVec0 = permA.Take(16).ToArray();
        int[] indicesVec1 = permA.Skip(16).Take(16).ToArray();

        w.WriteLine();
        w.WriteLine($"            // Step {stepIdx}");

        string s0Decl = !declaredS0 ? "var " : ""; declaredS0 = true;
        string s1Decl = !declaredS1 ? "var " : ""; declaredS1 = true;
        w.WriteLine($"            {s0Decl}s0 = Avx512F.PermuteVar16x32x2(vec0, {FmtVec512_Int(indicesVec0)}, vec1);");
        w.WriteLine($"            {s1Decl}s1 = Avx512F.PermuteVar16x32x2(vec0, {FmtVec512_Int(indicesVec1)}, vec1);");

        int[] blendMask0 = new int[16];
        int[] blendMask1 = new int[16];

        for (int i = 0; i < 16; i++)
        {
            foreach (var (a, b) in step)
            {
                if (b == i) { blendMask0[i] = -1; break; }
            }
        }

        for (int i = 0; i < 16; i++)
        {
            int globalIdx = i + 16;
            foreach (var (a, b) in step)
            {
                if (b == globalIdx) { blendMask1[i] = -1; break; }
            }
        }

        bool allMin0 = blendMask0.All(v => v == 0);
        bool allMax0 = blendMask0.All(v => v == -1);
        bool allMin1 = blendMask1.All(v => v == 0);
        bool allMax1 = blendMask1.All(v => v == -1);

        if (!allMax0)
        {
            string d = !declaredMin0 ? "var " : ""; declaredMin0 = true;
            w.WriteLine($"            {d}min0 = {MinExpr32_512(typeName, "vec0", "s0")};");
        }
        if (!allMin0)
        {
            string d = !declaredMax0 ? "var " : ""; declaredMax0 = true;
            w.WriteLine($"            {d}max0 = {MaxExpr32_512(typeName, "vec0", "s0")};");
        }
        if (!allMax1)
        {
            string d = !declaredMin1 ? "var " : ""; declaredMin1 = true;
            w.WriteLine($"            {d}min1 = {MinExpr32_512(typeName, "vec1", "s1")};");
        }
        if (!allMin1)
        {
            string d = !declaredMax1 ? "var " : ""; declaredMax1 = true;
            w.WriteLine($"            {d}max1 = {MaxExpr32_512(typeName, "vec1", "s1")};");
        }

        if (allMin0)
            w.WriteLine($"            vec0 = min0;");
        else if (allMax0)
            w.WriteLine($"            vec0 = max0;");
        else
            w.WriteLine($"            vec0 = Vector512.ConditionalSelect({FmtVec512_Int(blendMask0)}, max0, min0);");

        if (allMin1)
            w.WriteLine($"            vec1 = min1;");
        else if (allMax1)
            w.WriteLine($"            vec1 = max1;");
        else
            w.WriteLine($"            vec1 = Vector512.ConditionalSelect({FmtVec512_Int(blendMask1)}, max1, min1);");
    }

    w.WriteLine();
    w.WriteLine("            // Store results");
    if (n == 27)
    {
        w.WriteLine("""
                Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 23)),
                    Sse2.ShiftLeftLogical128BitLane(vec1.GetUpper().GetLower(), 4));
                Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 16)), vec1.GetLower());
                Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref first), vec0);
        """);
    }
    else
    {
        w.WriteLine("""
                Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 24)), vec1.GetUpper().GetLower());
                Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref Unsafe.Add(ref first, 16)), vec1.GetLower());
                Unsafe.WriteUnaligned(ref Unsafe.As<int, byte>(ref first), vec0);
        """);
    }
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
            WriteUnifiedByteSortMethod256(w, n, steps, typeName);
            w.WriteLine();
            WriteUnifiedByteSortMethod128(w, n, steps, typeName);
            first = false;
        }
    }

    foreach (string typeName in new[] { "short", "ushort", "char" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            w.WriteLine();
            WriteSimdSortMethod16(w, n, steps, typeName);
        }
    }

    foreach (string typeName in new[] { "int", "uint" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            w.WriteLine();
            WriteSimdSortMethod32_Avx2(w, n, steps, typeName);
        }
    }

    foreach (string typeName in new[] { "int", "uint", "float" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            w.WriteLine();
            WriteSimdSortMethod32_Avx512(w, n, steps, typeName);
        }
    }

    foreach (string typeName in new[] { "long", "ulong", "double" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            w.WriteLine();
            WriteSimdSortMethod64(w, n, steps, typeName);
        }
    }

    foreach (int n in new[] { 27, 28 })
    {
        var steps = GetNetworkSteps(n);
        w.WriteLine();
        WriteSimdSortMethodFloat(w, n, steps);
    }

    foreach (int n in new[] { 27, 28 })
    {
        var steps = GetNetworkSteps(n);
        w.WriteLine();
        WriteSimdSortMethodDouble(w, n, steps, "SortSimdAvx2_");
    }

    w.WriteLine("}");
}


void WriteArmSimdSortMethod16(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int v3ReadOffset = (n - 8) * 2;
    int v3ShiftBytes = (32 - n) * 2;
    int v3StoreShift = 16 - v3ShiftBytes;
    string suffix = $"_{typeName}";
    string refCast = $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));";

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimdArm{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");
    w.WriteLine($"        {refCast}");
    w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);");
    w.WriteLine("        var v1 = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, 16));");
    w.WriteLine("        var v2 = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, 32));");
    w.WriteLine($"        var v3 = AdvSimd.ExtractVector128(");
    w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {v3ReadOffset})),");
    w.WriteLine($"            Vector128<byte>.Zero,");
    w.WriteLine($"            {v3ShiftBytes});");

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        int[] perm = Enumerable.Range(0, 32).ToArray();
        foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

        byte[] blend = new byte[32];
        foreach (var (a, b) in step)
            blend[Math.Max(a, b)] = 0xFF;

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");
        w.WriteLine("            var table = (v0, v1, v2, v3);");

        for (int vi = 0; vi < 4; vi++)
        {
            byte[] shuffleIdx = new byte[16];
            for (int ei = 0; ei < 8; ei++)
            {
                int srcElem = perm[vi * 8 + ei];
                shuffleIdx[ei * 2] = (byte)(srcElem * 2);
                shuffleIdx[ei * 2 + 1] = (byte)(srcElem * 2 + 1);
            }
            w.WriteLine($"            var shuffled{vi} = AdvSimd.Arm64.VectorTableLookup(table, {FmtVec128(shuffleIdx)});");
        }

        for (int vi = 0; vi < 4; vi++)
        {
            byte[] blendMask = new byte[16];
            for (int ei = 0; ei < 8; ei++)
            {
                blendMask[ei * 2] = blend[vi * 8 + ei];
                blendMask[ei * 2 + 1] = blend[vi * 8 + ei];
            }
            bool allMin = blendMask.All(b => b == 0x00);
            bool allMax = blendMask.All(b => b == 0xFF);
            if (allMin)
            {
                w.WriteLine($"            v{vi} = {ArmMinExpr16(typeName, $"v{vi}", $"shuffled{vi}")};");
            }
            else if (allMax)
            {
                w.WriteLine($"            v{vi} = {ArmMaxExpr16(typeName, $"v{vi}", $"shuffled{vi}")};");
            }
            else
            {
                w.WriteLine($"            var mins{vi} = {ArmMinExpr16(typeName, $"v{vi}", $"shuffled{vi}")};");
                w.WriteLine($"            var maxs{vi} = {ArmMaxExpr16(typeName, $"v{vi}", $"shuffled{vi}")};");
                w.WriteLine($"            v{vi} = Vector128.ConditionalSelect({FmtVec128(blendMask)}, maxs{vi}, mins{vi});");
            }
        }

        w.WriteLine("        }");
    }

    w.WriteLine();
    w.WriteLine($"        AdvSimd.ExtractVector128(Vector128<byte>.Zero, v3, {v3StoreShift})");
    w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {v3ReadOffset}));");
    w.WriteLine("        v2.StoreUnsafe(ref Unsafe.Add(ref first, 32));");
    w.WriteLine("        v1.StoreUnsafe(ref Unsafe.Add(ref first, 16));");
    w.WriteLine("        v0.StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteArmSimdSortMethod32(StreamWriter w, int n, List<List<(int A, int B)>> steps, string typeName)
{
    int v6ReadOffset = (n - 4) * 4;
    int v6ShiftBytes = (28 - n) * 4;
    int v6StoreShift = 16 - v6ShiftBytes;
    string suffix = $"_{typeName}";
    string refCast = $"ref byte first = ref Unsafe.As<{typeName}, byte>(ref MemoryMarshal.GetReference(span));";

    w.WriteLine($"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]");
    w.WriteLine($"    private static void SortSimdArm{n}{suffix}(Span<{typeName}> span)");
    w.WriteLine("    {");

    // Early-exit: skip the SIMD sort if the input is already sorted
    w.WriteLine($"        // Early exit if already sorted");
    w.WriteLine("        {");
    w.WriteLine($"            ref {typeName} r = ref MemoryMarshal.GetReference(span);");
    w.WriteLine($"            for (int i = 0; i < {n - 1}; i++)");
    w.WriteLine("            {");
    w.WriteLine("                if (Unsafe.Add(ref r, i) > Unsafe.Add(ref r, i + 1))");
    w.WriteLine("                    goto notSorted;");
    w.WriteLine("            }");
    w.WriteLine("            return;");
    w.WriteLine("            notSorted:;");
    w.WriteLine("        }");
    w.WriteLine();

    w.WriteLine($"        {refCast}");
    for (int i = 0; i < 6; i++)
    {
        if (i == 0)
            w.WriteLine("        var v0 = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);");
        else
            w.WriteLine($"        var v{i} = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {i * 16}));");
    }
    if (v6ShiftBytes > 0)
    {
        w.WriteLine($"        var v6 = AdvSimd.ExtractVector128(");
        w.WriteLine($"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {v6ReadOffset})),");
        w.WriteLine($"            Vector128<byte>.Zero,");
        w.WriteLine($"            {v6ShiftBytes});");
    }
    else
    {
        w.WriteLine($"        var v6 = Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, 96));");
    }

    for (int si = 0; si < steps.Count; si++)
    {
        var step = steps[si];
        int[] perm = Enumerable.Range(0, 28).ToArray();
        foreach (var (a, b) in step) { perm[a] = b; perm[b] = a; }

        byte[] blend = new byte[28];
        foreach (var (a, b) in step)
            blend[Math.Max(a, b)] = 0xFF;

        string pairStr = string.Join(", ", step.Select(p => $"({p.A},{p.B})"));

        w.WriteLine();
        w.WriteLine($"        // Step {si}: {pairStr}");
        w.WriteLine("        {");

        // Pre-analyze each shuffled vector: detect single-source-register cases
        // and determine which tables are actually needed
        bool stepNeedsTableA = false, stepNeedsTableB = false;
        int[] singleSrc = new int[7]; // -1 = multi-source (needs table), 0-6 = single source register
        bool[] vecIsIdentity = new bool[7];

        for (int vi = 0; vi < 7; vi++)
        {
            bool identity = true;
            var srcRegs = new HashSet<int>();
            for (int ei = 0; ei < 4; ei++)
            {
                int srcElem = perm[vi * 4 + ei];
                srcRegs.Add(srcElem / 4);
                if (srcElem != vi * 4 + ei) identity = false;
            }
            vecIsIdentity[vi] = identity;

            if (identity || srcRegs.Count == 1)
            {
                singleSrc[vi] = srcRegs.Single();
            }
            else
            {
                singleSrc[vi] = -1;
                if (srcRegs.Any(r => r < 4)) stepNeedsTableA = true;
                if (srcRegs.Any(r => r >= 4)) stepNeedsTableB = true;
            }
        }

        if (stepNeedsTableA)
            w.WriteLine("            var tableA = (v0, v1, v2, v3);");
        if (stepNeedsTableB)
            w.WriteLine("            var tableB = (v4, v5, v6, Vector128<byte>.Zero);");

        // Emit shuffles
        for (int vi = 0; vi < 7; vi++)
        {
            if (vecIsIdentity[vi]) continue; // no elements move → skip shuffle and min/max

            if (singleSrc[vi] >= 0)
            {
                // All elements come from one register → Vector128.Shuffle (TBL1)
                int srcReg = singleSrc[vi];
                byte[] indices = new byte[16];
                for (int ei = 0; ei < 4; ei++)
                {
                    int localElem = perm[vi * 4 + ei] % 4;
                    for (int bi = 0; bi < 4; bi++)
                        indices[ei * 4 + bi] = (byte)(localElem * 4 + bi);
                }
                w.WriteLine($"            var shuffled{vi} = Vector128.Shuffle(v{srcReg}, {FmtVec128(indices)});");
            }
            else
            {
                // Multi-register: use tableA/tableB with TBL4/TBX
                byte[] idxA = new byte[16];
                byte[] idxB = new byte[16];
                bool needsA = false, needsB = false;
                for (int ei = 0; ei < 4; ei++)
                {
                    int srcElem = perm[vi * 4 + ei];
                    for (int bi = 0; bi < 4; bi++)
                    {
                        if (srcElem < 16)
                        {
                            idxA[ei * 4 + bi] = (byte)(srcElem * 4 + bi);
                            idxB[ei * 4 + bi] = 0xFF;
                            needsA = true;
                        }
                        else
                        {
                            idxA[ei * 4 + bi] = 0xFF;
                            idxB[ei * 4 + bi] = (byte)((srcElem - 16) * 4 + bi);
                            needsB = true;
                        }
                    }
                }

                if (needsA && needsB)
                {
                    w.WriteLine($"            var shuffled{vi} = AdvSimd.Arm64.VectorTableLookup(tableA, {FmtVec128(idxA)});");
                    w.WriteLine($"            shuffled{vi} = AdvSimd.Arm64.VectorTableLookupExtension(shuffled{vi}, tableB, {FmtVec128(idxB)});");
                }
                else if (needsA)
                {
                    w.WriteLine($"            var shuffled{vi} = AdvSimd.Arm64.VectorTableLookup(tableA, {FmtVec128(idxA)});");
                }
                else
                {
                    w.WriteLine($"            var shuffled{vi} = AdvSimd.Arm64.VectorTableLookup(tableB, {FmtVec128(idxB)});");
                }
            }
        }

        // Min/Max/Blend
        for (int vi = 0; vi < 7; vi++)
        {
            if (vecIsIdentity[vi]) continue; // no elements move → skip

            bool allMin = true, allMax = true;
            for (int ei = 0; ei < 4; ei++)
            {
                if (blend[vi * 4 + ei] != 0x00) allMin = false;
                if (blend[vi * 4 + ei] != 0xFF) allMax = false;
            }

            if (allMin)
            {
                w.WriteLine($"            v{vi} = {ArmMinExpr32(typeName, $"v{vi}", $"shuffled{vi}")};");
            }
            else if (allMax)
            {
                w.WriteLine($"            v{vi} = {ArmMaxExpr32(typeName, $"v{vi}", $"shuffled{vi}")};");
            }
            else
            {
                byte[] blendMask = new byte[16];
                for (int ei = 0; ei < 4; ei++)
                {
                    byte val = blend[vi * 4 + ei];
                    for (int bi = 0; bi < 4; bi++)
                        blendMask[ei * 4 + bi] = val;
                }
                w.WriteLine($"            var mins{vi} = {ArmMinExpr32(typeName, $"v{vi}", $"shuffled{vi}")};");
                w.WriteLine($"            var maxs{vi} = {ArmMaxExpr32(typeName, $"v{vi}", $"shuffled{vi}")};");
                w.WriteLine($"            v{vi} = Vector128.ConditionalSelect({FmtVec128(blendMask)}, maxs{vi}, mins{vi});");
            }
        }

        w.WriteLine("        }");
    }

    w.WriteLine();
    if (v6ShiftBytes > 0)
    {
        w.WriteLine($"        AdvSimd.ExtractVector128(Vector128<byte>.Zero, v6, {v6StoreShift})");
        w.WriteLine($"            .StoreUnsafe(ref Unsafe.Add(ref first, {v6ReadOffset}));");
    }
    else
    {
        w.WriteLine("        v6.StoreUnsafe(ref Unsafe.Add(ref first, 96));");
    }
    for (int i = 5; i >= 1; i--)
        w.WriteLine($"        v{i}.StoreUnsafe(ref Unsafe.Add(ref first, {i * 16}));");
    w.WriteLine("        v0.StoreUnsafe(ref first);");
    w.WriteLine("    }");
}

void WriteArmSimdFile(StreamWriter w)
{
    w.Write("""
        using System.Runtime.CompilerServices;
        using System.Runtime.InteropServices;
        using System.Runtime.Intrinsics;
        using System.Runtime.Intrinsics.Arm;

        namespace SortingNetworks;

        // <auto-generated>
        // This file was generated by generate_unrolled.cs
        // Do not edit manually.
        // </auto-generated>

        public static partial class NetworkSort
        {

        """);

    bool first = true;
    foreach (string typeName in new[] { "short", "ushort", "char" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            w.WriteLine();
            WriteArmSimdSortMethod16(w, n, steps, typeName);
        }
    }

    foreach (string typeName in new[] { "int", "uint", "float" })
    {
        foreach (int n in new[] { 27, 28 })
        {
            var steps = GetNetworkSteps(n);
            w.WriteLine();
            WriteArmSimdSortMethod32(w, n, steps, typeName);
        }
    }

    w.WriteLine("}");
}

void WritePublicApi(StreamWriter w, string t)
{
    string suffix = t != "byte" ? $"_{t}" : "";
    bool hasSimd8 = t == "byte" || t == "sbyte";
    bool hasSimd16 = t == "short" || t == "ushort" || t == "char";
    bool hasSimd32 = t == "int" || t == "uint";
    bool hasSimd32_512 = t == "int" || t == "uint" || t == "float";
    bool hasSimd64 = t == "long" || t == "ulong" || t == "double";
    bool hasAvx2Float = t == "float" || t == "double";

    w.WriteLine("    /// <summary>");
    w.WriteLine($"    /// Sorts a span of {t} using a sorting network when possible.");
    w.WriteLine("    /// </summary>");
    w.WriteLine($"    public static void Sort(Span<{t}> span)");
    w.WriteLine("    {");
    w.WriteLine("        int n = span.Length;");
    w.WriteLine("        if (n == 27 || n == 28)");
    w.WriteLine("        {");
    if (t == "nint")
    {
        // Gate 64-bit dispatch on Avx512F — long only has SIMD via AVX-512.
        // On ARM64 and AVX2-only x86, fall through to the scalar unrolled path.
        w.WriteLine("            if (nint.Size == 8 && Avx512F.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine("                Sort(MemoryMarshal.Cast<nint, long>(span));");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine("            if (nint.Size == 4)");
        w.WriteLine("            {");
        w.WriteLine("                Sort(MemoryMarshal.Cast<nint, int>(span));");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
    }
    else if (t == "nuint")
    {
        w.WriteLine("            if (nuint.Size == 8 && Avx512F.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine("                Sort(MemoryMarshal.Cast<nuint, ulong>(span));");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine("            if (nuint.Size == 4)");
        w.WriteLine("            {");
        w.WriteLine("                Sort(MemoryMarshal.Cast<nuint, uint>(span));");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
    }
    if (hasSimd32_512)
    {
        w.WriteLine("            if (Avx512F.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimd27_512{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimd28_512{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
        if (hasSimd32)
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
        else if (hasAvx2Float)
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
        w.WriteLine("            if (AdvSimd.Arm64.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimdArm27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimdArm28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
    }
    else if (hasSimd8)
    {
        // Vector256.Shuffle<byte> requires AVX2 (VPSHUFB) on x86
        w.WriteLine("            if (Avx2.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimd27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimd28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
        // Vector128.Shuffle<byte> requires SSSE3 (PSHUFB) on x86 or AdvSimd (TBL) on ARM
        w.WriteLine("            if (Ssse3.IsSupported || AdvSimd.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimd128_27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimd128_28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
    }
    else if (hasSimd16)
    {
        w.WriteLine("            if (Avx512BW.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimd27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimd28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
        w.WriteLine("            if (AdvSimd.Arm64.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimdArm27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimdArm28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
    }
    else if (hasSimd64)
    {
        w.WriteLine("            if (Avx512F.IsSupported)");
        w.WriteLine("            {");
        w.WriteLine($"                if (n == 27)");
        w.WriteLine($"                    SortSimd27{suffix}(span);");
        w.WriteLine("                else");
        w.WriteLine($"                    SortSimd28{suffix}(span);");
        w.WriteLine("                return;");
        w.WriteLine("            }");
        w.WriteLine();
        if (hasAvx2Float)
        {
            w.WriteLine("            if (Avx2.IsSupported)");
            w.WriteLine("            {");
            w.WriteLine($"                if (n == 27)");
            w.WriteLine($"                    SortSimdAvx2_27{suffix}(span);");
            w.WriteLine("                else");
            w.WriteLine($"                    SortSimdAvx2_28{suffix}(span);");
            w.WriteLine("                return;");
            w.WriteLine("            }");
            w.WriteLine();
        }
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
        using System.Runtime.Intrinsics;
        using System.Runtime.Intrinsics.X86;
        using System.Runtime.Intrinsics.Arm;

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
