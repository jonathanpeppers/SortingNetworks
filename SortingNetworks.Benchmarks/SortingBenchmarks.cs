using BenchmarkDotNet.Attributes;
using SortingNetworks;

namespace SortingNetworks.Benchmarks;

#region int

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
}

#endregion

#region byte

[MemoryDiagnoser]
[ShortRunJob]
public class ByteSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private byte[] _source = null!;
    private byte[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (byte)rng.Next(0, 256)).ToArray();
        _batch = new byte[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new byte[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region sbyte

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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region short

[MemoryDiagnoser]
[ShortRunJob]
public class ShortSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private short[] _source = null!;
    private short[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (short)rng.Next(-1000, 1000)).ToArray();
        _batch = new short[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new short[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region ushort

[MemoryDiagnoser]
[ShortRunJob]
public class UShortSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private ushort[] _source = null!;
    private ushort[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (ushort)rng.Next(0, 2000)).ToArray();
        _batch = new ushort[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new ushort[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region uint

[MemoryDiagnoser]
[ShortRunJob]
public class UIntSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private uint[] _source = null!;
    private uint[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (uint)rng.Next(0, 2000)).ToArray();
        _batch = new uint[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new uint[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region long

[MemoryDiagnoser]
[ShortRunJob]
public class LongSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private long[] _source = null!;
    private long[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (long)rng.Next(-1000, 1000)).ToArray();
        _batch = new long[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new long[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region ulong

[MemoryDiagnoser]
[ShortRunJob]
public class ULongSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private ulong[] _source = null!;
    private ulong[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (ulong)rng.Next(0, 2000)).ToArray();
        _batch = new ulong[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new ulong[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region nint

[MemoryDiagnoser]
[ShortRunJob]
public class NIntSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private nint[] _source = null!;
    private nint[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (nint)rng.Next(-1000, 1000)).ToArray();
        _batch = new nint[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new nint[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region nuint

[MemoryDiagnoser]
[ShortRunJob]
public class NUIntSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private nuint[] _source = null!;
    private nuint[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (nuint)rng.Next(0, 2000)).ToArray();
        _batch = new nuint[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new nuint[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region char

[MemoryDiagnoser]
[ShortRunJob]
public class CharSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private char[] _source = null!;
    private char[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (char)rng.Next(32, 127)).ToArray();
        _batch = new char[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new char[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region float

[MemoryDiagnoser]
[ShortRunJob]
public class FloatSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

    private float[] _source = null!;
    private float[][] _batch = null!;

    [GlobalSetup]
    public void Setup()
    {
        var rng = new Random(42);
        _source = Enumerable.Range(0, Length).Select(_ => (float)(rng.NextDouble() * 2000 - 1000)).ToArray();
        _batch = new float[OpsPerInvoke][];
        for (int i = 0; i < OpsPerInvoke; i++)
            _batch[i] = new float[Length];
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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

#region double

[MemoryDiagnoser]
[ShortRunJob]
public class DoubleSortingBenchmarks
{
    private const int OpsPerInvoke = 1000;

    [Params(27, 28)]
    public int Length { get; set; }

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
    public void NetworkSort_Span()
    {
        for (int i = 0; i < OpsPerInvoke; i++)
            NetworkSort.Sort(_batch[i].AsSpan());
    }
}

#endregion

public enum InputKind
{
    Random,
    Sorted,
    Reversed,
    Duplicates
}
