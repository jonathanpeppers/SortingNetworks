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
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,875.99 ns** | **96.525 ns** | **85.567 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    44.10 ns |  7.166 ns |  5.595 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,807.86 ns | 61.318 ns | 54.357 ns |  0.97 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |    35.63 ns |  8.893 ns |  7.883 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    31.62 ns |  3.067 ns |  2.719 ns |  0.02 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,041.11 ns** | **93.703 ns** | **83.065 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    34.19 ns |  3.565 ns |  2.977 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,032.39 ns | 94.220 ns | 83.524 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    31.10 ns |  3.680 ns |  2.873 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    32.12 ns |  3.405 ns |  2.843 ns |  0.02 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **116.6 ns** |  **4.67 ns** |  **3.90 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 136.7 ns |  6.27 ns |  4.89 ns |  1.17 |    0.06 |         - |          NA |
| SpanSort         | 27     | Random | 131.0 ns |  8.45 ns |  7.06 ns |  1.12 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random | 138.5 ns |  5.07 ns |  3.95 ns |  1.19 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random | 140.0 ns |  6.23 ns |  4.87 ns |  1.20 |    0.06 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **144.5 ns** |  **8.05 ns** |  **6.28 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 143.5 ns |  3.58 ns |  2.80 ns |  0.99 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 144.0 ns |  5.54 ns |  4.62 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random | 143.3 ns | 12.46 ns | 11.05 ns |  0.99 |    0.08 |         - |          NA |
| GeneratedSort    | 28     | Random | 140.2 ns |  8.60 ns |  7.18 ns |  0.97 |    0.06 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,256.2 ns** | **92.54 ns** | **77.28 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   132.0 ns | 13.26 ns | 11.76 ns |  0.06 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 2,297.2 ns | 87.91 ns | 77.93 ns |  1.02 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   123.2 ns |  4.13 ns |  3.22 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   156.2 ns | 11.63 ns |  9.71 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,490.7 ns** | **85.76 ns** | **76.02 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   131.9 ns | 11.14 ns |  9.87 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,509.3 ns | 88.67 ns | 78.61 ns |  1.01 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |   115.3 ns |  9.24 ns |  8.19 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   157.3 ns |  5.16 ns |  4.31 ns |  0.06 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,302.01 ns** | **48.273 ns** | **42.793 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    95.57 ns |  3.907 ns |  3.463 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,259.73 ns | 69.341 ns | 61.469 ns |  0.98 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |    98.56 ns | 12.189 ns | 10.805 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    74.11 ns |  3.857 ns |  3.220 ns |  0.03 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,512.88 ns** | **99.932 ns** | **88.587 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    87.35 ns |  2.127 ns |  1.776 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,473.02 ns | 94.180 ns | 83.488 ns |  0.99 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    85.55 ns |  1.333 ns |  1.113 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    67.79 ns |  2.804 ns |  2.342 ns |  0.03 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random**     | **104.41 ns** |  **3.092 ns** |  **2.414 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     |  71.21 ns |  4.234 ns |  3.753 ns |  0.68 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random     | 126.87 ns |  4.267 ns |  3.332 ns |  1.22 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random     |  66.56 ns |  3.048 ns |  2.545 ns |  0.64 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random     |  66.01 ns |  2.638 ns |  2.203 ns |  0.63 |    0.02 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **74.56 ns** |  **4.433 ns** |  **3.701 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     |  73.03 ns |  4.586 ns |  4.066 ns |  0.98 |    0.07 |         - |          NA |
| SpanSort         | 27     | Sorted     |  95.25 ns |  6.639 ns |  5.544 ns |  1.28 |    0.10 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  66.85 ns |  3.109 ns |  2.596 ns |  0.90 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Sorted     |  66.15 ns |  2.564 ns |  2.141 ns |  0.89 |    0.05 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **79.89 ns** |  **5.499 ns** |  **4.592 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   |  67.40 ns |  3.167 ns |  2.644 ns |  0.85 |    0.06 |         - |          NA |
| SpanSort         | 27     | Reversed   |  86.63 ns |  4.389 ns |  3.426 ns |  1.09 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   |  70.08 ns |  4.014 ns |  3.558 ns |  0.88 |    0.07 |         - |          NA |
| GeneratedSort    | 27     | Reversed   |  75.09 ns |  4.244 ns |  3.544 ns |  0.94 |    0.07 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** |  **97.10 ns** |  **3.679 ns** |  **3.262 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates |  76.08 ns |  8.216 ns |  6.860 ns |  0.78 |    0.07 |         - |          NA |
| SpanSort         | 27     | Duplicates | 106.17 ns |  2.279 ns |  2.020 ns |  1.09 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates |  67.80 ns |  3.762 ns |  3.335 ns |  0.70 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Duplicates |  66.44 ns |  2.734 ns |  2.423 ns |  0.69 |    0.03 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **125.22 ns** |  **3.594 ns** |  **2.806 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     |  72.63 ns |  3.638 ns |  3.225 ns |  0.58 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random     | 133.21 ns |  1.601 ns |  1.250 ns |  1.06 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random     |  66.11 ns |  3.216 ns |  2.685 ns |  0.53 |    0.02 |         - |          NA |
| GeneratedSort    | 28     | Random     |  69.34 ns |  4.868 ns |  4.065 ns |  0.55 |    0.03 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **77.00 ns** |  **3.801 ns** |  **2.968 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     |  72.34 ns |  4.577 ns |  4.058 ns |  0.94 |    0.06 |         - |          NA |
| SpanSort         | 28     | Sorted     |  83.78 ns |  2.907 ns |  2.427 ns |  1.09 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  68.79 ns |  7.061 ns |  6.260 ns |  0.89 |    0.09 |         - |          NA |
| GeneratedSort    | 28     | Sorted     |  69.95 ns |  9.603 ns |  8.513 ns |  0.91 |    0.11 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **82.69 ns** |  **3.276 ns** |  **2.558 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   |  66.30 ns |  3.178 ns |  2.654 ns |  0.80 |    0.04 |         - |          NA |
| SpanSort         | 28     | Reversed   |  89.40 ns |  3.460 ns |  2.701 ns |  1.08 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   |  72.73 ns | 10.300 ns |  9.130 ns |  0.88 |    0.11 |         - |          NA |
| GeneratedSort    | 28     | Reversed   |  70.20 ns |  7.481 ns |  6.632 ns |  0.85 |    0.08 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** | **156.91 ns** | **45.066 ns** | **39.950 ns** |  **1.08** |    **0.43** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates |  67.50 ns |  3.777 ns |  2.949 ns |  0.46 |    0.14 |         - |          NA |
| SpanSort         | 28     | Duplicates | 111.27 ns |  4.939 ns |  4.379 ns |  0.77 |    0.24 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates |  66.06 ns |  3.168 ns |  2.646 ns |  0.45 |    0.14 |         - |          NA |
| GeneratedSort    | 28     | Duplicates |  66.04 ns |  2.925 ns |  2.593 ns |  0.45 |    0.14 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,870.0 ns** |  **43.98 ns** |  **38.99 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   139.9 ns |   9.80 ns |   8.69 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,867.8 ns |  37.26 ns |  33.03 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |   136.6 ns |   9.38 ns |   7.83 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   140.3 ns |  12.52 ns |  11.10 ns |  0.08 |    0.01 |         - |          NA |
|                  |        |        |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,052.5 ns** |  **97.13 ns** |  **86.11 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   139.8 ns |   3.91 ns |   3.05 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,619.8 ns | 209.75 ns | 185.94 ns |  1.28 |    0.10 |         - |          NA |
| NetworkSort_Span | 28     | Random |   138.0 ns |   4.01 ns |   3.13 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   138.5 ns |   4.40 ns |   3.43 ns |  0.07 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,867.1 ns** | **38.84 ns** | **34.43 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   152.4 ns | 31.14 ns | 26.00 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,833.2 ns | 80.87 ns | 67.53 ns |  0.98 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   135.5 ns |  4.11 ns |  3.43 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,056.3 ns** | **96.28 ns** | **85.35 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   141.6 ns |  4.62 ns |  3.61 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,039.1 ns | 98.26 ns | 87.11 ns |  0.99 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.2 ns |  8.09 ns |  6.76 ns |  0.07 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,926.6 ns** | **48.04 ns** | **42.59 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   141.5 ns |  7.09 ns |  5.54 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,771.8 ns | 72.71 ns | 64.45 ns |  0.92 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   142.0 ns |  6.50 ns |  5.08 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,098.2 ns** | **86.67 ns** | **76.83 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   146.3 ns |  6.21 ns |  4.85 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,037.4 ns | 82.49 ns | 73.13 ns |  0.97 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   148.8 ns |  1.40 ns |  1.09 ns |  0.07 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,900.48 ns** | **41.407 ns** | **36.706 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    36.16 ns |  3.148 ns |  2.790 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,875.41 ns | 53.591 ns | 47.507 ns |  0.99 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |    40.80 ns |  9.652 ns |  8.060 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    33.93 ns |  2.664 ns |  2.225 ns |  0.02 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,066.55 ns** | **89.492 ns** | **79.332 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    41.98 ns |  9.198 ns |  8.154 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,053.02 ns | 90.311 ns | 80.058 ns |  0.99 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    40.72 ns |  7.622 ns |  6.365 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    34.44 ns |  2.603 ns |  2.308 ns |  0.02 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,830.6 ns** | **73.52 ns** | **65.17 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   144.4 ns |  5.54 ns |  4.91 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,835.4 ns | 67.83 ns | 60.13 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   142.2 ns | 13.84 ns | 12.27 ns |  0.08 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |   138.2 ns |  3.53 ns |  2.76 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,063.1 ns** | **99.64 ns** | **88.32 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   144.6 ns |  5.83 ns |  4.56 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,048.0 ns | 92.15 ns | 81.69 ns |  0.99 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   140.4 ns |  3.80 ns |  3.37 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   141.0 ns |  4.78 ns |  3.73 ns |  0.07 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **888.9 ns** | **15.44 ns** | **12.90 ns** |  **1.00** |    **0.02** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random | 553.4 ns | 21.10 ns | 18.70 ns |  0.62 |    0.02 |         - |        0.00 |
| SpanSort         | 27     | Random | 901.5 ns | 22.56 ns | 19.99 ns |  1.01 |    0.03 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random | 515.1 ns | 17.22 ns | 15.26 ns |  0.58 |    0.02 |         - |        0.00 |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **953.2 ns** | **14.85 ns** | **12.40 ns** |  **1.00** |    **0.02** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random | 572.8 ns | 15.76 ns | 13.97 ns |  0.60 |    0.02 |         - |        0.00 |
| SpanSort         | 28     | Random | 956.1 ns | 10.45 ns |  8.72 ns |  1.00 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random | 565.4 ns | 11.11 ns |  9.28 ns |  0.59 |    0.01 |         - |        0.00 |

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
| **ArraySort**        | **27**     | **Random** | **128.70 ns** |  **9.119 ns** |  **8.084 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  64.15 ns |  5.367 ns |  4.190 ns |  0.50 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 112.64 ns | 15.336 ns | 13.595 ns |  0.88 |    0.11 |         - |          NA |
| NetworkSort_Span | 27     | Random |  67.32 ns |  5.905 ns |  4.931 ns |  0.52 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random |  62.44 ns |  4.552 ns |  3.801 ns |  0.49 |    0.04 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **143.61 ns** |  **2.946 ns** |  **2.300 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  67.37 ns |  3.834 ns |  3.399 ns |  0.47 |    0.02 |         - |          NA |
| SpanSort         | 28     | Random | 125.58 ns |  2.618 ns |  2.044 ns |  0.87 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |  67.25 ns |  3.770 ns |  3.342 ns |  0.47 |    0.02 |         - |          NA |
| GeneratedSort    | 28     | Random |  62.63 ns |  4.689 ns |  4.157 ns |  0.44 |    0.03 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **152.2 ns** | **14.72 ns** | **13.05 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 133.7 ns |  2.04 ns |  1.59 ns |  0.88 |    0.07 |         - |          NA |
| SpanSort         | 27     | Random | 133.6 ns |  6.82 ns |  5.69 ns |  0.88 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Random | 131.7 ns |  4.59 ns |  3.58 ns |  0.87 |    0.07 |         - |          NA |
| GeneratedSort    | 27     | Random | 135.1 ns |  7.78 ns |  6.07 ns |  0.89 |    0.08 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **160.7 ns** |  **2.77 ns** |  **2.16 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 138.1 ns |  4.20 ns |  3.28 ns |  0.86 |    0.02 |         - |          NA |
| SpanSort         | 28     | Random | 143.4 ns |  3.83 ns |  3.20 ns |  0.89 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random | 136.0 ns |  4.13 ns |  3.23 ns |  0.85 |    0.02 |         - |          NA |
| GeneratedSort    | 28     | Random | 146.1 ns | 12.05 ns | 10.68 ns |  0.91 |    0.07 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,855.2 ns** |  **67.49 ns** | **56.35 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   138.7 ns |   3.82 ns |  2.98 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,807.0 ns |  75.31 ns | 66.76 ns |  0.97 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   136.0 ns |   4.15 ns |  3.47 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   143.6 ns |   3.48 ns |  2.90 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,064.1 ns** |  **95.34 ns** | **84.52 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   150.1 ns |   4.21 ns |  3.29 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,044.6 ns | 100.50 ns | 89.09 ns |  0.99 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |   140.2 ns |   4.63 ns |  3.87 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   140.4 ns |   4.06 ns |  3.17 ns |  0.07 |    0.00 |         - |          NA |

