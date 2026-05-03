using SortingNetworks;

namespace SortingNetworks.Tests;

[HybridSortingNetwork(typeof(int))]
[HybridSortingNetwork(typeof(byte))]
[HybridSortingNetwork(typeof(sbyte))]
[HybridSortingNetwork(typeof(short))]
[HybridSortingNetwork(typeof(ushort))]
[HybridSortingNetwork(typeof(long))]
[HybridSortingNetwork(typeof(ulong))]
[HybridSortingNetwork(typeof(uint))]
[HybridSortingNetwork(typeof(float))]
[HybridSortingNetwork(typeof(double))]
[HybridSortingNetwork(typeof(char))]
partial class HybridSorter { }
