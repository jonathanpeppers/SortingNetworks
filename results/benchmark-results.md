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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,301.43 ns** |  **59.305 ns** |  **52.572 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    92.92 ns |   3.239 ns |   2.529 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,648.46 ns |  86.711 ns |  76.867 ns |  1.27 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,635.59 ns |  72.739 ns |  64.481 ns |  1.26 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   101.40 ns |   3.121 ns |   2.606 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,403.52 ns |  32.076 ns |  28.434 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,398.57 ns |  47.065 ns |  41.722 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,413.98 ns |  35.640 ns |  31.594 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,452.28 ns |  36.898 ns |  32.709 ns |  1.12 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,401.80 ns |  30.772 ns |  27.279 ns |  1.08 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   978.84 ns |  54.460 ns |  45.477 ns |  0.75 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   107.13 ns |   4.180 ns |   3.705 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   117.70 ns |   3.092 ns |   2.582 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,285.46 ns |  29.454 ns |  24.596 ns |  0.99 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    38.97 ns |   1.005 ns |   0.890 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    97.10 ns |   2.156 ns |   1.911 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |    93.05 ns |   2.083 ns |   1.626 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    75.91 ns |   2.003 ns |   1.776 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    56.77 ns |   2.622 ns |   2.324 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.67 ns |   2.769 ns |   2.312 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   102.73 ns |   2.592 ns |   2.297 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   102.35 ns |   2.132 ns |   1.890 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    41.16 ns |   1.069 ns |   0.948 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.91 ns |   1.988 ns |   1.762 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   526.92 ns |   3.285 ns |   2.912 ns |  0.41 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    54.41 ns |   1.889 ns |   1.675 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.14 ns |   3.701 ns |   3.091 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.21 ns |   2.296 ns |   2.036 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,318.26 ns |  33.526 ns |  29.720 ns |  1.01 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.33 ns |   2.385 ns |   1.992 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,548.86 ns |  86.607 ns |  76.775 ns |  1.19 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,603.26 ns |  75.863 ns |  67.250 ns |  1.23 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   107.06 ns |   3.338 ns |   2.959 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,424.01 ns |  30.983 ns |  27.466 ns |  1.10 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,434.59 ns |  30.703 ns |  27.218 ns |  1.10 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,416.76 ns |  30.356 ns |  26.909 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,452.60 ns |  54.703 ns |  48.493 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,404.81 ns |  29.604 ns |  26.243 ns |  1.08 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   967.69 ns |  60.843 ns |  53.936 ns |  0.74 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   107.95 ns |   5.750 ns |   5.097 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   115.71 ns |   4.394 ns |   3.896 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,277.51 ns |  31.320 ns |  27.764 ns |  0.98 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    37.13 ns |   0.932 ns |   0.778 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.21 ns |   1.975 ns |   1.750 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |    90.11 ns |   3.919 ns |   3.272 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    73.49 ns |   1.754 ns |   1.555 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    55.24 ns |   2.510 ns |   2.225 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.21 ns |   2.654 ns |   2.216 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.00 ns |   2.286 ns |   2.027 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   101.14 ns |   2.209 ns |   1.958 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    39.60 ns |   1.139 ns |   1.010 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.17 ns |   2.157 ns |   1.912 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   520.08 ns |   7.862 ns |   6.565 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    52.04 ns |   2.019 ns |   1.790 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.13 ns |   2.045 ns |   1.708 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    98.76 ns |   2.239 ns |   1.985 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.41 ns** |   **2.624 ns** |   **2.326 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    56.79 ns |   2.948 ns |   2.614 ns |  0.81 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.59 ns |   2.898 ns |   2.569 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    54.79 ns |   2.714 ns |   2.267 ns |  0.78 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **84.32 ns** |   **3.220 ns** |   **2.855 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    57.52 ns |   2.483 ns |   2.074 ns |  0.68 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    91.35 ns |   2.999 ns |   2.504 ns |  1.08 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    54.81 ns |   2.070 ns |   1.835 ns |  0.65 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **108.78 ns** |   **3.281 ns** |   **2.909 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    56.63 ns |   2.237 ns |   1.983 ns |  0.52 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   112.54 ns |   2.842 ns |   2.519 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    54.31 ns |   2.330 ns |   1.946 ns |  0.50 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,472.75 ns** |  **61.120 ns** |  **54.181 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.30 ns |   2.680 ns |   2.238 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,835.03 ns |  71.323 ns |  63.226 ns |  1.25 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,774.89 ns | 119.695 ns | 106.107 ns |  1.21 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   119.53 ns |   2.759 ns |   2.304 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,592.49 ns |  60.197 ns |  53.363 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,583.50 ns |  36.010 ns |  30.070 ns |  1.08 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,614.17 ns |  42.010 ns |  37.241 ns |  1.10 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,602.69 ns |  80.585 ns |  71.436 ns |  1.09 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,564.71 ns |  86.424 ns |  76.613 ns |  1.06 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,049.00 ns |  73.812 ns |  65.432 ns |  0.71 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   121.24 ns |   3.141 ns |   2.623 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   125.86 ns |   2.716 ns |   2.407 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,510.14 ns |  34.194 ns |  30.312 ns |  1.03 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    39.21 ns |   1.442 ns |   1.278 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |   100.21 ns |   2.484 ns |   2.202 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |    91.12 ns |   2.850 ns |   2.380 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    70.55 ns |   2.044 ns |   1.812 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    56.75 ns |   4.211 ns |   3.733 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.87 ns |   4.026 ns |   3.569 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.22 ns |   2.621 ns |   2.188 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   106.70 ns |   3.083 ns |   2.575 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    40.99 ns |   1.168 ns |   1.035 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.63 ns |   2.328 ns |   2.064 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   543.64 ns |   6.418 ns |   5.359 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.46 ns |   2.390 ns |   2.119 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   104.32 ns |   2.728 ns |   2.278 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   103.06 ns |   2.799 ns |   2.482 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,502.92 ns |  74.103 ns |  65.690 ns |  1.02 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   134.58 ns |   2.711 ns |   2.403 ns |  0.09 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,751.39 ns | 123.172 ns | 109.189 ns |  1.19 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,809.78 ns |  68.970 ns |  61.140 ns |  1.23 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   126.32 ns |   4.937 ns |   4.377 ns |  0.09 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,632.49 ns |  37.929 ns |  31.672 ns |  1.11 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,653.08 ns |  45.478 ns |  40.315 ns |  1.12 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,608.80 ns |  45.833 ns |  40.630 ns |  1.09 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,660.58 ns |  44.541 ns |  37.194 ns |  1.13 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,589.02 ns |  35.960 ns |  30.028 ns |  1.08 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,063.42 ns |  71.643 ns |  59.825 ns |  0.72 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   120.93 ns |   3.346 ns |   2.966 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   124.98 ns |   2.930 ns |   2.598 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,447.76 ns |  39.782 ns |  35.266 ns |  0.98 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    37.72 ns |   1.318 ns |   1.101 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.15 ns |   2.121 ns |   1.771 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |    94.54 ns |   7.331 ns |   6.499 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    70.16 ns |   1.831 ns |   1.623 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    53.81 ns |   1.667 ns |   1.478 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.25 ns |   2.322 ns |   1.939 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.45 ns |   2.339 ns |   2.073 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   104.92 ns |   1.847 ns |   1.442 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    41.29 ns |   1.332 ns |   1.181 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   101.86 ns |   2.500 ns |   2.088 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   541.47 ns |   4.158 ns |   3.472 ns |  0.37 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    51.48 ns |   1.937 ns |   1.618 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.00 ns |   1.948 ns |   1.626 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.33 ns |   2.355 ns |   1.967 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.25 ns** |   **2.745 ns** |   **2.433 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    55.91 ns |   2.107 ns |   1.868 ns |  0.77 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    75.89 ns |   3.361 ns |   2.980 ns |  1.05 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    53.72 ns |   2.291 ns |   1.913 ns |  0.74 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **90.03 ns** |   **3.266 ns** |   **2.895 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.16 ns |   2.406 ns |   2.132 ns |  0.64 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    94.26 ns |   2.460 ns |   2.054 ns |  1.05 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    55.84 ns |   2.378 ns |   2.108 ns |  0.62 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **111.67 ns** |   **3.349 ns** |   **2.969 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    55.98 ns |   3.141 ns |   2.623 ns |  0.50 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   116.02 ns |   3.405 ns |   2.843 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    53.20 ns |   1.911 ns |   1.694 ns |  0.48 |    0.02 |         - |          NA |

