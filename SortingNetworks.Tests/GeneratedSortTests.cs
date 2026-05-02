using SortingNetworks;

namespace SortingNetworks.Tests;

public class GeneratedSortTests
{
    public static TheoryData<int> Lengths => new() { 27, 28 };

    // --- Int tests (multiple sizes) ---

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

    // --- Stress tests (100 seeds) for all primitive types at sizes 27 and 28 ---

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

    [Fact]
    public void Sort_27Elements_Int() => StressSort(27, rng => rng.Next(-10000, 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Int() => StressSort(28, rng => rng.Next(-10000, 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_Byte() => StressSort(27, rng => (byte)rng.Next(0, 256), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Byte() => StressSort(28, rng => (byte)rng.Next(0, 256), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_SByte() => StressSort(27, rng => (sbyte)rng.Next(-128, 128), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_SByte() => StressSort(28, rng => (sbyte)rng.Next(-128, 128), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_Short() => StressSort(27, rng => (short)rng.Next(-1000, 1000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Short() => StressSort(28, rng => (short)rng.Next(-1000, 1000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_UShort() => StressSort(27, rng => (ushort)rng.Next(0, 2000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_UShort() => StressSort(28, rng => (ushort)rng.Next(0, 2000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_UInt() => StressSort(27, rng => (uint)rng.Next(0, 2000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_UInt() => StressSort(28, rng => (uint)rng.Next(0, 2000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_Long() => StressSort(27, rng => (long)rng.Next(-10000, 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Long() => StressSort(28, rng => (long)rng.Next(-10000, 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_ULong() => StressSort(27, rng => (ulong)rng.Next(0, 20000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_ULong() => StressSort(28, rng => (ulong)rng.Next(0, 20000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_NInt() => StressSort(27, rng => (nint)rng.Next(-10000, 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_NInt() => StressSort(28, rng => (nint)rng.Next(-10000, 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_NUInt() => StressSort(27, rng => (nuint)rng.Next(0, 20000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_NUInt() => StressSort(28, rng => (nuint)rng.Next(0, 20000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_Char() => StressSort(27, rng => (char)rng.Next(32, 127), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Char() => StressSort(28, rng => (char)rng.Next(32, 127), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_Float() => StressSort(27, rng => (float)(rng.NextDouble() * 20000 - 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Float() => StressSort(28, rng => (float)(rng.NextDouble() * 20000 - 10000), a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_27Elements_Double() => StressSort(27, rng => rng.NextDouble() * 20000 - 10000, a => GeneratedSorters.Sort(a.AsSpan()));

    [Fact]
    public void Sort_28Elements_Double() => StressSort(28, rng => rng.NextDouble() * 20000 - 10000, a => GeneratedSorters.Sort(a.AsSpan()));

    // --- Random data for all types via Span ---

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomInts(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        var actual = (int[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomBytes(int length)
    {
        var rng = new Random(42 + length);
        var input = new byte[length];
        rng.NextBytes(input);
        var expected = (byte[])input.Clone();
        Array.Sort(expected);

        var actual = (byte[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomSBytes(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (sbyte)rng.Next(-128, 128)).ToArray();
        var expected = (sbyte[])input.Clone();
        Array.Sort(expected);

        var actual = (sbyte[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomShorts(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (short)rng.Next(-1000, 1000)).ToArray();
        var expected = (short[])input.Clone();
        Array.Sort(expected);

        var actual = (short[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomUShorts(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (ushort)rng.Next(0, 2000)).ToArray();
        var expected = (ushort[])input.Clone();
        Array.Sort(expected);

        var actual = (ushort[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomUInts(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (uint)rng.Next(0, 2000)).ToArray();
        var expected = (uint[])input.Clone();
        Array.Sort(expected);

        var actual = (uint[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomLongs(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (long)rng.Next(-1000, 1000)).ToArray();
        var expected = (long[])input.Clone();
        Array.Sort(expected);

        var actual = (long[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomULongs(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (ulong)rng.Next(0, 2000)).ToArray();
        var expected = (ulong[])input.Clone();
        Array.Sort(expected);

        var actual = (ulong[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomNInts(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (nint)rng.Next(-1000, 1000)).ToArray();
        var expected = (nint[])input.Clone();
        Array.Sort(expected);

        var actual = (nint[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomNUInts(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (nuint)rng.Next(0, 2000)).ToArray();
        var expected = (nuint[])input.Clone();
        Array.Sort(expected);

        var actual = (nuint[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomChars(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (char)rng.Next(32, 127)).ToArray();
        var expected = (char[])input.Clone();
        Array.Sort(expected);

        var actual = (char[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomFloats(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (float)(rng.NextDouble() * 2000 - 1000)).ToArray();
        var expected = (float[])input.Clone();
        Array.Sort(expected);

        var actual = (float[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_RandomDoubles(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
        var expected = (double[])input.Clone();
        Array.Sort(expected);

        var actual = (double[])input.Clone();
        GeneratedSorters.Sort(actual.AsSpan());

        Assert.Equal(expected, actual);
    }

    // --- Edge cases: already sorted, reversed, duplicates ---

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Int(int length)
    {
        var input = Enumerable.Range(0, length).ToArray();
        var expected = (int[])input.Clone();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Int(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().ToArray();
        var expected = Enumerable.Range(0, length).ToArray();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates_Int(int length)
    {
        var input = Enumerable.Repeat(7, length).ToArray();
        var expected = (int[])input.Clone();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_DuplicateHeavy_Int(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 3)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Bytes(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => (byte)i).ToArray();
        var expected = (byte[])input.Clone();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Bytes(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => (byte)i).ToArray();
        var expected = Enumerable.Range(0, length).Select(i => (byte)i).ToArray();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates_Bytes(int length)
    {
        var input = Enumerable.Repeat((byte)42, length).ToArray();
        var expected = (byte[])input.Clone();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Floats(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => (float)i).ToArray();
        var expected = (float[])input.Clone();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Floats(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => (float)i).ToArray();
        var expected = Enumerable.Range(0, length).Select(i => (float)i).ToArray();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Doubles(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => (double)i).ToArray();
        var expected = (double[])input.Clone();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Doubles(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => (double)i).ToArray();
        var expected = Enumerable.Range(0, length).Select(i => (double)i).ToArray();

        GeneratedSorters.Sort(input.AsSpan());

        Assert.Equal(expected, input);
    }

    // --- Min/Max edge cases ---

    private static T[] BuildMinMaxArray<T>(int length, T minValue, T maxValue, Func<Random, T> generator)
    {
        var rng = new Random(42 + length);
        var input = new T[length];
        input[0] = minValue;
        input[1] = maxValue;
        input[2] = minValue;
        input[3] = maxValue;
        for (int i = 4; i < length; i++)
            input[i] = generator(rng);
        rng = new Random(123 + length);
        for (int i = length - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (input[i], input[j]) = (input[j], input[i]);
        }
        return input;
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_MinMax_Byte(int length)
    {
        var input = BuildMinMaxArray(length, byte.MinValue, byte.MaxValue, rng => (byte)rng.Next(0, 256));
        var expected = (byte[])input.Clone();
        Array.Sort(expected);
        GeneratedSorters.Sort(input.AsSpan());
        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_MinMax_SByte(int length)
    {
        var input = BuildMinMaxArray(length, sbyte.MinValue, sbyte.MaxValue, rng => (sbyte)rng.Next(-128, 128));
        var expected = (sbyte[])input.Clone();
        Array.Sort(expected);
        GeneratedSorters.Sort(input.AsSpan());
        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_MinMax_Short(int length)
    {
        var input = BuildMinMaxArray(length, short.MinValue, short.MaxValue, rng => (short)rng.Next(short.MinValue, short.MaxValue + 1));
        var expected = (short[])input.Clone();
        Array.Sort(expected);
        GeneratedSorters.Sort(input.AsSpan());
        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_MinMax_Int(int length)
    {
        var input = BuildMinMaxArray(length, int.MinValue, int.MaxValue, rng => rng.Next());
        var expected = (int[])input.Clone();
        Array.Sort(expected);
        GeneratedSorters.Sort(input.AsSpan());
        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_MinMax_Float(int length)
    {
        var input = BuildMinMaxArray(length, float.MinValue, float.MaxValue, rng => (float)(rng.NextDouble() * 2e10 - 1e10));
        var expected = (float[])input.Clone();
        Array.Sort(expected);
        GeneratedSorters.Sort(input.AsSpan());
        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Extremes_Double(int length)
    {
        var rng = new Random(42 + length);
        var input = new double[length];
        input[0] = double.MinValue;
        input[1] = double.MaxValue;
        input[2] = double.NegativeInfinity;
        input[3] = double.PositiveInfinity;
        input[4] = double.Epsilon;
        input[5] = -0.0;
        for (int i = 6; i < length; i++)
            input[i] = rng.NextDouble() * 2000 - 1000;
        rng = new Random(123 + length);
        for (int i = length - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (input[i], input[j]) = (input[j], input[i]);
        }
        var expected = (double[])input.Clone();
        Array.Sort(expected);
        GeneratedSorters.Sort(input.AsSpan());
        Assert.Equal(expected, input);
    }

    // --- Null/wrong-size tests ---

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

    // --- Comparer tests ---

    [Fact]
    public void Sort_WithComparer_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan(), Comparer<int>.Default);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_WithComparer_ReverseOrder()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected, Comparer<int>.Create((a, b) => b.CompareTo(a)));

            var actual = (int[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan(), Comparer<int>.Create((a, b) => b.CompareTo(a)));

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_WithComparer_NullComparer_UsesDefault()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan(), null);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort_ArrayWithComparer_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            GeneratedSorters.Sort(input, Comparer<int>.Default);

            Assert.Equal(expected, input);
        }
    }

    [Fact]
    public void Sort_ArrayWithComparer_NullArray_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => GeneratedSorters.Sort((int[])null!, Comparer<int>.Default));
    }

    [Fact]
    public void Sort_WithComparer_WrongSize_Throws()
    {
        var arr = new int[5];
        Assert.Throws<ArgumentException>(() => GeneratedSorters.Sort(arr.AsSpan(), Comparer<int>.Default));
    }

    [Fact]
    public void Sort_ArrayWithComparer_WrongSize_Throws()
    {
        var arr = new int[5];
        Assert.Throws<ArgumentException>(() => GeneratedSorters.Sort(arr, Comparer<int>.Default));
    }

    [Fact]
    public void Sort_ArrayWithComparer_NullComparer_UsesDefault()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 16).Select(_ => rng.Next(-1000, 1000)).ToArray();
            var expected = (int[])input.Clone();
            Array.Sort(expected);

            GeneratedSorters.Sort(input, null);

            Assert.Equal(expected, input);
        }
    }

    // --- Reverse comparer for multiple types ---

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseComparer_Int(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);
        Array.Reverse(expected);

        var comparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
        GeneratedSorters.Sort(input.AsSpan(), comparer);

        Assert.Equal(expected, input);
    }

    // --- String tests ---

    [Fact]
    public void Sort27_String_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 27).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
            var expected = (string[])input.Clone();
            Array.Sort(expected, StringComparer.Ordinal);

            var actual = (string[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan());

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void Sort27_String_WithComparer_MatchesArraySort()
    {
        for (int seed = 0; seed < 50; seed++)
        {
            var rng = new Random(seed);
            var input = Enumerable.Range(0, 27).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
            var expected = (string[])input.Clone();
            Array.Sort(expected, StringComparer.Ordinal);

            var actual = (string[])input.Clone();
            GeneratedSorters.Sort(actual.AsSpan(), StringComparer.Ordinal);

            Assert.Equal(expected, actual);
        }
    }

    // --- Additional type-specific tests ---

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
