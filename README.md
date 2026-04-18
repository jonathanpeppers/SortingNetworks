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

### Types where NetworkSort is significantly faster (14-16x)

For types **without** a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,356 ns | 98 ns | **14x** |
| sbyte | 1,524 ns | 97 ns | **16x** |
| short | 1,462 ns | 97 ns | **15x** |
| ushort | 1,562 ns | 97 ns | **16x** |
| float | 1,646 ns | 105 ns | **16x** |
| double | 1,726 ns | 109 ns | **16x** |
| long | 1,523 ns | 99 ns | **15x** |
| nint | 1,481 ns | 104 ns | **14x** |
| nuint | 1,505 ns | 102 ns | **15x** |

### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `int`, `uint`, `char`, and
`ulong`. For these types the BCL is already very fast and NetworkSort
provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| int | 105 ns | 100 ns | ~1x |
| uint | 100 ns | 97 ns | ~1x |
| char | 97 ns | 94 ns | ~1x |
| ulong | 119 ns | 96 ns | ~1.2x |

### string (generic `Sort<T>` path)

The generic `Sort<T>(T[], IComparer<T>)` path uses the comparer-based
network (not unrolled), which is slower than `Array.Sort` for reference types:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| string | 918 ns | 3,626 ns | 0.25x (slower) |

### int detailed results (SIMD-optimized baseline)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 100 ns | **0.95x** (tied) |
| 27 | Sorted | 92 ns | 1.31x |
| 27 | Reversed | 101 ns | 1.19x |
| 27 | Duplicates | 92 ns | **0.89x** (11% faster) |
| 28 | Random | 102 ns | **0.84x** (16% faster) |
| 28 | Sorted | 73 ns | **1.01x** (tied) |
| 28 | Reversed | 87 ns | **0.99x** (tied) |
| 28 | Duplicates | 82 ns | **0.77x** (23% faster) |

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
