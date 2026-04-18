using BenchmarkDotNet.Running;

BenchmarkSwitcher.FromAssembly(typeof(SortingNetworks.Benchmarks.IntSortingBenchmarks).Assembly).Run(args);
