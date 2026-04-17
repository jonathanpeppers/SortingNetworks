using BenchmarkDotNet.Attributes;
using SortingNetworks;

namespace SortingNetworks.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class SortingBenchmarks
{
    [Params(2, 4, 8, 16, 27, 28, 32, 64)]
    public int Length { get; set; }

    [ParamsAllValues]
    public InputKind Kind { get; set; }

    private int[] _source = null!;

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
    }

    [Benchmark(Baseline = true)]
    public void ArraySort()
    {
        var data = (int[])_source.Clone();
        Array.Sort(data);
    }

    [Benchmark]
    public void SpanSort()
    {
        var data = (int[])_source.Clone();
        data.AsSpan().Sort();
    }

    [Benchmark]
    public void NetworkSort_Array()
    {
        var data = (int[])_source.Clone();
        NetworkSort.Sort(data);
    }

    [Benchmark]
    public void NetworkSort_Span()
    {
        var data = (int[])_source.Clone();
        NetworkSort.Sort(data.AsSpan());
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
