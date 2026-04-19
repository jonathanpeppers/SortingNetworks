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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,322.63 ns** |  **33.682 ns** |  **28.126 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    95.59 ns |   3.458 ns |   3.066 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,627.69 ns |  56.422 ns |  50.016 ns |  1.23 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,531.35 ns | 102.998 ns |  86.008 ns |  1.16 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   104.89 ns |   5.312 ns |   4.709 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,422.64 ns |  43.162 ns |  38.262 ns |  1.08 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,395.21 ns |  50.309 ns |  44.598 ns |  1.06 |    0.04 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,369.96 ns |  66.929 ns |  59.331 ns |  1.04 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,449.79 ns |  72.302 ns |  64.094 ns |  1.10 |    0.05 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,363.93 ns |  67.431 ns |  59.776 ns |  1.03 |    0.05 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   974.16 ns |  73.678 ns |  65.313 ns |  0.74 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   108.87 ns |   5.813 ns |   5.153 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   116.90 ns |   2.936 ns |   2.603 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,288.44 ns |  62.141 ns |  55.086 ns |  0.97 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    41.23 ns |   1.492 ns |   1.323 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    97.04 ns |   2.949 ns |   2.614 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |    93.59 ns |   2.312 ns |   2.050 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    75.76 ns |   1.771 ns |   1.570 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    56.64 ns |   2.253 ns |   1.997 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.88 ns |   2.448 ns |   2.170 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.33 ns |   2.401 ns |   2.005 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   103.49 ns |   2.944 ns |   2.610 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    43.29 ns |   1.142 ns |   1.012 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   101.71 ns |   3.203 ns |   2.840 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   528.36 ns |   6.263 ns |   4.890 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    54.19 ns |   2.212 ns |   1.847 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.66 ns |   2.972 ns |   2.635 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.58 ns |   2.334 ns |   2.069 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,356.12 ns |  39.991 ns |  35.451 ns |  1.03 |    0.03 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.02 ns |   2.912 ns |   2.432 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,571.59 ns | 103.794 ns |  81.036 ns |  1.19 |    0.06 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,593.46 ns |  77.065 ns |  68.316 ns |  1.21 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   109.89 ns |   5.775 ns |   5.119 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,398.44 ns |  56.244 ns |  49.859 ns |  1.06 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,426.61 ns |  68.206 ns |  60.463 ns |  1.08 |    0.05 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,415.64 ns |  39.662 ns |  35.159 ns |  1.07 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,459.05 ns |  29.908 ns |  24.975 ns |  1.10 |    0.03 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,395.94 ns |  53.934 ns |  47.811 ns |  1.06 |    0.04 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   986.36 ns |  61.696 ns |  54.692 ns |  0.75 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   105.49 ns |   4.670 ns |   4.140 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   115.19 ns |   4.623 ns |   4.098 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,268.61 ns |  62.006 ns |  54.967 ns |  0.96 |    0.04 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    39.38 ns |   1.394 ns |   1.235 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.34 ns |   1.849 ns |   1.639 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |    91.49 ns |   5.685 ns |   4.747 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    72.39 ns |   2.232 ns |   1.979 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    54.85 ns |   1.602 ns |   1.251 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.85 ns |   2.547 ns |   2.258 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   102.51 ns |   3.602 ns |   3.008 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   101.45 ns |   2.495 ns |   2.211 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    49.25 ns |   7.424 ns |   6.582 ns |  0.04 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.67 ns |   2.406 ns |   2.133 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   521.13 ns |   6.424 ns |   5.364 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    53.88 ns |   2.715 ns |   2.267 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.04 ns |   2.990 ns |   2.650 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |   105.32 ns |  13.774 ns |  11.502 ns |  0.08 |    0.01 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **69.92 ns** |   **2.978 ns** |   **2.487 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    58.65 ns |   4.013 ns |   3.351 ns |  0.84 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.07 ns |   3.799 ns |   2.966 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    54.97 ns |   1.451 ns |   1.212 ns |  0.79 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **85.34 ns** |   **4.117 ns** |   **3.214 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    58.78 ns |   8.504 ns |   7.101 ns |  0.69 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    91.22 ns |   2.727 ns |   2.277 ns |  1.07 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    54.53 ns |   2.074 ns |   1.838 ns |  0.64 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **108.16 ns** |   **3.442 ns** |   **3.052 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    56.89 ns |   2.410 ns |   2.137 ns |  0.53 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   112.64 ns |   4.213 ns |   3.735 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    54.58 ns |   2.212 ns |   1.847 ns |  0.51 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,466.40 ns** |  **82.250 ns** |  **72.913 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   125.45 ns |  14.157 ns |  11.822 ns |  0.09 |    0.01 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,838.05 ns |  70.517 ns |  62.512 ns |  1.26 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,768.94 ns | 178.186 ns | 157.957 ns |  1.21 |    0.12 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   123.49 ns |   4.715 ns |   3.938 ns |  0.08 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,589.84 ns |  34.870 ns |  29.118 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,633.23 ns |  32.426 ns |  28.745 ns |  1.12 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,598.04 ns |  77.000 ns |  68.259 ns |  1.09 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,633.43 ns | 143.131 ns | 133.884 ns |  1.12 |    0.11 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,598.28 ns |  37.732 ns |  33.449 ns |  1.09 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,049.21 ns |  93.832 ns |  78.354 ns |  0.72 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   122.62 ns |   3.039 ns |   2.538 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   129.22 ns |   5.744 ns |   4.796 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,490.41 ns |  78.035 ns |  69.176 ns |  1.02 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    41.01 ns |   1.580 ns |   1.400 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    99.84 ns |   1.962 ns |   1.739 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |   100.00 ns |   2.793 ns |   2.332 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    72.69 ns |   2.623 ns |   2.191 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    55.86 ns |   2.481 ns |   2.200 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   106.80 ns |   2.191 ns |   1.943 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   108.98 ns |   3.768 ns |   3.340 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   106.57 ns |   2.419 ns |   1.889 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    46.14 ns |   3.453 ns |   3.061 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.88 ns |   2.609 ns |   2.178 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   540.48 ns |   5.371 ns |   4.194 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.44 ns |   2.703 ns |   2.396 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   104.61 ns |   3.226 ns |   2.860 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   103.31 ns |   2.448 ns |   1.911 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,495.86 ns |  83.932 ns |  74.404 ns |  1.02 |    0.07 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   117.57 ns |   3.350 ns |   2.970 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,715.69 ns | 151.242 ns | 126.294 ns |  1.17 |    0.10 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,796.47 ns |  72.020 ns |  56.228 ns |  1.23 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   125.30 ns |   6.337 ns |   5.292 ns |  0.09 |    0.01 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,545.43 ns |  63.929 ns |  56.671 ns |  1.06 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,600.46 ns |  86.002 ns |  71.815 ns |  1.09 |    0.08 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,533.02 ns |  75.629 ns |  67.044 ns |  1.05 |    0.07 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,599.63 ns | 119.223 ns | 105.688 ns |  1.09 |    0.09 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,578.40 ns |  67.570 ns |  52.754 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,023.65 ns | 126.601 ns | 105.718 ns |  0.70 |    0.08 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   121.96 ns |   3.535 ns |   3.134 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   125.79 ns |   3.748 ns |   3.130 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,419.68 ns | 101.810 ns |  90.251 ns |  0.97 |    0.08 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    39.08 ns |   1.118 ns |   0.991 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    99.59 ns |   2.546 ns |   2.257 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |    91.16 ns |   5.036 ns |   4.465 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    69.12 ns |   1.996 ns |   1.667 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    53.68 ns |   2.109 ns |   1.761 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.09 ns |   1.974 ns |   1.749 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.12 ns |   2.842 ns |   2.373 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   106.09 ns |   2.613 ns |   2.317 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    41.65 ns |   1.721 ns |   1.437 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   106.83 ns |  13.089 ns |  10.930 ns |  0.07 |    0.01 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   539.73 ns |   5.681 ns |   5.036 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    51.99 ns |   2.728 ns |   2.278 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.42 ns |   2.353 ns |   2.086 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.31 ns |   2.103 ns |   1.864 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.21 ns** |   **3.235 ns** |   **2.701 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    56.19 ns |   3.369 ns |   2.987 ns |  0.78 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    76.22 ns |   3.357 ns |   2.803 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    54.43 ns |   3.522 ns |   3.122 ns |  0.75 |    0.05 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **90.65 ns** |   **3.684 ns** |   **3.265 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    56.92 ns |   2.494 ns |   2.083 ns |  0.63 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    93.81 ns |   2.086 ns |   1.742 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    53.61 ns |   2.107 ns |   1.867 ns |  0.59 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **111.46 ns** |   **2.672 ns** |   **2.369 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    55.58 ns |   2.513 ns |   2.098 ns |  0.50 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   114.75 ns |   2.853 ns |   2.382 ns |  1.03 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    53.93 ns |   2.765 ns |   2.309 ns |  0.48 |    0.02 |         - |          NA |

