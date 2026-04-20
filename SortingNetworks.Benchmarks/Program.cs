using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;

IConfig? config = null;
if (Environment.GetEnvironmentVariable("DISASSEMBLY_DIAGNOSER") == "1")
{
    config = DefaultConfig.Instance
        .AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(maxDepth: 3)));
}

BenchmarkSwitcher.FromAssembly(typeof(SortingNetworks.Benchmarks.IntSortingBenchmarks).Assembly).Run(args, config);
