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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,297.02 ns** |  **31.540 ns** |  **26.337 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    93.43 ns |   2.734 ns |   2.283 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,629.02 ns |  55.970 ns |  46.738 ns |  1.26 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,620.61 ns | 109.938 ns |  97.457 ns |  1.25 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   105.45 ns |   4.954 ns |   4.391 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,426.62 ns |  32.061 ns |  26.773 ns |  1.10 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,407.61 ns |  70.805 ns |  62.766 ns |  1.09 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,397.49 ns |  58.277 ns |  51.661 ns |  1.08 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,433.22 ns |  47.186 ns |  39.403 ns |  1.11 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,425.87 ns |  74.299 ns |  62.043 ns |  1.10 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   968.50 ns |  76.354 ns |  67.685 ns |  0.75 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   106.81 ns |   5.071 ns |   4.496 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   115.58 ns |   3.615 ns |   3.204 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,279.08 ns |  48.264 ns |  40.303 ns |  0.99 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    41.46 ns |   3.314 ns |   2.767 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.81 ns |   1.956 ns |   1.734 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |   107.27 ns |   2.310 ns |   1.929 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    74.19 ns |   2.277 ns |   1.901 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    59.14 ns |   2.248 ns |   1.993 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.50 ns |   1.896 ns |   1.681 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   113.98 ns |   2.118 ns |   1.877 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   112.81 ns |   2.914 ns |   2.583 ns |  0.09 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    43.20 ns |   1.527 ns |   1.275 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   101.75 ns |   3.276 ns |   2.735 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   523.46 ns |   2.434 ns |   1.900 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    54.46 ns |   1.984 ns |   1.759 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.65 ns |   2.790 ns |   2.329 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.92 ns |   2.848 ns |   2.525 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,325.45 ns |  33.458 ns |  29.660 ns |  1.02 |    0.03 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.43 ns |   1.938 ns |   1.718 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,569.73 ns |  45.824 ns |  38.265 ns |  1.21 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,589.96 ns |  77.402 ns |  68.615 ns |  1.23 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   107.55 ns |   4.330 ns |   3.616 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,416.50 ns |  57.422 ns |  50.903 ns |  1.09 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,464.49 ns | 107.304 ns |  89.604 ns |  1.13 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,417.27 ns |  58.910 ns |  52.223 ns |  1.09 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,463.05 ns |  57.287 ns |  47.837 ns |  1.13 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,417.84 ns |  29.776 ns |  26.396 ns |  1.09 |    0.03 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   954.54 ns |  73.345 ns |  61.247 ns |  0.74 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   109.92 ns |   7.253 ns |   6.429 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   114.81 ns |   4.847 ns |   4.297 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,260.82 ns |  44.227 ns |  39.206 ns |  0.97 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    39.12 ns |   1.258 ns |   1.115 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.59 ns |   1.857 ns |   1.646 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |    96.95 ns |   2.625 ns |   2.192 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    75.31 ns |   3.506 ns |   3.108 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    56.62 ns |   3.497 ns |   3.100 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.33 ns |   2.315 ns |   2.052 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   112.28 ns |   2.022 ns |   1.688 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   113.46 ns |   4.348 ns |   3.854 ns |  0.09 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    42.49 ns |   2.238 ns |   1.984 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.34 ns |   3.129 ns |   2.774 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   518.04 ns |   2.508 ns |   2.223 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    52.58 ns |   2.131 ns |   1.889 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   100.09 ns |   2.223 ns |   1.970 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    99.95 ns |   2.888 ns |   2.412 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.09 ns** |   **2.488 ns** |   **2.205 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    56.37 ns |   2.114 ns |   1.765 ns |  0.80 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    76.71 ns |   5.062 ns |   3.952 ns |  1.10 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    56.69 ns |   3.879 ns |   3.439 ns |  0.81 |    0.05 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **84.61 ns** |   **3.148 ns** |   **2.791 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    57.26 ns |   2.225 ns |   1.972 ns |  0.68 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    90.89 ns |   2.814 ns |   2.494 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    56.04 ns |   1.671 ns |   1.481 ns |  0.66 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **108.54 ns** |   **3.918 ns** |   **3.272 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    57.90 ns |   2.602 ns |   2.306 ns |  0.53 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   112.93 ns |   3.933 ns |   3.284 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    55.70 ns |   3.296 ns |   2.752 ns |  0.51 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,467.82 ns** |  **54.082 ns** |  **47.942 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.58 ns |   2.986 ns |   2.493 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,830.31 ns |  93.618 ns |  82.990 ns |  1.25 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,749.65 ns | 125.147 ns | 110.939 ns |  1.19 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   120.35 ns |   3.156 ns |   2.464 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,609.53 ns |  73.657 ns |  61.507 ns |  1.10 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,607.97 ns |  41.926 ns |  35.010 ns |  1.10 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,616.66 ns |  40.145 ns |  33.523 ns |  1.10 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,646.77 ns | 110.882 ns |  98.294 ns |  1.12 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,618.87 ns |  77.127 ns |  68.371 ns |  1.10 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,029.02 ns |  89.373 ns |  79.227 ns |  0.70 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   122.65 ns |   5.182 ns |   4.594 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   128.76 ns |   4.794 ns |   3.743 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,494.84 ns |  58.164 ns |  51.561 ns |  1.02 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    40.83 ns |   1.187 ns |   0.991 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    99.61 ns |   2.325 ns |   2.061 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |   113.42 ns |   4.597 ns |   3.589 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    70.86 ns |   2.339 ns |   1.953 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    56.36 ns |   2.375 ns |   2.106 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.45 ns |   4.038 ns |   3.372 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   116.69 ns |   2.576 ns |   2.284 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   122.93 ns |  10.073 ns |   8.411 ns |  0.08 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    44.56 ns |   1.259 ns |   1.052 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.82 ns |   2.784 ns |   2.325 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   544.12 ns |   7.603 ns |   6.349 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    55.90 ns |   2.405 ns |   2.132 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.94 ns |   2.803 ns |   2.340 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   103.43 ns |   2.580 ns |   2.155 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,510.13 ns |  39.900 ns |  33.318 ns |  1.03 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   118.63 ns |   3.347 ns |   2.967 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,757.52 ns | 146.662 ns | 130.012 ns |  1.20 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,738.72 ns | 136.516 ns | 121.018 ns |  1.19 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   123.24 ns |   4.572 ns |   3.818 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,597.21 ns |  81.855 ns |  68.353 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,602.69 ns |  70.741 ns |  62.710 ns |  1.09 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,595.68 ns |  99.221 ns |  82.854 ns |  1.09 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,620.92 ns |  76.754 ns |  68.040 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,585.73 ns |  61.652 ns |  51.483 ns |  1.08 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,048.54 ns |  83.471 ns |  73.995 ns |  0.72 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   121.37 ns |   5.794 ns |   5.136 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   126.52 ns |   2.391 ns |   2.119 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,485.14 ns |  57.276 ns |  47.828 ns |  1.01 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    39.03 ns |   1.054 ns |   0.934 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.58 ns |   2.508 ns |   2.094 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |   107.92 ns |   2.479 ns |   2.198 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    71.17 ns |   1.939 ns |   1.719 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    54.14 ns |   1.746 ns |   1.548 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.02 ns |   2.077 ns |   1.841 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   116.81 ns |   2.042 ns |   1.810 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   116.00 ns |   2.218 ns |   1.966 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    42.70 ns |   1.034 ns |   0.917 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.05 ns |   2.306 ns |   2.044 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   544.52 ns |   5.682 ns |   4.745 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    52.00 ns |   2.133 ns |   1.891 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.11 ns |   1.928 ns |   1.709 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.36 ns |   2.411 ns |   2.014 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.31 ns** |   **2.620 ns** |   **2.322 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    57.89 ns |   2.919 ns |   2.588 ns |  0.80 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    75.62 ns |   3.595 ns |   3.002 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    54.40 ns |   2.042 ns |   1.810 ns |  0.75 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **91.16 ns** |   **4.553 ns** |   **3.555 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.11 ns |   2.684 ns |   2.241 ns |  0.63 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    94.05 ns |   3.377 ns |   2.820 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    55.51 ns |   4.599 ns |   4.077 ns |  0.61 |    0.05 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **111.53 ns** |   **3.376 ns** |   **2.819 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    57.40 ns |   2.876 ns |   2.550 ns |  0.51 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   117.34 ns |   3.327 ns |   2.949 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    53.99 ns |   2.052 ns |   1.819 ns |  0.48 |    0.02 |         - |          NA |

