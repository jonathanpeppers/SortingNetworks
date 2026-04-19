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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,307.96 ns** |  **64.241 ns** |  **56.948 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    94.25 ns |   3.284 ns |   2.911 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,651.27 ns |  67.609 ns |  59.934 ns |  1.26 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,597.36 ns |  92.886 ns |  77.564 ns |  1.22 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   104.62 ns |   2.157 ns |   1.801 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,427.42 ns |  63.107 ns |  55.943 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,414.62 ns |  36.691 ns |  30.639 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,427.62 ns |  49.175 ns |  43.593 ns |  1.09 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,434.81 ns |  37.398 ns |  33.153 ns |  1.10 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,381.67 ns |  56.979 ns |  50.511 ns |  1.06 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   976.79 ns |  75.979 ns |  67.354 ns |  0.75 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   107.00 ns |   5.219 ns |   4.627 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   116.48 ns |   1.976 ns |   1.752 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,290.24 ns |  27.529 ns |  24.404 ns |  0.99 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    39.10 ns |   1.481 ns |   1.313 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.81 ns |   2.147 ns |   1.903 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |    95.93 ns |   2.188 ns |   1.827 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    74.91 ns |   2.560 ns |   2.269 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    56.25 ns |   2.225 ns |   1.972 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.25 ns |   2.406 ns |   2.133 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.19 ns |   3.697 ns |   3.277 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   102.74 ns |   2.250 ns |   1.756 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    42.91 ns |   1.613 ns |   1.430 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.82 ns |   2.756 ns |   2.443 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   525.20 ns |   3.843 ns |   3.209 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    55.90 ns |   2.707 ns |   2.400 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.40 ns |   1.893 ns |   1.678 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.29 ns |   2.276 ns |   2.018 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,306.61 ns |  66.348 ns |  58.816 ns |  1.00 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.75 ns |   2.879 ns |   2.404 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,559.25 ns |  75.135 ns |  62.741 ns |  1.19 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,598.31 ns |  80.260 ns |  71.149 ns |  1.22 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   111.20 ns |   7.456 ns |   6.609 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,397.68 ns |  54.995 ns |  45.923 ns |  1.07 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,466.30 ns |  71.411 ns |  63.304 ns |  1.12 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,412.98 ns |  41.055 ns |  36.394 ns |  1.08 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,439.36 ns |  44.718 ns |  39.641 ns |  1.10 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,392.84 ns |  58.728 ns |  49.040 ns |  1.07 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   973.02 ns | 148.780 ns | 116.158 ns |  0.75 |    0.09 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   105.76 ns |   4.915 ns |   4.357 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   113.76 ns |   4.771 ns |   4.229 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,258.94 ns |  50.831 ns |  45.061 ns |  0.96 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    37.08 ns |   1.129 ns |   1.001 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.83 ns |   2.667 ns |   2.227 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |    92.13 ns |   3.889 ns |   3.247 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    73.36 ns |   1.895 ns |   1.582 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    54.71 ns |   1.813 ns |   1.415 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   104.43 ns |   3.912 ns |   3.266 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.31 ns |   2.150 ns |   1.906 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   103.16 ns |   4.148 ns |   3.677 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    39.64 ns |   1.052 ns |   0.933 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.29 ns |   2.229 ns |   1.976 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   522.14 ns |   4.053 ns |   3.384 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    51.91 ns |   1.897 ns |   1.681 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.56 ns |   2.191 ns |   1.829 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    98.79 ns |   2.280 ns |   2.021 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **70.42 ns** |   **2.995 ns** |   **2.655 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    56.38 ns |   2.239 ns |   1.870 ns |  0.80 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.12 ns |   3.723 ns |   3.109 ns |  1.05 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    57.44 ns |   2.375 ns |   2.106 ns |  0.82 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **84.73 ns** |   **2.241 ns** |   **1.986 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    56.45 ns |   2.172 ns |   1.814 ns |  0.67 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    91.64 ns |   3.658 ns |   3.243 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    54.70 ns |   2.011 ns |   1.783 ns |  0.65 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **109.12 ns** |   **3.726 ns** |   **2.909 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    57.15 ns |   3.685 ns |   3.267 ns |  0.52 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   111.98 ns |   4.724 ns |   4.188 ns |  1.03 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    54.88 ns |   2.274 ns |   1.899 ns |  0.50 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,495.29 ns** |  **70.619 ns** |  **62.602 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   116.56 ns |   1.894 ns |   1.581 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,875.56 ns | 113.051 ns | 100.217 ns |  1.26 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,776.96 ns | 170.618 ns | 151.248 ns |  1.19 |    0.11 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   119.93 ns |   3.046 ns |   2.700 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,616.05 ns |  40.980 ns |  34.220 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,643.86 ns |  52.815 ns |  46.819 ns |  1.10 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,582.25 ns |  88.454 ns |  73.863 ns |  1.06 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,651.25 ns |  46.124 ns |  38.515 ns |  1.11 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,586.49 ns |  49.255 ns |  43.663 ns |  1.06 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,052.75 ns |  78.345 ns |  65.422 ns |  0.71 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   124.24 ns |   4.824 ns |   4.277 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   127.61 ns |   3.387 ns |   3.002 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,469.65 ns |  62.695 ns |  55.577 ns |  0.98 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    38.56 ns |   1.104 ns |   0.979 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |   100.71 ns |   3.091 ns |   2.740 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |    92.42 ns |   2.633 ns |   2.199 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    70.45 ns |   2.563 ns |   2.140 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    55.87 ns |   2.577 ns |   2.152 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.84 ns |   2.405 ns |   2.132 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   106.51 ns |   2.268 ns |   2.011 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   107.04 ns |   2.858 ns |   2.387 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    41.17 ns |   1.069 ns |   0.947 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.43 ns |   2.059 ns |   1.826 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   541.98 ns |   3.703 ns |   2.891 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.54 ns |   1.888 ns |   1.674 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.71 ns |   2.544 ns |   1.987 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   102.77 ns |   2.575 ns |   2.150 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,488.43 ns |  63.090 ns |  55.927 ns |  1.00 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   118.10 ns |   2.562 ns |   2.271 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,739.25 ns | 150.377 ns | 140.663 ns |  1.17 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,777.82 ns | 143.574 ns | 119.891 ns |  1.19 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   125.89 ns |   6.255 ns |   5.545 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,607.50 ns |  42.702 ns |  37.854 ns |  1.08 |    0.05 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,589.14 ns |  75.672 ns |  67.081 ns |  1.06 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,611.86 ns |  93.922 ns |  83.259 ns |  1.08 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,694.86 ns |  36.187 ns |  32.079 ns |  1.14 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,601.99 ns |  55.092 ns |  48.837 ns |  1.07 |    0.05 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,065.47 ns |  69.676 ns |  61.766 ns |  0.71 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   121.75 ns |   4.437 ns |   3.933 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   124.41 ns |   4.028 ns |   3.364 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,460.01 ns |  81.567 ns |  72.307 ns |  0.98 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    37.22 ns |   1.136 ns |   0.949 ns |  0.02 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.40 ns |   2.400 ns |   2.128 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |    99.58 ns |   1.778 ns |   1.576 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    69.97 ns |   2.005 ns |   1.777 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    56.09 ns |   4.939 ns |   4.378 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.61 ns |   2.178 ns |   1.931 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.79 ns |   4.245 ns |   3.763 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   105.14 ns |   2.183 ns |   1.935 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    40.90 ns |   1.183 ns |   0.988 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.57 ns |   2.673 ns |   2.369 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   543.66 ns |   5.290 ns |   4.689 ns |  0.36 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    52.20 ns |   2.735 ns |   2.425 ns |  0.03 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.52 ns |   2.049 ns |   1.711 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   102.78 ns |   2.165 ns |   1.919 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.39 ns** |   **3.474 ns** |   **2.901 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    55.84 ns |   2.491 ns |   2.208 ns |  0.77 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    77.96 ns |   2.291 ns |   1.913 ns |  1.08 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    53.72 ns |   2.382 ns |   2.112 ns |  0.74 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **86.99 ns** |   **3.117 ns** |   **2.603 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.54 ns |   2.468 ns |   2.188 ns |  0.66 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    95.09 ns |   3.851 ns |   3.413 ns |  1.09 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    55.60 ns |   2.312 ns |   2.049 ns |  0.64 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **111.30 ns** |   **4.407 ns** |   **3.680 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    55.49 ns |   2.348 ns |   2.082 ns |  0.50 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   115.89 ns |   3.092 ns |   2.741 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    54.30 ns |   4.139 ns |   3.456 ns |  0.49 |    0.03 |         - |          NA |

