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
| **CharSortingBenchmarks**   | **ArraySort**     | **8**      | **Random**     |    **29.29 ns** |   **2.307 ns** |   **2.045 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 8      | Random     |   304.68 ns |   9.743 ns |   8.637 ns | 10.45 |    0.77 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 8      | Random     |   276.84 ns |   9.466 ns |   8.391 ns |  9.49 |    0.70 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 8      | Random     |    32.35 ns |   2.073 ns |   1.838 ns |  1.11 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 8      | Random     |   305.38 ns |   9.247 ns |   8.198 ns | 10.47 |    0.76 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 8      | Random     |   272.29 ns |   9.586 ns |   8.498 ns |  9.34 |    0.69 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 8      | Random     |    20.66 ns |   0.830 ns |   0.736 ns |  0.71 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 8      | Random     |    23.72 ns |   0.912 ns |   0.809 ns |  0.81 |    0.06 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 8      | Random     |    23.66 ns |   0.866 ns |   0.767 ns |  0.81 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **16**     | **Random**     |    **68.99 ns** |   **2.431 ns** |   **2.155 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 16     | Random     |   956.02 ns |  24.099 ns |  21.363 ns | 13.87 |    0.52 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 16     | Random     |   817.02 ns |   9.754 ns |   8.145 ns | 11.85 |    0.38 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 16     | Random     |    73.13 ns |   3.110 ns |   2.757 ns |  1.06 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 16     | Random     |   920.31 ns |  24.408 ns |  20.382 ns | 13.35 |    0.50 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 16     | Random     |   807.15 ns |   7.267 ns |   6.068 ns | 11.71 |    0.37 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 16     | Random     |    30.74 ns |   1.078 ns |   0.956 ns |  0.45 |    0.02 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 16     | Random     |    33.21 ns |   1.062 ns |   0.942 ns |  0.48 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 16     | Random     |    33.32 ns |   1.145 ns |   1.015 ns |  0.48 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **23**     | **Random**     | **1,120.57 ns** |  **49.920 ns** |  **44.253 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 23     | Random     |    76.26 ns |   2.736 ns |   2.426 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 23     | Random     | 1,359.81 ns |  77.883 ns |  69.041 ns |  1.22 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 23     | Random     | 1,325.99 ns | 123.757 ns | 109.708 ns |  1.19 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 23     | Random     |    92.14 ns |   5.025 ns |   4.454 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 23     | Random     | 1,197.61 ns |  71.034 ns |  62.970 ns |  1.07 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 23     | Random     | 1,211.92 ns |  29.514 ns |  26.164 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 23     | Random     | 1,211.26 ns |  49.630 ns |  43.996 ns |  1.08 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 23     | Random     | 1,256.48 ns |  32.667 ns |  27.278 ns |  1.12 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 23     | Random     | 1,198.34 ns |  62.004 ns |  54.965 ns |  1.07 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 23     | Random     |   968.94 ns | 116.189 ns | 102.999 ns |  0.87 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 23     | Random     |    98.57 ns |   3.354 ns |   2.973 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 23     | Random     |   116.79 ns |   3.130 ns |   2.775 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 23     | Random     | 1,123.50 ns |  21.114 ns |  18.717 ns |  1.00 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 23     | Random     | 1,120.96 ns |  54.670 ns |  48.464 ns |  1.00 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 23     | Random     |    80.41 ns |   1.838 ns |   1.630 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 23     | Random     | 1,306.15 ns | 107.259 ns |  95.082 ns |  1.17 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 23     | Random     | 1,384.91 ns |  71.748 ns |  63.603 ns |  1.24 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Random     |   100.96 ns |   4.895 ns |   4.340 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 23     | Random     | 1,200.97 ns |  66.803 ns |  59.219 ns |  1.07 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 23     | Random     | 1,212.59 ns |  63.198 ns |  56.023 ns |  1.08 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 23     | Random     | 1,200.38 ns |  49.808 ns |  44.154 ns |  1.07 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 23     | Random     | 1,250.12 ns |  34.456 ns |  30.545 ns |  1.12 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 23     | Random     | 1,194.19 ns |  56.189 ns |  49.810 ns |  1.07 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 23     | Random     |   955.44 ns | 104.352 ns |  92.505 ns |  0.85 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 23     | Random     |    94.27 ns |   4.658 ns |   4.129 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 23     | Random     |   111.42 ns |  12.219 ns |  10.832 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 23     | Random     | 1,095.72 ns |  49.484 ns |  43.866 ns |  0.98 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 23     | Random     |    35.68 ns |   0.974 ns |   0.813 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 23     | Random     |    81.79 ns |   1.899 ns |   1.683 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 23     | Random     |    88.10 ns |   5.766 ns |   5.111 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 23     | Random     |    60.23 ns |   2.535 ns |   2.247 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Random     |    49.29 ns |   2.239 ns |   1.985 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 23     | Random     |    88.87 ns |   1.920 ns |   1.702 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    93.62 ns |   2.585 ns |   2.292 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 23     | Random     |    93.64 ns |   2.515 ns |   2.230 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 23     | Random     |    38.89 ns |   1.018 ns |   0.902 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 23     | Random     |    87.44 ns |   2.429 ns |   2.153 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 23     | Random     |   387.12 ns |   3.003 ns |   2.662 ns |  0.35 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    48.59 ns |   1.774 ns |   1.572 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 23     | Random     |    86.34 ns |   2.856 ns |   2.532 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 23     | Random     |    86.97 ns |   2.124 ns |   1.883 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Sorted**     |    **62.47 ns** |   **2.397 ns** |   **2.125 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Sorted     |    66.02 ns |   2.906 ns |   2.576 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Sorted     |    48.74 ns |   1.827 ns |   1.620 ns |  0.78 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Reversed**   |    **86.19 ns** |   **3.492 ns** |   **3.096 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Reversed   |    93.53 ns |   3.770 ns |   3.342 ns |  1.09 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Reversed   |    50.38 ns |   1.930 ns |   1.612 ns |  0.59 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Duplicates** |    **88.76 ns** |   **2.716 ns** |   **2.407 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Duplicates |    94.18 ns |   6.899 ns |   6.116 ns |  1.06 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Duplicates |    48.25 ns |   2.318 ns |   1.936 ns |  0.54 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **24**     | **Random**     | **1,238.90 ns** |  **71.057 ns** |  **62.991 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 24     | Random     |   127.34 ns |   3.091 ns |   2.740 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 24     | Random     | 1,498.01 ns | 122.320 ns | 108.434 ns |  1.21 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 24     | Random     | 1,446.76 ns | 121.252 ns | 107.487 ns |  1.17 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 24     | Random     |   107.29 ns |   4.732 ns |   3.951 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 24     | Random     | 1,330.03 ns |  66.971 ns |  59.368 ns |  1.08 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 24     | Random     | 1,365.20 ns |  51.578 ns |  45.722 ns |  1.10 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 24     | Random     | 1,362.98 ns |  33.873 ns |  30.027 ns |  1.10 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 24     | Random     | 1,386.01 ns |  87.995 ns |  78.005 ns |  1.12 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 24     | Random     | 1,345.74 ns |  34.892 ns |  30.930 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 24     | Random     | 1,085.71 ns |  71.029 ns |  62.965 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 24     | Random     |   111.72 ns |   2.844 ns |   2.521 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 24     | Random     |   127.78 ns |   3.208 ns |   2.679 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 24     | Random     | 1,239.81 ns |  56.872 ns |  47.491 ns |  1.00 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 24     | Random     | 1,261.13 ns |  42.004 ns |  37.236 ns |  1.02 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 24     | Random     |   125.79 ns |   1.283 ns |   1.137 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 24     | Random     | 1,444.39 ns | 168.574 ns | 157.684 ns |  1.17 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 24     | Random     | 1,503.06 ns |  96.653 ns |  85.680 ns |  1.22 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Random     |   114.36 ns |   4.123 ns |   3.655 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 24     | Random     | 1,348.67 ns |  79.469 ns |  70.447 ns |  1.09 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 24     | Random     | 1,321.43 ns |  66.630 ns |  55.639 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 24     | Random     | 1,402.90 ns |  31.316 ns |  26.150 ns |  1.14 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 24     | Random     | 1,366.25 ns |  91.673 ns |  81.266 ns |  1.11 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 24     | Random     | 1,338.04 ns |  34.700 ns |  30.760 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 24     | Random     | 1,068.60 ns | 101.546 ns |  90.018 ns |  0.86 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 24     | Random     |   109.50 ns |   2.348 ns |   1.961 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 24     | Random     |   130.34 ns |   3.932 ns |   3.485 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 24     | Random     | 1,256.26 ns |  33.996 ns |  30.136 ns |  1.02 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 24     | Random     |    38.43 ns |   1.122 ns |   0.876 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 24     | Random     |    79.00 ns |   1.834 ns |   1.531 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 24     | Random     |    98.64 ns |   1.581 ns |   1.401 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 24     | Random     |    63.26 ns |   1.986 ns |   1.760 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Random     |    52.19 ns |   2.448 ns |   2.170 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 24     | Random     |    88.33 ns |   2.253 ns |   1.997 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    92.01 ns |   2.549 ns |   2.128 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 24     | Random     |    92.48 ns |   2.720 ns |   2.411 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 24     | Random     |    41.52 ns |   1.118 ns |   0.991 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 24     | Random     |    85.51 ns |   2.342 ns |   2.076 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 24     | Random     |   417.06 ns |   3.364 ns |   2.982 ns |  0.34 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    49.28 ns |   2.804 ns |   2.342 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 24     | Random     |    84.36 ns |   2.534 ns |   2.246 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 24     | Random     |    84.56 ns |   2.125 ns |   1.884 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Sorted**     |    **70.50 ns** |   **2.152 ns** |   **1.907 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Sorted     |    77.62 ns |   5.746 ns |   5.094 ns |  1.10 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Sorted     |    52.25 ns |   2.828 ns |   2.361 ns |  0.74 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Reversed**   |    **90.64 ns** |   **2.492 ns** |   **2.209 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Reversed   |    98.95 ns |   2.703 ns |   2.257 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Reversed   |    52.06 ns |   1.742 ns |   1.545 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Duplicates** |    **93.51 ns** |   **3.319 ns** |   **2.942 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Duplicates |    98.19 ns |   3.138 ns |   2.782 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Duplicates |    52.00 ns |   1.929 ns |   1.710 ns |  0.56 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **25**     | **Random**     | **1,175.59 ns** |  **80.126 ns** |  **71.029 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 25     | Random     |   120.19 ns |   2.313 ns |   2.050 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 25     | Random     | 1,403.88 ns | 128.739 ns | 114.124 ns |  1.20 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 25     | Random     | 1,350.95 ns | 143.808 ns | 134.518 ns |  1.15 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 25     | Random     |   104.26 ns |   4.366 ns |   3.646 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 25     | Random     | 1,250.39 ns |  74.030 ns |  65.626 ns |  1.07 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 25     | Random     | 1,267.10 ns |  40.887 ns |  36.246 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 25     | Random     | 1,245.61 ns |  78.766 ns |  69.824 ns |  1.06 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 25     | Random     | 1,289.48 ns |  72.018 ns |  63.842 ns |  1.10 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 25     | Random     | 1,232.97 ns |  73.226 ns |  64.913 ns |  1.05 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 25     | Random     |   881.93 ns |  71.412 ns |  63.305 ns |  0.75 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 25     | Random     |   111.01 ns |   2.904 ns |   2.575 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 25     | Random     |   120.96 ns |   5.755 ns |   5.101 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 25     | Random     | 1,175.30 ns |  76.663 ns |  67.960 ns |  1.00 |    0.09 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 25     | Random     | 1,192.98 ns |  39.566 ns |  35.075 ns |  1.02 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 25     | Random     |   121.18 ns |   2.300 ns |   1.921 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 25     | Random     | 1,345.50 ns | 156.595 ns | 146.479 ns |  1.15 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 25     | Random     | 1,372.78 ns | 128.075 ns | 113.535 ns |  1.17 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Random     |   108.95 ns |   4.068 ns |   3.607 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 25     | Random     | 1,238.96 ns | 120.408 ns | 106.738 ns |  1.06 |    0.11 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 25     | Random     | 1,259.81 ns |  76.014 ns |  67.385 ns |  1.08 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 25     | Random     | 1,256.48 ns |  65.045 ns |  57.661 ns |  1.07 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 25     | Random     | 1,294.44 ns |  54.782 ns |  48.563 ns |  1.11 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 25     | Random     | 1,242.01 ns |  81.956 ns |  72.651 ns |  1.06 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 25     | Random     |   999.73 ns |  74.142 ns |  65.725 ns |  0.85 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 25     | Random     |   108.86 ns |   2.352 ns |   2.085 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 25     | Random     |   127.64 ns |   3.381 ns |   2.998 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 25     | Random     | 1,161.34 ns |  37.118 ns |  32.904 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 25     | Random     |    38.96 ns |   1.439 ns |   1.202 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 25     | Random     |    88.94 ns |   2.059 ns |   1.825 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 25     | Random     |   106.63 ns |   1.260 ns |   1.117 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 25     | Random     |    68.08 ns |   1.899 ns |   1.683 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Random     |    55.43 ns |   2.263 ns |   2.006 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 25     | Random     |    95.94 ns |   2.279 ns |   1.903 ns |  0.08 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 25     | Random     |   100.70 ns |   3.047 ns |   2.545 ns |  0.09 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 25     | Random     |   100.78 ns |   2.488 ns |   2.078 ns |  0.09 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 25     | Random     |    41.07 ns |   0.926 ns |   0.821 ns |  0.04 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 25     | Random     |    93.88 ns |   2.156 ns |   1.911 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 25     | Random     |   441.75 ns |   3.108 ns |   2.596 ns |  0.38 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 25     | Random     |    54.55 ns |   1.830 ns |   1.622 ns |  0.05 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 25     | Random     |    92.84 ns |   2.381 ns |   2.111 ns |  0.08 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 25     | Random     |    94.01 ns |   2.247 ns |   1.992 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Sorted**     |    **78.70 ns** |   **3.243 ns** |   **2.875 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Sorted     |    86.05 ns |   2.707 ns |   2.399 ns |  1.09 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Sorted     |    55.14 ns |   2.156 ns |   1.801 ns |  0.70 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Reversed**   |    **90.66 ns** |   **3.524 ns** |   **3.124 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Reversed   |    95.70 ns |   3.340 ns |   2.961 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Reversed   |    59.35 ns |   3.227 ns |   2.861 ns |  0.66 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Duplicates** |    **98.74 ns** |   **3.939 ns** |   **3.492 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Duplicates |   103.92 ns |   8.971 ns |   7.952 ns |  1.05 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Duplicates |    58.04 ns |   1.889 ns |   1.675 ns |  0.59 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **26**     | **Random**     | **1,404.94 ns** |  **73.259 ns** |  **64.942 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 26     | Random     |   121.70 ns |   1.981 ns |   1.756 ns |  0.09 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 26     | Random     | 1,677.78 ns |  82.568 ns |  73.194 ns |  1.20 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 26     | Random     | 1,637.58 ns | 123.622 ns | 109.587 ns |  1.17 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 26     | Random     |   121.28 ns |   6.269 ns |   5.235 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 26     | Random     | 1,493.42 ns |  33.737 ns |  29.907 ns |  1.07 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 26     | Random     | 1,458.56 ns |  69.570 ns |  54.316 ns |  1.04 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 26     | Random     | 1,477.05 ns |  44.763 ns |  39.681 ns |  1.05 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 26     | Random     | 1,535.96 ns |  32.233 ns |  28.574 ns |  1.10 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 26     | Random     | 1,462.29 ns |  50.541 ns |  44.803 ns |  1.04 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 26     | Random     |   997.85 ns |  84.263 ns |  74.697 ns |  0.71 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 26     | Random     |   125.75 ns |   4.140 ns |   3.457 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 26     | Random     |   158.25 ns |   4.511 ns |   3.999 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 26     | Random     | 1,417.18 ns |  37.070 ns |  32.862 ns |  1.01 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 26     | Random     | 1,430.31 ns |  46.112 ns |  40.877 ns |  1.02 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 26     | Random     |   122.07 ns |   1.520 ns |   1.269 ns |  0.09 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 26     | Random     | 1,578.07 ns | 144.904 ns | 128.453 ns |  1.13 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 26     | Random     | 1,672.04 ns | 122.654 ns | 102.422 ns |  1.19 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Random     |   123.63 ns |   3.727 ns |   3.304 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 26     | Random     | 1,486.71 ns |  70.054 ns |  62.101 ns |  1.06 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 26     | Random     | 1,528.26 ns |  44.223 ns |  39.203 ns |  1.09 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 26     | Random     | 1,486.36 ns |  62.465 ns |  55.374 ns |  1.06 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 26     | Random     | 1,576.24 ns |  40.144 ns |  35.586 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 26     | Random     | 1,442.89 ns | 106.062 ns |  94.021 ns |  1.03 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 26     | Random     | 1,101.18 ns | 114.167 ns | 101.206 ns |  0.79 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 26     | Random     |   121.69 ns |   4.788 ns |   4.244 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 26     | Random     |   143.27 ns |   8.423 ns |   7.467 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 26     | Random     | 1,347.40 ns |  75.873 ns |  63.357 ns |  0.96 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 26     | Random     |    41.69 ns |   1.141 ns |   1.011 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 26     | Random     |    91.60 ns |   2.029 ns |   1.798 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 26     | Random     |   119.17 ns |   4.715 ns |   4.179 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 26     | Random     |    72.36 ns |   1.621 ns |   1.437 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Random     |    59.14 ns |   1.913 ns |   1.696 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 26     | Random     |    99.10 ns |   3.423 ns |   2.858 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 26     | Random     |   101.94 ns |   2.313 ns |   1.932 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 26     | Random     |   102.25 ns |   2.433 ns |   2.031 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 26     | Random     |    44.06 ns |   1.083 ns |   0.960 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 26     | Random     |    95.27 ns |   2.218 ns |   1.966 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 26     | Random     |   475.62 ns |   3.577 ns |   3.171 ns |  0.34 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 26     | Random     |    57.04 ns |   2.529 ns |   2.112 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 26     | Random     |    95.34 ns |   2.601 ns |   2.172 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 26     | Random     |    96.11 ns |   2.445 ns |   2.168 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Sorted**     |    **79.48 ns** |   **8.218 ns** |   **6.862 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Sorted     |    88.11 ns |   2.476 ns |   2.195 ns |  1.12 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Sorted     |    59.60 ns |   2.079 ns |   1.843 ns |  0.76 |    0.08 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Reversed**   |    **98.58 ns** |   **2.293 ns** |   **1.790 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Reversed   |   106.89 ns |   4.282 ns |   3.576 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Reversed   |    59.84 ns |   2.355 ns |   2.088 ns |  0.61 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Duplicates** |    **94.04 ns** |   **2.966 ns** |   **2.629 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Duplicates |    99.29 ns |   3.316 ns |   2.769 ns |  1.06 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Duplicates |    57.22 ns |   2.161 ns |   1.916 ns |  0.61 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **27**     | **Random**     | **1,346.71 ns** |  **39.837 ns** |  **35.315 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 27     | Random     |    97.18 ns |   3.629 ns |   3.217 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 27     | Random     | 1,702.14 ns |  81.656 ns |  72.386 ns |  1.26 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 27     | Random     | 1,647.68 ns |  82.876 ns |  73.467 ns |  1.22 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 27     | Random     |   109.84 ns |   6.005 ns |   5.323 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 27     | Random     | 1,509.85 ns |  49.655 ns |  44.018 ns |  1.12 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 27     | Random     | 1,443.15 ns |  27.363 ns |  24.256 ns |  1.07 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 27     | Random     | 1,450.16 ns |  35.658 ns |  31.610 ns |  1.08 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 27     | Random     | 1,455.56 ns |  64.566 ns |  57.236 ns |  1.08 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 27     | Random     | 1,441.82 ns |  34.902 ns |  30.940 ns |  1.07 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 27     | Random     | 1,122.96 ns |  90.533 ns |  80.255 ns |  0.83 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 27     | Random     |   112.02 ns |   4.159 ns |   3.473 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 27     | Random     |   151.26 ns |  14.724 ns |  12.295 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 27     | Random     | 1,307.43 ns |  65.443 ns |  58.013 ns |  0.97 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 27     | Random     | 1,346.10 ns |  40.290 ns |  35.716 ns |  1.00 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 27     | Random     |    99.41 ns |   2.028 ns |   1.798 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 27     | Random     | 1,623.97 ns | 143.679 ns | 127.368 ns |  1.21 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 27     | Random     | 1,548.21 ns |  81.306 ns |  72.076 ns |  1.15 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Random     |   115.53 ns |   5.155 ns |   4.305 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 27     | Random     | 1,461.39 ns |  56.263 ns |  49.876 ns |  1.09 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 27     | Random     | 1,461.91 ns |  67.490 ns |  59.829 ns |  1.09 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 27     | Random     | 1,476.14 ns |  28.926 ns |  25.642 ns |  1.10 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 27     | Random     | 1,483.14 ns |  31.377 ns |  27.815 ns |  1.10 |    0.03 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 27     | Random     | 1,521.41 ns |  30.681 ns |  27.198 ns |  1.13 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 27     | Random     | 1,098.54 ns |  94.223 ns |  83.527 ns |  0.82 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 27     | Random     |   112.55 ns |   4.195 ns |   3.719 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 27     | Random     |   154.35 ns |   3.377 ns |   2.994 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 27     | Random     | 1,276.04 ns |  69.491 ns |  61.602 ns |  0.95 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 27     | Random     |    39.12 ns |   1.037 ns |   0.919 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 27     | Random     |    96.55 ns |   2.572 ns |   2.148 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 27     | Random     |    93.60 ns |   1.997 ns |   1.771 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 27     | Random     |    67.37 ns |   1.649 ns |   1.462 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Random     |    56.08 ns |   2.522 ns |   1.969 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 27     | Random     |   102.01 ns |   2.356 ns |   1.967 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 27     | Random     |   107.06 ns |   2.649 ns |   2.212 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 27     | Random     |   107.76 ns |   3.201 ns |   2.838 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 27     | Random     |    40.51 ns |   1.051 ns |   0.931 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 27     | Random     |   100.59 ns |   2.189 ns |   1.940 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 27     | Random     |   534.02 ns |   8.838 ns |   7.834 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 27     | Random     |    54.38 ns |   2.280 ns |   2.021 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 27     | Random     |    98.95 ns |   1.991 ns |   1.765 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 27     | Random     |    99.97 ns |   2.361 ns |   2.093 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Sorted**     |    **88.57 ns** |   **2.972 ns** |   **2.635 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Sorted     |    94.96 ns |   2.976 ns |   2.638 ns |  1.07 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Sorted     |    56.44 ns |   2.372 ns |   2.103 ns |  0.64 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Reversed**   |    **95.38 ns** |   **4.205 ns** |   **3.728 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Reversed   |   101.86 ns |   9.304 ns |   7.770 ns |  1.07 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Reversed   |    58.43 ns |   2.251 ns |   1.996 ns |  0.61 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Duplicates** |   **112.20 ns** |   **5.011 ns** |   **4.442 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Duplicates |   117.28 ns |   4.941 ns |   4.380 ns |  1.05 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Duplicates |    57.05 ns |   3.231 ns |   2.698 ns |  0.51 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **28**     | **Random**     | **1,518.93 ns** |  **63.759 ns** |  **56.521 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 28     | Random     |   136.74 ns |  13.374 ns |  11.856 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 28     | Random     | 1,896.46 ns |  88.213 ns |  78.198 ns |  1.25 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 28     | Random     | 1,745.39 ns | 170.850 ns | 159.814 ns |  1.15 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 28     | Random     |   134.02 ns |   3.568 ns |   2.980 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 28     | Random     | 1,650.23 ns |  72.901 ns |  64.625 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 28     | Random     | 1,657.33 ns |  53.318 ns |  47.265 ns |  1.09 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 28     | Random     | 1,644.87 ns |  50.867 ns |  45.092 ns |  1.08 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 28     | Random     | 1,701.26 ns |  52.684 ns |  46.703 ns |  1.12 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 28     | Random     | 1,678.24 ns |  43.690 ns |  38.730 ns |  1.11 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 28     | Random     | 1,196.94 ns | 112.739 ns |  99.940 ns |  0.79 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 28     | Random     |   134.36 ns |   1.908 ns |   1.490 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 28     | Random     |   170.42 ns |   4.331 ns |   3.839 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 28     | Random     | 1,524.50 ns |  90.435 ns |  80.169 ns |  1.01 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 28     | Random     | 1,555.56 ns |  97.158 ns |  86.128 ns |  1.03 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 28     | Random     |   137.06 ns |   1.678 ns |   1.487 ns |  0.09 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 28     | Random     | 1,767.53 ns | 191.019 ns | 178.679 ns |  1.17 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 28     | Random     | 1,849.70 ns | 122.715 ns | 108.784 ns |  1.22 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Random     |   140.11 ns |   4.733 ns |   4.195 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 28     | Random     | 1,671.38 ns |  43.991 ns |  38.997 ns |  1.10 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 28     | Random     | 1,634.32 ns | 101.274 ns |  84.569 ns |  1.08 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 28     | Random     | 1,670.75 ns |  99.292 ns |  88.020 ns |  1.10 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 28     | Random     | 1,691.11 ns |  61.297 ns |  54.338 ns |  1.11 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 28     | Random     | 1,615.46 ns | 115.344 ns | 102.250 ns |  1.06 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 28     | Random     | 1,196.41 ns | 148.534 ns | 131.672 ns |  0.79 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 28     | Random     |   140.74 ns |   5.801 ns |   5.143 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 28     | Random     |   168.51 ns |  14.811 ns |  13.129 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 28     | Random     | 1,527.32 ns |  66.310 ns |  58.782 ns |  1.01 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 28     | Random     |    39.56 ns |   1.494 ns |   1.324 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 28     | Random     |    99.59 ns |   2.328 ns |   2.064 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 28     | Random     |    96.48 ns |   6.544 ns |   5.465 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 28     | Random     |    67.41 ns |   3.048 ns |   2.702 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Random     |    56.63 ns |   2.764 ns |   2.451 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 28     | Random     |   107.39 ns |   2.050 ns |   1.712 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 28     | Random     |   111.38 ns |   2.968 ns |   2.478 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 28     | Random     |   111.21 ns |   2.752 ns |   2.440 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 28     | Random     |    40.90 ns |   1.202 ns |   1.066 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 28     | Random     |   102.34 ns |   2.174 ns |   1.927 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 28     | Random     |   548.64 ns |  13.274 ns |  11.767 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 28     | Random     |    55.56 ns |   3.210 ns |   2.846 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 28     | Random     |   103.61 ns |   2.141 ns |   1.898 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 28     | Random     |   104.39 ns |   2.684 ns |   2.380 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Sorted**     |    **88.15 ns** |   **2.889 ns** |   **2.561 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Sorted     |    91.98 ns |   3.306 ns |   2.931 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Sorted     |    55.80 ns |   1.985 ns |   1.759 ns |  0.63 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Reversed**   |   **107.09 ns** |   **2.294 ns** |   **2.034 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Reversed   |   111.36 ns |   3.703 ns |   3.283 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Reversed   |    57.91 ns |   2.933 ns |   2.600 ns |  0.54 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Duplicates** |   **113.68 ns** |   **3.897 ns** |   **3.254 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Duplicates |   116.68 ns |   3.506 ns |   2.928 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Duplicates |    55.42 ns |   2.256 ns |   1.884 ns |  0.49 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **29**     | **Random**     | **1,437.28 ns** |  **70.197 ns** |  **62.227 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 29     | Random     |   108.18 ns |   3.037 ns |   2.536 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 29     | Random     | 1,813.69 ns | 117.927 ns | 104.539 ns |  1.26 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 29     | Random     | 1,800.69 ns | 117.299 ns | 109.722 ns |  1.26 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 29     | Random     |   123.06 ns |   5.560 ns |   4.929 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 29     | Random     | 1,597.62 ns |  88.617 ns |  73.999 ns |  1.11 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 29     | Random     | 1,591.11 ns |  31.296 ns |  27.743 ns |  1.11 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 29     | Random     | 1,578.01 ns |  59.036 ns |  49.298 ns |  1.10 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 29     | Random     | 1,633.71 ns |  31.086 ns |  27.557 ns |  1.14 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 29     | Random     | 1,570.96 ns |  35.388 ns |  31.371 ns |  1.10 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 29     | Random     | 1,194.01 ns | 133.876 ns | 118.678 ns |  0.83 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 29     | Random     |   125.62 ns |   7.468 ns |   6.620 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 29     | Random     |   171.69 ns |   4.633 ns |   4.107 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 29     | Random     | 1,430.38 ns |  55.149 ns |  48.888 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 29     | Random     | 1,477.10 ns |  34.199 ns |  30.317 ns |  1.03 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 29     | Random     |   113.06 ns |   6.166 ns |   5.466 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 29     | Random     | 1,751.11 ns | 128.219 ns | 113.663 ns |  1.22 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 29     | Random     | 1,776.14 ns | 116.571 ns | 103.337 ns |  1.24 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Random     |   127.36 ns |   5.398 ns |   4.785 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 29     | Random     | 1,566.49 ns |  88.641 ns |  78.578 ns |  1.09 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 29     | Random     | 1,597.75 ns |  43.477 ns |  38.541 ns |  1.11 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 29     | Random     | 1,591.00 ns |  45.647 ns |  40.465 ns |  1.11 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 29     | Random     | 1,610.41 ns |  51.941 ns |  46.045 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 29     | Random     | 1,555.94 ns |  49.861 ns |  44.200 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 29     | Random     | 1,282.29 ns | 105.971 ns |  93.941 ns |  0.89 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 29     | Random     |   122.86 ns |   6.162 ns |   5.463 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 29     | Random     |   163.40 ns |  15.145 ns |  13.426 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 29     | Random     | 1,434.05 ns |  30.899 ns |  27.391 ns |  1.00 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 29     | Random     |    40.01 ns |   1.088 ns |   0.965 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 29     | Random     |   105.55 ns |   2.065 ns |   1.724 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 29     | Random     |   131.85 ns |   2.531 ns |   2.113 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 29     | Random     |    73.22 ns |   1.573 ns |   1.395 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Random     |    65.36 ns |   4.090 ns |   3.626 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 29     | Random     |   114.79 ns |   2.731 ns |   2.421 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 29     | Random     |   118.78 ns |   2.492 ns |   2.081 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 29     | Random     |   118.60 ns |   2.402 ns |   2.129 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 29     | Random     |    42.42 ns |   1.266 ns |   1.123 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 29     | Random     |   110.55 ns |   2.269 ns |   2.011 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 29     | Random     |   561.98 ns |   5.104 ns |   4.525 ns |  0.39 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 29     | Random     |    61.92 ns |   3.362 ns |   2.807 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 29     | Random     |   111.93 ns |   3.159 ns |   2.638 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 29     | Random     |   113.14 ns |   2.253 ns |   1.998 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Sorted**     |    **87.41 ns** |   **2.480 ns** |   **1.936 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Sorted     |    94.39 ns |   2.830 ns |   2.509 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Sorted     |    62.70 ns |   2.202 ns |   1.952 ns |  0.72 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Reversed**   |   **104.14 ns** |   **8.044 ns** |   **7.131 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Reversed   |   113.79 ns |   6.355 ns |   5.634 ns |  1.10 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Reversed   |    64.22 ns |   2.767 ns |   2.311 ns |  0.62 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Duplicates** |   **109.45 ns** |   **3.593 ns** |   **3.185 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Duplicates |   112.39 ns |   2.799 ns |   2.481 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Duplicates |    64.19 ns |   2.277 ns |   1.901 ns |  0.59 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **30**     | **Random**     | **1,464.99 ns** | **113.525 ns** | **100.637 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 30     | Random     |   118.39 ns |   2.263 ns |   2.006 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 30     | Random     | 1,819.29 ns | 169.342 ns | 150.117 ns |  1.25 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 30     | Random     | 1,717.76 ns | 195.627 ns | 182.990 ns |  1.18 |    0.15 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 30     | Random     |   118.94 ns |   4.060 ns |   3.599 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 30     | Random     | 1,613.35 ns |  45.736 ns |  40.544 ns |  1.11 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 30     | Random     | 1,614.66 ns |  69.486 ns |  61.598 ns |  1.11 |    0.10 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 30     | Random     | 1,598.37 ns |  55.882 ns |  49.537 ns |  1.10 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 30     | Random     | 1,646.57 ns |  34.282 ns |  30.390 ns |  1.13 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 30     | Random     | 1,524.30 ns | 143.619 ns | 127.314 ns |  1.05 |    0.12 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 30     | Random     | 1,241.01 ns | 218.647 ns | 193.825 ns |  0.85 |    0.15 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 30     | Random     |   119.99 ns |   4.051 ns |   3.591 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 30     | Random     |   141.26 ns |   6.674 ns |   5.916 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 30     | Random     | 1,448.68 ns | 135.930 ns | 120.499 ns |  0.99 |    0.11 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 30     | Random     | 1,515.49 ns |  31.756 ns |  28.151 ns |  1.04 |    0.09 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 30     | Random     |   121.14 ns |   3.581 ns |   3.175 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 30     | Random     | 1,788.43 ns | 184.087 ns | 172.196 ns |  1.23 |    0.15 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 30     | Random     | 1,749.45 ns | 190.358 ns | 178.061 ns |  1.20 |    0.15 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Random     |   122.31 ns |   3.598 ns |   3.005 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 30     | Random     | 1,612.70 ns |  56.679 ns |  50.245 ns |  1.11 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 30     | Random     | 1,593.84 ns | 126.123 ns | 111.805 ns |  1.09 |    0.11 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 30     | Random     | 1,630.51 ns |  59.740 ns |  52.958 ns |  1.12 |    0.10 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 30     | Random     | 1,604.32 ns |  86.240 ns |  76.450 ns |  1.10 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 30     | Random     | 1,559.82 ns | 118.622 ns | 105.155 ns |  1.07 |    0.11 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 30     | Random     | 1,326.74 ns | 124.155 ns | 110.060 ns |  0.91 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 30     | Random     |   117.57 ns |   4.332 ns |   3.841 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 30     | Random     |   139.12 ns |   8.895 ns |   7.427 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 30     | Random     | 1,468.69 ns |  88.696 ns |  78.627 ns |  1.01 |    0.10 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 30     | Random     |    42.95 ns |   1.415 ns |   1.182 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 30     | Random     |   109.81 ns |   2.837 ns |   2.515 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 30     | Random     |   124.66 ns |   2.413 ns |   2.139 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 30     | Random     |    73.17 ns |   1.743 ns |   1.545 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Random     |    63.06 ns |   2.097 ns |   1.859 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 30     | Random     |   118.99 ns |   2.483 ns |   2.073 ns |  0.08 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 30     | Random     |   124.05 ns |   2.988 ns |   2.649 ns |  0.09 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 30     | Random     |   125.11 ns |   3.056 ns |   2.709 ns |  0.09 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 30     | Random     |    45.16 ns |   1.010 ns |   0.895 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 30     | Random     |   117.31 ns |   2.342 ns |   2.076 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 30     | Random     |   585.13 ns |   6.173 ns |   5.155 ns |  0.40 |    0.03 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 30     | Random     |    60.57 ns |   3.001 ns |   2.506 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.41 ns |   2.156 ns |   1.911 ns |  0.08 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 30     | Random     |   115.34 ns |   2.346 ns |   2.079 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Sorted**     |    **90.41 ns** |   **2.428 ns** |   **2.152 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Sorted     |    92.78 ns |   9.888 ns |   8.765 ns |  1.03 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Sorted     |    64.76 ns |   2.603 ns |   2.307 ns |  0.72 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Reversed**   |   **110.71 ns** |   **2.774 ns** |   **2.459 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Reversed   |   121.31 ns |   3.471 ns |   3.077 ns |  1.10 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Reversed   |    62.57 ns |   2.366 ns |   2.097 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Duplicates** |   **117.83 ns** |   **2.792 ns** |   **2.475 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Duplicates |   122.71 ns |   5.323 ns |   4.719 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Duplicates |    64.39 ns |   2.166 ns |   1.920 ns |  0.55 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **31**     | **Random**     | **1,638.63 ns** | **102.058 ns** |  **90.472 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 31     | Random     |   129.01 ns |   3.519 ns |   3.120 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 31     | Random     | 2,057.59 ns | 127.007 ns | 112.589 ns |  1.26 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 31     | Random     | 1,914.55 ns | 218.507 ns | 204.392 ns |  1.17 |    0.14 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 31     | Random     |   148.01 ns |   5.020 ns |   4.450 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 31     | Random     | 1,798.81 ns | 104.851 ns |  92.948 ns |  1.10 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 31     | Random     | 1,793.32 ns |  87.674 ns |  77.721 ns |  1.10 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 31     | Random     | 1,809.57 ns |  44.320 ns |  39.288 ns |  1.11 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 31     | Random     | 1,818.66 ns |  91.857 ns |  81.429 ns |  1.11 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 31     | Random     | 1,769.59 ns | 124.488 ns | 110.355 ns |  1.08 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 31     | Random     | 1,399.51 ns | 136.721 ns | 121.199 ns |  0.86 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 31     | Random     |   137.28 ns |   4.952 ns |   4.135 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 31     | Random     |   193.01 ns |  16.829 ns |  14.919 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 31     | Random     | 1,679.40 ns |  63.024 ns |  55.869 ns |  1.03 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 31     | Random     | 1,676.86 ns | 115.464 ns |  90.147 ns |  1.03 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 31     | Random     |   137.75 ns |   8.525 ns |   7.119 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 31     | Random     | 1,984.06 ns | 201.629 ns | 188.604 ns |  1.21 |    0.13 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 31     | Random     | 2,063.32 ns | 104.332 ns |  92.488 ns |  1.26 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Random     |   152.96 ns |   7.911 ns |   7.013 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 31     | Random     | 1,773.63 ns | 121.132 ns | 107.380 ns |  1.09 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 31     | Random     | 1,825.25 ns | 106.514 ns |  94.422 ns |  1.12 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 31     | Random     | 1,817.66 ns |  64.080 ns |  53.510 ns |  1.11 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 31     | Random     | 1,827.22 ns |  60.777 ns |  53.877 ns |  1.12 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 31     | Random     | 1,764.39 ns |  97.609 ns |  76.207 ns |  1.08 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 31     | Random     | 1,403.58 ns | 151.558 ns | 126.558 ns |  0.86 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 31     | Random     |   136.36 ns |   9.412 ns |   8.343 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 31     | Random     |   191.89 ns |  15.436 ns |  12.890 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 31     | Random     | 1,641.55 ns |  69.644 ns |  61.738 ns |  1.00 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 31     | Random     |    40.11 ns |   1.279 ns |   1.134 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 31     | Random     |   109.30 ns |   1.839 ns |   1.536 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 31     | Random     |   131.09 ns |   2.362 ns |   2.094 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 31     | Random     |    70.60 ns |   2.225 ns |   1.858 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Random     |    58.45 ns |   2.621 ns |   2.323 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 31     | Random     |   118.07 ns |   2.728 ns |   2.278 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 31     | Random     |   124.07 ns |   2.584 ns |   2.290 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 31     | Random     |   126.51 ns |   3.120 ns |   2.765 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 31     | Random     |    42.48 ns |   1.483 ns |   1.238 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 31     | Random     |   115.09 ns |   2.822 ns |   2.502 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 31     | Random     |   605.41 ns |   6.975 ns |   5.825 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 31     | Random     |    58.18 ns |   2.601 ns |   2.306 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 31     | Random     |   115.45 ns |   2.587 ns |   2.160 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 31     | Random     |   115.17 ns |   2.309 ns |   2.047 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Sorted**     |    **88.30 ns** |   **2.476 ns** |   **2.195 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Sorted     |   101.24 ns |   3.976 ns |   3.320 ns |  1.15 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Sorted     |    61.65 ns |   2.471 ns |   2.191 ns |  0.70 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Reversed**   |   **114.81 ns** |   **2.649 ns** |   **2.348 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Reversed   |   119.55 ns |   2.632 ns |   2.198 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Reversed   |    60.14 ns |   4.335 ns |   3.843 ns |  0.52 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Duplicates** |   **127.13 ns** |   **2.622 ns** |   **2.324 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Duplicates |   134.96 ns |   7.264 ns |   6.065 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Duplicates |    58.27 ns |   1.927 ns |   1.609 ns |  0.46 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **32**     | **Random**     | **1,723.34 ns** |  **71.125 ns** |  **55.530 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 32     | Random     |   128.91 ns |   8.226 ns |   6.869 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 32     | Random     | 2,117.75 ns | 126.363 ns | 112.018 ns |  1.23 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 32     | Random     | 2,031.13 ns | 220.318 ns | 206.085 ns |  1.18 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 32     | Random     |   157.12 ns |   6.492 ns |   5.755 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 32     | Random     | 1,879.51 ns |  50.202 ns |  44.503 ns |  1.09 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 32     | Random     | 1,858.54 ns |  58.246 ns |  51.633 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 32     | Random     | 1,897.06 ns |  43.877 ns |  38.896 ns |  1.10 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 32     | Random     | 1,902.89 ns |  47.799 ns |  42.372 ns |  1.11 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 32     | Random     | 1,878.07 ns |  33.967 ns |  30.110 ns |  1.09 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 32     | Random     | 1,337.46 ns | 144.991 ns | 128.531 ns |  0.78 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 32     | Random     |   149.58 ns |   6.653 ns |   5.897 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 32     | Random     |   207.80 ns |  36.705 ns |  32.538 ns |  0.12 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 32     | Random     | 1,774.54 ns |  78.288 ns |  69.400 ns |  1.03 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 32     | Random     | 1,751.43 ns |  71.372 ns |  63.269 ns |  1.02 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 32     | Random     |   137.98 ns |   3.829 ns |   3.394 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 32     | Random     | 1,925.81 ns | 163.526 ns | 144.961 ns |  1.12 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 32     | Random     | 2,070.11 ns | 128.519 ns | 113.929 ns |  1.20 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Random     |   165.36 ns |   6.982 ns |   6.189 ns |  0.10 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 32     | Random     | 1,858.79 ns | 107.626 ns |  95.407 ns |  1.08 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 32     | Random     | 1,900.95 ns |  35.979 ns |  31.894 ns |  1.10 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 32     | Random     | 1,875.15 ns |  58.680 ns |  52.018 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 32     | Random     | 1,901.72 ns |  46.432 ns |  41.161 ns |  1.10 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 32     | Random     | 1,839.40 ns |  38.712 ns |  32.326 ns |  1.07 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 32     | Random     | 1,280.34 ns | 142.908 ns | 126.684 ns |  0.74 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 32     | Random     |   146.75 ns |   7.329 ns |   6.497 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 32     | Random     |   220.16 ns |   4.249 ns |   3.766 ns |  0.13 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 32     | Random     | 1,698.74 ns |  91.244 ns |  80.885 ns |  0.99 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 32     | Random     |    39.22 ns |   1.205 ns |   1.069 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 32     | Random     |   113.91 ns |   1.913 ns |   1.695 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 32     | Random     |   121.92 ns |   3.061 ns |   2.390 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 32     | Random     |    69.40 ns |   2.069 ns |   1.834 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Random     |    58.23 ns |   2.802 ns |   2.484 ns |  0.03 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 32     | Random     |   124.45 ns |   2.486 ns |   2.203 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 32     | Random     |   129.11 ns |   2.493 ns |   2.210 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 32     | Random     |   128.93 ns |   2.509 ns |   1.959 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 32     | Random     |    41.51 ns |   1.211 ns |   1.011 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 32     | Random     |   120.89 ns |   2.443 ns |   2.165 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 32     | Random     |   623.54 ns |   7.815 ns |   6.927 ns |  0.36 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 32     | Random     |    55.73 ns |   2.356 ns |   1.967 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 32     | Random     |   122.25 ns |   2.520 ns |   2.105 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 32     | Random     |   122.21 ns |   3.020 ns |   2.522 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Sorted**     |    **92.24 ns** |   **2.416 ns** |   **2.141 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Sorted     |   100.82 ns |   2.756 ns |   2.443 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Sorted     |    58.05 ns |   3.297 ns |   2.923 ns |  0.63 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Reversed**   |   **117.24 ns** |   **3.364 ns** |   **2.809 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Reversed   |   127.31 ns |   4.371 ns |   3.874 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Reversed   |    58.01 ns |   1.811 ns |   1.605 ns |  0.50 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Duplicates** |   **123.21 ns** |   **3.379 ns** |   **2.996 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Duplicates |   128.72 ns |   4.004 ns |   3.549 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Duplicates |    57.53 ns |   2.165 ns |   1.919 ns |  0.47 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **34**     | **Random**     | **1,935.00 ns** | **114.957 ns** | **101.906 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| ByteSortingBenchmarks   | SpanSort      | 34     | Random     | 1,952.29 ns |  81.426 ns |  72.182 ns |  1.01 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 34     | Random     |   131.41 ns |   2.146 ns |   1.902 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **FloatSortingBenchmarks**  | **ArraySort**     | **36**     | **Random**     | **2,122.65 ns** | **252.304 ns** | **236.005 ns** |  **1.01** |    **0.15** |         **-** |          **NA** |
| FloatSortingBenchmarks  | SpanSort      | 36     | Random     | 2,170.16 ns | 139.374 ns | 123.552 ns |  1.03 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 36     | Random     |    90.34 ns |   2.915 ns |   2.434 ns |  0.04 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **SByteSortingBenchmarks**  | **ArraySort**     | **38**     | **Random**     | **2,532.19 ns** | **151.247 ns** | **134.076 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| SByteSortingBenchmarks  | SpanSort      | 38     | Random     | 2,489.06 ns | 197.853 ns | 175.391 ns |  0.99 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 38     | Random     |   154.66 ns |   2.304 ns |   2.043 ns |  0.06 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ShortSortingBenchmarks**  | **ArraySort**     | **40**     | **Random**     | **2,407.28 ns** | **126.447 ns** |  **98.722 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| ShortSortingBenchmarks  | SpanSort      | 40     | Random     | 2,382.38 ns | 147.295 ns | 130.573 ns |  0.99 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 40     | Random     |   164.88 ns |   2.308 ns |   1.927 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **UShortSortingBenchmarks** | **ArraySort**     | **42**     | **Random**     | **2,581.65 ns** |  **37.814 ns** |  **33.521 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| UShortSortingBenchmarks | SpanSort      | 42     | Random     | 2,495.43 ns |  89.405 ns |  79.255 ns |  0.97 |    0.03 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 42     | Random     |   173.54 ns |   3.089 ns |   2.579 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **DoubleSortingBenchmarks** | **ArraySort**     | **44**     | **Random**     | **3,478.95 ns** | **295.039 ns** | **275.980 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| DoubleSortingBenchmarks | SpanSort      | 44     | Random     | 3,363.80 ns | 265.786 ns | 248.616 ns |  0.97 |    0.10 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 44     | Random     |   255.46 ns |   9.664 ns |   8.567 ns |  0.07 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Random**     |   **316.84 ns** |  **11.507 ns** |   **9.609 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Random     |   302.09 ns |  32.743 ns |  27.342 ns |  0.95 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Random     |   112.74 ns |   2.361 ns |   1.844 ns |  0.36 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Sorted**     |   **179.10 ns** |   **2.264 ns** |   **2.007 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Sorted     |   187.45 ns |   2.460 ns |   2.054 ns |  1.05 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Sorted     |   114.40 ns |   2.372 ns |   1.980 ns |  0.64 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Reversed**   |   **236.36 ns** |   **4.844 ns** |   **4.294 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Reversed   |   247.56 ns |   4.425 ns |   3.922 ns |  1.05 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Reversed   |   112.41 ns |   2.953 ns |   2.306 ns |  0.48 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Duplicates** |   **214.31 ns** |   **3.993 ns** |   **3.540 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Duplicates |   223.44 ns |   3.253 ns |   2.716 ns |  1.04 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Duplicates |   115.27 ns |   4.801 ns |   4.256 ns |  0.54 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **UIntSortingBenchmarks**   | **ArraySort**     | **50**     | **Random**     |   **278.15 ns** |  **23.990 ns** |  **21.267 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| UIntSortingBenchmarks   | SpanSort      | 50     | Random     |   296.22 ns |  21.058 ns |  16.440 ns |  1.07 |    0.10 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 50     | Random     |   218.51 ns |   2.188 ns |   1.940 ns |  0.79 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **LongSortingBenchmarks**   | **ArraySort**     | **52**     | **Random**     | **3,786.03 ns** | **188.810 ns** | **167.375 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| LongSortingBenchmarks   | SpanSort      | 52     | Random     | 3,855.88 ns |  80.586 ns |  71.438 ns |  1.02 |    0.05 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 52     | Random     |   257.09 ns |   3.656 ns |   3.241 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ULongSortingBenchmarks**  | **ArraySort**     | **54**     | **Random**     |   **501.10 ns** |   **8.276 ns** |   **6.911 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| ULongSortingBenchmarks  | SpanSort      | 54     | Random     |   435.19 ns | 106.019 ns |  93.983 ns |  0.87 |    0.18 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 54     | Random     |   268.36 ns |   4.287 ns |   3.580 ns |  0.54 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **NIntSortingBenchmarks**   | **ArraySort**     | **56**     | **Random**     | **4,194.26 ns** | **172.678 ns** | **153.075 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NIntSortingBenchmarks   | SpanSort      | 56     | Random     | 4,128.65 ns | 194.326 ns | 181.772 ns |  0.99 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 56     | Random     |   288.81 ns |   2.868 ns |   2.543 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **NUIntSortingBenchmarks**  | **ArraySort**     | **58**     | **Random**     | **3,934.95 ns** | **150.066 ns** | **133.029 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NUIntSortingBenchmarks  | SpanSort      | 58     | Random     | 3,990.32 ns | 255.715 ns | 226.685 ns |  1.02 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 58     | Random     |   315.21 ns |   3.951 ns |   3.299 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **60**     | **Random**     |   **361.87 ns** |  **29.234 ns** |  **22.824 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | SpanSort      | 60     | Random     |   390.93 ns |  25.180 ns |  22.322 ns |  1.09 |    0.10 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 60     | Random     |   258.30 ns |   3.231 ns |   2.698 ns |  0.72 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **StringSortingBenchmarks** | **ArraySort**     | **64**     | **Random**     | **3,522.81 ns** | **578.436 ns** | **541.069 ns** |  **1.03** |    **0.24** |      **64 B** |        **1.00** |
| StringSortingBenchmarks | SpanSort      | 64     | Random     | 3,527.68 ns | 673.076 ns | 629.596 ns |  1.03 |    0.26 |      64 B |        1.00 |
| StringSortingBenchmarks | GeneratedSort | 64     | Random     | 1,920.14 ns |  23.039 ns |  20.424 ns |  0.56 |    0.10 |         - |        0.00 |

