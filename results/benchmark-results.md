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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,318.86 ns** |  **52.089 ns** |  **46.176 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    93.29 ns |   2.819 ns |   2.354 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,622.29 ns |  57.699 ns |  51.148 ns |  1.23 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,567.80 ns |  87.245 ns |  77.341 ns |  1.19 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   101.98 ns |   2.833 ns |   2.212 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,554.16 ns | 262.224 ns | 232.455 ns |  1.18 |    0.18 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,419.29 ns |  38.345 ns |  33.992 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,421.41 ns |  43.356 ns |  38.434 ns |  1.08 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,443.71 ns |  49.996 ns |  44.320 ns |  1.10 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,388.98 ns |  67.961 ns |  56.751 ns |  1.05 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   975.55 ns |  86.769 ns |  67.744 ns |  0.74 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   108.39 ns |   4.331 ns |   3.839 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   116.90 ns |   4.954 ns |   4.392 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,305.47 ns |  51.645 ns |  45.782 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    40.27 ns |   2.087 ns |   1.850 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.85 ns |   2.094 ns |   1.856 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |    92.62 ns |   1.827 ns |   1.426 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    75.56 ns |   2.303 ns |   1.923 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    56.95 ns |   2.598 ns |   2.169 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   102.98 ns |   2.323 ns |   2.060 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   102.99 ns |   2.296 ns |   2.035 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   103.75 ns |   2.943 ns |   2.458 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    41.25 ns |   1.355 ns |   1.132 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.36 ns |   2.282 ns |   2.023 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   531.73 ns |   4.818 ns |   4.271 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    54.29 ns |   2.376 ns |   2.106 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   101.53 ns |   2.151 ns |   1.796 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.58 ns |   2.260 ns |   2.003 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,337.81 ns |  26.801 ns |  23.759 ns |  1.02 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.67 ns |   2.863 ns |   2.538 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,618.70 ns |  79.894 ns |  70.824 ns |  1.23 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,603.55 ns |  74.536 ns |  66.075 ns |  1.22 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   108.65 ns |   3.871 ns |   3.232 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,399.36 ns |  65.891 ns |  58.411 ns |  1.06 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,455.96 ns |  40.292 ns |  35.718 ns |  1.11 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,418.31 ns |  50.497 ns |  44.764 ns |  1.08 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,439.44 ns |  74.124 ns |  65.709 ns |  1.09 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,454.57 ns |  66.131 ns |  58.623 ns |  1.10 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   970.16 ns |  61.595 ns |  54.602 ns |  0.74 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   107.74 ns |   4.723 ns |   4.187 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   115.34 ns |   3.992 ns |   3.116 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,262.26 ns |  28.598 ns |  25.351 ns |  0.96 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    37.02 ns |   1.305 ns |   1.157 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    96.24 ns |   2.213 ns |   1.961 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |   100.06 ns |   2.797 ns |   2.335 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    73.14 ns |   1.793 ns |   1.590 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    55.79 ns |   2.835 ns |   2.513 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   100.81 ns |   2.545 ns |   2.125 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.43 ns |   2.710 ns |   2.403 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   100.84 ns |   2.276 ns |   2.018 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    39.58 ns |   0.980 ns |   0.868 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.12 ns |   1.955 ns |   1.733 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   518.97 ns |   3.739 ns |   3.315 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    52.56 ns |   2.279 ns |   1.779 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.02 ns |   2.103 ns |   1.642 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    99.35 ns |   2.431 ns |   2.155 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.69 ns** |   **2.945 ns** |   **2.459 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    56.52 ns |   3.244 ns |   2.709 ns |  0.80 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.19 ns |   3.210 ns |   2.846 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    56.73 ns |   3.656 ns |   3.241 ns |  0.80 |    0.05 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **85.28 ns** |   **2.812 ns** |   **2.196 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    58.10 ns |   3.342 ns |   2.962 ns |  0.68 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    92.28 ns |   3.256 ns |   2.886 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    55.66 ns |   3.293 ns |   2.749 ns |  0.65 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **110.09 ns** |   **2.886 ns** |   **2.410 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    56.92 ns |   2.859 ns |   2.534 ns |  0.52 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   112.74 ns |   4.151 ns |   3.680 ns |  1.02 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    54.79 ns |   2.093 ns |   1.856 ns |  0.50 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,477.44 ns** |  **39.457 ns** |  **34.977 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.77 ns |   4.385 ns |   3.423 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,842.30 ns |  66.776 ns |  59.195 ns |  1.25 |    0.05 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,723.76 ns | 118.719 ns | 105.241 ns |  1.17 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   121.72 ns |   4.469 ns |   3.732 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,586.21 ns |  46.905 ns |  41.580 ns |  1.07 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,577.01 ns |  85.851 ns |  76.104 ns |  1.07 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,575.41 ns |  76.411 ns |  67.736 ns |  1.07 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,603.67 ns | 125.710 ns | 111.439 ns |  1.09 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,544.93 ns |  94.337 ns |  78.776 ns |  1.05 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,006.83 ns | 124.553 ns | 110.413 ns |  0.68 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   121.18 ns |   2.575 ns |   2.151 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   125.47 ns |   2.511 ns |   2.226 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,475.88 ns |  57.274 ns |  50.771 ns |  1.00 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    38.77 ns |   1.323 ns |   1.172 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    99.54 ns |   2.378 ns |   2.108 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |    91.05 ns |   2.133 ns |   1.781 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    72.07 ns |   2.799 ns |   2.337 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    58.45 ns |   2.877 ns |   2.403 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   106.80 ns |   2.291 ns |   2.031 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   106.62 ns |   2.870 ns |   2.241 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   106.89 ns |   2.244 ns |   1.989 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    42.29 ns |   1.756 ns |   1.557 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.29 ns |   2.135 ns |   1.893 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   543.39 ns |   4.479 ns |   3.971 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.42 ns |   3.090 ns |   2.580 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   104.09 ns |   2.300 ns |   2.039 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   102.76 ns |   2.448 ns |   2.044 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,491.32 ns |  50.196 ns |  41.916 ns |  1.01 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   117.71 ns |   2.945 ns |   2.611 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,795.68 ns | 146.546 ns | 129.909 ns |  1.22 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,780.90 ns |  99.074 ns |  87.827 ns |  1.21 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   125.17 ns |   5.423 ns |   4.808 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,578.81 ns |  91.376 ns |  81.002 ns |  1.07 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,625.31 ns |  38.179 ns |  33.844 ns |  1.10 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,618.38 ns |  48.951 ns |  38.217 ns |  1.10 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,648.76 ns | 100.773 ns |  89.333 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,570.74 ns |  70.872 ns |  62.826 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,048.46 ns |  96.403 ns |  85.459 ns |  0.71 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   120.45 ns |   4.876 ns |   4.071 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   126.20 ns |   3.845 ns |   3.002 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,483.84 ns |  54.933 ns |  48.697 ns |  1.00 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    38.40 ns |   1.317 ns |   1.168 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    99.20 ns |   1.871 ns |   1.659 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |    99.84 ns |   5.047 ns |   4.474 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    68.91 ns |   1.760 ns |   1.560 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    54.19 ns |   2.712 ns |   2.404 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.29 ns |   2.691 ns |   2.385 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.36 ns |   2.935 ns |   2.601 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   105.64 ns |   2.274 ns |   2.016 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    39.74 ns |   1.127 ns |   0.999 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   101.84 ns |   2.328 ns |   2.064 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   542.02 ns |   2.143 ns |   1.899 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    51.55 ns |   1.945 ns |   1.624 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.51 ns |   1.809 ns |   1.604 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.08 ns |   2.391 ns |   2.120 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.96 ns** |   **3.658 ns** |   **2.856 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    55.98 ns |   2.280 ns |   2.021 ns |  0.77 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    75.91 ns |   2.792 ns |   2.179 ns |  1.04 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    53.80 ns |   1.720 ns |   1.525 ns |  0.74 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |   **106.61 ns** |  **28.262 ns** |  **25.054 ns** |  **1.05** |    **0.32** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.12 ns |   2.561 ns |   2.139 ns |  0.56 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    94.24 ns |   3.539 ns |   2.955 ns |  0.92 |    0.18 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    55.45 ns |   2.633 ns |   2.334 ns |  0.54 |    0.11 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **112.54 ns** |   **3.100 ns** |   **2.748 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    56.63 ns |   2.768 ns |   2.453 ns |  0.50 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   116.84 ns |   2.825 ns |   2.505 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    53.32 ns |   1.977 ns |   1.752 ns |  0.47 |    0.02 |         - |          NA |

