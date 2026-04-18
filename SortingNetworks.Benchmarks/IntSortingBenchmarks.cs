using BenchmarkDotNet.Attributes;
using SortingNetworks;

namespace SortingNetworks.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class IntSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    [ParamsAllValues]
    public InputKind Kind { get; set; }

    private int[] _source = null!;
    private int[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Kind switch
        {
            InputKind.Random => Enumerable.Range(0, Length).Select(_ => rng.Next(-1000, 1000)).ToArray(),
            InputKind.Sorted => Enumerable.Range(0, Length).ToArray(),
            InputKind.Reversed => Enumerable.Range(0, Length).Reverse().ToArray(),
            InputKind.Duplicates => Enumerable.Range(0, Length).Select(_ => rng.Next(0, 3)).ToArray(),
            _ => throw new ArgumentOutOfRangeException()
        };
        _batch = new int[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new int[Length];
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
    public void NetworkSort()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            SortingNetworks.NetworkSort.Sort(_batch[i]);
    }
}

