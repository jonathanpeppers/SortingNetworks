```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8246/25H2/2025Update/HudsonValley2)
Intel Core i9-9900K CPU 3.60GHz (Coffee Lake), 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.201
  [Host]     : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Type                     | Method        | Length | Kind       | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------- |-------------- |------- |----------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **CharSortingBenchmarks**    | **ArraySort**     | **8**      | **Random**     |    **29.74 ns** |   **2.189 ns** |   **1.941 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| ShortSortingBenchmarks   | ArraySort     | 8      | Random     |   305.40 ns |   9.806 ns |   8.693 ns | 10.31 |    0.71 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 8      | Random     |   275.67 ns |   9.489 ns |   8.412 ns |  9.31 |    0.65 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 8      | Random     |    32.49 ns |   1.991 ns |   1.765 ns |  1.10 |    0.09 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 8      | Random     |   303.33 ns |  19.941 ns |  17.677 ns | 10.24 |    0.87 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 8      | Random     |   270.36 ns |  19.129 ns |  16.958 ns |  9.13 |    0.80 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 8      | Random     |    20.84 ns |   0.737 ns |   0.654 ns |  0.70 |    0.05 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 8      | Random     |    24.24 ns |   0.914 ns |   0.810 ns |  0.82 |    0.06 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 8      | Random     |    23.94 ns |   1.152 ns |   1.022 ns |  0.81 |    0.06 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**    | **ArraySort**     | **16**     | **Random**     |    **69.01 ns** |   **2.938 ns** |   **2.604 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| ShortSortingBenchmarks   | ArraySort     | 16     | Random     |   922.06 ns |  15.197 ns |  13.471 ns | 13.38 |    0.52 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 16     | Random     |   819.72 ns |   8.315 ns |   7.371 ns | 11.89 |    0.45 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 16     | Random     |    72.69 ns |   3.320 ns |   2.943 ns |  1.05 |    0.06 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 16     | Random     |   977.97 ns |   8.036 ns |   7.124 ns | 14.19 |    0.53 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 16     | Random     |   799.05 ns |   9.289 ns |   8.234 ns | 11.59 |    0.44 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 16     | Random     |    30.89 ns |   1.327 ns |   1.176 ns |  0.45 |    0.02 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 16     | Random     |    33.47 ns |   1.296 ns |   1.149 ns |  0.49 |    0.02 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 16     | Random     |    34.41 ns |   1.555 ns |   1.378 ns |  0.50 |    0.03 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **23**     | **Random**     | **1,117.47 ns** |  **35.846 ns** |  **31.777 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 23     | Random     |    77.08 ns |   3.472 ns |   3.078 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 23     | Random     | 2,072.66 ns | 114.090 ns |  95.271 ns |  1.86 |    0.10 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 23     | Random     | 1,369.50 ns |  93.046 ns |  82.483 ns |  1.23 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 23     | Random     | 1,329.95 ns | 110.571 ns |  98.018 ns |  1.19 |    0.09 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 23     | Random     |    91.11 ns |   4.367 ns |   3.871 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 23     | Random     | 1,217.44 ns |  28.699 ns |  25.441 ns |  1.09 |    0.04 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 23     | Random     | 1,209.18 ns |  29.609 ns |  26.248 ns |  1.08 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 23     | Random     | 1,234.11 ns |  48.436 ns |  42.937 ns |  1.11 |    0.05 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 23     | Random     | 2,227.39 ns |  43.557 ns |  38.612 ns |  1.99 |    0.06 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 23     | Random     | 1,242.37 ns |  28.951 ns |  25.665 ns |  1.11 |    0.04 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 23     | Random     | 1,198.54 ns |  57.976 ns |  51.394 ns |  1.07 |    0.05 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 23     | Random     |   981.26 ns |  87.859 ns |  77.885 ns |  0.88 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 23     | Random     |    99.67 ns |   4.653 ns |   4.124 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 23     | Random     |   118.26 ns |   3.892 ns |   3.450 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 23     | Random     | 1,103.40 ns |  47.698 ns |  42.283 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 23     | Random     | 1,143.54 ns |  35.131 ns |  31.142 ns |  1.02 |    0.04 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 23     | Random     |    78.62 ns |   2.576 ns |   2.151 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 23     | Random     | 1,991.58 ns | 214.703 ns | 179.286 ns |  1.78 |    0.16 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 23     | Random     | 1,358.69 ns | 101.694 ns |  90.149 ns |  1.22 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 23     | Random     | 1,349.36 ns |  95.322 ns |  84.500 ns |  1.21 |    0.08 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 23     | Random     |    98.14 ns |   2.766 ns |   2.452 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 23     | Random     | 1,225.73 ns |  35.131 ns |  31.143 ns |  1.10 |    0.04 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 23     | Random     | 1,222.36 ns |  28.639 ns |  25.388 ns |  1.09 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 23     | Random     | 1,241.73 ns |  35.655 ns |  31.607 ns |  1.11 |    0.04 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 23     | Random     | 2,282.07 ns |  50.705 ns |  44.949 ns |  2.04 |    0.07 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 23     | Random     | 1,230.77 ns |  38.840 ns |  34.431 ns |  1.10 |    0.04 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 23     | Random     | 1,207.93 ns |  42.188 ns |  37.399 ns |  1.08 |    0.04 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 23     | Random     |   985.90 ns |  72.250 ns |  64.048 ns |  0.88 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 23     | Random     |    96.16 ns |   3.232 ns |   2.865 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 23     | Random     |   114.70 ns |  13.270 ns |  11.763 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 23     | Random     | 1,103.47 ns |  56.969 ns |  50.501 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 23     | Random     |    35.02 ns |   0.984 ns |   0.822 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 23     | Random     |    82.54 ns |   2.846 ns |   2.523 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 23     | Random     |   607.42 ns |   3.048 ns |   2.546 ns |  0.54 |    0.02 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 23     | Random     |    85.34 ns |   2.072 ns |   1.618 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 23     | Random     |    60.86 ns |   1.925 ns |   1.707 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 23     | Random     |    47.69 ns |   2.099 ns |   1.753 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 23     | Random     |    89.18 ns |   2.714 ns |   2.266 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 23     | Random     |    94.79 ns |   3.067 ns |   2.561 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 23     | Random     |    95.52 ns |   1.906 ns |   1.591 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 23     | Random     |   636.46 ns |   5.241 ns |   4.646 ns |  0.57 |    0.02 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 23     | Random     |    37.69 ns |   1.111 ns |   0.985 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 23     | Random     |    87.06 ns |   2.164 ns |   1.918 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 23     | Random     |   389.49 ns |   4.040 ns |   3.582 ns |  0.35 |    0.01 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 23     | Random     |    45.89 ns |   1.833 ns |   1.625 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 23     | Random     |    85.61 ns |   1.972 ns |   1.748 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 23     | Random     |    87.01 ns |   2.249 ns |   1.878 ns |  0.08 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **23**     | **Sorted**     |   **718.86 ns** |  **17.685 ns** |  **15.677 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 23     | Sorted     |    61.35 ns |   2.962 ns |   2.473 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 23     | Sorted     |   741.97 ns |  16.748 ns |  14.846 ns |  1.03 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 23     | Sorted     |   721.15 ns |  19.460 ns |  16.250 ns |  1.00 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 23     | Sorted     |    65.74 ns |   2.830 ns |   2.509 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 23     | Sorted     |   748.50 ns |  14.916 ns |  13.223 ns |  1.04 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 23     | Sorted     |   577.80 ns |   3.842 ns |   3.208 ns |  0.80 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 23     | Sorted     |    48.97 ns |   1.958 ns |   1.635 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 23     | Sorted     |   639.68 ns |   1.923 ns |   1.501 ns |  0.89 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **23**     | **Reversed**   | **1,166.67 ns** |  **30.707 ns** |  **25.641 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 23     | Reversed   |    85.79 ns |   4.516 ns |   4.003 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 23     | Reversed   | 1,100.49 ns |  20.159 ns |  17.870 ns |  0.94 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 23     | Reversed   | 1,181.83 ns |  28.544 ns |  25.303 ns |  1.01 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 23     | Reversed   |    92.11 ns |   3.267 ns |   2.896 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 23     | Reversed   | 1,097.13 ns |  20.502 ns |  18.174 ns |  0.94 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 23     | Reversed   |   578.63 ns |   4.912 ns |   3.835 ns |  0.50 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 23     | Reversed   |    51.57 ns |   2.522 ns |   2.236 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 23     | Reversed   |   637.37 ns |   3.618 ns |   3.021 ns |  0.55 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **23**     | **Duplicates** | **1,407.78 ns** | **112.917 ns** | **100.098 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 23     | Duplicates |    88.15 ns |   2.246 ns |   1.991 ns |  0.06 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 23     | Duplicates | 1,834.54 ns |  86.614 ns |  76.781 ns |  1.31 |    0.12 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 23     | Duplicates | 1,449.38 ns | 106.287 ns |  94.220 ns |  1.04 |    0.11 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 23     | Duplicates |    94.21 ns |   6.113 ns |   5.419 ns |  0.07 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 23     | Duplicates | 1,852.89 ns |  90.666 ns |  80.373 ns |  1.32 |    0.12 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 23     | Duplicates |   501.69 ns |   3.607 ns |   2.816 ns |  0.36 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 23     | Duplicates |    49.40 ns |   4.488 ns |   3.979 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 23     | Duplicates |   890.51 ns |   9.988 ns |   8.854 ns |  0.64 |    0.05 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **24**     | **Random**     | **1,260.38 ns** |  **67.623 ns** |  **56.468 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 24     | Random     |   127.59 ns |   4.816 ns |   4.022 ns |  0.10 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 24     | Random     | 2,190.04 ns | 231.715 ns | 205.410 ns |  1.74 |    0.18 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 24     | Random     | 1,546.63 ns |  75.078 ns |  66.555 ns |  1.23 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 24     | Random     | 1,461.85 ns |  98.113 ns |  81.929 ns |  1.16 |    0.08 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 24     | Random     |   107.64 ns |   3.983 ns |   3.530 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 24     | Random     | 1,320.78 ns |  53.239 ns |  44.457 ns |  1.05 |    0.06 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 24     | Random     | 1,333.23 ns |  35.138 ns |  31.149 ns |  1.06 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 24     | Random     | 1,350.58 ns |  37.840 ns |  33.544 ns |  1.07 |    0.06 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 24     | Random     | 2,139.25 ns |  30.788 ns |  27.292 ns |  1.70 |    0.08 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 24     | Random     | 1,369.53 ns |  64.451 ns |  57.134 ns |  1.09 |    0.07 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 24     | Random     | 1,314.06 ns |  56.958 ns |  50.492 ns |  1.04 |    0.06 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 24     | Random     | 1,064.21 ns | 106.673 ns |  94.563 ns |  0.85 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 24     | Random     |   110.26 ns |   3.128 ns |   2.612 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 24     | Random     |   130.34 ns |   4.724 ns |   3.945 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 24     | Random     | 1,301.84 ns |  60.168 ns |  50.243 ns |  1.03 |    0.06 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 24     | Random     | 1,270.19 ns |  79.596 ns |  70.560 ns |  1.01 |    0.07 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 24     | Random     |   128.21 ns |   2.743 ns |   2.431 ns |  0.10 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 24     | Random     | 2,218.70 ns | 202.284 ns | 179.319 ns |  1.76 |    0.16 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 24     | Random     | 1,554.67 ns | 156.056 ns | 145.974 ns |  1.24 |    0.13 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 24     | Random     | 1,492.41 ns |  84.649 ns |  70.686 ns |  1.19 |    0.08 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 24     | Random     |   114.15 ns |   3.183 ns |   2.658 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 24     | Random     | 1,404.84 ns |  40.056 ns |  35.509 ns |  1.12 |    0.06 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 24     | Random     | 1,338.21 ns |  54.166 ns |  48.017 ns |  1.06 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 24     | Random     | 1,386.37 ns |  68.977 ns |  61.147 ns |  1.10 |    0.07 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 24     | Random     | 2,094.86 ns |  65.864 ns |  55.000 ns |  1.67 |    0.09 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 24     | Random     | 1,386.48 ns |  82.494 ns |  68.886 ns |  1.10 |    0.07 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 24     | Random     | 1,335.28 ns |  46.834 ns |  41.517 ns |  1.06 |    0.06 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 24     | Random     | 1,085.32 ns |  72.543 ns |  64.308 ns |  0.86 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 24     | Random     |   108.69 ns |   4.012 ns |   3.556 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 24     | Random     |   123.14 ns |   5.436 ns |   4.819 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 24     | Random     | 1,241.76 ns |  62.860 ns |  55.723 ns |  0.99 |    0.06 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 24     | Random     |    37.37 ns |   1.602 ns |   1.420 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 24     | Random     |    79.44 ns |   2.021 ns |   1.792 ns |  0.06 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 24     | Random     |   650.45 ns |   5.626 ns |   4.393 ns |  0.52 |    0.02 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 24     | Random     |    99.49 ns |   2.096 ns |   1.750 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 24     | Random     |    62.16 ns |   1.754 ns |   1.555 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 24     | Random     |    52.25 ns |   2.131 ns |   1.780 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 24     | Random     |    86.84 ns |   1.977 ns |   1.753 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 24     | Random     |    94.45 ns |   2.270 ns |   2.012 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 24     | Random     |    94.20 ns |   4.047 ns |   3.380 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 24     | Random     |   671.75 ns |   6.516 ns |   5.776 ns |  0.53 |    0.03 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 24     | Random     |    39.66 ns |   1.106 ns |   0.980 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 24     | Random     |    84.80 ns |   2.384 ns |   1.990 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 24     | Random     |   420.70 ns |   8.098 ns |   7.178 ns |  0.33 |    0.02 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 24     | Random     |    49.14 ns |   2.313 ns |   1.931 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 24     | Random     |    84.97 ns |   2.227 ns |   1.975 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 24     | Random     |    84.73 ns |   2.355 ns |   2.088 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **24**     | **Sorted**     |   **756.39 ns** |  **33.661 ns** |  **29.840 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 24     | Sorted     |    70.61 ns |   2.522 ns |   2.235 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 24     | Sorted     |   766.04 ns |  18.149 ns |  16.089 ns |  1.01 |    0.04 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 24     | Sorted     |   746.36 ns |  22.283 ns |  19.753 ns |  0.99 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 24     | Sorted     |    78.18 ns |   3.358 ns |   2.976 ns |  0.10 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 24     | Sorted     |   799.51 ns |  16.716 ns |  14.818 ns |  1.06 |    0.04 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 24     | Sorted     |   611.36 ns |  21.021 ns |  18.635 ns |  0.81 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 24     | Sorted     |    51.12 ns |   1.557 ns |   1.380 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 24     | Sorted     |   665.32 ns |   7.816 ns |   6.527 ns |  0.88 |    0.03 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **24**     | **Reversed**   | **1,180.42 ns** |  **49.956 ns** |  **44.285 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 24     | Reversed   |    91.81 ns |   3.954 ns |   3.505 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 24     | Reversed   | 1,156.59 ns |  27.198 ns |  24.111 ns |  0.98 |    0.04 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 24     | Reversed   | 1,237.97 ns |  35.317 ns |  31.307 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 24     | Reversed   |   100.91 ns |   2.805 ns |   2.487 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 24     | Reversed   | 1,138.56 ns |  23.044 ns |  20.428 ns |  0.97 |    0.04 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 24     | Reversed   |   621.12 ns |  13.764 ns |  12.202 ns |  0.53 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 24     | Reversed   |    52.20 ns |   2.219 ns |   1.733 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 24     | Reversed   |   684.46 ns |   3.432 ns |   3.043 ns |  0.58 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **24**     | **Duplicates** | **1,321.90 ns** |  **44.397 ns** |  **37.074 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 24     | Duplicates |    93.37 ns |   2.930 ns |   2.597 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 24     | Duplicates | 2,045.35 ns |  81.322 ns |  72.090 ns |  1.55 |    0.07 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 24     | Duplicates | 1,316.70 ns |  87.066 ns |  77.182 ns |  1.00 |    0.06 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 24     | Duplicates |    97.79 ns |   2.938 ns |   2.605 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 24     | Duplicates | 2,071.91 ns |  90.521 ns |  80.245 ns |  1.57 |    0.07 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 24     | Duplicates |   540.49 ns |   2.614 ns |   2.041 ns |  0.41 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 24     | Duplicates |    52.46 ns |   1.808 ns |   1.603 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 24     | Duplicates | 1,012.94 ns |   8.320 ns |   6.948 ns |  0.77 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **25**     | **Random**     | **1,208.97 ns** |  **39.023 ns** |  **30.466 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 25     | Random     |   121.11 ns |   2.966 ns |   2.477 ns |  0.10 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 25     | Random     | 1,916.71 ns | 131.033 ns | 116.157 ns |  1.59 |    0.10 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 25     | Random     | 1,449.56 ns | 110.734 ns |  98.162 ns |  1.20 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 25     | Random     | 1,394.53 ns | 152.444 ns | 142.596 ns |  1.15 |    0.12 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 25     | Random     |   101.23 ns |   3.655 ns |   3.240 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 25     | Random     | 1,225.10 ns |  72.109 ns |  63.923 ns |  1.01 |    0.06 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 25     | Random     | 1,246.37 ns |  74.758 ns |  66.271 ns |  1.03 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 25     | Random     | 1,283.29 ns |  36.766 ns |  32.592 ns |  1.06 |    0.04 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 25     | Random     | 2,046.04 ns |  71.735 ns |  63.592 ns |  1.69 |    0.06 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 25     | Random     | 1,300.82 ns |  33.279 ns |  29.501 ns |  1.08 |    0.03 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 25     | Random     | 1,235.58 ns |  22.189 ns |  18.528 ns |  1.02 |    0.03 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 25     | Random     |   892.34 ns |  74.224 ns |  65.798 ns |  0.74 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 25     | Random     |   108.71 ns |   3.574 ns |   3.168 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 25     | Random     |   122.62 ns |   2.445 ns |   2.041 ns |  0.10 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 25     | Random     | 1,205.91 ns |  32.576 ns |  28.878 ns |  1.00 |    0.03 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 25     | Random     | 1,177.72 ns |  76.179 ns |  63.613 ns |  0.97 |    0.06 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 25     | Random     |   122.34 ns |   2.731 ns |   2.421 ns |  0.10 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 25     | Random     | 1,919.21 ns | 153.300 ns | 135.896 ns |  1.59 |    0.12 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 25     | Random     | 1,335.90 ns | 134.207 ns | 118.971 ns |  1.11 |    0.10 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 25     | Random     | 1,405.40 ns |  97.430 ns |  86.369 ns |  1.16 |    0.07 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 25     | Random     |   109.64 ns |   3.019 ns |   2.676 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 25     | Random     | 1,250.70 ns |  76.641 ns |  67.940 ns |  1.04 |    0.06 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 25     | Random     | 1,223.49 ns | 102.235 ns |  90.628 ns |  1.01 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 25     | Random     | 1,266.04 ns |  55.124 ns |  48.866 ns |  1.05 |    0.05 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 25     | Random     | 2,041.88 ns |  39.712 ns |  35.204 ns |  1.69 |    0.05 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 25     | Random     | 1,276.86 ns |  88.640 ns |  78.577 ns |  1.06 |    0.07 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 25     | Random     | 1,254.83 ns |  39.190 ns |  34.741 ns |  1.04 |    0.04 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 25     | Random     |   979.44 ns | 117.962 ns |  98.504 ns |  0.81 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 25     | Random     |   107.98 ns |   3.443 ns |   2.875 ns |  0.09 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 25     | Random     |   128.21 ns |   4.297 ns |   3.809 ns |  0.11 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 25     | Random     | 1,162.74 ns |  35.326 ns |  31.315 ns |  0.96 |    0.03 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 25     | Random     |    38.91 ns |   1.185 ns |   1.051 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 25     | Random     |    89.60 ns |   2.321 ns |   2.058 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 25     | Random     |   703.79 ns |   4.580 ns |   3.576 ns |  0.58 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 25     | Random     |   101.99 ns |   2.523 ns |   2.237 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 25     | Random     |    68.70 ns |   2.684 ns |   2.379 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 25     | Random     |    57.09 ns |   2.027 ns |   1.797 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 25     | Random     |    97.23 ns |   2.526 ns |   2.239 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 25     | Random     |   103.66 ns |   2.629 ns |   2.331 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 25     | Random     |   102.31 ns |   2.328 ns |   1.817 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 25     | Random     |   750.38 ns |  17.557 ns |  15.564 ns |  0.62 |    0.02 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 25     | Random     |    40.83 ns |   1.399 ns |   1.241 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 25     | Random     |    94.18 ns |   2.356 ns |   2.089 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 25     | Random     |   445.09 ns |   6.297 ns |   5.582 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 25     | Random     |    55.58 ns |   3.096 ns |   2.417 ns |  0.05 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 25     | Random     |    92.61 ns |   2.208 ns |   1.957 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 25     | Random     |    94.31 ns |   2.336 ns |   2.071 ns |  0.08 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **25**     | **Sorted**     |   **761.99 ns** |  **16.580 ns** |  **14.698 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 25     | Sorted     |    79.56 ns |   2.123 ns |   1.658 ns |  0.10 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 25     | Sorted     |   795.99 ns |  16.655 ns |  14.764 ns |  1.04 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 25     | Sorted     |   772.12 ns |  23.519 ns |  19.639 ns |  1.01 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 25     | Sorted     |    86.50 ns |   2.456 ns |   2.177 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 25     | Sorted     |   791.34 ns |  15.062 ns |  13.352 ns |  1.04 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 25     | Sorted     |   647.35 ns |   3.016 ns |   2.519 ns |  0.85 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 25     | Sorted     |    55.17 ns |   2.118 ns |   1.877 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 25     | Sorted     |   712.61 ns |   3.609 ns |   3.013 ns |  0.94 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **25**     | **Reversed**   | **1,255.61 ns** |  **36.448 ns** |  **32.310 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 25     | Reversed   |    90.64 ns |   2.590 ns |   2.296 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 25     | Reversed   | 1,180.37 ns |  15.819 ns |  14.023 ns |  0.94 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 25     | Reversed   | 1,256.19 ns |  48.531 ns |  43.022 ns |  1.00 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 25     | Reversed   |    96.51 ns |   4.224 ns |   3.744 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 25     | Reversed   | 1,183.69 ns |  22.258 ns |  19.731 ns |  0.94 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 25     | Reversed   |   662.57 ns |   7.673 ns |   6.407 ns |  0.53 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 25     | Reversed   |    55.36 ns |   1.774 ns |   1.572 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 25     | Reversed   |   738.80 ns |   6.314 ns |   5.597 ns |  0.59 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **25**     | **Duplicates** | **1,382.61 ns** |  **44.238 ns** |  **39.216 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 25     | Duplicates |    98.51 ns |   3.061 ns |   2.714 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 25     | Duplicates | 2,167.44 ns |  50.172 ns |  44.476 ns |  1.57 |    0.05 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 25     | Duplicates | 1,354.52 ns | 114.264 ns |  95.416 ns |  0.98 |    0.07 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 25     | Duplicates |   103.70 ns |   8.199 ns |   7.268 ns |  0.08 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 25     | Duplicates | 2,174.62 ns |  26.145 ns |  21.832 ns |  1.57 |    0.05 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 25     | Duplicates |   584.61 ns |   3.860 ns |   3.013 ns |  0.42 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 25     | Duplicates |    59.84 ns |   3.069 ns |   2.720 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 25     | Duplicates |   994.35 ns |   4.137 ns |   3.455 ns |  0.72 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **26**     | **Random**     | **1,396.25 ns** | **117.869 ns** |  **98.426 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 26     | Random     |   122.87 ns |   3.728 ns |   2.910 ns |  0.09 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 26     | Random     | 2,583.13 ns | 138.716 ns | 122.968 ns |  1.86 |    0.17 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 26     | Random     | 1,780.70 ns |  43.067 ns |  38.177 ns |  1.28 |    0.10 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 26     | Random     | 1,611.11 ns | 130.507 ns | 122.076 ns |  1.16 |    0.12 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 26     | Random     |   122.42 ns |   3.248 ns |   2.879 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 26     | Random     | 1,504.49 ns |  34.429 ns |  30.521 ns |  1.08 |    0.09 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 26     | Random     | 1,455.61 ns |  90.230 ns |  79.987 ns |  1.05 |    0.10 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 26     | Random     | 1,495.94 ns |  39.071 ns |  34.635 ns |  1.08 |    0.09 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 26     | Random     | 2,016.39 ns |  46.189 ns |  40.945 ns |  1.45 |    0.11 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 26     | Random     | 1,582.89 ns |  42.812 ns |  35.750 ns |  1.14 |    0.09 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 26     | Random     | 1,474.89 ns |  46.012 ns |  40.788 ns |  1.06 |    0.09 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 26     | Random     | 1,072.57 ns | 137.490 ns | 114.811 ns |  0.77 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 26     | Random     |   129.62 ns |   4.543 ns |   4.027 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 26     | Random     |   154.97 ns |   6.248 ns |   5.218 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 26     | Random     | 1,368.50 ns |  85.571 ns |  75.857 ns |  0.99 |    0.09 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 26     | Random     | 1,412.12 ns |  42.137 ns |  35.187 ns |  1.02 |    0.08 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 26     | Random     |   121.71 ns |   4.107 ns |   3.641 ns |  0.09 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 26     | Random     | 2,543.17 ns | 256.244 ns | 227.153 ns |  1.83 |    0.21 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 26     | Random     | 1,611.21 ns | 132.817 ns | 117.739 ns |  1.16 |    0.12 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 26     | Random     | 1,669.25 ns | 101.230 ns |  89.738 ns |  1.20 |    0.11 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 26     | Random     |   122.70 ns |   5.205 ns |   4.614 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 26     | Random     | 1,499.03 ns |  36.715 ns |  30.659 ns |  1.08 |    0.09 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 26     | Random     | 1,523.76 ns |  52.654 ns |  46.677 ns |  1.10 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 26     | Random     | 1,492.36 ns |  55.623 ns |  49.309 ns |  1.07 |    0.09 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 26     | Random     | 1,960.72 ns |  88.825 ns |  74.173 ns |  1.41 |    0.12 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 26     | Random     | 1,550.51 ns |  39.462 ns |  34.982 ns |  1.12 |    0.09 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 26     | Random     | 1,479.49 ns |  41.271 ns |  36.586 ns |  1.07 |    0.09 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 26     | Random     | 1,094.71 ns | 105.214 ns |  93.270 ns |  0.79 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 26     | Random     |   123.71 ns |   4.075 ns |   3.612 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 26     | Random     |   143.56 ns |   6.845 ns |   6.068 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 26     | Random     | 1,347.58 ns |  44.983 ns |  37.563 ns |  0.97 |    0.08 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 26     | Random     |    41.69 ns |   2.362 ns |   2.094 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 26     | Random     |    91.53 ns |   2.248 ns |   1.877 ns |  0.07 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 26     | Random     |   731.82 ns |   7.787 ns |   6.079 ns |  0.53 |    0.04 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 26     | Random     |   117.02 ns |   2.215 ns |   1.964 ns |  0.08 |    0.01 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 26     | Random     |    71.58 ns |   2.495 ns |   2.212 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 26     | Random     |    58.86 ns |   1.920 ns |   1.702 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 26     | Random     |    99.39 ns |   3.018 ns |   2.520 ns |  0.07 |    0.01 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 26     | Random     |   103.61 ns |   2.961 ns |   2.625 ns |  0.07 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 26     | Random     |   105.37 ns |   2.090 ns |   1.853 ns |  0.08 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 26     | Random     |   768.35 ns |   3.460 ns |   2.889 ns |  0.55 |    0.04 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 26     | Random     |    42.66 ns |   1.429 ns |   1.266 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 26     | Random     |    96.41 ns |   2.177 ns |   1.930 ns |  0.07 |    0.01 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 26     | Random     |   473.13 ns |   4.701 ns |   3.670 ns |  0.34 |    0.03 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 26     | Random     |    56.72 ns |   2.322 ns |   1.939 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 26     | Random     |    94.33 ns |   1.819 ns |   1.612 ns |  0.07 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 26     | Random     |    95.23 ns |   2.178 ns |   1.931 ns |  0.07 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **26**     | **Sorted**     |   **789.95 ns** |  **20.222 ns** |  **16.887 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 26     | Sorted     |    80.75 ns |   8.890 ns |   7.880 ns |  0.10 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 26     | Sorted     |   813.88 ns |  15.208 ns |  12.700 ns |  1.03 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 26     | Sorted     |   784.36 ns |  13.497 ns |  11.964 ns |  0.99 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 26     | Sorted     |    91.09 ns |   1.854 ns |   1.644 ns |  0.12 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 26     | Sorted     |   816.30 ns |  15.604 ns |  13.832 ns |  1.03 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 26     | Sorted     |   684.37 ns |   3.294 ns |   2.572 ns |  0.87 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 26     | Sorted     |    58.92 ns |   1.932 ns |   1.712 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 26     | Sorted     |   769.09 ns |   6.360 ns |   4.966 ns |  0.97 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **26**     | **Reversed**   | **1,326.71 ns** |  **25.215 ns** |  **21.055 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 26     | Reversed   |   101.29 ns |   4.912 ns |   4.354 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 26     | Reversed   | 1,224.80 ns |  17.948 ns |  15.911 ns |  0.92 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 26     | Reversed   | 1,332.37 ns |  23.533 ns |  19.651 ns |  1.00 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 26     | Reversed   |   107.92 ns |   3.939 ns |   3.492 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 26     | Reversed   | 1,222.17 ns |  20.795 ns |  18.435 ns |  0.92 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 26     | Reversed   |   705.95 ns |  12.347 ns |  10.945 ns |  0.53 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 26     | Reversed   |    59.53 ns |   1.976 ns |   1.751 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 26     | Reversed   |   786.71 ns |  13.957 ns |  11.655 ns |  0.59 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **26**     | **Duplicates** | **1,619.36 ns** | **117.982 ns** | **104.588 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 26     | Duplicates |    95.49 ns |   3.632 ns |   3.220 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 26     | Duplicates | 1,958.10 ns | 103.428 ns |  91.686 ns |  1.21 |    0.11 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 26     | Duplicates | 1,656.58 ns |  36.567 ns |  32.416 ns |  1.03 |    0.08 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 26     | Duplicates |    99.21 ns |   4.168 ns |   3.695 ns |  0.06 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 26     | Duplicates | 1,979.22 ns |  98.568 ns |  82.309 ns |  1.23 |    0.10 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 26     | Duplicates |   619.34 ns |   8.440 ns |   7.048 ns |  0.38 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 26     | Duplicates |    58.69 ns |   2.114 ns |   1.874 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 26     | Duplicates | 1,067.25 ns |  12.877 ns |  10.753 ns |  0.66 |    0.05 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **27**     | **Random**     | **1,346.37 ns** |  **52.979 ns** |  **46.964 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 27     | Random     |    98.69 ns |   3.335 ns |   2.956 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 27     | Random     | 2,375.83 ns | 195.835 ns | 173.603 ns |  1.77 |    0.14 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 27     | Random     | 1,720.76 ns |  74.499 ns |  66.042 ns |  1.28 |    0.07 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 27     | Random     | 1,594.39 ns | 135.584 ns | 126.825 ns |  1.19 |    0.10 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 27     | Random     |   109.34 ns |   6.526 ns |   5.785 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 27     | Random     | 1,446.40 ns |  53.038 ns |  47.017 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 27     | Random     | 1,473.91 ns |  32.609 ns |  27.230 ns |  1.10 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 27     | Random     | 1,451.36 ns |  31.512 ns |  27.934 ns |  1.08 |    0.04 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 27     | Random     | 2,744.56 ns | 100.885 ns |  89.432 ns |  2.04 |    0.10 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 27     | Random     | 1,476.46 ns |  69.749 ns |  61.831 ns |  1.10 |    0.06 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 27     | Random     | 1,450.74 ns |  40.726 ns |  36.102 ns |  1.08 |    0.05 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 27     | Random     | 1,102.75 ns |  84.045 ns |  70.182 ns |  0.82 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 27     | Random     |   113.30 ns |   6.098 ns |   5.406 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 27     | Random     |   155.39 ns |   3.878 ns |   3.238 ns |  0.12 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 27     | Random     | 1,326.71 ns |  77.251 ns |  68.481 ns |  0.99 |    0.06 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 27     | Random     | 1,362.84 ns |  61.029 ns |  50.962 ns |  1.01 |    0.05 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 27     | Random     |   100.43 ns |   2.323 ns |   1.940 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 27     | Random     | 2,304.59 ns | 253.465 ns | 224.690 ns |  1.71 |    0.17 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 27     | Random     | 1,695.78 ns | 146.257 ns | 136.809 ns |  1.26 |    0.11 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 27     | Random     | 1,613.25 ns | 158.189 ns | 140.231 ns |  1.20 |    0.11 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 27     | Random     |   113.27 ns |   5.859 ns |   5.194 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 27     | Random     | 1,455.52 ns |  44.887 ns |  37.483 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 27     | Random     | 1,478.14 ns |  35.213 ns |  31.216 ns |  1.10 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 27     | Random     | 1,465.10 ns |  51.169 ns |  45.360 ns |  1.09 |    0.05 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 27     | Random     | 2,653.65 ns |  79.186 ns |  61.823 ns |  1.97 |    0.08 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 27     | Random     | 1,489.81 ns |  36.323 ns |  32.200 ns |  1.11 |    0.05 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 27     | Random     | 1,454.75 ns |  37.220 ns |  32.994 ns |  1.08 |    0.05 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 27     | Random     | 1,096.88 ns |  88.483 ns |  78.438 ns |  0.82 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 27     | Random     |   112.49 ns |   4.950 ns |   4.388 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 27     | Random     |   152.46 ns |  14.917 ns |  12.456 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 27     | Random     | 1,307.15 ns |  33.667 ns |  29.845 ns |  0.97 |    0.04 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 27     | Random     |    36.72 ns |   1.338 ns |   1.186 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 27     | Random     |    96.81 ns |   2.441 ns |   2.164 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 27     | Random     |   793.57 ns |   5.368 ns |   4.483 ns |  0.59 |    0.02 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 27     | Random     |    94.62 ns |   2.122 ns |   1.772 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 27     | Random     |    65.97 ns |   2.161 ns |   1.804 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 27     | Random     |    56.20 ns |   2.717 ns |   2.408 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 27     | Random     |   102.79 ns |   2.294 ns |   2.034 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 27     | Random     |   108.39 ns |   2.766 ns |   2.452 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 27     | Random     |   108.98 ns |   3.264 ns |   2.548 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 27     | Random     |   859.12 ns |   9.678 ns |   8.580 ns |  0.64 |    0.02 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 27     | Random     |    39.21 ns |   1.319 ns |   1.169 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 27     | Random     |   100.50 ns |   2.243 ns |   1.988 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 27     | Random     |   523.78 ns |   4.536 ns |   3.788 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 27     | Random     |    53.41 ns |   2.107 ns |   1.868 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 27     | Random     |    98.78 ns |   2.188 ns |   1.827 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 27     | Random     |   100.16 ns |   2.374 ns |   2.104 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **27**     | **Sorted**     |   **811.52 ns** |  **13.355 ns** |  **11.152 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 27     | Sorted     |    87.03 ns |   2.975 ns |   2.637 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 27     | Sorted     |   841.65 ns |  15.880 ns |  14.077 ns |  1.04 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 27     | Sorted     |   828.80 ns |  15.005 ns |  13.302 ns |  1.02 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 27     | Sorted     |    92.42 ns |   2.056 ns |   1.823 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 27     | Sorted     |   844.09 ns |  13.448 ns |  11.921 ns |  1.04 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 27     | Sorted     |   768.46 ns |   3.025 ns |   2.362 ns |  0.95 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 27     | Sorted     |    57.93 ns |   2.058 ns |   1.824 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 27     | Sorted     |   850.19 ns |   7.044 ns |   6.244 ns |  1.05 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **27**     | **Reversed**   | **1,342.95 ns** |  **25.505 ns** |  **22.609 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 27     | Reversed   |    95.18 ns |   4.227 ns |   3.530 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 27     | Reversed   | 1,271.84 ns |  17.548 ns |  15.556 ns |  0.95 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 27     | Reversed   | 1,354.28 ns |  55.133 ns |  48.874 ns |  1.01 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 27     | Reversed   |   102.74 ns |   7.595 ns |   6.342 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 27     | Reversed   | 1,255.13 ns |  20.643 ns |  18.299 ns |  0.93 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 27     | Reversed   |   784.77 ns |   9.777 ns |   7.634 ns |  0.58 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 27     | Reversed   |    55.86 ns |   2.101 ns |   1.863 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 27     | Reversed   |   863.51 ns |   6.822 ns |   6.047 ns |  0.64 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **27**     | **Duplicates** | **1,880.99 ns** | **125.941 ns** | **111.643 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 27     | Duplicates |   112.34 ns |   4.217 ns |   3.738 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 27     | Duplicates | 2,752.68 ns |  44.500 ns |  39.448 ns |  1.47 |    0.10 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 27     | Duplicates | 1,870.53 ns | 173.615 ns | 153.905 ns |  1.00 |    0.10 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 27     | Duplicates |   116.27 ns |   2.634 ns |   2.200 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 27     | Duplicates | 2,750.82 ns | 121.597 ns | 107.793 ns |  1.47 |    0.11 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 27     | Duplicates |   698.72 ns |   9.331 ns |   7.792 ns |  0.37 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 27     | Duplicates |    55.54 ns |   1.987 ns |   1.761 ns |  0.03 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 27     | Duplicates | 1,234.81 ns |  11.388 ns |  10.095 ns |  0.66 |    0.05 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **28**     | **Random**     | **1,537.77 ns** | **115.855 ns** | **102.702 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 28     | Random     |   127.93 ns |   9.450 ns |   7.891 ns |  0.08 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 28     | Random     | 2,718.43 ns | 323.299 ns | 269.969 ns |  1.78 |    0.22 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 28     | Random     | 1,932.30 ns |  43.902 ns |  38.918 ns |  1.26 |    0.10 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 28     | Random     | 1,802.61 ns | 136.057 ns | 127.268 ns |  1.18 |    0.12 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 28     | Random     |   138.84 ns |   5.636 ns |   4.996 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 28     | Random     | 1,658.29 ns |  77.965 ns |  69.114 ns |  1.08 |    0.09 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 28     | Random     | 1,656.17 ns |  38.721 ns |  32.334 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 28     | Random     | 1,644.97 ns |  75.250 ns |  66.707 ns |  1.07 |    0.09 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 28     | Random     | 2,328.51 ns |  49.511 ns |  41.344 ns |  1.52 |    0.12 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 28     | Random     | 1,671.52 ns | 130.293 ns | 108.800 ns |  1.09 |    0.11 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 28     | Random     | 1,634.04 ns |  84.236 ns |  74.673 ns |  1.07 |    0.09 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 28     | Random     | 1,163.69 ns | 162.092 ns | 143.690 ns |  0.76 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 28     | Random     |   135.70 ns |   1.314 ns |   1.165 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 28     | Random     |   168.32 ns |   3.026 ns |   2.682 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 28     | Random     | 1,525.67 ns |  69.451 ns |  57.994 ns |  1.00 |    0.08 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 28     | Random     | 1,544.60 ns |  89.574 ns |  74.798 ns |  1.01 |    0.09 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 28     | Random     |   136.72 ns |   2.957 ns |   2.621 ns |  0.09 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 28     | Random     | 2,828.67 ns | 128.890 ns | 100.629 ns |  1.85 |    0.15 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 28     | Random     | 1,727.44 ns | 143.069 ns | 126.827 ns |  1.13 |    0.12 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 28     | Random     | 1,851.81 ns |  98.502 ns |  87.320 ns |  1.21 |    0.11 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 28     | Random     |   143.00 ns |   2.604 ns |   2.308 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 28     | Random     | 1,646.00 ns | 105.847 ns |  93.831 ns |  1.08 |    0.10 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 28     | Random     | 1,667.15 ns |  26.194 ns |  21.873 ns |  1.09 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 28     | Random     | 1,665.56 ns |  71.324 ns |  63.227 ns |  1.09 |    0.09 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 28     | Random     | 2,324.85 ns |  83.158 ns |  69.441 ns |  1.52 |    0.12 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 28     | Random     | 1,699.24 ns |  54.667 ns |  45.650 ns |  1.11 |    0.09 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 28     | Random     | 1,643.27 ns |  89.251 ns |  79.119 ns |  1.07 |    0.09 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 28     | Random     | 1,138.40 ns | 184.069 ns | 143.709 ns |  0.74 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 28     | Random     |   141.63 ns |   3.779 ns |   3.155 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 28     | Random     |   169.10 ns |  14.718 ns |  13.047 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 28     | Random     | 1,538.21 ns |  42.345 ns |  37.537 ns |  1.01 |    0.08 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 28     | Random     |    37.06 ns |   1.375 ns |   1.219 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 28     | Random     |    99.02 ns |   2.317 ns |   1.935 ns |  0.06 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 28     | Random     |   846.82 ns |   6.710 ns |   5.603 ns |  0.55 |    0.04 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 28     | Random     |   100.65 ns |   1.786 ns |   1.491 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 28     | Random     |    66.09 ns |   1.660 ns |   1.472 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 28     | Random     |    56.14 ns |   3.202 ns |   2.839 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 28     | Random     |   106.53 ns |   2.807 ns |   2.191 ns |  0.07 |    0.01 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 28     | Random     |   112.09 ns |   2.444 ns |   2.166 ns |  0.07 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 28     | Random     |   112.28 ns |   2.559 ns |   2.269 ns |  0.07 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 28     | Random     |   891.75 ns |   3.509 ns |   2.930 ns |  0.58 |    0.04 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 28     | Random     |    40.09 ns |   1.478 ns |   1.310 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 28     | Random     |   104.26 ns |   2.336 ns |   2.071 ns |  0.07 |    0.01 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 28     | Random     |   541.91 ns |   5.488 ns |   4.865 ns |  0.35 |    0.03 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 28     | Random     |    53.76 ns |   3.282 ns |   2.909 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 28     | Random     |   105.23 ns |   2.585 ns |   2.292 ns |  0.07 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 28     | Random     |   103.34 ns |   2.259 ns |   2.003 ns |  0.07 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **28**     | **Sorted**     |   **836.81 ns** |  **18.305 ns** |  **15.286 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 28     | Sorted     |    89.88 ns |   3.685 ns |   3.267 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 28     | Sorted     |   873.37 ns |  14.237 ns |  11.889 ns |  1.04 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 28     | Sorted     |   853.80 ns |  14.543 ns |  12.892 ns |  1.02 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 28     | Sorted     |    90.71 ns |   3.042 ns |   2.696 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 28     | Sorted     |   860.71 ns |  15.170 ns |  13.448 ns |  1.03 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 28     | Sorted     |   790.62 ns |  12.425 ns |  10.375 ns |  0.95 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 28     | Sorted     |    55.23 ns |   2.145 ns |   1.902 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 28     | Sorted     |   863.52 ns |   5.125 ns |   4.001 ns |  1.03 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **28**     | **Reversed**   | **1,385.71 ns** |  **53.502 ns** |  **47.428 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 28     | Reversed   |   107.66 ns |   3.820 ns |   3.387 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 28     | Reversed   | 1,320.44 ns |  20.917 ns |  18.543 ns |  0.95 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 28     | Reversed   | 1,391.66 ns |  40.991 ns |  36.337 ns |  1.01 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 28     | Reversed   |   109.56 ns |   5.977 ns |   5.298 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 28     | Reversed   | 1,321.16 ns |  18.258 ns |  16.185 ns |  0.95 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 28     | Reversed   |   807.10 ns |   7.780 ns |   6.074 ns |  0.58 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 28     | Reversed   |    57.29 ns |   2.972 ns |   2.634 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 28     | Reversed   |   901.04 ns |   7.074 ns |   6.271 ns |  0.65 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **28**     | **Duplicates** | **1,989.40 ns** |  **46.956 ns** |  **41.625 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 28     | Duplicates |   114.06 ns |   3.018 ns |   2.675 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 28     | Duplicates | 2,373.33 ns | 115.140 ns | 102.069 ns |  1.19 |    0.06 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 28     | Duplicates | 2,009.04 ns | 147.291 ns | 130.570 ns |  1.01 |    0.07 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 28     | Duplicates |   118.32 ns |   3.181 ns |   2.656 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 28     | Duplicates | 2,406.39 ns | 211.384 ns | 187.386 ns |  1.21 |    0.09 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 28     | Duplicates |   706.88 ns |   4.370 ns |   3.649 ns |  0.36 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 28     | Duplicates |    55.64 ns |   3.226 ns |   2.860 ns |  0.03 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 28     | Duplicates | 1,267.49 ns |   9.318 ns |   8.260 ns |  0.64 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **29**     | **Random**     | **1,446.65 ns** |  **81.023 ns** |  **63.258 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 29     | Random     |   108.67 ns |   1.894 ns |   1.582 ns |  0.08 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 29     | Random     | 2,708.54 ns | 222.049 ns | 196.840 ns |  1.88 |    0.16 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 29     | Random     | 1,837.59 ns |  60.562 ns |  53.687 ns |  1.27 |    0.07 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 29     | Random     | 1,747.50 ns | 113.467 ns | 106.137 ns |  1.21 |    0.09 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 29     | Random     |   123.31 ns |   5.118 ns |   4.537 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 29     | Random     | 1,586.11 ns |  78.298 ns |  69.409 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 29     | Random     | 1,614.59 ns |  89.187 ns |  74.475 ns |  1.12 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 29     | Random     | 1,568.13 ns |  78.648 ns |  69.719 ns |  1.09 |    0.07 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 29     | Random     | 2,596.21 ns |  63.404 ns |  56.206 ns |  1.80 |    0.09 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 29     | Random     | 1,583.64 ns | 117.392 ns |  98.027 ns |  1.10 |    0.08 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 29     | Random     | 1,634.51 ns |  45.776 ns |  40.579 ns |  1.13 |    0.06 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 29     | Random     | 1,241.06 ns | 135.278 ns | 119.920 ns |  0.86 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 29     | Random     |   124.19 ns |   6.581 ns |   5.834 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 29     | Random     |   171.81 ns |   4.964 ns |   4.401 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 29     | Random     | 1,465.40 ns |  23.105 ns |  20.482 ns |  1.01 |    0.05 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 29     | Random     | 1,468.61 ns |  42.930 ns |  38.056 ns |  1.02 |    0.05 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 29     | Random     |   113.87 ns |   8.221 ns |   7.288 ns |  0.08 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 29     | Random     | 2,604.77 ns | 304.621 ns | 284.943 ns |  1.80 |    0.21 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 29     | Random     | 1,817.99 ns |  87.873 ns |  77.897 ns |  1.26 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 29     | Random     | 1,731.09 ns |  99.055 ns |  87.810 ns |  1.20 |    0.08 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 29     | Random     |   130.66 ns |   4.083 ns |   3.619 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 29     | Random     | 1,601.31 ns |  32.398 ns |  28.720 ns |  1.11 |    0.06 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 29     | Random     | 1,618.84 ns |  56.216 ns |  49.834 ns |  1.12 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 29     | Random     | 1,626.66 ns |  42.395 ns |  37.582 ns |  1.13 |    0.06 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 29     | Random     | 2,665.63 ns |  47.570 ns |  39.723 ns |  1.85 |    0.09 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 29     | Random     | 1,601.69 ns |  84.953 ns |  70.940 ns |  1.11 |    0.07 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 29     | Random     | 1,615.80 ns |  33.750 ns |  29.918 ns |  1.12 |    0.06 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 29     | Random     | 1,261.31 ns |  86.286 ns |  76.490 ns |  0.87 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 29     | Random     |   121.48 ns |   4.589 ns |   3.832 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 29     | Random     |   163.63 ns |   4.433 ns |   3.930 ns |  0.11 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 29     | Random     | 1,431.51 ns |  29.912 ns |  26.516 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 29     | Random     |    38.57 ns |   1.462 ns |   1.296 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 29     | Random     |   105.99 ns |   1.967 ns |   1.743 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 29     | Random     |   896.20 ns |  12.047 ns |  10.679 ns |  0.62 |    0.03 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 29     | Random     |   136.14 ns |   1.959 ns |   1.736 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 29     | Random     |    74.53 ns |   2.616 ns |   2.319 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 29     | Random     |    63.00 ns |   1.963 ns |   1.740 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 29     | Random     |   115.51 ns |   3.542 ns |   3.140 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 29     | Random     |   120.96 ns |   3.095 ns |   2.743 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 29     | Random     |   120.71 ns |   3.052 ns |   2.548 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 29     | Random     |   918.77 ns |   7.627 ns |   6.369 ns |  0.64 |    0.03 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 29     | Random     |    41.43 ns |   1.499 ns |   1.329 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 29     | Random     |   110.81 ns |   2.373 ns |   2.103 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 29     | Random     |   565.75 ns |  11.036 ns |   9.783 ns |  0.39 |    0.02 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 29     | Random     |    61.90 ns |   2.070 ns |   1.835 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 29     | Random     |   110.32 ns |   2.464 ns |   1.924 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 29     | Random     |   111.33 ns |   2.450 ns |   2.172 ns |  0.08 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **29**     | **Sorted**     |   **873.87 ns** |  **19.307 ns** |  **15.074 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 29     | Sorted     |    88.75 ns |   2.195 ns |   1.946 ns |  0.10 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 29     | Sorted     |   895.01 ns |  13.552 ns |  12.014 ns |  1.02 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 29     | Sorted     |   873.96 ns |  16.223 ns |  13.547 ns |  1.00 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 29     | Sorted     |    95.96 ns |   3.036 ns |   2.692 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 29     | Sorted     |   901.99 ns |  16.621 ns |  14.734 ns |  1.03 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 29     | Sorted     |   817.02 ns |  16.394 ns |  13.690 ns |  0.94 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 29     | Sorted     |    64.34 ns |   2.136 ns |   1.894 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 29     | Sorted     |   894.78 ns |   3.686 ns |   2.878 ns |  1.02 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **29**     | **Reversed**   | **1,426.26 ns** |  **27.729 ns** |  **24.581 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 29     | Reversed   |   103.50 ns |   8.879 ns |   7.871 ns |  0.07 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 29     | Reversed   | 1,347.19 ns |  19.307 ns |  17.115 ns |  0.94 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 29     | Reversed   | 1,445.60 ns |  42.772 ns |  37.916 ns |  1.01 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 29     | Reversed   |   113.58 ns |   2.820 ns |   2.500 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 29     | Reversed   | 1,348.40 ns |  20.561 ns |  17.170 ns |  0.95 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 29     | Reversed   |   840.77 ns |  12.187 ns |  10.803 ns |  0.59 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 29     | Reversed   |    64.64 ns |   2.698 ns |   2.253 ns |  0.05 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 29     | Reversed   |   926.32 ns |   4.087 ns |   3.191 ns |  0.65 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **29**     | **Duplicates** | **1,857.13 ns** |  **62.941 ns** |  **58.875 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 29     | Duplicates |   108.86 ns |   3.990 ns |   3.537 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 29     | Duplicates | 2,848.48 ns | 183.053 ns | 152.857 ns |  1.54 |    0.09 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 29     | Duplicates | 1,858.20 ns |  86.164 ns |  76.382 ns |  1.00 |    0.05 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 29     | Duplicates |   113.77 ns |   3.683 ns |   3.265 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 29     | Duplicates | 2,900.22 ns | 151.951 ns | 134.700 ns |  1.56 |    0.09 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 29     | Duplicates |   743.61 ns |  18.478 ns |  16.381 ns |  0.40 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 29     | Duplicates |    62.61 ns |   2.152 ns |   1.908 ns |  0.03 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 29     | Duplicates | 1,353.70 ns |  28.065 ns |  24.879 ns |  0.73 |    0.03 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **30**     | **Random**     | **1,479.48 ns** |  **84.307 ns** |  **74.736 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 30     | Random     |   119.88 ns |   3.354 ns |   2.973 ns |  0.08 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 30     | Random     | 2,666.78 ns | 302.595 ns | 268.243 ns |  1.81 |    0.20 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 30     | Random     | 1,889.41 ns |  44.803 ns |  39.716 ns |  1.28 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 30     | Random     | 1,718.49 ns | 202.626 ns | 179.623 ns |  1.16 |    0.13 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 30     | Random     |   118.54 ns |   3.414 ns |   3.026 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 30     | Random     | 1,584.84 ns | 124.314 ns | 110.201 ns |  1.07 |    0.09 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 30     | Random     | 1,581.56 ns |  93.923 ns |  83.260 ns |  1.07 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 30     | Random     | 1,608.40 ns |  64.330 ns |  57.027 ns |  1.09 |    0.07 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 30     | Random     | 2,642.38 ns |  61.266 ns |  51.160 ns |  1.79 |    0.10 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 30     | Random     | 1,625.56 ns |  99.118 ns |  87.866 ns |  1.10 |    0.08 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 30     | Random     | 1,576.52 ns |  78.137 ns |  69.266 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 30     | Random     | 1,325.40 ns | 164.164 ns | 137.085 ns |  0.90 |    0.10 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 30     | Random     |   119.99 ns |   2.913 ns |   2.583 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 30     | Random     |   141.55 ns |   8.768 ns |   7.321 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 30     | Random     | 1,482.54 ns |  91.881 ns |  81.450 ns |  1.00 |    0.08 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 30     | Random     | 1,493.31 ns | 109.259 ns |  96.855 ns |  1.01 |    0.08 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 30     | Random     |   123.91 ns |   3.942 ns |   3.292 ns |  0.08 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 30     | Random     | 2,651.24 ns | 213.002 ns | 188.820 ns |  1.80 |    0.16 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 30     | Random     | 1,781.40 ns | 168.068 ns | 157.211 ns |  1.21 |    0.12 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 30     | Random     | 1,792.34 ns | 151.309 ns | 141.535 ns |  1.21 |    0.11 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 30     | Random     |   119.88 ns |   5.602 ns |   4.966 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 30     | Random     | 1,646.34 ns |  42.878 ns |  38.011 ns |  1.12 |    0.07 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 30     | Random     | 1,594.00 ns | 116.999 ns | 103.716 ns |  1.08 |    0.09 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 30     | Random     | 1,574.19 ns | 134.496 ns | 119.227 ns |  1.07 |    0.10 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 30     | Random     | 2,598.54 ns |  74.482 ns |  66.026 ns |  1.76 |    0.11 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 30     | Random     | 1,634.19 ns |  47.448 ns |  42.062 ns |  1.11 |    0.07 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 30     | Random     | 1,605.18 ns |  50.414 ns |  44.691 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 30     | Random     | 1,302.64 ns | 161.925 ns | 143.543 ns |  0.88 |    0.11 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 30     | Random     |   117.63 ns |   5.678 ns |   4.741 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 30     | Random     |   140.38 ns |   8.493 ns |   7.092 ns |  0.10 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 30     | Random     | 1,553.99 ns |  64.058 ns |  56.785 ns |  1.05 |    0.07 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 30     | Random     |    41.34 ns |   1.664 ns |   1.475 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 30     | Random     |   109.90 ns |   1.978 ns |   1.753 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 30     | Random     |   943.55 ns |  14.893 ns |  13.202 ns |  0.64 |    0.04 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 30     | Random     |   123.76 ns |   2.152 ns |   1.908 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 30     | Random     |    74.03 ns |   2.743 ns |   2.432 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 30     | Random     |    64.82 ns |   2.770 ns |   2.162 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 30     | Random     |   119.24 ns |   2.116 ns |   1.876 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 30     | Random     |   125.32 ns |   2.845 ns |   2.522 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 30     | Random     |   125.53 ns |   2.669 ns |   2.366 ns |  0.09 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 30     | Random     |   967.25 ns |  10.583 ns |   9.381 ns |  0.66 |    0.04 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 30     | Random     |    43.31 ns |   1.265 ns |   1.122 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 30     | Random     |   115.90 ns |   2.130 ns |   1.888 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 30     | Random     |   597.12 ns |  11.525 ns |  10.217 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 30     | Random     |    60.29 ns |   2.579 ns |   2.287 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 30     | Random     |   117.75 ns |   2.856 ns |   2.532 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 30     | Random     |   116.08 ns |   2.305 ns |   2.043 ns |  0.08 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **30**     | **Sorted**     |   **894.78 ns** |  **19.468 ns** |  **17.258 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 30     | Sorted     |    93.76 ns |   6.673 ns |   5.916 ns |  0.10 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 30     | Sorted     |   914.38 ns |  13.257 ns |  11.752 ns |  1.02 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 30     | Sorted     |   877.57 ns |  16.243 ns |  14.399 ns |  0.98 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 30     | Sorted     |    94.83 ns |   9.752 ns |   8.645 ns |  0.11 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 30     | Sorted     |   938.43 ns |  13.821 ns |  12.252 ns |  1.05 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 30     | Sorted     |   850.99 ns |   6.256 ns |   4.884 ns |  0.95 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 30     | Sorted     |    64.24 ns |   2.651 ns |   2.350 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 30     | Sorted     |   940.19 ns |   9.210 ns |   8.165 ns |  1.05 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **30**     | **Reversed**   | **1,509.29 ns** |  **25.246 ns** |  **22.380 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 30     | Reversed   |   110.82 ns |   3.372 ns |   2.989 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 30     | Reversed   | 1,410.89 ns |  23.672 ns |  20.985 ns |  0.93 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 30     | Reversed   | 1,512.32 ns |  34.522 ns |  30.603 ns |  1.00 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 30     | Reversed   |   122.76 ns |   4.024 ns |   3.567 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 30     | Reversed   | 1,440.90 ns |  24.699 ns |  21.895 ns |  0.95 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 30     | Reversed   |   873.59 ns |   8.372 ns |   7.422 ns |  0.58 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 30     | Reversed   |    64.90 ns |   2.125 ns |   1.884 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 30     | Reversed   |   970.28 ns |   8.007 ns |   6.686 ns |  0.64 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **30**     | **Duplicates** | **2,037.11 ns** | **178.082 ns** | **157.865 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 30     | Duplicates |   115.78 ns |   2.184 ns |   1.936 ns |  0.06 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 30     | Duplicates | 2,407.02 ns |  36.097 ns |  30.143 ns |  1.19 |    0.12 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 30     | Duplicates | 2,029.44 ns | 198.156 ns | 175.660 ns |  1.00 |    0.13 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 30     | Duplicates |   118.96 ns |   3.086 ns |   2.736 ns |  0.06 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 30     | Duplicates | 2,409.40 ns |  60.857 ns |  53.948 ns |  1.19 |    0.12 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 30     | Duplicates |   774.84 ns |   6.698 ns |   5.938 ns |  0.38 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 30     | Duplicates |    64.02 ns |   2.309 ns |   1.803 ns |  0.03 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 30     | Duplicates | 1,422.57 ns |  21.871 ns |  19.388 ns |  0.70 |    0.07 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **31**     | **Random**     | **1,665.73 ns** |  **96.471 ns** |  **85.519 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 31     | Random     |   127.19 ns |   5.398 ns |   4.508 ns |  0.08 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 31     | Random     | 3,069.60 ns | 292.274 ns | 259.093 ns |  1.85 |    0.18 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 31     | Random     | 2,076.26 ns | 102.562 ns |  90.919 ns |  1.25 |    0.08 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 31     | Random     | 1,998.25 ns | 197.740 ns | 184.966 ns |  1.20 |    0.13 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 31     | Random     |   147.77 ns |   7.063 ns |   6.261 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 31     | Random     | 1,812.34 ns |  34.552 ns |  30.629 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 31     | Random     | 1,814.02 ns | 117.157 ns | 103.856 ns |  1.09 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 31     | Random     | 1,824.78 ns |  42.918 ns |  35.839 ns |  1.10 |    0.06 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 31     | Random     | 2,770.26 ns |  89.906 ns |  79.699 ns |  1.67 |    0.10 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 31     | Random     | 1,815.95 ns |  89.756 ns |  79.566 ns |  1.09 |    0.07 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 31     | Random     | 1,782.00 ns |  88.451 ns |  78.410 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 31     | Random     | 1,385.57 ns | 143.151 ns | 126.899 ns |  0.83 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 31     | Random     |   140.77 ns |   6.611 ns |   5.860 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 31     | Random     |   194.70 ns |   2.943 ns |   2.609 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 31     | Random     | 1,687.76 ns |  66.026 ns |  58.531 ns |  1.02 |    0.06 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 31     | Random     | 1,704.53 ns |  65.994 ns |  58.502 ns |  1.03 |    0.06 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 31     | Random     |   136.01 ns |   6.682 ns |   5.923 ns |  0.08 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 31     | Random     | 3,100.56 ns | 227.384 ns | 201.570 ns |  1.87 |    0.15 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 31     | Random     | 1,939.60 ns | 176.651 ns | 165.239 ns |  1.17 |    0.11 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 31     | Random     | 1,993.65 ns | 147.700 ns | 138.159 ns |  1.20 |    0.10 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 31     | Random     |   150.34 ns |   6.787 ns |   6.016 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 31     | Random     | 1,816.86 ns |  82.887 ns |  73.477 ns |  1.09 |    0.07 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 31     | Random     | 1,805.34 ns |  90.079 ns |  79.853 ns |  1.09 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 31     | Random     | 1,846.86 ns |  78.696 ns |  69.762 ns |  1.11 |    0.07 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 31     | Random     | 2,767.82 ns |  35.449 ns |  27.676 ns |  1.67 |    0.09 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 31     | Random     | 1,835.34 ns |  50.682 ns |  44.928 ns |  1.10 |    0.06 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 31     | Random     | 1,782.76 ns | 109.521 ns |  97.087 ns |  1.07 |    0.08 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 31     | Random     | 1,373.97 ns | 173.067 ns | 144.519 ns |  0.83 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 31     | Random     |   136.19 ns |   8.763 ns |   7.768 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 31     | Random     |   194.02 ns |   3.816 ns |   3.383 ns |  0.12 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 31     | Random     | 1,631.51 ns |  66.842 ns |  59.254 ns |  0.98 |    0.06 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 31     | Random     |    38.89 ns |   1.741 ns |   1.544 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 31     | Random     |   110.91 ns |   2.136 ns |   1.894 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 31     | Random     |   978.84 ns |  16.044 ns |  14.223 ns |  0.59 |    0.03 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 31     | Random     |   125.40 ns |   2.172 ns |   1.926 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 31     | Random     |    70.63 ns |   1.128 ns |   1.000 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 31     | Random     |    58.29 ns |   2.496 ns |   2.213 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 31     | Random     |   118.88 ns |   2.787 ns |   2.327 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 31     | Random     |   125.86 ns |   4.815 ns |   4.021 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 31     | Random     |   124.82 ns |   3.173 ns |   2.649 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 31     | Random     | 1,001.18 ns |   8.990 ns |   7.969 ns |  0.60 |    0.03 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 31     | Random     |    41.07 ns |   1.306 ns |   1.090 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 31     | Random     |   114.87 ns |   2.333 ns |   2.068 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 31     | Random     |   613.65 ns |  12.458 ns |  10.403 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 31     | Random     |    57.59 ns |   2.971 ns |   2.633 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 31     | Random     |   115.99 ns |   2.358 ns |   1.841 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 31     | Random     |   116.09 ns |   2.564 ns |   2.273 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **31**     | **Sorted**     |   **913.51 ns** |  **18.473 ns** |  **16.376 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 31     | Sorted     |    88.83 ns |   2.100 ns |   1.862 ns |  0.10 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 31     | Sorted     |   936.08 ns |  22.107 ns |  19.597 ns |  1.03 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 31     | Sorted     |   919.89 ns |  22.783 ns |  20.196 ns |  1.01 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 31     | Sorted     |    98.25 ns |   2.612 ns |   2.181 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 31     | Sorted     |   947.74 ns |  16.689 ns |  14.795 ns |  1.04 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 31     | Sorted     |   888.07 ns |   3.312 ns |   2.766 ns |  0.97 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 31     | Sorted     |    61.66 ns |   2.575 ns |   2.283 ns |  0.07 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 31     | Sorted     | 1,006.42 ns |   2.605 ns |   2.034 ns |  1.10 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **31**     | **Reversed**   | **1,511.68 ns** |  **33.543 ns** |  **29.735 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 31     | Reversed   |   113.89 ns |   2.897 ns |   2.568 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 31     | Reversed   | 1,444.80 ns |  23.310 ns |  20.664 ns |  0.96 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 31     | Reversed   | 1,521.09 ns |  39.173 ns |  34.726 ns |  1.01 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 31     | Reversed   |   120.06 ns |   2.527 ns |   2.240 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 31     | Reversed   | 1,443.74 ns |  22.425 ns |  19.879 ns |  0.96 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 31     | Reversed   |   916.65 ns |  10.654 ns |   9.444 ns |  0.61 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 31     | Reversed   |    59.28 ns |   2.811 ns |   2.347 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 31     | Reversed   | 1,004.66 ns |   4.058 ns |   3.597 ns |  0.66 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **31**     | **Duplicates** | **1,942.67 ns** | **181.018 ns** | **160.468 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 31     | Duplicates |   127.54 ns |   3.149 ns |   2.792 ns |  0.07 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 31     | Duplicates | 2,766.74 ns | 215.133 ns | 190.710 ns |  1.43 |    0.16 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 31     | Duplicates | 1,995.71 ns |  95.832 ns |  84.953 ns |  1.03 |    0.10 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 31     | Duplicates |   132.79 ns |   5.463 ns |   4.843 ns |  0.07 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 31     | Duplicates | 2,780.43 ns | 191.476 ns | 169.739 ns |  1.44 |    0.16 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 31     | Duplicates |   822.50 ns |  11.736 ns |   9.800 ns |  0.43 |    0.04 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 31     | Duplicates |    58.58 ns |   2.134 ns |   1.666 ns |  0.03 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 31     | Duplicates | 1,468.72 ns |  14.327 ns |  12.700 ns |  0.76 |    0.07 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **32**     | **Random**     | **1,717.75 ns** | **120.400 ns** | **100.540 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| CharSortingBenchmarks    | ArraySort     | 32     | Random     |   129.08 ns |   8.608 ns |   6.721 ns |  0.08 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | ArraySort     | 32     | Random     | 3,245.62 ns | 150.387 ns | 133.314 ns |  1.90 |    0.15 |         - |          NA |
| DoubleSortingBenchmarks  | ArraySort     | 32     | Random     | 2,103.72 ns | 133.179 ns | 118.060 ns |  1.23 |    0.11 |         - |          NA |
| FloatSortingBenchmarks   | ArraySort     | 32     | Random     | 1,993.41 ns | 219.280 ns | 205.115 ns |  1.16 |    0.14 |         - |          NA |
| IntSortingBenchmarks     | ArraySort     | 32     | Random     |   155.69 ns |   5.765 ns |   5.111 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | ArraySort     | 32     | Random     | 1,839.06 ns |  92.014 ns |  81.568 ns |  1.07 |    0.08 |         - |          NA |
| NIntSortingBenchmarks    | ArraySort     | 32     | Random     | 1,867.33 ns |  40.547 ns |  35.943 ns |  1.09 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | ArraySort     | 32     | Random     | 1,862.10 ns |  44.660 ns |  39.590 ns |  1.09 |    0.08 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 32     | Random     | 2,998.62 ns |  65.008 ns |  57.627 ns |  1.75 |    0.12 |         - |          NA |
| SByteSortingBenchmarks   | ArraySort     | 32     | Random     | 1,912.29 ns |  45.407 ns |  40.252 ns |  1.12 |    0.08 |         - |          NA |
| ShortSortingBenchmarks   | ArraySort     | 32     | Random     | 1,819.36 ns | 113.868 ns | 100.941 ns |  1.06 |    0.09 |         - |          NA |
| StringSortingBenchmarks  | ArraySort     | 32     | Random     | 1,318.65 ns | 152.023 ns | 134.764 ns |  0.77 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks    | ArraySort     | 32     | Random     |   148.85 ns |   6.663 ns |   5.907 ns |  0.09 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | ArraySort     | 32     | Random     |   206.14 ns |  35.089 ns |  31.105 ns |  0.12 |    0.02 |         - |          NA |
| UShortSortingBenchmarks  | ArraySort     | 32     | Random     | 1,705.18 ns |  96.877 ns |  80.897 ns |  1.00 |    0.08 |         - |          NA |
| ByteSortingBenchmarks    | SpanSort      | 32     | Random     | 1,740.02 ns |  96.053 ns |  85.149 ns |  1.02 |    0.08 |         - |          NA |
| CharSortingBenchmarks    | SpanSort      | 32     | Random     |   133.81 ns |   4.801 ns |   4.256 ns |  0.08 |    0.01 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 32     | Random     | 3,082.92 ns | 379.999 ns | 296.678 ns |  1.80 |    0.21 |         - |          NA |
| DoubleSortingBenchmarks  | SpanSort      | 32     | Random     | 1,999.93 ns | 256.929 ns | 240.332 ns |  1.17 |    0.16 |         - |          NA |
| FloatSortingBenchmarks   | SpanSort      | 32     | Random     | 2,121.28 ns |  85.082 ns |  71.047 ns |  1.24 |    0.09 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 32     | Random     |   164.67 ns |   2.208 ns |   1.844 ns |  0.10 |    0.01 |         - |          NA |
| LongSortingBenchmarks    | SpanSort      | 32     | Random     | 1,868.19 ns |  55.494 ns |  49.194 ns |  1.09 |    0.08 |         - |          NA |
| NIntSortingBenchmarks    | SpanSort      | 32     | Random     | 1,851.04 ns |  89.776 ns |  74.967 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks   | SpanSort      | 32     | Random     | 1,876.84 ns |  71.562 ns |  63.438 ns |  1.10 |    0.08 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 32     | Random     | 2,980.16 ns |  71.121 ns |  59.389 ns |  1.74 |    0.12 |         - |          NA |
| SByteSortingBenchmarks   | SpanSort      | 32     | Random     | 1,851.25 ns | 129.975 ns | 115.220 ns |  1.08 |    0.10 |         - |          NA |
| ShortSortingBenchmarks   | SpanSort      | 32     | Random     | 1,885.67 ns | 126.795 ns | 112.400 ns |  1.10 |    0.10 |         - |          NA |
| StringSortingBenchmarks  | SpanSort      | 32     | Random     | 1,347.19 ns | 120.001 ns | 106.378 ns |  0.79 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks    | SpanSort      | 32     | Random     |   144.30 ns |   2.934 ns |   2.450 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks   | SpanSort      | 32     | Random     |   221.21 ns |   3.703 ns |   3.283 ns |  0.13 |    0.01 |         - |          NA |
| UShortSortingBenchmarks  | SpanSort      | 32     | Random     | 1,688.65 ns |  68.959 ns |  61.131 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 32     | Random     |    38.09 ns |   1.778 ns |   1.576 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 32     | Random     |   114.48 ns |   2.700 ns |   2.255 ns |  0.07 |    0.00 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 32     | Random     | 1,017.25 ns |  14.982 ns |  12.511 ns |  0.59 |    0.04 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 32     | Random     |   125.73 ns |   1.690 ns |   1.411 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 32     | Random     |    70.72 ns |   4.165 ns |   3.478 ns |  0.04 |    0.00 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 32     | Random     |    59.04 ns |   3.503 ns |   2.925 ns |  0.03 |    0.00 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 32     | Random     |   125.65 ns |   2.412 ns |   2.138 ns |  0.07 |    0.01 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 32     | Random     |   131.73 ns |   2.683 ns |   2.241 ns |  0.08 |    0.01 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 32     | Random     |   132.12 ns |   3.610 ns |   3.015 ns |  0.08 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 32     | Random     | 1,037.48 ns |   4.459 ns |   3.481 ns |  0.61 |    0.04 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 32     | Random     |    40.11 ns |   1.538 ns |   1.364 ns |  0.02 |    0.00 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 32     | Random     |   120.74 ns |   2.294 ns |   2.033 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks  | GeneratedSort | 32     | Random     |   624.29 ns |   4.901 ns |   4.093 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 32     | Random     |    55.05 ns |   2.536 ns |   1.980 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 32     | Random     |   123.42 ns |   2.897 ns |   2.261 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 32     | Random     |   121.07 ns |   2.695 ns |   2.251 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **32**     | **Sorted**     |   **938.80 ns** |  **25.864 ns** |  **21.598 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 32     | Sorted     |    93.26 ns |   2.745 ns |   2.433 ns |  0.10 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 32     | Sorted     |   970.75 ns |  16.515 ns |  14.640 ns |  1.03 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 32     | Sorted     |   939.36 ns |  21.740 ns |  19.272 ns |  1.00 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 32     | Sorted     |    99.87 ns |   2.133 ns |   1.891 ns |  0.11 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 32     | Sorted     |   991.61 ns |  15.542 ns |  13.777 ns |  1.06 |    0.03 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 32     | Sorted     |   917.29 ns |   7.502 ns |   6.651 ns |  0.98 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 32     | Sorted     |    57.86 ns |   2.126 ns |   1.884 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 32     | Sorted     | 1,002.42 ns |   6.483 ns |   5.414 ns |  1.07 |    0.02 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **32**     | **Reversed**   | **1,562.13 ns** |  **32.374 ns** |  **28.699 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 32     | Reversed   |   117.67 ns |  10.101 ns |   7.886 ns |  0.08 |    0.01 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 32     | Reversed   | 1,485.29 ns |  18.610 ns |  16.497 ns |  0.95 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 32     | Reversed   | 1,608.21 ns |  25.151 ns |  22.296 ns |  1.03 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 32     | Reversed   |   127.71 ns |   3.047 ns |   2.701 ns |  0.08 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 32     | Reversed   | 1,498.44 ns |  16.001 ns |  13.361 ns |  0.96 |    0.02 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 32     | Reversed   |   932.10 ns |   5.290 ns |   4.130 ns |  0.60 |    0.01 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 32     | Reversed   |    57.77 ns |   2.289 ns |   2.029 ns |  0.04 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 32     | Reversed   | 1,081.21 ns |  15.417 ns |  13.667 ns |  0.69 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DecimalSortingBenchmarks** | **ArraySort**     | **32**     | **Duplicates** | **2,199.25 ns** | **125.768 ns** | **111.490 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| IntSortingBenchmarks     | ArraySort     | 32     | Duplicates |   126.27 ns |   4.584 ns |   4.063 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | ArraySort     | 32     | Duplicates | 2,909.73 ns | 104.567 ns |  92.696 ns |  1.33 |    0.08 |         - |          NA |
| DecimalSortingBenchmarks | SpanSort      | 32     | Duplicates | 2,296.33 ns |  63.350 ns |  56.158 ns |  1.05 |    0.06 |         - |          NA |
| IntSortingBenchmarks     | SpanSort      | 32     | Duplicates |   129.76 ns |   4.475 ns |   3.967 ns |  0.06 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | SpanSort      | 32     | Duplicates | 2,962.77 ns | 111.035 ns |  98.429 ns |  1.35 |    0.08 |         - |          NA |
| DecimalSortingBenchmarks | GeneratedSort | 32     | Duplicates |   847.35 ns |   5.327 ns |   4.722 ns |  0.39 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 32     | Duplicates |    57.87 ns |   2.228 ns |   1.975 ns |  0.03 |    0.00 |         - |          NA |
| RecordSortingBenchmarks  | GeneratedSort | 32     | Duplicates | 1,483.58 ns |   5.930 ns |   4.952 ns |  0.68 |    0.04 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**    | **ArraySort**     | **34**     | **Random**     | **1,928.84 ns** | **103.751 ns** |  **86.637 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| ByteSortingBenchmarks    | SpanSort      | 34     | Random     | 2,030.58 ns | 121.604 ns | 101.545 ns |  1.05 |    0.07 |         - |          NA |
| ByteSortingBenchmarks    | GeneratedSort | 34     | Random     |   131.38 ns |   2.679 ns |   2.375 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **FloatSortingBenchmarks**   | **ArraySort**     | **36**     | **Random**     | **2,100.39 ns** | **166.591 ns** | **147.679 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| FloatSortingBenchmarks   | SpanSort      | 36     | Random     | 2,202.51 ns | 143.959 ns | 134.659 ns |  1.05 |    0.10 |         - |          NA |
| FloatSortingBenchmarks   | GeneratedSort | 36     | Random     |    89.80 ns |   2.153 ns |   1.908 ns |  0.04 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **SByteSortingBenchmarks**   | **ArraySort**     | **38**     | **Random**     | **2,562.58 ns** | **147.900 ns** | **131.109 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| SByteSortingBenchmarks   | SpanSort      | 38     | Random     | 2,541.82 ns | 148.835 ns | 131.938 ns |  0.99 |    0.08 |         - |          NA |
| SByteSortingBenchmarks   | GeneratedSort | 38     | Random     |   155.02 ns |   2.871 ns |   2.398 ns |  0.06 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ShortSortingBenchmarks**   | **ArraySort**     | **40**     | **Random**     | **2,364.12 ns** | **187.812 ns** | **166.490 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| ShortSortingBenchmarks   | SpanSort      | 40     | Random     | 2,371.88 ns | 184.703 ns | 163.734 ns |  1.01 |    0.10 |         - |          NA |
| ShortSortingBenchmarks   | GeneratedSort | 40     | Random     |   164.93 ns |   2.767 ns |   2.310 ns |  0.07 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **UShortSortingBenchmarks**  | **ArraySort**     | **42**     | **Random**     | **2,557.74 ns** |  **38.418 ns** |  **34.056 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| UShortSortingBenchmarks  | SpanSort      | 42     | Random     | 2,487.85 ns |  80.544 ns |  71.400 ns |  0.97 |    0.03 |         - |          NA |
| UShortSortingBenchmarks  | GeneratedSort | 42     | Random     |   173.29 ns |   2.721 ns |   2.412 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **DoubleSortingBenchmarks**  | **ArraySort**     | **44**     | **Random**     | **3,655.46 ns** | **227.155 ns** | **201.367 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| DoubleSortingBenchmarks  | SpanSort      | 44     | Random     | 3,545.09 ns | 227.771 ns | 213.058 ns |  0.97 |    0.08 |         - |          NA |
| DoubleSortingBenchmarks  | GeneratedSort | 44     | Random     |   251.64 ns |   1.975 ns |   1.750 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**     | **ArraySort**     | **48**     | **Random**     |   **302.92 ns** |  **26.897 ns** |  **23.844 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| IntSortingBenchmarks     | SpanSort      | 48     | Random     |   308.51 ns |  38.448 ns |  34.083 ns |  1.03 |    0.15 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 48     | Random     |   113.01 ns |   2.422 ns |   2.022 ns |  0.38 |    0.04 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**     | **ArraySort**     | **48**     | **Sorted**     |   **178.91 ns** |   **1.919 ns** |   **1.603 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| IntSortingBenchmarks     | SpanSort      | 48     | Sorted     |   191.66 ns |   2.697 ns |   2.391 ns |  1.07 |    0.02 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 48     | Sorted     |   114.46 ns |   2.583 ns |   2.289 ns |  0.64 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**     | **ArraySort**     | **48**     | **Reversed**   |   **237.71 ns** |   **5.464 ns** |   **4.843 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks     | SpanSort      | 48     | Reversed   |   250.18 ns |   4.620 ns |   4.095 ns |  1.05 |    0.03 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 48     | Reversed   |   112.08 ns |   2.609 ns |   2.178 ns |  0.47 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**     | **ArraySort**     | **48**     | **Duplicates** |   **213.64 ns** |  **12.463 ns** |  **11.048 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| IntSortingBenchmarks     | SpanSort      | 48     | Duplicates |   223.69 ns |   4.576 ns |   4.056 ns |  1.05 |    0.06 |         - |          NA |
| IntSortingBenchmarks     | GeneratedSort | 48     | Duplicates |   113.87 ns |   2.298 ns |   1.794 ns |  0.53 |    0.03 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **UIntSortingBenchmarks**    | **ArraySort**     | **50**     | **Random**     |   **278.35 ns** |  **17.903 ns** |  **15.871 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| UIntSortingBenchmarks    | SpanSort      | 50     | Random     |   298.49 ns |  13.683 ns |  12.129 ns |  1.08 |    0.07 |         - |          NA |
| UIntSortingBenchmarks    | GeneratedSort | 50     | Random     |   216.30 ns |   2.699 ns |   2.254 ns |  0.78 |    0.04 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **LongSortingBenchmarks**    | **ArraySort**     | **52**     | **Random**     | **3,789.84 ns** | **126.152 ns** | **111.830 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| LongSortingBenchmarks    | SpanSort      | 52     | Random     | 3,820.23 ns | 217.836 ns | 181.903 ns |  1.01 |    0.05 |         - |          NA |
| LongSortingBenchmarks    | GeneratedSort | 52     | Random     |   255.04 ns |   3.831 ns |   3.199 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **ULongSortingBenchmarks**   | **ArraySort**     | **54**     | **Random**     |   **506.38 ns** |  **12.913 ns** |  **10.783 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| ULongSortingBenchmarks   | SpanSort      | 54     | Random     |   466.01 ns |  92.195 ns |  81.729 ns |  0.92 |    0.16 |         - |          NA |
| ULongSortingBenchmarks   | GeneratedSort | 54     | Random     |   268.18 ns |   2.627 ns |   2.051 ns |  0.53 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **NIntSortingBenchmarks**    | **ArraySort**     | **56**     | **Random**     | **4,248.35 ns** | **109.213 ns** |  **96.815 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NIntSortingBenchmarks    | SpanSort      | 56     | Random     | 4,153.35 ns | 200.164 ns | 187.234 ns |  0.98 |    0.05 |         - |          NA |
| NIntSortingBenchmarks    | GeneratedSort | 56     | Random     |   292.32 ns |   3.604 ns |   3.195 ns |  0.07 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **NUIntSortingBenchmarks**   | **ArraySort**     | **58**     | **Random**     | **4,012.71 ns** | **194.681 ns** | **172.580 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NUIntSortingBenchmarks   | SpanSort      | 58     | Random     | 3,965.21 ns | 204.208 ns | 170.523 ns |  0.99 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks   | GeneratedSort | 58     | Random     |   314.78 ns |   3.687 ns |   3.079 ns |  0.08 |    0.00 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **CharSortingBenchmarks**    | **ArraySort**     | **60**     | **Random**     |   **369.40 ns** |   **5.403 ns** |   **4.218 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| CharSortingBenchmarks    | SpanSort      | 60     | Random     |   391.10 ns |  31.209 ns |  27.666 ns |  1.06 |    0.07 |         - |          NA |
| CharSortingBenchmarks    | GeneratedSort | 60     | Random     |   260.37 ns |   2.514 ns |   2.228 ns |  0.70 |    0.01 |         - |          NA |
|                          |               |        |            |             |            |            |       |         |           |             |
| **StringSortingBenchmarks**  | **ArraySort**     | **64**     | **Random**     | **3,585.62 ns** | **483.652 ns** | **428.745 ns** |  **1.02** |    **0.19** |      **64 B** |        **1.00** |
| StringSortingBenchmarks  | SpanSort      | 64     | Random     | 3,524.62 ns | 577.724 ns | 540.403 ns |  1.00 |    0.21 |      64 B |        1.00 |
| StringSortingBenchmarks  | GeneratedSort | 64     | Random     | 1,924.60 ns |  18.707 ns |  16.583 ns |  0.55 |    0.08 |         - |        0.00 |

