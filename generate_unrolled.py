"""Generate unrolled sorting network methods for SortingNetworks."""

import sys
import os

# Primitive .NET types to specialize (all sortable primitives)
PRIMITIVE_TYPES = [
    "byte", "sbyte", "short", "ushort",
    "int", "uint", "long", "ulong",
    "nint", "nuint", "char", "float", "double",
]

# --- Batcher's odd-even merge sort network generator ---

def batcher_sort(lo, hi, n, pairs):
    if lo >= hi:
        return
    mid = lo + (hi - lo) // 2
    batcher_sort(lo, mid, n, pairs)
    batcher_sort(mid + 1, hi, n, pairs)
    batcher_merge(lo, hi, 1, n, pairs)

def batcher_merge(lo, hi, step, n, pairs):
    double_step = step * 2
    if double_step > hi - lo:
        if lo < n and lo + step < n:
            pairs.append((lo, lo + step))
        return
    batcher_merge(lo, hi, double_step, n, pairs)
    batcher_merge(lo + step, hi, double_step, n, pairs)
    i = lo + step
    while i + step <= hi:
        if i < n and i + step < n:
            pairs.append((i, i + step))
        i += double_step

def generate_batcher_network(n):
    p = 1
    while p < n:
        p <<= 1
    pairs = []
    batcher_sort(0, p - 1, n, pairs)
    return pairs

# --- Network28 from the paper ---
NETWORK_28_FLAT = [
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
]

def get_network28():
    pairs = []
    for i in range(0, len(NETWORK_28_FLAT), 2):
        pairs.append((NETWORK_28_FLAT[i], NETWORK_28_FLAT[i+1]))
    return pairs

def get_network27():
    pairs = []
    for a, b in get_network28():
        if a < 27 and b < 27:
            pairs.append((a, b))
    return pairs

def get_network(n):
    if n == 28:
        return get_network28()
    elif n == 27:
        return get_network27()
    else:
        return generate_batcher_network(n)

# --- SIMD code generation helpers ---

# Step sizes from the depth-13 network for 28 channels (arXiv:2511.04107).
# These define the number of compare-swap pairs per step in NETWORK_28_FLAT.
NETWORK_28_STEP_SIZES = [14, 14, 14, 14, 13, 14, 11, 10, 10, 10, 12, 12, 11]

def get_network28_steps():
    """Get the 28-element network organized into its original steps."""
    pairs = get_network28()
    steps = []
    idx = 0
    for size in NETWORK_28_STEP_SIZES:
        steps.append(pairs[idx:idx + size])
        idx += size
    assert idx == len(pairs), f"Step sizes don't sum to pair count: {idx} != {len(pairs)}"
    return steps

def get_network27_steps():
    """Derive 27-element network steps from 28-element network steps."""
    steps = []
    for step in get_network28_steps():
        filtered = [(a, b) for a, b in step if a < 27 and b < 27]
        if filtered:
            steps.append(filtered)
    return steps

def get_network_steps(n):
    """Get the network steps for size n, preserving original step structure."""
    if n == 28:
        return get_network28_steps()
    elif n == 27:
        return get_network27_steps()
    else:
        raise ValueError(f"SIMD steps only supported for n=27 and n=28, got n={n}")

def step_needs_cross_lane(step):
    """Check if any pair crosses the 128-bit lane boundary (byte 0-15 vs 16-31)."""
    for a, b in step:
        if (a < 16) != (b < 16):
            return True
    return False

def compute_shuffle_perm(step):
    """Build a 32-element permutation: paired elements swap, others identity."""
    perm = list(range(32))
    for a, b in step:
        perm[a] = b
        perm[b] = a
    return perm

def compute_blend_mask(step):
    """Build blend mask: 0xFF at 'right' (larger index) positions, 0x00 elsewhere."""
    blend = [0] * 32
    for a, b in step:
        right = max(a, b)
        blend[right] = 0xFF
    return blend

def compute_cross_lane_masks(perm):
    """Split permutation into maskLo/maskHi for the cross-lane shuffle trick."""
    maskLo = []
    maskHi = []
    for i in range(32):
        src = perm[i]
        if src < 16:
            maskLo.append(src)
            maskHi.append(0x80)
        else:
            maskLo.append(0x80)
            maskHi.append(src - 16)
    return maskLo, maskHi

def compute_intra_lane_mask(perm):
    """Convert permutation to lane-relative indices for Avx2.Shuffle."""
    mask = list(perm)
    for i in range(16, 32):
        if mask[i] >= 16:
            mask[i] -= 16
    return mask

def fmt_vec256(values):
    """Format a Vector256.Create<byte>(...) call."""
    parts = ", ".join(f"0x{v:02X}" for v in values)
    return f"Vector256.Create((byte){parts})"

def generate_simd_sort_method(n, steps, type_name):
    """Generate a SortSimdN method for byte or sbyte using AVX2."""
    load_offset = n - 16  # 11 for n=27, 12 for n=28
    shift_amount = 32 - n  # 5 for n=27, 4 for n=28
    is_signed = (type_name == "sbyte")
    suffix = f"_{type_name}" if type_name != "byte" else ""

    # Min/Max calls differ by signedness
    if is_signed:
        min_expr = lambda v, s: f"Avx2.Min({v}.AsSByte(), {s}.AsSByte()).AsByte()"
        max_expr = lambda v, s: f"Avx2.Max({v}.AsSByte(), {s}.AsSByte()).AsByte()"
    else:
        min_expr = lambda v, s: f"Avx2.Min({v}, {s})"
        max_expr = lambda v, s: f"Avx2.Max({v}, {s})"

    lines = []
    lines.append(f"    [MethodImpl(MethodImplOptions.AggressiveOptimization)]")
    lines.append(f"    private static void SortSimd{n}{suffix}(Span<{type_name}> span)")
    lines.append(f"    {{")
    # Load: reinterpret as byte for all bitwise operations
    if is_signed:
        lines.append(f"        ref byte first = ref Unsafe.As<{type_name}, byte>(ref MemoryMarshal.GetReference(span));")
    else:
        lines.append(f"        ref byte first = ref MemoryMarshal.GetReference(span);")
    lines.append(f"        var lo = Unsafe.ReadUnaligned<Vector128<byte>>(ref first);")
    lines.append(f"        var hi = Sse2.ShiftRightLogical128BitLane(")
    lines.append(f"            Unsafe.ReadUnaligned<Vector128<byte>>(ref Unsafe.Add(ref first, {load_offset})),")
    lines.append(f"            {shift_amount});")
    lines.append(f"        var vec = Vector256.Create(lo, hi);")

    for si, step in enumerate(steps):
        perm = compute_shuffle_perm(step)
        blend = compute_blend_mask(step)
        cross = step_needs_cross_lane(step)

        pair_str = ", ".join(f"({a},{b})" for a, b in step)
        lines.append(f"")
        lines.append(f"        // Step {si}: {pair_str}")

        if cross:
            maskLo, maskHi = compute_cross_lane_masks(perm)
            lines.append(f"        {{")
            lines.append(f"            var loLo = Avx2.Permute2x128(vec, vec, 0x00);")
            lines.append(f"            var hiHi = Avx2.Permute2x128(vec, vec, 0x11);")
            lines.append(f"            var fromLo = Avx2.Shuffle(loLo, {fmt_vec256(maskLo)});")
            lines.append(f"            var fromHi = Avx2.Shuffle(hiHi, {fmt_vec256(maskHi)});")
            lines.append(f"            var shuffled = Avx2.Or(fromLo, fromHi);")
            lines.append(f"            var mins = {min_expr('vec', 'shuffled')};")
            lines.append(f"            var maxs = {max_expr('vec', 'shuffled')};")
            lines.append(f"            vec = Avx2.BlendVariable(mins, maxs, {fmt_vec256(blend)});")
            lines.append(f"        }}")
        else:
            mask = compute_intra_lane_mask(perm)
            lines.append(f"        {{")
            lines.append(f"            var shuffled = Avx2.Shuffle(vec, {fmt_vec256(mask)});")
            lines.append(f"            var mins = {min_expr('vec', 'shuffled')};")
            lines.append(f"            var maxs = {max_expr('vec', 'shuffled')};")
            lines.append(f"            vec = Avx2.BlendVariable(mins, maxs, {fmt_vec256(blend)});")
            lines.append(f"        }}")

    lines.append(f"")
    lines.append(f"        lo = vec.GetLower();")
    lines.append(f"        hi = vec.GetUpper();")
    lines.append(f"        Sse2.ShiftLeftLogical128BitLane(hi, {shift_amount})")
    lines.append(f"            .StoreUnsafe(ref Unsafe.Add(ref first, {load_offset}));")
    lines.append(f"        lo.StoreUnsafe(ref first);")
    lines.append(f"    }}")
    return "\n".join(lines)

def generate_simd_file():
    """Generate NetworkSort.Simd.cs with AVX2 byte/sbyte sorting methods."""
    lines = []
    lines.append("using System.Runtime.CompilerServices;")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("using System.Runtime.Intrinsics;")
    lines.append("using System.Runtime.Intrinsics.X86;")
    lines.append("")
    lines.append("namespace SortingNetworks;")
    lines.append("")
    lines.append("// <auto-generated>")
    lines.append("// This file was generated by generate_unrolled.py")
    lines.append("// Do not edit manually.")
    lines.append("// </auto-generated>")
    lines.append("")
    lines.append("public static partial class NetworkSort")
    lines.append("{")

    first = True
    for type_name in ["byte", "sbyte"]:
        for n in [27, 28]:
            pairs = get_network(n)
            steps = get_network_steps(n)
            if not first:
                lines.append("")
            lines.append(generate_simd_sort_method(n, steps, type_name))
            first = False

    lines.append("}")
    lines.append("")
    return "\n".join(lines)

# --- Code generation ---

def generate_unrolled_method(n, pairs, type_name):
    lines = []
    if n <= 8:
        lines.append(f"    [MethodImpl(MethodImplOptions.AggressiveInlining)]")
    lines.append(f"    private static void Sort{n}(ref {type_name} first)")
    lines.append(f"    {{")
    lines.append(f"        {type_name} e0 = first;")
    for i in range(1, n):
        lines.append(f"        {type_name} e{i} = Unsafe.Add(ref first, {i});")
    lines.append(f"")
    for a, b in pairs:
        lines.append(f"        if (e{a} > e{b}) {{ {type_name} temp = e{a}; e{a} = e{b}; e{b} = temp; }}")
    lines.append(f"")
    lines.append(f"        first = e0;")
    for i in range(1, n):
        lines.append(f"        Unsafe.Add(ref first, {i}) = e{i};")
    lines.append(f"    }}")
    return "\n".join(lines)

def generate_public_api(type_name):
    lines = []
    # Sort(Span<T>)
    lines.append(f"    /// <summary>")
    lines.append(f"    /// Sorts a span of {type_name} using a sorting network when possible.")
    lines.append(f"    /// </summary>")
    lines.append(f"    public static void Sort(Span<{type_name}> span)")
    lines.append(f"    {{")
    lines.append(f"        int n = span.Length;")
    lines.append(f"        if (n == 27 || n == 28)")
    lines.append(f"        {{")
    if type_name == "byte":
        lines.append(f"            if (Avx2.IsSupported)")
        lines.append(f"            {{")
        lines.append(f"                if (n == 27)")
        lines.append(f"                    SortSimd27(span);")
        lines.append(f"                else")
        lines.append(f"                    SortSimd28(span);")
        lines.append(f"                return;")
        lines.append(f"            }}")
        lines.append(f"")
    elif type_name == "sbyte":
        lines.append(f"            if (Avx2.IsSupported)")
        lines.append(f"            {{")
        lines.append(f"                if (n == 27)")
        lines.append(f"                    SortSimd27_sbyte(span);")
        lines.append(f"                else")
        lines.append(f"                    SortSimd28_sbyte(span);")
        lines.append(f"                return;")
        lines.append(f"            }}")
        lines.append(f"")
    lines.append(f"            ref {type_name} first = ref MemoryMarshal.GetReference(span);")
    lines.append(f"            if (n == 27)")
    lines.append(f"                Sort27(ref first);")
    lines.append(f"            else")
    lines.append(f"                Sort28(ref first);")
    lines.append(f"            return;")
    lines.append(f"        }}")
    lines.append(f"")
    lines.append(f"        span.Sort();")
    lines.append(f"    }}")
    lines.append(f"")
    # Sort(T[])
    lines.append(f"    /// <summary>")
    lines.append(f"    /// Sorts an array of {type_name} using a sorting network when possible.")
    lines.append(f"    /// </summary>")
    lines.append(f"    public static void Sort({type_name}[] array)")
    lines.append(f"    {{")
    lines.append(f"        ArgumentNullException.ThrowIfNull(array);")
    lines.append(f"        Sort(array.AsSpan());")
    lines.append(f"    }}")
    lines.append(f"")
    # Sort(Span<T>, IComparer<T>?)
    lines.append(f"    /// <summary>")
    lines.append(f"    /// Sorts a span of {type_name} using a sorting network when possible,")
    lines.append(f"    /// with a custom comparer.")
    lines.append(f"    /// </summary>")
    lines.append(f"    public static void Sort(Span<{type_name}> span, IComparer<{type_name}>? comparer)")
    lines.append(f"    {{")
    lines.append(f"        comparer ??= Comparer<{type_name}>.Default;")
    lines.append(f"        int n = span.Length;")
    lines.append(f"        if (n == 27 || n == 28)")
    lines.append(f"        {{")
    lines.append(f"            ApplyNetworkWithComparer(span, NetworkData.GetNetwork(n), comparer);")
    lines.append(f"            return;")
    lines.append(f"        }}")
    lines.append(f"")
    lines.append(f"        span.Sort(comparer);")
    lines.append(f"    }}")
    lines.append(f"")
    # Sort(T[], IComparer<T>?)
    lines.append(f"    /// <summary>")
    lines.append(f"    /// Sorts an array of {type_name} using a sorting network when possible,")
    lines.append(f"    /// with a custom comparer.")
    lines.append(f"    /// </summary>")
    lines.append(f"    public static void Sort({type_name}[] array, IComparer<{type_name}>? comparer)")
    lines.append(f"    {{")
    lines.append(f"        ArgumentNullException.ThrowIfNull(array);")
    lines.append(f"        Sort(array.AsSpan(), comparer);")
    lines.append(f"    }}")
    lines.append(f"")
    # ApplyNetworkWithComparer
    lines.append(f"    [MethodImpl(MethodImplOptions.AggressiveInlining)]")
    lines.append(f"    private static void ApplyNetworkWithComparer(Span<{type_name}> span, int[] network, IComparer<{type_name}> comparer)")
    lines.append(f"    {{")
    lines.append(f"        ref {type_name} first = ref MemoryMarshal.GetReference(span);")
    lines.append(f"        for (int i = 0; i < network.Length; i += 2)")
    lines.append(f"        {{")
    lines.append(f"            ref {type_name} a = ref Unsafe.Add(ref first, network[i]);")
    lines.append(f"            ref {type_name} b = ref Unsafe.Add(ref first, network[i + 1]);")
    lines.append(f"            if (comparer.Compare(a, b) > 0)")
    lines.append(f"            {{")
    lines.append(f"                {type_name} temp = a;")
    lines.append(f"                a = b;")
    lines.append(f"                b = temp;")
    lines.append(f"            }}")
    lines.append(f"        }}")
    lines.append(f"    }}")
    return "\n".join(lines)

def generate_api_file():
    lines = []
    lines.append("using System.Runtime.CompilerServices;")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("using System.Runtime.Intrinsics.X86;")
    lines.append("")
    lines.append("namespace SortingNetworks;")
    lines.append("")
    lines.append("// <auto-generated>")
    lines.append("// This file was generated by generate_unrolled.py")
    lines.append("// Do not edit manually.")
    lines.append("// </auto-generated>")
    lines.append("")
    lines.append("/// <summary>")
    lines.append("/// Provides sorting-network-based sorting for small collections.")
    lines.append("/// Uses fixed compare-and-swap networks for sizes up to 28, including")
    lines.append("/// depth-13 networks for 27 and 28 channels from arXiv:2511.04107.")
    lines.append("/// Falls back to the default .NET sort for larger inputs.")
    lines.append("/// </summary>")
    lines.append("public static partial class NetworkSort")
    lines.append("{")

    for i, type_name in enumerate(PRIMITIVE_TYPES):
        if i > 0:
            lines.append("")
        lines.append(generate_public_api(type_name))

    lines.append("")
    lines.append("    /// <summary>")
    lines.append("    /// Sorts an array of <typeparamref name=\"T\"/> using a sorting network when possible.")
    lines.append("    /// </summary>")
    lines.append("    public static void Sort<T>(T[] array, IComparer<T> comparer)")
    lines.append("    {")
    lines.append("        ArgumentNullException.ThrowIfNull(array);")
    lines.append("        ArgumentNullException.ThrowIfNull(comparer);")
    lines.append("        int n = array.Length;")
    lines.append("        if (n == 27 || n == 28)")
    lines.append("        {")
    lines.append("            int[] network = NetworkData.GetNetwork(n);")
    lines.append("            for (int i = 0; i < network.Length; i += 2)")
    lines.append("            {")
    lines.append("                int ai = network[i], bi = network[i + 1];")
    lines.append("                if (comparer.Compare(array[ai], array[bi]) > 0)")
    lines.append("                {")
    lines.append("                    T temp = array[ai];")
    lines.append("                    array[ai] = array[bi];")
    lines.append("                    array[bi] = temp;")
    lines.append("                }")
    lines.append("            }")
    lines.append("            return;")
    lines.append("        }")
    lines.append("")
    lines.append("        Array.Sort(array, comparer);")
    lines.append("    }")

    lines.append("}")
    lines.append("")
    return "\n".join(lines)

def generate_unrolled_file():
    lines = []
    lines.append("using System.Runtime.CompilerServices;")
    lines.append("using System.Runtime.InteropServices;")
    lines.append("")
    lines.append("namespace SortingNetworks;")
    lines.append("")
    lines.append("// <auto-generated>")
    lines.append("// This file was generated by generate_unrolled.py")
    lines.append("// Do not edit manually.")
    lines.append("// </auto-generated>")
    lines.append("")
    lines.append("public static partial class NetworkSort")
    lines.append("{")

    first_method = True
    for type_name in PRIMITIVE_TYPES:
        for n in [27, 28]:
            pairs = get_network(n)
            if not first_method:
                lines.append("")
            lines.append(generate_unrolled_method(n, pairs, type_name))
            first_method = False

    lines.append("}")
    lines.append("")
    return "\n".join(lines)

if __name__ == "__main__":
    base_dir = sys.argv[1] if len(sys.argv) > 1 else "SortingNetworks"

    api_path = os.path.join(base_dir, "NetworkSort.cs")
    api_output = generate_api_file()
    with open(api_path, "w", encoding="utf-8") as f:
        f.write(api_output)
    print(f"Generated {api_path}")

    unrolled_path = os.path.join(base_dir, "NetworkSort.Unrolled.cs")
    unrolled_output = generate_unrolled_file()
    with open(unrolled_path, "w", encoding="utf-8") as f:
        f.write(unrolled_output)
    print(f"Generated {unrolled_path}")

    simd_path = os.path.join(base_dir, "NetworkSort.Simd.cs")
    simd_output = generate_simd_file()
    with open(simd_path, "w", encoding="utf-8") as f:
        f.write(simd_output)
    print(f"Generated {simd_path}")

    # Print stats
    for n in [27, 28]:
        pairs = get_network(n)
        steps = get_network_steps(n)
        print(f"  Sort{n}: {len(pairs)} compare-swaps, {len(steps)} SIMD steps")
    print(f"  Types: {', '.join(PRIMITIVE_TYPES)}")
