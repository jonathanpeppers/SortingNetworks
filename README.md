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
individual scalar compare-and-swap branches.

For `int` and `uint`, AVX2 SIMD is used on x86 with four `Vector256<int>`
registers (8 elements each). Cross-vector shuffles use `PermuteVar8x32` with
`Blend` composition, and `Min`/`Max` handles signed and unsigned comparisons.

For `short`, `ushort`, and `char` (16-bit types), AVX-512 SIMD is used on x86
when available, packing all elements into a single `Vector512<ushort>`. On
ARM64, four `Vector128<byte>` vectors with `VectorTableLookup` (TBL4) provide
cross-vector shuffles for the same 16-bit types. On platforms without SIMD
support, this falls back to the scalar unrolled sort.

For `int`, `uint`, and `float` (32-bit types), ARM64 AdvSimd SIMD is used when
available. The 27-28 elements require seven `Vector128` registers — exceeding
TBL4's 4-register table limit. This is solved with a two-stage TBL/TBX lookup:
elements 0-15 are in Table A and elements 16-27 are in Table B, with
`VectorTableLookupExtension` (TBX) chaining the results. On x86, `int` and
`uint` use AVX2 SIMD (see above), while `float` falls back to the scalar
unrolled sort.

## Benchmarks

### x86 (Intel Core i9-9900K, AVX2)

Results comparing `NetworkSort` vs `Array.Sort` on .NET 10:

#### Types where NetworkSort is significantly faster

For `byte` and `sbyte`, the library uses AVX2 SIMD vectorization -- all 27-28
elements fit in a single `Vector256<byte>` register, enabling each network step
to execute as a vectorized min/max/blend operation:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,284 ns | 41 ns | **31x** |
| sbyte | 1,427 ns | 44 ns | **32x** |

For `int` and `uint`, AVX2 SIMD uses four `Vector256<int>` registers with
cross-vector shuffles via `PermuteVar8x32`:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| int | 103 ns | 58 ns | **1.8x** |
| uint | 106 ns | 55 ns | **1.9x** |

For other types without a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| short | 1,411 ns | 101 ns | **14x** |
| ushort | 1,288 ns | 100 ns | **13x** |
| float | 1,598 ns | 107 ns | **15x** |
| double | 1,630 ns | 110 ns | **15x** |
| long | 1,398 ns | 104 ns | **13x** |
| nint | 1,408 ns | 105 ns | **13x** |
| nuint | 1,381 ns | 103 ns | **13x** |

> **Note:** On processors with AVX-512, `short`, `ushort`, and `char` use AVX-512 SIMD (packing all 27-28 elements into a single `Vector512<ushort>`) for even greater speedups.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `char` and `ulong`. For these
types the BCL is already very fast and NetworkSort provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| char | 94 ns | 96 ns | ~1x |
| ulong | 120 ns | 100 ns | ~1.2x |

> **Note:** These results are from an Intel Core i9-9900K. On processors with AVX-512 (e.g., Xeon), Array.Sort is even more optimized and NetworkSort may be slower for these types.

#### string (specialized `Sort(string[])` path)

The specialized `Sort(string[])` overload uses `string.CompareOrdinal` in the
unrolled network, avoiding `IComparer<T>` interface dispatch overhead:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| string | 986 ns | 532 ns | **1.9x** |

### ARM64 (Apple M1, AdvSimd/NEON)

On ARM64, the library uses AdvSimd (NEON) intrinsics for `byte`, `sbyte`,
`short`, `ushort`, `char`, `int`, `uint`, and `float`:

#### SIMD-accelerated types

For `byte` and `sbyte`, all elements fit in two `Vector128<byte>` registers.
For `short` and `ushort`, four `Vector128<byte>` registers with TBL4
cross-vector shuffles are used:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,211 ns | 26 ns | **47x** |
| sbyte | 1,358 ns | 31 ns | **44x** |
| short | 1,382 ns | 53 ns | **26x** |
| ushort | 1,242 ns | 55 ns | **23x** |

For `int`, `uint`, and `float`, seven `Vector128` registers with two-stage
TBL/TBX cross-vector shuffles are used:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| float | 1,504 ns | 85 ns | **18x** |

> **Note:** `float` benefits enormously because .NET's `Array.Sort` does not
> have a SIMD-accelerated path for `float` on ARM64.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort for `char`, `int`, and `uint` on ARM64.
NetworkSort's NEON path still provides improvements:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| char | 102 ns | 51 ns | **2x** |
| int | 102 ns | 86 ns | **1.2x** |
| uint | 114 ns | 81 ns | **1.4x** |

#### Other types (scalar unrolled network)

For other types, the unrolled scalar sorting network provides the same large
speedup over `Array.Sort` as on x86:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| double | 1,478 ns | 110 ns | **13x** |
| long | 1,472 ns | 100 ns | **15x** |

### int detailed results (AVX2 SIMD)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 58 ns | **0.57x** (43% faster) |
| 27 | Sorted | 58 ns | **0.82x** (18% faster) |
| 27 | Reversed | 57 ns | **0.67x** (33% faster) |
| 27 | Duplicates | 57 ns | **0.54x** (46% faster) |
| 28 | Random | 58 ns | **0.48x** (52% faster) |
| 28 | Sorted | 57 ns | **0.78x** (22% faster) |
| 28 | Reversed | 57 ns | **0.64x** (36% faster) |
| 28 | Duplicates | 58 ns | **0.52x** (48% faster) |

### int detailed results (ARM64)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 82 ns | **0.81x** (19% faster) |
| 27 | Sorted | 81 ns | 1.41x |
| 27 | Reversed | 80 ns | 1.27x |
| 27 | Duplicates | 82 ns | **0.80x** (20% faster) |
| 28 | Random | 79 ns | **0.66x** (34% faster) |
| 28 | Sorted | 79 ns | 1.33x |
| 28 | Reversed | 79 ns | 1.21x |
| 28 | Duplicates | 80 ns | **0.74x** (26% faster) |

> With AVX2 SIMD, NetworkSort is consistently faster than Array.Sort for `int` across all input patterns. On ARM64, the SIMD path wins for random and duplicate-heavy inputs, while sorted/reversed inputs are slightly slower for size 27 (the fixed comparison sequence can't exploit pre-sorted data). Size 28 is faster across the board on both platforms.

## Building

```
dotnet build
dotnet test
dotnet run --project SortingNetworks.Benchmarks -c Release -- --filter *
```

## Code generation

The `NetworkSort.cs`, `NetworkSort.Unrolled.cs`, `NetworkSort.Simd.cs`, and
`NetworkSort.Simd.Arm.cs` files are auto-generated by `scripts/generate_unrolled.cs`.
To regenerate after changing the script:

```
dotnet run scripts/generate_unrolled.cs
```

## Projects

- **SortingNetworks** -- class library (future NuGet package)
- **SortingNetworks.Tests** -- xUnit correctness tests covering lengths 27-28
  across all 13 primitive types, plus string via the specialized `Sort(string[])`
  overload, with stress tests using 100 random seeds (135 tests)
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
