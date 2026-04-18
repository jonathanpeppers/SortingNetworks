using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SortingNetworks;

/// <summary>
/// Provides sorting-network-based sorting for small collections.
/// Uses fixed compare-and-swap networks for sizes up to 28, including
/// depth-13 networks for 27 and 28 channels from arXiv:2511.04107.
/// Falls back to the default .NET sort for larger inputs.
/// </summary>
public static partial class NetworkSort
{
    /// <summary>
    /// Sorts the elements of a span using a sorting network when possible.
    /// </summary>
    public static void Sort<T>(Span<T> span) where T : IComparable<T>
    {
        int n = span.Length;
        if (n <= 1) return;

        if (n <= NetworkData.MaxNetworkSize)
        {
            ref T first = ref MemoryMarshal.GetReference(span);

            // For larger networks, an O(n) sorted check avoids running
            // all comparators on already-sorted input.
            if (n >= 9 && IsSorted(ref first, n))
                return;

            switch (n)
            {
                case 2: Sort2(ref first); return;
                case 3: Sort3(ref first); return;
                case 4: Sort4(ref first); return;
                case 5: Sort5(ref first); return;
                case 6: Sort6(ref first); return;
                case 7: Sort7(ref first); return;
                case 8: Sort8(ref first); return;
                case 9: Sort9(ref first); return;
                case 10: Sort10(ref first); return;
                case 11: Sort11(ref first); return;
                case 12: Sort12(ref first); return;
                case 13: Sort13(ref first); return;
                case 14: Sort14(ref first); return;
                case 15: Sort15(ref first); return;
                case 16: Sort16(ref first); return;
                case 17: Sort17(ref first); return;
                case 18: Sort18(ref first); return;
                case 19: Sort19(ref first); return;
                case 20: Sort20(ref first); return;
                case 21: Sort21(ref first); return;
                case 22: Sort22(ref first); return;
                case 23: Sort23(ref first); return;
                case 24: Sort24(ref first); return;
                case 25: Sort25(ref first); return;
                case 26: Sort26(ref first); return;
                case 27: Sort27(ref first); return;
                case 28: Sort28(ref first); return;
            }
        }

        span.Sort();
    }

    /// <summary>
    /// Sorts the elements of a span using a sorting network when possible,
    /// with a custom comparer.
    /// </summary>
    public static void Sort<T>(Span<T> span, IComparer<T>? comparer)
    {
        comparer ??= Comparer<T>.Default;
        int n = span.Length;
        if (n <= 1) return;

        if (n <= NetworkData.MaxNetworkSize)
        {
            ApplyNetworkWithComparer(span, NetworkData.GetNetwork(n), comparer);
            return;
        }

        span.Sort(comparer.Compare);
    }

    /// <summary>
    /// Sorts an array using a sorting network when possible.
    /// </summary>
    public static void Sort<T>(T[] array) where T : IComparable<T>
        => Sort(array.AsSpan());

    /// <summary>
    /// Sorts an array using a sorting network when possible,
    /// with a custom comparer.
    /// </summary>
    public static void Sort<T>(T[] array, IComparer<T>? comparer)
        => Sort(array.AsSpan(), comparer);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void ApplyNetwork<T>(Span<T> span, int[] network) where T : IComparable<T>
    {
        ref T first = ref MemoryMarshal.GetReference(span);
        for (int i = 0; i < network.Length; i += 2)
        {
            ref T a = ref Unsafe.Add(ref first, network[i]);
            ref T b = ref Unsafe.Add(ref first, network[i + 1]);
            if (a.CompareTo(b) > 0)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void ApplyNetworkWithComparer<T>(Span<T> span, int[] network, IComparer<T> comparer)
    {
        ref T first = ref MemoryMarshal.GetReference(span);
        for (int i = 0; i < network.Length; i += 2)
        {
            ref T a = ref Unsafe.Add(ref first, network[i]);
            ref T b = ref Unsafe.Add(ref first, network[i + 1]);
            if (comparer.Compare(a, b) > 0)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }
    }

    /// <summary>
    /// Fast comparison that bypasses CompareTo for primitive types.
    /// The JIT constant-folds typeof checks and eliminates boxing,
    /// compiling to a single comparison instruction for primitives.
    /// Same pattern used by the BCL in ArraySortHelper.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static bool GreaterThan<T>(T left, T right) where T : IComparable<T>
    {
        if (typeof(T) == typeof(byte)) return (byte)(object)left! > (byte)(object)right!;
        if (typeof(T) == typeof(sbyte)) return (sbyte)(object)left! > (sbyte)(object)right!;
        if (typeof(T) == typeof(ushort)) return (ushort)(object)left! > (ushort)(object)right!;
        if (typeof(T) == typeof(short)) return (short)(object)left! > (short)(object)right!;
        if (typeof(T) == typeof(uint)) return (uint)(object)left! > (uint)(object)right!;
        if (typeof(T) == typeof(int)) return (int)(object)left! > (int)(object)right!;
        if (typeof(T) == typeof(ulong)) return (ulong)(object)left! > (ulong)(object)right!;
        if (typeof(T) == typeof(long)) return (long)(object)left! > (long)(object)right!;
        if (typeof(T) == typeof(nuint)) return (nuint)(object)left! > (nuint)(object)right!;
        if (typeof(T) == typeof(nint)) return (nint)(object)left! > (nint)(object)right!;
        if (typeof(T) == typeof(float)) return (float)(object)left! > (float)(object)right!;
        if (typeof(T) == typeof(double)) return (double)(object)left! > (double)(object)right!;
        return left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Compare-and-swap two elements in-place using their offsets from a base reference.
    /// Used by larger sorting networks (17+ elements) to avoid loading all
    /// values into locals, which causes register spills at those sizes.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static void SwapIfGreater<T>(ref T first, int i, int j) where T : IComparable<T>
    {
        ref T a = ref Unsafe.Add(ref first, i);
        ref T b = ref Unsafe.Add(ref first, j);
        if (GreaterThan(a, b))
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsSorted<T>(ref T first, int n) where T : IComparable<T>
    {
        for (int i = 0; i < n - 1; i++)
        {
            if (GreaterThan(Unsafe.Add(ref first, i), Unsafe.Add(ref first, i + 1)))
                return false;
        }
        return true;
    }
}
