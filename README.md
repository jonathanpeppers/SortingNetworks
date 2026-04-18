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

// Length 27 uses a depth-13 sorting network
int[] data = {
    27, 26, 25, 24, 23, 22, 21, 20, 19,
    18, 17, 16, 15, 14, 13, 12, 11, 10,
     9,  8,  7,  6,  5,  4,  3,  2,  1,
};
NetworkSort.Sort(data);
NetworkSort.Sort(data, comparer);  // IComparer<int> path

// Length 27 uses a depth-13 sorting network
Span<int> span = stackalloc int[] {
    27, 26, 25, 24, 23, 22, 21, 20, 19,
    18, 17, 16, 15, 14, 13, 12, 11, 10,
     9,  8,  7,  6,  5,  4,  3,  2,  1,
};
NetworkSort.Sort(span);

// Works with any primitive type
double[] doubles = { 3.14, 1.41, 2.72 };
NetworkSort.Sort(doubles);

byte[] bytes = { 0xFF, 0x01, 0x80 };
NetworkSort.Sort(bytes);

// Generic Sort<T> for non-primitive types like string
string[] names = { "Charlie", "Alice", "Bob" };
NetworkSort.Sort(names, StringComparer.Ordinal);
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
| byte | 1,366 ns | 92 ns | **15x** |
| sbyte | 1,468 ns | 97 ns | **15x** |
| short | 1,505 ns | 97 ns | **16x** |
| ushort | 1,372 ns | 96 ns | **14x** |
| float | 1,565 ns | 102 ns | **15x** |
| double | 1,745 ns | 109 ns | **16x** |
| long | 1,450 ns | 98 ns | **15x** |
| nint | 1,466 ns | 99 ns | **15x** |
| nuint | 1,496 ns | 95 ns | **16x** |

### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `int`, `uint`, `char`, and
`ulong`. For these types the BCL is already very fast and NetworkSort
provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| int | 99 ns | 96 ns | ~1x |
| uint | 104 ns | 96 ns | ~1x |
| char | 88 ns | 92 ns | ~1x |
| ulong | 132 ns | 97 ns | ~1.4x |

### string (generic `Sort<T>` path)

The generic `Sort<T>(T[], IComparer<T>)` path uses the comparer-based
network (not unrolled), which is slower than `Array.Sort` for reference types:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| string | 952 ns | 3,625 ns | 0.26x (slower) |

### int detailed results (SIMD-optimized baseline)

| Size | Kind | NetworkSort_Span | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 96 ns | **0.97x** (tied) |
| 27 | Sorted | 69 ns | **1.07x** |
| 27 | Reversed | 97 ns | 1.18x |
| 27 | Duplicates | 78 ns | **0.76x** (24% faster) |
| 28 | Random | 105 ns | **0.92x** |
| 28 | Sorted | 72 ns | **1.08x** |
| 28 | Reversed | 87 ns | **1.04x** (tied) |
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
  across all 13 primitive types, plus string via the generic `Sort<T>`
  overload (1,332 tests)
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
