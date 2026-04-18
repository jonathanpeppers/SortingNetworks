# SortingNetworks

A .NET library that uses sorting-network-based specializations for small
arrays of sizes 27 and 28 -- using depth-13 networks from the paper
["Depth-13 Sorting Networks for 28 Channels"](https://arxiv.org/abs/2511.04107).
All other sizes fall back to the default .NET sort.

Overloads are provided for every primitive .NET type: `byte`, `sbyte`,
`short`, `ushort`, `int`, `uint`, `long`, `ulong`, `nint`, `nuint`,
`char`, `float`, and `double`.

## Usage

```csharp
using SortingNetworks;

int[] data = { 5, 3, 1, 4, 2 };
NetworkSort.Sort(data);
NetworkSort.Sort(data, comparer);  // IComparer<int> path

Span<int> span = stackalloc int[] { 5, 3, 1, 4, 2 };
NetworkSort.Sort(span);

// Works with any primitive type
double[] doubles = { 3.14, 1.41, 2.72 };
NetworkSort.Sort(doubles);

byte[] bytes = { 0xFF, 0x01, 0x80 };
NetworkSort.Sort(bytes);
```

## Design

| Input size | Strategy |
|---|---|
| 27-28 | Depth-13 networks from arXiv:2511.04107 |
| All other sizes | Fallback to `Span<T>.Sort()` / `Array.Sort()` |

Sorting networks execute a fixed sequence of compare-and-swap operations
determined entirely by the input length. This eliminates branches and enables
predictable performance. The 27- and 28-channel networks are derived from the
paper's reflection-symmetric construction that improved the previous best depth
bound from 14 to 13.

The unrolled methods use type-specific comparisons (`>` operator) instead of
generic `CompareTo()` calls, which compiles to a single CPU comparison
instruction and matches the performance of the BCL's internal sort helpers.

## Benchmarks

Results comparing `NetworkSort` vs `Array.Sort` on .NET 10 (Intel Core
i9-9900K):

### Types where NetworkSort is significantly faster (10-17x)

For types **without** a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,382 ns | 93 ns | **15x** |
| sbyte | 1,437 ns | 134 ns | **11x** |
| short | 1,481 ns | 97 ns | **15x** |
| ushort | 1,395 ns | 96 ns | **14x** |
| float | 1,575 ns | 102 ns | **15x** |
| double | 1,775 ns | 104 ns | **17x** |
| long | 1,453 ns | 99 ns | **15x** |
| nint | 1,436 ns | 98 ns | **15x** |
| nuint | 1,423 ns | 98 ns | **14x** |

### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `int`, `uint`, `char`, and
`ulong`. For these types the BCL is already very fast and NetworkSort
provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| int | 100 ns | 79-167 ns | ~1x |
| uint | 101 ns | 96 ns | ~1x |
| char | 109 ns | 93 ns | ~1.2x |
| ulong | 147 ns | 97 ns | ~1.5x |

### int detailed results (SIMD-optimized baseline)

| Size | Kind | NetworkSort_Span | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 167 ns | 1.67x |
| 27 | Sorted | 70 ns | **1.08x** |
| 27 | Reversed | 98 ns | 1.13x |
| 27 | Duplicates | 79 ns | **0.77x** (23% faster) |
| 28 | Random | 99 ns | **0.87x** (13% faster) |
| 28 | Sorted | 73 ns | **1.08x** |
| 28 | Reversed | 91 ns | **1.09x** |
| 28 | Duplicates | 81 ns | **0.74x** (26% faster) |

## Building

```
dotnet build
dotnet test
dotnet run --project SortingNetworks.Benchmarks -c Release -- --filter *
```

## Code generation

The `NetworkSort.cs` and `NetworkSort.Unrolled.cs` files are auto-generated
by `generate_unrolled.py`. To regenerate after changing the script:

```
python generate_unrolled.py
```

## Projects

- **SortingNetworks** -- class library (future NuGet package)
- **SortingNetworks.Tests** -- xUnit correctness tests covering lengths 0-64
  across all 13 primitive types, various input patterns, and the 27/28-element
  specialized paths (1,265 tests)
- **SortingNetworks.Benchmarks** -- BenchmarkDotNet benchmarks comparing
  `NetworkSort.Sort` vs `Array.Sort` for sizes 27 and 28 across all primitive
  types

## Paper reference

> Chengu Wang, "Depth-13 Sorting Networks for 28 Channels", arXiv:2511.04107, 2025.
>
> Establishes new depth upper bounds for sorting networks on 27 and 28
> channels, improving the previous best bound of 14 to 13. The 28-channel
> network is constructed with reflectional symmetry by combining high-quality
> prefixes of 16- and 12-channel networks, extending them greedily one
> comparator at a time, and using a SAT solver to complete the remaining
> layers.
