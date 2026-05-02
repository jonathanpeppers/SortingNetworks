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
| **CharSortingBenchmarks**   | **ArraySort**     | **8**      | **Random**     |    **29.34 ns** |   **1.918 ns** |   **1.701 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 8      | Random     |   313.05 ns |   9.319 ns |   8.261 ns | 10.71 |    0.68 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 8      | Random     |   276.55 ns |   8.079 ns |   7.162 ns |  9.46 |    0.60 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 8      | Random     |    32.07 ns |   1.432 ns |   1.269 ns |  1.10 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 8      | Random     |   307.59 ns |   9.201 ns |   8.157 ns | 10.52 |    0.67 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 8      | Random     |   274.29 ns |  10.475 ns |   9.286 ns |  9.38 |    0.63 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 8      | Random     |    20.85 ns |   0.684 ns |   0.606 ns |  0.71 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 8      | Random     |    23.67 ns |   0.953 ns |   0.844 ns |  0.81 |    0.05 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 8      | Random     |    23.74 ns |   0.925 ns |   0.820 ns |  0.81 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **16**     | **Random**     |    **68.55 ns** |   **3.411 ns** |   **3.024 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 16     | Random     |   942.66 ns |  10.207 ns |   9.048 ns | 13.78 |    0.62 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 16     | Random     |   908.17 ns |   9.826 ns |   7.671 ns | 13.27 |    0.60 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 16     | Random     |    72.64 ns |   3.828 ns |   3.393 ns |  1.06 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 16     | Random     |   930.13 ns |  10.919 ns |   9.680 ns | 13.59 |    0.62 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 16     | Random     |   800.56 ns |  10.297 ns |   9.128 ns | 11.70 |    0.53 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 16     | Random     |    30.78 ns |   1.129 ns |   0.942 ns |  0.45 |    0.02 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 16     | Random     |    33.18 ns |   1.136 ns |   1.007 ns |  0.48 |    0.03 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 16     | Random     |    33.20 ns |   1.124 ns |   0.996 ns |  0.49 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **23**     | **Random**     | **1,112.16 ns** |  **36.386 ns** |  **32.256 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 23     | Random     |    76.30 ns |   2.987 ns |   2.648 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 23     | Random     | 1,419.35 ns |  36.263 ns |  32.147 ns |  1.28 |    0.05 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 23     | Random     | 1,343.48 ns | 120.567 ns | 106.880 ns |  1.21 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 23     | Random     |    92.34 ns |   5.262 ns |   4.664 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 23     | Random     | 1,218.56 ns |  40.115 ns |  35.561 ns |  1.10 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 23     | Random     | 1,280.88 ns |  32.638 ns |  28.933 ns |  1.15 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 23     | Random     | 1,184.53 ns |  70.615 ns |  62.599 ns |  1.07 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 23     | Random     | 1,237.95 ns |  63.175 ns |  56.003 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 23     | Random     | 1,274.87 ns |  38.372 ns |  34.016 ns |  1.15 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 23     | Random     |   982.07 ns |  90.132 ns |  79.900 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 23     | Random     |    98.65 ns |   3.839 ns |   3.403 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 23     | Random     |   117.89 ns |   4.052 ns |   3.592 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 23     | Random     | 1,129.75 ns |  26.938 ns |  22.494 ns |  1.02 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 23     | Random     | 1,126.68 ns |  57.412 ns |  50.894 ns |  1.01 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 23     | Random     |    79.64 ns |   2.622 ns |   2.190 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 23     | Random     | 1,304.57 ns |  87.042 ns |  77.161 ns |  1.17 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 23     | Random     | 1,353.81 ns |  47.143 ns |  41.791 ns |  1.22 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Random     |    96.91 ns |   4.533 ns |   4.018 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 23     | Random     | 1,219.16 ns |  51.385 ns |  45.552 ns |  1.10 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 23     | Random     | 1,238.52 ns |  27.611 ns |  24.477 ns |  1.11 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 23     | Random     | 1,215.95 ns |  42.394 ns |  37.581 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 23     | Random     | 1,228.59 ns |  54.068 ns |  47.930 ns |  1.11 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 23     | Random     | 1,207.15 ns |  50.842 ns |  45.070 ns |  1.09 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 23     | Random     |   982.76 ns |  82.884 ns |  73.475 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 23     | Random     |    95.91 ns |   5.834 ns |   5.171 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 23     | Random     |   115.58 ns |  15.081 ns |  12.593 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 23     | Random     | 1,098.53 ns |  41.456 ns |  36.750 ns |  0.99 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 23     | Random     |    35.88 ns |   1.430 ns |   1.194 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 23     | Random     |    81.96 ns |   2.181 ns |   1.821 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 23     | Random     |    86.39 ns |   3.622 ns |   3.211 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 23     | Random     |    59.73 ns |   1.562 ns |   1.220 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Random     |    48.31 ns |   1.689 ns |   1.498 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 23     | Random     |    88.44 ns |   2.181 ns |   1.821 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    92.72 ns |   2.524 ns |   2.237 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 23     | Random     |    92.64 ns |   2.500 ns |   2.216 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 23     | Random     |    38.31 ns |   1.171 ns |   1.038 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 23     | Random     |    87.60 ns |   2.566 ns |   2.275 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 23     | Random     |   391.50 ns |   2.859 ns |   2.534 ns |  0.35 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    46.76 ns |   1.999 ns |   1.772 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 23     | Random     |    85.64 ns |   1.943 ns |   1.722 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 23     | Random     |    86.69 ns |   2.129 ns |   1.887 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Sorted**     |    **61.68 ns** |   **2.527 ns** |   **2.240 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Sorted     |    65.17 ns |   3.424 ns |   3.035 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Sorted     |    49.00 ns |   1.906 ns |   1.592 ns |  0.80 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Reversed**   |    **85.53 ns** |   **2.238 ns** |   **1.984 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Reversed   |    90.93 ns |   4.918 ns |   3.840 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Reversed   |    47.64 ns |   1.829 ns |   1.621 ns |  0.56 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Duplicates** |    **87.76 ns** |   **2.647 ns** |   **2.347 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Duplicates |    94.60 ns |   5.096 ns |   4.517 ns |  1.08 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Duplicates |    47.63 ns |   1.768 ns |   1.568 ns |  0.54 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **24**     | **Random**     | **1,225.30 ns** |  **81.099 ns** |  **63.317 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 24     | Random     |   127.25 ns |   3.340 ns |   2.961 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 24     | Random     | 1,538.57 ns |  92.702 ns |  82.178 ns |  1.26 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 24     | Random     | 1,487.73 ns | 182.697 ns | 170.895 ns |  1.22 |    0.15 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 24     | Random     |   106.91 ns |   2.204 ns |   1.954 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 24     | Random     | 1,316.79 ns |  83.991 ns |  74.455 ns |  1.08 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 24     | Random     | 1,346.32 ns |  32.342 ns |  28.670 ns |  1.10 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 24     | Random     | 1,411.62 ns |  34.481 ns |  30.567 ns |  1.16 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 24     | Random     | 1,366.34 ns |  73.468 ns |  65.128 ns |  1.12 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 24     | Random     | 1,322.18 ns |  47.375 ns |  41.997 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 24     | Random     | 1,052.21 ns | 127.478 ns | 113.006 ns |  0.86 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 24     | Random     |   114.43 ns |   4.281 ns |   3.795 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 24     | Random     |   128.91 ns |   2.762 ns |   2.449 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 24     | Random     | 1,381.75 ns |  35.729 ns |  31.673 ns |  1.13 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 24     | Random     | 1,269.77 ns |  42.199 ns |  37.408 ns |  1.04 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 24     | Random     |   124.21 ns |   7.208 ns |   6.390 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 24     | Random     | 1,459.07 ns | 166.361 ns | 155.615 ns |  1.19 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 24     | Random     | 1,517.11 ns | 134.091 ns | 125.429 ns |  1.24 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Random     |   114.75 ns |   3.797 ns |   3.366 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 24     | Random     | 1,368.48 ns |  35.762 ns |  31.702 ns |  1.12 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 24     | Random     | 1,353.01 ns |  28.560 ns |  25.317 ns |  1.11 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 24     | Random     | 1,335.92 ns |  71.474 ns |  63.360 ns |  1.09 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 24     | Random     | 1,379.55 ns |  75.927 ns |  67.308 ns |  1.13 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 24     | Random     | 1,330.14 ns |  36.917 ns |  32.726 ns |  1.09 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 24     | Random     | 1,080.29 ns | 105.859 ns |  93.841 ns |  0.88 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 24     | Random     |   107.97 ns |   2.676 ns |   2.089 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 24     | Random     |   125.70 ns |   4.867 ns |   4.314 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 24     | Random     | 1,230.84 ns |  68.002 ns |  60.282 ns |  1.01 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 24     | Random     |    38.51 ns |   1.133 ns |   1.004 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 24     | Random     |    80.35 ns |   2.347 ns |   2.081 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 24     | Random     |   100.98 ns |   2.251 ns |   1.995 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 24     | Random     |    62.90 ns |   1.791 ns |   1.496 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Random     |    51.05 ns |   1.741 ns |   1.454 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 24     | Random     |    86.55 ns |   2.140 ns |   1.787 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    91.93 ns |   2.650 ns |   2.213 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 24     | Random     |    91.14 ns |   2.504 ns |   2.219 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 24     | Random     |    41.30 ns |   1.369 ns |   1.213 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 24     | Random     |    84.61 ns |   2.042 ns |   1.810 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 24     | Random     |   417.86 ns |   4.603 ns |   3.594 ns |  0.34 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    49.56 ns |   1.892 ns |   1.677 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 24     | Random     |    84.44 ns |   1.914 ns |   1.696 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 24     | Random     |    85.34 ns |   2.534 ns |   2.116 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Sorted**     |    **69.68 ns** |   **2.037 ns** |   **1.806 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Sorted     |    79.03 ns |   2.734 ns |   2.424 ns |  1.13 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Sorted     |    53.17 ns |   1.922 ns |   1.704 ns |  0.76 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Reversed**   |    **92.68 ns** |   **2.371 ns** |   **2.102 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Reversed   |    98.07 ns |   5.959 ns |   5.282 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Reversed   |    52.46 ns |   1.879 ns |   1.666 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Duplicates** |    **94.52 ns** |   **3.323 ns** |   **2.945 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Duplicates |    98.84 ns |   3.201 ns |   2.673 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Duplicates |    50.60 ns |   1.405 ns |   1.245 ns |  0.54 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **25**     | **Random**     | **1,170.07 ns** |  **75.586 ns** |  **67.005 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 25     | Random     |   125.72 ns |   1.696 ns |   1.416 ns |  0.11 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 25     | Random     | 1,374.44 ns | 127.402 ns | 112.938 ns |  1.18 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 25     | Random     | 1,370.92 ns | 140.020 ns | 124.124 ns |  1.18 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 25     | Random     |   104.33 ns |   3.079 ns |   2.729 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 25     | Random     | 1,243.72 ns |  74.486 ns |  66.030 ns |  1.07 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 25     | Random     | 1,270.16 ns |  52.334 ns |  46.393 ns |  1.09 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 25     | Random     | 1,260.83 ns |  36.121 ns |  32.020 ns |  1.08 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 25     | Random     | 1,370.44 ns |  90.301 ns |  80.049 ns |  1.18 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 25     | Random     | 1,253.82 ns |  39.328 ns |  34.863 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 25     | Random     |   880.09 ns |  73.553 ns |  65.202 ns |  0.75 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 25     | Random     |   109.56 ns |   2.824 ns |   2.503 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 25     | Random     |   121.56 ns |   2.001 ns |   1.671 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 25     | Random     | 1,181.75 ns |  61.497 ns |  54.515 ns |  1.01 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 25     | Random     | 1,208.84 ns |  40.562 ns |  35.957 ns |  1.04 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 25     | Random     |   122.01 ns |   2.226 ns |   1.973 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 25     | Random     | 1,317.49 ns | 149.059 ns | 132.137 ns |  1.13 |    0.13 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 25     | Random     | 1,412.36 ns | 115.561 ns | 102.442 ns |  1.21 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Random     |   109.63 ns |   5.268 ns |   4.670 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 25     | Random     | 1,277.54 ns |  37.853 ns |  33.556 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 25     | Random     | 1,281.58 ns |  33.927 ns |  30.075 ns |  1.10 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 25     | Random     | 1,301.32 ns |  36.479 ns |  32.338 ns |  1.12 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 25     | Random     | 1,302.61 ns |  32.806 ns |  29.081 ns |  1.12 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 25     | Random     | 1,212.96 ns | 105.718 ns |  93.717 ns |  1.04 |    0.10 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 25     | Random     |   957.40 ns | 141.660 ns | 125.578 ns |  0.82 |    0.12 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 25     | Random     |   107.12 ns |   3.481 ns |   3.086 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 25     | Random     |   127.63 ns |   3.695 ns |   3.275 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 25     | Random     | 1,129.39 ns |  65.560 ns |  58.117 ns |  0.97 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 25     | Random     |    38.71 ns |   0.844 ns |   0.748 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 25     | Random     |    88.94 ns |   2.235 ns |   1.981 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 25     | Random     |    99.82 ns |   3.000 ns |   2.342 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 25     | Random     |    68.51 ns |   2.749 ns |   2.437 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Random     |    57.29 ns |   1.728 ns |   1.532 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 25     | Random     |    95.26 ns |   2.338 ns |   2.072 ns |  0.08 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 25     | Random     |   100.05 ns |   2.309 ns |   2.047 ns |  0.09 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 25     | Random     |    99.88 ns |   2.732 ns |   2.281 ns |  0.09 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 25     | Random     |    41.40 ns |   1.091 ns |   0.967 ns |  0.04 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 25     | Random     |    94.19 ns |   2.299 ns |   2.038 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 25     | Random     |   439.06 ns |   3.466 ns |   2.894 ns |  0.38 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 25     | Random     |    53.36 ns |   2.171 ns |   1.813 ns |  0.05 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 25     | Random     |    92.61 ns |   2.091 ns |   1.854 ns |  0.08 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 25     | Random     |    94.64 ns |   2.552 ns |   2.262 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Sorted**     |    **80.18 ns** |   **2.158 ns** |   **1.913 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Sorted     |    87.19 ns |   2.717 ns |   2.409 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Sorted     |    55.85 ns |   2.635 ns |   2.201 ns |  0.70 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Reversed**   |    **91.20 ns** |   **3.740 ns** |   **3.123 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Reversed   |    93.59 ns |   3.814 ns |   3.381 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Reversed   |    55.71 ns |   2.141 ns |   1.898 ns |  0.61 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Duplicates** |   **100.13 ns** |   **5.196 ns** |   **4.339 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Duplicates |   104.31 ns |   8.772 ns |   7.776 ns |  1.04 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Duplicates |    56.96 ns |   1.904 ns |   1.688 ns |  0.57 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **26**     | **Random**     | **1,410.07 ns** |  **83.977 ns** |  **74.443 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 26     | Random     |   123.29 ns |   2.709 ns |   2.262 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 26     | Random     | 1,715.90 ns |  94.569 ns |  83.833 ns |  1.22 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 26     | Random     | 1,638.79 ns | 147.218 ns | 130.505 ns |  1.17 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 26     | Random     |   122.61 ns |   4.470 ns |   3.962 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 26     | Random     | 1,586.11 ns |  35.253 ns |  31.251 ns |  1.13 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 26     | Random     | 1,474.47 ns |  91.881 ns |  81.450 ns |  1.05 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 26     | Random     | 1,479.74 ns |  88.302 ns |  78.278 ns |  1.05 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 26     | Random     | 1,627.24 ns |  69.489 ns |  61.600 ns |  1.16 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 26     | Random     | 1,471.23 ns |  46.927 ns |  41.600 ns |  1.05 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 26     | Random     | 1,101.93 ns |  85.835 ns |  76.090 ns |  0.78 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 26     | Random     |   125.03 ns |   4.322 ns |   3.832 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 26     | Random     |   153.83 ns |  13.240 ns |  11.056 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 26     | Random     | 1,407.73 ns |  42.181 ns |  37.393 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 26     | Random     | 1,389.33 ns |  47.122 ns |  41.772 ns |  0.99 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 26     | Random     |   122.44 ns |   2.091 ns |   1.854 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 26     | Random     | 1,508.87 ns |  55.076 ns |  43.000 ns |  1.07 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 26     | Random     | 1,636.29 ns | 114.384 ns | 101.399 ns |  1.16 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Random     |   122.53 ns |   3.882 ns |   3.441 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 26     | Random     | 1,458.42 ns |  77.571 ns |  64.775 ns |  1.04 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 26     | Random     | 1,493.21 ns |  68.512 ns |  57.210 ns |  1.06 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 26     | Random     | 1,525.96 ns |  37.647 ns |  33.373 ns |  1.09 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 26     | Random     | 1,522.04 ns |  94.076 ns |  83.396 ns |  1.08 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 26     | Random     | 1,468.16 ns |  40.682 ns |  36.064 ns |  1.04 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 26     | Random     | 1,057.05 ns | 156.834 ns | 139.029 ns |  0.75 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 26     | Random     |   124.01 ns |   3.790 ns |   3.359 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 26     | Random     |   141.03 ns |   5.837 ns |   5.174 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 26     | Random     | 1,366.59 ns |  38.240 ns |  31.932 ns |  0.97 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 26     | Random     |    41.30 ns |   1.051 ns |   0.932 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 26     | Random     |    90.97 ns |   1.975 ns |   1.751 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 26     | Random     |   114.03 ns |   1.975 ns |   1.542 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 26     | Random     |    70.30 ns |   1.726 ns |   1.530 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Random     |    56.36 ns |   1.766 ns |   1.565 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 26     | Random     |    97.67 ns |   2.209 ns |   1.958 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 26     | Random     |   101.44 ns |   2.298 ns |   2.037 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 26     | Random     |   101.86 ns |   2.856 ns |   2.531 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 26     | Random     |    44.00 ns |   1.096 ns |   0.972 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 26     | Random     |    94.98 ns |   2.314 ns |   2.051 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 26     | Random     |   470.09 ns |   3.941 ns |   3.494 ns |  0.33 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 26     | Random     |    52.36 ns |   1.776 ns |   1.574 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 26     | Random     |    94.68 ns |   2.108 ns |   1.760 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 26     | Random     |    95.19 ns |   2.320 ns |   2.056 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Sorted**     |    **80.46 ns** |   **8.480 ns** |   **7.517 ns** |  **1.01** |    **0.14** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Sorted     |    88.10 ns |   5.777 ns |   5.121 ns |  1.11 |    0.14 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Sorted     |    56.37 ns |   1.976 ns |   1.752 ns |  0.71 |    0.08 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Reversed**   |   **100.26 ns** |   **3.948 ns** |   **3.500 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Reversed   |   108.78 ns |   2.357 ns |   1.968 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Reversed   |    57.10 ns |   2.479 ns |   2.198 ns |  0.57 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Duplicates** |    **95.58 ns** |   **3.496 ns** |   **3.099 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Duplicates |   100.45 ns |   2.706 ns |   2.399 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Duplicates |    58.11 ns |   1.985 ns |   1.760 ns |  0.61 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **27**     | **Random**     | **1,333.57 ns** |  **67.842 ns** |  **60.140 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 27     | Random     |    98.74 ns |   4.760 ns |   3.716 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 27     | Random     | 1,630.32 ns | 103.493 ns |  91.744 ns |  1.23 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 27     | Random     | 1,591.36 ns | 105.149 ns |  93.212 ns |  1.20 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 27     | Random     |   108.59 ns |   6.275 ns |   5.563 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 27     | Random     | 1,443.81 ns |  34.552 ns |  30.629 ns |  1.08 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 27     | Random     | 1,491.94 ns |  85.421 ns |  75.724 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 27     | Random     | 1,433.31 ns |  44.556 ns |  39.498 ns |  1.08 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 27     | Random     | 1,495.54 ns |  34.945 ns |  30.978 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 27     | Random     | 1,435.62 ns |  53.110 ns |  47.080 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 27     | Random     | 1,106.13 ns |  92.607 ns |  82.094 ns |  0.83 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 27     | Random     |   113.22 ns |   5.448 ns |   4.830 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 27     | Random     |   155.09 ns |  17.983 ns |  15.942 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 27     | Random     | 1,328.99 ns |  33.230 ns |  29.458 ns |  1.00 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 27     | Random     | 1,384.33 ns |  49.646 ns |  44.010 ns |  1.04 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 27     | Random     |    99.78 ns |   2.149 ns |   1.905 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 27     | Random     | 1,623.52 ns | 146.697 ns | 137.220 ns |  1.22 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 27     | Random     | 1,606.37 ns | 100.068 ns |  88.708 ns |  1.21 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Random     |   112.83 ns |   3.257 ns |   2.719 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 27     | Random     | 1,457.72 ns |  34.349 ns |  30.449 ns |  1.10 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 27     | Random     | 1,458.49 ns |  66.751 ns |  59.173 ns |  1.10 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 27     | Random     | 1,459.76 ns |  28.988 ns |  25.697 ns |  1.10 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 27     | Random     | 1,481.41 ns |  33.055 ns |  29.302 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 27     | Random     | 1,463.48 ns |  29.583 ns |  26.225 ns |  1.10 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 27     | Random     | 1,110.58 ns |  85.165 ns |  75.497 ns |  0.83 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 27     | Random     |   111.16 ns |   3.840 ns |   3.404 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 27     | Random     |   154.14 ns |   3.730 ns |   3.306 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 27     | Random     | 1,407.67 ns |  58.513 ns |  51.870 ns |  1.06 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 27     | Random     |    37.91 ns |   1.003 ns |   0.889 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 27     | Random     |    96.06 ns |   2.025 ns |   1.795 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 27     | Random     |    94.44 ns |   1.660 ns |   1.471 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 27     | Random     |    66.78 ns |   1.594 ns |   1.413 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Random     |    57.42 ns |   1.895 ns |   1.680 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 27     | Random     |   101.67 ns |   2.296 ns |   2.035 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 27     | Random     |   108.69 ns |   3.702 ns |   3.282 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 27     | Random     |   105.91 ns |   2.572 ns |   2.280 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 27     | Random     |    41.87 ns |   1.215 ns |   1.077 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 27     | Random     |    99.87 ns |   2.186 ns |   1.938 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 27     | Random     |   523.61 ns |   4.944 ns |   4.383 ns |  0.39 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 27     | Random     |    53.44 ns |   2.109 ns |   1.870 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 27     | Random     |    99.16 ns |   2.163 ns |   1.918 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 27     | Random     |    99.89 ns |   2.139 ns |   1.896 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Sorted**     |    **87.01 ns** |   **2.725 ns** |   **2.416 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Sorted     |    93.66 ns |   2.038 ns |   1.807 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Sorted     |    55.69 ns |   2.191 ns |   1.942 ns |  0.64 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Reversed**   |    **93.78 ns** |   **4.014 ns** |   **3.558 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Reversed   |   100.73 ns |   7.651 ns |   6.783 ns |  1.08 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Reversed   |    55.30 ns |   2.230 ns |   1.862 ns |  0.59 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Duplicates** |   **111.72 ns** |   **5.126 ns** |   **4.544 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Duplicates |   117.38 ns |   4.261 ns |   3.777 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Duplicates |    55.98 ns |   1.948 ns |   1.727 ns |  0.50 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **28**     | **Random**     | **1,516.34 ns** |  **57.100 ns** |  **50.617 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 28     | Random     |   128.64 ns |  10.421 ns |   9.238 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 28     | Random     | 1,970.49 ns | 140.925 ns | 124.927 ns |  1.30 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 28     | Random     | 1,798.27 ns | 198.711 ns | 185.875 ns |  1.19 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 28     | Random     |   134.66 ns |   3.781 ns |   3.352 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 28     | Random     | 1,692.44 ns |  38.914 ns |  34.496 ns |  1.12 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 28     | Random     | 1,645.07 ns |  94.538 ns |  83.805 ns |  1.09 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 28     | Random     | 1,694.78 ns |  88.348 ns |  78.318 ns |  1.12 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 28     | Random     | 1,706.73 ns |  88.946 ns |  78.848 ns |  1.13 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 28     | Random     | 1,628.00 ns |  74.720 ns |  66.237 ns |  1.07 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 28     | Random     | 1,178.36 ns | 154.418 ns | 136.888 ns |  0.78 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 28     | Random     |   138.35 ns |   4.891 ns |   4.336 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 28     | Random     |   169.69 ns |   4.299 ns |   3.811 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 28     | Random     | 1,513.92 ns |  81.639 ns |  72.371 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 28     | Random     | 1,539.95 ns |  34.512 ns |  28.819 ns |  1.02 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 28     | Random     |   133.04 ns |   5.266 ns |   4.668 ns |  0.09 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 28     | Random     | 1,732.10 ns | 143.628 ns | 134.350 ns |  1.14 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 28     | Random     | 1,846.49 ns | 124.601 ns | 110.456 ns |  1.22 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Random     |   142.32 ns |   2.458 ns |   2.179 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 28     | Random     | 1,689.59 ns |  41.126 ns |  36.457 ns |  1.12 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 28     | Random     | 1,714.09 ns |  64.837 ns |  57.476 ns |  1.13 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 28     | Random     | 1,670.87 ns |  50.518 ns |  44.783 ns |  1.10 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 28     | Random     | 1,656.74 ns |  95.464 ns |  74.532 ns |  1.09 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 28     | Random     | 1,594.20 ns | 130.354 ns | 115.555 ns |  1.05 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 28     | Random     | 1,168.59 ns | 110.106 ns |  97.606 ns |  0.77 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 28     | Random     |   141.29 ns |   2.929 ns |   2.596 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 28     | Random     |   166.84 ns |   2.905 ns |   2.426 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 28     | Random     | 1,501.44 ns | 105.572 ns |  93.587 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 28     | Random     |    38.28 ns |   0.969 ns |   0.809 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 28     | Random     |    99.08 ns |   2.210 ns |   1.846 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 28     | Random     |   104.45 ns |   5.630 ns |   4.991 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 28     | Random     |    66.63 ns |   1.879 ns |   1.569 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Random     |    55.21 ns |   2.389 ns |   2.118 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 28     | Random     |   106.55 ns |   2.338 ns |   2.073 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 28     | Random     |   110.65 ns |   2.585 ns |   2.292 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 28     | Random     |   110.00 ns |   2.566 ns |   2.275 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 28     | Random     |    42.81 ns |   1.981 ns |   1.756 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 28     | Random     |   102.98 ns |   2.682 ns |   2.239 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 28     | Random     |   550.77 ns |  13.891 ns |  12.314 ns |  0.36 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 28     | Random     |    52.61 ns |   2.113 ns |   1.873 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 28     | Random     |   103.94 ns |   2.264 ns |   2.007 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 28     | Random     |   103.31 ns |   2.213 ns |   1.961 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Sorted**     |    **90.50 ns** |   **3.133 ns** |   **2.777 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Sorted     |    91.23 ns |   4.623 ns |   4.098 ns |  1.01 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Sorted     |    55.62 ns |   3.340 ns |   2.961 ns |  0.62 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Reversed**   |   **108.48 ns** |   **2.767 ns** |   **2.453 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Reversed   |   110.56 ns |   3.392 ns |   3.007 ns |  1.02 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Reversed   |    55.54 ns |   2.083 ns |   1.846 ns |  0.51 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Duplicates** |   **112.17 ns** |   **4.564 ns** |   **4.046 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Duplicates |   119.68 ns |   4.983 ns |   4.417 ns |  1.07 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Duplicates |    54.94 ns |   1.956 ns |   1.734 ns |  0.49 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **29**     | **Random**     | **1,434.48 ns** |  **77.853 ns** |  **69.014 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 29     | Random     |   106.87 ns |   2.810 ns |   2.491 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 29     | Random     | 1,831.23 ns |  88.392 ns |  78.357 ns |  1.28 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 29     | Random     | 1,749.34 ns | 131.595 ns | 116.655 ns |  1.22 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 29     | Random     |   124.48 ns |   4.008 ns |   3.553 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 29     | Random     | 1,612.40 ns |  59.507 ns |  52.751 ns |  1.13 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 29     | Random     | 1,576.30 ns |  72.060 ns |  63.879 ns |  1.10 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 29     | Random     | 1,580.24 ns |  60.835 ns |  53.928 ns |  1.10 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 29     | Random     | 1,633.65 ns |  44.530 ns |  39.475 ns |  1.14 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 29     | Random     | 1,556.08 ns |  68.417 ns |  60.649 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 29     | Random     | 1,243.48 ns | 118.696 ns | 105.221 ns |  0.87 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 29     | Random     |   125.69 ns |   6.767 ns |   5.999 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 29     | Random     |   172.83 ns |   4.689 ns |   4.156 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 29     | Random     | 1,460.79 ns |  63.674 ns |  56.445 ns |  1.02 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 29     | Random     | 1,482.50 ns |  71.488 ns |  63.372 ns |  1.04 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 29     | Random     |   113.02 ns |   6.879 ns |   6.098 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 29     | Random     | 1,754.46 ns | 156.819 ns | 146.688 ns |  1.23 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 29     | Random     | 1,751.96 ns | 108.498 ns |  96.181 ns |  1.22 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Random     |   127.26 ns |   6.584 ns |   5.837 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 29     | Random     | 1,605.01 ns |  30.599 ns |  27.125 ns |  1.12 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 29     | Random     | 1,603.25 ns |  77.815 ns |  68.981 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 29     | Random     | 1,571.44 ns |  86.466 ns |  76.650 ns |  1.10 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 29     | Random     | 1,599.56 ns |  78.808 ns |  69.861 ns |  1.12 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 29     | Random     | 1,534.37 ns |  96.654 ns |  85.681 ns |  1.07 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 29     | Random     | 1,244.77 ns | 108.999 ns |  96.624 ns |  0.87 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 29     | Random     |   124.82 ns |   5.058 ns |   4.484 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 29     | Random     |   162.34 ns |   5.394 ns |   4.505 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 29     | Random     | 1,421.30 ns |  77.613 ns |  68.802 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 29     | Random     |    40.04 ns |   1.125 ns |   0.997 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 29     | Random     |   106.57 ns |   2.929 ns |   2.446 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 29     | Random     |   135.44 ns |   2.748 ns |   2.436 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 29     | Random     |    73.70 ns |   1.804 ns |   1.506 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Random     |    63.34 ns |   2.102 ns |   1.863 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 29     | Random     |   115.36 ns |   2.386 ns |   2.115 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 29     | Random     |   117.50 ns |   2.708 ns |   2.262 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 29     | Random     |   118.27 ns |   3.215 ns |   2.850 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 29     | Random     |    42.39 ns |   1.067 ns |   0.946 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 29     | Random     |   111.23 ns |   2.574 ns |   2.282 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 29     | Random     |   562.93 ns |   5.454 ns |   4.258 ns |  0.39 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 29     | Random     |    61.33 ns |   1.951 ns |   1.729 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 29     | Random     |   110.33 ns |   2.137 ns |   1.895 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 29     | Random     |   110.97 ns |   2.461 ns |   2.182 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Sorted**     |    **88.61 ns** |   **1.731 ns** |   **1.445 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Sorted     |    96.06 ns |   2.800 ns |   2.482 ns |  1.08 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Sorted     |    64.27 ns |   2.456 ns |   2.177 ns |  0.73 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Reversed**   |   **103.92 ns** |   **8.796 ns** |   **7.798 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Reversed   |   112.27 ns |   5.542 ns |   4.913 ns |  1.09 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Reversed   |    63.53 ns |   2.261 ns |   2.004 ns |  0.61 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Duplicates** |   **112.55 ns** |   **3.988 ns** |   **3.535 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Duplicates |   112.15 ns |   3.680 ns |   3.263 ns |  1.00 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Duplicates |    64.07 ns |   2.068 ns |   1.834 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **30**     | **Random**     | **1,474.57 ns** |  **89.127 ns** |  **79.009 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 30     | Random     |   118.05 ns |   3.999 ns |   3.545 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 30     | Random     | 1,773.94 ns | 150.299 ns | 133.237 ns |  1.21 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 30     | Random     | 1,710.72 ns | 173.308 ns | 162.112 ns |  1.16 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 30     | Random     |   119.86 ns |   4.937 ns |   4.376 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 30     | Random     | 1,583.62 ns | 104.531 ns |  92.664 ns |  1.08 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 30     | Random     | 1,608.20 ns |  37.165 ns |  32.946 ns |  1.09 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 30     | Random     | 1,604.81 ns |  39.553 ns |  35.062 ns |  1.09 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 30     | Random     | 1,629.08 ns | 118.251 ns | 104.826 ns |  1.11 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 30     | Random     | 1,571.58 ns |  79.114 ns |  70.133 ns |  1.07 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 30     | Random     | 1,340.91 ns | 126.477 ns | 112.119 ns |  0.91 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 30     | Random     |   120.15 ns |   4.391 ns |   3.893 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 30     | Random     |   145.96 ns |   4.705 ns |   4.171 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 30     | Random     | 1,524.54 ns |  34.401 ns |  30.496 ns |  1.04 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 30     | Random     | 1,486.02 ns | 134.782 ns | 112.549 ns |  1.01 |    0.09 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 30     | Random     |   121.89 ns |   3.364 ns |   2.982 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 30     | Random     | 1,750.35 ns | 193.085 ns | 180.612 ns |  1.19 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 30     | Random     | 1,798.16 ns | 144.066 ns | 127.710 ns |  1.22 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Random     |   122.08 ns |   3.776 ns |   3.347 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 30     | Random     | 1,617.93 ns |  45.351 ns |  40.202 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 30     | Random     | 1,643.95 ns |  69.166 ns |  61.314 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 30     | Random     | 1,635.81 ns |  34.112 ns |  30.240 ns |  1.11 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 30     | Random     | 1,622.44 ns | 117.670 ns | 104.311 ns |  1.10 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 30     | Random     | 1,614.93 ns |  45.561 ns |  40.389 ns |  1.10 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 30     | Random     | 1,311.28 ns | 170.483 ns | 151.129 ns |  0.89 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 30     | Random     |   117.03 ns |   4.507 ns |   3.995 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 30     | Random     |   142.56 ns |   4.114 ns |   3.647 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 30     | Random     | 1,441.77 ns | 108.304 ns |  96.008 ns |  0.98 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 30     | Random     |    42.56 ns |   1.204 ns |   1.067 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 30     | Random     |   109.52 ns |   3.096 ns |   2.586 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 30     | Random     |   124.37 ns |   1.504 ns |   1.256 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 30     | Random     |    72.20 ns |   1.895 ns |   1.583 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Random     |    63.97 ns |   2.377 ns |   2.107 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 30     | Random     |   119.11 ns |   2.681 ns |   2.093 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 30     | Random     |   122.31 ns |   2.540 ns |   2.121 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 30     | Random     |   122.62 ns |   2.299 ns |   2.038 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 30     | Random     |    45.39 ns |   1.124 ns |   0.997 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.56 ns |   2.450 ns |   2.046 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 30     | Random     |   591.28 ns |   8.901 ns |   7.891 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 30     | Random     |    60.58 ns |   2.123 ns |   1.882 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.27 ns |   2.339 ns |   2.073 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 30     | Random     |   114.96 ns |   2.304 ns |   2.042 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Sorted**     |    **89.11 ns** |   **4.295 ns** |   **3.808 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Sorted     |    94.72 ns |  10.163 ns |   9.009 ns |  1.06 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Sorted     |    63.12 ns |   2.130 ns |   1.888 ns |  0.71 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Reversed**   |   **110.84 ns** |   **3.189 ns** |   **2.827 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Reversed   |   117.41 ns |   6.626 ns |   5.874 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Reversed   |    63.26 ns |   2.113 ns |   1.873 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Duplicates** |   **116.28 ns** |   **3.865 ns** |   **3.228 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Duplicates |   121.62 ns |   2.498 ns |   2.214 ns |  1.05 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Duplicates |    63.04 ns |   2.318 ns |   1.935 ns |  0.54 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **31**     | **Random**     | **1,637.48 ns** |  **92.317 ns** |  **81.837 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 31     | Random     |   129.47 ns |   2.495 ns |   2.212 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 31     | Random     | 1,996.70 ns | 125.915 ns | 111.621 ns |  1.22 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 31     | Random     | 1,911.93 ns | 163.667 ns | 153.094 ns |  1.17 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 31     | Random     |   145.86 ns |   4.476 ns |   3.968 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 31     | Random     | 1,811.49 ns |  68.844 ns |  61.028 ns |  1.11 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 31     | Random     | 1,837.48 ns |  37.444 ns |  33.193 ns |  1.12 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 31     | Random     | 1,815.89 ns |  41.918 ns |  37.159 ns |  1.11 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 31     | Random     | 1,812.46 ns |  78.832 ns |  69.883 ns |  1.11 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 31     | Random     | 1,785.37 ns | 119.623 ns | 106.043 ns |  1.09 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 31     | Random     | 1,403.07 ns | 126.997 ns | 106.048 ns |  0.86 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 31     | Random     |   139.51 ns |   7.008 ns |   6.212 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 31     | Random     |   196.06 ns |   4.878 ns |   4.324 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 31     | Random     | 1,695.87 ns |  55.845 ns |  49.505 ns |  1.04 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 31     | Random     | 1,716.21 ns |  19.145 ns |  14.947 ns |  1.05 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 31     | Random     |   132.06 ns |   2.929 ns |   2.596 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 31     | Random     | 1,954.16 ns | 158.443 ns | 140.455 ns |  1.20 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 31     | Random     | 2,100.04 ns | 116.593 ns | 103.357 ns |  1.29 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Random     |   144.66 ns |   7.602 ns |   6.739 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 31     | Random     | 1,807.58 ns | 102.850 ns |  85.884 ns |  1.11 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 31     | Random     | 1,823.24 ns | 109.246 ns |  96.844 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 31     | Random     | 1,768.33 ns | 120.713 ns |  94.245 ns |  1.08 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 31     | Random     | 1,772.33 ns | 113.630 ns | 100.730 ns |  1.08 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 31     | Random     | 1,778.88 ns |  73.922 ns |  65.530 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 31     | Random     | 1,420.94 ns | 113.968 ns | 101.030 ns |  0.87 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 31     | Random     |   135.58 ns |   7.331 ns |   6.498 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 31     | Random     |   193.24 ns |   3.782 ns |   3.353 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 31     | Random     | 1,635.50 ns | 115.727 ns | 102.589 ns |  1.00 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 31     | Random     |    40.92 ns |   1.198 ns |   1.062 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 31     | Random     |   109.06 ns |   2.084 ns |   1.847 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 31     | Random     |   133.42 ns |   2.488 ns |   2.078 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 31     | Random     |    70.68 ns |   2.735 ns |   2.284 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Random     |    59.58 ns |   2.758 ns |   2.303 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 31     | Random     |   118.36 ns |   2.906 ns |   2.576 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 31     | Random     |   122.53 ns |   2.373 ns |   2.103 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 31     | Random     |   122.52 ns |   2.413 ns |   2.139 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 31     | Random     |    42.25 ns |   1.123 ns |   0.996 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 31     | Random     |   115.97 ns |   2.852 ns |   2.528 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 31     | Random     |   611.51 ns |   9.737 ns |   8.131 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 31     | Random     |    56.44 ns |   2.555 ns |   2.265 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 31     | Random     |   117.26 ns |   2.416 ns |   2.142 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 31     | Random     |   115.39 ns |   2.374 ns |   2.105 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Sorted**     |    **87.49 ns** |   **4.121 ns** |   **3.653 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Sorted     |   100.16 ns |   3.191 ns |   2.829 ns |  1.15 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Sorted     |    59.15 ns |   2.431 ns |   2.155 ns |  0.68 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Reversed**   |   **113.21 ns** |   **4.565 ns** |   **3.564 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Reversed   |   120.72 ns |   7.900 ns |   6.597 ns |  1.07 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Reversed   |    61.76 ns |   2.280 ns |   2.021 ns |  0.55 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Duplicates** |   **126.95 ns** |   **2.911 ns** |   **2.581 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Duplicates |   132.76 ns |   3.458 ns |   3.066 ns |  1.05 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Duplicates |    59.58 ns |   3.125 ns |   2.610 ns |  0.47 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **32**     | **Random**     | **1,729.81 ns** |  **59.485 ns** |  **52.732 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 32     | Random     |   130.29 ns |   8.086 ns |   7.168 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 32     | Random     | 2,097.97 ns | 139.694 ns | 123.835 ns |  1.21 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 32     | Random     | 1,989.97 ns | 164.512 ns | 153.885 ns |  1.15 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 32     | Random     |   157.76 ns |  10.068 ns |   8.925 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 32     | Random     | 1,875.55 ns |  52.552 ns |  46.586 ns |  1.09 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 32     | Random     | 2,045.98 ns |  53.027 ns |  47.007 ns |  1.18 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 32     | Random     | 1,826.67 ns | 107.970 ns |  95.713 ns |  1.06 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 32     | Random     | 1,905.15 ns |  51.951 ns |  46.054 ns |  1.10 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 32     | Random     | 1,851.78 ns | 118.105 ns | 104.697 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 32     | Random     | 1,341.23 ns | 175.879 ns | 164.517 ns |  0.78 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 32     | Random     |   149.43 ns |   4.734 ns |   3.953 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 32     | Random     |   206.61 ns |  35.983 ns |  31.898 ns |  0.12 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 32     | Random     | 1,699.35 ns | 118.283 ns | 104.855 ns |  0.98 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 32     | Random     | 1,738.51 ns | 119.337 ns | 105.789 ns |  1.01 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 32     | Random     |   135.73 ns |   3.489 ns |   3.093 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 32     | Random     | 2,001.40 ns | 189.276 ns | 177.049 ns |  1.16 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 32     | Random     | 2,058.21 ns | 150.619 ns | 133.520 ns |  1.19 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Random     |   164.82 ns |   7.273 ns |   6.073 ns |  0.10 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 32     | Random     | 1,811.32 ns | 134.072 ns | 118.851 ns |  1.05 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 32     | Random     | 1,921.34 ns |  41.107 ns |  36.440 ns |  1.11 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 32     | Random     | 1,882.54 ns |  41.546 ns |  36.829 ns |  1.09 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 32     | Random     | 1,876.58 ns | 136.732 ns | 121.209 ns |  1.09 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 32     | Random     | 1,807.11 ns | 134.562 ns | 119.286 ns |  1.05 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 32     | Random     | 1,282.10 ns | 198.985 ns | 176.395 ns |  0.74 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 32     | Random     |   144.89 ns |   5.356 ns |   4.748 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 32     | Random     |   215.34 ns |  13.909 ns |  12.330 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 32     | Random     | 1,691.46 ns |  58.622 ns |  51.967 ns |  0.98 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 32     | Random     |    38.78 ns |   1.043 ns |   0.925 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 32     | Random     |   113.72 ns |   1.730 ns |   1.445 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 32     | Random     |   128.87 ns |   3.596 ns |   2.808 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 32     | Random     |    68.91 ns |   1.688 ns |   1.409 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Random     |    63.16 ns |   4.231 ns |   3.751 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 32     | Random     |   124.84 ns |   2.515 ns |   2.230 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 32     | Random     |   128.53 ns |   2.423 ns |   2.148 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 32     | Random     |   129.24 ns |   2.967 ns |   2.630 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 32     | Random     |    41.14 ns |   1.028 ns |   0.911 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 32     | Random     |   121.76 ns |   2.311 ns |   2.049 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 32     | Random     |   626.35 ns |  12.773 ns |  11.323 ns |  0.36 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 32     | Random     |    55.41 ns |   2.334 ns |   2.069 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 32     | Random     |   122.51 ns |   2.591 ns |   2.164 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 32     | Random     |   122.30 ns |   2.614 ns |   2.317 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Sorted**     |    **93.01 ns** |   **2.704 ns** |   **2.397 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Sorted     |    99.97 ns |   2.119 ns |   1.879 ns |  1.08 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Sorted     |    58.03 ns |   2.409 ns |   2.136 ns |  0.62 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Reversed**   |   **118.08 ns** |   **9.725 ns** |   **8.121 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Reversed   |   125.44 ns |   4.083 ns |   3.619 ns |  1.07 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Reversed   |    57.75 ns |   2.393 ns |   2.121 ns |  0.49 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Duplicates** |   **125.25 ns** |   **3.992 ns** |   **3.539 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Duplicates |   129.90 ns |   3.921 ns |   3.476 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Duplicates |    58.82 ns |   2.643 ns |   2.207 ns |  0.47 |    0.02 |         - |          NA |

