using SortingNetworks;

namespace SortingNetworks.Tests;

public class GeneratedSortTests
{
    private static void VerifyGeneratedSort(int size)
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, size).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            GeneratedSorters.Sort(actual);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort4_MatchesArraySort() => VerifyGeneratedSort(4);

    [Fact]
    public void Sort8_MatchesArraySort() => VerifyGeneratedSort(8);

    [Fact]
    public void Sort16_MatchesArraySort() => VerifyGeneratedSort(16);

    [Fact]
    public void Sort27_MatchesArraySort() => VerifyGeneratedSort(27);

    [Fact]
    public void Sort28_MatchesArraySort() => VerifyGeneratedSort(28);

    [Fact]
    public void Sort32_MatchesArraySort() => VerifyGeneratedSort(32);

    [Fact]
    public void Sort48_MatchesArraySort() => VerifyGeneratedSort(48);

    [Fact]
    public void Sort64_MatchesArraySort() => VerifyGeneratedSort(64);

    [Fact]
    public void Sort16_Double_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
            var expected = (double[])input.Clone();
            Array.Sort(expected);

            var actual = (double[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Theory]
    [InlineData(27)]
    [InlineData(28)]
    public void Sort_Double_MatchesArraySort(int size)
    {
        for (int seed = 0; seed < 100; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, size).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
            var expected = (double[])input.Clone();
            Array.Sort(expected);

            var actual = (double[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort16_Byte_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = new byte[16];
            rng.NextBytes(input);
            var expected = (byte[])input.Clone();
            Array.Sort(expected);

            var actual = (byte[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort16_Long_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.NextInt64(-10000, 10000)).ToArray();
            var expected = (long[])input.Clone();
            Array.Sort(expected);

            var actual = (long[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_ThrowsOnWrongSize()
    {
        var arr = new int[5];
        Assert.Throws<ArgumentException>(() => GeneratedSorters.Sort(arr));
    }

    [Fact]
    public void Sort_NullArray_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => GeneratedSorters.Sort((int[])null!));
    }

    [Fact]
    public void Sort_ArrayOverload_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            GeneratedSorters.Sort(input);

            Assert.Equal(expected, input);
        }
    }

    [Fact]
    public void Sort8_UShort_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 8).Select(_ => (ushort)rng.Next(0, 65536)).ToArray();
            var expected = (ushort[])input.Clone();
            Array.Sort(expected);

            var actual = (ushort[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort16_UShort_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => (ushort)rng.Next(0, 65536)).ToArray();
            var expected = (ushort[])input.Clone();
            Array.Sort(expected);

            var actual = (ushort[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort8_Short_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 8).Select(_ => (short)rng.Next(-32768, 32768)).ToArray();
            var expected = (short[])input.Clone();
            Array.Sort(expected);

            var actual = (short[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort16_Short_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => (short)rng.Next(-32768, 32768)).ToArray();
            var expected = (short[])input.Clone();
            Array.Sort(expected);

            var actual = (short[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort12_UShort_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 12).Select(_ => (ushort)rng.Next(0, 65536)).ToArray();
            var expected = (ushort[])input.Clone();
            Array.Sort(expected);

            var actual = (ushort[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort12_Short_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 12).Select(_ => (short)rng.Next(-32768, 32768)).ToArray();
            var expected = (short[])input.Clone();
            Array.Sort(expected);

            var actual = (short[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort16_NInt_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => (nint)rng.Next(-10000, 10000)).ToArray();
            var expected = (nint[])input.Clone();
            Array.Sort(expected);

            var actual = (nint[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort16_NUInt_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => (nuint)rng.Next(0, 20000)).ToArray();
            var expected = (nuint[])input.Clone();
            Array.Sort(expected);

            var actual = (nuint[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }
}
