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
}
