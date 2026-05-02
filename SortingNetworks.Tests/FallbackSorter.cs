using SortingNetworks;

namespace SortingNetworks.Tests;

[SortingNetwork(4, typeof(int))]
[SortingNetwork(4, typeof(double))]
partial class FallbackSorter
{
    internal static int FallbackCallCount;

    static void OnFallback(Span<int> span)
    {
        FallbackCallCount++;
        span.Sort();
    }

    static void OnFallback(Span<int> span, System.Collections.Generic.IComparer<int> comparer)
    {
        FallbackCallCount++;
        int[] temp = span.ToArray();
        Array.Sort(temp, comparer);
        temp.CopyTo(span);
    }

    static void OnFallback(Span<double> span)
    {
        FallbackCallCount++;
        span.Sort();
    }

    static void OnFallback(Span<double> span, System.Collections.Generic.IComparer<double> comparer)
    {
        FallbackCallCount++;
        double[] temp = span.ToArray();
        Array.Sort(temp, comparer);
        temp.CopyTo(span);
    }
}
