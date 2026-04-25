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
| **ArraySort**        | **27**     | **Random** | **1,951.48 ns** | **55.434 ns** | **49.141 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    53.40 ns |  2.734 ns |  2.283 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,957.61 ns | 34.574 ns | 30.649 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |    50.34 ns |  2.580 ns |  2.014 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   130.34 ns |  4.719 ns |  3.684 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,220.65 ns** | **43.968 ns** | **38.977 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    51.39 ns |  2.727 ns |  2.278 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,176.97 ns | 37.097 ns | 32.885 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    50.15 ns |  2.997 ns |  2.656 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   133.08 ns |  8.477 ns |  7.515 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **109.27 ns** |  **4.273 ns** | **3.336 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  70.13 ns |  2.569 ns | 2.277 ns |  0.64 |    0.03 |         - |          NA |
| SpanSort         | 27     | Random | 117.34 ns |  8.806 ns | 7.807 ns |  1.07 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Random |  67.92 ns |  2.812 ns | 2.348 ns |  0.62 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random | 132.56 ns | 10.813 ns | 9.585 ns |  1.21 |    0.09 |         - |          NA |
|                  |        |        |           |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **125.01 ns** |  **4.781 ns** | **3.992 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  70.45 ns |  2.539 ns | 2.120 ns |  0.56 |    0.02 |         - |          NA |
| SpanSort         | 28     | Random | 132.20 ns |  9.835 ns | 8.719 ns |  1.06 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Random |  67.88 ns |  2.440 ns | 2.037 ns |  0.54 |    0.02 |         - |          NA |
| GeneratedSort    | 28     | Random | 130.78 ns |  4.823 ns | 4.276 ns |  1.05 |    0.05 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **2,477.9 ns** | **37.40 ns** | **33.15 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   156.1 ns |  6.76 ns |  5.64 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,452.1 ns | 45.28 ns | 40.14 ns |  0.99 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   149.1 ns |  3.67 ns |  2.87 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   152.2 ns |  4.52 ns |  3.53 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,713.0 ns** | **50.08 ns** | **44.39 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   161.9 ns | 10.30 ns |  9.13 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,771.9 ns | 43.62 ns | 36.43 ns |  1.02 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   158.6 ns | 10.72 ns |  9.50 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   155.0 ns |  3.06 ns |  2.39 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **2,471.9 ns** | **45.50 ns** | **40.33 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   153.5 ns | 10.67 ns |  9.46 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,476.4 ns | 40.28 ns | 35.71 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   146.2 ns |  2.93 ns |  2.45 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   142.4 ns |  2.61 ns |  2.31 ns |  0.06 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,788.1 ns** | **52.45 ns** | **46.49 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   144.1 ns |  2.52 ns |  2.23 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,724.2 ns | 52.63 ns | 46.66 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.0 ns |  4.52 ns |  3.53 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   148.9 ns |  3.88 ns |  3.24 ns |  0.05 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random**     | **101.37 ns** |  **9.677 ns** |  **8.081 ns** |  **1.01** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     | 145.63 ns |  3.257 ns |  2.543 ns |  1.44 |    0.10 |         - |          NA |
| SpanSort         | 27     | Random     | 101.88 ns |  4.119 ns |  3.216 ns |  1.01 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Random     | 148.83 ns | 12.416 ns | 11.007 ns |  1.48 |    0.15 |         - |          NA |
| GeneratedSort    | 27     | Random     | 136.43 ns | 12.335 ns | 10.935 ns |  1.35 |    0.14 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **61.01 ns** |  **4.735 ns** |  **3.954 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     |  34.96 ns |  3.604 ns |  2.814 ns |  0.58 |    0.06 |         - |          NA |
| SpanSort         | 27     | Sorted     |  64.36 ns |  3.370 ns |  2.987 ns |  1.06 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  32.58 ns |  3.669 ns |  2.865 ns |  0.54 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Sorted     | 127.24 ns |  4.164 ns |  3.478 ns |  2.09 |    0.15 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **82.37 ns** |  **8.989 ns** |  **7.969 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   | 144.99 ns |  2.884 ns |  2.408 ns |  1.77 |    0.15 |         - |          NA |
| SpanSort         | 27     | Reversed   |  83.11 ns |  3.696 ns |  3.086 ns |  1.02 |    0.09 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   | 142.93 ns |  3.998 ns |  3.122 ns |  1.75 |    0.15 |         - |          NA |
| GeneratedSort    | 27     | Reversed   | 136.22 ns |  7.570 ns |  6.321 ns |  1.67 |    0.16 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** | **100.93 ns** | **10.698 ns** |  **9.484 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates | 144.54 ns |  2.936 ns |  2.452 ns |  1.44 |    0.12 |         - |          NA |
| SpanSort         | 27     | Duplicates |  99.69 ns |  3.293 ns |  2.919 ns |  1.00 |    0.09 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates | 144.38 ns |  4.191 ns |  3.272 ns |  1.44 |    0.13 |         - |          NA |
| GeneratedSort    | 27     | Duplicates | 122.25 ns |  3.536 ns |  2.760 ns |  1.22 |    0.11 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **115.93 ns** | **11.024 ns** |  **9.773 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     | 141.48 ns |  3.869 ns |  3.231 ns |  1.23 |    0.10 |         - |          NA |
| SpanSort         | 28     | Random     | 116.31 ns |  4.377 ns |  3.655 ns |  1.01 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Random     | 140.96 ns |  9.015 ns |  7.528 ns |  1.22 |    0.11 |         - |          NA |
| GeneratedSort    | 28     | Random     | 126.60 ns |  4.268 ns |  3.332 ns |  1.10 |    0.09 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **61.54 ns** |  **4.131 ns** |  **3.449 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     |  36.16 ns |  3.852 ns |  3.415 ns |  0.59 |    0.06 |         - |          NA |
| SpanSort         | 28     | Sorted     |  65.97 ns |  4.144 ns |  3.460 ns |  1.08 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  33.79 ns |  4.411 ns |  3.683 ns |  0.55 |    0.07 |         - |          NA |
| GeneratedSort    | 28     | Sorted     | 131.22 ns |  4.630 ns |  3.615 ns |  2.14 |    0.14 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **79.73 ns** |  **4.331 ns** |  **3.381 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   | 141.11 ns |  3.643 ns |  2.844 ns |  1.77 |    0.08 |         - |          NA |
| SpanSort         | 28     | Reversed   |  85.04 ns |  4.176 ns |  3.260 ns |  1.07 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   | 138.70 ns |  3.301 ns |  2.757 ns |  1.74 |    0.08 |         - |          NA |
| GeneratedSort    | 28     | Reversed   | 140.93 ns |  7.277 ns |  6.077 ns |  1.77 |    0.11 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** |  **98.01 ns** |  **3.785 ns** |  **3.160 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates | 140.90 ns |  2.918 ns |  2.587 ns |  1.44 |    0.05 |         - |          NA |
| SpanSort         | 28     | Duplicates | 101.56 ns |  3.823 ns |  3.389 ns |  1.04 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates | 143.07 ns |  8.467 ns |  7.505 ns |  1.46 |    0.09 |         - |          NA |
| GeneratedSort    | 28     | Duplicates | 127.16 ns |  5.005 ns |  3.907 ns |  1.30 |    0.06 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **2,039.8 ns** | **38.09 ns** | **33.77 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   136.1 ns |  4.55 ns |  3.55 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,035.9 ns | 39.25 ns | 34.80 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   133.4 ns |  3.74 ns |  3.12 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   134.7 ns |  4.85 ns |  3.78 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,283.9 ns** | **48.28 ns** | **42.80 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   142.1 ns |  3.98 ns |  3.11 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,298.1 ns | 46.33 ns | 41.07 ns |  1.01 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   142.7 ns |  9.25 ns |  7.72 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   138.4 ns |  4.37 ns |  3.88 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **2,083.7 ns** | **29.01 ns** | **25.72 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   142.2 ns |  5.22 ns |  4.07 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,032.6 ns | 41.63 ns | 36.90 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   138.0 ns |  4.26 ns |  3.56 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,375.2 ns** | **36.75 ns** | **32.57 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   149.0 ns | 12.61 ns | 11.18 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,360.9 ns | 46.28 ns | 41.03 ns |  0.99 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.5 ns |  4.67 ns |  3.90 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **2,023.9 ns** | **43.61 ns** | **38.66 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   140.3 ns |  3.36 ns |  2.63 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,073.0 ns | 28.91 ns | 25.63 ns |  1.02 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |   135.8 ns |  6.28 ns |  4.90 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,377.3 ns** | **39.61 ns** | **35.11 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   148.8 ns |  9.66 ns |  8.57 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,348.8 ns | 46.03 ns | 40.81 ns |  0.99 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |   142.3 ns |  7.93 ns |  6.62 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,994.66 ns** | **37.286 ns** | **33.053 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    55.65 ns |  2.632 ns |  2.198 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,007.40 ns | 27.307 ns | 22.803 ns |  1.01 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    53.47 ns |  2.862 ns |  2.234 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   132.97 ns |  4.562 ns |  3.810 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,266.24 ns** | **46.036 ns** | **40.810 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    55.19 ns |  2.498 ns |  2.086 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,247.04 ns | 45.372 ns | 40.221 ns |  0.99 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    53.42 ns |  2.994 ns |  2.500 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   138.36 ns |  9.366 ns |  7.821 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **2,056.71 ns** | **29.571 ns** | **26.214 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    74.28 ns |  2.965 ns |  2.476 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,050.75 ns | 35.471 ns | 31.444 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    73.00 ns |  2.417 ns |  2.018 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   134.39 ns |  3.742 ns |  3.317 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,343.92 ns** | **32.238 ns** | **26.920 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    74.48 ns |  3.338 ns |  2.606 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,292.29 ns | 45.958 ns | 40.741 ns |  0.98 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    72.54 ns |  2.801 ns |  2.339 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   144.93 ns |  9.271 ns |  8.218 ns |  0.06 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **830.0 ns** | **18.30 ns** | **15.29 ns** |  **1.00** |    **0.03** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random | 570.9 ns | 10.94 ns |  9.70 ns |  0.69 |    0.02 |         - |        0.00 |
| SpanSort         | 27     | Random | 832.8 ns | 16.84 ns | 14.07 ns |  1.00 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random | 568.7 ns | 12.04 ns | 10.67 ns |  0.69 |    0.02 |         - |        0.00 |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **870.6 ns** | **12.17 ns** | **10.16 ns** |  **1.00** |    **0.02** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random | 590.3 ns | 14.78 ns | 13.10 ns |  0.68 |    0.02 |         - |        0.00 |
| SpanSort         | 28     | Random | 884.0 ns | 12.24 ns | 10.22 ns |  1.02 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random | 589.0 ns | 12.57 ns | 11.15 ns |  0.68 |    0.01 |         - |        0.00 |

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
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **106.3 ns** |  **9.02 ns** |  **7.53 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 149.6 ns | 11.22 ns |  9.95 ns |  1.41 |    0.13 |         - |          NA |
| SpanSort         | 27     | Random | 101.7 ns |  4.57 ns |  3.82 ns |  0.96 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random | 142.4 ns |  2.67 ns |  2.36 ns |  1.34 |    0.09 |         - |          NA |
| GeneratedSort    | 27     | Random | 131.1 ns | 10.52 ns |  9.33 ns |  1.24 |    0.11 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **120.5 ns** |  **3.24 ns** |  **2.71 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 146.2 ns |  9.09 ns |  8.06 ns |  1.21 |    0.07 |         - |          NA |
| SpanSort         | 28     | Random | 117.0 ns |  5.19 ns |  4.34 ns |  0.97 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random | 145.4 ns | 12.97 ns | 11.50 ns |  1.21 |    0.10 |         - |          NA |
| GeneratedSort    | 28     | Random | 129.5 ns |  6.77 ns |  5.29 ns |  1.08 |    0.05 |         - |          NA |

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
| Method           | Length | Kind   | Mean     | Error    | StdDev  | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|--------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **112.5 ns** |  **3.15 ns** | **2.79 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 139.2 ns |  4.03 ns | 3.15 ns |  1.24 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 118.7 ns |  9.51 ns | 8.43 ns |  1.06 |    0.08 |         - |          NA |
| NetworkSort_Span | 27     | Random | 135.4 ns |  4.91 ns | 3.83 ns |  1.20 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 136.2 ns |  4.86 ns | 3.79 ns |  1.21 |    0.04 |         - |          NA |
|                  |        |        |          |          |         |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **134.7 ns** | **10.44 ns** | **9.26 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 144.9 ns |  5.47 ns | 4.27 ns |  1.08 |    0.07 |         - |          NA |
| SpanSort         | 28     | Random | 132.3 ns |  3.80 ns | 3.18 ns |  0.99 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random | 137.8 ns |  3.81 ns | 3.18 ns |  1.03 |    0.07 |         - |          NA |
| GeneratedSort    | 28     | Random | 140.9 ns |  5.21 ns | 4.07 ns |  1.05 |    0.07 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,993.11 ns** | **33.910 ns** | **30.060 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    74.03 ns |  3.607 ns |  2.816 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,985.39 ns | 42.767 ns | 37.911 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 27     | Random |    72.47 ns |  2.910 ns |  2.430 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   135.25 ns |  3.722 ns |  3.108 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,322.52 ns** | **40.523 ns** | **35.922 ns** |  **1.00** |    **0.02** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    74.20 ns |  3.056 ns |  2.552 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,324.96 ns | 51.247 ns | 45.430 ns |  1.00 |    0.02 |         - |          NA |
| NetworkSort_Span | 28     | Random |    72.14 ns |  3.127 ns |  2.441 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   143.83 ns | 10.283 ns |  9.116 ns |  0.06 |    0.00 |         - |          NA |

