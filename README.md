# SortingNetworks

A .NET library that uses sorting-network-based specializations for `int`
arrays of sizes 27 and 28 -- using depth-13 networks from the paper
["Depth-13 Sorting Networks for 28 Channels"](https://arxiv.org/abs/2511.04107).
All other sizes fall back to the default .NET sort.

## Usage

```csharp
using SortingNetworks;

int[] data = { 5, 3, 1, 4, 2 };
NetworkSort.Sort(data);
NetworkSort.Sort(data, comparer);  // IComparer<int> path

Span<int> span = stackalloc int[] { 5, 3, 1, 4, 2 };
NetworkSort.Sort(span);
```

## Design

| Input size | Strategy |
|---|---|
| 27-28 | Depth-13 networks from arXiv:2511.04107 |
| All other sizes | Fallback to `Span<int>.Sort()` / `Array.Sort()` |

Sorting networks execute a fixed sequence of compare-and-swap operations
determined entirely by the input length. This eliminates branches and enables
predictable performance. The 27- and 28-channel networks are derived from the
paper's reflection-symmetric construction that improved the previous best depth
bound from 14 to 13.

The unrolled methods use `int`-specific comparisons (`>` operator) instead of
generic `CompareTo()` calls, which compiles to a single CPU comparison
instruction and matches the performance of the BCL's internal sort helpers.

## Benchmarks

Results comparing `NetworkSort` vs `Array.Sort` on .NET 10:

| Size | Kind | NetworkSort_Span | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 97.3 ns | **1.00x** (tied) |
| 27 | Sorted | 68.4 ns | 1.04x |
| 27 | Reversed | 97.6 ns | 1.19x |
| 27 | Duplicates | 80.0 ns | **0.77x** (23% faster) |
| 28 | Random | 98.7 ns | **0.84x** (16% faster) |
| 28 | Sorted | 70.7 ns | **0.97x** (tied) |
| 28 | Reversed | 87.0 ns | **1.00x** (tied) |
| 28 | Duplicates | 80.7 ns | **0.73x** (27% faster) |

## Building

```
dotnet build
dotnet test
dotnet run --project SortingNetworks.Benchmarks -c Release -- --filter *
```

## Projects

- **SortingNetworks** -- class library (future NuGet package)
- **SortingNetworks.Tests** -- xUnit correctness tests covering lengths 0-64,
  various input patterns, and the 27/28-element specialized paths
- **SortingNetworks.Benchmarks** -- BenchmarkDotNet benchmarks comparing
  `NetworkSort.Sort` vs `Array.Sort` / `Span<int>.Sort` for sizes 27 and 28
  across multiple input distributions

## Paper reference

> Chengu Wang, "Depth-13 Sorting Networks for 28 Channels", arXiv:2511.04107, 2025.
>
> Establishes new depth upper bounds for sorting networks on 27 and 28
> channels, improving the previous best bound of 14 to 13. The 28-channel
> network is constructed with reflectional symmetry by combining high-quality
> prefixes of 16- and 12-channel networks, extending them greedily one
> comparator at a time, and using a SAT solver to complete the remaining
> layers.
