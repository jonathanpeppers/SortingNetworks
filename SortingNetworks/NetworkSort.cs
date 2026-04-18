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
    /// Sorts a span of int using a sorting network when possible.
    /// </summary>
    public static void Sort(Span<int> span)
    {
        int n = span.Length;
        if (n == 27 || n == 28)
        {
            ref int first = ref MemoryMarshal.GetReference(span);
            if (n == 27)
                Sort27(ref first);
            else
                Sort28(ref first);
            return;
        }

        span.Sort();
    }

    /// <summary>
    /// Sorts an array of int using a sorting network when possible.
    /// </summary>
    public static void Sort(int[] array)
        => Sort(array.AsSpan());

    /// <summary>
    /// Sorts a span of int using a sorting network when possible,
    /// with a custom comparer.
    /// </summary>
    public static void Sort(Span<int> span, IComparer<int>? comparer)
    {
        comparer ??= Comparer<int>.Default;
        int n = span.Length;
        if (n == 27 || n == 28)
        {
            ApplyNetworkWithComparer(span, NetworkData.GetNetwork(n), comparer);
            return;
        }

        span.Sort(comparer.Compare);
    }

    /// <summary>
    /// Sorts an array of int using a sorting network when possible,
    /// with a custom comparer.
    /// </summary>
    public static void Sort(int[] array, IComparer<int>? comparer)
        => Sort(array.AsSpan(), comparer);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void ApplyNetworkWithComparer(Span<int> span, int[] network, IComparer<int> comparer)
    {
        ref int first = ref MemoryMarshal.GetReference(span);
        for (int i = 0; i < network.Length; i += 2)
        {
            ref int a = ref Unsafe.Add(ref first, network[i]);
            ref int b = ref Unsafe.Add(ref first, network[i + 1]);
            if (comparer.Compare(a, b) > 0)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }
}
