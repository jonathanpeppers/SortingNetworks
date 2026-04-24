using SortingNetworks;

namespace SortingNetworks.Tests;

public class GeneratedSortTests
{
    private static void VerifyGeneratedSort(int size, Action<int[]> sort)
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, size).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            sort(actual);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort4_MatchesArraySort() =>
        VerifyGeneratedSort(4, a => GeneratedSorters.Sort4(a));

    [Fact]
    public void Sort8_MatchesArraySort() =>
        VerifyGeneratedSort(8, a => GeneratedSorters.Sort8(a));

    [Fact]
    public void Sort16_MatchesArraySort() =>
        VerifyGeneratedSort(16, a => GeneratedSorters.Sort16(a));

    [Fact]
    public void Sort27_MatchesArraySort() =>
        VerifyGeneratedSort(27, a => GeneratedSorters.Sort27(a));

    [Fact]
    public void Sort28_MatchesArraySort() =>
        VerifyGeneratedSort(28, a => GeneratedSorters.Sort28(a));

    [Fact]
    public void Sort32_MatchesArraySort() =>
        VerifyGeneratedSort(32, a => GeneratedSorters.Sort32(a));

    [Fact]
    public void Sort48_MatchesArraySort() =>
        VerifyGeneratedSort(48, a => GeneratedSorters.Sort48(a));

    [Fact]
    public void Sort64_MatchesArraySort() =>
        VerifyGeneratedSort(64, a => GeneratedSorters.Sort64(a));

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
            GeneratedSorters.Sort16(actual.AsSpan());

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
            GeneratedSorters.Sort16(actual.AsSpan());

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
            GeneratedSorters.Sort16(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_ThrowsOnWrongSize()
    {
        var arr = new int[5];
        Assert.Throws<ArgumentException>(() => GeneratedSorters.Sort4(arr));
    }
}
