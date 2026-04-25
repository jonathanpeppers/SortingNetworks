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
| Method           | Length | Kind   | Mean        | Error      | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,654.67 ns** |  **59.448 ns** | **49.642 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    61.46 ns |   1.839 ns |  1.630 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,771.52 ns | 102.079 ns | 90.490 ns |  1.07 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Random |    59.38 ns |   3.283 ns |  2.741 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    58.83 ns |   2.989 ns |  2.334 ns |  0.04 |    0.00 |         - |          NA |
|                  |        |        |             |            |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,898.87 ns** |  **83.707 ns** | **74.204 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    61.40 ns |   1.154 ns |  1.023 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,924.11 ns |  65.100 ns | 54.362 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    59.54 ns |   3.314 ns |  2.587 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    60.36 ns |   3.221 ns |  2.855 ns |  0.03 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **115.2 ns** |  **4.23 ns** |  **3.30 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 138.5 ns |  3.29 ns |  2.57 ns |  1.20 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 128.5 ns |  9.40 ns |  7.85 ns |  1.12 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random | 135.3 ns |  3.05 ns |  2.38 ns |  1.18 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 134.7 ns |  5.21 ns |  4.35 ns |  1.17 |    0.05 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **129.9 ns** |  **4.74 ns** |  **3.70 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 141.7 ns |  3.75 ns |  2.93 ns |  1.09 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random | 137.2 ns |  2.90 ns |  2.57 ns |  1.06 |    0.03 |         - |          NA |
| NetworkSort_Span | 28     | Random | 138.1 ns |  3.92 ns |  3.47 ns |  1.06 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 141.6 ns | 15.03 ns | 12.55 ns |  1.09 |    0.10 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,110.9 ns** | **67.89 ns** | **60.18 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   149.2 ns |  1.95 ns |  1.72 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,092.9 ns | 66.68 ns | 59.11 ns |  0.99 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   148.6 ns |  1.83 ns |  1.62 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   155.6 ns |  3.88 ns |  3.24 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,378.7 ns** | **75.87 ns** | **67.26 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   152.7 ns |  2.09 ns |  1.85 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,357.1 ns | 88.14 ns | 78.14 ns |  0.99 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |   151.6 ns |  2.72 ns |  2.41 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   159.0 ns |  3.83 ns |  3.39 ns |  0.07 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **2,097.5 ns** | **75.74 ns** | **67.14 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   124.2 ns |  1.71 ns |  1.51 ns |  0.06 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 2,084.2 ns | 78.05 ns | 65.18 ns |  0.99 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   122.3 ns |  1.58 ns |  1.32 ns |  0.06 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   105.1 ns |  4.74 ns |  3.70 ns |  0.05 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,315.4 ns** | **64.38 ns** | **53.76 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   119.7 ns |  1.52 ns |  1.27 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,312.4 ns | 74.52 ns | 62.23 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 28     | Random |   116.9 ns |  1.61 ns |  1.35 ns |  0.05 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   103.5 ns |  1.22 ns |  1.02 ns |  0.04 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random**     |  **93.20 ns** |  **4.387 ns** |  **3.663 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     | 101.56 ns |  3.348 ns |  2.968 ns |  1.09 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random     | 111.45 ns |  2.867 ns |  2.394 ns |  1.20 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random     |  99.33 ns |  2.603 ns |  2.307 ns |  1.07 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Random     |  99.11 ns |  1.028 ns |  0.803 ns |  1.06 |    0.04 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **60.38 ns** |  **6.972 ns** |  **5.822 ns** |  **1.01** |    **0.13** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     | 106.42 ns | 11.242 ns |  9.388 ns |  1.78 |    0.23 |         - |          NA |
| SpanSort         | 27     | Sorted     |  86.70 ns |  3.679 ns |  2.872 ns |  1.45 |    0.15 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  98.50 ns |  1.526 ns |  1.274 ns |  1.65 |    0.16 |         - |          NA |
| GeneratedSort    | 27     | Sorted     |  98.75 ns |  1.789 ns |  1.586 ns |  1.65 |    0.16 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **78.96 ns** |  **4.646 ns** |  **3.628 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   | 104.23 ns |  2.935 ns |  2.291 ns |  1.32 |    0.07 |         - |          NA |
| SpanSort         | 27     | Reversed   |  97.28 ns |  2.628 ns |  2.052 ns |  1.23 |    0.06 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   |  98.78 ns |  2.039 ns |  1.703 ns |  1.25 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Reversed   |  98.22 ns |  1.988 ns |  1.660 ns |  1.25 |    0.06 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** | **103.28 ns** |  **4.796 ns** |  **4.251 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates | 100.97 ns |  1.667 ns |  1.392 ns |  0.98 |    0.04 |         - |          NA |
| SpanSort         | 27     | Duplicates | 115.52 ns |  3.455 ns |  2.885 ns |  1.12 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates |  98.48 ns |  1.623 ns |  1.355 ns |  0.96 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Duplicates |  97.96 ns |  1.253 ns |  1.111 ns |  0.95 |    0.04 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **110.55 ns** |  **5.747 ns** |  **5.094 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     | 101.61 ns |  2.490 ns |  2.207 ns |  0.92 |    0.05 |         - |          NA |
| SpanSort         | 28     | Random     | 137.05 ns | 16.183 ns | 14.346 ns |  1.24 |    0.14 |         - |          NA |
| NetworkSort_Span | 28     | Random     |  98.31 ns |  2.537 ns |  1.981 ns |  0.89 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random     |  97.27 ns |  1.623 ns |  1.439 ns |  0.88 |    0.04 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **66.87 ns** |  **5.352 ns** |  **4.470 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     | 102.01 ns |  1.326 ns |  1.107 ns |  1.53 |    0.11 |         - |          NA |
| SpanSort         | 28     | Sorted     |  88.82 ns |  3.282 ns |  2.910 ns |  1.33 |    0.10 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  97.88 ns |  1.973 ns |  1.647 ns |  1.47 |    0.10 |         - |          NA |
| GeneratedSort    | 28     | Sorted     |  97.38 ns |  1.481 ns |  1.156 ns |  1.46 |    0.10 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **78.04 ns** |  **4.513 ns** |  **3.768 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   | 102.51 ns |  3.047 ns |  2.379 ns |  1.32 |    0.07 |         - |          NA |
| SpanSort         | 28     | Reversed   | 103.30 ns | 12.557 ns | 11.131 ns |  1.33 |    0.15 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   |  97.88 ns |  1.602 ns |  1.420 ns |  1.26 |    0.06 |         - |          NA |
| GeneratedSort    | 28     | Reversed   |  97.79 ns |  2.199 ns |  1.836 ns |  1.26 |    0.07 |         - |          NA |
|                  |        |            |           |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** | **106.34 ns** |  **5.912 ns** |  **5.241 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates | 101.39 ns |  1.264 ns |  1.056 ns |  0.96 |    0.05 |         - |          NA |
| SpanSort         | 28     | Duplicates | 123.03 ns | 12.809 ns | 10.696 ns |  1.16 |    0.11 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates |  99.50 ns |  2.844 ns |  2.521 ns |  0.94 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Duplicates |  97.18 ns |  1.447 ns |  1.283 ns |  0.92 |    0.05 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error     | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,788.9 ns** |  **51.37 ns** | **45.54 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   154.6 ns |  16.16 ns | 14.33 ns |  0.09 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,852.6 ns |  78.59 ns | 69.67 ns |  1.04 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   144.9 ns |   3.41 ns |  3.02 ns |  0.08 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   141.5 ns |   2.65 ns |  2.07 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |           |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,043.0 ns** | **101.51 ns** | **89.99 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   157.2 ns |  18.79 ns | 16.66 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 28     | Random | 2,133.5 ns |  66.56 ns | 59.00 ns |  1.05 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.8 ns |   3.11 ns |  2.60 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   144.3 ns |   2.68 ns |  2.24 ns |  0.07 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,860.8 ns** | **90.74 ns** | **80.44 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   142.8 ns |  3.27 ns |  2.55 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,831.7 ns | 60.13 ns | 53.31 ns |  0.99 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   142.0 ns |  3.48 ns |  2.90 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,116.5 ns** | **73.08 ns** | **64.79 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   151.0 ns |  5.55 ns |  4.33 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,030.5 ns | 66.32 ns | 58.79 ns |  0.96 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |   146.9 ns |  4.36 ns |  3.40 ns |  0.07 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,852.6 ns** | **87.71 ns** | **77.75 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   147.6 ns |  9.22 ns |  8.17 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,862.7 ns | 58.51 ns | 51.87 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random |   139.3 ns |  4.33 ns |  3.38 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,107.8 ns** | **74.42 ns** | **65.97 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   151.1 ns |  4.45 ns |  3.71 ns |  0.07 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,126.3 ns | 92.05 ns | 81.60 ns |  1.01 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   146.9 ns |  3.18 ns |  2.66 ns |  0.07 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,782.07 ns** |  **54.864 ns** |  **48.635 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    64.67 ns |   2.477 ns |   1.933 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,784.78 ns |  59.310 ns |  52.577 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |    63.32 ns |   1.050 ns |   0.877 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |    63.94 ns |   1.015 ns |   0.900 ns |  0.04 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,034.74 ns** | **111.805 ns** |  **99.112 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    67.14 ns |   2.605 ns |   2.034 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,056.87 ns | 114.170 ns | 101.209 ns |  1.01 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Random |    64.18 ns |   1.519 ns |   1.268 ns |  0.03 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |    63.51 ns |   1.122 ns |   0.995 ns |  0.03 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,814.2 ns** | **78.16 ns** | **69.29 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   144.2 ns |  2.71 ns |  2.40 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,802.1 ns | 61.63 ns | 51.47 ns |  0.99 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   147.1 ns | 15.55 ns | 12.99 ns |  0.08 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |   147.2 ns |  2.61 ns |  2.18 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **2,083.5 ns** | **74.52 ns** | **66.06 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   158.7 ns | 19.42 ns | 17.21 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 28     | Random | 2,075.0 ns | 77.56 ns | 68.75 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |   143.2 ns |  3.36 ns |  2.81 ns |  0.07 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   149.2 ns |  3.09 ns |  2.58 ns |  0.07 |    0.00 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** |   **946.3 ns** |  **24.70 ns** |  **20.63 ns** |  **1.00** |    **0.03** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random |   703.8 ns |  36.19 ns |  32.08 ns |  0.74 |    0.04 |         - |        0.00 |
| SpanSort         | 27     | Random |   960.2 ns |  32.54 ns |  28.85 ns |  1.02 |    0.04 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random |   754.2 ns | 136.63 ns | 114.09 ns |  0.80 |    0.12 |         - |        0.00 |
|                  |        |        |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,017.1 ns** |  **24.77 ns** |  **20.68 ns** |  **1.00** |    **0.03** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random |   710.0 ns |  28.93 ns |  25.65 ns |  0.70 |    0.03 |         - |        0.00 |
| SpanSort         | 28     | Random | 1,023.4 ns |  17.93 ns |  14.97 ns |  1.01 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random |   705.8 ns |  31.08 ns |  27.55 ns |  0.69 |    0.03 |         - |        0.00 |

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
| Method           | Length | Kind   | Mean      | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **112.76 ns** | **3.498 ns** | **2.921 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  96.60 ns | 1.760 ns | 1.374 ns |  0.86 |    0.02 |         - |          NA |
| SpanSort         | 27     | Random | 107.16 ns | 4.189 ns | 3.498 ns |  0.95 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |  94.86 ns | 2.292 ns | 1.789 ns |  0.84 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random |  93.09 ns | 2.604 ns | 2.308 ns |  0.83 |    0.03 |         - |          NA |
|                  |        |        |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **130.80 ns** | **2.963 ns** | **2.475 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  96.35 ns | 2.075 ns | 1.839 ns |  0.74 |    0.02 |         - |          NA |
| SpanSort         | 28     | Random | 124.69 ns | 5.262 ns | 4.394 ns |  0.95 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |  93.08 ns | 2.953 ns | 2.305 ns |  0.71 |    0.02 |         - |          NA |
| GeneratedSort    | 28     | Random |  92.12 ns | 2.369 ns | 1.978 ns |  0.70 |    0.02 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **118.3 ns** |  **3.71 ns** |  **2.90 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 144.6 ns |  2.94 ns |  2.45 ns |  1.22 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 122.1 ns |  4.65 ns |  3.89 ns |  1.03 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random | 139.9 ns |  2.80 ns |  2.34 ns |  1.18 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random | 138.7 ns |  3.10 ns |  2.42 ns |  1.17 |    0.03 |         - |          NA |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **136.4 ns** |  **4.28 ns** |  **3.34 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 146.7 ns |  3.70 ns |  3.09 ns |  1.08 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 137.2 ns |  4.66 ns |  3.89 ns |  1.01 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random | 149.0 ns | 13.09 ns | 11.60 ns |  1.09 |    0.09 |         - |          NA |
| GeneratedSort    | 28     | Random | 148.7 ns |  9.04 ns |  7.06 ns |  1.09 |    0.06 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,656.5 ns** | **52.27 ns** | **46.33 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   146.4 ns |  3.72 ns |  3.10 ns |  0.09 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,684.9 ns | 62.01 ns | 54.97 ns |  1.02 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   142.2 ns |  2.76 ns |  2.16 ns |  0.09 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   139.2 ns |  3.59 ns |  2.81 ns |  0.08 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,915.7 ns** | **70.23 ns** | **62.26 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   145.0 ns |  2.99 ns |  2.65 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,072.2 ns | 65.77 ns | 58.30 ns |  1.08 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |   149.4 ns | 15.90 ns | 14.09 ns |  0.08 |    0.01 |         - |          NA |
| GeneratedSort    | 28     | Random |   144.0 ns |  3.36 ns |  2.81 ns |  0.08 |    0.00 |         - |          NA |

