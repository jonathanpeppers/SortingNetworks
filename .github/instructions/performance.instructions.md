---
description: "Use when writing or modifying C# code in SortingNetworks. Covers performance-critical patterns: Unsafe, refs, AggressiveInlining, zero-allocation sorting."
applyTo: "**/*.cs"
---
# Performance Patterns

This is a high-performance sorting library. All code in the hot path must follow these rules:

- Use `ref` and `Unsafe.Add(ref T, int)` for element access instead of span indexing in unrolled methods.
- Use `MemoryMarshal.GetReference(span)` to get a ref to the first element.
- Mark hot-path private methods with `[MethodImpl(MethodImplOptions.AggressiveInlining)]`.
- Avoid heap allocations in sort methods — no LINQ, no closures, no boxing.
- Use inline compare-and-swap (`if (a > b) { T temp = a; a = b; b = temp; }`) for primitive types rather than `IComparer<T>`.
- `IComparer<T>` overloads use the loop-based `ApplyNetworkWithComparer` path and are not unrolled.
- Fallback to `span.Sort()` or `Array.Sort()` for sizes outside the network range.
- `AllowUnsafeBlocks` is enabled in the project.
