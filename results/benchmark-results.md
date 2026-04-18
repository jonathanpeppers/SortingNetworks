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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,283.84 ns** |  **65.096 ns** |  **54.358 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    93.83 ns |   3.131 ns |   2.615 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,630.38 ns |  77.771 ns |  64.943 ns |  1.27 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,598.45 ns |  95.750 ns |  79.955 ns |  1.25 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   102.72 ns |   2.761 ns |   2.447 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,398.00 ns |  38.477 ns |  34.109 ns |  1.09 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,407.57 ns |  31.550 ns |  27.969 ns |  1.10 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,381.34 ns |  39.641 ns |  35.141 ns |  1.08 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,426.84 ns |  52.664 ns |  46.685 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,410.73 ns |  28.232 ns |  25.027 ns |  1.10 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   986.35 ns |  71.617 ns |  59.803 ns |  0.77 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   105.61 ns |   4.029 ns |   3.365 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   119.52 ns |   4.442 ns |   3.709 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,287.60 ns |  84.009 ns |  74.472 ns |  1.00 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    41.18 ns |   1.290 ns |   1.144 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.48 ns |   2.105 ns |   1.866 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |   109.79 ns |   2.680 ns |   2.238 ns |  0.09 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |   106.97 ns |   2.983 ns |   2.644 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    58.36 ns |   3.728 ns |   3.305 ns |  0.05 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   104.48 ns |   3.446 ns |   2.877 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   104.79 ns |   2.446 ns |   2.168 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   103.05 ns |   2.504 ns |   2.091 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    44.20 ns |   1.515 ns |   1.343 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.56 ns |   2.235 ns |   1.981 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   531.71 ns |  19.904 ns |  15.540 ns |  0.41 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    54.62 ns |   2.091 ns |   1.854 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |    99.89 ns |   2.180 ns |   1.933 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.36 ns |   2.308 ns |   2.046 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,285.29 ns |  49.863 ns |  44.202 ns |  1.00 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.48 ns |   2.437 ns |   2.160 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,605.00 ns |  86.425 ns |  76.613 ns |  1.25 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,604.91 ns |  74.254 ns |  62.006 ns |  1.25 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   109.44 ns |   4.480 ns |   3.972 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,397.38 ns |  62.478 ns |  55.385 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,517.98 ns |  37.309 ns |  31.155 ns |  1.18 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,423.17 ns |  41.998 ns |  37.230 ns |  1.11 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,418.88 ns |  58.857 ns |  52.175 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,394.99 ns |  63.193 ns |  56.019 ns |  1.09 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   975.66 ns |  64.434 ns |  53.805 ns |  0.76 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   104.94 ns |   5.439 ns |   4.821 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   114.01 ns |   4.803 ns |   4.258 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,221.86 ns |  58.606 ns |  48.939 ns |  0.95 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    38.99 ns |   1.023 ns |   0.907 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.39 ns |   2.228 ns |   1.975 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |   107.66 ns |   2.205 ns |   1.955 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   105.76 ns |   3.208 ns |   2.844 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    56.53 ns |   2.485 ns |   2.203 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   103.99 ns |   3.034 ns |   2.689 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   104.23 ns |   3.054 ns |   2.707 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   101.75 ns |   2.590 ns |   2.296 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    41.79 ns |   1.208 ns |   1.070 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.85 ns |   2.149 ns |   1.905 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   518.99 ns |   4.072 ns |   3.610 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    53.11 ns |   2.335 ns |   1.950 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.33 ns |   1.973 ns |   1.749 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    98.79 ns |   2.047 ns |   1.815 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.34 ns** |   **2.491 ns** |   **2.208 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    57.79 ns |   4.129 ns |   3.660 ns |  0.82 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    73.91 ns |   3.114 ns |   2.760 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    55.19 ns |   2.103 ns |   1.864 ns |  0.79 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **85.46 ns** |   **2.994 ns** |   **2.654 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    57.19 ns |   2.316 ns |   2.053 ns |  0.67 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    91.97 ns |   2.767 ns |   2.453 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    55.55 ns |   1.843 ns |   1.539 ns |  0.65 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **106.32 ns** |   **2.909 ns** |   **2.578 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    57.38 ns |   3.061 ns |   2.556 ns |  0.54 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   110.44 ns |   3.839 ns |   3.404 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    55.22 ns |   1.850 ns |   1.544 ns |  0.52 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,485.13 ns** |  **39.426 ns** |  **34.950 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.55 ns |   3.516 ns |   2.936 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,820.73 ns |  93.799 ns |  83.151 ns |  1.23 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,761.70 ns | 130.397 ns | 115.593 ns |  1.19 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   120.45 ns |   2.569 ns |   2.145 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,516.63 ns |  91.527 ns |  81.136 ns |  1.02 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,572.62 ns |  85.850 ns |  71.689 ns |  1.06 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,586.08 ns | 155.913 ns | 138.213 ns |  1.07 |    0.09 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,652.67 ns |  49.750 ns |  44.102 ns |  1.11 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,539.57 ns | 117.588 ns | 104.239 ns |  1.04 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,095.91 ns |  80.696 ns |  71.535 ns |  0.74 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   125.26 ns |   4.786 ns |   4.243 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   129.00 ns |   4.542 ns |   4.026 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,484.04 ns |  38.985 ns |  34.560 ns |  1.00 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    41.26 ns |   0.814 ns |   0.722 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    99.44 ns |   2.067 ns |   1.832 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |   111.34 ns |   2.270 ns |   2.013 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |   108.84 ns |   2.626 ns |   2.328 ns |  0.07 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    58.26 ns |   3.939 ns |   3.491 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   109.53 ns |   4.795 ns |   4.004 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.40 ns |   2.073 ns |   1.838 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   106.53 ns |   2.167 ns |   1.921 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    43.59 ns |   1.463 ns |   1.297 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.98 ns |   2.870 ns |   2.397 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   544.35 ns |   4.170 ns |   3.482 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.23 ns |   1.782 ns |   1.580 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   107.56 ns |   7.545 ns |   6.689 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   106.79 ns |   4.237 ns |   3.756 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,496.24 ns |  37.446 ns |  33.195 ns |  1.01 |    0.03 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   116.82 ns |   2.667 ns |   2.364 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,688.57 ns | 121.653 ns | 107.842 ns |  1.14 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,809.35 ns | 100.512 ns |  89.101 ns |  1.22 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   123.59 ns |   4.003 ns |   3.548 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,587.36 ns |  90.652 ns |  80.361 ns |  1.07 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,625.26 ns |  69.559 ns |  61.662 ns |  1.09 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,815.55 ns | 437.544 ns | 409.279 ns |  1.22 |    0.27 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,618.00 ns |  81.981 ns |  72.674 ns |  1.09 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,573.54 ns |  76.989 ns |  68.249 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,066.29 ns |  59.974 ns |  53.165 ns |  0.72 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   123.53 ns |   5.018 ns |   4.448 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   126.54 ns |   3.656 ns |   3.053 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,456.60 ns |  78.370 ns |  69.473 ns |  0.98 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    39.05 ns |   1.083 ns |   0.904 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.88 ns |   2.309 ns |   1.928 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |   108.11 ns |   2.712 ns |   2.117 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   107.29 ns |   2.337 ns |   1.951 ns |  0.07 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    54.09 ns |   2.090 ns |   1.745 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.55 ns |   2.228 ns |   1.861 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   107.98 ns |   3.978 ns |   3.321 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   106.68 ns |   4.337 ns |   3.844 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    42.88 ns |   1.126 ns |   0.998 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.43 ns |   2.281 ns |   2.022 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   543.50 ns |   4.343 ns |   3.627 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    52.36 ns |   2.337 ns |   2.071 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.37 ns |   2.235 ns |   1.745 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.64 ns |   2.276 ns |   2.018 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **73.10 ns** |   **3.585 ns** |   **3.178 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    57.14 ns |   3.120 ns |   2.766 ns |  0.78 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    76.43 ns |   2.608 ns |   2.312 ns |  1.05 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    55.12 ns |   2.970 ns |   2.632 ns |  0.76 |    0.05 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **89.62 ns** |   **3.468 ns** |   **2.896 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.38 ns |   2.864 ns |   2.391 ns |  0.64 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    94.90 ns |   3.319 ns |   2.772 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    54.82 ns |   2.045 ns |   1.707 ns |  0.61 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **112.18 ns** |   **2.917 ns** |   **2.436 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    58.15 ns |   2.697 ns |   2.391 ns |  0.52 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   115.50 ns |   4.081 ns |   3.618 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    54.84 ns |   2.340 ns |   1.827 ns |  0.49 |    0.02 |         - |          NA |

