using SortingNetworks;

namespace SortingNetworks.Tests;

public class HybridSortTests
{
    // --- Sort: various sizes ---

    private static void VerifyHybridSort(int size)
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, size).Select(_ => rng.Next(-10000, 10000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            HybridSorter.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact] public void Sort_2Elements() => VerifyHybridSort(2);
    [Fact] public void Sort_3Elements() => VerifyHybridSort(3);
    [Fact] public void Sort_10Elements() => VerifyHybridSort(10);
    [Fact] public void Sort_27Elements() => VerifyHybridSort(27);
    [Fact] public void Sort_64Elements() => VerifyHybridSort(64);
    [Fact] public void Sort_100Elements() => VerifyHybridSort(100);
    [Fact] public void Sort_256Elements() => VerifyHybridSort(256);
    [Fact] public void Sort_1000Elements() => VerifyHybridSort(1000);
    [Fact] public void Sort_10000Elements() => VerifyHybridSort(10000);

    // --- Sort: edge cases ---

    [Fact]
    public void Sort_Empty()
    {
        var span = Span<int>.Empty;
        HybridSorter.Sort(span); // Should not throw
    }

    [Fact]
    public void Sort_SingleElement()
    {
        var data = new int[] { 42 };
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(42, data[0]);
    }

    [Fact]
    public void Sort_AlreadySorted()
    {
        var data = Enumerable.Range(0, 200).ToArray();
        var expected = (int[])data.Clone();
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_ReverseSorted()
    {
        var data = Enumerable.Range(0, 200).Reverse().ToArray();
        var expected = Enumerable.Range(0, 200).ToArray();
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_AllDuplicates()
    {
        var data = Enumerable.Repeat(7, 200).ToArray();
        var expected = (int[])data.Clone();
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_DuplicateHeavy()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 500).Select(_ => rng.Next(0, 5)).ToArray();
        var expected = (int[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_NullArray_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => HybridSorter.Sort((int[])null!));
    }

    // --- Sort: multiple types ---

    [Fact]
    public void Sort_Byte_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (byte)rng.Next(0, 256)).ToArray();
        var expected = (byte[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_Short_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (short)rng.Next(-10000, 10000)).ToArray();
        var expected = (short[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_Long_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (long)rng.Next(-10000, 10000)).ToArray();
        var expected = (long[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_Float_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (float)(rng.NextDouble() * 2000 - 1000)).ToArray();
        var expected = (float[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_Double_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
        var expected = (double[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_SByte_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (sbyte)rng.Next(-128, 128)).ToArray();
        var expected = (sbyte[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_UShort_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (ushort)rng.Next(0, 65536)).ToArray();
        var expected = (ushort[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_UInt_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (uint)rng.Next(0, int.MaxValue)).ToArray();
        var expected = (uint[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_ULong_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (ulong)rng.Next(0, int.MaxValue)).ToArray();
        var expected = (ulong[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    [Fact]
    public void Sort_Char_200Elements()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 200).Select(_ => (char)rng.Next('A', 'z')).ToArray();
        var expected = (char[])data.Clone();
        Array.Sort(expected);
        HybridSorter.Sort(data.AsSpan());
        Assert.Equal(expected, data);
    }

    // --- Stress test ---

    [Fact]
    public void Sort_Stress_Int_Various_Sizes()
    {
        foreach (int size in new[] { 65, 100, 128, 200, 500, 1000 })
        {
            for (int seed = 0; seed < 20; seed++)
            {
                var rng = new Random(seed + size);
                var data = Enumerable.Range(0, size).Select(_ => rng.Next(-10000, 10000)).ToArray();
                var expected = (int[])data.Clone();
                Array.Sort(expected);
                HybridSorter.Sort(data.AsSpan());
                Assert.Equal(expected, data);
            }
        }
    }

    // --- PartialSort tests ---

    [Fact]
    public void PartialSort_Top10()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 1000).Select(_ => rng.Next(-10000, 10000)).ToArray();
        var expected = (int[])data.Clone();
        Array.Sort(expected);

        HybridSorter.PartialSort(data.AsSpan(), 10);

        // First 10 elements should match the 10 smallest sorted elements
        Assert.Equal(expected.Take(10), data.Take(10));
    }

    [Fact]
    public void PartialSort_K_Equals_Length()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 100).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])data.Clone();
        Array.Sort(expected);

        HybridSorter.PartialSort(data.AsSpan(), data.Length);
        Assert.Equal(expected, data);
    }

    [Fact]
    public void PartialSort_K_Zero()
    {
        var data = new int[] { 3, 1, 2 };
        HybridSorter.PartialSort(data.AsSpan(), 0); // Should not throw
    }

    [Fact]
    public void PartialSort_K_One()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 100).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])data.Clone();
        Array.Sort(expected);

        HybridSorter.PartialSort(data.AsSpan(), 1);
        Assert.Equal(expected[0], data[0]);
    }

    [Fact]
    public void PartialSort_InvalidK_Throws()
    {
        var data = new int[] { 3, 1, 2 };
        Assert.Throws<ArgumentOutOfRangeException>(() => HybridSorter.PartialSort(data.AsSpan(), -1));
        Assert.Throws<ArgumentOutOfRangeException>(() => HybridSorter.PartialSort(data.AsSpan(), 4));
    }

    // --- NthElement tests ---

    [Fact]
    public void NthElement_Median()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 101).Select(_ => rng.Next(-10000, 10000)).ToArray();
        var sorted = (int[])data.Clone();
        Array.Sort(sorted);

        HybridSorter.NthElement(data.AsSpan(), 50);
        Assert.Equal(sorted[50], data[50]);
    }

    [Fact]
    public void NthElement_First()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 100).Select(_ => rng.Next(-10000, 10000)).ToArray();
        var sorted = (int[])data.Clone();
        Array.Sort(sorted);

        HybridSorter.NthElement(data.AsSpan(), 0);
        Assert.Equal(sorted[0], data[0]);
    }

    [Fact]
    public void NthElement_Last()
    {
        var rng = new Random(42);
        var data = Enumerable.Range(0, 100).Select(_ => rng.Next(-10000, 10000)).ToArray();
        var sorted = (int[])data.Clone();
        Array.Sort(sorted);

        HybridSorter.NthElement(data.AsSpan(), 99);
        Assert.Equal(sorted[99], data[99]);
    }

    [Fact]
    public void NthElement_InvalidN_Throws()
    {
        var data = new int[] { 3, 1, 2 };
        Assert.Throws<ArgumentOutOfRangeException>(() => HybridSorter.NthElement(data.AsSpan(), -1));
        Assert.Throws<ArgumentOutOfRangeException>(() => HybridSorter.NthElement(data.AsSpan(), 3));
    }
}
