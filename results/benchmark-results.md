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
| **CharSortingBenchmarks**   | **ArraySort**     | **8**      | **Random**     |    **29.22 ns** |   **1.823 ns** |   **1.616 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 8      | Random     |   314.43 ns |  11.657 ns |  10.334 ns | 10.79 |    0.70 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 8      | Random     |   276.18 ns |  11.846 ns |  10.501 ns |  9.48 |    0.64 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 8      | Random     |    32.12 ns |   1.508 ns |   1.337 ns |  1.10 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 8      | Random     |   298.39 ns |  21.981 ns |  19.486 ns | 10.24 |    0.86 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 8      | Random     |   268.26 ns |  11.834 ns |  10.491 ns |  9.21 |    0.62 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 8      | Random     |    21.25 ns |   0.900 ns |   0.798 ns |  0.73 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 8      | Random     |    24.03 ns |   0.895 ns |   0.794 ns |  0.82 |    0.05 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 8      | Random     |    29.11 ns |   9.938 ns |   8.810 ns |  1.00 |    0.30 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **16**     | **Random**     |    **69.94 ns** |   **3.053 ns** |   **2.549 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 16     | Random     |   919.86 ns |   8.611 ns |   7.633 ns | 13.17 |    0.49 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 16     | Random     |   800.28 ns |   7.964 ns |   7.060 ns | 11.46 |    0.43 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 16     | Random     |    70.94 ns |   2.708 ns |   2.401 ns |  1.02 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 16     | Random     |   903.64 ns |  27.630 ns |  24.493 ns | 12.94 |    0.58 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 16     | Random     |   780.44 ns |   9.152 ns |   8.113 ns | 11.17 |    0.42 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 16     | Random     |    30.12 ns |   1.139 ns |   1.010 ns |  0.43 |    0.02 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 16     | Random     |    38.16 ns |  10.592 ns |   9.390 ns |  0.55 |    0.13 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 16     | Random     |    32.59 ns |   1.267 ns |   1.058 ns |  0.47 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **23**     | **Random**     | **1,092.72 ns** |  **72.046 ns** |  **63.867 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 23     | Random     |    75.35 ns |   2.831 ns |   2.364 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 23     | Random     | 1,369.19 ns |  83.070 ns |  73.639 ns |  1.26 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 23     | Random     | 1,356.06 ns | 105.555 ns |  93.572 ns |  1.25 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 23     | Random     |    89.73 ns |   6.014 ns |   5.022 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 23     | Random     | 1,187.59 ns |  64.084 ns |  56.809 ns |  1.09 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 23     | Random     | 1,189.43 ns |  78.744 ns |  69.805 ns |  1.09 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 23     | Random     | 1,271.72 ns |  54.090 ns |  47.949 ns |  1.17 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 23     | Random     | 2,180.28 ns |  41.362 ns |  36.667 ns |  2.00 |    0.13 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 23     | Random     | 1,206.76 ns |  65.860 ns |  58.383 ns |  1.11 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 23     | Random     | 1,199.80 ns |  30.750 ns |  27.259 ns |  1.10 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 23     | Random     |   981.49 ns |  92.756 ns |  82.226 ns |  0.90 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 23     | Random     |   103.79 ns |  14.182 ns |  12.572 ns |  0.10 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 23     | Random     |   118.45 ns |   4.596 ns |   4.074 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 23     | Random     | 1,072.83 ns |  48.981 ns |  43.420 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 23     | Random     | 1,150.15 ns |  29.679 ns |  24.783 ns |  1.06 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 23     | Random     |    79.18 ns |   2.380 ns |   2.110 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 23     | Random     | 1,300.46 ns | 115.777 ns | 102.633 ns |  1.19 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 23     | Random     | 1,328.84 ns |  87.815 ns |  77.846 ns |  1.22 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Random     |    97.27 ns |   4.490 ns |   3.506 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 23     | Random     | 1,172.24 ns |  71.287 ns |  63.194 ns |  1.08 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 23     | Random     | 1,240.96 ns |  28.697 ns |  25.439 ns |  1.14 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 23     | Random     | 1,162.47 ns |  64.005 ns |  56.739 ns |  1.07 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 23     | Random     | 2,202.64 ns |  72.275 ns |  64.070 ns |  2.02 |    0.14 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 23     | Random     | 1,235.79 ns |  29.550 ns |  26.195 ns |  1.13 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 23     | Random     | 1,210.10 ns |  51.645 ns |  45.782 ns |  1.11 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 23     | Random     |   902.48 ns | 127.365 ns | 112.906 ns |  0.83 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 23     | Random     |    95.99 ns |   5.075 ns |   4.498 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 23     | Random     |   114.04 ns |  12.680 ns |  11.241 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 23     | Random     | 1,076.44 ns |  71.320 ns |  63.223 ns |  0.99 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 23     | Random     |    33.74 ns |   1.170 ns |   1.037 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 23     | Random     |    81.02 ns |   2.837 ns |   2.215 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 23     | Random     |    84.19 ns |   2.051 ns |   1.713 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 23     | Random     |    60.18 ns |   1.463 ns |   1.297 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Random     |    52.69 ns |   3.833 ns |   3.398 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 23     | Random     |    88.34 ns |   2.162 ns |   1.917 ns |  0.08 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    93.75 ns |   2.653 ns |   2.352 ns |  0.09 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 23     | Random     |    94.81 ns |   2.550 ns |   2.261 ns |  0.09 |    0.01 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 23     | Random     |   625.09 ns |   6.017 ns |   5.334 ns |  0.57 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 23     | Random     |    36.53 ns |   1.227 ns |   1.088 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 23     | Random     |    87.33 ns |   2.188 ns |   1.940 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 23     | Random     |   389.32 ns |   4.670 ns |   3.646 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    46.76 ns |   2.121 ns |   1.880 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 23     | Random     |    84.19 ns |   1.658 ns |   1.385 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 23     | Random     |    86.75 ns |   2.002 ns |   1.775 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Sorted**     |    **66.48 ns** |   **9.282 ns** |   **7.751 ns** |  **1.01** |    **0.16** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 23     | Sorted     |   720.24 ns |  15.907 ns |  14.101 ns | 10.97 |    1.27 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Sorted     |    63.54 ns |   3.029 ns |   2.530 ns |  0.97 |    0.12 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 23     | Sorted     |   784.68 ns |  19.968 ns |  16.674 ns | 11.96 |    1.39 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Sorted     |    49.18 ns |   1.782 ns |   1.488 ns |  0.75 |    0.09 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 23     | Sorted     |   629.97 ns |   7.977 ns |   6.228 ns |  9.60 |    1.10 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Reversed**   |    **84.73 ns** |   **2.698 ns** |   **2.392 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 23     | Reversed   | 1,070.27 ns |  21.919 ns |  19.430 ns | 12.64 |    0.42 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Reversed   |    91.54 ns |   1.804 ns |   1.599 ns |  1.08 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 23     | Reversed   | 1,106.41 ns |  32.811 ns |  29.086 ns | 13.07 |    0.50 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Reversed   |    46.86 ns |   1.848 ns |   1.443 ns |  0.55 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 23     | Reversed   |   625.62 ns |   6.951 ns |   5.427 ns |  7.39 |    0.22 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Duplicates** |    **88.32 ns** |   **2.747 ns** |   **2.435 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 23     | Duplicates | 1,756.36 ns | 104.247 ns |  92.412 ns | 19.90 |    1.14 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Duplicates |    89.79 ns |   6.956 ns |   6.166 ns |  1.02 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 23     | Duplicates | 1,818.63 ns |  39.545 ns |  35.056 ns | 20.61 |    0.67 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Duplicates |    47.66 ns |   2.167 ns |   1.810 ns |  0.54 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 23     | Duplicates |   869.06 ns |   9.832 ns |   7.676 ns |  9.85 |    0.27 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **24**     | **Random**     | **1,253.24 ns** |  **32.281 ns** |  **28.617 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 24     | Random     |   127.48 ns |   4.058 ns |   3.597 ns |  0.10 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 24     | Random     | 1,550.08 ns | 115.725 ns | 102.587 ns |  1.24 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 24     | Random     | 1,491.11 ns |  98.326 ns |  87.164 ns |  1.19 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 24     | Random     |   106.94 ns |   2.643 ns |   2.343 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 24     | Random     | 1,328.55 ns |  61.526 ns |  54.542 ns |  1.06 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 24     | Random     | 1,354.44 ns |  74.897 ns |  66.395 ns |  1.08 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 24     | Random     | 1,327.74 ns |  80.014 ns |  70.930 ns |  1.06 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 24     | Random     | 2,068.74 ns |  55.190 ns |  48.924 ns |  1.65 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 24     | Random     | 1,365.76 ns |  29.893 ns |  26.500 ns |  1.09 |    0.03 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 24     | Random     | 1,318.67 ns |  87.548 ns |  77.609 ns |  1.05 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 24     | Random     | 1,073.57 ns |  98.041 ns |  86.911 ns |  0.86 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 24     | Random     |   111.38 ns |   9.788 ns |   8.174 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 24     | Random     |   127.79 ns |   2.701 ns |   2.394 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 24     | Random     | 1,539.79 ns |  39.499 ns |  35.015 ns |  1.23 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 24     | Random     | 1,264.65 ns |  81.673 ns |  72.401 ns |  1.01 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 24     | Random     |   127.66 ns |   2.304 ns |   2.042 ns |  0.10 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 24     | Random     | 1,474.73 ns | 152.137 ns | 142.309 ns |  1.18 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 24     | Random     | 1,450.29 ns | 110.563 ns |  98.011 ns |  1.16 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Random     |   110.92 ns |   5.309 ns |   4.433 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 24     | Random     | 1,344.90 ns |  69.030 ns |  61.193 ns |  1.07 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 24     | Random     | 1,391.66 ns |  80.486 ns |  71.349 ns |  1.11 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 24     | Random     | 1,317.34 ns |  84.774 ns |  75.150 ns |  1.05 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 24     | Random     | 2,107.09 ns |  33.401 ns |  29.609 ns |  1.68 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 24     | Random     | 1,388.54 ns |  33.779 ns |  29.944 ns |  1.11 |    0.03 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 24     | Random     | 1,316.09 ns |  64.457 ns |  57.139 ns |  1.05 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 24     | Random     | 1,061.55 ns | 117.779 ns | 104.408 ns |  0.85 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 24     | Random     |   104.93 ns |   4.548 ns |   4.032 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 24     | Random     |   115.84 ns |  12.349 ns |  10.947 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 24     | Random     | 1,203.75 ns |  85.032 ns |  75.378 ns |  0.96 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 24     | Random     |    36.15 ns |   1.181 ns |   1.047 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 24     | Random     |    78.99 ns |   1.884 ns |   1.670 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 24     | Random     |    99.63 ns |   1.498 ns |   1.328 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 24     | Random     |    62.09 ns |   1.753 ns |   1.554 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Random     |    51.98 ns |   1.931 ns |   1.712 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 24     | Random     |    86.73 ns |   2.018 ns |   1.789 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    92.65 ns |   3.384 ns |   2.826 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 24     | Random     |    92.01 ns |   2.185 ns |   1.937 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 24     | Random     |   657.92 ns |  10.333 ns |   8.067 ns |  0.53 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 24     | Random     |    43.32 ns |   9.324 ns |   8.265 ns |  0.03 |    0.01 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 24     | Random     |    85.54 ns |   2.399 ns |   2.126 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 24     | Random     |   418.37 ns |   3.142 ns |   2.453 ns |  0.33 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    50.37 ns |   1.968 ns |   1.643 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 24     | Random     |    83.22 ns |   2.208 ns |   1.724 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 24     | Random     |    84.45 ns |   2.176 ns |   1.929 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Sorted**     |    **76.73 ns** |   **2.473 ns** |   **2.192 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 24     | Sorted     |   749.08 ns |  16.388 ns |  13.684 ns |  9.77 |    0.32 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Sorted     |    80.03 ns |   2.986 ns |   2.647 ns |  1.04 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 24     | Sorted     |   768.99 ns |  14.796 ns |  13.116 ns | 10.03 |    0.33 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Sorted     |    50.63 ns |   1.933 ns |   1.714 ns |  0.66 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 24     | Sorted     |   658.44 ns |   8.115 ns |   6.776 ns |  8.59 |    0.25 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Reversed**   |    **85.69 ns** |   **6.624 ns** |   **5.531 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 24     | Reversed   | 1,125.45 ns |  29.021 ns |  25.726 ns | 13.19 |    0.92 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Reversed   |    95.95 ns |   6.154 ns |   5.139 ns |  1.12 |    0.09 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 24     | Reversed   | 1,138.41 ns |  21.313 ns |  18.893 ns | 13.34 |    0.91 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Reversed   |    51.36 ns |   1.854 ns |   1.644 ns |  0.60 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 24     | Reversed   |   678.63 ns |  11.713 ns |  10.383 ns |  7.95 |    0.54 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Duplicates** |    **90.04 ns** |   **5.830 ns** |   **4.552 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 24     | Duplicates | 2,000.31 ns |  92.897 ns |  82.351 ns | 22.27 |    1.39 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Duplicates |    94.73 ns |   4.165 ns |   3.478 ns |  1.05 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 24     | Duplicates | 2,031.58 ns |  81.166 ns |  67.777 ns | 22.62 |    1.31 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Duplicates |    51.91 ns |   1.846 ns |   1.636 ns |  0.58 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 24     | Duplicates |   988.19 ns |  70.738 ns |  59.069 ns | 11.00 |    0.83 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **25**     | **Random**     | **1,192.09 ns** |  **36.969 ns** |  **32.772 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 25     | Random     |   120.41 ns |   8.036 ns |   7.123 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 25     | Random     | 1,432.72 ns | 128.207 ns | 113.652 ns |  1.20 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 25     | Random     | 1,372.41 ns | 149.351 ns | 139.703 ns |  1.15 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 25     | Random     |   103.36 ns |   4.212 ns |   3.734 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 25     | Random     | 1,245.27 ns |  26.158 ns |  23.189 ns |  1.05 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 25     | Random     | 1,244.12 ns |  53.882 ns |  44.994 ns |  1.04 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 25     | Random     | 1,230.81 ns |  89.350 ns |  79.207 ns |  1.03 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 25     | Random     | 2,144.71 ns |  55.882 ns |  49.538 ns |  1.80 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 25     | Random     | 1,297.46 ns |  40.154 ns |  35.596 ns |  1.09 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 25     | Random     | 1,222.49 ns | 103.501 ns |  91.751 ns |  1.03 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 25     | Random     |   884.89 ns |  56.664 ns |  50.231 ns |  0.74 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 25     | Random     |   106.41 ns |   3.823 ns |   3.389 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 25     | Random     |   121.17 ns |   2.351 ns |   2.084 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 25     | Random     | 1,130.84 ns |  71.576 ns |  63.451 ns |  0.95 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 25     | Random     | 1,177.43 ns |  77.116 ns |  68.361 ns |  0.99 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 25     | Random     |   123.16 ns |   1.971 ns |   1.747 ns |  0.10 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 25     | Random     | 1,383.99 ns | 115.254 ns | 102.170 ns |  1.16 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 25     | Random     | 1,362.03 ns | 117.528 ns | 104.186 ns |  1.14 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Random     |   109.01 ns |   3.493 ns |   3.096 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 25     | Random     | 1,247.87 ns |  81.212 ns |  71.992 ns |  1.05 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 25     | Random     | 1,245.94 ns |  99.143 ns |  87.888 ns |  1.05 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 25     | Random     | 1,237.36 ns |  60.119 ns |  53.294 ns |  1.04 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 25     | Random     | 2,039.12 ns |  40.894 ns |  36.251 ns |  1.71 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 25     | Random     | 1,287.92 ns |  58.199 ns |  51.592 ns |  1.08 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 25     | Random     | 1,238.78 ns |  66.960 ns |  59.358 ns |  1.04 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 25     | Random     |   996.58 ns |  84.862 ns |  70.864 ns |  0.84 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 25     | Random     |   105.86 ns |   3.774 ns |   3.345 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 25     | Random     |   121.53 ns |  11.734 ns |  10.402 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 25     | Random     | 1,121.69 ns |  99.893 ns |  88.552 ns |  0.94 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 25     | Random     |    36.76 ns |   1.220 ns |   1.081 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 25     | Random     |    89.01 ns |   5.988 ns |   5.000 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 25     | Random     |   100.18 ns |   1.853 ns |   1.547 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 25     | Random     |    65.89 ns |   1.424 ns |   1.262 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Random     |    53.31 ns |   1.821 ns |   1.422 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 25     | Random     |    97.48 ns |   1.991 ns |   1.765 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 25     | Random     |   101.16 ns |   2.425 ns |   2.149 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 25     | Random     |   101.29 ns |   1.901 ns |   1.685 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 25     | Random     |   722.09 ns |  20.070 ns |  17.792 ns |  0.61 |    0.02 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 25     | Random     |    39.44 ns |   1.474 ns |   1.307 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 25     | Random     |    94.03 ns |   2.226 ns |   1.973 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 25     | Random     |   444.97 ns |   5.197 ns |   4.339 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 25     | Random     |    51.76 ns |   1.895 ns |   1.680 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 25     | Random     |    95.32 ns |   5.867 ns |   4.899 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 25     | Random     |    91.84 ns |   2.168 ns |   1.922 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Sorted**     |    **75.26 ns** |   **4.429 ns** |   **3.926 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 25     | Sorted     |   769.78 ns |  20.879 ns |  17.435 ns | 10.26 |    0.62 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Sorted     |    87.57 ns |   3.540 ns |   2.956 ns |  1.17 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 25     | Sorted     |   796.67 ns |  13.945 ns |  12.362 ns | 10.62 |    0.62 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Sorted     |    53.86 ns |   1.758 ns |   1.558 ns |  0.72 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 25     | Sorted     |   710.93 ns |   8.170 ns |   7.242 ns |  9.47 |    0.54 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Reversed**   |    **90.98 ns** |   **2.475 ns** |   **2.194 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 25     | Reversed   | 1,154.04 ns |  22.625 ns |  20.057 ns | 12.69 |    0.37 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Reversed   |    93.96 ns |   2.898 ns |   2.569 ns |  1.03 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 25     | Reversed   | 1,173.61 ns |  19.025 ns |  16.865 ns | 12.91 |    0.36 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Reversed   |    54.86 ns |   2.072 ns |   1.837 ns |  0.60 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 25     | Reversed   |   731.03 ns |  12.865 ns |  11.405 ns |  8.04 |    0.23 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Duplicates** |    **99.72 ns** |   **3.993 ns** |   **3.540 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 25     | Duplicates | 2,054.27 ns | 113.609 ns | 100.711 ns | 20.62 |    1.21 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Duplicates |   100.42 ns |   9.146 ns |   8.107 ns |  1.01 |    0.09 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 25     | Duplicates | 2,102.64 ns |  89.104 ns |  74.406 ns | 21.11 |    1.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Duplicates |    56.99 ns |   1.941 ns |   1.720 ns |  0.57 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 25     | Duplicates | 1,039.55 ns |  60.038 ns |  53.222 ns | 10.44 |    0.63 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **26**     | **Random**     | **1,429.44 ns** |  **85.882 ns** |  **76.132 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 26     | Random     |   121.67 ns |   3.313 ns |   2.937 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 26     | Random     | 1,674.53 ns |  76.063 ns |  59.385 ns |  1.18 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 26     | Random     | 1,622.86 ns | 178.565 ns | 167.030 ns |  1.14 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 26     | Random     |   119.29 ns |   3.436 ns |   2.869 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 26     | Random     | 1,506.83 ns |  54.225 ns |  48.069 ns |  1.06 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 26     | Random     | 1,493.40 ns |  39.432 ns |  34.955 ns |  1.05 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 26     | Random     | 1,454.74 ns |  80.555 ns |  71.410 ns |  1.02 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 26     | Random     | 1,984.96 ns |  56.962 ns |  50.496 ns |  1.39 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 26     | Random     | 1,549.06 ns |  37.425 ns |  33.176 ns |  1.09 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 26     | Random     | 1,475.29 ns |  37.039 ns |  32.834 ns |  1.04 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 26     | Random     | 1,124.39 ns |  96.401 ns |  85.457 ns |  0.79 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 26     | Random     |   120.56 ns |   5.696 ns |   4.447 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 26     | Random     |   143.17 ns |  20.378 ns |  18.065 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 26     | Random     | 1,361.81 ns |  52.327 ns |  46.386 ns |  0.96 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 26     | Random     | 1,385.04 ns |  68.301 ns |  60.547 ns |  0.97 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 26     | Random     |   122.58 ns |   1.971 ns |   1.748 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 26     | Random     | 1,552.28 ns | 157.978 ns | 140.043 ns |  1.09 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 26     | Random     | 1,667.61 ns |  80.029 ns |  66.828 ns |  1.17 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Random     |   122.00 ns |   4.627 ns |   4.102 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 26     | Random     | 1,511.99 ns |  41.848 ns |  37.097 ns |  1.06 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 26     | Random     | 1,465.90 ns |  69.718 ns |  61.804 ns |  1.03 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 26     | Random     | 1,505.36 ns |  38.181 ns |  33.846 ns |  1.06 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 26     | Random     | 2,023.67 ns |  42.044 ns |  37.271 ns |  1.42 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 26     | Random     | 1,538.84 ns |  95.332 ns |  84.509 ns |  1.08 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 26     | Random     | 1,494.90 ns |  90.100 ns |  79.872 ns |  1.05 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 26     | Random     | 1,023.61 ns | 147.819 ns | 131.037 ns |  0.72 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 26     | Random     |   126.76 ns |   9.258 ns |   8.207 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 26     | Random     |   143.08 ns |   7.972 ns |   7.067 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 26     | Random     | 1,352.88 ns |  43.573 ns |  38.626 ns |  0.95 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 26     | Random     |    39.84 ns |   1.257 ns |   1.114 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 26     | Random     |    90.07 ns |   2.231 ns |   1.742 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 26     | Random     |   115.58 ns |   2.259 ns |   1.764 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 26     | Random     |    67.46 ns |   1.425 ns |   1.263 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Random     |    55.97 ns |   2.064 ns |   1.830 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 26     | Random     |    96.93 ns |   1.868 ns |   1.656 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 26     | Random     |   100.03 ns |   2.087 ns |   1.743 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 26     | Random     |   102.05 ns |   2.893 ns |   2.416 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 26     | Random     |   751.54 ns |   4.460 ns |   3.482 ns |  0.53 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 26     | Random     |    50.45 ns |  14.175 ns |  11.837 ns |  0.04 |    0.01 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 26     | Random     |    95.96 ns |   2.243 ns |   1.988 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 26     | Random     |   474.94 ns |   4.714 ns |   3.936 ns |  0.33 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 26     | Random     |    52.60 ns |   1.954 ns |   1.732 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 26     | Random     |    94.13 ns |   1.884 ns |   1.573 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 26     | Random     |    93.04 ns |   2.826 ns |   2.206 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Sorted**     |    **81.76 ns** |   **9.128 ns** |   **8.092 ns** |  **1.01** |    **0.15** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 26     | Sorted     |   791.34 ns |  14.134 ns |  11.803 ns |  9.79 |    1.16 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Sorted     |    90.88 ns |   1.713 ns |   1.518 ns |  1.12 |    0.13 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 26     | Sorted     |   809.85 ns |  20.460 ns |  17.085 ns | 10.02 |    1.19 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Sorted     |    55.98 ns |   1.921 ns |   1.703 ns |  0.69 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 26     | Sorted     |   753.19 ns |   4.889 ns |   4.334 ns |  9.32 |    1.10 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Reversed**   |    **88.62 ns** |  **13.740 ns** |  **11.473 ns** |  **1.01** |    **0.17** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 26     | Reversed   | 1,224.41 ns |  17.130 ns |  15.185 ns | 14.00 |    1.52 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Reversed   |   103.84 ns |   2.860 ns |   2.233 ns |  1.19 |    0.13 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 26     | Reversed   | 1,229.35 ns |  31.501 ns |  26.305 ns | 14.06 |    1.54 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Reversed   |    54.62 ns |   2.317 ns |   1.809 ns |  0.62 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 26     | Reversed   |   761.99 ns |   5.015 ns |   3.915 ns |  8.71 |    0.94 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Duplicates** |    **93.84 ns** |   **2.899 ns** |   **2.570 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 26     | Duplicates | 1,946.71 ns | 111.701 ns |  99.020 ns | 20.76 |    1.16 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Duplicates |   100.44 ns |   3.129 ns |   2.774 ns |  1.07 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 26     | Duplicates | 1,997.44 ns |  36.092 ns |  31.995 ns | 21.30 |    0.65 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Duplicates |    59.00 ns |   1.968 ns |   1.644 ns |  0.63 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 26     | Duplicates | 1,076.34 ns |  17.107 ns |  15.165 ns | 11.48 |    0.34 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **27**     | **Random**     | **1,327.68 ns** |  **60.435 ns** |  **53.574 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 27     | Random     |    94.87 ns |   3.608 ns |   3.199 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 27     | Random     | 1,638.55 ns | 118.757 ns | 105.275 ns |  1.24 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 27     | Random     | 1,598.30 ns | 113.626 ns | 100.726 ns |  1.21 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 27     | Random     |   105.08 ns |   6.139 ns |   5.126 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 27     | Random     | 1,464.76 ns |  30.084 ns |  26.668 ns |  1.11 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 27     | Random     | 1,422.83 ns |  86.621 ns |  76.788 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 27     | Random     | 1,427.11 ns |  46.106 ns |  40.872 ns |  1.08 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 27     | Random     | 2,599.14 ns | 107.402 ns |  95.209 ns |  1.96 |    0.11 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 27     | Random     | 1,479.38 ns |  59.456 ns |  52.706 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 27     | Random     | 1,407.04 ns |  96.410 ns |  85.465 ns |  1.06 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 27     | Random     | 1,076.29 ns | 114.041 ns | 101.094 ns |  0.81 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 27     | Random     |   108.20 ns |   3.139 ns |   2.621 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 27     | Random     |   157.40 ns |   4.114 ns |   3.647 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 27     | Random     | 1,297.74 ns |  52.814 ns |  46.818 ns |  0.98 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 27     | Random     | 1,303.16 ns | 100.524 ns |  89.112 ns |  0.98 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 27     | Random     |    98.71 ns |   3.688 ns |   3.080 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 27     | Random     | 1,519.91 ns | 101.816 ns |  90.257 ns |  1.15 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 27     | Random     | 1,587.81 ns |  95.210 ns |  84.401 ns |  1.20 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Random     |   113.11 ns |   6.089 ns |   5.085 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 27     | Random     | 1,442.21 ns |  51.091 ns |  45.291 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 27     | Random     | 1,447.16 ns |  68.372 ns |  60.610 ns |  1.09 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 27     | Random     | 1,467.67 ns |  49.346 ns |  43.744 ns |  1.11 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 27     | Random     | 2,653.26 ns | 102.439 ns |  90.810 ns |  2.00 |    0.11 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 27     | Random     | 1,456.74 ns |  62.846 ns |  55.712 ns |  1.10 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 27     | Random     | 1,383.14 ns |  85.037 ns |  75.383 ns |  1.04 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 27     | Random     | 1,114.71 ns |  88.350 ns |  78.320 ns |  0.84 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 27     | Random     |   112.80 ns |   6.744 ns |   5.978 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 27     | Random     |   151.47 ns |   2.901 ns |   2.422 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 27     | Random     | 1,294.96 ns |  31.079 ns |  27.551 ns |  0.98 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 27     | Random     |    37.87 ns |   1.783 ns |   1.581 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 27     | Random     |    96.62 ns |   2.136 ns |   1.894 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 27     | Random     |    99.92 ns |   1.336 ns |   1.116 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 27     | Random     |    65.89 ns |   1.856 ns |   1.645 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Random     |    54.31 ns |   2.010 ns |   1.782 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 27     | Random     |    99.94 ns |   2.618 ns |   2.044 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 27     | Random     |   107.14 ns |   2.453 ns |   2.175 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 27     | Random     |   105.18 ns |   2.551 ns |   2.130 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 27     | Random     |   863.68 ns |  34.301 ns |  30.407 ns |  0.65 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 27     | Random     |    38.62 ns |   1.145 ns |   0.956 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 27     | Random     |   100.34 ns |   2.553 ns |   2.263 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 27     | Random     |   513.57 ns |   4.948 ns |   3.863 ns |  0.39 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 27     | Random     |    54.04 ns |   2.131 ns |   1.889 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 27     | Random     |    99.49 ns |   1.864 ns |   1.652 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 27     | Random     |    98.95 ns |   6.233 ns |   4.867 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Sorted**     |    **87.26 ns** |   **4.204 ns** |   **3.727 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 27     | Sorted     |   843.03 ns |  14.595 ns |  12.938 ns |  9.68 |    0.44 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Sorted     |    93.26 ns |   2.435 ns |   2.159 ns |  1.07 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 27     | Sorted     |   831.94 ns |  16.421 ns |  14.557 ns |  9.55 |    0.44 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Sorted     |    56.26 ns |   2.215 ns |   1.963 ns |  0.65 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 27     | Sorted     |   841.16 ns |  25.551 ns |  22.651 ns |  9.66 |    0.49 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Reversed**   |    **93.65 ns** |   **3.381 ns** |   **2.997 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 27     | Reversed   | 1,263.54 ns |  18.237 ns |  16.166 ns | 13.51 |    0.46 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Reversed   |   101.34 ns |   7.565 ns |   6.707 ns |  1.08 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 27     | Reversed   | 1,267.93 ns |  16.929 ns |  15.007 ns | 13.55 |    0.46 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Reversed   |    55.69 ns |   4.018 ns |   3.355 ns |  0.60 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 27     | Reversed   |   859.36 ns |   5.844 ns |   5.180 ns |  9.19 |    0.30 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Duplicates** |   **119.94 ns** |  **24.424 ns** |  **21.651 ns** |  **1.03** |    **0.24** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 27     | Duplicates | 2,703.84 ns | 103.408 ns |  91.668 ns | 23.13 |    3.48 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Duplicates |   116.78 ns |   4.336 ns |   3.844 ns |  1.00 |    0.15 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 27     | Duplicates | 2,792.51 ns |  29.549 ns |  26.195 ns | 23.89 |    3.52 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Duplicates |    55.48 ns |   1.976 ns |   1.752 ns |  0.47 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 27     | Duplicates | 1,267.37 ns |  54.721 ns |  48.509 ns | 10.84 |    1.64 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **28**     | **Random**     | **1,499.54 ns** | **107.717 ns** |  **95.488 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 28     | Random     |   128.45 ns |   8.792 ns |   7.794 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 28     | Random     | 1,846.49 ns | 129.628 ns | 114.912 ns |  1.24 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 28     | Random     | 1,726.68 ns | 195.039 ns | 182.439 ns |  1.16 |    0.14 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 28     | Random     |   134.72 ns |   4.124 ns |   3.444 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 28     | Random     | 1,667.85 ns |  44.596 ns |  39.533 ns |  1.12 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 28     | Random     | 1,614.44 ns |  75.183 ns |  66.648 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 28     | Random     | 1,594.78 ns | 115.880 ns | 102.724 ns |  1.07 |    0.10 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 28     | Random     | 2,351.25 ns |  59.213 ns |  49.446 ns |  1.57 |    0.11 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 28     | Random     | 1,703.81 ns |  33.685 ns |  29.861 ns |  1.14 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 28     | Random     | 1,593.65 ns | 118.242 ns | 110.603 ns |  1.07 |    0.10 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 28     | Random     | 1,195.06 ns | 107.930 ns |  95.677 ns |  0.80 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 28     | Random     |   133.76 ns |   2.286 ns |   1.785 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 28     | Random     |   144.01 ns |  29.948 ns |  26.549 ns |  0.10 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 28     | Random     | 1,493.29 ns |  89.344 ns |  79.201 ns |  1.00 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 28     | Random     | 1,483.01 ns | 103.958 ns |  81.164 ns |  0.99 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 28     | Random     |   133.82 ns |   2.784 ns |   2.468 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 28     | Random     | 1,763.86 ns | 160.172 ns | 149.825 ns |  1.18 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 28     | Random     | 1,818.04 ns | 128.955 ns | 114.315 ns |  1.22 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Random     |   141.95 ns |   5.490 ns |   4.286 ns |  0.10 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 28     | Random     | 1,611.19 ns | 164.622 ns | 153.987 ns |  1.08 |    0.12 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 28     | Random     | 1,687.47 ns |  42.453 ns |  37.633 ns |  1.13 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 28     | Random     | 1,605.27 ns | 145.707 ns | 129.165 ns |  1.07 |    0.11 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 28     | Random     | 2,351.96 ns |  71.202 ns |  63.119 ns |  1.57 |    0.11 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 28     | Random     | 1,662.32 ns |  88.307 ns |  78.281 ns |  1.11 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 28     | Random     | 1,627.07 ns |  87.264 ns |  77.357 ns |  1.09 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 28     | Random     | 1,116.51 ns | 189.632 ns | 168.103 ns |  0.75 |    0.12 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 28     | Random     |   133.29 ns |   7.109 ns |   6.302 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 28     | Random     |   165.60 ns |   1.715 ns |   1.521 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 28     | Random     | 1,523.45 ns |  40.339 ns |  35.760 ns |  1.02 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 28     | Random     |    36.75 ns |   1.394 ns |   1.236 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 28     | Random     |    99.09 ns |   1.994 ns |   1.768 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 28     | Random     |    92.45 ns |   3.297 ns |   2.753 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 28     | Random     |    65.89 ns |   1.471 ns |   1.304 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Random     |    55.44 ns |   3.446 ns |   2.877 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 28     | Random     |   180.09 ns |  26.635 ns |  23.611 ns |  0.12 |    0.02 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 28     | Random     |   109.14 ns |   2.144 ns |   1.901 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 28     | Random     |   108.67 ns |   2.854 ns |   2.228 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 28     | Random     |   892.69 ns |   3.479 ns |   3.084 ns |  0.60 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 28     | Random     |    38.75 ns |   1.444 ns |   1.127 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 28     | Random     |   102.26 ns |   2.268 ns |   2.011 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 28     | Random     |   541.61 ns |   5.146 ns |   4.561 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 28     | Random     |    54.42 ns |   8.370 ns |   6.989 ns |  0.04 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 28     | Random     |   103.34 ns |   2.056 ns |   1.823 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 28     | Random     |   100.52 ns |   2.275 ns |   1.900 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Sorted**     |    **83.70 ns** |   **7.665 ns** |   **6.401 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 28     | Sorted     |   860.71 ns |  13.114 ns |  11.625 ns | 10.34 |    0.85 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Sorted     |    89.58 ns |   2.395 ns |   2.123 ns |  1.08 |    0.09 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 28     | Sorted     |   863.40 ns |  12.770 ns |  11.320 ns | 10.38 |    0.85 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Sorted     |    55.66 ns |   2.152 ns |   1.908 ns |  0.67 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 28     | Sorted     |   864.99 ns |   5.903 ns |   4.929 ns | 10.40 |    0.85 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Reversed**   |   **107.16 ns** |   **3.076 ns** |   **2.727 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 28     | Reversed   | 1,325.76 ns |  31.603 ns |  28.015 ns | 12.38 |    0.40 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Reversed   |   107.57 ns |   8.167 ns |   7.239 ns |  1.00 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 28     | Reversed   | 1,322.24 ns |  18.887 ns |  16.743 ns | 12.35 |    0.34 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Reversed   |    55.49 ns |   2.486 ns |   1.941 ns |  0.52 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 28     | Reversed   |   900.99 ns |   7.980 ns |   7.074 ns |  8.41 |    0.22 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Duplicates** |   **109.69 ns** |   **4.263 ns** |   **3.328 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 28     | Duplicates | 2,437.95 ns |  88.756 ns |  78.680 ns | 22.24 |    0.95 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Duplicates |   115.62 ns |   3.871 ns |   3.022 ns |  1.05 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 28     | Duplicates | 2,276.97 ns | 257.293 ns | 240.672 ns | 20.78 |    2.21 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Duplicates |    55.52 ns |   1.737 ns |   1.540 ns |  0.51 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 28     | Duplicates | 1,271.24 ns |  13.276 ns |  11.768 ns | 11.60 |    0.35 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **29**     | **Random**     | **1,415.88 ns** | **103.580 ns** |  **91.821 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 29     | Random     |   106.40 ns |  11.554 ns |   9.648 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 29     | Random     | 1,860.06 ns |  64.195 ns |  56.907 ns |  1.32 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 29     | Random     | 1,763.46 ns | 125.125 ns | 110.920 ns |  1.25 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 29     | Random     |   123.95 ns |   4.635 ns |   4.109 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 29     | Random     | 1,546.64 ns | 144.839 ns | 128.396 ns |  1.10 |    0.12 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 29     | Random     | 1,608.09 ns |  31.481 ns |  27.907 ns |  1.14 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 29     | Random     | 1,608.15 ns |  32.325 ns |  28.656 ns |  1.14 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 29     | Random     | 2,537.51 ns |  63.491 ns |  56.284 ns |  1.80 |    0.13 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 29     | Random     | 1,621.84 ns |  66.711 ns |  59.137 ns |  1.15 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 29     | Random     | 1,580.85 ns |  31.214 ns |  27.670 ns |  1.12 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 29     | Random     | 1,217.31 ns | 134.214 ns | 118.977 ns |  0.86 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 29     | Random     |   121.37 ns |   9.145 ns |   8.107 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 29     | Random     |   176.22 ns |   6.178 ns |   5.477 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 29     | Random     | 1,439.90 ns |  41.725 ns |  36.988 ns |  1.02 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 29     | Random     | 1,499.36 ns |  24.379 ns |  21.612 ns |  1.06 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 29     | Random     |   110.05 ns |   7.673 ns |   6.802 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 29     | Random     | 1,799.33 ns | 145.161 ns | 135.783 ns |  1.28 |    0.13 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 29     | Random     | 1,887.26 ns |  64.071 ns |  56.797 ns |  1.34 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Random     |   127.93 ns |   4.480 ns |   3.971 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 29     | Random     | 1,629.99 ns |  34.926 ns |  30.961 ns |  1.16 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 29     | Random     | 1,596.69 ns |  51.461 ns |  45.618 ns |  1.13 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 29     | Random     | 1,553.93 ns |  52.228 ns |  46.299 ns |  1.10 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 29     | Random     | 2,563.18 ns |  73.799 ns |  65.421 ns |  1.82 |    0.13 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 29     | Random     | 1,480.49 ns |  71.570 ns |  63.445 ns |  1.05 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 29     | Random     | 1,535.94 ns |  87.245 ns |  77.340 ns |  1.09 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 29     | Random     | 1,209.31 ns |  94.082 ns |  83.401 ns |  0.86 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 29     | Random     |   121.69 ns |   3.542 ns |   3.140 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 29     | Random     |   165.29 ns |   4.963 ns |   4.399 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 29     | Random     | 1,540.56 ns |  36.945 ns |  32.751 ns |  1.09 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 29     | Random     |    39.99 ns |   1.563 ns |   1.386 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 29     | Random     |   105.61 ns |   1.628 ns |   1.444 ns |  0.07 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 29     | Random     |   127.66 ns |   1.921 ns |   1.703 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 29     | Random     |    73.89 ns |   1.722 ns |   1.527 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Random     |    62.28 ns |   2.019 ns |   1.790 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 29     | Random     |   113.63 ns |   2.496 ns |   2.085 ns |  0.08 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 29     | Random     |   116.31 ns |   2.328 ns |   2.064 ns |  0.08 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 29     | Random     |   119.79 ns |   2.464 ns |   2.184 ns |  0.08 |    0.01 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 29     | Random     |   899.53 ns |   4.225 ns |   3.528 ns |  0.64 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 29     | Random     |    40.95 ns |   1.216 ns |   1.078 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 29     | Random     |   111.86 ns |   2.240 ns |   1.986 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 29     | Random     |   562.01 ns |   8.717 ns |   7.727 ns |  0.40 |    0.03 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 29     | Random     |    61.48 ns |   1.297 ns |   1.150 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 29     | Random     |   109.15 ns |   2.300 ns |   2.039 ns |  0.08 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 29     | Random     |   112.68 ns |   2.977 ns |   2.639 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Sorted**     |    **85.60 ns** |   **4.410 ns** |   **3.443 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 29     | Sorted     |   955.63 ns |  21.735 ns |  19.268 ns | 11.18 |    0.53 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Sorted     |    94.26 ns |   2.473 ns |   2.065 ns |  1.10 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 29     | Sorted     |   946.59 ns |  20.332 ns |  16.978 ns | 11.08 |    0.51 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Sorted     |    61.50 ns |   2.080 ns |   1.844 ns |  0.72 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 29     | Sorted     |   893.67 ns |   3.217 ns |   2.511 ns | 10.46 |    0.45 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Reversed**   |   **103.77 ns** |   **9.752 ns** |   **8.645 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 29     | Reversed   | 1,322.26 ns |  29.946 ns |  26.546 ns | 12.84 |    1.20 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Reversed   |   113.11 ns |   1.986 ns |   1.761 ns |  1.10 |    0.10 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 29     | Reversed   | 1,331.81 ns |  14.604 ns |  12.946 ns | 12.93 |    1.19 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Reversed   |    64.42 ns |   2.596 ns |   2.301 ns |  0.63 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 29     | Reversed   |   926.09 ns |  23.313 ns |  20.667 ns |  8.99 |    0.84 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Duplicates** |   **109.39 ns** |   **4.548 ns** |   **4.032 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 29     | Duplicates | 2,759.89 ns | 210.158 ns | 186.300 ns | 25.26 |    1.89 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Duplicates |   109.49 ns |   4.476 ns |   3.968 ns |  1.00 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 29     | Duplicates | 2,953.64 ns |  50.295 ns |  44.585 ns | 27.04 |    1.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Duplicates |    60.63 ns |   2.042 ns |   1.594 ns |  0.56 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 29     | Duplicates | 1,312.56 ns |  16.893 ns |  14.975 ns | 12.01 |    0.46 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **30**     | **Random**     | **1,495.55 ns** |  **51.701 ns** |  **45.831 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 30     | Random     |   119.86 ns |   3.391 ns |   2.832 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 30     | Random     | 1,850.11 ns | 132.928 ns | 117.838 ns |  1.24 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 30     | Random     | 1,808.75 ns | 187.557 ns | 175.441 ns |  1.21 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 30     | Random     |   117.54 ns |   3.596 ns |   3.188 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 30     | Random     | 1,604.08 ns |  57.330 ns |  50.821 ns |  1.07 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 30     | Random     | 1,545.36 ns |  95.038 ns |  84.249 ns |  1.03 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 30     | Random     | 1,597.03 ns |  95.768 ns |  84.896 ns |  1.07 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 30     | Random     | 2,561.72 ns |  66.344 ns |  58.813 ns |  1.71 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 30     | Random     | 1,599.76 ns | 126.977 ns | 112.561 ns |  1.07 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 30     | Random     | 1,575.20 ns | 117.176 ns | 103.873 ns |  1.05 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 30     | Random     | 1,279.31 ns | 167.519 ns | 148.501 ns |  0.86 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 30     | Random     |   118.82 ns |   7.264 ns |   6.066 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 30     | Random     |   139.51 ns |   3.038 ns |   2.537 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 30     | Random     | 1,493.08 ns | 104.476 ns |  87.242 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 30     | Random     | 1,534.37 ns |  43.609 ns |  38.658 ns |  1.03 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 30     | Random     |   121.64 ns |   3.187 ns |   2.826 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 30     | Random     | 1,737.48 ns | 232.112 ns | 217.118 ns |  1.16 |    0.15 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 30     | Random     | 1,817.94 ns | 143.838 ns | 127.509 ns |  1.22 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Random     |   119.96 ns |   3.861 ns |   3.422 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 30     | Random     | 1,512.93 ns | 133.516 ns | 118.359 ns |  1.01 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 30     | Random     | 1,530.92 ns | 138.950 ns | 123.175 ns |  1.02 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 30     | Random     | 1,562.17 ns | 125.486 ns | 111.240 ns |  1.05 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 30     | Random     | 2,551.24 ns |  87.291 ns |  77.381 ns |  1.71 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 30     | Random     | 1,628.49 ns |  42.543 ns |  37.713 ns |  1.09 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 30     | Random     | 1,512.12 ns | 139.777 ns | 123.909 ns |  1.01 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 30     | Random     | 1,297.74 ns | 169.042 ns | 149.852 ns |  0.87 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 30     | Random     |   119.18 ns |   8.455 ns |   7.495 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 30     | Random     |   138.53 ns |   4.154 ns |   3.682 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 30     | Random     | 1,451.64 ns | 107.367 ns |  95.178 ns |  0.97 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 30     | Random     |    40.19 ns |   1.018 ns |   0.903 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 30     | Random     |   109.66 ns |   2.347 ns |   2.081 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 30     | Random     |   129.95 ns |   2.043 ns |   1.706 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 30     | Random     |    72.21 ns |   1.964 ns |   1.741 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Random     |    63.01 ns |   2.180 ns |   1.933 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 30     | Random     |   119.10 ns |   2.106 ns |   1.867 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 30     | Random     |   128.02 ns |  16.106 ns |  13.449 ns |  0.09 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 30     | Random     |   123.02 ns |   2.179 ns |   1.819 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 30     | Random     |   965.72 ns |   8.284 ns |   6.917 ns |  0.65 |    0.02 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 30     | Random     |    44.02 ns |   1.763 ns |   1.563 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 30     | Random     |   115.54 ns |   2.526 ns |   2.239 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 30     | Random     |   587.16 ns |   3.943 ns |   3.495 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 30     | Random     |    58.88 ns |   2.185 ns |   1.937 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.21 ns |   2.369 ns |   1.978 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 30     | Random     |   115.57 ns |   2.259 ns |   2.002 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Sorted**     |    **89.66 ns** |   **2.601 ns** |   **2.305 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 30     | Sorted     |   897.92 ns |   7.859 ns |   6.136 ns | 10.02 |    0.26 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Sorted     |    91.80 ns |   9.122 ns |   8.086 ns |  1.02 |    0.09 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 30     | Sorted     |   926.25 ns |  12.606 ns |  11.175 ns | 10.34 |    0.29 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Sorted     |    63.27 ns |   2.665 ns |   2.363 ns |  0.71 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 30     | Sorted     |   933.12 ns |   7.074 ns |   5.907 ns | 10.41 |    0.27 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Reversed**   |   **105.61 ns** |   **4.839 ns** |   **4.290 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 30     | Reversed   | 1,375.04 ns |  33.114 ns |  29.355 ns | 13.04 |    0.62 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Reversed   |   119.17 ns |   3.291 ns |   2.917 ns |  1.13 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 30     | Reversed   | 1,389.41 ns |  18.607 ns |  16.495 ns | 13.18 |    0.59 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Reversed   |    61.39 ns |   2.247 ns |   1.992 ns |  0.58 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 30     | Reversed   |   958.79 ns |  24.022 ns |  20.059 ns |  9.09 |    0.43 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Duplicates** |   **116.36 ns** |   **2.131 ns** |   **1.889 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 30     | Duplicates | 2,263.06 ns | 200.316 ns | 177.575 ns | 19.45 |    1.51 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Duplicates |   120.86 ns |   3.596 ns |   3.188 ns |  1.04 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 30     | Duplicates | 2,312.66 ns | 166.850 ns | 147.908 ns | 19.88 |    1.27 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Duplicates |    62.71 ns |   2.198 ns |   1.949 ns |  0.54 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 30     | Duplicates | 1,433.12 ns |  68.508 ns |  60.731 ns | 12.32 |    0.54 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **31**     | **Random**     | **1,644.91 ns** |  **97.714 ns** |  **86.621 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 31     | Random     |   128.49 ns |   3.045 ns |   2.700 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 31     | Random     | 2,035.94 ns | 150.446 ns | 133.366 ns |  1.24 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 31     | Random     | 2,000.30 ns | 111.224 ns |  98.597 ns |  1.22 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 31     | Random     |   145.21 ns |   5.395 ns |   4.783 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 31     | Random     | 1,821.57 ns |  34.819 ns |  27.185 ns |  1.11 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 31     | Random     | 1,706.76 ns | 129.241 ns | 114.569 ns |  1.04 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 31     | Random     | 1,730.80 ns | 128.655 ns | 114.049 ns |  1.06 |    0.09 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 31     | Random     | 2,715.38 ns | 114.535 ns | 101.532 ns |  1.66 |    0.11 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 31     | Random     | 1,725.63 ns | 111.459 ns |  98.806 ns |  1.05 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 31     | Random     | 1,784.01 ns | 111.337 ns |  98.698 ns |  1.09 |    0.08 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 31     | Random     | 1,407.49 ns | 113.639 ns | 100.738 ns |  0.86 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 31     | Random     |   141.15 ns |   5.605 ns |   4.968 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 31     | Random     |   196.12 ns |   4.866 ns |   4.313 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 31     | Random     | 1,661.12 ns | 109.513 ns |  97.080 ns |  1.01 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 31     | Random     | 1,690.26 ns |  57.876 ns |  51.306 ns |  1.03 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 31     | Random     |   129.81 ns |   6.419 ns |   5.012 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 31     | Random     | 1,921.84 ns | 165.486 ns | 146.699 ns |  1.17 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 31     | Random     | 1,924.73 ns | 140.496 ns | 124.546 ns |  1.17 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Random     |   144.71 ns |  10.236 ns |   7.992 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 31     | Random     | 1,811.37 ns |  52.702 ns |  46.719 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 31     | Random     | 1,767.64 ns | 102.993 ns |  91.301 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 31     | Random     | 1,797.01 ns |  76.229 ns |  67.575 ns |  1.10 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 31     | Random     | 2,760.44 ns |  76.371 ns |  63.773 ns |  1.68 |    0.10 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 31     | Random     | 1,867.63 ns |  51.000 ns |  45.210 ns |  1.14 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 31     | Random     | 1,797.67 ns |  79.754 ns |  70.700 ns |  1.10 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 31     | Random     | 1,318.34 ns | 174.808 ns | 154.963 ns |  0.80 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 31     | Random     |   137.72 ns |   7.927 ns |   7.027 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 31     | Random     |   173.31 ns |  36.922 ns |  32.731 ns |  0.11 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 31     | Random     | 1,743.43 ns |  79.753 ns |  70.699 ns |  1.06 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 31     | Random     |    37.87 ns |   1.719 ns |   1.524 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 31     | Random     |   109.25 ns |   2.025 ns |   1.795 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 31     | Random     |   128.56 ns |   2.881 ns |   2.406 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 31     | Random     |    70.01 ns |   1.760 ns |   1.560 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Random     |    58.21 ns |   1.633 ns |   1.363 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 31     | Random     |   119.15 ns |   2.842 ns |   2.373 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 31     | Random     |   124.38 ns |   2.626 ns |   2.193 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 31     | Random     |   123.76 ns |   2.345 ns |   2.079 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 31     | Random     |   989.36 ns |  14.024 ns |  12.432 ns |  0.60 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 31     | Random     |    40.83 ns |   1.244 ns |   1.103 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 31     | Random     |   114.65 ns |   2.511 ns |   2.097 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 31     | Random     |   599.63 ns |   6.506 ns |   5.079 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 31     | Random     |    56.70 ns |   2.362 ns |   1.972 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 31     | Random     |   117.64 ns |   2.243 ns |   1.988 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 31     | Random     |   115.82 ns |   2.359 ns |   2.091 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Sorted**     |    **87.43 ns** |   **2.251 ns** |   **1.879 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 31     | Sorted     |   927.11 ns |  25.321 ns |  22.446 ns | 10.61 |    0.33 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Sorted     |    96.47 ns |   2.717 ns |   2.269 ns |  1.10 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 31     | Sorted     |   953.05 ns |  15.420 ns |  13.670 ns | 10.91 |    0.27 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Sorted     |    58.30 ns |   2.259 ns |   2.003 ns |  0.67 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 31     | Sorted     |   994.99 ns |  12.890 ns |  11.427 ns | 11.39 |    0.27 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Reversed**   |   **115.79 ns** |   **4.720 ns** |   **4.184 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 31     | Reversed   | 1,410.19 ns |  21.840 ns |  19.361 ns | 12.19 |    0.46 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Reversed   |   120.03 ns |   2.136 ns |   1.894 ns |  1.04 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 31     | Reversed   | 1,430.34 ns |  27.255 ns |  24.161 ns | 12.37 |    0.48 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Reversed   |    57.54 ns |   2.211 ns |   1.727 ns |  0.50 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 31     | Reversed   |   982.12 ns |   6.186 ns |   5.166 ns |  8.49 |    0.30 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Duplicates** |   **125.14 ns** |   **3.036 ns** |   **2.691 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 31     | Duplicates | 2,688.37 ns | 228.340 ns | 213.589 ns | 21.49 |    1.72 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Duplicates |   129.02 ns |   8.458 ns |   7.063 ns |  1.03 |    0.06 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 31     | Duplicates | 2,720.04 ns | 217.712 ns | 203.648 ns | 21.74 |    1.64 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Duplicates |    58.00 ns |   2.027 ns |   1.797 ns |  0.46 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 31     | Duplicates | 1,441.49 ns |  26.663 ns |  23.636 ns | 11.52 |    0.30 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **32**     | **Random**     | **1,694.21 ns** |  **66.484 ns** |  **58.937 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 32     | Random     |   130.00 ns |   7.087 ns |   6.282 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 32     | Random     | 2,040.70 ns | 114.532 ns |  95.640 ns |  1.21 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 32     | Random     | 2,084.60 ns | 103.237 ns |  91.517 ns |  1.23 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 32     | Random     |   153.77 ns |   2.950 ns |   2.464 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 32     | Random     | 1,916.09 ns |  36.226 ns |  32.114 ns |  1.13 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 32     | Random     | 1,814.85 ns | 151.275 ns | 134.101 ns |  1.07 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 32     | Random     | 1,814.03 ns | 141.823 ns | 125.722 ns |  1.07 |    0.08 |         - |          NA |
| RecordSortingBenchmarks | ArraySort     | 32     | Random     | 2,908.03 ns |  83.667 ns |  74.169 ns |  1.72 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 32     | Random     | 1,850.67 ns | 118.758 ns |  99.169 ns |  1.09 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 32     | Random     | 1,847.11 ns |  89.422 ns |  79.271 ns |  1.09 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 32     | Random     | 1,298.75 ns | 142.588 ns | 126.401 ns |  0.77 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 32     | Random     |   148.62 ns |   5.361 ns |   4.752 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 32     | Random     |   202.80 ns |  35.019 ns |  31.044 ns |  0.12 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 32     | Random     | 1,703.12 ns | 118.247 ns | 104.823 ns |  1.01 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 32     | Random     | 1,678.88 ns | 143.825 ns | 127.497 ns |  0.99 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 32     | Random     |   134.81 ns |   3.509 ns |   2.739 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 32     | Random     | 2,001.35 ns | 187.607 ns | 175.488 ns |  1.18 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 32     | Random     | 2,023.56 ns | 134.262 ns | 119.020 ns |  1.20 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Random     |   159.16 ns |  10.375 ns |   9.197 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 32     | Random     | 1,866.33 ns |  68.658 ns |  60.863 ns |  1.10 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 32     | Random     | 1,829.17 ns |  82.943 ns |  69.262 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 32     | Random     | 1,868.02 ns |  53.260 ns |  47.214 ns |  1.10 |    0.05 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 32     | Random     | 2,966.11 ns |  77.468 ns |  68.673 ns |  1.75 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 32     | Random     | 1,991.34 ns |  75.356 ns |  66.801 ns |  1.18 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 32     | Random     | 1,789.29 ns | 117.707 ns | 104.344 ns |  1.06 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 32     | Random     | 1,305.50 ns | 115.582 ns | 102.461 ns |  0.77 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 32     | Random     |   142.70 ns |   8.358 ns |   7.409 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 32     | Random     |   205.79 ns |  22.052 ns |  19.549 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 32     | Random     | 1,617.60 ns | 128.882 ns | 114.251 ns |  0.96 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 32     | Random     |    36.50 ns |   1.357 ns |   1.133 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 32     | Random     |   111.69 ns |   2.101 ns |   1.863 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 32     | Random     |   124.58 ns |   2.998 ns |   2.340 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 32     | Random     |    69.34 ns |   1.892 ns |   1.677 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Random     |    60.00 ns |   3.752 ns |   3.326 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 32     | Random     |   124.10 ns |   2.503 ns |   2.218 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 32     | Random     |   129.31 ns |   2.417 ns |   2.143 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 32     | Random     |   125.94 ns |   2.866 ns |   2.238 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 32     | Random     | 1,015.57 ns |   5.058 ns |   3.949 ns |  0.60 |    0.02 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 32     | Random     |    40.18 ns |   6.172 ns |   4.819 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 32     | Random     |   120.55 ns |   1.934 ns |   1.715 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 32     | Random     |   626.83 ns |  13.450 ns |  11.923 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 32     | Random     |    55.18 ns |   1.837 ns |   1.628 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 32     | Random     |   122.39 ns |   2.424 ns |   2.149 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 32     | Random     |   122.63 ns |   3.388 ns |   3.004 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Sorted**     |    **91.34 ns** |   **2.205 ns** |   **1.955 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 32     | Sorted     |   947.11 ns |  16.462 ns |  13.746 ns | 10.37 |    0.26 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Sorted     |   100.78 ns |   2.670 ns |   2.367 ns |  1.10 |    0.03 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 32     | Sorted     |   956.04 ns |  26.298 ns |  23.312 ns | 10.47 |    0.33 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Sorted     |    56.91 ns |   2.033 ns |   1.587 ns |  0.62 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 32     | Sorted     |   985.76 ns |  11.419 ns |   9.535 ns | 10.80 |    0.25 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Reversed**   |   **116.74 ns** |   **4.014 ns** |   **3.558 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 32     | Reversed   | 1,596.93 ns |  27.430 ns |  24.316 ns | 13.69 |    0.45 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Reversed   |   123.06 ns |   9.657 ns |   8.064 ns |  1.06 |    0.07 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 32     | Reversed   | 1,510.51 ns |  18.880 ns |  16.737 ns | 12.95 |    0.41 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Reversed   |    56.42 ns |   2.347 ns |   1.960 ns |  0.48 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 32     | Reversed   | 1,062.18 ns |  13.129 ns |  10.963 ns |  9.11 |    0.28 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Duplicates** |   **120.56 ns** |   **4.059 ns** |   **3.598 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| RecordSortingBenchmarks | ArraySort     | 32     | Duplicates | 2,788.26 ns |  72.031 ns |  63.853 ns | 23.15 |    0.85 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Duplicates |   127.93 ns |   3.044 ns |   2.699 ns |  1.06 |    0.04 |         - |          NA |
| RecordSortingBenchmarks | SpanSort      | 32     | Duplicates | 2,901.88 ns |  96.860 ns |  75.622 ns | 24.09 |    0.93 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Duplicates |    57.59 ns |   2.199 ns |   1.836 ns |  0.48 |    0.02 |         - |          NA |
| RecordSortingBenchmarks | GeneratedSort | 32     | Duplicates | 1,459.09 ns |  15.596 ns |  13.023 ns | 12.11 |    0.37 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **34**     | **Random**     | **1,899.73 ns** |  **94.576 ns** |  **83.839 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| ByteSortingBenchmarks   | SpanSort      | 34     | Random     | 1,982.03 ns |  35.786 ns |  31.723 ns |  1.05 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 34     | Random     |   131.60 ns |   2.515 ns |   2.230 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **FloatSortingBenchmarks**  | **ArraySort**     | **36**     | **Random**     | **2,124.59 ns** | **225.601 ns** | **211.028 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| FloatSortingBenchmarks  | SpanSort      | 36     | Random     | 2,146.79 ns | 184.189 ns | 163.279 ns |  1.02 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 36     | Random     |    90.08 ns |   1.714 ns |   1.519 ns |  0.04 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **SByteSortingBenchmarks**  | **ArraySort**     | **38**     | **Random**     | **2,439.66 ns** | **169.083 ns** | **149.888 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| SByteSortingBenchmarks  | SpanSort      | 38     | Random     | 2,585.29 ns |  37.422 ns |  33.174 ns |  1.06 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 38     | Random     |   155.11 ns |   2.759 ns |   2.446 ns |  0.06 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ShortSortingBenchmarks**  | **ArraySort**     | **40**     | **Random**     | **2,348.08 ns** | **140.628 ns** | **109.793 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| ShortSortingBenchmarks  | SpanSort      | 40     | Random     | 2,372.89 ns | 166.599 ns | 147.686 ns |  1.01 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 40     | Random     |   164.75 ns |   2.370 ns |   2.101 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **UShortSortingBenchmarks** | **ArraySort**     | **42**     | **Random**     | **3,223.97 ns** | **126.281 ns** | **111.945 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| UShortSortingBenchmarks | SpanSort      | 42     | Random     | 2,376.46 ns | 170.141 ns | 150.825 ns |  0.74 |    0.05 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 42     | Random     |   170.84 ns |   3.005 ns |   2.509 ns |  0.05 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **DoubleSortingBenchmarks** | **ArraySort**     | **44**     | **Random**     | **3,613.57 ns** | **239.534 ns** | **224.060 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| DoubleSortingBenchmarks | SpanSort      | 44     | Random     | 3,261.42 ns | 219.386 ns | 205.213 ns |  0.91 |    0.08 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 44     | Random     |   246.57 ns |   2.275 ns |   1.900 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Random**     |   **315.77 ns** |  **17.706 ns** |  **15.696 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Random     |   303.10 ns |  35.165 ns |  31.173 ns |  0.96 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Random     |   110.48 ns |   2.638 ns |   2.060 ns |  0.35 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Sorted**     |   **175.27 ns** |   **2.093 ns** |   **1.748 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Sorted     |   182.48 ns |  14.700 ns |  12.275 ns |  1.04 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Sorted     |   111.81 ns |   2.615 ns |   2.318 ns |  0.64 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Reversed**   |   **237.66 ns** |   **4.218 ns** |   **3.739 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Reversed   |   241.29 ns |  18.047 ns |  15.998 ns |  1.02 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Reversed   |   112.59 ns |   3.376 ns |   2.993 ns |  0.47 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Duplicates** |   **208.23 ns** |  **12.728 ns** |  **11.283 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Duplicates |   222.04 ns |   5.645 ns |   5.004 ns |  1.07 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Duplicates |   112.99 ns |   1.791 ns |   1.587 ns |  0.54 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **UIntSortingBenchmarks**   | **ArraySort**     | **50**     | **Random**     |   **279.66 ns** |  **14.502 ns** |  **12.855 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| UIntSortingBenchmarks   | SpanSort      | 50     | Random     |   301.59 ns |   6.976 ns |   6.184 ns |  1.08 |    0.05 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 50     | Random     |   223.67 ns |  25.057 ns |  20.924 ns |  0.80 |    0.08 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **LongSortingBenchmarks**   | **ArraySort**     | **52**     | **Random**     | **3,781.78 ns** | **168.468 ns** | **149.342 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| LongSortingBenchmarks   | SpanSort      | 52     | Random     | 3,863.56 ns | 153.483 ns | 136.058 ns |  1.02 |    0.05 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 52     | Random     |   249.94 ns |   3.236 ns |   2.702 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ULongSortingBenchmarks**  | **ArraySort**     | **54**     | **Random**     |   **470.17 ns** |  **89.288 ns** |  **79.151 ns** |  **1.04** |    **0.31** |         **-** |          **NA** |
| ULongSortingBenchmarks  | SpanSort      | 54     | Random     |   412.81 ns | 114.894 ns | 101.850 ns |  0.91 |    0.32 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 54     | Random     |   262.42 ns |   3.890 ns |   3.037 ns |  0.58 |    0.14 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **NIntSortingBenchmarks**   | **ArraySort**     | **56**     | **Random**     | **4,080.88 ns** | **190.403 ns** | **168.787 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NIntSortingBenchmarks   | SpanSort      | 56     | Random     | 4,088.46 ns | 244.054 ns | 216.348 ns |  1.00 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 56     | Random     |   282.85 ns |   2.807 ns |   2.344 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **NUIntSortingBenchmarks**  | **ArraySort**     | **58**     | **Random**     | **3,859.05 ns** | **327.950 ns** | **306.765 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NUIntSortingBenchmarks  | SpanSort      | 58     | Random     | 3,929.88 ns | 284.171 ns | 251.910 ns |  1.02 |    0.11 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 58     | Random     |   307.97 ns |   3.111 ns |   2.598 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **60**     | **Random**     |   **359.66 ns** |   **4.635 ns** |   **3.619 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| CharSortingBenchmarks   | SpanSort      | 60     | Random     |   395.12 ns |   5.343 ns |   4.736 ns |  1.10 |    0.02 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 60     | Random     |   258.85 ns |   1.855 ns |   1.549 ns |  0.72 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **StringSortingBenchmarks** | **ArraySort**     | **64**     | **Random**     | **3,541.81 ns** | **537.865 ns** | **476.803 ns** |  **1.02** |    **0.22** |      **64 B** |        **1.00** |
| StringSortingBenchmarks | SpanSort      | 64     | Random     | 3,458.51 ns | 629.832 ns | 558.329 ns |  1.00 |    0.24 |      64 B |        1.00 |
| StringSortingBenchmarks | GeneratedSort | 64     | Random     | 1,898.11 ns |  30.260 ns |  26.824 ns |  0.55 |    0.10 |         - |        0.00 |

