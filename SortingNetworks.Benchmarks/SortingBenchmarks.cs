using BenchmarkDotNet.Attributes;
using SortingNetworks;

namespace SortingNetworks.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class SortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(2, 4, 8, 16, 27, 28)]
    public int Length { get; set; }

    [ParamsAllValues]
    public InputKind Kind { get; set; }

    private int[] _source = null!;
    private int[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        _source = Kind switch
        {
            InputKind.Random => GenerateRandom(Length, seed: 42),
            InputKind.Sorted => Enumerable.Range(0, Length).ToArray(),
            InputKind.Reversed => Enumerable.Range(0, Length).Reverse().ToArray(),
            InputKind.Duplicates => GenerateDuplicates(Length, seed: 42),
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
    public void SpanSort()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i].AsSpan().Sort();
    }

    [Benchmark(OperationsPerInvoke = OpsPerInvoke)]
    public void NetworkSort_Array()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i]);
    }

    [Benchmark(OperationsPerInvoke = OpsPerInvoke)]
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }

    private static int[] GenerateRandom(int length, int seed)
    {
        var rng = new Random(seed);
        return Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
    }

    private static int[] GenerateDuplicates(int length, int seed)
    {
        var rng = new Random(seed);
        return Enumerable.Range(0, length).Select(_ => rng.Next(0, 3)).ToArray();
    }
}

public enum InputKind
{
    Random,
    Sorted,
    Reversed,
    Duplicates
}
