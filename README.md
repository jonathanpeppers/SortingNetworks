# SortingNetworks

A .NET library that uses sorting-network-based specializations for small
collections. For sizes up to 28, elements are sorted via fixed
compare-and-swap sequences -- including depth-13 networks for 27 and 28
channels from the paper
["Depth-13 Sorting Networks for 28 Channels"](https://arxiv.org/abs/2511.04107).
Larger inputs fall back to the default .NET sort.

## Usage

```csharp
using SortingNetworks;

int[] data = { 5, 3, 1, 4, 2 };
NetworkSort.Sort(data);            // IComparable<T> path
NetworkSort.Sort(data, comparer);  // IComparer<T> path

Span<int> span = stackalloc int[] { 5, 3, 1, 4, 2 };
NetworkSort.Sort(span);
```

## Design

| Input size | Strategy |
|---|---|
| 0-1 | No-op |
| 2-26 | Batcher's odd-even merge sort network |
| 27-28 | Depth-13 networks from arXiv:2511.04107 |
| 29+ | Fallback to `Span<T>.Sort()` / `Array.Sort()` |

Sorting networks execute a fixed sequence of compare-and-swap operations
determined entirely by the input length. This eliminates branches and enables
predictable performance for small arrays. The 27- and 28-channel networks are
derived from the paper's reflection-symmetric construction that improved the
previous best depth bound from 14 to 13.

## Building

```
dotnet build
dotnet test
dotnet run --project SortingNetworks.Benchmarks -c Release -- --filter *
```

## Projects

- **SortingNetworks** -- class library (future NuGet package)
- **SortingNetworks.Tests** -- xUnit correctness tests covering lengths 0-64,
  int/string types, sorted/reversed/duplicate inputs, and the 27/28-element
  specialized paths
- **SortingNetworks.Benchmarks** -- BenchmarkDotNet benchmarks comparing
  `NetworkSort.Sort` vs `Array.Sort` / `Span<T>.Sort` across multiple sizes
  and input distributions

## Paper reference

> Chengu Wang, "Depth-13 Sorting Networks for 28 Channels", arXiv:2511.04107, 2025.
>
> Establishes new depth upper bounds for sorting networks on 27 and 28
> channels, improving the previous best bound of 14 to 13. The 28-channel
> network is constructed with reflectional symmetry by combining high-quality
> prefixes of 16- and 12-channel networks, extending them greedily one
> comparator at a time, and using a SAT solver to complete the remaining
> layers.
