## Byte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,948.00 ns** | **30.842 ns** | **27.340 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    52.20 ns |  2.874 ns |  2.400 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,938.04 ns | 32.828 ns | 29.101 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    49.59 ns |  2.084 ns |  1.740 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   129.98 ns |  4.037 ns |  3.371 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,228.40 ns** | **44.880 ns** | **39.785 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    51.69 ns |  3.286 ns |  2.744 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,164.32 ns | 47.081 ns | 41.736 ns |  0.97 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    50.21 ns |  2.940 ns |  2.455 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   129.29 ns |  5.614 ns |  4.383 ns |  0.06 |    0.00 |         - |          NA |

## Char

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |  **38.79 ns** |  **3.318 ns** | **2.941 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |  48.50 ns |  3.007 ns | 2.665 ns |  1.26 |    0.12 |         - |          NA |
| SpanSort         | 8      | Random |  43.48 ns |  2.788 ns | 2.472 ns |  1.13 |    0.11 |         - |          NA |
| NetworkSort_Span | 8      | Random |  45.50 ns |  3.523 ns | 2.942 ns |  1.18 |    0.12 |         - |          NA |
| GeneratedSort    | 8      | Random |  39.18 ns |  3.055 ns | 2.385 ns |  1.02 |    0.10 |         - |          NA |
|                  |        |        |           |           |          |       |         |           |             |
| **ArraySort**        | **16**     | **Random** |  **80.95 ns** |  **3.346 ns** | **2.794 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 16     | Random |  86.10 ns |  3.394 ns | 2.834 ns |  1.06 |    0.05 |         - |          NA |
| SpanSort         | 16     | Random |  80.59 ns |  4.774 ns | 3.986 ns |  1.00 |    0.06 |         - |          NA |
| NetworkSort_Span | 16     | Random |  81.79 ns |  3.777 ns | 2.949 ns |  1.01 |    0.05 |         - |          NA |
| GeneratedSort    | 16     | Random |  73.44 ns |  4.447 ns | 3.942 ns |  0.91 |    0.06 |         - |          NA |
|                  |        |        |           |           |          |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **112.96 ns** | **10.182 ns** | **9.026 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  71.34 ns |  2.961 ns | 2.312 ns |  0.64 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random | 113.47 ns |  4.207 ns | 3.284 ns |  1.01 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Random |  67.77 ns |  3.054 ns | 2.550 ns |  0.60 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random | 129.69 ns |  3.843 ns | 3.000 ns |  1.15 |    0.09 |         - |          NA |
|                  |        |        |           |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **128.74 ns** | **10.203 ns** | **9.044 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  71.26 ns |  3.084 ns | 2.576 ns |  0.56 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 131.57 ns |  7.432 ns | 6.589 ns |  1.03 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Random |  67.74 ns |  2.836 ns | 2.368 ns |  0.53 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 130.84 ns |  4.046 ns | 3.159 ns |  1.02 |    0.07 |         - |          NA |

## Double

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,463.5 ns** | **40.94 ns** | **36.29 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   152.3 ns |  4.32 ns |  3.60 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,470.4 ns | 39.74 ns | 35.23 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   148.9 ns |  4.26 ns |  3.32 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   150.3 ns |  2.89 ns |  2.42 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,737.3 ns** | **46.43 ns** | **41.16 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   158.8 ns |  4.71 ns |  3.94 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,740.3 ns | 47.98 ns | 42.54 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   155.1 ns |  4.07 ns |  3.18 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   157.7 ns | 10.24 ns |  9.08 ns |  0.06 |    0.00 |         - |          NA |

## Float

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,468.6 ns** | **37.62 ns** | **33.35 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   148.6 ns |  2.98 ns |  2.49 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,437.2 ns | 41.92 ns | 37.16 ns |  0.99 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   146.4 ns |  3.12 ns |  2.43 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   143.9 ns |  3.97 ns |  3.10 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,790.4 ns** | **44.30 ns** | **39.27 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   148.7 ns |  4.97 ns |  4.15 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,721.6 ns | 49.79 ns | 44.14 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   142.2 ns |  2.09 ns |  1.75 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   150.1 ns |  4.32 ns |  3.61 ns |  0.05 |    0.00 |         - |          NA |

## Int

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind       | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |----------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random**     | **102.01 ns** |  **8.385 ns** |  **7.433 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     | 151.60 ns | 12.435 ns | 11.023 ns |  1.49 |    0.15 |         - |          NA |
| SpanSort         | 27     | Random     | 100.78 ns |  3.750 ns |  3.324 ns |  0.99 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random     | 142.98 ns |  3.315 ns |  2.588 ns |  1.41 |    0.10 |         - |          NA |
| GeneratedSort    | 27     | Random     | 124.58 ns |  3.413 ns |  3.026 ns |  1.23 |    0.09 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **62.11 ns** |  **4.261 ns** |  **3.778 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     |  36.45 ns |  3.363 ns |  2.626 ns |  0.59 |    0.05 |         - |          NA |
| SpanSort         | 27     | Sorted     |  65.02 ns |  4.296 ns |  3.808 ns |  1.05 |    0.09 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  34.22 ns |  4.006 ns |  3.551 ns |  0.55 |    0.07 |         - |          NA |
| GeneratedSort    | 27     | Sorted     | 128.85 ns |  5.136 ns |  4.289 ns |  2.08 |    0.14 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **78.19 ns** |  **4.354 ns** |  **3.399 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   | 145.22 ns |  3.326 ns |  2.597 ns |  1.86 |    0.09 |         - |          NA |
| SpanSort         | 27     | Reversed   |  83.03 ns |  3.134 ns |  2.447 ns |  1.06 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   | 142.32 ns |  2.611 ns |  2.314 ns |  1.82 |    0.08 |         - |          NA |
| GeneratedSort    | 27     | Reversed   | 133.01 ns |  4.319 ns |  3.372 ns |  1.70 |    0.08 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** |  **99.21 ns** | **10.324 ns** |  **9.152 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates | 144.88 ns |  2.664 ns |  2.080 ns |  1.47 |    0.12 |         - |          NA |
| SpanSort         | 27     | Duplicates |  99.95 ns |  2.969 ns |  2.632 ns |  1.01 |    0.09 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates | 142.27 ns |  2.975 ns |  2.323 ns |  1.44 |    0.12 |         - |          NA |
| GeneratedSort    | 27     | Duplicates | 123.38 ns |  4.096 ns |  3.198 ns |  1.25 |    0.11 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **110.32 ns** |  **4.751 ns** |  **3.709 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     | 144.21 ns |  8.882 ns |  7.873 ns |  1.31 |    0.08 |         - |          NA |
| SpanSort         | 28     | Random     | 115.68 ns |  4.113 ns |  3.646 ns |  1.05 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random     | 138.29 ns |  3.419 ns |  2.670 ns |  1.25 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Random     | 126.27 ns |  4.288 ns |  3.581 ns |  1.15 |    0.05 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **61.37 ns** |  **4.166 ns** |  **3.252 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     |  36.01 ns |  3.231 ns |  2.698 ns |  0.59 |    0.05 |         - |          NA |
| SpanSort         | 28     | Sorted     |  66.19 ns |  3.162 ns |  2.641 ns |  1.08 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  34.05 ns |  4.124 ns |  3.656 ns |  0.56 |    0.07 |         - |          NA |
| GeneratedSort    | 28     | Sorted     | 134.15 ns |  9.615 ns |  8.523 ns |  2.19 |    0.18 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **79.99 ns** |  **3.329 ns** |  **2.780 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   | 140.80 ns |  3.479 ns |  2.716 ns |  1.76 |    0.07 |         - |          NA |
| SpanSort         | 28     | Reversed   |  84.21 ns |  3.785 ns |  3.161 ns |  1.05 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   | 138.96 ns |  2.699 ns |  2.393 ns |  1.74 |    0.07 |         - |          NA |
| GeneratedSort    | 28     | Reversed   | 138.48 ns |  4.746 ns |  4.207 ns |  1.73 |    0.08 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** |  **97.51 ns** |  **3.876 ns** |  **3.237 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates | 145.15 ns |  9.646 ns |  8.551 ns |  1.49 |    0.10 |         - |          NA |
| SpanSort         | 28     | Duplicates | 100.40 ns |  3.968 ns |  3.098 ns |  1.03 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates | 139.43 ns |  3.721 ns |  3.107 ns |  1.43 |    0.06 |         - |          NA |
| GeneratedSort    | 28     | Duplicates | 132.06 ns | 10.227 ns |  9.066 ns |  1.36 |    0.10 |         - |          NA |

## Long

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,015.8 ns** | **39.45 ns** | **34.97 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   136.2 ns |  4.37 ns |  3.41 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,080.5 ns | 39.80 ns | 35.29 ns |  1.03 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   133.7 ns |  4.39 ns |  3.67 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   132.8 ns |  5.11 ns |  3.99 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,363.6 ns** | **39.08 ns** | **34.64 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   142.9 ns |  4.57 ns |  3.82 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,286.0 ns | 46.45 ns | 41.17 ns |  0.97 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   138.4 ns |  3.41 ns |  3.02 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   138.8 ns |  3.90 ns |  3.26 ns |  0.06 |    0.00 |         - |          NA |

## NInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,048.3 ns** | **38.12 ns** | **33.79 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   139.9 ns |  5.16 ns |  4.03 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,035.6 ns | 43.81 ns | 38.84 ns |  0.99 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   138.6 ns |  8.13 ns |  6.79 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,312.6 ns** | **49.31 ns** | **43.71 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   148.0 ns |  4.02 ns |  3.56 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,352.2 ns | 37.26 ns | 33.03 ns |  1.02 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   144.3 ns |  4.67 ns |  3.65 ns |  0.06 |    0.00 |         - |          NA |

## NUInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,023.8 ns** | **37.39 ns** | **33.14 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   141.8 ns |  3.88 ns |  3.24 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,051.3 ns | 34.30 ns | 30.41 ns |  1.01 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   136.0 ns |  5.72 ns |  4.46 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,289.6 ns** | **40.70 ns** | **36.08 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   146.1 ns |  4.63 ns |  3.62 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,305.0 ns | 41.71 ns | 36.98 ns |  1.01 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.3 ns |  5.38 ns |  4.20 ns |  0.06 |    0.00 |         - |          NA |

## SByte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,990.95 ns** | **34.664 ns** | **30.729 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    55.97 ns |  2.719 ns |  2.410 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,012.42 ns | 35.582 ns | 31.543 ns |  1.01 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    53.42 ns |  2.823 ns |  2.358 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   134.60 ns |  3.133 ns |  2.446 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,250.54 ns** | **44.622 ns** | **39.556 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    55.02 ns |  3.013 ns |  2.516 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,249.47 ns | 41.045 ns | 36.386 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    52.32 ns |  2.358 ns |  1.969 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   135.83 ns |  4.479 ns |  3.497 ns |  0.06 |    0.00 |         - |          NA |

## Short

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **424.83 ns** | **16.650 ns** | **14.760 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   432.94 ns |  7.506 ns |  6.654 ns |  1.02 |    0.04 |         - |          NA |
| SpanSort         | 8      | Random |   422.76 ns |  6.126 ns |  5.431 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 8      | Random |   434.59 ns | 16.702 ns | 14.806 ns |  1.02 |    0.05 |         - |          NA |
| GeneratedSort    | 8      | Random |    44.25 ns |  3.224 ns |  2.858 ns |  0.10 |    0.01 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** | **1,341.48 ns** |  **9.367 ns** |  **8.304 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| NetworkSort      | 16     | Random | 1,360.24 ns | 12.061 ns | 10.692 ns |  1.01 |    0.01 |         - |          NA |
| SpanSort         | 16     | Random | 1,344.56 ns |  9.269 ns |  8.216 ns |  1.00 |    0.01 |         - |          NA |
| NetworkSort_Span | 16     | Random | 1,339.05 ns |  9.208 ns |  8.162 ns |  1.00 |    0.01 |         - |          NA |
| GeneratedSort    | 16     | Random |    77.13 ns |  5.814 ns |  4.855 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **2,070.07 ns** | **34.089 ns** | **30.219 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    74.47 ns |  3.026 ns |  2.362 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,020.64 ns | 35.012 ns | 31.037 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    72.07 ns |  2.974 ns |  2.322 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   136.97 ns |  3.570 ns |  2.787 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,351.06 ns** | **39.765 ns** | **35.251 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    73.38 ns |  2.877 ns |  2.551 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,277.70 ns | 44.549 ns | 39.492 ns |  0.97 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    71.66 ns |  2.837 ns |  2.369 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   136.08 ns |  3.483 ns |  3.088 ns |  0.06 |    0.00 |         - |          NA |

## String

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **829.5 ns** | **11.43 ns** |  **9.54 ns** |  **1.00** |    **0.02** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random | 571.1 ns | 12.16 ns | 10.78 ns |  0.69 |    0.01 |         - |        0.00 |
| SpanSort         | 27     | Random | 839.3 ns |  9.70 ns |  8.10 ns |  1.01 |    0.01 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random | 571.1 ns | 13.04 ns | 11.56 ns |  0.69 |    0.02 |         - |        0.00 |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **876.1 ns** | **19.30 ns** | **17.11 ns** |  **1.00** |    **0.03** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random | 592.2 ns | 14.44 ns | 12.80 ns |  0.68 |    0.02 |         - |        0.00 |
| SpanSort         | 28     | Random | 879.7 ns | 14.76 ns | 12.32 ns |  1.00 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random | 587.6 ns | 12.92 ns | 11.45 ns |  0.67 |    0.02 |         - |        0.00 |

## UInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **103.0 ns** | **3.58 ns** | **2.99 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 145.6 ns | 3.74 ns | 2.92 ns |  1.41 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random | 103.9 ns | 4.90 ns | 4.09 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random | 142.9 ns | 2.67 ns | 2.08 ns |  1.39 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 125.8 ns | 4.69 ns | 3.91 ns |  1.22 |    0.05 |         - |          NA |
|                  |        |        |          |         |         |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **121.0 ns** | **4.29 ns** | **3.35 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 141.6 ns | 3.18 ns | 2.66 ns |  1.17 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 116.8 ns | 2.59 ns | 2.02 ns |  0.97 |    0.03 |         - |          NA |
| NetworkSort_Span | 28     | Random | 138.4 ns | 2.58 ns | 2.28 ns |  1.14 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 126.9 ns | 4.11 ns | 3.43 ns |  1.05 |    0.04 |         - |          NA |

## ULong

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **111.7 ns** | **3.79 ns** | **3.17 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 138.4 ns | 3.71 ns | 3.10 ns |  1.24 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 115.4 ns | 4.98 ns | 4.16 ns |  1.03 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random | 132.9 ns | 4.34 ns | 3.38 ns |  1.19 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 134.1 ns | 3.53 ns | 3.13 ns |  1.20 |    0.04 |         - |          NA |
|                  |        |        |          |         |         |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **130.8 ns** | **4.60 ns** | **3.59 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 142.2 ns | 4.60 ns | 3.84 ns |  1.09 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 136.3 ns | 9.44 ns | 8.37 ns |  1.04 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Random | 138.3 ns | 3.73 ns | 3.30 ns |  1.06 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 140.5 ns | 4.07 ns | 3.18 ns |  1.07 |    0.04 |         - |          NA |

## UShort

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.3 LTS (Noble Numbat)
Neoverse-N2, 4 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **411.60 ns** | **18.142 ns** | **16.082 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   426.70 ns | 15.944 ns | 14.134 ns |  1.04 |    0.05 |         - |          NA |
| SpanSort         | 8      | Random |   414.98 ns | 19.265 ns | 17.078 ns |  1.01 |    0.06 |         - |          NA |
| NetworkSort_Span | 8      | Random |   417.06 ns | 13.177 ns | 11.681 ns |  1.01 |    0.05 |         - |          NA |
| GeneratedSort    | 8      | Random |    50.83 ns |  4.793 ns |  4.002 ns |  0.12 |    0.01 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** | **1,308.77 ns** | **12.860 ns** | **11.400 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| NetworkSort      | 16     | Random | 1,315.73 ns | 11.318 ns | 10.033 ns |  1.01 |    0.01 |         - |          NA |
| SpanSort         | 16     | Random | 1,296.19 ns | 15.828 ns | 14.031 ns |  0.99 |    0.01 |         - |          NA |
| NetworkSort_Span | 16     | Random | 1,302.05 ns | 13.470 ns | 11.941 ns |  0.99 |    0.01 |         - |          NA |
| GeneratedSort    | 16     | Random |    78.17 ns |  5.053 ns |  4.220 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **2,021.12 ns** | **39.549 ns** | **35.059 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    74.36 ns |  3.344 ns |  2.611 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,985.38 ns | 33.807 ns | 29.969 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    72.02 ns |  2.440 ns |  1.905 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   135.22 ns |  4.347 ns |  3.630 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,302.48 ns** | **42.027 ns** | **37.256 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    75.16 ns |  3.212 ns |  2.508 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,293.10 ns | 32.882 ns | 27.458 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    72.07 ns |  2.860 ns |  2.389 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   139.44 ns |  5.445 ns |  4.547 ns |  0.06 |    0.00 |         - |          NA |

