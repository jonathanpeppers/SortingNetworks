---
description: "Use when writing or modifying tests in SortingNetworks.Tests. Covers test structure, naming, and correctness verification patterns."
applyTo: "SortingNetworks.Tests/**/*.cs"
---
# Testing Conventions

- Use xUnit (`[Fact]`, `[Theory]`, `[MemberData]`).
- Verify correctness by comparing `NetworkSort.Sort` output against `Array.Sort` on the same input.
- Test naming: `Sort_<Scenario>` or `Sort_<Size>Elements_<Type>` (e.g., `Sort_27Elements_Int`, `Sort_RandomInts_MatchesArraySort`).
- Use `VerifySort<T>(length, generator, sort)` helper for parameterized single-seed tests across all lengths.
- Use `StressSort<T>(size, generator, sort)` helper for multi-seed stress tests (100 seeds) on specific sizes like 27 and 28.
- Cover all primitive types: `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `nint`, `nuint`, `char`, `float`, `double`.
- Cover `string` sorting with explicit `StringComparer.Ordinal`.
- Include edge-case tests: already sorted, reverse sorted, all duplicates, duplicate-heavy, null array, null comparer, fallback for large arrays.
- **Do not add NaN tests** for `float`/`double`. NaN is unsupported with sorting networks — see [#10](https://github.com/jonathanpeppers/SortingNetworks/issues/10) and [#11](https://github.com/jonathanpeppers/SortingNetworks/issues/11).
- Use deterministic `Random` seeds (`new Random(42 + length)` or `new Random(seed)`) for reproducibility.
