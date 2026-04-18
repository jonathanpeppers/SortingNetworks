using Xunit;
using SortingNetworks;

namespace SortingNetworks.Tests;

public class NetworkSortTests
{
    /// <summary>
    /// Verifies NetworkSort produces the same result as Array.Sort
    /// for random int arrays of lengths 0 through 64.
    /// </summary>
    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomInts_MatchesArraySort(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        var actual = (int[])input.Clone();
        NetworkSort.Sort(actual);

        Assert.Equal(expected, actual);
    }

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
        // All elements are the same value
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
        // Only 3 distinct values to create heavy duplicates
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 3)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Sort_27Elements_UsesSpecializedNetwork()
    {
        // Multiple random seeds to stress the 27-element network
        for (int seed = 0; seed < 100; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 27).Select(_ => rng.Next(-10000, 10000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            NetworkSort.Sort(input);

            Assert.Equal(expected, input);
        }
    }

    [Fact]
    public void Sort_28Elements_UsesSpecializedNetwork()
    {
        // Multiple random seeds to stress the 28-element network
        for (int seed = 0; seed < 100; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 28).Select(_ => rng.Next(-10000, 10000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            NetworkSort.Sort(input);

            Assert.Equal(expected, input);
        }
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
