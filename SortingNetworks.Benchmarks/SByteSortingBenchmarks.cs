using BenchmarkDotNet.Attributes;
using SortingNetworks;

namespace SortingNetworks.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class SByteSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private sbyte[] _source = null!;
    private sbyte[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (sbyte)rng.Next(-128, 128)).ToArray();
        _batch = new sbyte[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new sbyte[Length];
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
            SortingNetworks.NetworkSort.Sort(_batch[i].AsSpan());
    }
}
