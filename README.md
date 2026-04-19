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
On CPUs with AVX-512F, an AVX-512F path uses two `Vector512<int>` registers
(16 elements each) with `PermuteVar16x32x2` cross-vector shuffles.

For `short`, `ushort`, and `char` (16-bit types), AVX-512 SIMD is used on x86
when available, packing all elements into a single `Vector512<ushort>`. On
ARM64, four `Vector128<byte>` vectors with `VectorTableLookup` (TBL4) provide
cross-vector shuffles for the same 16-bit types. On platforms without SIMD
support, this falls back to the scalar unrolled sort.

For `int`, `uint`, and `float` (32-bit types), ARM64 AdvSimd SIMD is used when
available. The 27-28 elements require seven `Vector128` registers — exceeding
TBL4's 4-register table limit. This is solved with a two-stage TBL/TBX lookup:
elements 0-15 are in Table A and elements 16-27 are in Table B, with
`VectorTableLookupExtension` (TBX) chaining the results.

For `float`, AVX2 SIMD is used on x86 with four `Vector256<float>` registers
(8 elements each). Cross-vector shuffles use `PermuteVar8x32` with
`BlendVariable` composition, and `Avx.Min`/`Avx.Max` handles comparisons.
On CPUs with AVX-512F, an AVX-512F path uses two `Vector512<float>` registers
(16 elements each) with `PermuteVar16x32x2` cross-vector shuffles.

For `double`, AVX-512F SIMD is used on x86 when available (four `Vector512`
registers). On CPUs without AVX-512F, an AVX2 fallback uses seven
`Vector256<double>` registers (4 elements each) with `Permute4x64` shuffles.

## Benchmarks

### x86 (Intel Core i9-9900K, AVX2)

Results comparing `NetworkSort` vs `Array.Sort` on .NET 10:

#### Types where NetworkSort is significantly faster

For `byte` and `sbyte`, the library uses AVX2 SIMD vectorization -- all 27-28
elements fit in a single `Vector256<byte>` register, enabling each network step
to execute as a vectorized min/max/blend operation:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,323 ns | 41 ns | **32x** |
| sbyte | 1,450 ns | 43 ns | **34x** |

For `int` and `uint`, AVX2 SIMD uses four `Vector256<int>` registers with
cross-vector shuffles via `PermuteVar8x32`:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| int | 105 ns | 57 ns | **1.8x** |
| uint | 109 ns | 54 ns | **2.0x** |

For `float`, AVX2 SIMD uses four `Vector256<float>` registers with
`PermuteVar8x32` shuffles and `Avx.Min`/`Avx.Max` comparisons:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| float | 1,531 ns | 76 ns | **20x** |

For `double`, AVX2 SIMD uses seven `Vector256<double>` registers with
`Permute4x64` shuffles (on CPUs with AVX-512F, an AVX-512 path is used instead):

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| double | 1,628 ns | 94 ns | **17x** |

For other types without a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| short | 1,364 ns | 102 ns | **13x** |
| ushort | 1,288 ns | 101 ns | **13x** |
| long | 1,423 ns | 104 ns | **14x** |
| nint | 1,395 ns | 103 ns | **14x** |
| nuint | 1,370 ns | 103 ns | **13x** |

> **Note:** On processors with AVX-512, `short`, `ushort`, and `char` use AVX-512BW SIMD, `long` uses AVX-512F SIMD, and `int`, `uint`, and `float` use AVX-512F SIMD for even greater speedups.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `char` and `ulong`. For these
types the BCL is already very fast and NetworkSort provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| char | 96 ns | 97 ns | ~1x |
| ulong | 117 ns | 101 ns | ~1.2x |

> **Note:** These results are from an Intel Core i9-9900K. On processors with AVX-512 (e.g., Xeon), Array.Sort is even more optimized and NetworkSort may be slower for these types.

#### string (specialized `Sort(string[])` path)

The specialized `Sort(string[])` overload uses `string.CompareOrdinal` in the
unrolled network, avoiding `IComparer<T>` interface dispatch overhead:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| string | 974 ns | 528 ns | **1.8x** |

### x86 AVX-512F (AMD EPYC 9V74, GitHub Actions)

On CPUs with AVX-512F (e.g., AMD EPYC, Intel Ice Lake+), `int`, `uint`, and
`float` use two `Vector512` registers with `PermuteVar16x32x2` cross-vector
shuffles:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| int | 105 ns | 67 ns | **1.6x** |
| uint | 122 ns | 63 ns | **1.9x** |
| float | 2,330 ns | 92 ns | **25x** |

> **Note:** These results are from an AMD EPYC 9V74 on GitHub Actions
> (ubuntu-latest), which double-pumps 512-bit operations through 256-bit
> execution ports. Intel CPUs with native 512-bit execution units (e.g.,
> Sapphire Rapids) may see additional gains.

### ARM64 (Apple M1, AdvSimd/NEON)

On ARM64, the library uses AdvSimd (NEON) intrinsics for `byte`, `sbyte`,
`short`, `ushort`, `char`, `int`, `uint`, and `float`:

#### SIMD-accelerated types

For `byte` and `sbyte`, all elements fit in two `Vector128<byte>` registers.
For `short` and `ushort`, four `Vector128<byte>` registers with TBL4
cross-vector shuffles are used:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,200 ns | 29 ns | **41x** |
| sbyte | 1,230 ns | 30 ns | **41x** |
| short | 1,264 ns | 54 ns | **23x** |
| ushort | 1,254 ns | 54 ns | **23x** |

For `int`, `uint`, and `float`, seven `Vector128` registers with two-stage
TBL/TBX cross-vector shuffles are used:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| float | 1,464 ns | 84 ns | **17x** |

> **Note:** `float` benefits enormously because .NET's `Array.Sort` does not
> have a SIMD-accelerated path for `float` on ARM64.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort for `char`, `int`, and `uint` on ARM64.
NetworkSort's NEON path still provides improvements:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| char | 121 ns | 51 ns | **2.4x** |
| int | 105 ns | 88 ns | **1.2x** |
| uint | 112 ns | 85 ns | **1.3x** |

#### Other types (scalar unrolled network)

For other types, the unrolled scalar sorting network provides the same large
speedup over `Array.Sort` as on x86:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| double | 1,523 ns | 111 ns | **14x** |
| long | 1,254 ns | 106 ns | **12x** |

### int detailed results (AVX2 SIMD)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 57 ns | **0.54x** (46% faster) |
| 27 | Sorted | 59 ns | **0.84x** (16% faster) |
| 27 | Reversed | 59 ns | **0.69x** (31% faster) |
| 27 | Duplicates | 57 ns | **0.53x** (47% faster) |
| 28 | Random | 56 ns | **0.45x** (55% faster) |
| 28 | Sorted | 56 ns | **0.78x** (22% faster) |
| 28 | Reversed | 57 ns | **0.63x** (37% faster) |
| 28 | Duplicates | 56 ns | **0.50x** (50% faster) |

### int detailed results (ARM64)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 88 ns | **0.84x** (16% faster) |
| 27 | Sorted | 88 ns | 1.54x |
| 27 | Reversed | 85 ns | 1.38x |
| 27 | Duplicates | 85 ns | **0.65x** (35% faster) |
| 28 | Random | 84 ns | **0.68x** (32% faster) |
| 28 | Sorted | 83 ns | 1.41x |
| 28 | Reversed | 84 ns | 1.28x |
| 28 | Duplicates | 83 ns | **0.75x** (25% faster) |

> With AVX2 SIMD, NetworkSort is consistently faster than Array.Sort for `int` across all input patterns. On ARM64, the SIMD path wins for random and duplicate-heavy inputs, while sorted/reversed inputs are slower for both sizes 27 and 28 (the fixed comparison sequence can't exploit pre-sorted data).

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
