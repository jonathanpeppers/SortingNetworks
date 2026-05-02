using BenchmarkDotNet.Attributes;

namespace SortingNetworks.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(warmupCount: 5, iterationCount: 15)]
public class DoubleSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(23, 24, 25, 26, 27, 28, 29, 30, 31, 32)]
    public int Length { get; set; }

    [Params(InputKind.Random)]
    public InputKind Kind { get; set; }

    private double[] _source = null!;
    private double[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
        _batch = new double[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new double[Length];
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

