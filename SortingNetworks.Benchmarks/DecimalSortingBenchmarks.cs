using BenchmarkDotNet.Attributes;

namespace SortingNetworks.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 5, iterationCount: 15)]
public class DecimalSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(23, 24, 25, 26, 27, 28, 29, 30, 31, 32)]
    public int Length { get; set; }

    [ParamsAllValues]
    public InputKind Kind { get; set; }

    private decimal[] _source = null!;
    private decimal[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Kind switch
        {
            InputKind.Random => Enumerable.Range(0, Length).Select(_ => (decimal)(rng.NextDouble() * 2000 - 1000)).ToArray(),
            InputKind.Sorted => Enumerable.Range(0, Length).Select(i => (decimal)i).ToArray(),
            InputKind.Reversed => Enumerable.Range(0, Length).Reverse().Select(i => (decimal)i).ToArray(),
            InputKind.Duplicates => Enumerable.Range(0, Length).Select(_ => (decimal)rng.Next(0, 3)).ToArray(),
            _ => throw new ArgumentOutOfRangeException()
        };
        _batch = new decimal[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new decimal[Length];
    }

    [IterationSetup]
    public void IterationSetup()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            Array.Copy(_source, _batch[i], Length);
    }

    [Benchmark(Baseline = true, OperationsPerInvoke = OpsPerInvoke)]
    public void ArraySort()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            Array.Sort(_batch[i]);
    }

    [Benchmark(OperationsPerInvoke = OpsPerInvoke)]
    public void SpanSort()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i].AsSpan().Sort();
    }

    [Benchmark(OperationsPerInvoke = OpsPerInvoke)]
    public void GeneratedSort()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            GeneratedSorters.Sort(_batch[i].AsSpan());
    }
}
