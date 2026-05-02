```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Type                    | Method        | Length | Kind       | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------ |-------------- |------- |----------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **CharSortingBenchmarks**   | **ArraySort**     | **8**      | **Random**     |    **30.87 ns** |   **2.457 ns** |   **2.178 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 8      | Random     |   301.15 ns |  19.154 ns |  16.979 ns |  9.80 |    0.88 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 8      | Random     |   285.12 ns |   9.670 ns |   8.572 ns |  9.28 |    0.72 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 8      | Random     |    32.14 ns |   1.833 ns |   1.625 ns |  1.05 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 8      | Random     |   304.31 ns |  16.210 ns |  14.370 ns |  9.91 |    0.84 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 8      | Random     |   273.66 ns |   9.668 ns |   8.571 ns |  8.91 |    0.69 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 8      | Random     |    22.21 ns |   2.613 ns |   2.182 ns |  0.72 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 8      | Random     |    23.67 ns |   0.768 ns |   0.681 ns |  0.77 |    0.06 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 8      | Random     |    23.66 ns |   0.884 ns |   0.783 ns |  0.77 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **16**     | **Random**     |    **76.10 ns** |  **17.688 ns** |  **15.680 ns** |  **1.03** |    **0.27** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 16     | Random     |   921.04 ns |  20.855 ns |  18.487 ns | 12.51 |    2.09 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 16     | Random     |   837.51 ns |   7.080 ns |   5.912 ns | 11.37 |    1.89 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 16     | Random     |    72.69 ns |   2.613 ns |   2.317 ns |  0.99 |    0.17 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 16     | Random     |   946.35 ns |  21.683 ns |  19.222 ns | 12.85 |    2.14 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 16     | Random     |   829.62 ns |   8.017 ns |   6.695 ns | 11.27 |    1.87 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 16     | Random     |    33.17 ns |   1.172 ns |   1.039 ns |  0.45 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 16     | Random     |    33.69 ns |   1.612 ns |   1.429 ns |  0.46 |    0.08 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 16     | Random     |    33.32 ns |   1.520 ns |   1.186 ns |  0.45 |    0.08 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **23**     | **Random**     | **1,143.09 ns** |  **45.757 ns** |  **40.562 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 23     | Random     |    75.81 ns |   2.903 ns |   2.574 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 23     | Random     | 1,397.09 ns |  76.165 ns |  67.519 ns |  1.22 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 23     | Random     | 1,389.50 ns |  85.981 ns |  76.220 ns |  1.22 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 23     | Random     |    94.04 ns |   6.897 ns |   6.114 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 23     | Random     | 1,181.70 ns |  77.389 ns |  68.604 ns |  1.04 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 23     | Random     | 1,207.14 ns |  24.616 ns |  21.821 ns |  1.06 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 23     | Random     | 1,209.39 ns |  29.045 ns |  25.747 ns |  1.06 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 23     | Random     | 1,241.03 ns |  91.293 ns |  80.929 ns |  1.09 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 23     | Random     | 1,216.24 ns |  24.424 ns |  21.652 ns |  1.07 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 23     | Random     |   981.04 ns | 109.029 ns |  96.652 ns |  0.86 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 23     | Random     |    99.80 ns |   2.915 ns |   2.584 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 23     | Random     |   120.24 ns |   4.107 ns |   3.430 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 23     | Random     | 1,107.68 ns |  25.401 ns |  22.517 ns |  0.97 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 23     | Random     | 1,167.31 ns |  98.523 ns |  87.338 ns |  1.02 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 23     | Random     |    78.94 ns |   2.106 ns |   1.867 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 23     | Random     | 1,290.03 ns | 107.785 ns |  95.549 ns |  1.13 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 23     | Random     | 1,395.05 ns |  42.451 ns |  37.631 ns |  1.22 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Random     |    96.77 ns |   3.830 ns |   3.395 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 23     | Random     | 1,193.40 ns |  64.482 ns |  57.162 ns |  1.05 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 23     | Random     | 1,201.26 ns |  71.241 ns |  63.154 ns |  1.05 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 23     | Random     | 1,205.96 ns |  58.682 ns |  52.020 ns |  1.06 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 23     | Random     | 1,223.61 ns |  77.032 ns |  68.287 ns |  1.07 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 23     | Random     | 1,206.57 ns |  31.639 ns |  28.047 ns |  1.06 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 23     | Random     | 1,003.52 ns |  76.840 ns |  68.117 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 23     | Random     |    94.68 ns |   4.846 ns |   4.295 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 23     | Random     |   114.83 ns |   9.568 ns |   8.482 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 23     | Random     | 1,093.36 ns |  28.394 ns |  25.170 ns |  0.96 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 23     | Random     |    34.58 ns |   1.265 ns |   1.121 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 23     | Random     |    83.93 ns |   2.480 ns |   2.198 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 23     | Random     |    85.06 ns |   1.749 ns |   1.461 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 23     | Random     |    61.05 ns |   1.485 ns |   1.240 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Random     |    48.03 ns |   2.367 ns |   1.976 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 23     | Random     |    91.15 ns |   3.097 ns |   2.745 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    93.05 ns |   3.588 ns |   2.997 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 23     | Random     |    93.14 ns |   3.161 ns |   2.802 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 23     | Random     |    37.09 ns |   1.280 ns |   1.134 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 23     | Random     |    87.98 ns |   3.467 ns |   3.073 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 23     | Random     |   389.84 ns |   2.324 ns |   2.060 ns |  0.34 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    48.54 ns |   2.370 ns |   2.101 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 23     | Random     |    86.20 ns |   1.999 ns |   1.669 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 23     | Random     |    86.90 ns |   2.029 ns |   1.799 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Sorted**     |    **67.69 ns** |   **6.161 ns** |   **5.462 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Sorted     |    65.35 ns |   3.027 ns |   2.683 ns |  0.97 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Sorted     |    48.92 ns |   2.039 ns |   1.702 ns |  0.73 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Reversed**   |    **86.86 ns** |   **3.560 ns** |   **3.156 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Reversed   |    92.07 ns |   2.861 ns |   2.536 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Reversed   |    46.82 ns |   1.685 ns |   1.407 ns |  0.54 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Duplicates** |    **88.82 ns** |   **2.917 ns** |   **2.586 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Duplicates |    92.66 ns |   5.933 ns |   5.259 ns |  1.04 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Duplicates |    50.74 ns |   1.880 ns |   1.666 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **24**     | **Random**     | **1,240.11 ns** |  **85.013 ns** |  **75.362 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 24     | Random     |   125.61 ns |   8.599 ns |   7.181 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 24     | Random     | 1,565.07 ns |  48.853 ns |  43.307 ns |  1.27 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 24     | Random     | 1,423.45 ns | 116.179 ns | 102.989 ns |  1.15 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 24     | Random     |   108.07 ns |   2.627 ns |   2.329 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 24     | Random     | 1,329.33 ns |  49.284 ns |  43.689 ns |  1.08 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 24     | Random     | 1,337.04 ns |  57.242 ns |  50.744 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 24     | Random     | 1,350.27 ns |  80.127 ns |  71.030 ns |  1.09 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 24     | Random     | 1,409.70 ns |  30.716 ns |  27.229 ns |  1.14 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 24     | Random     | 1,318.94 ns |  66.162 ns |  58.651 ns |  1.07 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 24     | Random     | 1,083.92 ns |  68.162 ns |  60.424 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 24     | Random     |   113.71 ns |   5.413 ns |   4.799 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 24     | Random     |   128.65 ns |   2.647 ns |   2.346 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 24     | Random     | 1,243.38 ns |  59.079 ns |  52.372 ns |  1.01 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 24     | Random     | 1,253.82 ns |  66.511 ns |  58.960 ns |  1.01 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 24     | Random     |   126.77 ns |   1.304 ns |   1.018 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 24     | Random     | 1,487.94 ns | 157.598 ns | 147.417 ns |  1.20 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 24     | Random     | 1,465.71 ns | 133.344 ns | 118.206 ns |  1.19 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Random     |   114.64 ns |   4.490 ns |   3.980 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 24     | Random     | 1,194.78 ns | 194.978 ns | 162.815 ns |  0.97 |    0.14 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 24     | Random     | 1,333.47 ns |  70.352 ns |  62.365 ns |  1.08 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 24     | Random     | 1,359.14 ns |  36.679 ns |  32.515 ns |  1.10 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 24     | Random     | 1,380.68 ns |  49.923 ns |  44.256 ns |  1.12 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 24     | Random     | 1,337.60 ns |  37.124 ns |  32.910 ns |  1.08 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 24     | Random     | 1,086.11 ns |  73.475 ns |  65.134 ns |  0.88 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 24     | Random     |   108.89 ns |   4.534 ns |   4.019 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 24     | Random     |   125.08 ns |   3.834 ns |   3.398 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 24     | Random     | 1,218.66 ns |  52.797 ns |  46.803 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 24     | Random     |    36.69 ns |   1.424 ns |   1.262 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 24     | Random     |    80.13 ns |   1.653 ns |   1.465 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 24     | Random     |   100.88 ns |   2.924 ns |   2.442 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 24     | Random     |    62.88 ns |   2.204 ns |   1.841 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Random     |    50.40 ns |   1.714 ns |   1.520 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 24     | Random     |    87.75 ns |   3.088 ns |   2.579 ns |  0.07 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    91.29 ns |   2.426 ns |   2.150 ns |  0.07 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 24     | Random     |    92.39 ns |   2.630 ns |   2.332 ns |  0.07 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 24     | Random     |    39.83 ns |   1.395 ns |   1.237 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 24     | Random     |    84.74 ns |   1.975 ns |   1.751 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 24     | Random     |   418.06 ns |   4.989 ns |   4.422 ns |  0.34 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    49.86 ns |   2.007 ns |   1.779 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 24     | Random     |    85.39 ns |   2.680 ns |   2.375 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 24     | Random     |    85.02 ns |   2.849 ns |   2.379 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Sorted**     |    **70.26 ns** |   **2.314 ns** |   **2.051 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Sorted     |    77.91 ns |   1.834 ns |   1.626 ns |  1.11 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Sorted     |    52.69 ns |   3.658 ns |   3.054 ns |  0.75 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Reversed**   |    **91.08 ns** |   **1.798 ns** |   **1.502 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Reversed   |   100.62 ns |   3.393 ns |   2.833 ns |  1.11 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Reversed   |    53.28 ns |   2.095 ns |   1.857 ns |  0.59 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Duplicates** |    **92.61 ns** |   **2.814 ns** |   **2.495 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Duplicates |    98.98 ns |   2.423 ns |   2.148 ns |  1.07 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Duplicates |    50.64 ns |   2.192 ns |   1.831 ns |  0.55 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **25**     | **Random**     | **1,186.86 ns** |  **52.674 ns** |  **46.694 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 25     | Random     |   120.53 ns |   1.885 ns |   1.671 ns |  0.10 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 25     | Random     | 1,456.31 ns |  81.585 ns |  72.323 ns |  1.23 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 25     | Random     | 1,412.68 ns | 165.687 ns | 146.877 ns |  1.19 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 25     | Random     |    99.23 ns |   5.441 ns |   4.544 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 25     | Random     | 1,271.51 ns |  36.816 ns |  32.637 ns |  1.07 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 25     | Random     | 1,230.72 ns | 102.890 ns |  91.209 ns |  1.04 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 25     | Random     | 1,278.24 ns |  38.485 ns |  34.116 ns |  1.08 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 25     | Random     | 1,306.16 ns |  39.446 ns |  34.968 ns |  1.10 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 25     | Random     | 1,260.81 ns |  44.607 ns |  39.543 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 25     | Random     | 1,005.28 ns |  69.324 ns |  61.454 ns |  0.85 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 25     | Random     |   108.76 ns |   3.519 ns |   3.120 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 25     | Random     |   121.79 ns |   1.101 ns |   0.860 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 25     | Random     | 1,203.99 ns |  33.302 ns |  29.522 ns |  1.02 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 25     | Random     | 1,173.21 ns |  70.431 ns |  62.435 ns |  0.99 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 25     | Random     |   123.46 ns |   2.960 ns |   2.624 ns |  0.10 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 25     | Random     | 1,416.51 ns |  98.008 ns |  86.882 ns |  1.20 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 25     | Random     | 1,428.61 ns | 105.743 ns |  93.738 ns |  1.21 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Random     |   109.56 ns |   4.165 ns |   3.693 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 25     | Random     | 1,250.56 ns | 107.500 ns |  95.296 ns |  1.06 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 25     | Random     | 1,264.56 ns |  82.513 ns |  73.146 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 25     | Random     | 1,288.54 ns |  39.415 ns |  34.940 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 25     | Random     | 1,289.78 ns |  52.180 ns |  43.572 ns |  1.09 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 25     | Random     | 1,257.36 ns |  36.612 ns |  32.455 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 25     | Random     |   984.78 ns |  95.429 ns |  79.687 ns |  0.83 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 25     | Random     |   106.00 ns |   5.282 ns |   4.682 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 25     | Random     |   123.79 ns |   3.845 ns |   3.408 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 25     | Random     | 1,141.37 ns |  64.467 ns |  57.148 ns |  0.96 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 25     | Random     |    37.74 ns |   1.386 ns |   1.228 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 25     | Random     |    89.47 ns |   2.669 ns |   2.229 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 25     | Random     |   108.80 ns |   1.455 ns |   1.290 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 25     | Random     |    71.40 ns |   1.717 ns |   1.522 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Random     |    57.36 ns |   1.780 ns |   1.578 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 25     | Random     |    95.37 ns |   1.741 ns |   1.543 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 25     | Random     |    99.91 ns |   2.504 ns |   2.220 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 25     | Random     |    99.87 ns |   2.434 ns |   2.157 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 25     | Random     |    39.67 ns |   1.035 ns |   0.918 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 25     | Random     |    94.62 ns |   2.245 ns |   1.990 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 25     | Random     |   441.54 ns |   5.621 ns |   4.983 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 25     | Random     |    51.38 ns |   1.960 ns |   1.636 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 25     | Random     |    92.89 ns |   2.123 ns |   1.882 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 25     | Random     |    95.17 ns |   3.493 ns |   2.917 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Sorted**     |    **78.60 ns** |   **2.746 ns** |   **2.434 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Sorted     |    87.17 ns |   5.647 ns |   5.006 ns |  1.11 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Sorted     |    56.27 ns |   2.136 ns |   1.893 ns |  0.72 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Reversed**   |    **91.88 ns** |   **3.279 ns** |   **2.907 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Reversed   |    95.99 ns |   4.090 ns |   3.626 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Reversed   |    55.28 ns |   1.859 ns |   1.648 ns |  0.60 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Duplicates** |    **99.70 ns** |   **3.041 ns** |   **2.696 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Duplicates |   102.92 ns |   8.566 ns |   7.594 ns |  1.03 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Duplicates |    57.19 ns |   2.295 ns |   2.034 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **26**     | **Random**     | **1,426.49 ns** |  **89.771 ns** |  **79.580 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 26     | Random     |   121.85 ns |   1.964 ns |   1.741 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 26     | Random     | 1,689.90 ns | 117.073 ns | 103.782 ns |  1.19 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 26     | Random     | 1,628.77 ns | 192.810 ns | 180.355 ns |  1.15 |    0.14 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 26     | Random     |   123.21 ns |   3.678 ns |   3.260 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 26     | Random     | 1,492.12 ns |  46.470 ns |  41.195 ns |  1.05 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 26     | Random     | 1,430.98 ns | 121.657 ns | 107.845 ns |  1.01 |    0.10 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 26     | Random     | 1,503.68 ns |  49.533 ns |  43.910 ns |  1.06 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 26     | Random     | 1,551.09 ns |  47.834 ns |  42.404 ns |  1.09 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 26     | Random     | 1,458.61 ns |  79.892 ns |  70.822 ns |  1.03 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 26     | Random     | 1,067.04 ns | 109.385 ns |  96.967 ns |  0.75 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 26     | Random     |   124.32 ns |   5.240 ns |   4.645 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 26     | Random     |   154.60 ns |   3.674 ns |   3.256 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 26     | Random     | 1,375.94 ns |  68.240 ns |  60.493 ns |  0.97 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 26     | Random     | 1,477.71 ns |  37.549 ns |  33.286 ns |  1.04 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 26     | Random     |   119.46 ns |   6.693 ns |   5.933 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 26     | Random     | 1,652.22 ns | 131.893 ns | 116.919 ns |  1.16 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 26     | Random     | 1,679.81 ns |  84.440 ns |  74.854 ns |  1.18 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Random     |   125.68 ns |   4.896 ns |   4.340 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 26     | Random     | 1,502.48 ns |  36.791 ns |  32.614 ns |  1.06 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 26     | Random     | 1,450.96 ns | 102.499 ns |  85.591 ns |  1.02 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 26     | Random     | 1,503.01 ns |  65.886 ns |  58.406 ns |  1.06 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 26     | Random     | 1,557.25 ns |  51.172 ns |  45.362 ns |  1.10 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 26     | Random     | 1,476.79 ns |  92.269 ns |  81.794 ns |  1.04 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 26     | Random     | 1,112.24 ns |  92.695 ns |  82.172 ns |  0.78 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 26     | Random     |   120.44 ns |   4.937 ns |   4.376 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 26     | Random     |   144.00 ns |   9.076 ns |   8.046 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 26     | Random     | 1,377.83 ns |  38.147 ns |  33.816 ns |  0.97 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 26     | Random     |    39.86 ns |   1.318 ns |   1.169 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 26     | Random     |    92.32 ns |   2.332 ns |   1.948 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 26     | Random     |   119.24 ns |   2.377 ns |   1.855 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 26     | Random     |    67.87 ns |   1.693 ns |   1.501 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Random     |    58.14 ns |   2.118 ns |   1.877 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 26     | Random     |    97.59 ns |   2.224 ns |   1.857 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 26     | Random     |   101.20 ns |   2.354 ns |   1.966 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 26     | Random     |   101.47 ns |   2.446 ns |   1.910 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 26     | Random     |    42.14 ns |   1.100 ns |   0.976 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 26     | Random     |    95.45 ns |   2.809 ns |   2.346 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 26     | Random     |   472.26 ns |   3.809 ns |   3.377 ns |  0.33 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 26     | Random     |    54.52 ns |   3.296 ns |   2.753 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 26     | Random     |    98.06 ns |   5.690 ns |   4.752 ns |  0.07 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 26     | Random     |    95.28 ns |   2.167 ns |   1.921 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Sorted**     |    **81.01 ns** |   **8.694 ns** |   **7.707 ns** |  **1.01** |    **0.15** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Sorted     |    89.97 ns |   1.306 ns |   1.158 ns |  1.12 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Sorted     |    56.74 ns |   2.191 ns |   1.943 ns |  0.71 |    0.08 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Reversed**   |   **100.98 ns** |   **3.808 ns** |   **3.376 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Reversed   |   107.39 ns |   2.972 ns |   2.634 ns |  1.06 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Reversed   |    56.53 ns |   2.254 ns |   1.998 ns |  0.56 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Duplicates** |    **95.62 ns** |   **2.904 ns** |   **2.574 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Duplicates |    99.42 ns |   3.586 ns |   3.179 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Duplicates |    59.58 ns |   2.706 ns |   2.399 ns |  0.62 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **27**     | **Random**     | **1,340.47 ns** |  **50.938 ns** |  **45.156 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 27     | Random     |    98.94 ns |   4.606 ns |   4.083 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 27     | Random     | 1,708.42 ns |  37.225 ns |  31.084 ns |  1.28 |    0.05 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 27     | Random     | 1,630.59 ns | 108.857 ns |  96.499 ns |  1.22 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 27     | Random     |   110.14 ns |   6.819 ns |   6.045 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 27     | Random     | 1,401.29 ns |  86.686 ns |  76.845 ns |  1.05 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 27     | Random     | 1,496.06 ns |  37.764 ns |  33.477 ns |  1.12 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 27     | Random     | 1,438.41 ns |  71.392 ns |  63.287 ns |  1.07 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 27     | Random     | 1,497.06 ns |  30.139 ns |  26.718 ns |  1.12 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 27     | Random     | 1,419.01 ns |  54.120 ns |  47.976 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 27     | Random     | 1,094.86 ns | 101.134 ns |  89.653 ns |  0.82 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 27     | Random     |   113.14 ns |   4.091 ns |   3.416 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 27     | Random     |   156.47 ns |   2.390 ns |   2.119 ns |  0.12 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 27     | Random     | 1,330.98 ns |  48.375 ns |  42.884 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 27     | Random     | 1,385.61 ns | 112.225 ns |  99.484 ns |  1.03 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 27     | Random     |    98.84 ns |   2.499 ns |   2.215 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 27     | Random     | 1,602.93 ns | 120.333 ns | 106.672 ns |  1.20 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 27     | Random     | 1,616.83 ns |  96.839 ns |  85.845 ns |  1.21 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Random     |   113.27 ns |   3.558 ns |   2.971 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 27     | Random     | 1,453.77 ns |  33.903 ns |  30.054 ns |  1.09 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 27     | Random     | 1,476.51 ns |  77.694 ns |  68.874 ns |  1.10 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 27     | Random     | 1,435.21 ns |  56.379 ns |  49.978 ns |  1.07 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 27     | Random     | 1,492.30 ns |  32.008 ns |  28.375 ns |  1.11 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 27     | Random     | 1,434.49 ns |  48.834 ns |  43.290 ns |  1.07 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 27     | Random     | 1,085.46 ns | 109.523 ns |  97.090 ns |  0.81 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 27     | Random     |   111.54 ns |   4.969 ns |   4.404 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 27     | Random     |   150.57 ns |   1.948 ns |   1.726 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 27     | Random     | 1,295.14 ns |  62.047 ns |  55.003 ns |  0.97 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 27     | Random     |    37.01 ns |   1.280 ns |   1.135 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 27     | Random     |    97.12 ns |   1.961 ns |   1.739 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 27     | Random     |    93.65 ns |   2.023 ns |   1.689 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 27     | Random     |    64.73 ns |   1.923 ns |   1.501 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Random     |    56.06 ns |   2.697 ns |   2.391 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 27     | Random     |   101.43 ns |   2.305 ns |   2.043 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 27     | Random     |   105.98 ns |   2.169 ns |   1.922 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 27     | Random     |   106.35 ns |   2.102 ns |   1.863 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 27     | Random     |    39.29 ns |   1.231 ns |   1.091 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 27     | Random     |   100.68 ns |   2.553 ns |   2.132 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 27     | Random     |   522.57 ns |   4.468 ns |   3.961 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 27     | Random     |    53.04 ns |   1.965 ns |   1.742 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 27     | Random     |    99.60 ns |   1.769 ns |   1.568 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 27     | Random     |   100.77 ns |   2.480 ns |   2.071 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Sorted**     |    **87.00 ns** |   **3.582 ns** |   **3.175 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Sorted     |    93.06 ns |   2.906 ns |   2.576 ns |  1.07 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Sorted     |    55.77 ns |   2.088 ns |   1.851 ns |  0.64 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Reversed**   |    **94.05 ns** |   **3.714 ns** |   **3.293 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Reversed   |   101.19 ns |   7.534 ns |   6.679 ns |  1.08 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Reversed   |    55.54 ns |   1.946 ns |   1.725 ns |  0.59 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Duplicates** |   **110.79 ns** |   **4.276 ns** |   **3.571 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Duplicates |   115.05 ns |   4.731 ns |   4.194 ns |  1.04 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Duplicates |    55.94 ns |   2.193 ns |   1.944 ns |  0.51 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **28**     | **Random**     | **1,530.40 ns** |  **55.375 ns** |  **49.088 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 28     | Random     |   128.74 ns |   8.850 ns |   7.845 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 28     | Random     | 1,911.05 ns | 113.863 ns | 100.936 ns |  1.25 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 28     | Random     | 1,771.20 ns | 196.848 ns | 184.131 ns |  1.16 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 28     | Random     |   132.31 ns |   4.779 ns |   3.731 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 28     | Random     | 1,633.54 ns | 118.228 ns | 104.806 ns |  1.07 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 28     | Random     | 1,535.75 ns | 139.508 ns | 116.496 ns |  1.00 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 28     | Random     | 1,665.75 ns |  69.438 ns |  61.555 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 28     | Random     | 1,699.16 ns |  72.262 ns |  64.058 ns |  1.11 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 28     | Random     | 1,648.84 ns |  38.753 ns |  34.353 ns |  1.08 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 28     | Random     | 1,152.32 ns | 148.273 ns | 131.440 ns |  0.75 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 28     | Random     |   137.07 ns |   1.365 ns |   1.065 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 28     | Random     |   165.45 ns |  12.501 ns |  11.082 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 28     | Random     | 1,546.64 ns |  40.080 ns |  35.530 ns |  1.01 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 28     | Random     | 1,552.42 ns |  91.361 ns |  80.989 ns |  1.02 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 28     | Random     |   135.00 ns |   2.244 ns |   1.989 ns |  0.09 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 28     | Random     | 1,762.79 ns | 164.019 ns | 153.423 ns |  1.15 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 28     | Random     | 1,864.33 ns | 140.116 ns | 131.065 ns |  1.22 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Random     |   141.11 ns |   3.521 ns |   2.940 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 28     | Random     | 1,694.59 ns |  36.474 ns |  32.333 ns |  1.11 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 28     | Random     | 1,651.84 ns |  78.174 ns |  69.299 ns |  1.08 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 28     | Random     | 1,704.48 ns |  39.261 ns |  34.804 ns |  1.11 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 28     | Random     | 1,669.95 ns |  70.353 ns |  58.748 ns |  1.09 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 28     | Random     | 1,656.91 ns |  73.982 ns |  65.583 ns |  1.08 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 28     | Random     | 1,178.24 ns | 108.790 ns |  96.440 ns |  0.77 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 28     | Random     |   143.51 ns |   3.106 ns |   2.753 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 28     | Random     |   169.01 ns |   3.869 ns |   3.430 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 28     | Random     | 1,498.61 ns |  43.785 ns |  38.814 ns |  0.98 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 28     | Random     |    36.70 ns |   1.101 ns |   0.976 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 28     | Random     |    98.94 ns |   1.950 ns |   1.728 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 28     | Random     |    92.84 ns |   2.610 ns |   2.038 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 28     | Random     |    67.01 ns |   3.297 ns |   2.923 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Random     |    55.64 ns |   2.569 ns |   2.277 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 28     | Random     |   107.56 ns |   2.607 ns |   2.311 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 28     | Random     |   110.05 ns |   2.626 ns |   2.328 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 28     | Random     |   112.65 ns |   4.790 ns |   4.246 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 28     | Random     |    39.70 ns |   1.702 ns |   1.421 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 28     | Random     |   102.45 ns |   2.170 ns |   1.812 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 28     | Random     |   539.86 ns |   4.243 ns |   3.761 ns |  0.35 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 28     | Random     |    52.86 ns |   2.068 ns |   1.833 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 28     | Random     |   103.79 ns |   2.246 ns |   1.876 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 28     | Random     |   103.18 ns |   2.592 ns |   2.164 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Sorted**     |    **87.26 ns** |   **3.189 ns** |   **2.827 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Sorted     |    89.84 ns |   2.815 ns |   2.495 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Sorted     |    56.29 ns |   3.228 ns |   2.862 ns |  0.65 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Reversed**   |   **106.52 ns** |   **3.959 ns** |   **3.510 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Reversed   |   112.38 ns |   3.595 ns |   3.187 ns |  1.06 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Reversed   |    54.94 ns |   2.000 ns |   1.773 ns |  0.52 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Duplicates** |   **114.16 ns** |   **3.534 ns** |   **2.951 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Duplicates |   118.47 ns |   4.684 ns |   4.152 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Duplicates |    56.18 ns |   2.018 ns |   1.685 ns |  0.49 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **29**     | **Random**     | **1,470.87 ns** |  **31.698 ns** |  **28.099 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 29     | Random     |   108.25 ns |   1.939 ns |   1.719 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 29     | Random     | 1,830.93 ns |  79.956 ns |  70.879 ns |  1.25 |    0.05 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 29     | Random     | 1,804.35 ns | 126.080 ns | 117.935 ns |  1.23 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 29     | Random     |   123.47 ns |   3.980 ns |   3.528 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 29     | Random     | 1,570.42 ns | 143.298 ns | 111.877 ns |  1.07 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 29     | Random     | 1,536.56 ns |  96.998 ns |  85.986 ns |  1.05 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 29     | Random     | 1,573.79 ns |  37.682 ns |  33.404 ns |  1.07 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 29     | Random     | 1,600.39 ns |  58.718 ns |  52.052 ns |  1.09 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 29     | Random     | 1,565.45 ns |  57.554 ns |  48.060 ns |  1.06 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 29     | Random     | 1,233.97 ns | 118.015 ns | 104.617 ns |  0.84 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 29     | Random     |   124.91 ns |   9.371 ns |   8.308 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 29     | Random     |   176.22 ns |   5.077 ns |   4.501 ns |  0.12 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 29     | Random     | 1,458.19 ns |  57.399 ns |  50.883 ns |  0.99 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 29     | Random     | 1,467.91 ns |  46.418 ns |  41.149 ns |  1.00 |    0.03 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 29     | Random     |   116.82 ns |   8.538 ns |   7.568 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 29     | Random     | 1,718.13 ns | 113.447 ns | 100.568 ns |  1.17 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 29     | Random     | 1,723.66 ns | 107.522 ns |  95.315 ns |  1.17 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Random     |   127.15 ns |   5.238 ns |   4.643 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 29     | Random     | 1,613.48 ns |  42.420 ns |  37.604 ns |  1.10 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 29     | Random     | 1,615.76 ns |  33.582 ns |  29.769 ns |  1.10 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 29     | Random     | 1,597.49 ns |  34.748 ns |  30.803 ns |  1.09 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 29     | Random     | 1,572.80 ns | 187.232 ns | 156.347 ns |  1.07 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 29     | Random     | 1,569.11 ns |  54.699 ns |  48.489 ns |  1.07 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 29     | Random     | 1,314.21 ns |  86.727 ns |  76.881 ns |  0.89 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 29     | Random     |   123.89 ns |   5.674 ns |   5.030 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 29     | Random     |   162.17 ns |  12.264 ns |  10.872 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 29     | Random     | 1,437.11 ns |  31.489 ns |  27.914 ns |  0.98 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 29     | Random     |    38.26 ns |   1.214 ns |   1.014 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 29     | Random     |   105.65 ns |   1.926 ns |   1.708 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 29     | Random     |   131.90 ns |   2.793 ns |   2.332 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 29     | Random     |    73.71 ns |   1.539 ns |   1.365 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Random     |    65.34 ns |   2.549 ns |   2.260 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 29     | Random     |   112.82 ns |   2.352 ns |   1.964 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 29     | Random     |   118.34 ns |   2.414 ns |   2.140 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 29     | Random     |   117.90 ns |   2.580 ns |   2.154 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 29     | Random     |    41.03 ns |   1.500 ns |   1.253 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 29     | Random     |   110.82 ns |   2.454 ns |   2.049 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 29     | Random     |   566.63 ns |   9.783 ns |   8.672 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 29     | Random     |    61.20 ns |   2.299 ns |   2.038 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 29     | Random     |   113.65 ns |   2.814 ns |   2.197 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 29     | Random     |   111.41 ns |   2.653 ns |   2.352 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Sorted**     |    **89.06 ns** |   **2.218 ns** |   **1.852 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Sorted     |    94.74 ns |   6.064 ns |   5.376 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Sorted     |    64.71 ns |   2.250 ns |   1.995 ns |  0.73 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Reversed**   |   **110.88 ns** |  **31.739 ns** |  **28.136 ns** |  **1.05** |    **0.35** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Reversed   |   113.60 ns |   2.345 ns |   2.078 ns |  1.08 |    0.23 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Reversed   |    64.02 ns |   2.258 ns |   2.002 ns |  0.61 |    0.13 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Duplicates** |   **113.68 ns** |  **16.550 ns** |  **13.820 ns** |  **1.01** |    **0.16** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Duplicates |   111.99 ns |   3.621 ns |   3.210 ns |  1.00 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Duplicates |    63.56 ns |   2.768 ns |   2.454 ns |  0.57 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **30**     | **Random**     | **1,494.34 ns** |  **41.271 ns** |  **36.586 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 30     | Random     |   118.44 ns |   2.435 ns |   2.159 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 30     | Random     | 1,870.60 ns |  40.905 ns |  31.936 ns |  1.25 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 30     | Random     | 1,724.35 ns | 168.015 ns | 157.161 ns |  1.15 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 30     | Random     |   126.76 ns |  16.761 ns |  13.996 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 30     | Random     | 1,623.03 ns |  87.449 ns |  77.521 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 30     | Random     | 1,598.39 ns | 110.671 ns |  98.107 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 30     | Random     | 1,593.43 ns | 116.462 ns | 103.240 ns |  1.07 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 30     | Random     | 1,615.52 ns |  98.899 ns |  87.671 ns |  1.08 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 30     | Random     | 1,552.47 ns | 109.537 ns |  97.102 ns |  1.04 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 30     | Random     | 1,326.66 ns | 194.418 ns | 172.346 ns |  0.89 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 30     | Random     |   119.23 ns |   5.110 ns |   4.529 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 30     | Random     |   141.42 ns |   2.144 ns |   1.791 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 30     | Random     | 1,434.01 ns | 143.902 ns | 127.565 ns |  0.96 |    0.09 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 30     | Random     | 1,470.24 ns |  97.303 ns |  86.257 ns |  0.98 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 30     | Random     |   121.67 ns |   6.170 ns |   4.817 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 30     | Random     | 1,780.44 ns | 197.029 ns | 184.301 ns |  1.19 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 30     | Random     | 1,850.11 ns |  59.362 ns |  52.623 ns |  1.24 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Random     |   118.76 ns |   2.799 ns |   2.481 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 30     | Random     | 1,590.61 ns | 103.633 ns |  91.868 ns |  1.07 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 30     | Random     | 1,602.06 ns | 108.658 ns |  96.322 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 30     | Random     | 1,616.26 ns |  62.297 ns |  55.225 ns |  1.08 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 30     | Random     | 1,649.16 ns |  41.789 ns |  37.045 ns |  1.10 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 30     | Random     | 1,595.61 ns | 117.832 ns | 104.455 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 30     | Random     | 1,305.50 ns | 145.620 ns | 129.089 ns |  0.87 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 30     | Random     |   116.30 ns |   3.491 ns |   3.094 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 30     | Random     |   141.86 ns |   3.753 ns |   3.327 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 30     | Random     | 1,357.43 ns | 139.726 ns | 123.864 ns |  0.91 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 30     | Random     |    40.90 ns |   0.883 ns |   0.737 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 30     | Random     |   110.16 ns |   2.370 ns |   2.101 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 30     | Random     |   132.82 ns |   3.595 ns |   2.807 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 30     | Random     |    71.89 ns |   1.817 ns |   1.610 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Random     |    62.76 ns |   2.144 ns |   1.901 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 30     | Random     |   119.57 ns |   1.522 ns |   1.188 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 30     | Random     |   122.32 ns |   2.399 ns |   2.127 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 30     | Random     |   122.90 ns |   2.509 ns |   2.095 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 30     | Random     |    43.26 ns |   1.194 ns |   1.058 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 30     | Random     |   117.06 ns |   3.348 ns |   2.968 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 30     | Random     |   585.97 ns |   5.065 ns |   4.490 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 30     | Random     |    60.73 ns |   2.440 ns |   2.038 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.18 ns |   2.265 ns |   2.008 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 30     | Random     |   115.89 ns |   2.345 ns |   2.079 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Sorted**     |    **87.49 ns** |   **5.014 ns** |   **4.445 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Sorted     |    91.84 ns |   9.347 ns |   8.286 ns |  1.05 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Sorted     |    65.23 ns |   2.597 ns |   2.168 ns |  0.75 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Reversed**   |   **109.33 ns** |   **2.835 ns** |   **2.214 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Reversed   |   121.30 ns |  14.791 ns |  12.351 ns |  1.11 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Reversed   |    64.24 ns |   2.476 ns |   2.195 ns |  0.59 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Duplicates** |   **132.21 ns** |  **18.840 ns** |  **16.701 ns** |  **1.01** |    **0.17** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Duplicates |   121.67 ns |   3.597 ns |   3.189 ns |  0.93 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Duplicates |    62.94 ns |   1.620 ns |   1.436 ns |  0.48 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **31**     | **Random**     | **1,627.90 ns** | **116.475 ns** | **103.252 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 31     | Random     |   128.44 ns |   2.164 ns |   1.919 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 31     | Random     | 2,152.84 ns |  45.870 ns |  40.663 ns |  1.33 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 31     | Random     | 1,926.77 ns | 153.285 ns | 143.383 ns |  1.19 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 31     | Random     |   143.93 ns |   9.522 ns |   8.441 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 31     | Random     | 1,778.97 ns |  96.592 ns |  75.412 ns |  1.10 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 31     | Random     | 1,817.61 ns |  81.146 ns |  71.934 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 31     | Random     | 1,822.42 ns |  52.510 ns |  46.549 ns |  1.12 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 31     | Random     | 1,820.96 ns |  84.728 ns |  75.109 ns |  1.12 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 31     | Random     | 1,752.78 ns |  92.686 ns |  86.699 ns |  1.08 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 31     | Random     | 1,429.10 ns | 122.548 ns | 108.636 ns |  0.88 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 31     | Random     |   139.43 ns |   5.270 ns |   4.672 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 31     | Random     |   196.69 ns |  12.134 ns |  10.756 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 31     | Random     | 1,717.74 ns |  58.906 ns |  52.219 ns |  1.06 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 31     | Random     | 1,698.98 ns |  56.650 ns |  50.219 ns |  1.05 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 31     | Random     |   132.85 ns |   5.374 ns |   4.764 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 31     | Random     | 1,909.36 ns | 118.497 ns |  98.950 ns |  1.18 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 31     | Random     | 2,003.36 ns | 145.687 ns | 129.148 ns |  1.24 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Random     |   145.63 ns |   8.546 ns |   7.576 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 31     | Random     | 1,816.81 ns |  47.647 ns |  42.238 ns |  1.12 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 31     | Random     | 1,775.42 ns | 100.307 ns |  83.761 ns |  1.09 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 31     | Random     | 1,802.22 ns | 115.608 ns | 102.484 ns |  1.11 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 31     | Random     | 1,824.31 ns | 102.003 ns |  90.423 ns |  1.13 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 31     | Random     | 1,831.69 ns | 104.612 ns |  92.736 ns |  1.13 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 31     | Random     | 1,387.94 ns | 131.442 ns | 116.520 ns |  0.86 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 31     | Random     |   136.14 ns |   5.887 ns |   5.219 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 31     | Random     |   194.14 ns |   3.420 ns |   3.032 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 31     | Random     | 1,623.54 ns |  90.500 ns |  80.226 ns |  1.00 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 31     | Random     |    38.40 ns |   1.569 ns |   1.391 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 31     | Random     |   109.86 ns |   2.474 ns |   2.066 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 31     | Random     |   126.20 ns |   2.402 ns |   2.129 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 31     | Random     |    71.25 ns |   2.167 ns |   1.810 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Random     |    60.21 ns |   1.567 ns |   1.389 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 31     | Random     |   118.29 ns |   2.537 ns |   2.249 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 31     | Random     |   123.17 ns |   2.861 ns |   2.536 ns |  0.08 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 31     | Random     |   122.81 ns |   2.528 ns |   2.241 ns |  0.08 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 31     | Random     |    40.84 ns |   1.460 ns |   1.295 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 31     | Random     |   116.84 ns |   2.831 ns |   2.510 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 31     | Random     |   605.22 ns |   4.856 ns |   4.055 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 31     | Random     |    56.11 ns |   2.275 ns |   2.016 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 31     | Random     |   116.01 ns |   2.966 ns |   2.629 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 31     | Random     |   114.99 ns |   2.272 ns |   2.015 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Sorted**     |    **87.87 ns** |   **1.741 ns** |   **1.543 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Sorted     |    95.36 ns |   5.448 ns |   4.830 ns |  1.09 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Sorted     |    58.98 ns |   2.145 ns |   1.901 ns |  0.67 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Reversed**   |   **114.62 ns** |   **9.825 ns** |   **8.204 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Reversed   |   120.32 ns |   3.978 ns |   3.106 ns |  1.06 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Reversed   |    59.72 ns |   3.175 ns |   2.651 ns |  0.52 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Duplicates** |   **128.74 ns** |   **3.391 ns** |   **3.006 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Duplicates |   132.78 ns |   4.080 ns |   3.407 ns |  1.03 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Duplicates |    60.96 ns |   3.036 ns |   2.691 ns |  0.47 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **32**     | **Random**     | **1,724.79 ns** | **123.909 ns** | **109.842 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 32     | Random     |   130.72 ns |   6.716 ns |   5.953 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 32     | Random     | 2,092.00 ns | 186.441 ns | 174.397 ns |  1.22 |    0.13 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 32     | Random     | 2,092.29 ns | 217.095 ns | 203.071 ns |  1.22 |    0.14 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 32     | Random     |   156.33 ns |  13.415 ns |  11.892 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 32     | Random     | 1,899.98 ns |  36.807 ns |  32.628 ns |  1.11 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 32     | Random     | 1,857.89 ns | 112.881 ns | 100.066 ns |  1.08 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 32     | Random     | 1,861.25 ns |  43.702 ns |  38.741 ns |  1.08 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 32     | Random     | 1,884.78 ns | 113.253 ns | 100.396 ns |  1.10 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 32     | Random     | 1,814.25 ns |  99.152 ns |  82.796 ns |  1.06 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 32     | Random     | 1,358.84 ns | 183.724 ns | 171.855 ns |  0.79 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 32     | Random     |   149.13 ns |   5.118 ns |   4.537 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 32     | Random     |   207.82 ns |  36.906 ns |  32.716 ns |  0.12 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 32     | Random     | 1,745.63 ns |  40.218 ns |  35.652 ns |  1.02 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 32     | Random     | 1,782.44 ns |  56.859 ns |  50.404 ns |  1.04 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 32     | Random     |   137.82 ns |   4.195 ns |   3.719 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 32     | Random     | 1,966.75 ns | 193.893 ns | 171.881 ns |  1.15 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 32     | Random     | 2,098.45 ns |  95.652 ns |  84.793 ns |  1.22 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Random     |   166.93 ns |   5.653 ns |   5.011 ns |  0.10 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 32     | Random     | 1,853.90 ns | 101.047 ns |  89.575 ns |  1.08 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 32     | Random     | 1,918.15 ns |  70.230 ns |  58.645 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 32     | Random     | 1,860.37 ns | 115.881 ns | 102.726 ns |  1.08 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 32     | Random     | 1,905.68 ns |  60.498 ns |  53.630 ns |  1.11 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 32     | Random     | 1,810.84 ns | 117.267 ns | 103.954 ns |  1.05 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 32     | Random     | 1,491.66 ns | 164.266 ns | 145.618 ns |  0.87 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 32     | Random     |   143.55 ns |   3.231 ns |   2.698 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 32     | Random     |   216.64 ns |   2.747 ns |   2.435 ns |  0.13 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 32     | Random     | 1,962.55 ns | 557.409 ns | 521.401 ns |  1.14 |    0.30 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 32     | Random     |    37.08 ns |   1.305 ns |   1.090 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 32     | Random     |   114.46 ns |   2.818 ns |   2.498 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 32     | Random     |   121.91 ns |   3.485 ns |   2.721 ns |  0.07 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 32     | Random     |    69.47 ns |   2.628 ns |   2.330 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Random     |    57.90 ns |   2.241 ns |   1.986 ns |  0.03 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 32     | Random     |   124.49 ns |   2.466 ns |   2.186 ns |  0.07 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 32     | Random     |   129.46 ns |   3.949 ns |   3.500 ns |  0.08 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 32     | Random     |   127.74 ns |   2.443 ns |   2.040 ns |  0.07 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 32     | Random     |    40.01 ns |   1.474 ns |   1.306 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 32     | Random     |   121.40 ns |   2.195 ns |   1.945 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 32     | Random     |   629.29 ns |  12.985 ns |  11.511 ns |  0.37 |    0.03 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 32     | Random     |    57.49 ns |   3.428 ns |   3.038 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 32     | Random     |   122.76 ns |   2.293 ns |   1.915 ns |  0.07 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 32     | Random     |   121.33 ns |   2.631 ns |   2.332 ns |  0.07 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Sorted**     |    **94.01 ns** |   **2.681 ns** |   **2.377 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Sorted     |    99.46 ns |   7.957 ns |   7.054 ns |  1.06 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Sorted     |    58.90 ns |   3.069 ns |   2.720 ns |  0.63 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Reversed**   |   **114.14 ns** |   **8.263 ns** |   **7.325 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Reversed   |   122.92 ns |  11.248 ns |   9.971 ns |  1.08 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Reversed   |    59.66 ns |   3.007 ns |   2.666 ns |  0.52 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Duplicates** |   **123.62 ns** |   **4.054 ns** |   **3.385 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Duplicates |   127.16 ns |   3.270 ns |   2.899 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Duplicates |    58.49 ns |   2.053 ns |   1.820 ns |  0.47 |    0.02 |         - |          NA |

