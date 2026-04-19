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
| **ByteSortingBenchmarks**   | **ArraySort**        | **27**     | **Random**     | **1,290.26 ns** |  **63.739 ns** |  **56.503 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 27     | Random     |    92.81 ns |   2.137 ns |   1.894 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 27     | Random     | 1,599.43 ns |  83.339 ns |  73.878 ns |  1.24 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 27     | Random     | 1,526.61 ns |  95.608 ns |  84.754 ns |  1.19 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 27     | Random     |   102.03 ns |   3.245 ns |   2.877 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 27     | Random     | 1,418.01 ns |  48.453 ns |  42.952 ns |  1.10 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 27     | Random     | 1,401.77 ns |  51.494 ns |  45.648 ns |  1.09 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 27     | Random     | 1,410.86 ns |  39.704 ns |  35.196 ns |  1.10 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 27     | Random     | 1,444.19 ns |  36.466 ns |  32.326 ns |  1.12 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 27     | Random     | 1,380.31 ns |  50.243 ns |  44.539 ns |  1.07 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 27     | Random     |   973.25 ns |  84.241 ns |  70.345 ns |  0.76 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 27     | Random     |   107.35 ns |   5.021 ns |   4.451 ns |  0.08 |    0.01 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 27     | Random     |   117.74 ns |   2.517 ns |   2.102 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 27     | Random     | 1,291.04 ns |  28.494 ns |  25.259 ns |  1.00 |    0.05 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 27     | Random     |    39.93 ns |   1.376 ns |   1.149 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 27     | Random     |    96.56 ns |   2.404 ns |   2.131 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 27     | Random     |    93.38 ns |   2.293 ns |   2.033 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 27     | Random     |    75.45 ns |   2.592 ns |   2.164 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 27     | Random     |    56.99 ns |   3.332 ns |   2.783 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 27     | Random     |   105.07 ns |   3.143 ns |   2.624 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 27     | Random     |   103.07 ns |   2.606 ns |   2.177 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 27     | Random     |   103.16 ns |   2.128 ns |   1.887 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 27     | Random     |    41.19 ns |   1.204 ns |   1.068 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.74 ns |   2.606 ns |   2.310 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 27     | Random     |   531.95 ns |   4.272 ns |   3.787 ns |  0.41 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 27     | Random     |    53.97 ns |   2.636 ns |   2.201 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 27     | Random     |   100.52 ns |   1.589 ns |   1.408 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 27     | Random     |   100.41 ns |   2.206 ns |   1.956 ns |  0.08 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 27     | Random     | 1,323.13 ns |  46.220 ns |  40.973 ns |  1.03 |    0.06 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 27     | Random     |    96.42 ns |   2.658 ns |   2.220 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 27     | Random     | 1,625.19 ns |  89.165 ns |  79.043 ns |  1.26 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 27     | Random     | 1,617.59 ns |  46.391 ns |  41.124 ns |  1.26 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Random     |   109.06 ns |   4.759 ns |   3.974 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 27     | Random     | 1,408.45 ns |  48.518 ns |  40.515 ns |  1.09 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 27     | Random     | 1,527.64 ns |  39.635 ns |  35.135 ns |  1.19 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 27     | Random     | 1,443.05 ns |  38.469 ns |  34.102 ns |  1.12 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 27     | Random     | 1,457.51 ns |  41.083 ns |  36.419 ns |  1.13 |    0.06 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 27     | Random     | 1,395.99 ns |  39.179 ns |  34.731 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 27     | Random     |   964.06 ns |  54.143 ns |  47.996 ns |  0.75 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 27     | Random     |   104.05 ns |   5.262 ns |   4.394 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 27     | Random     |   115.46 ns |   4.323 ns |   3.832 ns |  0.09 |    0.01 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 27     | Random     | 1,265.87 ns |  58.958 ns |  52.265 ns |  0.98 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    36.94 ns |   1.086 ns |   0.907 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    96.27 ns |   2.639 ns |   2.339 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 27     | Random     |    90.68 ns |   3.461 ns |   3.068 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    72.71 ns |   2.057 ns |   1.824 ns |  0.06 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Random     |    54.66 ns |   2.475 ns |   2.194 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   102.34 ns |   1.984 ns |   1.758 ns |  0.08 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |   101.24 ns |   2.404 ns |   2.131 ns |  0.08 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   102.03 ns |   2.970 ns |   2.480 ns |  0.08 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    39.79 ns |   1.103 ns |   0.978 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 27     | Random     |   100.16 ns |   2.595 ns |   2.301 ns |  0.08 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 27     | Random     |   519.15 ns |   4.136 ns |   3.667 ns |  0.40 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 27     | Random     |    54.47 ns |   2.494 ns |   1.947 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 27     | Random     |    98.79 ns |   1.999 ns |   1.669 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 27     | Random     |    98.65 ns |   2.385 ns |   1.992 ns |  0.08 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Sorted**     |    **69.98 ns** |   **2.530 ns** |   **2.243 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Sorted     |    56.67 ns |   3.223 ns |   2.691 ns |  0.81 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Sorted     |    75.40 ns |   4.192 ns |   3.716 ns |  1.08 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Sorted     |    55.91 ns |   2.612 ns |   2.316 ns |  0.80 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Reversed**   |    **83.98 ns** |   **2.441 ns** |   **2.164 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Reversed   |    56.67 ns |   2.004 ns |   1.777 ns |  0.68 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Reversed   |    90.40 ns |   3.057 ns |   2.710 ns |  1.08 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Reversed   |    55.90 ns |   2.162 ns |   1.916 ns |  0.67 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **27**     | **Duplicates** |   **108.85 ns** |   **3.086 ns** |   **2.577 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 27     | Duplicates |    59.28 ns |   2.211 ns |   1.960 ns |  0.54 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 27     | Duplicates |   113.18 ns |   1.858 ns |   1.647 ns |  1.04 |    0.03 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 27     | Duplicates |    54.87 ns |   1.995 ns |   1.558 ns |  0.50 |    0.02 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **ByteSortingBenchmarks**   | **ArraySort**        | **28**     | **Random**     | **1,466.80 ns** |  **72.480 ns** |  **64.251 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| CharSortingBenchmarks   | ArraySort        | 28     | Random     |   115.92 ns |   3.427 ns |   2.862 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | ArraySort        | 28     | Random     | 1,817.40 ns | 110.349 ns |  97.821 ns |  1.24 |    0.08 |         - |          NA |
| FloatSortingBenchmarks  | ArraySort        | 28     | Random     | 1,809.60 ns |  74.452 ns |  62.171 ns |  1.24 |    0.07 |         - |          NA |
| IntSortingBenchmarks    | ArraySort        | 28     | Random     |   120.81 ns |   2.588 ns |   2.161 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | ArraySort        | 28     | Random     | 1,583.67 ns |  49.661 ns |  44.023 ns |  1.08 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | ArraySort        | 28     | Random     | 1,562.68 ns |  93.527 ns |  78.100 ns |  1.07 |    0.07 |         - |          NA |
| NUIntSortingBenchmarks  | ArraySort        | 28     | Random     | 1,594.91 ns |  73.090 ns |  64.792 ns |  1.09 |    0.06 |         - |          NA |
| SByteSortingBenchmarks  | ArraySort        | 28     | Random     | 1,627.60 ns |  75.716 ns |  67.120 ns |  1.11 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | ArraySort        | 28     | Random     | 1,574.80 ns |  58.165 ns |  51.562 ns |  1.08 |    0.06 |         - |          NA |
| StringSortingBenchmarks | ArraySort        | 28     | Random     | 1,061.78 ns |  72.525 ns |  64.291 ns |  0.73 |    0.05 |      64 B |          NA |
| UIntSortingBenchmarks   | ArraySort        | 28     | Random     |   121.52 ns |   1.422 ns |   1.187 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | ArraySort        | 28     | Random     |   126.53 ns |   3.028 ns |   2.364 ns |  0.09 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | ArraySort        | 28     | Random     | 1,466.14 ns |  67.054 ns |  59.442 ns |  1.00 |    0.06 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort      | 28     | Random     |    39.29 ns |   1.630 ns |   1.445 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort      | 28     | Random     |   100.81 ns |   2.975 ns |   2.638 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort      | 28     | Random     |    91.89 ns |   5.209 ns |   4.350 ns |  0.06 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort      | 28     | Random     |    73.66 ns |   4.037 ns |   3.579 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort      | 28     | Random     |    57.61 ns |   2.463 ns |   2.183 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort      | 28     | Random     |   106.69 ns |   2.567 ns |   2.144 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort      | 28     | Random     |   107.05 ns |   1.831 ns |   1.623 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort      | 28     | Random     |   107.85 ns |   2.600 ns |   2.304 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort      | 28     | Random     |    42.55 ns |   1.410 ns |   1.177 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.35 ns |   2.327 ns |   2.062 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort      | 28     | Random     |   544.32 ns |   3.555 ns |   2.776 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort      | 28     | Random     |    54.44 ns |   2.851 ns |   2.527 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort      | 28     | Random     |   103.87 ns |   2.194 ns |   1.832 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort      | 28     | Random     |   103.06 ns |   2.332 ns |   2.067 ns |  0.07 |    0.00 |         - |          NA |
| ByteSortingBenchmarks   | SpanSort         | 28     | Random     | 1,498.88 ns |  44.551 ns |  37.202 ns |  1.02 |    0.05 |         - |          NA |
| CharSortingBenchmarks   | SpanSort         | 28     | Random     |   118.59 ns |   3.403 ns |   3.016 ns |  0.08 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | SpanSort         | 28     | Random     | 1,750.23 ns | 132.147 ns | 117.145 ns |  1.20 |    0.09 |         - |          NA |
| FloatSortingBenchmarks  | SpanSort         | 28     | Random     | 1,803.32 ns | 110.682 ns |  98.117 ns |  1.23 |    0.08 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Random     |   122.55 ns |   2.921 ns |   2.589 ns |  0.08 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | SpanSort         | 28     | Random     | 1,627.04 ns |  67.106 ns |  59.487 ns |  1.11 |    0.06 |         - |          NA |
| NIntSortingBenchmarks   | SpanSort         | 28     | Random     | 1,576.84 ns |  76.719 ns |  59.897 ns |  1.08 |    0.06 |         - |          NA |
| NUIntSortingBenchmarks  | SpanSort         | 28     | Random     | 1,627.18 ns |  38.030 ns |  33.712 ns |  1.11 |    0.05 |         - |          NA |
| SByteSortingBenchmarks  | SpanSort         | 28     | Random     | 1,656.21 ns |  76.974 ns |  68.235 ns |  1.13 |    0.07 |         - |          NA |
| ShortSortingBenchmarks  | SpanSort         | 28     | Random     | 1,572.36 ns |  81.365 ns |  72.128 ns |  1.07 |    0.07 |         - |          NA |
| StringSortingBenchmarks | SpanSort         | 28     | Random     | 1,046.84 ns |  79.073 ns |  70.097 ns |  0.72 |    0.06 |      64 B |          NA |
| UIntSortingBenchmarks   | SpanSort         | 28     | Random     |   120.75 ns |   3.609 ns |   3.199 ns |  0.08 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | SpanSort         | 28     | Random     |   124.17 ns |   2.982 ns |   2.644 ns |  0.08 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | SpanSort         | 28     | Random     | 1,436.56 ns |  83.741 ns |  74.234 ns |  0.98 |    0.07 |         - |          NA |
| ByteSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    36.97 ns |   1.034 ns |   0.917 ns |  0.03 |    0.00 |         - |          NA |
| CharSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    98.39 ns |   2.038 ns |   1.807 ns |  0.07 |    0.00 |         - |          NA |
| DoubleSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.81 ns |   5.985 ns |   5.305 ns |  0.07 |    0.00 |         - |          NA |
| FloatSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    68.88 ns |   1.890 ns |   1.579 ns |  0.05 |    0.00 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Random     |    53.61 ns |   2.008 ns |   1.780 ns |  0.04 |    0.00 |         - |          NA |
| LongSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   105.29 ns |   2.217 ns |   1.966 ns |  0.07 |    0.00 |         - |          NA |
| NIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |   106.82 ns |   3.017 ns |   2.519 ns |  0.07 |    0.00 |         - |          NA |
| NUIntSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   105.01 ns |   2.607 ns |   2.035 ns |  0.07 |    0.00 |         - |          NA |
| SByteSortingBenchmarks  | NetworkSort_Span | 28     | Random     |    40.99 ns |   1.152 ns |   1.022 ns |  0.03 |    0.00 |         - |          NA |
| ShortSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   102.00 ns |   2.290 ns |   2.030 ns |  0.07 |    0.00 |         - |          NA |
| StringSortingBenchmarks | NetworkSort_Span | 28     | Random     |   542.54 ns |   5.191 ns |   4.335 ns |  0.37 |    0.02 |         - |          NA |
| UIntSortingBenchmarks   | NetworkSort_Span | 28     | Random     |    53.14 ns |   2.051 ns |   1.818 ns |  0.04 |    0.00 |         - |          NA |
| ULongSortingBenchmarks  | NetworkSort_Span | 28     | Random     |   103.22 ns |   3.448 ns |   2.879 ns |  0.07 |    0.00 |         - |          NA |
| UShortSortingBenchmarks | NetworkSort_Span | 28     | Random     |   101.18 ns |   2.123 ns |   1.882 ns |  0.07 |    0.00 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Sorted**     |    **72.55 ns** |   **3.260 ns** |   **2.723 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Sorted     |    56.30 ns |   2.822 ns |   2.501 ns |  0.78 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Sorted     |    76.23 ns |   3.626 ns |   3.028 ns |  1.05 |    0.06 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Sorted     |    53.68 ns |   2.499 ns |   2.087 ns |  0.74 |    0.04 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Reversed**   |    **89.62 ns** |   **3.557 ns** |   **2.970 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Reversed   |    57.54 ns |   2.964 ns |   2.628 ns |  0.64 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Reversed   |    94.58 ns |   3.768 ns |   3.146 ns |  1.06 |    0.05 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Reversed   |    54.63 ns |   1.863 ns |   1.651 ns |  0.61 |    0.03 |         - |          NA |
|                         |                  |        |            |             |            |            |       |         |           |             |
| **IntSortingBenchmarks**    | **ArraySort**        | **28**     | **Duplicates** |   **112.38 ns** |   **2.982 ns** |   **2.643 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| IntSortingBenchmarks    | NetworkSort      | 28     | Duplicates |    56.22 ns |   2.834 ns |   2.512 ns |  0.50 |    0.02 |         - |          NA |
| IntSortingBenchmarks    | SpanSort         | 28     | Duplicates |   116.00 ns |   4.080 ns |   3.617 ns |  1.03 |    0.04 |         - |          NA |
| IntSortingBenchmarks    | NetworkSort_Span | 28     | Duplicates |    53.65 ns |   2.883 ns |   2.407 ns |  0.48 |    0.02 |         - |          NA |

