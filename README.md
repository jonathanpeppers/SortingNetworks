# SortingNetworks

[![Building a 41x Faster Sort in C# -- From Research Paper to SIMD, Powered by AI](https://i.ytimg.com/vi/FoRRWCkMsFc/hqdefault.jpg)](https://www.youtube.com/watch?v=FoRRWCkMsFc)

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

## How it works

A [sorting network](https://en.wikipedia.org/wiki/Sorting_network) is a fixed
sequence of **compare-and-swap** operations that sorts any input of a given
size. Unlike comparison-based algorithms such as quicksort, the sequence of
comparisons is determined entirely by the input length — not by the data values
— which eliminates input-dependent control flow and enables predictable,
data-oblivious performance and branchless implementations.

Each compare-and-swap takes two elements and puts the smaller one first:

```
if a > b
    swap(a, b)
```

A sorting network arranges these operations into **layers** (or stages).
Comparators within the same layer operate on independent pairs, so they can
execute in parallel. The **depth** of a network is the number of layers —
fewer layers means lower latency.

### The paper

This library implements the networks from:

> Chengu Wang, **"Depth-13 Sorting Networks for 28 Channels"**,
> [arXiv:2511.04107](https://arxiv.org/abs/2511.04107), 2025.

The paper established new depth upper bounds for sorting networks on 27 and 28
channels, improving the previous best bound from **14 to 13**. The
28-channel network is constructed with **reflectional symmetry** by:

1. Combining high-quality prefixes of 16-channel and 12-channel networks (5
   layers each),
2. Extending them greedily one comparator at a time to reach 6 layers, and
3. Using a **SAT solver** to complete the remaining layers 7–13.

The 27-channel network is derived from the 28-channel network by removing all
comparators that involve channel 27.

### Scalar implementation

The simplest path unrolls every compare-and-swap from the network into
straight-line code. For a 3-element example, a depth-3 network looks like:

```csharp
// Sort 3 elements with a sorting network (depth 3, 3 comparators)
static void Sort3(ref int e0, ref int e1, ref int e2)
{
    // Layer 1 — two independent comparators could go here, but
    // for 3 elements there is only one pair per layer.
    if (e0 > e1) { int t = e0; e0 = e1; e1 = t; }

    // Layer 2
    if (e1 > e2) { int t = e1; e1 = e2; e2 = t; }

    // Layer 3
    if (e0 > e1) { int t = e0; e0 = e1; e1 = t; }
}
```

For the real 27/28-element networks the same pattern is used — the code
generator emits all ~185 comparators across 13 layers as a flat `if`/swap
sequence. Elements are loaded into local variables via `Unsafe.Add(ref T, n)`
to avoid bounds checks:

```csharp
// Actual generated code (simplified) for the first layer of Sort27<int>:
int e0 = first;
int e1 = Unsafe.Add(ref first, 1);
// ... load e2 through e26 ...

// Layer 1 comparators:
if (e1  > e26) { int temp = e1;  e1  = e26; e26 = temp; }
if (e2  > e25) { int temp = e2;  e2  = e25; e25 = temp; }
if (e3  > e24) { int temp = e3;  e3  = e24; e24 = temp; }
// ... remaining comparators in layers 2–13 ...
```

### SIMD implementation

For types that fit well in SIMD registers, the library replaces the scalar
`if`/swap pattern with vectorized **min/max/select** operations. Instead of
comparing one pair at a time, an entire layer of the sorting network executes
in a few instructions.

Here is a simplified example for `byte` with AVX2 — all 27 elements fit in a
single `Vector256<byte>` (32 lanes, 5 unused):

```csharp
// Load all elements into one 256-bit vector
var vec = LoadVector256(ref first); // [e0, e1, ..., e26, 0, 0, 0, 0, 0]

// For each of the 13 layers:
//   1. Shuffle: rearrange elements to pair up comparators
var shuffled = Vector256.Shuffle(vec, layerPermutation);

//   2. Min/Max: compare all pairs simultaneously
var mins = Vector256.Min(vec, shuffled);
var maxs = Vector256.Max(vec, shuffled);

//   3. Select: pick min or max for each position using a mask
vec = Vector256.ConditionalSelect(layerMask, maxs, mins);

// After all 13 layers, store the sorted vector back
StoreVector256(ref first, vec);
```

Each layer becomes a small handful of SIMD instructions — **shuffle**,
**min**, **max**, and **blend/select** — instead of many individual branches.
For `byte`, this produces a **33-41x** speedup over `Array.Sort`. The same
pattern extends to wider types (`int`, `float`, `double`) using multiple SIMD
registers with cross-vector shuffles.

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
`ConditionalSelect` composition, and `Min`/`Max` handles signed and unsigned comparisons.
On CPUs with AVX-512F, an AVX-512F path uses two `Vector512<int>` registers
(16 elements each) with `PermuteVar16x32x2` cross-vector shuffles.

For `short`, `ushort`, and `char` (16-bit types), AVX-512 SIMD is used on x86
when available, packing all elements into a single `Vector512<ushort>`. On
ARM64, four `Vector128<byte>` vectors with `VectorTableLookup` (TBL4) provide
cross-vector shuffles for the same 16-bit types. On platforms without SIMD
support, this falls back to the scalar unrolled sort.

For `int`, `uint`, and `float` (32-bit types), ARM64 AdvSimd SIMD is used when
available. The 27-28 elements require seven `Vector128` registers — exceeding
TBL4's 4-register table limit. When all elements of a shuffled vector come from
a single source register, `Vector128.Shuffle` (TBL1) is used directly; otherwise
a two-stage TBL/TBX lookup splits elements into Table A (0-15) and Table B
(16-27) with `VectorTableLookupExtension` (TBX) chaining. An early-exit check
detects already-sorted input and skips the SIMD path entirely.

For `float`, AVX2 SIMD uses four `Vector256<float>` registers
(8 elements each). Cross-vector shuffles use `PermuteVar8x32` with
`Avx.BlendVariable` composition, and `Avx.Min`/`Avx.Max` handles comparisons.
On CPUs with AVX-512F, an AVX-512F path uses two `Vector512<float>` registers
(16 elements each) with `PermuteVar16x32x2` cross-vector shuffles.

For `double`, AVX-512F SIMD is used on x86 when available (four `Vector512`
registers). On CPUs without AVX-512F, an AVX2 fallback uses seven
`Vector256<double>` registers (4 elements each) with `Permute4x64` shuffles.

For `nint` and `nuint`, the library dispatches to the corresponding fixed-size
integer sort via `MemoryMarshal.Cast` when SIMD is available for the target type.
On 64-bit platforms with AVX-512, `nint`/`nuint` dispatch to `long`/`ulong` to
use AVX-512F SIMD. On 32-bit platforms, they dispatch to `int`/`uint`. When no
SIMD path exists for the target type (e.g., ARM64 or AVX2-only x86 for 64-bit),
the scalar unrolled network is used directly to avoid dispatch overhead.

## Benchmarks

### x86 (Intel Core i9-9900K, AVX2)

Results comparing `NetworkSort` vs `Array.Sort` on .NET 10:

#### Types where NetworkSort is significantly faster

For `byte` and `sbyte`, the library uses AVX2 SIMD vectorization -- all 27-28
elements fit in a single `Vector256<byte>` register, enabling each network step
to execute as a vectorized min/max/blend operation:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| byte | 1,301 ns | 39 ns | **33x** |
| sbyte | 1,452 ns | 41 ns | **35x** |

For `int` and `uint`, AVX2 SIMD uses four `Vector256<int>` registers with
cross-vector shuffles via `PermuteVar8x32`:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| int | 101 ns | 57 ns | **1.8x** |
| uint | 107 ns | 54 ns | **2.0x** |

For `float`, AVX2 SIMD uses four `Vector256<float>` registers with
`PermuteVar8x32` shuffles and `Avx.Min`/`Avx.Max` comparisons:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| float | 1,636 ns | 76 ns | **22x** |

For `double`, AVX2 SIMD uses seven `Vector256<double>` registers with
`Permute4x64` shuffles (on CPUs with AVX-512F, an AVX-512 path is used instead):

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| double | 1,648 ns | 93 ns | **18x** |

For other types without a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| short | 1,402 ns | 101 ns | **14x** |
| ushort | 1,285 ns | 100 ns | **13x** |
| long | 1,404 ns | 104 ns | **14x** |
| nint | 1,399 ns | 103 ns | **14x** |
| nuint | 1,414 ns | 102 ns | **14x** |

> **Note:** On processors with AVX-512, `short`, `ushort`, and `char` use AVX-512BW SIMD, `long` uses AVX-512F SIMD, `int`, `uint`, and `float` use AVX-512F SIMD, and `nint`/`nuint` dispatch to `long`/`ulong` for even greater speedups.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `char` and `ulong`. For these
types the BCL is already very fast and NetworkSort provides a smaller benefit:

| Type | ArraySort (27) | NetworkSort (27) | Ratio |
|---|---|---|---|
| char | 93 ns | 97 ns | ~1x |
| ulong | 118 ns | 100 ns | ~1.2x |

> **Note:** These results are from an Intel Core i9-9900K. On processors with AVX-512 (e.g., Xeon), Array.Sort is even more optimized and NetworkSort may be slower for these types.

#### string (specialized `Sort(string[])` path)

The specialized `Sort(string[])` overload uses `string.CompareOrdinal` in the
unrolled network, avoiding `IComparer<T>` interface dispatch overhead:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| string | 979 ns | 527 ns | **1.9x** |

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
TBL/TBX cross-vector shuffles are used (with TBL1 optimization for single-register
shuffles and early-exit for sorted input):

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| float | 1,363 ns | 78 ns | **17x** |

> **Note:** `float` benefits enormously because .NET's `Array.Sort` does not
> have a SIMD-accelerated path for `float` on ARM64.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort for `char`, `int`, and `uint` on ARM64.
NetworkSort's NEON path still provides improvements:

| Type | ArraySort (27) | NetworkSort (27) | Speedup |
|---|---|---|---|
| char | 98 ns | 50 ns | **2.0x** |
| int | 98 ns | 78 ns | **1.3x** |
| uint | 108 ns | 75 ns | **1.4x** |

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
| 27 | Random | 57 ns | **0.56x** (44% faster) |
| 27 | Sorted | 57 ns | **0.81x** (19% faster) |
| 27 | Reversed | 58 ns | **0.68x** (32% faster) |
| 27 | Duplicates | 57 ns | **0.52x** (48% faster) |
| 28 | Random | 57 ns | **0.47x** (53% faster) |
| 28 | Sorted | 56 ns | **0.77x** (23% faster) |
| 28 | Reversed | 57 ns | **0.64x** (36% faster) |
| 28 | Duplicates | 56 ns | **0.50x** (50% faster) |

### int detailed results (ARM64)

| Size | Kind | NetworkSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 78 ns | **0.80x** (20% faster) |
| 27 | Sorted | 29 ns | **0.51x** (49% faster) |
| 27 | Reversed | 79 ns | 1.33x |
| 27 | Duplicates | 79 ns | **0.81x** (19% faster) |
| 28 | Random | 78 ns | **0.66x** (34% faster) |
| 28 | Sorted | 30 ns | **0.54x** (46% faster) |
| 28 | Reversed | 75 ns | 1.21x |
| 28 | Duplicates | 76 ns | **0.73x** (27% faster) |

> With AVX2 SIMD, NetworkSort is consistently faster than Array.Sort for `int` across all input patterns. On ARM64, the early-exit sorted check eliminates the previous 1.5x regression on sorted data (now 2x faster), and TBL1 optimization improves random/duplicate performance ~10%. Reversed input remains slightly slower due to the overhead of cross-vector TBL/TBX shuffles with 7 registers.

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
  overload, with stress tests using 100 random seeds (161 tests)
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
