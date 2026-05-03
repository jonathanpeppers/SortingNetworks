using SortingNetworks;

namespace SortingNetworks.Tests;

[HybridSortingNetwork(typeof(int))]
[HybridSortingNetwork(typeof(byte))]
[HybridSortingNetwork(typeof(short))]
[HybridSortingNetwork(typeof(long))]
[HybridSortingNetwork(typeof(float))]
[HybridSortingNetwork(typeof(double))]
partial class HybridSorter { }
