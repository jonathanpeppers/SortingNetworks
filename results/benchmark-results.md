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
| **CharSortingBenchmarks**   | **ArraySort**     | **8**      | **Random**     |    **29.15 ns** |   **1.894 ns** |   **1.679 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 8      | Random     |   303.14 ns |  10.430 ns |   9.246 ns | 10.43 |    0.67 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 8      | Random     |   272.29 ns |  15.392 ns |  13.645 ns |  9.37 |    0.70 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 8      | Random     |    34.95 ns |   2.955 ns |   2.620 ns |  1.20 |    0.11 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 8      | Random     |   304.90 ns |   9.155 ns |   7.645 ns | 10.49 |    0.65 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 8      | Random     |   279.87 ns |  10.821 ns |   9.592 ns |  9.63 |    0.64 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 8      | Random     |    20.91 ns |   0.866 ns |   0.767 ns |  0.72 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 8      | Random     |    23.79 ns |   0.878 ns |   0.778 ns |  0.82 |    0.05 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 8      | Random     |    23.93 ns |   1.308 ns |   1.159 ns |  0.82 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **16**     | **Random**     |    **69.06 ns** |   **2.873 ns** |   **2.547 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| ShortSortingBenchmarks  | ArraySort     | 16     | Random     |   925.88 ns |   6.704 ns |   5.598 ns | 13.42 |    0.49 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 16     | Random     |   838.33 ns |  16.305 ns |  13.615 ns | 12.16 |    0.48 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 16     | Random     |    72.84 ns |   2.910 ns |   2.579 ns |  1.06 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 16     | Random     |   922.34 ns |   9.945 ns |   8.304 ns | 13.37 |    0.49 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 16     | Random     |   798.66 ns |   7.952 ns |   7.050 ns | 11.58 |    0.43 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 16     | Random     |    30.73 ns |   1.087 ns |   0.964 ns |  0.45 |    0.02 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 16     | Random     |    33.56 ns |   1.448 ns |   1.284 ns |  0.49 |    0.03 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 16     | Random     |    34.67 ns |   1.317 ns |   1.168 ns |  0.50 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **23**     | **Random**     | **1,107.14 ns** |  **52.482 ns** |  **46.524 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 23     | Random     |    76.76 ns |   3.084 ns |   2.734 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 23     | Random     | 1,461.49 ns |  83.827 ns |  69.999 ns |  1.32 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 23     | Random     | 1,362.83 ns |  88.199 ns |  68.860 ns |  1.23 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 23     | Random     |    92.85 ns |   6.177 ns |   5.476 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 23     | Random     | 1,210.51 ns |  30.064 ns |  26.651 ns |  1.10 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 23     | Random     | 1,231.60 ns |  32.279 ns |  28.614 ns |  1.11 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 23     | Random     | 1,190.91 ns |  50.023 ns |  44.344 ns |  1.08 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 23     | Random     | 1,239.61 ns |  28.804 ns |  25.534 ns |  1.12 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 23     | Random     | 1,222.59 ns |  36.772 ns |  32.597 ns |  1.11 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 23     | Random     |   926.62 ns | 124.133 ns | 110.041 ns |  0.84 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 23     | Random     |    98.68 ns |   4.284 ns |   3.798 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 23     | Random     |   123.84 ns |   4.112 ns |   3.645 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 23     | Random     | 1,112.12 ns |  89.176 ns |  79.052 ns |  1.01 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 23     | Random     | 1,110.82 ns |  85.264 ns |  75.584 ns |  1.01 |    0.08 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 23     | Random     |    80.22 ns |   3.209 ns |   2.845 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 23     | Random     | 1,325.13 ns | 102.132 ns |  90.538 ns |  1.20 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 23     | Random     | 1,356.62 ns | 117.911 ns |  98.461 ns |  1.23 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 23     | Random     |    97.92 ns |   3.999 ns |   3.545 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 23     | Random     | 1,224.89 ns |  37.442 ns |  33.191 ns |  1.11 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 23     | Random     | 1,224.80 ns |  37.941 ns |  33.634 ns |  1.11 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 23     | Random     | 1,169.32 ns |  76.180 ns |  67.531 ns |  1.06 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 23     | Random     | 1,231.34 ns |  46.073 ns |  40.843 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 23     | Random     | 1,191.36 ns |  51.920 ns |  46.026 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 23     | Random     |   945.81 ns | 136.904 ns | 121.362 ns |  0.86 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 23     | Random     |    94.00 ns |   5.270 ns |   4.672 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 23     | Random     |   112.73 ns |  12.241 ns |  10.852 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 23     | Random     | 1,092.82 ns |  28.613 ns |  25.365 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 23     | Random     |    34.52 ns |   1.097 ns |   0.973 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 23     | Random     |    81.93 ns |   1.991 ns |   1.765 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 23     | Random     |    95.41 ns |   4.005 ns |   3.344 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 23     | Random     |    60.40 ns |   1.221 ns |   1.082 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Random     |    48.67 ns |   1.440 ns |   1.202 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 23     | Random     |    91.84 ns |   2.236 ns |   1.982 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    94.14 ns |   2.237 ns |   1.983 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 23     | Random     |    94.14 ns |   2.111 ns |   1.871 ns |  0.09 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 23     | Random     |    37.73 ns |   1.247 ns |   1.106 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 23     | Random     |    87.11 ns |   2.029 ns |   1.799 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 23     | Random     |   392.84 ns |   5.161 ns |   4.575 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    48.18 ns |   1.855 ns |   1.644 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 23     | Random     |    85.76 ns |   1.841 ns |   1.632 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 23     | Random     |    87.44 ns |   2.207 ns |   1.956 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Sorted**     |    **61.89 ns** |   **2.115 ns** |   **1.874 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Sorted     |    65.38 ns |   2.571 ns |   2.279 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Sorted     |    50.89 ns |   1.830 ns |   1.622 ns |  0.82 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Reversed**   |    **86.61 ns** |   **3.629 ns** |   **3.030 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Reversed   |    92.60 ns |   3.232 ns |   2.865 ns |  1.07 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Reversed   |    50.99 ns |   2.054 ns |   1.821 ns |  0.59 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **23**     | **Duplicates** |    **87.06 ns** |   **2.282 ns** |   **2.023 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 23     | Duplicates |    93.24 ns |   5.991 ns |   5.310 ns |  1.07 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 23     | Duplicates |    49.37 ns |   3.195 ns |   2.833 ns |  0.57 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **24**     | **Random**     | **1,234.24 ns** |  **76.755 ns** |  **68.042 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 24     | Random     |   126.77 ns |   3.115 ns |   2.601 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 24     | Random     | 1,552.44 ns |  96.842 ns |  85.848 ns |  1.26 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 24     | Random     | 1,443.63 ns | 149.463 ns | 139.808 ns |  1.17 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 24     | Random     |   109.64 ns |   7.508 ns |   6.656 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 24     | Random     | 1,304.69 ns | 100.686 ns |  89.256 ns |  1.06 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 24     | Random     | 1,351.66 ns |  31.743 ns |  28.140 ns |  1.10 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 24     | Random     | 1,331.39 ns |  46.650 ns |  41.354 ns |  1.08 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 24     | Random     | 1,395.33 ns |  32.755 ns |  29.036 ns |  1.13 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 24     | Random     | 1,318.19 ns |  42.394 ns |  37.582 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 24     | Random     | 1,084.34 ns |  72.973 ns |  64.689 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 24     | Random     |   112.85 ns |   4.088 ns |   3.624 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 24     | Random     |   124.34 ns |   9.304 ns |   7.769 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 24     | Random     | 1,245.31 ns |  59.773 ns |  52.988 ns |  1.01 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 24     | Random     | 1,268.36 ns |  38.525 ns |  34.152 ns |  1.03 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 24     | Random     |   124.85 ns |   7.523 ns |   6.282 ns |  0.10 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 24     | Random     | 1,476.70 ns | 160.609 ns | 150.233 ns |  1.20 |    0.14 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 24     | Random     | 1,504.95 ns | 114.692 ns | 101.671 ns |  1.22 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 24     | Random     |   112.46 ns |   3.350 ns |   2.970 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 24     | Random     | 1,341.04 ns |  51.525 ns |  45.675 ns |  1.09 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 24     | Random     | 1,313.35 ns |  96.164 ns |  85.247 ns |  1.07 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 24     | Random     | 1,355.54 ns |  34.058 ns |  30.192 ns |  1.10 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 24     | Random     | 1,406.56 ns |  33.988 ns |  30.130 ns |  1.14 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 24     | Random     | 1,361.32 ns |  85.490 ns |  75.785 ns |  1.11 |    0.09 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 24     | Random     | 1,039.09 ns | 124.214 ns | 110.113 ns |  0.84 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 24     | Random     |   110.32 ns |   3.573 ns |   2.984 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 24     | Random     |   124.49 ns |   4.223 ns |   3.744 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 24     | Random     | 1,215.28 ns |  48.220 ns |  42.746 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 24     | Random     |    36.40 ns |   1.364 ns |   1.209 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 24     | Random     |    79.51 ns |   1.710 ns |   1.516 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 24     | Random     |   107.38 ns |   1.431 ns |   1.195 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 24     | Random     |    62.99 ns |   3.323 ns |   2.775 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Random     |    53.02 ns |   2.062 ns |   1.828 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 24     | Random     |    87.81 ns |   3.044 ns |   2.699 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    91.96 ns |   2.279 ns |   2.020 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 24     | Random     |    92.08 ns |   2.269 ns |   1.894 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 24     | Random     |    39.82 ns |   1.524 ns |   1.272 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 24     | Random     |    86.94 ns |   2.626 ns |   2.328 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 24     | Random     |   415.45 ns |   3.852 ns |   3.415 ns |  0.34 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    51.39 ns |   2.572 ns |   2.280 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 24     | Random     |    84.54 ns |   1.672 ns |   1.483 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 24     | Random     |    84.29 ns |   2.285 ns |   1.908 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Sorted**     |    **76.74 ns** |   **2.114 ns** |   **1.874 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Sorted     |    79.68 ns |   2.210 ns |   1.845 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Sorted     |    51.52 ns |   1.689 ns |   1.410 ns |  0.67 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Reversed**   |    **91.88 ns** |   **4.015 ns** |   **3.352 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Reversed   |    99.51 ns |   2.696 ns |   2.390 ns |  1.08 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Reversed   |    53.34 ns |   2.153 ns |   1.909 ns |  0.58 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **24**     | **Duplicates** |    **94.56 ns** |   **3.721 ns** |   **3.299 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 24     | Duplicates |   100.14 ns |   6.242 ns |   5.213 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 24     | Duplicates |    54.02 ns |   2.393 ns |   2.121 ns |  0.57 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **25**     | **Random**     | **1,178.76 ns** |  **36.302 ns** |  **30.314 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 25     | Random     |   119.54 ns |   1.813 ns |   1.607 ns |  0.10 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 25     | Random     | 1,461.89 ns |  79.470 ns |  66.361 ns |  1.24 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 25     | Random     | 1,346.98 ns | 134.590 ns | 119.311 ns |  1.14 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 25     | Random     |   102.42 ns |   3.982 ns |   3.530 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 25     | Random     | 1,246.74 ns |  65.448 ns |  58.018 ns |  1.06 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 25     | Random     | 1,254.97 ns |  83.565 ns |  74.078 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 25     | Random     | 1,276.74 ns |  34.004 ns |  30.144 ns |  1.08 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 25     | Random     | 1,309.24 ns |  70.738 ns |  62.708 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 25     | Random     | 1,245.51 ns |  44.502 ns |  39.450 ns |  1.06 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 25     | Random     |   972.10 ns | 116.162 ns | 102.974 ns |  0.83 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 25     | Random     |   110.10 ns |   2.946 ns |   2.612 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 25     | Random     |   118.19 ns |   7.066 ns |   5.901 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 25     | Random     | 1,200.28 ns |  68.373 ns |  57.094 ns |  1.02 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 25     | Random     | 1,204.26 ns |  35.364 ns |  31.349 ns |  1.02 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 25     | Random     |   124.51 ns |   9.001 ns |   7.979 ns |  0.11 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 25     | Random     | 1,305.73 ns | 129.376 ns | 114.689 ns |  1.11 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 25     | Random     | 1,427.22 ns | 106.906 ns |  94.769 ns |  1.21 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 25     | Random     |   110.78 ns |   4.297 ns |   3.809 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 25     | Random     | 1,288.36 ns |  35.289 ns |  31.282 ns |  1.09 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 25     | Random     | 1,218.60 ns |  99.929 ns |  88.584 ns |  1.03 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 25     | Random     | 1,233.41 ns |  65.721 ns |  58.260 ns |  1.05 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 25     | Random     | 1,308.64 ns |  36.400 ns |  32.268 ns |  1.11 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 25     | Random     | 1,262.24 ns |  37.311 ns |  33.075 ns |  1.07 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 25     | Random     |   975.09 ns | 103.544 ns |  91.789 ns |  0.83 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 25     | Random     |   108.60 ns |   4.535 ns |   4.020 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 25     | Random     |   123.81 ns |   2.717 ns |   2.268 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 25     | Random     | 1,115.84 ns |  88.348 ns |  78.319 ns |  0.95 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 25     | Random     |    37.66 ns |   1.428 ns |   1.266 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 25     | Random     |    89.00 ns |   2.077 ns |   1.734 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 25     | Random     |   113.49 ns |   7.773 ns |   6.491 ns |  0.10 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 25     | Random     |    68.13 ns |   2.334 ns |   2.069 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Random     |    57.20 ns |   1.903 ns |   1.589 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 25     | Random     |    97.36 ns |   4.913 ns |   4.356 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 25     | Random     |   100.68 ns |   2.371 ns |   2.102 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 25     | Random     |   100.77 ns |   2.328 ns |   2.064 ns |  0.09 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 25     | Random     |    41.11 ns |   1.272 ns |   1.062 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 25     | Random     |    95.99 ns |   3.141 ns |   2.784 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 25     | Random     |   441.42 ns |   2.424 ns |   1.892 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 25     | Random     |    52.66 ns |   2.475 ns |   2.194 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 25     | Random     |    93.83 ns |   1.531 ns |   1.195 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 25     | Random     |    93.82 ns |   2.774 ns |   2.166 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Sorted**     |    **81.16 ns** |   **1.829 ns** |   **1.621 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Sorted     |    88.68 ns |   3.102 ns |   2.750 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Sorted     |    55.90 ns |   2.155 ns |   1.683 ns |  0.69 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Reversed**   |    **92.01 ns** |   **3.388 ns** |   **3.004 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Reversed   |    93.57 ns |   3.391 ns |   3.006 ns |  1.02 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Reversed   |    55.04 ns |   1.960 ns |   1.738 ns |  0.60 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **25**     | **Duplicates** |    **99.24 ns** |   **2.573 ns** |   **2.281 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 25     | Duplicates |   101.88 ns |   9.414 ns |   7.861 ns |  1.03 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 25     | Duplicates |    59.19 ns |   2.032 ns |   1.801 ns |  0.60 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **26**     | **Random**     | **1,421.59 ns** |  **97.954 ns** |  **86.834 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 26     | Random     |   121.11 ns |   6.528 ns |   5.787 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 26     | Random     | 1,699.68 ns | 109.318 ns |  96.908 ns |  1.20 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 26     | Random     | 1,659.45 ns | 142.642 ns | 119.113 ns |  1.17 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 26     | Random     |   123.20 ns |   3.740 ns |   3.316 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 26     | Random     | 1,488.45 ns |  36.588 ns |  32.434 ns |  1.05 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 26     | Random     | 1,470.32 ns |  77.121 ns |  68.366 ns |  1.04 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 26     | Random     | 1,471.16 ns |  30.010 ns |  25.059 ns |  1.04 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 26     | Random     | 1,553.26 ns |  40.352 ns |  35.771 ns |  1.10 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 26     | Random     | 1,466.51 ns |  87.610 ns |  77.664 ns |  1.04 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 26     | Random     | 1,094.97 ns |  87.500 ns |  77.566 ns |  0.77 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 26     | Random     |   127.74 ns |   7.291 ns |   6.463 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 26     | Random     |   151.31 ns |  17.519 ns |  15.530 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 26     | Random     | 1,473.95 ns |  33.893 ns |  30.045 ns |  1.04 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 26     | Random     | 1,380.22 ns |  34.640 ns |  28.926 ns |  0.97 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 26     | Random     |   122.43 ns |   1.744 ns |   1.361 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 26     | Random     | 1,596.81 ns | 142.662 ns | 126.466 ns |  1.13 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 26     | Random     | 1,596.69 ns | 130.915 ns | 116.053 ns |  1.13 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 26     | Random     |   124.13 ns |   4.931 ns |   4.371 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 26     | Random     | 1,497.36 ns |  40.194 ns |  35.631 ns |  1.06 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 26     | Random     | 1,438.83 ns |  91.712 ns |  81.301 ns |  1.02 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 26     | Random     | 1,521.62 ns |  35.520 ns |  31.488 ns |  1.07 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 26     | Random     | 1,557.79 ns | 101.874 ns |  90.309 ns |  1.10 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 26     | Random     | 1,479.97 ns |  32.060 ns |  28.420 ns |  1.05 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 26     | Random     | 1,079.12 ns | 131.492 ns | 116.565 ns |  0.76 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 26     | Random     |   120.87 ns |   4.012 ns |   3.557 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 26     | Random     |   142.69 ns |   7.762 ns |   6.881 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 26     | Random     | 1,359.19 ns |  38.434 ns |  34.071 ns |  0.96 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 26     | Random     |    39.89 ns |   1.685 ns |   1.493 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 26     | Random     |    91.39 ns |   1.983 ns |   1.758 ns |  0.06 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 26     | Random     |   117.12 ns |   4.381 ns |   3.659 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 26     | Random     |    70.27 ns |   2.195 ns |   1.946 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Random     |    56.05 ns |   1.798 ns |   1.594 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 26     | Random     |    98.20 ns |   2.167 ns |   1.921 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 26     | Random     |   102.51 ns |   1.971 ns |   1.747 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 26     | Random     |   103.21 ns |   2.338 ns |   2.072 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 26     | Random     |    43.65 ns |   1.386 ns |   1.229 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 26     | Random     |    96.23 ns |   2.612 ns |   2.315 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 26     | Random     |   475.52 ns |   3.718 ns |   3.105 ns |  0.34 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 26     | Random     |    55.33 ns |   1.548 ns |   1.372 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 26     | Random     |    94.71 ns |   1.741 ns |   1.543 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 26     | Random     |    94.74 ns |   1.971 ns |   1.747 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Sorted**     |    **79.03 ns** |   **9.105 ns** |   **7.603 ns** |  **1.01** |    **0.14** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Sorted     |    89.84 ns |   1.876 ns |   1.663 ns |  1.15 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Sorted     |    56.56 ns |   1.726 ns |   1.441 ns |  0.72 |    0.08 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Reversed**   |   **103.44 ns** |   **3.515 ns** |   **3.116 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Reversed   |   106.84 ns |   3.228 ns |   2.862 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Reversed   |    57.72 ns |   1.968 ns |   1.745 ns |  0.56 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **26**     | **Duplicates** |    **96.27 ns** |   **3.050 ns** |   **2.704 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 26     | Duplicates |   100.42 ns |   3.057 ns |   2.710 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 26     | Duplicates |    60.32 ns |   2.103 ns |   1.642 ns |  0.63 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **27**     | **Random**     | **1,310.04 ns** |  **94.672 ns** |  **83.924 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 27     | Random     |    96.77 ns |   3.514 ns |   3.115 ns |  0.07 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 27     | Random     | 1,640.95 ns |  99.422 ns |  88.135 ns |  1.26 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 27     | Random     | 1,667.02 ns |  92.102 ns |  81.646 ns |  1.28 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 27     | Random     |   108.05 ns |   7.515 ns |   6.662 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 27     | Random     | 1,459.22 ns |  30.907 ns |  27.398 ns |  1.12 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 27     | Random     | 1,417.06 ns |  59.819 ns |  53.028 ns |  1.09 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 27     | Random     | 1,451.49 ns |  29.426 ns |  26.085 ns |  1.11 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 27     | Random     | 1,478.29 ns |  33.690 ns |  29.865 ns |  1.13 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 27     | Random     | 1,433.62 ns |  82.642 ns |  73.260 ns |  1.10 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 27     | Random     | 1,120.21 ns |  79.929 ns |  70.855 ns |  0.86 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 27     | Random     |   112.31 ns |   4.503 ns |   3.992 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 27     | Random     |   160.42 ns |   3.224 ns |   2.858 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 27     | Random     | 1,333.03 ns |  32.245 ns |  28.585 ns |  1.02 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 27     | Random     | 1,388.59 ns |  32.146 ns |  28.497 ns |  1.06 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 27     | Random     |   102.46 ns |   3.440 ns |   3.049 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 27     | Random     | 1,639.29 ns |  85.703 ns |  75.973 ns |  1.26 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 27     | Random     | 1,647.91 ns |  85.225 ns |  75.550 ns |  1.26 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 27     | Random     |   116.02 ns |   6.184 ns |   5.164 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 27     | Random     | 1,455.62 ns |  66.554 ns |  58.998 ns |  1.12 |    0.09 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 27     | Random     | 1,498.51 ns |  28.804 ns |  25.534 ns |  1.15 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 27     | Random     | 1,433.43 ns |  50.581 ns |  44.838 ns |  1.10 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 27     | Random     | 1,476.04 ns |  32.586 ns |  28.887 ns |  1.13 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 27     | Random     | 1,464.15 ns |  64.258 ns |  56.963 ns |  1.12 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 27     | Random     | 1,085.77 ns | 118.309 ns | 104.878 ns |  0.83 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 27     | Random     |   109.61 ns |   1.691 ns |   1.320 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 27     | Random     |   153.69 ns |   3.107 ns |   2.754 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 27     | Random     | 1,297.40 ns |  63.162 ns |  55.992 ns |  0.99 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 27     | Random     |    37.48 ns |   1.863 ns |   1.652 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 27     | Random     |    97.67 ns |   2.175 ns |   1.928 ns |  0.07 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 27     | Random     |   102.42 ns |   1.857 ns |   1.551 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 27     | Random     |    65.49 ns |   1.431 ns |   1.268 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Random     |    55.67 ns |   1.837 ns |   1.628 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 27     | Random     |   103.74 ns |   2.371 ns |   1.980 ns |  0.08 |    0.01 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 27     | Random     |   106.78 ns |   2.365 ns |   2.097 ns |  0.08 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 27     | Random     |   107.46 ns |   2.169 ns |   1.811 ns |  0.08 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 27     | Random     |    39.54 ns |   0.892 ns |   0.791 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 27     | Random     |   100.44 ns |   2.830 ns |   2.509 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 27     | Random     |   523.42 ns |   5.704 ns |   4.763 ns |  0.40 |    0.03 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 27     | Random     |    54.21 ns |   2.362 ns |   2.094 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 27     | Random     |   100.25 ns |   4.571 ns |   3.817 ns |  0.08 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 27     | Random     |    99.61 ns |   2.344 ns |   1.958 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Sorted**     |    **86.36 ns** |   **5.468 ns** |   **4.847 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Sorted     |    91.35 ns |   6.438 ns |   5.376 ns |  1.06 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Sorted     |    57.34 ns |   3.219 ns |   2.854 ns |  0.67 |    0.05 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Reversed**   |    **94.59 ns** |   **4.517 ns** |   **4.004 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Reversed   |   100.97 ns |   7.203 ns |   6.386 ns |  1.07 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Reversed   |    57.29 ns |   3.605 ns |   3.011 ns |  0.61 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **27**     | **Duplicates** |   **110.07 ns** |   **5.347 ns** |   **4.465 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 27     | Duplicates |   113.71 ns |   4.154 ns |   3.682 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 27     | Duplicates |    55.94 ns |   1.712 ns |   1.518 ns |  0.51 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **28**     | **Random**     | **1,502.65 ns** |  **88.703 ns** |  **78.633 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 28     | Random     |   128.46 ns |  11.449 ns |   8.939 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 28     | Random     | 1,853.29 ns | 121.504 ns | 107.710 ns |  1.24 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 28     | Random     | 1,761.27 ns | 190.443 ns | 178.141 ns |  1.18 |    0.13 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 28     | Random     |   137.19 ns |   8.195 ns |   7.265 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 28     | Random     | 1,651.95 ns |  38.134 ns |  33.805 ns |  1.10 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 28     | Random     | 1,607.26 ns |  61.107 ns |  51.027 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 28     | Random     | 1,684.24 ns |  52.958 ns |  46.946 ns |  1.12 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 28     | Random     | 1,717.25 ns |  37.424 ns |  33.176 ns |  1.15 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 28     | Random     | 1,632.91 ns |  42.829 ns |  37.967 ns |  1.09 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 28     | Random     | 1,160.71 ns | 154.325 ns | 136.805 ns |  0.77 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 28     | Random     |   134.94 ns |   5.739 ns |   4.793 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 28     | Random     |   168.44 ns |   2.199 ns |   1.836 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 28     | Random     | 1,544.24 ns | 115.968 ns | 102.803 ns |  1.03 |    0.09 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 28     | Random     | 1,550.96 ns |  70.781 ns |  62.745 ns |  1.03 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 28     | Random     |   133.43 ns |   5.649 ns |   5.007 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 28     | Random     | 1,824.43 ns | 163.599 ns | 145.026 ns |  1.22 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 28     | Random     | 1,879.95 ns |  87.260 ns |  77.354 ns |  1.25 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 28     | Random     |   144.61 ns |   6.622 ns |   5.870 ns |  0.10 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 28     | Random     | 1,668.10 ns |  37.370 ns |  33.128 ns |  1.11 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 28     | Random     | 1,673.16 ns |  84.531 ns |  74.935 ns |  1.12 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 28     | Random     | 1,684.91 ns |  39.486 ns |  35.003 ns |  1.12 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 28     | Random     | 1,709.66 ns |  38.307 ns |  33.958 ns |  1.14 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 28     | Random     | 1,626.38 ns |  59.930 ns |  50.044 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 28     | Random     | 1,155.61 ns | 124.712 ns | 110.554 ns |  0.77 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 28     | Random     |   138.89 ns |   2.454 ns |   1.916 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 28     | Random     |   172.49 ns |   3.568 ns |   3.163 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 28     | Random     | 1,490.04 ns | 113.732 ns | 100.820 ns |  0.99 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 28     | Random     |    38.29 ns |   1.545 ns |   1.370 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 28     | Random     |   100.45 ns |   2.375 ns |   2.105 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 28     | Random     |    96.36 ns |   3.033 ns |   2.688 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 28     | Random     |    67.52 ns |   2.562 ns |   2.271 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Random     |    55.21 ns |   1.770 ns |   1.569 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 28     | Random     |   106.56 ns |   2.701 ns |   2.255 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 28     | Random     |   109.12 ns |   2.692 ns |   2.102 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 28     | Random     |   108.60 ns |   2.520 ns |   2.234 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 28     | Random     |    39.28 ns |   1.112 ns |   0.985 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 28     | Random     |   104.46 ns |   2.734 ns |   2.424 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 28     | Random     |   546.79 ns |  13.133 ns |  11.642 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 28     | Random     |    53.82 ns |   1.931 ns |   1.712 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 28     | Random     |   103.68 ns |   2.358 ns |   1.969 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 28     | Random     |   104.60 ns |   2.515 ns |   2.230 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Sorted**     |    **87.86 ns** |   **1.900 ns** |   **1.684 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Sorted     |    89.75 ns |   2.755 ns |   2.442 ns |  1.02 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Sorted     |    56.68 ns |   2.423 ns |   2.024 ns |  0.65 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Reversed**   |   **107.48 ns** |   **3.483 ns** |   **2.909 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Reversed   |   111.46 ns |   3.659 ns |   3.243 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Reversed   |    55.57 ns |   2.165 ns |   1.808 ns |  0.52 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **28**     | **Duplicates** |   **115.06 ns** |   **3.708 ns** |   **3.287 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 28     | Duplicates |   119.87 ns |   5.094 ns |   4.516 ns |  1.04 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 28     | Duplicates |    55.14 ns |   1.844 ns |   1.540 ns |  0.48 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **29**     | **Random**     | **1,448.85 ns** |  **85.885 ns** |  **76.135 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 29     | Random     |   107.81 ns |   2.167 ns |   1.921 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 29     | Random     | 1,748.27 ns | 110.588 ns |  98.033 ns |  1.21 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 29     | Random     | 1,757.74 ns | 106.454 ns |  94.368 ns |  1.22 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 29     | Random     |   123.69 ns |   3.911 ns |   3.467 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 29     | Random     | 1,584.75 ns |  68.363 ns |  60.602 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 29     | Random     | 1,536.01 ns |  81.363 ns |  72.126 ns |  1.06 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 29     | Random     | 1,572.31 ns |  46.655 ns |  41.359 ns |  1.09 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 29     | Random     | 1,614.05 ns |  54.100 ns |  47.958 ns |  1.12 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 29     | Random     | 1,559.90 ns |  47.274 ns |  41.907 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 29     | Random     | 1,210.76 ns | 136.294 ns | 120.821 ns |  0.84 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 29     | Random     |   126.54 ns |   8.451 ns |   7.491 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 29     | Random     |   175.76 ns |   5.829 ns |   5.168 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 29     | Random     | 1,448.01 ns |  70.245 ns |  62.271 ns |  1.00 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 29     | Random     | 1,474.14 ns |  49.321 ns |  43.721 ns |  1.02 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 29     | Random     |   114.38 ns |   8.550 ns |   6.675 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 29     | Random     | 1,738.96 ns | 153.081 ns | 143.192 ns |  1.20 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 29     | Random     | 1,747.49 ns | 117.784 ns | 104.413 ns |  1.21 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 29     | Random     |   130.68 ns |   4.932 ns |   4.118 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 29     | Random     | 1,596.39 ns |  33.476 ns |  29.676 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 29     | Random     | 1,548.11 ns |  87.688 ns |  77.734 ns |  1.07 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 29     | Random     | 1,615.66 ns |  46.229 ns |  40.981 ns |  1.12 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 29     | Random     | 1,609.42 ns |  36.316 ns |  32.193 ns |  1.11 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 29     | Random     | 1,563.85 ns |  54.711 ns |  45.686 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 29     | Random     | 1,261.09 ns |  83.632 ns |  74.138 ns |  0.87 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 29     | Random     |   125.85 ns |   4.367 ns |   3.872 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 29     | Random     |   165.54 ns |   5.485 ns |   4.863 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 29     | Random     | 1,399.64 ns |  73.999 ns |  65.599 ns |  0.97 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 29     | Random     |    40.06 ns |   2.268 ns |   2.011 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 29     | Random     |   106.79 ns |   2.240 ns |   1.985 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 29     | Random     |   131.52 ns |   2.135 ns |   1.783 ns |  0.09 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 29     | Random     |    73.55 ns |   1.469 ns |   1.147 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Random     |    62.79 ns |   2.048 ns |   1.815 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 29     | Random     |   114.63 ns |   2.206 ns |   1.842 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 29     | Random     |   117.35 ns |   3.835 ns |   3.202 ns |  0.08 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 29     | Random     |   115.25 ns |   2.726 ns |   2.128 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 29     | Random     |    41.09 ns |   1.308 ns |   1.159 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 29     | Random     |   111.02 ns |   2.380 ns |   2.110 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 29     | Random     |   564.46 ns |   8.128 ns |   7.205 ns |  0.39 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 29     | Random     |    61.98 ns |   2.415 ns |   2.141 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 29     | Random     |   111.35 ns |   2.133 ns |   1.891 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 29     | Random     |   112.30 ns |   2.783 ns |   2.467 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Sorted**     |    **88.91 ns** |   **2.400 ns** |   **2.004 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Sorted     |    95.56 ns |   3.006 ns |   2.665 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Sorted     |    64.32 ns |   2.607 ns |   2.311 ns |  0.72 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Reversed**   |   **104.33 ns** |   **9.385 ns** |   **8.320 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Reversed   |   114.53 ns |   3.120 ns |   2.605 ns |  1.11 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Reversed   |    63.92 ns |   2.651 ns |   2.350 ns |  0.62 |    0.06 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **29**     | **Duplicates** |   **109.10 ns** |   **3.550 ns** |   **3.147 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 29     | Duplicates |   113.76 ns |   3.889 ns |   3.448 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 29     | Duplicates |    62.56 ns |   1.809 ns |   1.510 ns |  0.57 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **30**     | **Random**     | **1,497.01 ns** |  **39.681 ns** |  **35.176 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 30     | Random     |   118.51 ns |   3.292 ns |   2.918 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 30     | Random     | 1,878.44 ns | 135.417 ns | 120.044 ns |  1.26 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 30     | Random     | 1,676.49 ns | 155.265 ns | 137.638 ns |  1.12 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 30     | Random     |   119.69 ns |   4.682 ns |   4.150 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 30     | Random     | 1,603.48 ns |  38.777 ns |  34.375 ns |  1.07 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 30     | Random     | 1,580.71 ns |  79.689 ns |  66.544 ns |  1.06 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 30     | Random     | 1,643.35 ns |  41.260 ns |  36.576 ns |  1.10 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 30     | Random     | 1,645.96 ns |  47.935 ns |  42.493 ns |  1.10 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 30     | Random     | 1,565.40 ns | 101.651 ns |  90.111 ns |  1.05 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 30     | Random     | 1,359.51 ns | 155.682 ns | 138.008 ns |  0.91 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 30     | Random     |   121.43 ns |   4.418 ns |   3.917 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 30     | Random     |   141.82 ns |   8.234 ns |   7.299 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 30     | Random     | 1,458.09 ns | 146.416 ns | 129.794 ns |  0.97 |    0.09 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 30     | Random     | 1,518.64 ns | 106.100 ns |  94.055 ns |  1.01 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 30     | Random     |   121.15 ns |   3.630 ns |   2.834 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 30     | Random     | 1,720.23 ns | 250.027 ns | 233.875 ns |  1.15 |    0.15 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 30     | Random     | 1,796.59 ns | 153.581 ns | 136.145 ns |  1.20 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 30     | Random     |   119.74 ns |   4.375 ns |   3.879 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 30     | Random     | 1,665.06 ns | 100.629 ns |  89.205 ns |  1.11 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 30     | Random     | 1,596.38 ns | 104.794 ns |  92.897 ns |  1.07 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 30     | Random     | 1,528.76 ns | 150.670 ns | 133.565 ns |  1.02 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 30     | Random     | 1,607.46 ns |  86.116 ns |  76.339 ns |  1.07 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 30     | Random     | 1,583.66 ns |  75.970 ns |  67.345 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 30     | Random     | 1,315.35 ns | 107.757 ns |  95.523 ns |  0.88 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 30     | Random     |   118.16 ns |   5.033 ns |   4.462 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 30     | Random     |   143.02 ns |   4.707 ns |   4.172 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 30     | Random     | 1,406.96 ns | 130.389 ns | 115.587 ns |  0.94 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 30     | Random     |    43.64 ns |   1.618 ns |   1.435 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 30     | Random     |   112.06 ns |   2.845 ns |   2.522 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 30     | Random     |   124.41 ns |   3.460 ns |   3.067 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 30     | Random     |    72.86 ns |   2.660 ns |   2.077 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Random     |    63.50 ns |   2.474 ns |   2.193 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 30     | Random     |   119.28 ns |   2.157 ns |   1.801 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 30     | Random     |   120.13 ns |   2.338 ns |   2.073 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 30     | Random     |   123.53 ns |   2.146 ns |   1.792 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 30     | Random     |    43.57 ns |   1.381 ns |   1.224 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 30     | Random     |   115.06 ns |   2.386 ns |   1.993 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 30     | Random     |   589.07 ns |   7.948 ns |   7.045 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 30     | Random     |    62.56 ns |   4.432 ns |   3.929 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.48 ns |   2.240 ns |   1.986 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 30     | Random     |   115.77 ns |   2.348 ns |   2.081 ns |  0.08 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Sorted**     |    **91.44 ns** |   **2.745 ns** |   **2.292 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Sorted     |    93.99 ns |   9.067 ns |   8.038 ns |  1.03 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Sorted     |    63.32 ns |   1.977 ns |   1.752 ns |  0.69 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Reversed**   |   **110.79 ns** |   **6.012 ns** |   **5.329 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Reversed   |   120.16 ns |   4.475 ns |   3.737 ns |  1.09 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Reversed   |    64.31 ns |   4.087 ns |   3.623 ns |  0.58 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **30**     | **Duplicates** |   **122.43 ns** |   **4.584 ns** |   **3.828 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 30     | Duplicates |   121.15 ns |   2.348 ns |   2.081 ns |  0.99 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 30     | Duplicates |    63.04 ns |   1.988 ns |   1.762 ns |  0.52 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **31**     | **Random**     | **1,663.85 ns** |  **70.855 ns** |  **62.811 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 31     | Random     |   136.94 ns |  27.654 ns |  23.092 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 31     | Random     | 2,101.04 ns |  78.329 ns |  69.436 ns |  1.26 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 31     | Random     | 1,995.41 ns | 127.144 ns | 118.931 ns |  1.20 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 31     | Random     |   143.78 ns |   7.207 ns |   6.389 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 31     | Random     | 1,803.93 ns | 125.180 ns | 110.969 ns |  1.09 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 31     | Random     | 1,794.86 ns | 110.827 ns |  98.245 ns |  1.08 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 31     | Random     | 1,860.61 ns |  98.336 ns |  87.172 ns |  1.12 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 31     | Random     | 1,829.72 ns |  96.095 ns |  85.186 ns |  1.10 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 31     | Random     | 1,783.49 ns | 109.010 ns |  96.635 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 31     | Random     | 1,356.34 ns | 174.554 ns | 154.737 ns |  0.82 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 31     | Random     |   142.86 ns |   6.476 ns |   5.741 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 31     | Random     |   189.32 ns |  16.551 ns |  14.672 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 31     | Random     | 1,684.49 ns | 109.923 ns |  97.444 ns |  1.01 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 31     | Random     | 1,689.22 ns |  21.293 ns |  17.780 ns |  1.02 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 31     | Random     |   133.54 ns |   4.982 ns |   4.416 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 31     | Random     | 1,915.24 ns | 205.378 ns | 192.111 ns |  1.15 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 31     | Random     | 2,017.41 ns | 110.033 ns |  97.542 ns |  1.21 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 31     | Random     |   146.99 ns |   7.239 ns |   6.417 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 31     | Random     | 1,847.71 ns |  44.240 ns |  39.218 ns |  1.11 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 31     | Random     | 1,724.05 ns | 121.007 ns | 107.270 ns |  1.04 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 31     | Random     | 1,854.44 ns |  41.804 ns |  37.058 ns |  1.12 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 31     | Random     | 1,855.91 ns |  51.615 ns |  45.756 ns |  1.12 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 31     | Random     | 1,821.49 ns | 100.744 ns |  89.307 ns |  1.10 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 31     | Random     | 1,394.58 ns | 175.154 ns | 155.269 ns |  0.84 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 31     | Random     |   137.73 ns |   8.030 ns |   7.118 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 31     | Random     |   193.81 ns |   3.241 ns |   2.873 ns |  0.12 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 31     | Random     | 1,640.32 ns |  67.977 ns |  56.764 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 31     | Random     |    38.43 ns |   1.144 ns |   1.014 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 31     | Random     |   110.21 ns |   2.666 ns |   2.363 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 31     | Random     |   129.32 ns |   7.059 ns |   6.258 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 31     | Random     |    70.38 ns |   2.567 ns |   2.144 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Random     |    58.88 ns |   2.123 ns |   1.773 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 31     | Random     |   121.01 ns |   2.698 ns |   2.392 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 31     | Random     |   123.83 ns |   2.912 ns |   2.273 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 31     | Random     |   121.61 ns |   3.125 ns |   2.440 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 31     | Random     |    40.76 ns |   1.494 ns |   1.325 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 31     | Random     |   114.86 ns |   1.828 ns |   1.620 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 31     | Random     |   613.42 ns |   7.858 ns |   6.966 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 31     | Random     |    57.14 ns |   1.812 ns |   1.607 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 31     | Random     |   116.05 ns |   2.533 ns |   1.977 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 31     | Random     |   117.69 ns |   3.307 ns |   2.932 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Sorted**     |    **89.01 ns** |   **2.008 ns** |   **1.780 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Sorted     |    96.89 ns |   5.735 ns |   5.084 ns |  1.09 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Sorted     |    58.79 ns |   2.288 ns |   1.787 ns |  0.66 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Reversed**   |   **114.85 ns** |   **1.676 ns** |   **1.399 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Reversed   |   120.93 ns |   2.093 ns |   1.634 ns |  1.05 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Reversed   |    59.07 ns |   2.420 ns |   2.145 ns |  0.51 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **31**     | **Duplicates** |   **126.59 ns** |   **3.400 ns** |   **3.014 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 31     | Duplicates |   135.08 ns |   4.168 ns |   3.481 ns |  1.07 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 31     | Duplicates |    58.04 ns |   1.972 ns |   1.539 ns |  0.46 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **32**     | **Random**     | **1,729.31 ns** | **101.686 ns** |  **90.142 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort     | 32     | Random     |   130.63 ns |   7.913 ns |   7.015 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort     | 32     | Random     | 2,104.25 ns | 121.104 ns | 107.355 ns |  1.22 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort     | 32     | Random     | 1,991.24 ns | 172.778 ns | 153.164 ns |  1.15 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort     | 32     | Random     |   157.04 ns |   6.714 ns |   5.951 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort     | 32     | Random     | 1,863.85 ns |  80.378 ns |  67.119 ns |  1.08 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort     | 32     | Random     | 1,855.06 ns |  88.777 ns |  78.698 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort     | 32     | Random     | 1,859.64 ns | 110.340 ns |  97.813 ns |  1.08 |    0.08 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort     | 32     | Random     | 1,903.95 ns |  43.714 ns |  38.752 ns |  1.10 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort     | 32     | Random     | 1,819.19 ns | 141.186 ns | 125.158 ns |  1.06 |    0.09 |         - |          NA |
| StringSortingBenchmarks | ArraySort     | 32     | Random     | 1,300.27 ns | 134.711 ns | 119.418 ns |  0.75 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort     | 32     | Random     |   147.72 ns |   4.458 ns |   3.952 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort     | 32     | Random     |   206.96 ns |  35.822 ns |  31.755 ns |  0.12 |    0.02 |         - |          NA |
| UShortSortingBenchmarks | ArraySort     | 32     | Random     | 1,728.76 ns |  56.668 ns |  50.235 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort      | 32     | Random     | 1,791.90 ns |  58.912 ns |  52.224 ns |  1.04 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort      | 32     | Random     |   136.12 ns |   3.008 ns |   2.512 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort      | 32     | Random     | 2,029.19 ns | 219.456 ns | 205.279 ns |  1.18 |    0.13 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort      | 32     | Random     | 2,103.66 ns |  79.146 ns |  66.091 ns |  1.22 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort      | 32     | Random     |   168.94 ns |   7.096 ns |   6.291 ns |  0.10 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort      | 32     | Random     | 1,891.86 ns |  59.977 ns |  53.168 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort      | 32     | Random     | 1,917.76 ns |  46.012 ns |  40.788 ns |  1.11 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort      | 32     | Random     | 1,857.85 ns |  79.306 ns |  66.224 ns |  1.08 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort      | 32     | Random     | 1,890.29 ns |  70.281 ns |  62.302 ns |  1.10 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort      | 32     | Random     | 1,854.38 ns |  39.144 ns |  34.700 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort      | 32     | Random     | 1,328.06 ns | 120.799 ns | 107.085 ns |  0.77 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort      | 32     | Random     |   144.70 ns |   6.782 ns |   6.012 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort      | 32     | Random     |   216.21 ns |   3.808 ns |   3.376 ns |  0.13 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort      | 32     | Random     | 1,690.29 ns |  46.680 ns |  41.380 ns |  0.98 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 32     | Random     |    37.60 ns |   1.425 ns |   1.263 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 32     | Random     |   114.64 ns |   2.123 ns |   1.882 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 32     | Random     |   120.88 ns |   3.118 ns |   2.435 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 32     | Random     |    69.54 ns |   1.605 ns |   1.423 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Random     |    57.47 ns |   1.707 ns |   1.513 ns |  0.03 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 32     | Random     |   124.04 ns |   2.500 ns |   2.216 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 32     | Random     |   126.51 ns |   2.354 ns |   1.966 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 32     | Random     |   129.39 ns |   2.853 ns |   2.529 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 32     | Random     |    40.29 ns |   1.423 ns |   1.261 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 32     | Random     |   121.31 ns |   3.135 ns |   2.779 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | GeneratedSort | 32     | Random     |   619.19 ns |   3.839 ns |   3.403 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 32     | Random     |    55.22 ns |   2.063 ns |   1.611 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 32     | Random     |   123.63 ns |   2.115 ns |   1.875 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 32     | Random     |   121.46 ns |   2.522 ns |   2.236 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Sorted**     |    **91.81 ns** |   **3.939 ns** |   **3.492 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Sorted     |   100.78 ns |   1.756 ns |   1.556 ns |  1.10 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Sorted     |    58.04 ns |   2.201 ns |   1.838 ns |  0.63 |    0.03 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Reversed**   |   **116.69 ns** |   **4.180 ns** |   **3.705 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Reversed   |   127.42 ns |   3.764 ns |   3.337 ns |  1.09 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Reversed   |    58.31 ns |   2.515 ns |   2.100 ns |  0.50 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **32**     | **Duplicates** |   **149.26 ns** |  **60.549 ns** |  **53.675 ns** |  **1.09** |    **0.47** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 32     | Duplicates |   129.16 ns |   3.585 ns |   3.178 ns |  0.94 |    0.23 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 32     | Duplicates |    57.44 ns |   2.320 ns |   2.056 ns |  0.42 |    0.10 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**     | **34**     | **Random**     | **1,971.29 ns** |  **37.078 ns** |  **32.869 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| ByteSortingBenchmarks   | SpanSort      | 34     | Random     | 1,964.00 ns |  93.486 ns |  82.873 ns |  1.00 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | GeneratedSort | 34     | Random     |   131.13 ns |   2.440 ns |   2.163 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **FloatSortingBenchmarks**  | **ArraySort**     | **36**     | **Random**     | **2,165.20 ns** | **210.972 ns** | **197.343 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| FloatSortingBenchmarks  | SpanSort      | 36     | Random     | 2,192.45 ns | 206.883 ns | 183.396 ns |  1.02 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | GeneratedSort | 36     | Random     |    89.98 ns |   1.823 ns |   1.616 ns |  0.04 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **SByteSortingBenchmarks**  | **ArraySort**     | **38**     | **Random**     | **2,548.86 ns** | **132.385 ns** | **117.356 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| SByteSortingBenchmarks  | SpanSort      | 38     | Random     | 2,582.19 ns |  94.622 ns |  83.880 ns |  1.02 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | GeneratedSort | 38     | Random     |   154.71 ns |   2.590 ns |   2.296 ns |  0.06 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ShortSortingBenchmarks**  | **ArraySort**     | **40**     | **Random**     | **2,349.57 ns** | **202.040 ns** | **179.103 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| ShortSortingBenchmarks  | SpanSort      | 40     | Random     | 2,366.39 ns | 128.768 ns | 114.149 ns |  1.01 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | GeneratedSort | 40     | Random     |   165.92 ns |   2.715 ns |   2.407 ns |  0.07 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **UShortSortingBenchmarks** | **ArraySort**     | **42**     | **Random**     | **2,562.93 ns** | **152.893 ns** | **135.535 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| UShortSortingBenchmarks | SpanSort      | 42     | Random     | 2,498.66 ns |  99.772 ns |  88.445 ns |  0.98 |    0.07 |         - |          NA |
| UShortSortingBenchmarks | GeneratedSort | 42     | Random     |   172.89 ns |   2.212 ns |   1.961 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **DoubleSortingBenchmarks** | **ArraySort**     | **44**     | **Random**     | **3,546.91 ns** | **219.846 ns** | **205.644 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| DoubleSortingBenchmarks | SpanSort      | 44     | Random     | 3,460.13 ns | 285.259 ns | 266.831 ns |  0.98 |    0.09 |         - |          NA |
| DoubleSortingBenchmarks | GeneratedSort | 44     | Random     |   256.46 ns |  11.043 ns |   9.789 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Random**     |   **313.39 ns** |  **11.109 ns** |   **9.848 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Random     |   311.96 ns |  37.244 ns |  33.016 ns |  1.00 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Random     |   113.60 ns |   2.337 ns |   2.072 ns |  0.36 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Sorted**     |   **188.80 ns** |   **3.661 ns** |   **3.058 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Sorted     |   188.71 ns |   1.476 ns |   1.308 ns |  1.00 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Sorted     |   114.22 ns |   2.802 ns |   2.340 ns |  0.61 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Reversed**   |   **237.46 ns** |   **5.429 ns** |   **4.813 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Reversed   |   247.86 ns |   4.961 ns |   4.397 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Reversed   |   112.86 ns |   3.069 ns |   2.563 ns |  0.48 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**     | **48**     | **Duplicates** |   **214.08 ns** |   **3.058 ns** |   **2.554 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks    | SpanSort      | 48     | Duplicates |   229.58 ns |   3.840 ns |   3.404 ns |  1.07 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | GeneratedSort | 48     | Duplicates |   116.49 ns |   5.864 ns |   5.198 ns |  0.54 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **UIntSortingBenchmarks**   | **ArraySort**     | **50**     | **Random**     |   **282.67 ns** |  **16.657 ns** |  **14.766 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| UIntSortingBenchmarks   | SpanSort      | 50     | Random     |   307.24 ns |  11.073 ns |   9.815 ns |  1.09 |    0.06 |         - |          NA |
| UIntSortingBenchmarks   | GeneratedSort | 50     | Random     |   218.69 ns |   5.726 ns |   5.076 ns |  0.78 |    0.04 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **LongSortingBenchmarks**   | **ArraySort**     | **52**     | **Random**     | **3,802.34 ns** | **156.264 ns** | **138.524 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| LongSortingBenchmarks   | SpanSort      | 52     | Random     | 3,848.60 ns | 208.194 ns | 194.745 ns |  1.01 |    0.06 |         - |          NA |
| LongSortingBenchmarks   | GeneratedSort | 52     | Random     |   256.75 ns |   4.450 ns |   3.945 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **ULongSortingBenchmarks**  | **ArraySort**     | **54**     | **Random**     |   **488.97 ns** |  **71.135 ns** |  **63.060 ns** |  **1.03** |    **0.25** |         **-** |          **NA** |
| ULongSortingBenchmarks  | SpanSort      | 54     | Random     |   448.81 ns | 106.551 ns |  94.455 ns |  0.94 |    0.27 |         - |          NA |
| ULongSortingBenchmarks  | GeneratedSort | 54     | Random     |   268.86 ns |   3.914 ns |   3.469 ns |  0.56 |    0.11 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **NIntSortingBenchmarks**   | **ArraySort**     | **56**     | **Random**     | **4,268.36 ns** |  **90.490 ns** |  **80.217 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NIntSortingBenchmarks   | SpanSort      | 56     | Random     | 4,351.21 ns | 152.738 ns | 135.398 ns |  1.02 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | GeneratedSort | 56     | Random     |   289.98 ns |   3.570 ns |   3.165 ns |  0.07 |    0.00 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **NUIntSortingBenchmarks**  | **ArraySort**     | **58**     | **Random**     | **3,821.36 ns** | **362.798 ns** | **339.361 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| NUIntSortingBenchmarks  | SpanSort      | 58     | Random     | 3,856.20 ns | 356.786 ns | 316.281 ns |  1.02 |    0.12 |         - |          NA |
| NUIntSortingBenchmarks  | GeneratedSort | 58     | Random     |   314.72 ns |   2.578 ns |   2.153 ns |  0.08 |    0.01 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**   | **ArraySort**     | **60**     | **Random**     |   **375.35 ns** |  **14.020 ns** |  **12.428 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks   | SpanSort      | 60     | Random     |   393.27 ns |   8.186 ns |   7.256 ns |  1.05 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | GeneratedSort | 60     | Random     |   258.18 ns |   2.333 ns |   2.068 ns |  0.69 |    0.02 |         - |          NA |
|                         |               |        |            |             |            |            |       |         |           |             |
| **StringSortingBenchmarks** | **ArraySort**     | **64**     | **Random**     | **3,621.97 ns** | **549.990 ns** | **514.461 ns** |  **1.02** |    **0.23** |      **64 B** |        **1.00** |
| StringSortingBenchmarks | SpanSort      | 64     | Random     | 3,513.60 ns | 534.939 ns | 474.209 ns |  0.99 |    0.22 |      64 B |        1.00 |
| StringSortingBenchmarks | GeneratedSort | 64     | Random     | 1,916.76 ns |  14.882 ns |  13.192 ns |  0.54 |    0.10 |         - |        0.00 |

