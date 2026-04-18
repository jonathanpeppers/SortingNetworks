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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,326.80 ns** |  **30.853 ns** |  **25.763 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    94.21 ns |   3.609 ns |   3.013 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,785.01 ns |  56.882 ns |  50.424 ns |  1.35 |    0.04 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,594.46 ns |  87.334 ns |  68.185 ns |  1.20 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   101.79 ns |   3.456 ns |   2.698 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,406.79 ns |  52.778 ns |  46.787 ns |  1.06 |    0.04 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,408.90 ns |  30.306 ns |  26.866 ns |  1.06 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,414.02 ns |  35.121 ns |  29.327 ns |  1.07 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,440.84 ns |  60.164 ns |  53.334 ns |  1.09 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,405.29 ns |  61.561 ns |  54.572 ns |  1.06 |    0.04 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   973.95 ns |  92.504 ns |  77.245 ns |  0.73 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   109.68 ns |   7.905 ns |   6.601 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   117.09 ns |   4.490 ns |   3.749 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,278.34 ns |  37.506 ns |  33.248 ns |  0.96 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    42.49 ns |   1.636 ns |   1.450 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    97.04 ns |   2.424 ns |   2.149 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |   111.54 ns |   2.665 ns |   2.362 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |   108.13 ns |   2.518 ns |   2.103 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    56.90 ns |   2.319 ns |   2.056 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.22 ns |   3.330 ns |   2.781 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   102.97 ns |   2.461 ns |   2.055 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   103.16 ns |   2.209 ns |   1.958 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    45.28 ns |   2.827 ns |   2.506 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   101.16 ns |   2.579 ns |   2.286 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   529.42 ns |   3.148 ns |   2.629 ns |  0.40 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    53.99 ns |   2.381 ns |   1.988 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   101.92 ns |   2.230 ns |   1.976 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.35 ns |   2.564 ns |   2.141 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,302.94 ns |  44.962 ns |  39.858 ns |  0.98 |    0.03 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    95.52 ns |   2.027 ns |   1.797 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,568.94 ns | 105.045 ns |  93.119 ns |  1.18 |    0.07 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,602.95 ns |  83.396 ns |  69.640 ns |  1.21 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   106.34 ns |   3.975 ns |   3.103 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,417.93 ns |  38.182 ns |  33.848 ns |  1.07 |    0.03 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,421.59 ns |  46.083 ns |  38.482 ns |  1.07 |    0.03 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,428.13 ns |  27.600 ns |  24.467 ns |  1.08 |    0.03 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,436.35 ns |  58.055 ns |  48.478 ns |  1.08 |    0.04 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,410.19 ns |  37.738 ns |  31.513 ns |  1.06 |    0.03 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   971.73 ns |  57.824 ns |  51.260 ns |  0.73 |    0.04 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   104.27 ns |   5.458 ns |   4.839 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   115.29 ns |   6.020 ns |   5.337 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,261.30 ns |  38.462 ns |  34.096 ns |  0.95 |    0.03 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    39.20 ns |   1.315 ns |   1.166 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    95.17 ns |   2.035 ns |   1.804 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |   110.06 ns |   4.188 ns |   3.713 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   104.98 ns |   2.248 ns |   1.993 ns |  0.08 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    55.18 ns |   2.028 ns |   1.694 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.81 ns |   4.317 ns |   3.605 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   100.94 ns |   2.991 ns |   2.498 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   101.80 ns |   3.091 ns |   2.581 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    41.62 ns |   1.153 ns |   1.022 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    99.36 ns |   2.696 ns |   2.390 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   517.07 ns |   3.811 ns |   3.183 ns |  0.39 |    0.01 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    54.43 ns |   2.178 ns |   1.819 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   100.50 ns |   2.495 ns |   2.084 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    99.48 ns |   3.161 ns |   2.468 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **69.95 ns** |   **2.928 ns** |   **2.445 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    56.34 ns |   2.205 ns |   1.954 ns |  0.81 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    74.15 ns |   4.059 ns |   3.389 ns |  1.06 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    54.97 ns |   2.373 ns |   1.981 ns |  0.79 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **86.06 ns** |   **3.205 ns** |   **2.841 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    56.72 ns |   2.508 ns |   2.094 ns |  0.66 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    91.51 ns |   3.902 ns |   3.459 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    54.76 ns |   2.018 ns |   1.789 ns |  0.64 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **106.10 ns** |   **3.163 ns** |   **2.642 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    56.39 ns |   2.314 ns |   1.932 ns |  0.53 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   110.49 ns |   3.684 ns |   3.266 ns |  1.04 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    54.73 ns |   1.928 ns |   1.709 ns |  0.52 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,464.58 ns** |  **75.792 ns** |  **67.187 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.94 ns |   3.711 ns |   3.289 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,830.54 ns |  81.430 ns |  67.998 ns |  1.25 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,818.25 ns |  85.111 ns |  71.072 ns |  1.24 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   120.09 ns |   3.873 ns |   3.024 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,576.48 ns |  75.867 ns |  63.353 ns |  1.08 |    0.07 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,614.93 ns |  70.984 ns |  62.926 ns |  1.11 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,677.64 ns |  41.005 ns |  36.350 ns |  1.15 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,616.25 ns |  63.580 ns |  53.092 ns |  1.11 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,574.49 ns |  88.594 ns |  78.536 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,054.83 ns |  83.157 ns |  69.440 ns |  0.72 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   122.28 ns |   4.835 ns |   4.287 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   128.66 ns |   5.750 ns |   5.097 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,638.29 ns |  46.283 ns |  38.649 ns |  1.12 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    40.91 ns |   1.224 ns |   1.085 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |    99.66 ns |   2.520 ns |   2.234 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |   110.83 ns |   2.635 ns |   2.336 ns |  0.08 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |   108.94 ns |   3.123 ns |   2.608 ns |  0.07 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    59.17 ns |   4.433 ns |   3.702 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   108.35 ns |   3.097 ns |   2.418 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.86 ns |   2.832 ns |   2.511 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   107.18 ns |   3.399 ns |   2.838 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    44.14 ns |   1.798 ns |   1.594 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.61 ns |   2.167 ns |   1.921 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   542.85 ns |   5.383 ns |   4.495 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.39 ns |   1.944 ns |   1.724 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   104.67 ns |   2.325 ns |   1.942 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   104.36 ns |   2.180 ns |   1.933 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,490.65 ns |  70.776 ns |  59.101 ns |  1.02 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   117.07 ns |   3.343 ns |   2.610 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,729.51 ns | 178.575 ns | 149.118 ns |  1.18 |    0.11 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 2,082.09 ns | 100.608 ns |  89.186 ns |  1.42 |    0.09 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   122.53 ns |   3.192 ns |   2.492 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,593.65 ns |  51.432 ns |  42.948 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,590.98 ns |  72.179 ns |  60.272 ns |  1.09 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,592.74 ns |  65.419 ns |  54.627 ns |  1.09 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,668.74 ns |  80.553 ns |  71.408 ns |  1.14 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,575.03 ns |  80.634 ns |  71.480 ns |  1.08 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,048.22 ns |  91.154 ns |  76.118 ns |  0.72 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   119.27 ns |   4.252 ns |   3.551 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   126.98 ns |   3.769 ns |   3.341 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,448.23 ns |  75.285 ns |  66.739 ns |  0.99 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    39.04 ns |   1.189 ns |   1.054 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.24 ns |   2.392 ns |   2.121 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |   108.46 ns |   2.037 ns |   1.805 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   107.39 ns |   3.945 ns |   3.497 ns |  0.07 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    54.16 ns |   2.050 ns |   1.817 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.77 ns |   1.957 ns |   1.735 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.70 ns |   2.744 ns |   2.143 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   105.43 ns |   3.298 ns |   2.754 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    41.65 ns |   1.138 ns |   0.950 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   103.11 ns |   2.681 ns |   2.238 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   540.12 ns |   6.578 ns |   5.136 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    55.16 ns |   2.865 ns |   2.539 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   103.34 ns |   3.981 ns |   3.529 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.62 ns |   2.593 ns |   2.165 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.88 ns** |   **3.558 ns** |   **2.971 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    56.42 ns |   4.211 ns |   3.288 ns |  0.78 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    75.95 ns |   3.291 ns |   2.748 ns |  1.04 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    56.60 ns |   2.147 ns |   1.793 ns |  0.78 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **88.44 ns** |   **3.050 ns** |   **2.547 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.95 ns |   2.143 ns |   1.789 ns |  0.66 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    96.60 ns |   3.957 ns |   3.508 ns |  1.09 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    56.39 ns |   2.048 ns |   1.815 ns |  0.64 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **112.19 ns** |   **2.786 ns** |   **2.469 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    58.20 ns |   2.353 ns |   2.085 ns |  0.52 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   117.14 ns |   3.415 ns |   3.028 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    54.29 ns |   2.059 ns |   1.825 ns |  0.48 |    0.02 |         - |          NA |

