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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,314.59 ns** |  **29.936 ns** |  **26.538 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    93.36 ns |   3.427 ns |   2.862 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,643.89 ns |  50.430 ns |  44.705 ns |  1.25 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,582.85 ns |  81.733 ns |  72.454 ns |  1.20 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   106.44 ns |   4.947 ns |   4.131 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,399.00 ns |  48.328 ns |  37.732 ns |  1.06 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,371.87 ns |  62.649 ns |  55.536 ns |  1.04 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,415.50 ns |  46.474 ns |  38.808 ns |  1.08 |    0.04 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,489.67 ns | 159.142 ns | 132.891 ns |  1.13 |    0.10 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,388.80 ns |  36.553 ns |  32.403 ns |  1.06 |    0.03 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   958.83 ns | 104.833 ns |  81.847 ns |  0.73 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   105.46 ns |   2.652 ns |   2.351 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   115.38 ns |   2.247 ns |   1.877 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,322.44 ns |  44.215 ns |  39.196 ns |  1.01 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    40.49 ns |   1.094 ns |   0.969 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.79 ns |   2.081 ns |   1.845 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |    98.99 ns |   1.543 ns |   1.288 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    75.57 ns |   1.936 ns |   1.717 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    57.42 ns |   2.140 ns |   1.671 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.88 ns |   3.435 ns |   2.868 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   113.20 ns |   1.622 ns |   1.355 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   116.38 ns |   3.175 ns |   2.814 ns |  0.09 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    43.84 ns |   2.136 ns |   1.784 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.87 ns |   2.071 ns |   1.836 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   531.94 ns |   8.916 ns |   7.445 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    55.03 ns |   2.283 ns |   2.023 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |    99.91 ns |   2.189 ns |   1.940 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   101.06 ns |   2.537 ns |   2.249 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,495.78 ns |  37.937 ns |  33.631 ns |  1.14 |    0.03 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    97.25 ns |   2.759 ns |   2.303 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,608.60 ns |  77.327 ns |  68.548 ns |  1.22 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,599.68 ns |  75.506 ns |  66.934 ns |  1.22 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   107.28 ns |   2.767 ns |   2.310 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,420.49 ns |  28.818 ns |  25.546 ns |  1.08 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,417.63 ns |  87.512 ns |  68.324 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,416.58 ns |  37.131 ns |  31.006 ns |  1.08 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,448.15 ns |  61.343 ns |  51.224 ns |  1.10 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,381.49 ns |  67.761 ns |  60.068 ns |  1.05 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   956.23 ns |  64.906 ns |  57.538 ns |  0.73 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   104.60 ns |   3.576 ns |   2.792 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   114.43 ns |   4.954 ns |   4.392 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,262.71 ns |  54.000 ns |  47.870 ns |  0.96 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    39.21 ns |   0.974 ns |   0.863 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    96.41 ns |   1.963 ns |   1.740 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |    98.17 ns |   3.483 ns |   2.908 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    74.94 ns |   4.194 ns |   3.718 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    55.10 ns |   1.902 ns |   1.686 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.46 ns |   1.783 ns |   1.581 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   113.22 ns |   4.055 ns |   3.386 ns |  0.09 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   111.04 ns |   2.132 ns |   1.890 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    42.86 ns |   1.098 ns |   0.973 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.21 ns |   1.907 ns |   1.690 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   518.35 ns |   3.426 ns |   2.861 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    53.81 ns |   2.790 ns |   2.330 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.41 ns |   2.004 ns |   1.777 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    98.51 ns |   1.981 ns |   1.756 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.24 ns** |   **2.713 ns** |   **2.405 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    59.47 ns |   2.781 ns |   2.322 ns |  0.85 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.03 ns |   3.669 ns |   3.252 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    55.18 ns |   2.351 ns |   1.963 ns |  0.79 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **85.95 ns** |   **2.704 ns** |   **2.397 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    58.42 ns |   1.492 ns |   1.246 ns |  0.68 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    92.08 ns |   3.866 ns |   3.428 ns |  1.07 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    56.66 ns |   2.286 ns |   2.026 ns |  0.66 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **110.01 ns** |   **4.247 ns** |   **3.765 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    57.73 ns |   2.162 ns |   1.917 ns |  0.53 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   111.95 ns |   3.966 ns |   3.311 ns |  1.02 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    56.07 ns |   2.276 ns |   2.018 ns |  0.51 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,475.06 ns** |  **92.293 ns** |  **81.815 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.50 ns |   2.569 ns |   2.277 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,818.82 ns | 129.148 ns | 114.486 ns |  1.24 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,797.91 ns | 112.538 ns |  99.762 ns |  1.22 |    0.10 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   121.08 ns |   4.258 ns |   3.325 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,589.92 ns |  89.999 ns |  75.153 ns |  1.08 |    0.08 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,620.41 ns |  72.834 ns |  64.565 ns |  1.10 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,609.38 ns |  42.564 ns |  35.543 ns |  1.09 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,654.59 ns |  54.618 ns |  48.418 ns |  1.13 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,580.74 ns |  39.281 ns |  34.821 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     |   901.44 ns |  48.277 ns |  42.796 ns |  0.61 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   121.22 ns |   3.789 ns |   3.164 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   130.04 ns |   5.718 ns |   4.464 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,475.16 ns |  44.604 ns |  39.540 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    41.02 ns |   1.146 ns |   1.016 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    99.66 ns |   1.827 ns |   1.619 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |   110.59 ns |   3.890 ns |   3.448 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    71.36 ns |   1.677 ns |   1.487 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    56.72 ns |   2.849 ns |   2.379 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   108.12 ns |   2.784 ns |   2.468 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   118.10 ns |   2.900 ns |   2.571 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   117.72 ns |   3.430 ns |   2.864 ns |  0.08 |    0.01 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    43.55 ns |   1.459 ns |   1.294 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   104.21 ns |   2.166 ns |   1.920 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   541.80 ns |   4.139 ns |   3.457 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    55.40 ns |   1.504 ns |   1.256 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   105.56 ns |   2.097 ns |   1.859 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   102.91 ns |   2.320 ns |   2.056 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,494.96 ns |  74.094 ns |  65.682 ns |  1.02 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   120.62 ns |   4.104 ns |   3.638 ns |  0.08 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,774.08 ns | 180.827 ns | 150.999 ns |  1.21 |    0.12 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,814.87 ns |  90.629 ns |  80.340 ns |  1.23 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   123.97 ns |   3.322 ns |   2.945 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,616.28 ns |  64.544 ns |  53.897 ns |  1.10 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,594.32 ns |  99.705 ns |  83.258 ns |  1.08 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,945.19 ns | 712.385 ns | 666.365 ns |  1.32 |    0.45 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,695.14 ns |  42.849 ns |  37.984 ns |  1.15 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,600.74 ns |  40.657 ns |  36.041 ns |  1.09 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,049.45 ns |  90.732 ns |  80.432 ns |  0.71 |    0.07 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   119.91 ns |   2.724 ns |   2.275 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   126.96 ns |   2.751 ns |   2.148 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,488.73 ns |  69.981 ns |  62.036 ns |  1.01 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    39.31 ns |   1.110 ns |   0.984 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.40 ns |   2.097 ns |   1.859 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |   107.10 ns |   4.473 ns |   3.735 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    70.84 ns |   2.064 ns |   1.830 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    53.80 ns |   2.273 ns |   1.898 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   107.04 ns |   2.375 ns |   1.983 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   116.06 ns |   2.010 ns |   1.782 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   143.81 ns |  35.586 ns |  31.546 ns |  0.10 |    0.02 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    42.72 ns |   1.130 ns |   0.943 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   114.00 ns |  20.283 ns |  17.980 ns |  0.08 |    0.01 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   540.26 ns |   6.110 ns |   5.416 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    52.34 ns |   3.205 ns |   2.841 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   134.49 ns |  45.640 ns |  40.458 ns |  0.09 |    0.03 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   102.38 ns |   2.720 ns |   2.271 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.55 ns** |   **3.535 ns** |   **2.952 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    56.57 ns |   2.312 ns |   1.931 ns |  0.78 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    76.11 ns |   2.804 ns |   2.485 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    54.96 ns |   2.390 ns |   2.119 ns |  0.76 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **89.19 ns** |   **3.101 ns** |   **2.589 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.60 ns |   2.633 ns |   2.334 ns |  0.65 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    96.62 ns |   3.131 ns |   2.614 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    54.53 ns |   2.092 ns |   1.854 ns |  0.61 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **111.69 ns** |   **3.198 ns** |   **2.835 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    56.82 ns |   2.472 ns |   2.064 ns |  0.51 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   116.22 ns |   3.342 ns |   2.963 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    54.35 ns |   1.699 ns |   1.419 ns |  0.49 |    0.02 |         - |          NA |

