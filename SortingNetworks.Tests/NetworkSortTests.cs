using SortingNetworks;

namespace SortingNetworks.Tests;

public class NetworkSortTests
{

    private static void VerifySort<T>(int length, Func<Random, T> generator, Action<T[]> sort) where T : IComparable<T>
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => generator(rng)).ToArray();
        var expected = (T[])input.Clone();
        Array.Sort(expected);

        var actual = (T[])input.Clone();
        sort(actual);

        Assert.Equal(expected, actual);
    }

    private static void StressSort<T>(int size, Func<Random, T> generator, Action<T[]> sort) where T : IComparable<T>
    {
        for (int seed = 0; seed < 100; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, size).Select(_ => generator(rng)).ToArray();
            var expected = (T[])input.Clone();
            Array.Sort(expected);

            var actual = (T[])input.Clone();
            sort(actual);

            Assert.Equal(expected, actual);
        }
    }



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomInts_MatchesArraySort(int length) =>
        VerifySort(length, rng => rng.Next(-1000, 1000), NetworkSort.Sort);

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Span_RandomInts_MatchesArraySort(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        var actual = (int[])input.Clone();
        NetworkSort.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_WithComparer_RandomInts_MatchesArraySort(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        var actual = (int[])input.Clone();
        NetworkSort.Sort(actual, Comparer<int>.Default);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted(int length)
    {
        var input = Enumerable.Range(0, length).ToArray();
        var expected = (int[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().ToArray();
        var expected = Enumerable.Range(0, length).ToArray();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates(int length)
    {
        var input = Enumerable.Repeat(7, length).ToArray();
        var expected = (int[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_DuplicateHeavy(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 3)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Sort_27Elements_Int() => StressSort(27, rng => rng.Next(-10000, 10000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Int() => StressSort(28, rng => rng.Next(-10000, 10000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Span_WithComparer()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 27).Select(_ => rng.Next(-10000, 10000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            NetworkSort.Sort(input.AsSpan(), Comparer<int>.Default);

            Assert.Equal(expected, input);
        }
    }

    [Fact]
    public void Sort_28Elements_Span_WithComparer()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 28).Select(_ => rng.Next(-10000, 10000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            NetworkSort.Sort(input.AsSpan(), Comparer<int>.Default);

            Assert.Equal(expected, input);
        }
    }

    [Fact]
    public void Sort_NullComparer_UsesDefault()
    {
        var input = new[] { 3, 1, 2 };
        NetworkSort.Sort(input, null);
        Assert.Equal([1, 2, 3], input);
    }

    [Fact]
    public void Sort_FallsBackForLargeArrays()
    {
        var rng = new Random(42);
        var input = Enumerable.Range(0, 100).Select(_ => rng.Next()).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Bytes(int length) =>
        VerifySort(length, rng => (byte)rng.Next(0, 256), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Byte() => StressSort(27, rng => (byte)rng.Next(0, 256), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Byte() => StressSort(28, rng => (byte)rng.Next(0, 256), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_SBytes(int length) =>
        VerifySort(length, rng => (sbyte)rng.Next(-128, 128), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_SByte() => StressSort(27, rng => (sbyte)rng.Next(-128, 128), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_SByte() => StressSort(28, rng => (sbyte)rng.Next(-128, 128), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Shorts(int length) =>
        VerifySort(length, rng => (short)rng.Next(-1000, 1000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Short() => StressSort(27, rng => (short)rng.Next(-1000, 1000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Short() => StressSort(28, rng => (short)rng.Next(-1000, 1000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_UShorts(int length) =>
        VerifySort(length, rng => (ushort)rng.Next(0, 2000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_UShort() => StressSort(27, rng => (ushort)rng.Next(0, 2000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_UShort() => StressSort(28, rng => (ushort)rng.Next(0, 2000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_UInts(int length) =>
        VerifySort(length, rng => (uint)rng.Next(0, 2000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_UInt() => StressSort(27, rng => (uint)rng.Next(0, 2000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_UInt() => StressSort(28, rng => (uint)rng.Next(0, 2000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Longs(int length) =>
        VerifySort(length, rng => (long)rng.Next(-1000, 1000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Long() => StressSort(27, rng => (long)rng.Next(-10000, 10000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Long() => StressSort(28, rng => (long)rng.Next(-10000, 10000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ULongs(int length) =>
        VerifySort(length, rng => (ulong)rng.Next(0, 2000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_ULong() => StressSort(27, rng => (ulong)rng.Next(0, 20000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_ULong() => StressSort(28, rng => (ulong)rng.Next(0, 20000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_NInts(int length) =>
        VerifySort(length, rng => (nint)rng.Next(-1000, 1000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_NInt() => StressSort(27, rng => (nint)rng.Next(-10000, 10000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_NInt() => StressSort(28, rng => (nint)rng.Next(-10000, 10000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_NUInts(int length) =>
        VerifySort(length, rng => (nuint)rng.Next(0, 2000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_NUInt() => StressSort(27, rng => (nuint)rng.Next(0, 20000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_NUInt() => StressSort(28, rng => (nuint)rng.Next(0, 20000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Chars(int length) =>
        VerifySort(length, rng => (char)rng.Next(32, 127), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Char() => StressSort(27, rng => (char)rng.Next(32, 127), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Char() => StressSort(28, rng => (char)rng.Next(32, 127), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Floats(int length) =>
        VerifySort(length, rng => (float)(rng.NextDouble() * 2000 - 1000), NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Float() => StressSort(27, rng => (float)(rng.NextDouble() * 20000 - 10000), NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Float() => StressSort(28, rng => (float)(rng.NextDouble() * 20000 - 10000), NetworkSort.Sort);



    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Doubles(int length) =>
        VerifySort(length, rng => rng.NextDouble() * 2000 - 1000, NetworkSort.Sort);

    [Fact]
    public void Sort_27Elements_Double() => StressSort(27, rng => rng.NextDouble() * 20000 - 10000, NetworkSort.Sort);

    [Fact]
    public void Sort_28Elements_Double() => StressSort(28, rng => rng.NextDouble() * 20000 - 10000, NetworkSort.Sort);

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Strings(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 100).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        var actual = (string[])input.Clone();
        NetworkSort.Sort(actual, StringComparer.Ordinal);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Sort_27Elements_String()
    {
        for (int seed = 0; seed < 100; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 27).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
            var expected = (string[])input.Clone();
            Array.Sort(expected, StringComparer.Ordinal);

            var actual = (string[])input.Clone();
            NetworkSort.Sort(actual, StringComparer.Ordinal);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_28Elements_String()
    {
        for (int seed = 0; seed < 100; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 28).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
            var expected = (string[])input.Clone();
            Array.Sort(expected, StringComparer.Ordinal);

            var actual = (string[])input.Clone();
            NetworkSort.Sort(actual, StringComparer.Ordinal);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_NullArray_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((byte[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((sbyte[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((short[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((ushort[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((int[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((uint[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((long[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((ulong[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((float[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((double[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((char[])null!));
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((string[])null!, StringComparer.Ordinal));
    }

    [Fact]
    public void Sort_NullComparer_Throws_Generic()
    {
        var array = new string[] { "a", "b" };
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort(array, (IComparer<string>)null!));
    }

    [Fact]
    public void Sort_NullComparer_UsesDefault_Primitives()
    {
        var bytes = new byte[] { 3, 1, 2 };
        NetworkSort.Sort(bytes, null);
        Assert.Equal(new byte[] { 1, 2, 3 }, bytes);

        var sbytes = new sbyte[] { 3, 1, 2 };
        NetworkSort.Sort(sbytes, null);
        Assert.Equal(new sbyte[] { 1, 2, 3 }, sbytes);

        var shorts = new short[] { 3, 1, 2 };
        NetworkSort.Sort(shorts, null);
        Assert.Equal(new short[] { 1, 2, 3 }, shorts);

        var ushorts = new ushort[] { 3, 1, 2 };
        NetworkSort.Sort(ushorts, null);
        Assert.Equal(new ushort[] { 1, 2, 3 }, ushorts);

        var ints = new int[] { 3, 1, 2 };
        NetworkSort.Sort(ints, null);
        Assert.Equal(new int[] { 1, 2, 3 }, ints);

        var uints = new uint[] { 3, 1, 2 };
        NetworkSort.Sort(uints, null);
        Assert.Equal(new uint[] { 1, 2, 3 }, uints);

        var longs = new long[] { 3, 1, 2 };
        NetworkSort.Sort(longs, null);
        Assert.Equal(new long[] { 1, 2, 3 }, longs);

        var ulongs = new ulong[] { 3, 1, 2 };
        NetworkSort.Sort(ulongs, null);
        Assert.Equal(new ulong[] { 1, 2, 3 }, ulongs);

        var floats = new float[] { 3, 1, 2 };
        NetworkSort.Sort(floats, null);
        Assert.Equal(new float[] { 1, 2, 3 }, floats);

        var doubles = new double[] { 3, 1, 2 };
        NetworkSort.Sort(doubles, null);
        Assert.Equal(new double[] { 1, 2, 3 }, doubles);

        var chars = new char[] { 'c', 'a', 'b' };
        NetworkSort.Sort(chars, null);
        Assert.Equal(new char[] { 'a', 'b', 'c' }, chars);
    }


    public static TheoryData<int> Lengths
    {
        get
        {
            var data = new TheoryData<int>();
            for (int i = 0; i <= 64; i++)
                data.Add(i);
            return data;
        }
    }
}
