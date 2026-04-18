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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,309.61 ns** |  **29.038 ns** |  **25.741 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    98.13 ns |  13.607 ns |  11.363 ns |  0.07 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,599.22 ns |  57.848 ns |  51.281 ns |  1.22 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,645.54 ns |  64.198 ns |  56.910 ns |  1.26 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   103.26 ns |   2.914 ns |   2.433 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,415.09 ns |  43.625 ns |  38.673 ns |  1.08 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,356.14 ns |  61.769 ns |  54.757 ns |  1.04 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,428.80 ns |  63.692 ns |  56.461 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,431.28 ns |  57.077 ns |  50.597 ns |  1.09 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,372.16 ns |  36.073 ns |  31.978 ns |  1.05 |    0.03 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   978.26 ns |  50.660 ns |  44.909 ns |  0.75 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   108.21 ns |   5.411 ns |   4.796 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   117.16 ns |   1.659 ns |   1.471 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,266.60 ns |  35.368 ns |  31.352 ns |  0.97 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    42.11 ns |   1.321 ns |   1.171 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.86 ns |   2.185 ns |   1.937 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |   108.27 ns |   2.040 ns |   1.593 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |   105.87 ns |   2.556 ns |   2.266 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |   100.51 ns |   2.351 ns |   2.084 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   101.84 ns |   2.328 ns |   1.817 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.51 ns |   2.433 ns |   2.032 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   104.34 ns |   7.199 ns |   6.011 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    43.18 ns |   1.172 ns |   1.039 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.63 ns |   2.231 ns |   1.977 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   523.25 ns |  16.246 ns |  14.402 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    98.06 ns |   2.222 ns |   1.970 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |    97.81 ns |   1.992 ns |   1.766 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |    98.71 ns |   2.669 ns |   2.084 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,320.74 ns |  57.262 ns |  50.761 ns |  1.01 |    0.04 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    95.76 ns |   1.856 ns |   1.645 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,551.29 ns |  88.937 ns |  78.840 ns |  1.18 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,619.63 ns |  58.188 ns |  51.582 ns |  1.24 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   108.49 ns |   4.661 ns |   4.131 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,376.69 ns |  37.868 ns |  33.569 ns |  1.05 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,426.94 ns |  29.942 ns |  26.543 ns |  1.09 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,439.26 ns |  29.616 ns |  26.253 ns |  1.10 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,429.76 ns |  31.147 ns |  27.611 ns |  1.09 |    0.03 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,399.85 ns |  28.874 ns |  25.596 ns |  1.07 |    0.03 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   943.56 ns |  81.743 ns |  72.463 ns |  0.72 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   105.51 ns |   5.246 ns |   4.650 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   115.81 ns |   5.612 ns |   4.975 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,264.18 ns |  30.073 ns |  26.659 ns |  0.97 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    40.18 ns |   1.447 ns |   1.283 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.14 ns |   1.949 ns |   1.727 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |   106.27 ns |   2.102 ns |   1.755 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   103.17 ns |   1.713 ns |   1.519 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |   100.78 ns |   2.336 ns |   1.951 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.01 ns |   2.382 ns |   2.112 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   102.38 ns |   6.205 ns |   4.844 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.84 ns |   2.529 ns |   2.112 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    41.44 ns |   1.034 ns |   0.916 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    96.90 ns |   2.284 ns |   1.907 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   520.72 ns |   2.339 ns |   1.953 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    96.77 ns |   1.765 ns |   1.565 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   110.48 ns |  22.167 ns |  19.650 ns |  0.08 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    97.38 ns |   2.883 ns |   2.408 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **78.17 ns** |  **16.953 ns** |  **15.028 ns** |  **1.03** |    **0.25** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    73.21 ns |   2.753 ns |   2.441 ns |  0.96 |    0.15 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.01 ns |   3.145 ns |   2.788 ns |  0.97 |    0.15 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    71.40 ns |   2.257 ns |   2.000 ns |  0.94 |    0.15 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **85.71 ns** |   **2.118 ns** |   **1.769 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |   101.39 ns |   1.904 ns |   1.688 ns |  1.18 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    92.09 ns |   2.432 ns |   2.156 ns |  1.07 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    98.82 ns |   2.268 ns |   1.893 ns |  1.15 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **108.71 ns** |   **2.387 ns** |   **2.116 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    82.82 ns |   2.258 ns |   2.002 ns |  0.76 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   113.34 ns |   3.250 ns |   2.881 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    79.98 ns |   1.988 ns |   1.660 ns |  0.74 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,455.34 ns** |  **91.125 ns** |  **80.780 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.91 ns |   3.587 ns |   3.179 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,824.87 ns |  54.816 ns |  48.593 ns |  1.26 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,775.25 ns | 121.268 ns | 113.435 ns |  1.22 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   120.09 ns |   2.931 ns |   2.598 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,546.18 ns |  85.770 ns |  76.033 ns |  1.07 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,582.67 ns |  34.243 ns |  28.595 ns |  1.09 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,538.00 ns |  62.601 ns |  52.275 ns |  1.06 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,658.35 ns |  38.026 ns |  33.709 ns |  1.14 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,585.65 ns |  40.956 ns |  36.306 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,047.90 ns |  86.490 ns |  76.671 ns |  0.72 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   122.24 ns |   2.298 ns |   1.919 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   126.06 ns |   2.924 ns |   2.442 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,489.45 ns |  80.668 ns |  71.510 ns |  1.03 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    41.39 ns |   2.394 ns |   2.122 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    97.57 ns |   2.146 ns |   1.903 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |   112.08 ns |   3.295 ns |   2.752 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |   109.19 ns |   2.670 ns |   2.367 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |   103.04 ns |   2.163 ns |   1.918 ns |  0.07 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   104.62 ns |   2.241 ns |   1.987 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   106.94 ns |   2.318 ns |   2.055 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   107.26 ns |   2.471 ns |   2.191 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    43.92 ns |   1.373 ns |   1.146 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.29 ns |   2.259 ns |   2.003 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   544.32 ns |   7.212 ns |   6.022 ns |  0.38 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   100.17 ns |   2.022 ns |   1.792 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   104.53 ns |   2.055 ns |   1.822 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   102.63 ns |   2.184 ns |   1.936 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,425.75 ns | 109.588 ns |  97.147 ns |  0.98 |    0.09 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   116.77 ns |   7.018 ns |   5.479 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,712.84 ns | 124.275 ns | 110.166 ns |  1.18 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,804.14 ns | 100.778 ns |  89.337 ns |  1.24 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   122.74 ns |   3.389 ns |   2.646 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,614.76 ns |  46.607 ns |  41.316 ns |  1.11 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,572.58 ns |  87.735 ns |  77.774 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,588.07 ns |  53.252 ns |  44.468 ns |  1.09 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,639.75 ns |  85.518 ns |  75.810 ns |  1.13 |    0.08 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,513.79 ns |  83.993 ns |  74.458 ns |  1.04 |    0.08 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,038.01 ns |  76.010 ns |  67.381 ns |  0.72 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   117.59 ns |   2.741 ns |   2.140 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   127.79 ns |   3.975 ns |   3.524 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,402.25 ns |  83.492 ns |  69.720 ns |  0.97 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    39.02 ns |   1.040 ns |   0.922 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.20 ns |   2.316 ns |   2.053 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |   107.15 ns |   6.604 ns |   5.156 ns |  0.07 |    0.01 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   106.02 ns |   2.366 ns |   1.976 ns |  0.07 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |   101.85 ns |   2.336 ns |   1.950 ns |  0.07 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.23 ns |   2.336 ns |   1.951 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.24 ns |   2.087 ns |   1.850 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   103.15 ns |   2.197 ns |   1.835 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    40.63 ns |   1.093 ns |   0.912 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   101.82 ns |   2.393 ns |   2.121 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   540.25 ns |  10.151 ns |   8.476 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    99.08 ns |   1.991 ns |   1.765 ns |  0.07 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   100.82 ns |   2.117 ns |   1.653 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   102.99 ns |   2.605 ns |   2.309 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **71.76 ns** |   **2.942 ns** |   **2.608 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    73.66 ns |   2.697 ns |   2.252 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    73.95 ns |   3.733 ns |   2.915 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    73.19 ns |   2.174 ns |   1.927 ns |  1.02 |    0.05 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **89.21 ns** |   **3.958 ns** |   **3.509 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    93.21 ns |   2.244 ns |   1.989 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    95.30 ns |   2.121 ns |   1.880 ns |  1.07 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    89.78 ns |   1.906 ns |   1.689 ns |  1.01 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **110.99 ns** |   **3.193 ns** |   **2.830 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    84.52 ns |   2.280 ns |   2.021 ns |  0.76 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   117.41 ns |   3.727 ns |   3.112 ns |  1.06 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    83.39 ns |   2.163 ns |   1.918 ns |  0.75 |    0.02 |         - |          NA |

