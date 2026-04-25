## Byte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,850.85 ns** | **252.123 ns** | **223.501 ns** |  **1.01** |    **0.16** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    62.81 ns |   2.021 ns |   1.687 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,684.75 ns |  41.950 ns |  35.030 ns |  0.92 |    0.10 |         - |          NA |
| NetworkSort_Span | 27     | Random |    60.37 ns |   1.640 ns |   1.454 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    58.78 ns |   2.692 ns |   2.248 ns |  0.03 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,899.80 ns** |  **77.248 ns** |  **68.478 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    64.21 ns |   3.085 ns |   2.735 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,079.60 ns | 142.162 ns | 126.023 ns |  1.10 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Random |    60.36 ns |   2.633 ns |   2.198 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    61.52 ns |   2.506 ns |   2.093 ns |  0.03 |    0.00 |         - |          NA |

## Char

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |  **35.97 ns** |  **6.225 ns** |  **5.198 ns** |  **1.02** |    **0.22** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |  46.41 ns |  2.522 ns |  2.106 ns |  1.32 |    0.22 |         - |          NA |
| SpanSort         | 8      | Random |  52.09 ns |  9.554 ns |  7.978 ns |  1.48 |    0.33 |         - |          NA |
| NetworkSort_Span | 8      | Random |  47.20 ns |  6.759 ns |  5.277 ns |  1.34 |    0.26 |         - |          NA |
| GeneratedSort    | 8      | Random |  29.31 ns |  2.517 ns |  2.231 ns |  0.83 |    0.15 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** |  **76.94 ns** |  **3.859 ns** |  **3.223 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 16     | Random |  92.56 ns |  3.335 ns |  2.604 ns |  1.21 |    0.06 |         - |          NA |
| SpanSort         | 16     | Random |  88.76 ns |  5.871 ns |  4.584 ns |  1.16 |    0.07 |         - |          NA |
| NetworkSort_Span | 16     | Random |  91.24 ns |  4.800 ns |  3.747 ns |  1.19 |    0.07 |         - |          NA |
| GeneratedSort    | 16     | Random |  47.82 ns |  1.396 ns |  1.237 ns |  0.62 |    0.03 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **116.15 ns** |  **3.212 ns** |  **2.682 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 140.27 ns |  4.972 ns |  4.152 ns |  1.21 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 129.78 ns |  8.004 ns |  6.683 ns |  1.12 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random | 143.39 ns | 16.185 ns | 14.347 ns |  1.24 |    0.12 |         - |          NA |
| GeneratedSort    | 27     | Random | 136.15 ns |  2.817 ns |  2.199 ns |  1.17 |    0.03 |         - |          NA |
|                  |        |        |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **129.83 ns** |  **3.368 ns** |  **2.812 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 140.83 ns |  4.145 ns |  3.461 ns |  1.09 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 137.30 ns |  2.964 ns |  2.475 ns |  1.06 |    0.03 |         - |          NA |
| NetworkSort_Span | 28     | Random | 138.80 ns |  5.887 ns |  4.596 ns |  1.07 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 137.48 ns |  4.524 ns |  3.532 ns |  1.06 |    0.03 |         - |          NA |

## Double

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,169.4 ns** |  **53.50 ns** | **47.42 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   153.0 ns |   2.37 ns |  1.98 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,111.3 ns |  73.44 ns | 65.10 ns |  0.97 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   146.0 ns |   1.34 ns |  1.05 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   157.3 ns |  12.91 ns | 10.78 ns |  0.07 |    0.01 |         - |          NA |
|                  |        |        |            |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,398.4 ns** | **103.42 ns** | **91.68 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   152.8 ns |  10.04 ns |  8.90 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,413.1 ns |  77.22 ns | 68.45 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.8 ns |   2.08 ns |  1.73 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   158.3 ns |   3.30 ns |  2.75 ns |  0.07 |    0.00 |         - |          NA |

## Float

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,104.1 ns** |  **68.65 ns** |  **60.86 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   130.6 ns |  10.24 ns |   9.08 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,053.5 ns |  59.61 ns |  49.78 ns |  0.98 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   122.5 ns |   1.87 ns |   1.46 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   104.3 ns |   2.87 ns |   2.24 ns |  0.05 |    0.00 |         - |          NA |
|                  |        |        |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,345.7 ns** |  **82.11 ns** |  **72.79 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   120.1 ns |   1.50 ns |   1.25 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,355.2 ns | 117.22 ns | 103.91 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   115.9 ns |   1.71 ns |   1.43 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   103.1 ns |   1.60 ns |   1.42 ns |  0.04 |    0.00 |         - |          NA |

## Int

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind       | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |----------- |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random**     |  **96.67 ns** | **13.568 ns** | **12.028 ns** |  **1.01** |    **0.16** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     | 100.26 ns |  1.533 ns |  1.359 ns |  1.05 |    0.11 |         - |          NA |
| SpanSort         | 27     | Random     | 112.74 ns |  5.665 ns |  4.423 ns |  1.18 |    0.14 |         - |          NA |
| NetworkSort_Span | 27     | Random     |  98.56 ns |  1.320 ns |  1.171 ns |  1.03 |    0.11 |         - |          NA |
| GeneratedSort    | 27     | Random     |  98.44 ns |  1.944 ns |  1.624 ns |  1.03 |    0.11 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **60.77 ns** |  **4.679 ns** |  **3.907 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     | 100.51 ns |  1.944 ns |  1.518 ns |  1.66 |    0.12 |         - |          NA |
| SpanSort         | 27     | Sorted     |  84.73 ns |  3.726 ns |  2.909 ns |  1.40 |    0.11 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  98.40 ns |  1.457 ns |  1.217 ns |  1.63 |    0.11 |         - |          NA |
| GeneratedSort    | 27     | Sorted     |  98.58 ns |  1.633 ns |  1.363 ns |  1.63 |    0.12 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **78.88 ns** |  **3.148 ns** |  **2.628 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   | 101.30 ns |  2.531 ns |  2.113 ns |  1.29 |    0.05 |         - |          NA |
| SpanSort         | 27     | Reversed   |  95.15 ns |  3.250 ns |  2.714 ns |  1.21 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   |  98.73 ns |  2.720 ns |  2.271 ns |  1.25 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Reversed   |  97.73 ns |  1.367 ns |  1.141 ns |  1.24 |    0.04 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** |  **99.53 ns** |  **4.721 ns** |  **3.686 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates | 102.67 ns |  2.474 ns |  1.931 ns |  1.03 |    0.04 |         - |          NA |
| SpanSort         | 27     | Duplicates | 112.39 ns |  2.937 ns |  2.293 ns |  1.13 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates |  99.12 ns |  1.689 ns |  1.411 ns |  1.00 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Duplicates |  98.47 ns |  1.598 ns |  1.334 ns |  0.99 |    0.04 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **110.39 ns** | **11.155 ns** |  **9.315 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     | 100.24 ns |  1.560 ns |  1.302 ns |  0.91 |    0.07 |         - |          NA |
| SpanSort         | 28     | Random     | 129.43 ns |  3.517 ns |  2.746 ns |  1.18 |    0.09 |         - |          NA |
| NetworkSort_Span | 28     | Random     |  97.74 ns |  1.586 ns |  1.406 ns |  0.89 |    0.07 |         - |          NA |
| GeneratedSort    | 28     | Random     |  97.20 ns |  1.616 ns |  1.350 ns |  0.89 |    0.07 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **66.34 ns** |  **5.245 ns** |  **4.380 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     | 103.30 ns |  4.802 ns |  4.257 ns |  1.56 |    0.13 |         - |          NA |
| SpanSort         | 28     | Sorted     |  86.91 ns |  2.772 ns |  2.457 ns |  1.32 |    0.10 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  98.82 ns |  2.980 ns |  2.326 ns |  1.50 |    0.11 |         - |          NA |
| GeneratedSort    | 28     | Sorted     | 101.32 ns | 12.487 ns | 10.427 ns |  1.53 |    0.19 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **78.25 ns** |  **3.839 ns** |  **3.403 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   | 100.88 ns |  2.284 ns |  2.025 ns |  1.29 |    0.06 |         - |          NA |
| SpanSort         | 28     | Reversed   |  97.08 ns |  3.416 ns |  2.667 ns |  1.24 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   |  99.09 ns |  2.137 ns |  1.894 ns |  1.27 |    0.06 |         - |          NA |
| GeneratedSort    | 28     | Reversed   |  96.97 ns |  1.377 ns |  1.150 ns |  1.24 |    0.06 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** | **113.43 ns** |  **6.231 ns** |  **5.203 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates | 101.27 ns |  2.936 ns |  2.292 ns |  0.89 |    0.05 |         - |          NA |
| SpanSort         | 28     | Duplicates | 129.99 ns |  3.849 ns |  3.005 ns |  1.15 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates | 100.43 ns |  2.617 ns |  2.320 ns |  0.89 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Duplicates | 100.29 ns |  4.222 ns |  3.742 ns |  0.89 |    0.05 |         - |          NA |

## Long

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,146.2 ns** | **422.76 ns** | **395.45 ns** |  **1.03** |    **0.24** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   146.8 ns |   3.88 ns |   3.03 ns |  0.07 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,814.7 ns |  67.04 ns |  59.43 ns |  0.87 |    0.13 |         - |          NA |
| NetworkSort_Span | 27     | Random |   144.3 ns |   3.72 ns |   3.10 ns |  0.07 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |   141.1 ns |   2.64 ns |   2.34 ns |  0.07 |    0.01 |         - |          NA |
|                  |        |        |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,097.7 ns** |  **97.01 ns** |  **86.00 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   147.2 ns |   3.87 ns |   3.02 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,114.5 ns |  86.55 ns |  72.27 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   151.4 ns |  15.21 ns |  13.48 ns |  0.07 |    0.01 |         - |          NA |
| GeneratedSort    | 28     | Random |   145.6 ns |   2.45 ns |   1.91 ns |  0.07 |    0.00 |         - |          NA |

## NInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,190.5 ns** |  **62.45 ns** | **55.36 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   142.5 ns |   3.76 ns |  2.93 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,788.3 ns |  49.05 ns | 40.96 ns |  0.82 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |   142.9 ns |   6.92 ns |  5.40 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,137.3 ns** | **107.04 ns** | **89.39 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   153.6 ns |   8.56 ns |  6.68 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,047.2 ns |  75.31 ns | 62.88 ns |  0.96 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   152.4 ns |  11.05 ns |  8.63 ns |  0.07 |    0.00 |         - |          NA |

## NUInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,802.4 ns** | **40.85 ns** | **34.11 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   143.3 ns |  6.74 ns |  5.26 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,912.0 ns | 60.91 ns | 54.00 ns |  1.06 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |   144.3 ns |  7.35 ns |  6.51 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,108.1 ns** | **92.56 ns** | **82.05 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   150.7 ns |  3.73 ns |  3.12 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,134.8 ns | 81.17 ns | 67.78 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   149.9 ns |  8.63 ns |  7.21 ns |  0.07 |    0.00 |         - |          NA |

## SByte

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,028.79 ns** | **55.878 ns** | **49.535 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    64.24 ns |  1.389 ns |  1.084 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,794.53 ns | 58.397 ns | 48.764 ns |  0.89 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |    64.31 ns |  1.133 ns |  0.946 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    63.50 ns |  1.256 ns |  1.114 ns |  0.03 |    0.00 |         - |          NA |
|                  |        |        |             |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,008.46 ns** | **98.264 ns** | **87.108 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    64.06 ns |  1.130 ns |  0.944 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,058.15 ns | 75.202 ns | 66.664 ns |  1.03 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    64.69 ns |  1.154 ns |  0.964 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    63.15 ns |  1.160 ns |  0.906 ns |  0.03 |    0.00 |         - |          NA |

## Short

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **370.15 ns** |  **17.590 ns** |  **14.688 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   385.89 ns |  10.651 ns |   8.894 ns |  1.04 |    0.05 |         - |          NA |
| SpanSort         | 8      | Random |   377.50 ns |  26.589 ns |  23.571 ns |  1.02 |    0.07 |         - |          NA |
| NetworkSort_Span | 8      | Random |   379.67 ns |  16.638 ns |  14.749 ns |  1.03 |    0.05 |         - |          NA |
| GeneratedSort    | 8      | Random |    34.06 ns |   1.126 ns |   0.998 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **16**     | **Random** | **1,177.76 ns** |  **42.385 ns** |  **37.573 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 16     | Random | 1,211.71 ns |  41.789 ns |  37.045 ns |  1.03 |    0.04 |         - |          NA |
| SpanSort         | 16     | Random | 1,217.44 ns |  77.649 ns |  68.834 ns |  1.03 |    0.06 |         - |          NA |
| NetworkSort_Span | 16     | Random | 1,205.27 ns |  40.333 ns |  33.680 ns |  1.02 |    0.04 |         - |          NA |
| GeneratedSort    | 16     | Random |    56.37 ns |   2.538 ns |   2.250 ns |  0.05 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **1,795.82 ns** |  **65.488 ns** |  **54.686 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   150.04 ns |  11.531 ns |  10.222 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,861.34 ns | 100.793 ns |  84.167 ns |  1.04 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   145.62 ns |   4.234 ns |   3.306 ns |  0.08 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   144.19 ns |   3.149 ns |   2.459 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,124.52 ns** |  **96.268 ns** |  **80.389 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   151.70 ns |   9.904 ns |   8.270 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,117.52 ns | 112.872 ns | 100.058 ns |  1.00 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |   159.17 ns |  12.449 ns |  10.396 ns |  0.08 |    0.01 |         - |          NA |
| GeneratedSort    | 28     | Random |   159.26 ns |  19.967 ns |  17.700 ns |  0.08 |    0.01 |         - |          NA |

## String

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** |   **986.1 ns** |  **36.08 ns** |  **28.17 ns** |  **1.00** |    **0.04** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random |   690.3 ns |  26.91 ns |  21.01 ns |  0.70 |    0.03 |         - |        0.00 |
| SpanSort         | 27     | Random |   949.4 ns |  29.72 ns |  26.34 ns |  0.96 |    0.04 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random |   694.9 ns |  22.65 ns |  18.91 ns |  0.71 |    0.03 |         - |        0.00 |
|                  |        |        |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,260.3 ns** | **306.44 ns** | **286.64 ns** |  **1.04** |    **0.31** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random |   832.0 ns | 200.32 ns | 177.58 ns |  0.69 |    0.20 |         - |        0.00 |
| SpanSort         | 28     | Random | 1,079.7 ns |  27.21 ns |  24.12 ns |  0.89 |    0.18 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random |   882.0 ns | 297.99 ns | 264.16 ns |  0.73 |    0.26 |         - |        0.00 |

## UInt

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **121.19 ns** | **14.150 ns** | **11.816 ns** | **114.20 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  98.93 ns |  5.298 ns |  4.424 ns |  97.85 ns |  0.82 |    0.08 |         - |          NA |
| SpanSort         | 27     | Random | 148.27 ns | 61.866 ns | 54.843 ns | 112.75 ns |  1.23 |    0.46 |         - |          NA |
| NetworkSort_Span | 27     | Random |  94.51 ns |  2.970 ns |  2.480 ns |  94.80 ns |  0.79 |    0.07 |         - |          NA |
| GeneratedSort    | 27     | Random |  95.84 ns |  4.434 ns |  3.462 ns |  96.15 ns |  0.80 |    0.08 |         - |          NA |
|                  |        |        |           |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **142.93 ns** |  **4.792 ns** |  **3.741 ns** | **143.80 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  96.48 ns |  2.155 ns |  1.683 ns |  97.00 ns |  0.68 |    0.02 |         - |          NA |
| SpanSort         | 28     | Random | 139.35 ns |  6.023 ns |  4.702 ns | 139.50 ns |  0.98 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |  94.49 ns |  3.111 ns |  2.758 ns |  94.65 ns |  0.66 |    0.03 |         - |          NA |
| GeneratedSort    | 28     | Random |  93.48 ns |  2.812 ns |  2.348 ns |  93.60 ns |  0.65 |    0.02 |         - |          NA |

## ULong

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **130.9 ns** | **12.44 ns** |  **9.71 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 174.9 ns | 39.49 ns | 35.01 ns |  1.34 |    0.27 |         - |          NA |
| SpanSort         | 27     | Random | 155.6 ns | 48.86 ns | 43.31 ns |  1.19 |    0.33 |         - |          NA |
| NetworkSort_Span | 27     | Random | 149.4 ns | 10.31 ns |  8.05 ns |  1.15 |    0.10 |         - |          NA |
| GeneratedSort    | 27     | Random | 151.2 ns | 37.63 ns | 31.42 ns |  1.16 |    0.25 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **136.5 ns** |  **3.88 ns** |  **3.03 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 148.2 ns |  5.05 ns |  4.22 ns |  1.09 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 146.5 ns |  7.88 ns |  6.58 ns |  1.07 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random | 151.4 ns | 10.12 ns |  8.45 ns |  1.11 |    0.06 |         - |          NA |
| GeneratedSort    | 28     | Random | 173.7 ns | 37.64 ns | 33.37 ns |  1.27 |    0.24 |         - |          NA |

## UShort

> **ArraySort** = BCL baseline `Array.Sort`, **NetworkSort** = this library

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.32522/24H2/2024Update/HudsonValley) (Hyper-V)
AMD EPYC 7763 2.44GHz, 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  Job-IAMMPO : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3

InvocationCount=1  IterationCount=15  UnrollFactor=1  
WarmupCount=5  

```
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Median      | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **352.53 ns** |  **23.501 ns** |  **20.833 ns** |   **347.75 ns** |  **1.00** |    **0.08** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   420.38 ns | 103.541 ns |  91.787 ns |   373.70 ns |  1.20 |    0.26 |         - |          NA |
| SpanSort         | 8      | Random |   362.12 ns |  15.785 ns |  12.324 ns |   362.20 ns |  1.03 |    0.07 |         - |          NA |
| NetworkSort_Span | 8      | Random |   417.81 ns |  97.739 ns |  86.643 ns |   376.75 ns |  1.19 |    0.25 |         - |          NA |
| GeneratedSort    | 8      | Random |    35.69 ns |   2.325 ns |   2.061 ns |    35.50 ns |  0.10 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |             |       |         |           |             |
| **ArraySort**        | **16**     | **Random** | **1,280.01 ns** | **262.514 ns** | **245.556 ns** | **1,203.70 ns** |  **1.03** |    **0.26** |         **-** |          **NA** |
| NetworkSort      | 16     | Random | 1,516.49 ns | 436.028 ns | 407.861 ns | 1,205.40 ns |  1.22 |    0.38 |         - |          NA |
| SpanSort         | 16     | Random | 1,140.45 ns | 121.286 ns | 101.280 ns | 1,102.80 ns |  0.92 |    0.17 |         - |          NA |
| NetworkSort_Span | 16     | Random | 1,210.14 ns | 125.835 ns | 111.550 ns | 1,180.55 ns |  0.98 |    0.19 |         - |          NA |
| GeneratedSort    | 16     | Random |    55.27 ns |   1.341 ns |   1.189 ns |    55.65 ns |  0.04 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |             |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **1,649.32 ns** |  **86.634 ns** |  **72.343 ns** | **1,647.80 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   146.77 ns |   7.314 ns |   5.710 ns |   144.65 ns |  0.09 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,688.89 ns |  56.908 ns |  50.447 ns | 1,675.45 ns |  1.03 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   142.99 ns |   2.999 ns |   2.342 ns |   143.45 ns |  0.09 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   145.32 ns |   7.326 ns |   6.118 ns |   143.40 ns |  0.09 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |             |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,939.62 ns** |  **64.273 ns** |  **50.180 ns** | **1,940.30 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   155.02 ns |   3.590 ns |   2.998 ns |   156.20 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,947.20 ns |  47.733 ns |  39.859 ns | 1,935.90 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 28     | Random |   147.09 ns |  10.601 ns |   8.276 ns |   144.05 ns |  0.08 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   168.27 ns |  42.788 ns |  37.930 ns |   143.35 ns |  0.09 |    0.02 |         - |          NA |

