## Byte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,152.12 ns** | **68.658 ns** | **60.863 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    33.55 ns |  4.662 ns |  4.133 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,186.42 ns | 43.366 ns | 38.443 ns |  1.03 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random |    30.71 ns |  4.183 ns |  3.266 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    98.24 ns |  5.555 ns |  4.639 ns |  0.09 |    0.01 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,352.08 ns** | **64.800 ns** | **54.111 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    32.44 ns |  4.488 ns |  3.978 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,291.13 ns | 42.570 ns | 37.738 ns |  0.96 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |    32.50 ns |  4.895 ns |  4.340 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   103.34 ns |  4.694 ns |  4.161 ns |  0.08 |    0.00 |         - |          NA |

## Char

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** |  **96.04 ns** |  **4.672 ns** |  **4.142 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  50.69 ns |  4.835 ns |  4.287 ns |  0.53 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random | 101.37 ns |  5.853 ns |  5.189 ns |  1.06 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random |  49.43 ns |  4.130 ns |  3.449 ns |  0.52 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 102.34 ns |  8.498 ns |  7.534 ns |  1.07 |    0.09 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **128.41 ns** | **14.402 ns** | **11.244 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  53.37 ns |  5.924 ns |  5.252 ns |  0.42 |    0.05 |         - |          NA |
| SpanSort         | 28     | Random | 121.70 ns |  5.632 ns |  4.703 ns |  0.95 |    0.09 |         - |          NA |
| NetworkSort_Span | 28     | Random |  49.20 ns |  4.066 ns |  3.605 ns |  0.39 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 101.63 ns |  5.524 ns |  4.897 ns |  0.80 |    0.08 |         - |          NA |

## Double

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,479.4 ns** | **42.91 ns** | **35.84 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   110.2 ns |  4.10 ns |  3.64 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,482.8 ns | 55.62 ns | 49.31 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   108.3 ns |  4.19 ns |  3.72 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   102.6 ns |  4.09 ns |  3.63 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,615.3 ns** | **72.07 ns** | **63.88 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   111.4 ns |  5.31 ns |  4.71 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,590.8 ns | 89.99 ns | 79.77 ns |  0.99 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |   110.4 ns |  4.73 ns |  3.95 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   111.6 ns |  6.57 ns |  5.83 ns |  0.07 |    0.00 |         - |          NA |

## Float

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,516.65 ns** |  **53.026 ns** |  **47.006 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    78.42 ns |   4.392 ns |   3.893 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,397.45 ns |  89.046 ns |  78.937 ns |  0.92 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random |    73.63 ns |   4.520 ns |   4.007 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   101.61 ns |   4.306 ns |   3.818 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,584.39 ns** |  **23.998 ns** |  **21.273 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    75.36 ns |   4.558 ns |   4.041 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,614.24 ns | 135.629 ns | 120.231 ns |  1.02 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Random |    76.06 ns |   5.891 ns |   5.222 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   109.01 ns |   6.739 ns |   5.974 ns |  0.07 |    0.00 |         - |          NA |

## Int

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind       | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |----------- |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random**     | **102.15 ns** | **5.920 ns** | **4.943 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     |  80.34 ns | 5.764 ns | 4.500 ns |  0.79 |    0.06 |         - |          NA |
| SpanSort         | 27     | Random     | 105.77 ns | 3.417 ns | 2.853 ns |  1.04 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random     |  73.72 ns | 4.205 ns | 3.283 ns |  0.72 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random     |  99.66 ns | 4.088 ns | 3.624 ns |  0.98 |    0.06 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **56.55 ns** | **5.813 ns** | **5.153 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     |  30.08 ns | 4.758 ns | 4.218 ns |  0.54 |    0.09 |         - |          NA |
| SpanSort         | 27     | Sorted     |  65.03 ns | 6.352 ns | 5.304 ns |  1.16 |    0.14 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  32.56 ns | 5.043 ns | 4.470 ns |  0.58 |    0.09 |         - |          NA |
| GeneratedSort    | 27     | Sorted     |  84.93 ns | 6.240 ns | 5.210 ns |  1.51 |    0.17 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **62.68 ns** | **5.738 ns** | **4.791 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   |  82.48 ns | 6.641 ns | 5.887 ns |  1.32 |    0.14 |         - |          NA |
| SpanSort         | 27     | Reversed   |  73.05 ns | 6.239 ns | 5.210 ns |  1.17 |    0.12 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   |  77.39 ns | 6.119 ns | 5.424 ns |  1.24 |    0.13 |         - |          NA |
| GeneratedSort    | 27     | Reversed   | 103.51 ns | 4.739 ns | 4.201 ns |  1.66 |    0.15 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** | **104.76 ns** | **6.682 ns** | **5.923 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates |  82.32 ns | 6.466 ns | 5.732 ns |  0.79 |    0.07 |         - |          NA |
| SpanSort         | 27     | Duplicates | 110.66 ns | 5.640 ns | 4.403 ns |  1.06 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates |  76.18 ns | 5.302 ns | 4.700 ns |  0.73 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Duplicates |  81.48 ns | 4.409 ns | 3.909 ns |  0.78 |    0.06 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **116.64 ns** | **4.354 ns** | **3.860 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     |  79.97 ns | 7.330 ns | 6.121 ns |  0.69 |    0.06 |         - |          NA |
| SpanSort         | 28     | Random     | 128.46 ns | 4.651 ns | 4.123 ns |  1.10 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random     |  72.39 ns | 5.762 ns | 4.812 ns |  0.62 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random     | 104.44 ns | 6.436 ns | 5.374 ns |  0.90 |    0.05 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **56.38 ns** | **3.646 ns** | **3.045 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     |  30.82 ns | 4.768 ns | 4.227 ns |  0.55 |    0.08 |         - |          NA |
| SpanSort         | 28     | Sorted     |  67.11 ns | 6.847 ns | 6.070 ns |  1.19 |    0.12 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  34.19 ns | 6.297 ns | 5.258 ns |  0.61 |    0.10 |         - |          NA |
| GeneratedSort    | 28     | Sorted     |  88.54 ns | 5.079 ns | 4.502 ns |  1.57 |    0.11 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **62.84 ns** | **4.820 ns** | **4.273 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   |  79.05 ns | 5.886 ns | 4.915 ns |  1.26 |    0.12 |         - |          NA |
| SpanSort         | 28     | Reversed   |  78.70 ns | 9.966 ns | 8.835 ns |  1.26 |    0.16 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   |  74.84 ns | 6.146 ns | 5.132 ns |  1.20 |    0.12 |         - |          NA |
| GeneratedSort    | 28     | Reversed   |  94.61 ns | 3.706 ns | 3.095 ns |  1.51 |    0.12 |         - |          NA |
|                  |        |            |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** | **108.64 ns** | **4.978 ns** | **4.413 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates |  78.81 ns | 4.910 ns | 4.353 ns |  0.73 |    0.05 |         - |          NA |
| SpanSort         | 28     | Duplicates | 116.61 ns | 5.966 ns | 4.982 ns |  1.08 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates |  75.45 ns | 6.039 ns | 5.043 ns |  0.70 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Duplicates |  91.79 ns | 9.770 ns | 8.661 ns |  0.85 |    0.08 |         - |          NA |

## Long

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,143.29 ns** | **55.137 ns** | **48.877 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   106.80 ns |  5.909 ns |  5.238 ns |  0.09 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,211.89 ns | 37.930 ns | 31.673 ns |  1.06 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   108.74 ns |  6.606 ns |  5.856 ns |  0.10 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |    99.89 ns |  5.036 ns |  4.464 ns |  0.09 |    0.01 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,386.18 ns** | **47.145 ns** | **39.368 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   110.29 ns |  5.531 ns |  4.903 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,394.65 ns | 71.547 ns | 63.425 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   104.96 ns |  5.686 ns |  5.041 ns |  0.08 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   102.58 ns |  5.383 ns |  4.772 ns |  0.07 |    0.00 |         - |          NA |

## NInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,224.6 ns** | **49.39 ns** | **43.79 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   106.0 ns |  8.62 ns |  6.73 ns |  0.09 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,222.1 ns | 47.01 ns | 41.67 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   107.2 ns |  7.51 ns |  6.66 ns |  0.09 |    0.01 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,352.0 ns** | **55.19 ns** | **48.92 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   110.8 ns |  6.45 ns |  5.72 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,371.5 ns | 45.64 ns | 40.46 ns |  1.02 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |   108.2 ns |  4.85 ns |  4.30 ns |  0.08 |    0.00 |         - |          NA |

## NUInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,224.2 ns** | **44.91 ns** | **39.81 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   106.7 ns |  5.83 ns |  5.17 ns |  0.09 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,246.1 ns | 35.64 ns | 31.60 ns |  1.02 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   105.0 ns |  5.92 ns |  5.25 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,386.1 ns** | **45.21 ns** | **40.07 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   116.2 ns | 11.44 ns | 10.14 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 28     | Random | 1,425.4 ns | 72.69 ns | 64.44 ns |  1.03 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   107.8 ns |  5.10 ns |  4.26 ns |  0.08 |    0.00 |         - |          NA |

## SByte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,227.25 ns** | **35.071 ns** | **29.286 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    34.12 ns |  4.635 ns |  4.109 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,242.99 ns | 67.023 ns | 59.414 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |    32.35 ns |  4.086 ns |  3.622 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   102.23 ns |  5.473 ns |  4.571 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,363.49 ns** | **49.672 ns** | **41.478 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    34.03 ns |  3.795 ns |  3.364 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,393.65 ns | 46.209 ns | 40.963 ns |  1.02 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |    32.26 ns |  4.374 ns |  3.877 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   105.71 ns |  5.024 ns |  4.454 ns |  0.08 |    0.00 |         - |          NA |

## Short

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,229.35 ns** | **39.338 ns** | **34.872 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    53.08 ns |  4.450 ns |  3.945 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,223.52 ns | 38.529 ns | 32.173 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |    51.01 ns |  5.753 ns |  5.100 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   103.43 ns |  4.629 ns |  3.865 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,359.47 ns** | **58.855 ns** | **52.173 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    53.10 ns |  4.217 ns |  3.738 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,411.35 ns | 61.274 ns | 54.318 ns |  1.04 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    50.62 ns |  5.216 ns |  4.355 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   108.78 ns |  7.144 ns |  5.966 ns |  0.08 |    0.01 |         - |          NA |

## String

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **710.9 ns** |  **31.64 ns** |  **28.05 ns** |  **1.00** |    **0.05** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random | 427.7 ns |   8.08 ns |   7.17 ns |  0.60 |    0.02 |         - |        0.00 |
| SpanSort         | 27     | Random | 638.2 ns |  13.73 ns |  12.18 ns |  0.90 |    0.04 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random | 435.0 ns |  29.34 ns |  24.50 ns |  0.61 |    0.04 |         - |        0.00 |
|                  |        |        |          |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **915.9 ns** | **322.15 ns** | **285.57 ns** |  **1.07** |    **0.42** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random | 428.4 ns |   6.63 ns |   5.88 ns |  0.50 |    0.12 |         - |        0.00 |
| SpanSort         | 28     | Random | 694.4 ns |  11.04 ns |   8.62 ns |  0.82 |    0.20 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random | 442.3 ns |  13.58 ns |  10.61 ns |  0.52 |    0.13 |         - |        0.00 |

## UInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **114.49 ns** | **6.450 ns** | **5.718 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  80.12 ns | 7.543 ns | 6.299 ns |  0.70 |    0.06 |         - |          NA |
| SpanSort         | 27     | Random | 109.51 ns | 5.573 ns | 4.941 ns |  0.96 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random |  75.68 ns | 4.236 ns | 3.307 ns |  0.66 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 102.21 ns | 4.519 ns | 4.006 ns |  0.89 |    0.06 |         - |          NA |
|                  |        |        |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **134.07 ns** | **6.662 ns** | **5.905 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  75.66 ns | 3.798 ns | 3.366 ns |  0.57 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 131.12 ns | 5.116 ns | 4.272 ns |  0.98 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |  73.08 ns | 5.159 ns | 4.308 ns |  0.55 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 104.09 ns | 4.856 ns | 4.305 ns |  0.78 |    0.05 |         - |          NA |

## ULong

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error   | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|--------:|--------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **122.8 ns** | **5.48 ns** | **4.85 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 107.2 ns | 4.47 ns | 3.73 ns |  0.87 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random | 119.4 ns | 5.14 ns | 4.29 ns |  0.97 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random | 102.6 ns | 6.19 ns | 5.17 ns |  0.84 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random | 101.7 ns | 3.72 ns | 3.11 ns |  0.83 |    0.04 |         - |          NA |
|                  |        |        |          |         |         |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **143.6 ns** | **4.52 ns** | **3.77 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 108.8 ns | 3.77 ns | 3.34 ns |  0.76 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 143.4 ns | 3.98 ns | 3.32 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 28     | Random | 103.9 ns | 4.68 ns | 3.91 ns |  0.72 |    0.03 |         - |          NA |
| GeneratedSort    | 28     | Random | 107.0 ns | 6.14 ns | 5.13 ns |  0.75 |    0.04 |         - |          NA |

## UShort

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, macOS Sequoia 15.7.4 (24G517) [Darwin 24.6.0]
Apple M1 (Virtual), 1 CPU, 3 logical and 3 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), Arm64 RyuJIT armv8.0-a

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,253.92 ns** | **29.886 ns** | **26.493 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    54.01 ns |  5.214 ns |  4.622 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,239.50 ns | 25.856 ns | 22.921 ns |  0.99 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |    50.96 ns |  4.728 ns |  4.192 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   101.93 ns |  4.717 ns |  3.939 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,433.99 ns** | **78.999 ns** | **70.031 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    53.88 ns |  5.740 ns |  5.088 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,418.25 ns | 37.933 ns | 31.676 ns |  0.99 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    50.34 ns |  4.123 ns |  3.655 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   107.68 ns |  5.455 ns |  4.836 ns |  0.08 |    0.00 |         - |          NA |

