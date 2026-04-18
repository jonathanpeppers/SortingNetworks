using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(SortingNetworks.Benchmarks.SortingBenchmarks).Assembly).Run(args);
