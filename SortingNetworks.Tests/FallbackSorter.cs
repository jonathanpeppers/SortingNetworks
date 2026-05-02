using SortingNetworks;

namespace SortingNetworks.Tests;

[SortingNetwork(4, typeof(int))]
[SortingNetwork(4, typeof(double))]
partial class FallbackSorter
{
    static void OnFallback(Span<int> span)
    {
        span.Sort();
    }

    static void OnFallback(Span<double> span)
    {
        span.Sort();
    }
}
