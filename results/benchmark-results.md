```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8037/25H2/2025Update/HudsonValley2)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Type                    | Method           | Length | Kind       | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |----------------- |------- |----------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Random**     |   **105.04 ns** |   **5.040 ns** |   **4.468 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |   102.13 ns |   3.975 ns |   3.524 ns |  0.97 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   108.96 ns |   4.578 ns |   4.059 ns |  1.04 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    98.88 ns |   2.462 ns |   1.922 ns |  0.94 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.48 ns** |   **2.591 ns** |   **2.297 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    73.32 ns |   2.186 ns |   1.938 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.31 ns |   4.084 ns |   3.189 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    71.38 ns |   2.000 ns |   1.773 ns |  1.01 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **84.89 ns** |   **2.321 ns** |   **2.058 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |   102.19 ns |   3.232 ns |   2.865 ns |  1.20 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    92.76 ns |   3.725 ns |   3.302 ns |  1.09 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    99.56 ns |   2.080 ns |   1.844 ns |  1.17 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **109.21 ns** |   **3.196 ns** |   **2.833 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    83.07 ns |   2.059 ns |   1.720 ns |  0.76 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   112.17 ns |   3.527 ns |   3.127 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    81.19 ns |   1.796 ns |   1.592 ns |  0.74 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **?**          | **1,299.76 ns** |  **32.590 ns** |  **28.890 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | ?          |    93.81 ns |   3.256 ns |   2.886 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | ?          | 1,631.15 ns |  62.436 ns |  55.348 ns |  1.26 |    0.05 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | ?          | 1,610.09 ns |  72.750 ns |  64.491 ns |  1.24 |    0.05 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | ?          | 1,397.65 ns |  68.641 ns |  60.848 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | ?          | 1,468.51 ns |  36.326 ns |  32.202 ns |  1.13 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | ?          | 1,392.56 ns |  79.480 ns |  66.369 ns |  1.07 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | ?          | 1,411.19 ns |  81.051 ns |  71.850 ns |  1.09 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | ?          | 1,417.96 ns |  28.988 ns |  25.697 ns |  1.09 |    0.03 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | ?          |   991.38 ns |  48.937 ns |  43.381 ns |  0.76 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | ?          |   109.61 ns |   6.458 ns |   5.725 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | ?          |   117.38 ns |   2.297 ns |   1.918 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | ?          | 1,278.01 ns |  55.331 ns |  49.050 ns |  0.98 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | ?          |    41.44 ns |   1.585 ns |   1.405 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | ?          |    97.56 ns |   2.214 ns |   1.963 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | ?          |   109.53 ns |   2.674 ns |   2.370 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | ?          |   107.79 ns |   3.564 ns |   3.160 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | ?          |   105.18 ns |   3.449 ns |   2.880 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | ?          |   103.82 ns |   3.028 ns |   2.529 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | ?          |   105.18 ns |   4.436 ns |   3.704 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | ?          |    43.38 ns |   1.589 ns |   1.408 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | ?          |   101.71 ns |   2.631 ns |   2.333 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | ?          |   520.67 ns |   4.452 ns |   3.718 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | ?          |    98.05 ns |   1.752 ns |   1.367 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | ?          |   102.15 ns |   3.559 ns |   2.972 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | ?          |   101.41 ns |   2.326 ns |   2.062 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | ?          | 1,347.94 ns |  51.653 ns |  45.789 ns |  1.04 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | ?          |    95.62 ns |   1.982 ns |   1.757 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | ?          | 1,638.55 ns |  67.832 ns |  60.132 ns |  1.26 |    0.05 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | ?          | 1,567.77 ns |  81.133 ns |  71.922 ns |  1.21 |    0.06 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | ?          | 1,467.06 ns |  56.323 ns |  49.929 ns |  1.13 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | ?          | 1,446.64 ns |  39.401 ns |  32.902 ns |  1.11 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | ?          | 1,394.52 ns |  47.457 ns |  39.628 ns |  1.07 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | ?          | 1,427.23 ns |  68.660 ns |  60.866 ns |  1.10 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | ?          | 1,400.69 ns |  77.237 ns |  68.469 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | ?          |   960.54 ns |  64.719 ns |  54.043 ns |  0.74 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | ?          |   106.28 ns |   3.239 ns |   2.705 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | ?          |   113.65 ns |   4.390 ns |   3.666 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | ?          | 1,266.09 ns |  39.549 ns |  35.059 ns |  0.97 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | ?          |    39.14 ns |   1.279 ns |   1.134 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | ?          |    95.34 ns |   1.945 ns |   1.724 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | ?          |   110.01 ns |   2.783 ns |   2.467 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | ?          |   104.85 ns |   2.527 ns |   2.240 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | ?          |   101.44 ns |   2.036 ns |   1.805 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | ?          |   102.86 ns |   4.190 ns |   3.271 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | ?          |   103.12 ns |   4.126 ns |   3.658 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | ?          |    42.79 ns |   1.077 ns |   0.955 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | ?          |    99.32 ns |   2.338 ns |   2.073 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | ?          |   516.52 ns |   3.156 ns |   2.636 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | ?          |    96.92 ns |   2.681 ns |   2.239 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | ?          |    99.21 ns |   2.623 ns |   2.190 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | ?          |    98.60 ns |   1.970 ns |   1.747 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Random**     |   **120.58 ns** |   **3.066 ns** |   **2.561 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |   103.16 ns |   1.913 ns |   1.696 ns |  0.86 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   123.51 ns |   2.773 ns |   2.315 ns |  1.02 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |   103.18 ns |   2.493 ns |   2.082 ns |  0.86 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **73.01 ns** |   **2.911 ns** |   **2.581 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    76.16 ns |   2.433 ns |   2.157 ns |  1.04 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    76.94 ns |   3.627 ns |   3.215 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    73.32 ns |   2.043 ns |   1.706 ns |  1.01 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **90.02 ns** |   **2.715 ns** |   **2.407 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    92.48 ns |   4.234 ns |   3.536 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    94.60 ns |   2.731 ns |   2.421 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    89.91 ns |   2.464 ns |   2.058 ns |  1.00 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **112.88 ns** |   **2.942 ns** |   **2.608 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    84.40 ns |   2.427 ns |   2.026 ns |  0.75 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   116.55 ns |   3.726 ns |   3.112 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    84.39 ns |   1.345 ns |   1.193 ns |  0.75 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **?**          | **1,488.26 ns** |  **36.961 ns** |  **32.765 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | ?          |   116.18 ns |   3.700 ns |   3.280 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | ?          | 1,853.99 ns |  87.789 ns |  77.823 ns |  1.25 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | ?          | 1,817.37 ns | 131.564 ns | 123.065 ns |  1.22 |    0.08 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | ?          | 1,596.39 ns |  41.836 ns |  37.087 ns |  1.07 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | ?          | 1,600.70 ns |  47.050 ns |  39.289 ns |  1.08 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | ?          | 1,612.69 ns |  38.438 ns |  34.075 ns |  1.08 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | ?          | 1,639.87 ns |  32.730 ns |  29.015 ns |  1.10 |    0.03 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | ?          | 1,578.51 ns |  56.458 ns |  50.048 ns |  1.06 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | ?          | 1,048.16 ns |  82.999 ns |  69.308 ns |  0.70 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | ?          |   122.39 ns |   4.334 ns |   3.842 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | ?          |   127.74 ns |   2.903 ns |   2.573 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | ?          | 1,476.68 ns |  51.233 ns |  45.417 ns |  0.99 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | ?          |    41.72 ns |   1.339 ns |   1.187 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | ?          |    99.89 ns |   1.879 ns |   1.666 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | ?          |   110.27 ns |   2.725 ns |   2.416 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | ?          |   110.52 ns |   3.041 ns |   2.539 ns |  0.07 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | ?          |   109.17 ns |   2.412 ns |   2.138 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | ?          |   106.96 ns |   2.101 ns |   1.863 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | ?          |   107.70 ns |   2.814 ns |   2.495 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | ?          |    44.21 ns |   1.993 ns |   1.767 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | ?          |   104.75 ns |   2.358 ns |   2.090 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | ?          |   542.40 ns |   5.031 ns |   4.201 ns |  0.36 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | ?          |   100.41 ns |   1.945 ns |   1.624 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | ?          |   106.06 ns |   2.673 ns |   2.370 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | ?          |   103.97 ns |   2.589 ns |   2.162 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | ?          | 1,496.35 ns |  74.240 ns |  65.812 ns |  1.01 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | ?          |   117.59 ns |   3.022 ns |   2.679 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | ?          | 1,802.09 ns | 101.358 ns |  79.134 ns |  1.21 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | ?          | 1,660.75 ns |  91.878 ns |  76.722 ns |  1.12 |    0.05 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | ?          | 1,594.04 ns |  61.511 ns |  51.365 ns |  1.07 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | ?          | 1,653.85 ns |  63.999 ns |  53.442 ns |  1.11 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | ?          | 1,557.58 ns |  81.624 ns |  72.357 ns |  1.05 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | ?          | 1,591.50 ns |  67.909 ns |  56.707 ns |  1.07 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | ?          | 1,554.31 ns | 103.139 ns |  91.430 ns |  1.04 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | ?          | 1,063.90 ns |  60.127 ns |  53.301 ns |  0.72 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | ?          |   123.16 ns |   6.461 ns |   5.727 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | ?          |   128.88 ns |   4.617 ns |   3.605 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | ?          | 1,454.42 ns |  25.303 ns |  21.129 ns |  0.98 |    0.02 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | ?          |    39.00 ns |   0.928 ns |   0.823 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | ?          |    98.01 ns |   2.033 ns |   1.697 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | ?          |   109.96 ns |   2.740 ns |   2.429 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | ?          |   106.75 ns |   2.192 ns |   1.943 ns |  0.07 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | ?          |   105.81 ns |   2.008 ns |   1.780 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | ?          |   105.75 ns |   2.363 ns |   2.095 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | ?          |   104.88 ns |   2.594 ns |   2.025 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | ?          |    41.57 ns |   1.290 ns |   1.144 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | ?          |   103.11 ns |   2.593 ns |   2.299 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | ?          |   541.67 ns |   5.391 ns |   4.779 ns |  0.36 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | ?          |    99.67 ns |   2.081 ns |   1.738 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | ?          |   103.87 ns |   2.261 ns |   1.765 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | ?          |   102.68 ns |   2.758 ns |   2.153 ns |  0.07 |    0.00 |         - |          NA |

