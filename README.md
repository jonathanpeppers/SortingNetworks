# SortingNetworks

[![Building a 41x Faster Sort in C# -- From Research Paper to SIMD, Powered by AI](https://i.ytimg.com/vi/FoRRWCkMsFc/hqdefault.jpg)](https://www.youtube.com/watch?v=FoRRWCkMsFc)

A .NET source generator that produces sorting-network-based sort methods for
small arrays (sizes 2–64). Networks for sizes 27 and 28 use depth-13 networks
from the paper
["Depth-13 Sorting Networks for 28 Channels"](https://arxiv.org/abs/2511.04107).

Overloads are generated for every primitive .NET type: `byte`, `sbyte`,
`short`, `ushort`, `int`, `uint`, `long`, `ulong`, `nint`, `nuint`,
`char`, `float`, `double`, and `string`. Custom value types that implement
`IComparable<T>` are also supported with unrolled `.CompareTo()` calls,
and arbitrary types can be sorted via an `IComparer<T>` overload.

## Usage

Add the `SortingNetworks` NuGet package, then decorate a `partial class` with
`[SortingNetwork(size, typeof(T))]` for each size/type combination you need.

> **Target framework:** The generated SIMD code uses `System.Runtime.Intrinsics`
> APIs that require **.NET 8 or later**. The scalar-only path uses
> `System.Runtime.CompilerServices.Unsafe` which is available on **.NET 5+**.
> Projects targeting older frameworks (e.g., netstandard2.0, .NET Framework)
> will get compile errors from the generated code.

```csharp
using SortingNetworks;

[SortingNetwork(27, typeof(int))]
[SortingNetwork(28, typeof(int))]
[SortingNetwork(27, typeof(double))]
partial class MySorter { }

// Sort a span of exactly 27 ints
Span<int> data = stackalloc int[] {
    27, 26, 25, 24, 23, 22, 21, 20, 19,
    18, 17, 16, 15, 14, 13, 12, 11, 10,
     9,  8,  7,  6,  5,  4,  3,  2,  1,
};
MySorter.Sort(data);

// Array overload
int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, /* ... 27 elements */ };
MySorter.Sort(array);

// IComparer<T> overload
MySorter.Sort(data, Comparer<int>.Create((a, b) => b.CompareTo(a)));
```

### Custom types

Any type can be used with `[SortingNetwork]`. For value types implementing
`IComparable<T>`, the generator emits unrolled `Sort{N}` methods using
`.CompareTo()` — the same strategy as primitives, just with `CompareTo`
instead of `>`:

```csharp
public record struct Point(int X, int Y) : IComparable<Point>
{
    public int CompareTo(Point other)
    {
        int cmp = X.CompareTo(other.X);
        return cmp != 0 ? cmp : Y.CompareTo(other.Y);
    }
}

[SortingNetwork(27, typeof(Point))]
partial class MySorter { }

// Parameterless Sort uses unrolled CompareTo
Span<Point> points = /* ... */;
MySorter.Sort(points);

// IComparer<T> overload also available for custom comparers
MySorter.Sort(points, Comparer<Point>.Create((a, b) => a.Y.CompareTo(b.Y)));
```

For types that do **not** implement `IComparable<T>`, only the
`IComparer<T>` overload is generated (the comparer parameter defaults to
`null` and uses `Comparer<T>.Default` at runtime):

```csharp
[SortingNetwork(10, typeof(MyClass))]
partial class MySorter { }

// Must provide a comparer (or rely on Comparer<T>.Default)
MySorter.Sort(items, myComparer);
```

### Handling unsupported sizes

By default, calling `Sort` with a span length that doesn't match any
`[SortingNetwork]` size throws `ArgumentException`. To handle unsupported
sizes gracefully, define a static `OnFallback` method in your partial class:

```csharp
[SortingNetwork(27, typeof(int))]
partial class MySorter
{
    static void OnFallback(Span<int> span)
    {
        span.Sort(); // or log, throw a custom exception, etc.
    }

    // Optional: comparer-aware fallback
    static void OnFallback(Span<int> span, IComparer<int> comparer)
    {
        int[] temp = span.ToArray();
        Array.Sort(temp, comparer);
        temp.CopyTo(span);
    }
}

MySorter.Sort(data);           // size 27 → sorting network
MySorter.Sort(otherData);      // any other size → OnFallback
```

- If no `OnFallback` is defined, unsupported sizes throw (same as before).
- The 1-parameter overload handles `Sort(Span<T>)` and `Sort(T[])`.
- The 2-parameter overload handles `Sort(Span<T>, IComparer<T>)` and
  `Sort(T[], IComparer<T>)`. If only the 1-parameter overload is defined,
  the comparer path still throws.

The source generator emits optimized sort methods with:
- **Scalar unrolled** compare-and-swap for all sizes/types
- **x86 SIMD** (AVX2, AVX-512) when the type and size fit in SIMD registers
- **ARM64 SIMD** (AdvSimd/NEON) for supported types
- **IComparer&lt;T&gt;** overloads using loop-based network application
- **Custom types** via unrolled `.CompareTo()` for `IComparable<T>` value types,
  or `IComparer<T>` for arbitrary types

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
| 2–22 | Batcher's odd-even merge sort networks |
| 23–32 | Optimal/best-known networks (Dobbelaere SorterHunter, arXiv:2511.04107) |
| 33–64 | Best-known networks ([Dobbelaere SorterHunter](https://github.com/bertdobbelaere/SorterHunter/tree/main/Networks/Sorters)) |

Sorting networks execute a fixed sequence of compare-and-swap operations
determined entirely by the input length. This eliminates branches and enables
predictable performance. The 27- and 28-channel networks are derived from the
paper's reflection-symmetric construction that improved the previous best depth
bound from 14 to 13.

The source generator emits unrolled methods using type-specific comparisons
(`>` operator) for primitives, `string.CompareOrdinal` for strings, and
`.CompareTo()` for custom `IComparable<T>` value types. For primitives this
compiles to a single CPU comparison instruction matching the BCL's internal
sort helpers; for custom types the JIT can devirtualize `CompareTo` on value
types, keeping the call nearly as cheap.

For `byte` and `sbyte`, the generator additionally emits SIMD vectorization
when available — AVX2 on x86 and AdvSimd (NEON) on ARM64. All 27-28 elements
fit in a single vector register, allowing each of the 13 network steps to
execute as a vectorized shuffle + min/max + blend operation instead of
individual scalar compare-and-swap branches.

For `int` and `uint`, AVX2 SIMD is emitted on x86 with four `Vector256<int>`
registers (8 elements each). Cross-vector shuffles use `PermuteVar8x32` with
`ConditionalSelect` composition, and `Min`/`Max` handles signed and unsigned comparisons.
On CPUs with AVX-512F, an AVX-512F path uses two `Vector512<int>` registers
(16 elements each) with `PermuteVar16x32x2` cross-vector shuffles.

For `short`, `ushort`, and `char` (16-bit types), AVX-512 SIMD is emitted on x86
when available, packing all elements into a single `Vector512<ushort>`. On
ARM64, four `Vector128<byte>` vectors are used for the same 16-bit types.
When all elements of a shuffled vector come from a single source register,
`Vector128.Shuffle` (TBL1) is used; otherwise `VectorTableLookup` (TBL4)
provides cross-vector shuffles. This TBL1 optimization is critical for ARM64
processors like Ampere Altra/Neoverse where TBL4 has significantly higher
latency than TBL1. On platforms without SIMD support, this falls back to the
scalar unrolled sort.

For `int`, `uint`, and `float` (32-bit types), ARM64 AdvSimd SIMD is emitted when
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

For `double`, AVX-512F SIMD is emitted on x86 when available (four `Vector512`
registers). On CPUs without AVX-512F, an AVX2 fallback uses seven
`Vector256<double>` registers (4 elements each) with `Permute4x64` shuffles.

For `nint` and `nuint`, the generated code delegates to the corresponding fixed-size
integer sort (`int`/`uint` on 32-bit, `long`/`ulong` on 64-bit) for both SIMD and
scalar paths. The SIMD path uses `MemoryMarshal.Cast` to reinterpret the span,
while the scalar path uses `Unsafe.As` to reinterpret the element reference —
matching the pattern used by dotnet/runtime's `SpanHelpers` for native-sized types.
This ensures optimal JIT codegen on all platforms by avoiding separate `nint`/`nuint`
sort methods.

## Benchmarks

### x86 (Intel Core i9-9900K, AVX2)

Results comparing `GeneratedSort` vs `Array.Sort` on .NET 10:

#### Types where GeneratedSort is significantly faster

For `byte` and `sbyte`, the generated code uses AVX2 SIMD vectorization -- all 27-28
elements fit in a single `Vector256<byte>` register, enabling each network step
to execute as a vectorized min/max/blend operation:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| byte | 1,310 ns | 37 ns | **35x** |
| sbyte | 1,478 ns | 40 ns | **37x** |

For `int` and `uint`, AVX2 SIMD uses four `Vector256<int>` registers with
cross-vector shuffles via `PermuteVar8x32`:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| int | 108 ns | 56 ns | **1.9x** |
| uint | 112 ns | 54 ns | **2.1x** |

For `float`, AVX2 SIMD uses four `Vector256<float>` registers with
`PermuteVar8x32` shuffles and `Avx.Min`/`Avx.Max` comparisons:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| float | 1,667 ns | 65 ns | **26x** |

For `double`, AVX2 SIMD uses seven `Vector256<double>` registers with
`Permute4x64` shuffles (on CPUs with AVX-512F, an AVX-512 path is used instead):

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| double | 1,641 ns | 102 ns | **16x** |

For other types without a SIMD-optimized `Array.Sort` in the BCL, the unrolled
sorting network dominates:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| short | 1,434 ns | 100 ns | **14x** |
| ushort | 1,333 ns | 100 ns | **13x** |
| long | 1,459 ns | 104 ns | **14x** |
| nint | 1,417 ns | 107 ns | **13x** |
| nuint | 1,452 ns | 107 ns | **14x** |

> **Note:** On processors with AVX-512, `short`, `ushort`, and `char` use AVX-512BW SIMD, `long` uses AVX-512F SIMD, `int`, `uint`, and `float` use AVX-512F SIMD, and `nint`/`nuint` dispatch to `long`/`ulong` for even greater speedups.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort paths for `char` and `ulong`. For these
types the BCL is already very fast and GeneratedSort provides a smaller benefit:

| Type | ArraySort (27) | GeneratedSort (27) | Ratio |
|---|---|---|---|
| char | 97 ns | 98 ns | ~1x |
| ulong | 160 ns | 100 ns | **1.6x** |

> **Note:** These results are from an Intel Core i9-9900K. On processors with AVX-512 (e.g., Xeon), Array.Sort is even more optimized and GeneratedSort may be slower for these types.

#### string (scalar `string.CompareOrdinal` path)

The generated `Sort(Span<string>)` method uses `string.CompareOrdinal` in the
unrolled network, avoiding `IComparer<T>` interface dispatch overhead:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| string | 1,120 ns | 523 ns | **2.1x** |

#### Custom types (unrolled `.CompareTo()` path)

For custom value types implementing `IComparable<T>`, the generator emits
unrolled `Sort{N}` methods using `.CompareTo()`. The JIT devirtualizes and
inlines the call for value types, keeping overhead low:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| Record (2× int) | 3,839 ns | 1,129 ns | **3.4x** |

> **Note:** These results are from GitHub Actions (ubuntu-latest, AMD EPYC).
> The `Record` type is a `record struct` with two `int` fields sorted
> lexicographically. Performance depends on the cost of `CompareTo` — cheap
> comparisons (like two-int) show ~2-3x on random data; more expensive
> comparisons would show even larger gains.

### x86 AVX-512F (AMD EPYC 9V74, GitHub Actions)

On CPUs with AVX-512F (e.g., AMD EPYC, Intel Ice Lake+), additional SIMD paths
are available. For `byte` and `sbyte`, the AVX2 path uses optimized direct
`Avx2.Shuffle` intrinsics (vpshufb) avoiding the expensive cross-lane emulation:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| byte | 1,591 ns | 61 ns | **26x** |
| sbyte | 1,714 ns | 68 ns | **25x** |

For `int`, `uint`, and `float`, AVX-512F uses two `Vector512` registers with
`PermuteVar16x32x2` cross-vector shuffles:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| int | 103 ns | 88 ns | **1.2x** |
| uint | 119 ns | 83 ns | **1.4x** |
| float | 2,049 ns | 92 ns | **22x** |
| double | 1,994 ns | 166 ns | **12x** |

For other types without SIMD-optimized `Array.Sort` in the BCL:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| short | 1,719 ns | 154 ns | **11x** |
| ushort | 1,589 ns | 154 ns | **10x** |
| long | 1,696 ns | 147 ns | **12x** |
| nint | 1,867 ns | 166 ns | **11x** |
| nuint | 1,742 ns | 175 ns | **10x** |
| string | 941 ns | 678 ns | **1.4x** |

> **Note:** These results are from an AMD EPYC 9V74 on GitHub Actions
> (windows-latest), which double-pumps 512-bit operations through 256-bit
> execution ports. Intel CPUs with native 512-bit execution units (e.g.,
> Sapphire Rapids) may see additional gains.

### ARM64 (Apple M1, AdvSimd/NEON)

On ARM64, the library uses AdvSimd (NEON) intrinsics for `byte`, `sbyte`,
`short`, `ushort`, `char`, `int`, `uint`, and `float`:

#### SIMD-accelerated types

For `byte` and `sbyte`, all elements fit in two `Vector128<byte>` registers.
For `short`, `ushort`, and `char`, four `Vector128<byte>` registers are used with
`Vector128.Shuffle` (TBL1) for intra-register shuffles and TBL4 only for
cross-register shuffles — avoiding expensive multi-register table lookups on
ARM cores where TBL4 has high latency:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| byte | 1,132 ns | 31 ns | **37x** |
| sbyte | 1,206 ns | 32 ns | **38x** |
| short | 1,124 ns | 48 ns | **23x** |
| ushort | 1,134 ns | 48 ns | **24x** |

For `int`, `uint`, and `float`, seven `Vector128` registers with two-stage
TBL/TBX cross-vector shuffles are used (with TBL1 optimization for single-register
shuffles and early-exit for sorted input):

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| float | 1,363 ns | 74 ns | **18x** |

> **Note:** `float` benefits enormously because .NET's `Array.Sort` does not
> have a SIMD-accelerated path for `float` on ARM64.

#### Types where Array.Sort is already SIMD-optimized

.NET 10 has SIMD-accelerated sort for `char`, `int`, and `uint` on ARM64.
GeneratedSort's NEON path still provides improvements:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| char | 97 ns | 50 ns | **1.9x** |
| int | 99 ns | 74 ns | **1.3x** |
| uint | 108 ns | 72 ns | **1.5x** |

#### Other types (scalar unrolled network)

For other types, the unrolled scalar sorting network provides the same large
speedup over `Array.Sort` as on x86:

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| double | 1,461 ns | 110 ns | **13x** |
| long | 1,122 ns | 100 ns | **11x** |

### ARM64 (Ampere Neoverse-N2, AdvSimd/NEON)

On Ampere/Neoverse ARM64 cores, TBL4 has significantly higher latency than on
Apple Silicon. The TBL1 optimization for intra-register shuffles is critical here:

#### char (16-bit) — the key improvement

| Type | ArraySort (27) | GeneratedSort (27) | Speedup |
|---|---|---|---|
| char | 109 ns | 68 ns | **1.6x** |
| ushort | 1,986 ns | 71 ns | **28x** |
| short | 1,983 ns | 60 ns | **33x** |
| byte | 1,962 ns | 57 ns | **34x** |

> **Note:** Without the TBL1 optimization, `char` size 27 was 135 ns — slower
> than ArraySort (97 ns). The optimization reduced it to 68 ns, a **2x
> improvement** that made GeneratedSort 1.6x faster than ArraySort.

### int detailed results (AVX2 SIMD)

| Size | Kind | GeneratedSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 56 ns | **0.52x** (48% faster) |
| 27 | Sorted | 57 ns | **0.66x** (34% faster) |
| 27 | Reversed | 57 ns | **0.60x** (40% faster) |
| 27 | Duplicates | 56 ns | **0.51x** (49% faster) |
| 28 | Random | 55 ns | **0.40x** (60% faster) |
| 28 | Sorted | 57 ns | **0.65x** (35% faster) |
| 28 | Reversed | 56 ns | **0.52x** (48% faster) |
| 28 | Duplicates | 55 ns | **0.48x** (52% faster) |

### int detailed results (ARM64)

| Size | Kind | GeneratedSort | Ratio vs ArraySort |
|---|---|---|---|
| 27 | Random | 74 ns | **0.74x** (26% faster) |
| 27 | Sorted | 30 ns | **0.52x** (48% faster) |
| 27 | Reversed | 78 ns | 1.22x |
| 27 | Duplicates | 77 ns | **0.72x** (28% faster) |
| 28 | Random | 80 ns | **0.65x** (35% faster) |
| 28 | Sorted | 30 ns | **0.51x** (49% faster) |
| 28 | Reversed | 73 ns | 1.15x |
| 28 | Duplicates | 80 ns | **0.73x** (27% faster) |

> With AVX2 SIMD, GeneratedSort is consistently faster than Array.Sort for `int` across all input patterns. On ARM64, the early-exit sorted check makes sorted input ~2x faster than ArraySort. Reversed input is slightly slower due to the overhead of cross-vector TBL/TBX shuffles with 7 registers.

### Sizes 33-64 (x86, scalar unrolled)

Networks for sizes 33-64 use best-known networks from [Dobbelaere's SorterHunter](https://github.com/bertdobbelaere/SorterHunter).
These are scalar unrolled (no SIMD), but still significantly faster than `Array.Sort` / `Span.Sort` for most types:

| Type | Size | SpanSort | GeneratedSort | Speedup |
|---|---|---|---|---|
| byte | 34 | 1,952 ns | 131 ns | **15x** |
| float | 36 | 2,170 ns | 90 ns | **24x** |
| sbyte | 38 | 2,489 ns | 155 ns | **16x** |
| short | 40 | 2,382 ns | 165 ns | **14x** |
| ushort | 42 | 2,495 ns | 174 ns | **14x** |
| double | 44 | 3,364 ns | 255 ns | **13x** |
| int | 48 | 302 ns | 113 ns | **2.7x** |
| uint | 50 | 296 ns | 219 ns | **1.4x** |
| long | 52 | 3,856 ns | 257 ns | **15x** |
| ulong | 54 | 435 ns | 268 ns | **1.6x** |
| nint | 56 | 4,129 ns | 289 ns | **14x** |
| nuint | 58 | 3,990 ns | 315 ns | **13x** |
| char | 60 | 391 ns | 258 ns | **1.5x** |
| string | 64 | 3,528 ns | 1,920 ns | **1.8x** |

> For types where .NET already has a SIMD-optimized sort path (`int`, `uint`, `char`, `ulong`),
> the speedup is smaller but GeneratedSort is still faster. For all other types, the unrolled
> sorting network provides 13-24x speedups.

## Building

```
dotnet build
dotnet test
dotnet run --project SortingNetworks.Benchmarks -c Release -- --filter *
```

## Projects

- **SortingNetworks** -- NuGet package containing the `SortingNetworkAttribute`
  and bundled source generator
- **SortingNetworks.Generators** -- Roslyn incremental source generator that
  emits optimized sorting network code (scalar + SIMD)
- **SortingNetworks.Tests** -- xUnit correctness tests covering sizes 2-64
  across all 13 primitive types plus custom types, with stress tests using
  100 random seeds (420 tests)
- **SortingNetworks.Benchmarks** -- BenchmarkDotNet benchmarks comparing
  generated sort vs `Array.Sort` for sizes 23-64 across all primitive types
  and custom record structs

## Paper reference

> Chengu Wang, "Depth-13 Sorting Networks for 28 Channels", arXiv:2511.04107, 2025.
>
> Establishes new depth upper bounds for sorting networks on 27 and 28
> channels, improving the previous best bound of 14 to 13. The 28-channel
> network is constructed with reflectional symmetry by combining high-quality
> prefixes of 16- and 12-channel networks, extending them greedily one
> comparator at a time, and using a SAT solver to complete the remaining
> layers.
