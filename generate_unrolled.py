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
    lines.append(f"        => Sort(array.AsSpan());")
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
    lines.append(f"        => Sort(array.AsSpan(), comparer);")
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

    # Print stats
    for n in [27, 28]:
        pairs = get_network(n)
        print(f"  Sort{n}: {len(pairs)} compare-swaps")
    print(f"  Types: {', '.join(PRIMITIVE_TYPES)}")
