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

// Span overload also uses the sorting network
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

// Specialized string overload using ordinal comparison
string[] names = { "Charlie", "Alice", "Bob" };
NetworkSort.Sort(names);
NetworkSort.Sort(names, StringComparer.OrdinalIgnoreCase);  // custom comparer

// Generic Sort<T> for other non-primitive types
NetworkSort.Sort(myArray, myComparer);
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

For `byte` and `sbyte`, the library additionally uses SIMD vectorization
when available — AVX2 on x86 and AdvSimd (NEON) on ARM64. All 27-28 elements
fit in a single vector register, allowing each of the 13 network steps to
execute as a vectorized shuffle + min/max + blend operation instead of
individual scalar compare-and-swap branches. On platforms without SIMD support,
this falls back to the scalar unrolled sort.

## Benchmarks

### x86 (Intel Core i9-9900K, AVX2)

Results comparing `NetworkSort` vs `Array.Sort` on .NET 10:

#### Types where NetworkSort is significantly faster

For `byte` and `sbyte`, the library uses AVX2 SIMD vectorization -- all 27-28
elements fit in a single `Vector256<byte>` register, enabling each network step
to execute as a vectorized min/max/blend operation:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,369 ns | 40 ns | **34x** |
| sbyte | 1,535 ns | 42 ns | **37x** |

For other types without a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| short | 1,671 ns | 97 ns | **17x** |
| ushort | 1,469 ns | 97 ns | **15x** |
| float | 1,657 ns | 104 ns | **16x** |
| double | 1,726 ns | 108 ns | **16x** |
| long | 1,495 ns | 102 ns | **15x** |
| nint | 1,472 ns | 100 ns | **15x** |
| nuint | 1,471 ns | 104 ns | **14x** |

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `int`, `uint`, `char`, and
`ulong`. For these types the BCL is already very fast and NetworkSort
provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| int | 106 ns | 99 ns | ~1x |
| uint | 103 ns | 95 ns | ~1x |
| char | 87 ns | 94 ns | ~1x |
| ulong | 114 ns | 97 ns | ~1.2x |

> **Note:** These results are from an Intel Core i9-9900K. On processors with AVX-512 (e.g., Xeon), Array.Sort is even more optimized and NetworkSort may be slower for these types.

#### string (specialized `Sort(string[])` path)

The specialized `Sort(string[])` overload uses `string.CompareOrdinal` in the
unrolled network, avoiding `IComparer<T>` interface dispatch overhead:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| string | 943 ns | 527 ns | **1.8x** |

### ARM64 (Apple M1, AdvSimd/NEON)

On ARM64, the library uses AdvSimd (NEON) intrinsics for `byte` and `sbyte`,
achieving ~4.7x speedup over the scalar unrolled path:

| Type | Length | Scalar (main) | NEON SIMD (PR) | Speedup |
|---|---|---|---|---|
| byte | 27 | 92 ns | 20 ns | **4.7x** |
| byte | 28 | 96 ns | 20 ns | **4.7x** |
| sbyte | 27 | 99 ns | 22 ns | **4.5x** |
| sbyte | 28 | 100 ns | 21 ns | **4.7x** |

For other types, the unrolled scalar sorting network provides the same large
speedup over `Array.Sort` as on x86:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| double | 1,568 ns | 102 ns | **15x** |
| float | 1,496 ns | 100 ns | **15x** |
| long | 1,472 ns | 100 ns | **15x** |
| short | 1,443 ns | 93 ns | **16x** |

### int detailed results (SIMD-optimized baseline)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 99 ns | **0.94x** (tied) |
| 27 | Sorted | 73 ns | 1.11x |
| 27 | Reversed | 99 ns | 1.22x |
| 27 | Duplicates | 81 ns | **0.78x** (22% faster) |
| 28 | Random | 100 ns | **0.86x** (14% faster) |
| 28 | Sorted | 74 ns | **1.03x** (tied) |
| 28 | Reversed | 88 ns | **0.98x** (tied) |
| 28 | Duplicates | 83 ns | **0.74x** (26% faster) |

> Results vary by hardware and run. Sorting networks execute a fixed comparison sequence regardless of input order, so they don't benefit from already-sorted or reversed patterns the way adaptive sorts can.

## Building

```
dotnet build
dotnet test
dotnet run --project SortingNetworks.Benchmarks -c Release -- --filter *
```

## Code generation

The `NetworkSort.cs`, `NetworkSort.Unrolled.cs`, `NetworkSort.Simd.cs`, and
`NetworkSort.Simd.Arm.cs` files are auto-generated by `generate_unrolled.cs`.
To regenerate after changing the script:

```
dotnet run generate_unrolled.cs
```

## Projects

- **SortingNetworks** -- class library (future NuGet package)
- **SortingNetworks.Tests** -- xUnit correctness tests covering lengths 27-28
  across all 13 primitive types, plus string via the specialized `Sort(string[])`
  overload, with stress tests using 100 random seeds (81 tests)
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
