## Byte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,829.24 ns** |  **84.288 ns** |  **74.719 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    41.27 ns |   8.557 ns |   7.586 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,825.65 ns |  68.123 ns |  60.390 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |    32.47 ns |   3.489 ns |   2.914 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    34.39 ns |   6.019 ns |   5.335 ns |  0.02 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,079.12 ns** | **210.058 ns** | **164.000 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    37.07 ns |   7.925 ns |   6.618 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,065.25 ns | 109.994 ns |  97.506 ns |  1.00 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Random |    38.94 ns |   5.657 ns |   4.724 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    39.29 ns |   4.840 ns |   4.291 ns |  0.02 |    0.00 |         - |          NA |

## Char

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |  **39.49 ns** |  **5.010 ns** |  **4.441 ns** |  **1.01** |    **0.18** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |  55.07 ns |  3.257 ns |  2.887 ns |  1.41 |    0.20 |         - |          NA |
| SpanSort         | 8      | Random |  61.45 ns |  8.548 ns |  7.138 ns |  1.58 |    0.28 |         - |          NA |
| NetworkSort_Span | 8      | Random |  44.82 ns |  5.277 ns |  4.120 ns |  1.15 |    0.19 |         - |          NA |
| GeneratedSort    | 8      | Random |  23.48 ns |  6.983 ns |  6.190 ns |  0.60 |    0.17 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** |  **89.50 ns** |  **4.668 ns** |  **4.138 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 16     | Random |  91.89 ns |  3.177 ns |  2.817 ns |  1.03 |    0.06 |         - |          NA |
| SpanSort         | 16     | Random |  93.36 ns |  9.031 ns |  7.541 ns |  1.05 |    0.10 |         - |          NA |
| NetworkSort_Span | 16     | Random | 102.22 ns |  3.178 ns |  2.817 ns |  1.14 |    0.06 |         - |          NA |
| GeneratedSort    | 16     | Random |  33.19 ns |  3.122 ns |  2.607 ns |  0.37 |    0.03 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **115.89 ns** |  **5.549 ns** |  **4.919 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 134.99 ns |  4.063 ns |  3.172 ns |  1.17 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random | 127.41 ns |  6.712 ns |  5.240 ns |  1.10 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random | 133.67 ns |  4.381 ns |  3.421 ns |  1.16 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random | 142.01 ns |  4.500 ns |  3.513 ns |  1.23 |    0.06 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **142.09 ns** |  **4.521 ns** |  **3.775 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 138.25 ns |  4.032 ns |  3.148 ns |  0.97 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 209.18 ns | 75.812 ns | 67.205 ns |  1.47 |    0.46 |         - |          NA |
| NetworkSort_Span | 28     | Random | 139.98 ns |  4.864 ns |  3.798 ns |  0.99 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 138.18 ns |  5.573 ns |  4.351 ns |  0.97 |    0.04 |         - |          NA |

## Double

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,554.0 ns** |  **54.97 ns** | **48.73 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   124.2 ns |   5.30 ns |  4.14 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,282.5 ns |  40.08 ns | 33.47 ns |  0.89 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   115.6 ns |   3.59 ns |  3.19 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   156.1 ns |  11.38 ns |  9.50 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |            |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,476.9 ns** |  **92.12 ns** | **81.66 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   116.1 ns |   3.90 ns |  3.04 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,458.8 ns | 112.25 ns | 99.51 ns |  0.99 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   116.7 ns |   4.03 ns |  3.36 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   165.1 ns |  16.68 ns | 14.79 ns |  0.07 |    0.01 |         - |          NA |

## Float

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,703.08 ns** | **631.568 ns** | **590.770 ns** |  **1.04** |    **0.30** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   112.59 ns |   5.651 ns |   4.719 ns |  0.04 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 2,205.00 ns |  71.248 ns |  63.159 ns |  0.85 |    0.16 |         - |          NA |
| NetworkSort_Span | 27     | Random |    95.44 ns |   3.977 ns |   3.526 ns |  0.04 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |    68.50 ns |   2.869 ns |   2.240 ns |  0.03 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,488.67 ns** | **154.850 ns** | **144.846 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   104.53 ns |   1.887 ns |   1.576 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,468.72 ns | 100.716 ns |  89.282 ns |  0.99 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |    88.98 ns |   1.733 ns |   1.447 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    70.08 ns |   4.173 ns |   3.699 ns |  0.03 |    0.00 |         - |          NA |

## Int

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind       | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |----------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random**     | **104.76 ns** |  **2.988 ns** |  **2.495 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     |  67.80 ns |  2.923 ns |  2.591 ns |  0.65 |    0.03 |         - |          NA |
| SpanSort         | 27     | Random     | 125.58 ns |  7.430 ns |  5.801 ns |  1.20 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random     |  65.85 ns |  3.236 ns |  2.527 ns |  0.63 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random     |  70.37 ns |  7.223 ns |  6.403 ns |  0.67 |    0.06 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **74.98 ns** |  **5.240 ns** |  **4.091 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     |  67.12 ns |  3.164 ns |  2.471 ns |  0.90 |    0.06 |         - |          NA |
| SpanSort         | 27     | Sorted     |  82.97 ns |  2.716 ns |  2.268 ns |  1.11 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  70.83 ns |  2.731 ns |  2.421 ns |  0.95 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Sorted     |  66.21 ns |  3.272 ns |  2.732 ns |  0.89 |    0.06 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **78.98 ns** |  **6.167 ns** |  **5.150 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   |  78.53 ns |  2.910 ns |  2.272 ns |  1.00 |    0.07 |         - |          NA |
| SpanSort         | 27     | Reversed   |  93.50 ns | 14.073 ns | 12.476 ns |  1.19 |    0.17 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   |  66.94 ns |  3.363 ns |  2.808 ns |  0.85 |    0.07 |         - |          NA |
| GeneratedSort    | 27     | Reversed   |  67.09 ns |  3.194 ns |  2.832 ns |  0.85 |    0.07 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** |  **97.24 ns** |  **4.301 ns** |  **3.358 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates |  73.44 ns | 10.417 ns |  9.234 ns |  0.76 |    0.10 |         - |          NA |
| SpanSort         | 27     | Duplicates | 106.58 ns |  2.983 ns |  2.491 ns |  1.10 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates |  67.31 ns |  2.944 ns |  2.458 ns |  0.69 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Duplicates |  66.13 ns |  3.300 ns |  2.756 ns |  0.68 |    0.04 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **127.38 ns** |  **9.173 ns** |  **7.161 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     |  71.31 ns |  2.863 ns |  2.390 ns |  0.56 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random     | 140.17 ns | 13.670 ns | 12.118 ns |  1.10 |    0.11 |         - |          NA |
| NetworkSort_Span | 28     | Random     |  65.28 ns |  2.874 ns |  2.548 ns |  0.51 |    0.03 |         - |          NA |
| GeneratedSort    | 28     | Random     |  65.77 ns |  3.083 ns |  2.407 ns |  0.52 |    0.03 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **75.48 ns** |  **4.194 ns** |  **3.502 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     |  72.01 ns |  3.557 ns |  2.970 ns |  0.96 |    0.06 |         - |          NA |
| SpanSort         | 28     | Sorted     |  85.22 ns |  3.236 ns |  2.526 ns |  1.13 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  65.91 ns |  2.644 ns |  2.344 ns |  0.88 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Sorted     |  74.85 ns |  3.296 ns |  2.574 ns |  0.99 |    0.06 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **81.01 ns** |  **4.885 ns** |  **4.079 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   |  67.74 ns |  3.219 ns |  2.853 ns |  0.84 |    0.05 |         - |          NA |
| SpanSort         | 28     | Reversed   | 103.00 ns |  3.166 ns |  2.644 ns |  1.27 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   |  66.10 ns |  2.794 ns |  2.333 ns |  0.82 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Reversed   |  65.55 ns |  3.071 ns |  2.398 ns |  0.81 |    0.05 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** | **139.77 ns** | **47.037 ns** | **41.697 ns** |  **1.08** |    **0.44** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates |  67.63 ns |  3.388 ns |  2.829 ns |  0.52 |    0.15 |         - |          NA |
| SpanSort         | 28     | Duplicates | 121.55 ns |  2.376 ns |  1.984 ns |  0.94 |    0.26 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates |  66.27 ns |  2.494 ns |  2.211 ns |  0.51 |    0.14 |         - |          NA |
| GeneratedSort    | 28     | Duplicates |  65.54 ns |  3.097 ns |  2.418 ns |  0.51 |    0.14 |         - |          NA |

## Long

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,929.7 ns** | **58.07 ns** | **51.48 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   136.9 ns |  3.61 ns |  2.82 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,868.7 ns | 76.61 ns | 67.91 ns |  0.64 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   150.9 ns | 23.57 ns | 20.89 ns |  0.05 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |   134.8 ns |  3.70 ns |  2.88 ns |  0.05 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,053.8 ns** | **88.74 ns** | **78.67 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   148.2 ns | 13.78 ns | 12.21 ns |  0.07 |    0.01 |         - |          NA |
| SpanSort         | 28     | Random | 2,057.4 ns | 95.28 ns | 84.47 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   138.6 ns |  3.95 ns |  3.30 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   138.7 ns |  4.18 ns |  3.26 ns |  0.07 |    0.00 |         - |          NA |

## NInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,835.1 ns** | **66.44 ns** | **58.89 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   142.3 ns |  8.23 ns |  7.29 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,850.6 ns | 35.97 ns | 31.89 ns |  1.01 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   140.2 ns | 11.11 ns |  9.85 ns |  0.08 |    0.01 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,063.9 ns** | **95.32 ns** | **84.50 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   142.9 ns |  4.34 ns |  3.39 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,100.4 ns | 60.52 ns | 53.65 ns |  1.02 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   145.9 ns | 11.67 ns | 10.35 ns |  0.07 |    0.01 |         - |          NA |

## NUInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,881.9 ns** |  **69.97 ns** | **62.02 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   138.1 ns |   4.82 ns |  4.02 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,814.5 ns |  86.17 ns | 76.39 ns |  0.97 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   136.6 ns |   4.90 ns |  3.82 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,268.1 ns** |  **82.09 ns** | **72.77 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   144.1 ns |   4.62 ns |  3.86 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,018.0 ns | 108.33 ns | 96.03 ns |  0.89 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.8 ns |   6.14 ns |  5.12 ns |  0.06 |    0.00 |         - |          NA |

## SByte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,897.27 ns** | **45.550 ns** | **40.379 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    45.02 ns |  3.052 ns |  2.706 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,898.85 ns | 44.563 ns | 39.504 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |    45.28 ns |  2.894 ns |  2.565 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    33.92 ns |  2.476 ns |  2.195 ns |  0.02 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,309.58 ns** | **96.118 ns** | **85.206 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    36.30 ns |  3.859 ns |  3.013 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,088.07 ns | 98.400 ns | 87.229 ns |  0.91 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    42.99 ns | 10.805 ns |  9.578 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    34.45 ns |  3.106 ns |  2.425 ns |  0.01 |    0.00 |         - |          NA |

## Short

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **389.10 ns** |  **13.116 ns** | **11.627 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   373.94 ns |  32.189 ns | 26.879 ns |  0.96 |    0.07 |         - |          NA |
| SpanSort         | 8      | Random |   392.53 ns |  10.041 ns |  8.901 ns |  1.01 |    0.04 |         - |          NA |
| NetworkSort_Span | 8      | Random |   391.76 ns |  52.956 ns | 44.221 ns |  1.01 |    0.11 |         - |          NA |
| GeneratedSort    | 8      | Random |    24.46 ns |   2.257 ns |  2.001 ns |  0.06 |    0.01 |         - |          NA |
|                  |        |        |             |            |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** | **1,287.69 ns** |  **34.141 ns** | **28.510 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 16     | Random | 1,226.45 ns |  45.711 ns | 40.522 ns |  0.95 |    0.04 |         - |          NA |
| SpanSort         | 16     | Random | 1,305.10 ns |  28.451 ns | 25.221 ns |  1.01 |    0.03 |         - |          NA |
| NetworkSort_Span | 16     | Random | 1,239.16 ns |  18.576 ns | 16.467 ns |  0.96 |    0.02 |         - |          NA |
| GeneratedSort    | 16     | Random |    29.42 ns |   2.308 ns |  1.927 ns |  0.02 |    0.00 |         - |          NA |
|                  |        |        |             |            |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **1,863.87 ns** |  **47.079 ns** | **41.735 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   138.14 ns |   3.968 ns |  3.314 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,811.78 ns |  80.624 ns | 71.471 ns |  0.97 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   136.30 ns |   3.756 ns |  3.329 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   139.32 ns |   5.378 ns |  4.199 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |            |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,209.88 ns** |  **72.700 ns** | **64.446 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   142.79 ns |   4.244 ns |  3.313 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,036.88 ns | 103.758 ns | 91.979 ns |  0.92 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   140.13 ns |   4.086 ns |  3.412 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   147.98 ns |   4.223 ns |  3.527 ns |  0.07 |    0.00 |         - |          NA |

## String

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Median   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,197.1 ns** | **439.90 ns** | **411.48 ns** | **900.2 ns** |  **1.10** |    **0.50** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random |   527.5 ns |  20.23 ns |  17.93 ns | 526.0 ns |  0.49 |    0.14 |         - |        0.00 |
| SpanSort         | 27     | Random |   908.9 ns |  29.37 ns |  26.03 ns | 910.8 ns |  0.84 |    0.24 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random |   523.1 ns |  12.53 ns |   9.78 ns | 525.8 ns |  0.48 |    0.14 |         - |        0.00 |
|                  |        |        |            |           |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** |   **952.2 ns** |   **7.55 ns** |   **6.31 ns** | **952.2 ns** |  **1.00** |    **0.01** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random |   571.3 ns |  15.74 ns |  13.95 ns | 567.5 ns |  0.60 |    0.01 |         - |        0.00 |
| SpanSort         | 28     | Random |   951.0 ns |  21.28 ns |  17.77 ns | 948.3 ns |  1.00 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random |   562.1 ns |  12.10 ns |  10.73 ns | 564.2 ns |  0.59 |    0.01 |         - |        0.00 |

## UInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **122.00 ns** |  **2.033 ns** |  **1.698 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  64.03 ns |  4.451 ns |  3.946 ns |  0.52 |    0.03 |         - |          NA |
| SpanSort         | 27     | Random | 110.56 ns |  9.617 ns |  8.526 ns |  0.91 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random |  62.68 ns |  5.055 ns |  4.221 ns |  0.51 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random |  63.04 ns |  4.395 ns |  3.431 ns |  0.52 |    0.03 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **159.73 ns** | **12.542 ns** | **11.118 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  65.08 ns |  3.755 ns |  3.329 ns |  0.41 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 126.04 ns |  1.841 ns |  1.537 ns |  0.79 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |  63.13 ns |  4.357 ns |  3.401 ns |  0.40 |    0.03 |         - |          NA |
| GeneratedSort    | 28     | Random |  66.00 ns |  6.631 ns |  5.878 ns |  0.41 |    0.04 |         - |          NA |

## ULong

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **145.3 ns** |  **2.70 ns** |  **2.10 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 135.4 ns |  4.47 ns |  3.73 ns |  0.93 |    0.03 |         - |          NA |
| SpanSort         | 27     | Random | 135.6 ns |  9.40 ns |  7.34 ns |  0.93 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random | 131.4 ns |  3.77 ns |  3.15 ns |  0.90 |    0.02 |         - |          NA |
| GeneratedSort    | 27     | Random | 132.8 ns |  4.32 ns |  3.61 ns |  0.91 |    0.03 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **164.8 ns** |  **8.77 ns** |  **7.32 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 139.1 ns |  4.16 ns |  3.25 ns |  0.85 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 163.8 ns | 13.70 ns | 12.14 ns |  1.00 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Random | 136.3 ns |  3.97 ns |  3.31 ns |  0.83 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 138.5 ns |  3.51 ns |  2.74 ns |  0.84 |    0.04 |         - |          NA |

## UShort

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 9V74 2.60GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **371.19 ns** | **21.269 ns** | **18.854 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   377.95 ns | 26.286 ns | 23.302 ns |  1.02 |    0.08 |         - |          NA |
| SpanSort         | 8      | Random |   374.98 ns | 21.017 ns | 18.631 ns |  1.01 |    0.07 |         - |          NA |
| NetworkSort_Span | 8      | Random |   379.10 ns | 20.198 ns | 17.905 ns |  1.02 |    0.07 |         - |          NA |
| GeneratedSort    | 8      | Random |    25.77 ns |  2.969 ns |  2.479 ns |  0.07 |    0.01 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** | **1,240.91 ns** | **27.723 ns** | **24.575 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 16     | Random | 1,227.27 ns | 49.730 ns | 44.084 ns |  0.99 |    0.04 |         - |          NA |
| SpanSort         | 16     | Random | 1,236.35 ns | 33.188 ns | 29.421 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 16     | Random | 1,249.03 ns | 35.353 ns | 31.339 ns |  1.01 |    0.03 |         - |          NA |
| GeneratedSort    | 16     | Random |    33.34 ns |  3.961 ns |  3.512 ns |  0.03 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **1,822.95 ns** | **74.494 ns** | **62.206 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   145.24 ns |  6.184 ns |  4.828 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,859.77 ns | 40.310 ns | 35.734 ns |  1.02 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   146.88 ns | 11.000 ns |  9.751 ns |  0.08 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |   139.80 ns |  4.284 ns |  3.797 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,042.65 ns** | **93.592 ns** | **82.967 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   143.82 ns |  5.528 ns |  4.316 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,035.86 ns | 92.628 ns | 82.112 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   147.31 ns | 12.327 ns | 10.927 ns |  0.07 |    0.01 |         - |          NA |
| GeneratedSort    | 28     | Random |   143.29 ns |  5.110 ns |  3.990 ns |  0.07 |    0.00 |         - |          NA |

