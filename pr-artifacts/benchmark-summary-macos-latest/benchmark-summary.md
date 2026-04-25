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
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,345.39 ns** | **609.984 ns** | **476.236 ns** |  **1.06** |    **0.41** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    35.65 ns |   8.075 ns |   6.304 ns |  0.03 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,204.13 ns |  25.354 ns |  21.171 ns |  0.95 |    0.16 |         - |          NA |
| NetworkSort_Span | 27     | Random |    38.83 ns |  23.029 ns |  17.979 ns |  0.03 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |    99.57 ns |   5.486 ns |   4.581 ns |  0.08 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,499.25 ns** | **280.566 ns** | **248.714 ns** |  **1.02** |    **0.22** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    32.79 ns |   4.157 ns |   3.685 ns |  0.02 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,529.47 ns | 372.663 ns | 290.950 ns |  1.04 |    0.24 |         - |          NA |
| NetworkSort_Span | 28     | Random |    32.21 ns |   4.995 ns |   3.900 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   102.27 ns |   5.660 ns |   4.727 ns |  0.07 |    0.01 |         - |          NA |

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
| Method           | Length | Kind   | Mean      | Error      | StdDev     | Median    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |----------:|-----------:|-----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |  **39.38 ns** |   **5.742 ns** |   **4.795 ns** |  **41.62 ns** |  **1.02** |    **0.19** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |  86.70 ns |  43.776 ns |  38.806 ns |  63.88 ns |  2.24 |    1.03 |         - |          NA |
| SpanSort         | 8      | Random |  63.24 ns |  33.733 ns |  28.169 ns |  49.40 ns |  1.63 |    0.74 |         - |          NA |
| NetworkSort_Span | 8      | Random |  58.12 ns |  14.879 ns |  12.425 ns |  53.75 ns |  1.50 |    0.38 |         - |          NA |
| GeneratedSort    | 8      | Random |  31.12 ns |   4.916 ns |   4.358 ns |  32.79 ns |  0.80 |    0.16 |         - |          NA |
|                  |        |        |           |            |            |           |       |         |           |             |
| **ArraySort**        | **16**     | **Random** |  **65.74 ns** |   **6.802 ns** |   **5.310 ns** |  **66.27 ns** |  **1.01** |    **0.11** |         **-** |          **NA** |
| NetworkSort      | 16     | Random |  86.25 ns |   6.736 ns |   5.625 ns |  87.00 ns |  1.32 |    0.14 |         - |          NA |
| SpanSort         | 16     | Random |  67.39 ns |   6.843 ns |   5.342 ns |  69.94 ns |  1.03 |    0.12 |         - |          NA |
| NetworkSort_Span | 16     | Random |  77.58 ns |   3.278 ns |   2.737 ns |  78.62 ns |  1.19 |    0.10 |         - |          NA |
| GeneratedSort    | 16     | Random |  55.46 ns |   5.838 ns |   5.175 ns |  56.44 ns |  0.85 |    0.10 |         - |          NA |
|                  |        |        |           |            |            |           |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **100.30 ns** |   **4.459 ns** |   **3.953 ns** | **100.96 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  51.83 ns |   4.707 ns |   3.675 ns |  51.88 ns |  0.52 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 165.90 ns |  97.844 ns |  86.737 ns | 109.88 ns |  1.66 |    0.84 |         - |          NA |
| NetworkSort_Span | 27     | Random |  49.40 ns |   3.926 ns |   3.480 ns |  50.29 ns |  0.49 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random | 162.68 ns | 133.014 ns | 117.913 ns | 104.54 ns |  1.62 |    1.14 |         - |          NA |
|                  |        |        |           |            |            |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **221.24 ns** | **180.802 ns** | **160.277 ns** | **132.62 ns** |  **1.37** |    **1.16** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  56.39 ns |  12.309 ns |  10.278 ns |  56.58 ns |  0.35 |    0.15 |         - |          NA |
| SpanSort         | 28     | Random | 123.54 ns |   5.947 ns |   4.966 ns | 123.75 ns |  0.76 |    0.30 |         - |          NA |
| NetworkSort_Span | 28     | Random |  50.33 ns |   5.559 ns |   4.340 ns |  51.92 ns |  0.31 |    0.13 |         - |          NA |
| GeneratedSort    | 28     | Random | 105.80 ns |   7.121 ns |   6.312 ns | 104.98 ns |  0.65 |    0.26 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error       | StdDev      | Median     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|------------:|------------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,510.9 ns** |    **82.44 ns** |    **64.37 ns** | **1,507.8 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   208.3 ns |   173.52 ns |   153.82 ns |   118.0 ns |  0.14 |    0.10 |         - |          NA |
| SpanSort         | 27     | Random | 2,883.7 ns | 1,943.14 ns | 1,817.62 ns | 1,619.9 ns |  1.91 |    1.17 |         - |          NA |
| NetworkSort_Span | 27     | Random |   115.4 ns |     6.32 ns |     5.28 ns |   115.2 ns |  0.08 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   108.2 ns |     4.81 ns |     4.02 ns |   106.2 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |            |             |             |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,768.2 ns** |   **200.10 ns** |   **167.09 ns** | **1,717.6 ns** |  **1.01** |    **0.12** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   118.7 ns |     5.84 ns |     4.56 ns |   118.1 ns |  0.07 |    0.01 |         - |          NA |
| SpanSort         | 28     | Random | 1,706.3 ns |    71.32 ns |    59.56 ns | 1,715.4 ns |  0.97 |    0.08 |         - |          NA |
| NetworkSort_Span | 28     | Random |   121.1 ns |    17.93 ns |    14.00 ns |   117.2 ns |  0.07 |    0.01 |         - |          NA |
| GeneratedSort    | 28     | Random |   116.0 ns |     8.22 ns |     6.42 ns |   115.4 ns |  0.07 |    0.01 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,590.35 ns** | **263.436 ns** | **219.981 ns** |  **1.01** |    **0.18** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    80.69 ns |   4.714 ns |   4.179 ns |  0.05 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,485.91 ns |  27.272 ns |  22.773 ns |  0.95 |    0.11 |         - |          NA |
| NetworkSort_Span | 27     | Random |    78.82 ns |   5.659 ns |   4.726 ns |  0.05 |    0.01 |         - |          NA |
| GeneratedSort    | 27     | Random |   117.70 ns |  23.203 ns |  18.116 ns |  0.08 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,714.48 ns** |  **61.469 ns** |  **51.329 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    81.24 ns |   6.143 ns |   5.446 ns |  0.05 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,675.39 ns |  61.505 ns |  51.359 ns |  0.98 |    0.04 |         - |          NA |
| NetworkSort_Span | 28     | Random |    85.06 ns |  16.023 ns |  13.380 ns |  0.05 |    0.01 |         - |          NA |
| GeneratedSort    | 28     | Random |   114.88 ns |   5.774 ns |   4.822 ns |  0.07 |    0.00 |         - |          NA |

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
| Method           | Length | Kind       | Mean      | Error      | StdDev    | Median    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |----------- |----------:|-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random**     | **102.62 ns** |   **4.336 ns** |  **3.385 ns** | **103.12 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Random     |  81.03 ns |   4.491 ns |  3.981 ns |  81.77 ns |  0.79 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random     | 109.20 ns |   4.913 ns |  4.355 ns | 110.38 ns |  1.07 |    0.05 |         - |          NA |
| NetworkSort_Span | 27     | Random     |  77.54 ns |   7.590 ns |  6.338 ns |  77.00 ns |  0.76 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Random     | 103.68 ns |   4.721 ns |  3.943 ns | 105.46 ns |  1.01 |    0.05 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Sorted**     |  **56.29 ns** |   **2.189 ns** |  **1.940 ns** |  **55.52 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 27     | Sorted     |  31.23 ns |   4.320 ns |  3.607 ns |  30.75 ns |  0.56 |    0.06 |         - |          NA |
| SpanSort         | 27     | Sorted     |  67.91 ns |   7.060 ns |  5.896 ns |  67.88 ns |  1.21 |    0.11 |         - |          NA |
| NetworkSort_Span | 27     | Sorted     |  33.33 ns |   4.891 ns |  4.084 ns |  33.96 ns |  0.59 |    0.07 |         - |          NA |
| GeneratedSort    | 27     | Sorted     |  86.03 ns |   5.019 ns |  4.449 ns |  86.67 ns |  1.53 |    0.09 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Reversed**   |  **64.24 ns** |   **4.956 ns** |  **4.394 ns** |  **65.54 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 27     | Reversed   |  85.00 ns |   7.302 ns |  5.701 ns |  86.08 ns |  1.33 |    0.13 |         - |          NA |
| SpanSort         | 27     | Reversed   |  77.62 ns |   7.595 ns |  6.342 ns |  76.58 ns |  1.21 |    0.13 |         - |          NA |
| NetworkSort_Span | 27     | Reversed   |  77.40 ns |   6.548 ns |  5.112 ns |  77.94 ns |  1.21 |    0.12 |         - |          NA |
| GeneratedSort    | 27     | Reversed   | 101.57 ns |   5.653 ns |  4.414 ns | 101.12 ns |  1.59 |    0.13 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **27**     | **Duplicates** | **102.64 ns** |   **5.044 ns** |  **4.471 ns** | **103.90 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 27     | Duplicates | 169.12 ns |  85.862 ns | 76.114 ns | 215.58 ns |  1.65 |    0.72 |         - |          NA |
| SpanSort         | 27     | Duplicates | 114.71 ns |   6.597 ns |  5.848 ns | 115.27 ns |  1.12 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Duplicates |  79.91 ns |   5.636 ns |  4.400 ns |  80.73 ns |  0.78 |    0.05 |         - |          NA |
| GeneratedSort    | 27     | Duplicates |  84.97 ns |   4.199 ns |  3.722 ns |  86.19 ns |  0.83 |    0.05 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random**     | **127.09 ns** |   **7.614 ns** |  **6.750 ns** | **125.89 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Random     |  80.28 ns |   5.152 ns |  4.022 ns |  81.15 ns |  0.63 |    0.04 |         - |          NA |
| SpanSort         | 28     | Random     | 131.36 ns |   7.236 ns |  5.649 ns | 131.38 ns |  1.04 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Random     |  75.03 ns |   4.794 ns |  4.249 ns |  76.40 ns |  0.59 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random     | 105.77 ns |   6.050 ns |  5.363 ns | 105.94 ns |  0.83 |    0.06 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Sorted**     |  **60.10 ns** |   **3.654 ns** |  **3.051 ns** |  **60.12 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Sorted     |  40.38 ns |  27.987 ns | 23.370 ns |  32.29 ns |  0.67 |    0.38 |         - |          NA |
| SpanSort         | 28     | Sorted     |  66.07 ns |   7.509 ns |  5.862 ns |  67.12 ns |  1.10 |    0.11 |         - |          NA |
| NetworkSort_Span | 28     | Sorted     |  52.98 ns |  27.474 ns | 24.355 ns |  40.04 ns |  0.88 |    0.40 |         - |          NA |
| GeneratedSort    | 28     | Sorted     | 113.30 ns |  54.846 ns | 45.799 ns |  90.04 ns |  1.89 |    0.74 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Reversed**   |  **65.14 ns** |   **5.763 ns** |  **4.499 ns** |  **66.44 ns** |  **1.00** |    **0.10** |         **-** |          **NA** |
| NetworkSort      | 28     | Reversed   |  81.59 ns |   5.681 ns |  4.743 ns |  81.29 ns |  1.26 |    0.12 |         - |          NA |
| SpanSort         | 28     | Reversed   |  73.95 ns |   5.665 ns |  4.731 ns |  75.00 ns |  1.14 |    0.11 |         - |          NA |
| NetworkSort_Span | 28     | Reversed   |  76.13 ns |   5.814 ns |  4.855 ns |  77.42 ns |  1.17 |    0.11 |         - |          NA |
| GeneratedSort    | 28     | Reversed   |  98.17 ns |   4.997 ns |  4.430 ns |  99.52 ns |  1.51 |    0.13 |         - |          NA |
|                  |        |            |           |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Duplicates** | **172.57 ns** | **104.408 ns** | **97.664 ns** | **112.40 ns** |  **1.25** |    **0.87** |         **-** |          **NA** |
| NetworkSort      | 28     | Duplicates |  83.26 ns |   6.288 ns |  4.909 ns |  82.77 ns |  0.60 |    0.23 |         - |          NA |
| SpanSort         | 28     | Duplicates | 117.39 ns |   4.639 ns |  4.112 ns | 117.96 ns |  0.85 |    0.32 |         - |          NA |
| NetworkSort_Span | 28     | Duplicates |  77.96 ns |   6.077 ns |  5.074 ns |  79.54 ns |  0.57 |    0.22 |         - |          NA |
| GeneratedSort    | 28     | Duplicates |  86.60 ns |   4.505 ns |  3.993 ns |  87.58 ns |  0.63 |    0.24 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Median     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,208.0 ns** |  **27.05 ns** |  **23.98 ns** | **1,200.9 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   108.9 ns |   3.91 ns |   3.06 ns |   109.1 ns |  0.09 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,202.4 ns |  31.34 ns |  26.17 ns | 1,199.7 ns |  1.00 |    0.03 |         - |          NA |
| NetworkSort_Span | 27     | Random |   105.4 ns |   4.81 ns |   4.26 ns |   106.1 ns |  0.09 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   104.7 ns |   5.97 ns |   5.29 ns |   105.6 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |            |           |           |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,401.4 ns** |  **50.17 ns** |  **41.90 ns** | **1,394.5 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   109.1 ns |   5.66 ns |   4.72 ns |   111.1 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,403.7 ns |  77.74 ns |  64.91 ns | 1,385.7 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   109.6 ns |   6.61 ns |   5.52 ns |   109.5 ns |  0.08 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   171.3 ns | 139.26 ns | 123.45 ns |   109.2 ns |  0.12 |    0.09 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **1,203.7 ns** | **38.58 ns** | **34.20 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   108.1 ns |  6.72 ns |  5.24 ns |  0.09 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,197.4 ns | 36.47 ns | 32.33 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |   105.2 ns |  4.66 ns |  3.89 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |            |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,362.0 ns** | **51.43 ns** | **45.60 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   110.6 ns |  5.17 ns |  4.59 ns |  0.08 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,362.7 ns | 56.45 ns | 47.14 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |   111.7 ns | 10.84 ns |  9.61 ns |  0.08 |    0.01 |         - |          NA |

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
| Method           | Length | Kind   | Mean       | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |-----------:|----------:|----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,218.1 ns** |  **34.38 ns** |  **30.48 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |   113.0 ns |   9.38 ns |   7.83 ns |  0.09 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,398.6 ns | 251.62 ns | 223.06 ns |  1.15 |    0.18 |         - |          NA |
| NetworkSort_Span | 27     | Random |   107.2 ns |   4.83 ns |   4.28 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |            |           |           |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,415.5 ns** |  **47.95 ns** |  **40.04 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |   115.9 ns |   8.72 ns |   7.28 ns |  0.08 |    0.01 |         - |          NA |
| SpanSort         | 28     | Random | 2,001.3 ns | 736.65 ns | 615.14 ns |  1.41 |    0.42 |         - |          NA |
| NetworkSort_Span | 28     | Random |   112.3 ns |   5.04 ns |   3.94 ns |  0.08 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean        | Error        | StdDev     | Median      | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-------------:|-----------:|------------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **1,234.41 ns** |    **38.083 ns** |  **29.733 ns** | **1,239.48 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    44.87 ns |    20.699 ns |  16.161 ns |    37.29 ns |  0.04 |    0.01 |         - |          NA |
| SpanSort         | 27     | Random | 1,231.46 ns |    43.392 ns |  33.878 ns | 1,227.04 ns |  1.00 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random |    53.57 ns |    40.301 ns |  35.726 ns |    34.81 ns |  0.04 |    0.03 |         - |          NA |
| GeneratedSort    | 27     | Random |   105.52 ns |     5.560 ns |   4.643 ns |   105.25 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |             |              |            |             |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,376.84 ns** |    **52.715 ns** |  **44.019 ns** | **1,366.71 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    34.49 ns |     4.948 ns |   3.863 ns |    36.38 ns |  0.03 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 2,523.63 ns | 1,086.306 ns | 962.982 ns | 2,349.65 ns |  1.83 |    0.68 |         - |          NA |
| NetworkSort_Span | 28     | Random |    32.56 ns |     3.580 ns |   3.174 ns |    33.48 ns |  0.02 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   107.44 ns |     5.473 ns |   4.273 ns |   108.31 ns |  0.08 |    0.00 |         - |          NA |

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
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **247.12 ns** |  **12.587 ns** |   **9.827 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   265.09 ns |  13.672 ns |  10.674 ns |  1.07 |    0.06 |         - |          NA |
| SpanSort         | 8      | Random |   250.68 ns |  12.065 ns |  10.075 ns |  1.02 |    0.05 |         - |          NA |
| NetworkSort_Span | 8      | Random |   254.51 ns |  11.759 ns |  10.424 ns |  1.03 |    0.06 |         - |          NA |
| GeneratedSort    | 8      | Random |    33.87 ns |   5.787 ns |   4.832 ns |  0.14 |    0.02 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **16**     | **Random** |   **859.32 ns** |   **7.843 ns** |   **6.952 ns** |  **1.00** |    **0.01** |         **-** |          **NA** |
| NetworkSort      | 16     | Random |   911.22 ns |  10.416 ns |   9.233 ns |  1.06 |    0.01 |         - |          NA |
| SpanSort         | 16     | Random |   879.50 ns |  17.040 ns |  13.303 ns |  1.02 |    0.02 |         - |          NA |
| NetworkSort_Span | 16     | Random |   883.21 ns |  33.967 ns |  28.364 ns |  1.03 |    0.03 |         - |          NA |
| GeneratedSort    | 16     | Random |    61.92 ns |   3.712 ns |   3.100 ns |  0.07 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **1,222.29 ns** |  **31.367 ns** |  **26.193 ns** |  **1.00** |    **0.03** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    52.47 ns |   3.760 ns |   3.333 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 27     | Random | 1,375.88 ns | 245.349 ns | 217.495 ns |  1.13 |    0.17 |         - |          NA |
| NetworkSort_Span | 27     | Random |    70.33 ns |  29.791 ns |  24.877 ns |  0.06 |    0.02 |         - |          NA |
| GeneratedSort    | 27     | Random |   103.99 ns |   4.650 ns |   4.122 ns |  0.09 |    0.00 |         - |          NA |
|                  |        |        |             |            |            |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,413.77 ns** | **122.928 ns** |  **95.974 ns** |  **1.00** |    **0.09** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    53.62 ns |   5.344 ns |   4.463 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,407.30 ns |  49.374 ns |  41.229 ns |  1.00 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |    53.91 ns |   5.881 ns |   4.911 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   106.23 ns |   5.247 ns |   4.651 ns |  0.08 |    0.01 |         - |          NA |

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
| Method           | Length | Kind   | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **27**     | **Random** | **699.5 ns** | **82.64 ns** | **73.26 ns** |  **1.01** |    **0.14** |      **64 B** |        **1.00** |
| NetworkSort      | 27     | Random | 417.5 ns | 11.34 ns | 10.06 ns |  0.60 |    0.06 |         - |        0.00 |
| SpanSort         | 27     | Random | 644.3 ns | 11.78 ns |  9.84 ns |  0.93 |    0.08 |      64 B |        1.00 |
| NetworkSort_Span | 27     | Random | 423.5 ns |  5.35 ns |  4.74 ns |  0.61 |    0.06 |         - |        0.00 |
|                  |        |        |          |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **714.9 ns** | **13.88 ns** | **10.84 ns** |  **1.00** |    **0.02** |      **64 B** |        **1.00** |
| NetworkSort      | 28     | Random | 449.3 ns | 13.70 ns | 11.44 ns |  0.63 |    0.02 |         - |        0.00 |
| SpanSort         | 28     | Random | 720.6 ns | 16.63 ns | 14.74 ns |  1.01 |    0.02 |      64 B |        1.00 |
| NetworkSort_Span | 28     | Random | 424.0 ns | 14.17 ns | 12.56 ns |  0.59 |    0.02 |         - |        0.00 |

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
| **ArraySort**        | **27**     | **Random** | **115.98 ns** | **6.296 ns** | **5.581 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |  78.58 ns | 5.439 ns | 4.542 ns |  0.68 |    0.05 |         - |          NA |
| SpanSort         | 27     | Random | 111.88 ns | 7.193 ns | 6.006 ns |  0.97 |    0.07 |         - |          NA |
| NetworkSort_Span | 27     | Random |  74.80 ns | 4.332 ns | 3.618 ns |  0.65 |    0.04 |         - |          NA |
| GeneratedSort    | 27     | Random |  97.71 ns | 4.330 ns | 3.838 ns |  0.84 |    0.05 |         - |          NA |
|                  |        |        |           |          |          |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **137.20 ns** | **5.945 ns** | **5.270 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |  76.02 ns | 4.963 ns | 3.875 ns |  0.55 |    0.03 |         - |          NA |
| SpanSort         | 28     | Random | 134.86 ns | 6.671 ns | 5.914 ns |  0.98 |    0.06 |         - |          NA |
| NetworkSort_Span | 28     | Random |  75.10 ns | 4.713 ns | 4.178 ns |  0.55 |    0.04 |         - |          NA |
| GeneratedSort    | 28     | Random | 106.59 ns | 5.906 ns | 5.236 ns |  0.78 |    0.05 |         - |          NA |

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
| **ArraySort**        | **27**     | **Random** | **124.0 ns** | **3.99 ns** | **3.54 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random | 105.1 ns | 4.21 ns | 3.73 ns |  0.85 |    0.04 |         - |          NA |
| SpanSort         | 27     | Random | 121.5 ns | 4.93 ns | 4.37 ns |  0.98 |    0.04 |         - |          NA |
| NetworkSort_Span | 27     | Random | 105.0 ns | 8.99 ns | 7.51 ns |  0.85 |    0.06 |         - |          NA |
| GeneratedSort    | 27     | Random | 101.0 ns | 5.21 ns | 4.35 ns |  0.82 |    0.04 |         - |          NA |
|                  |        |        |          |         |         |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **139.7 ns** | **7.86 ns** | **6.97 ns** |  **1.00** |    **0.07** |         **-** |          **NA** |
| NetworkSort      | 28     | Random | 113.0 ns | 5.82 ns | 4.86 ns |  0.81 |    0.05 |         - |          NA |
| SpanSort         | 28     | Random | 147.0 ns | 9.59 ns | 7.49 ns |  1.05 |    0.07 |         - |          NA |
| NetworkSort_Span | 28     | Random | 105.7 ns | 6.65 ns | 5.89 ns |  0.76 |    0.05 |         - |          NA |
| GeneratedSort    | 28     | Random | 102.3 ns | 5.81 ns | 5.15 ns |  0.73 |    0.05 |         - |          NA |

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
| Method           | Length | Kind   | Mean        | Error      | StdDev     | Median      | Ratio | RatioSD | Allocated | Alloc Ratio |
|----------------- |------- |------- |------------:|-----------:|-----------:|------------:|------:|--------:|----------:|------------:|
| **ArraySort**        | **8**      | **Random** |   **255.97 ns** |  **11.124 ns** |   **9.861 ns** |   **254.62 ns** |  **1.00** |    **0.05** |         **-** |          **NA** |
| NetworkSort      | 8      | Random |   256.60 ns |  12.396 ns |  10.989 ns |   254.08 ns |  1.00 |    0.06 |         - |          NA |
| SpanSort         | 8      | Random |   251.16 ns |  10.937 ns |   9.133 ns |   248.50 ns |  0.98 |    0.05 |         - |          NA |
| NetworkSort_Span | 8      | Random |   253.25 ns |  12.773 ns |  11.323 ns |   253.38 ns |  0.99 |    0.06 |         - |          NA |
| GeneratedSort    | 8      | Random |    34.14 ns |   4.507 ns |   3.996 ns |    35.31 ns |  0.13 |    0.02 |         - |          NA |
|                  |        |        |             |            |            |             |       |         |           |             |
| **ArraySort**        | **16**     | **Random** |   **920.61 ns** |  **46.498 ns** |  **38.828 ns** |   **912.48 ns** |  **1.00** |    **0.06** |         **-** |          **NA** |
| NetworkSort      | 16     | Random |   912.96 ns |  26.414 ns |  20.622 ns |   908.71 ns |  0.99 |    0.04 |         - |          NA |
| SpanSort         | 16     | Random |   897.23 ns |  41.618 ns |  36.893 ns |   887.25 ns |  0.98 |    0.05 |         - |          NA |
| NetworkSort_Span | 16     | Random |   996.44 ns | 266.265 ns | 222.343 ns |   894.98 ns |  1.08 |    0.24 |         - |          NA |
| GeneratedSort    | 16     | Random |   125.93 ns | 115.807 ns | 102.660 ns |    69.33 ns |  0.14 |    0.11 |         - |          NA |
|                  |        |        |             |            |            |             |       |         |           |             |
| **ArraySort**        | **27**     | **Random** | **1,209.56 ns** |  **37.019 ns** |  **32.816 ns** | **1,211.23 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 27     | Random |    77.72 ns |  40.822 ns |  36.187 ns |    65.17 ns |  0.06 |    0.03 |         - |          NA |
| SpanSort         | 27     | Random | 1,604.15 ns | 702.443 ns | 622.697 ns | 1,282.79 ns |  1.33 |    0.50 |         - |          NA |
| NetworkSort_Span | 27     | Random |    50.98 ns |   4.819 ns |   4.272 ns |    52.31 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 27     | Random |   107.57 ns |   7.849 ns |   6.554 ns |   108.06 ns |  0.09 |    0.01 |         - |          NA |
|                  |        |        |             |            |            |             |       |         |           |             |
| **ArraySort**        | **28**     | **Random** | **1,322.67 ns** |  **46.559 ns** |  **38.879 ns** | **1,315.90 ns** |  **1.00** |    **0.04** |         **-** |          **NA** |
| NetworkSort      | 28     | Random |    53.33 ns |   5.037 ns |   4.206 ns |    53.96 ns |  0.04 |    0.00 |         - |          NA |
| SpanSort         | 28     | Random | 1,323.84 ns |  64.538 ns |  57.211 ns | 1,323.17 ns |  1.00 |    0.05 |         - |          NA |
| NetworkSort_Span | 28     | Random |    50.06 ns |   4.938 ns |   3.855 ns |    52.12 ns |  0.04 |    0.00 |         - |          NA |
| GeneratedSort    | 28     | Random |   111.45 ns |   6.634 ns |   5.540 ns |   111.17 ns |  0.08 |    0.00 |         - |          NA |

