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
        var rng = new Random(42);
        var input = Enumerable.Range(0, 27).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input, null);
        Assert.Equal(expected, input);
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
        NetworkSort.Sort(actual);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Strings_WithComparer(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 100).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        var actual = (string[])input.Clone();
        NetworkSort.Sort(actual, StringComparer.Ordinal);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Span_Strings(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 100).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        var actual = (string[])input.Clone();
        NetworkSort.Sort(actual.AsSpan());

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
            NetworkSort.Sort(actual);

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
            NetworkSort.Sort(actual);

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
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort((string[])null!));
    }

    [Fact]
    public void Sort_NullComparer_Throws_Generic()
    {
        var rng = new Random(42);
        var array = Enumerable.Range(0, 27).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort<string>(array, (IComparer<string>)null!));
    }

    [Fact]
    public void Sort_NullComparer_UsesDefault_String()
    {
        var rng = new Random(42);
        var array = Enumerable.Range(0, 27).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
        var expected = (string[])array.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(array, (IComparer<string>?)null);
        Assert.Equal(expected, array);
    }

    [Fact]
    public void Sort_NullComparer_UsesDefault_Primitives()
    {
        var rng = new Random(42);

        var bytes = Enumerable.Range(0, 27).Select(_ => (byte)rng.Next(0, 256)).ToArray();
        var bytesExpected = (byte[])bytes.Clone();
        Array.Sort(bytesExpected);
        NetworkSort.Sort(bytes, null);
        Assert.Equal(bytesExpected, bytes);

        var sbytes = Enumerable.Range(0, 27).Select(_ => (sbyte)rng.Next(-128, 128)).ToArray();
        var sbytesExpected = (sbyte[])sbytes.Clone();
        Array.Sort(sbytesExpected);
        NetworkSort.Sort(sbytes, null);
        Assert.Equal(sbytesExpected, sbytes);

        var shorts = Enumerable.Range(0, 27).Select(_ => (short)rng.Next(-1000, 1000)).ToArray();
        var shortsExpected = (short[])shorts.Clone();
        Array.Sort(shortsExpected);
        NetworkSort.Sort(shorts, null);
        Assert.Equal(shortsExpected, shorts);

        var ushorts = Enumerable.Range(0, 27).Select(_ => (ushort)rng.Next(0, 2000)).ToArray();
        var ushortsExpected = (ushort[])ushorts.Clone();
        Array.Sort(ushortsExpected);
        NetworkSort.Sort(ushorts, null);
        Assert.Equal(ushortsExpected, ushorts);

        var ints = Enumerable.Range(0, 27).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var intsExpected = (int[])ints.Clone();
        Array.Sort(intsExpected);
        NetworkSort.Sort(ints, null);
        Assert.Equal(intsExpected, ints);

        var uints = Enumerable.Range(0, 27).Select(_ => (uint)rng.Next(0, 2000)).ToArray();
        var uintsExpected = (uint[])uints.Clone();
        Array.Sort(uintsExpected);
        NetworkSort.Sort(uints, null);
        Assert.Equal(uintsExpected, uints);

        var longs = Enumerable.Range(0, 27).Select(_ => (long)rng.Next(-1000, 1000)).ToArray();
        var longsExpected = (long[])longs.Clone();
        Array.Sort(longsExpected);
        NetworkSort.Sort(longs, null);
        Assert.Equal(longsExpected, longs);

        var ulongs = Enumerable.Range(0, 27).Select(_ => (ulong)rng.Next(0, 2000)).ToArray();
        var ulongsExpected = (ulong[])ulongs.Clone();
        Array.Sort(ulongsExpected);
        NetworkSort.Sort(ulongs, null);
        Assert.Equal(ulongsExpected, ulongs);

        var floats = Enumerable.Range(0, 27).Select(_ => (float)(rng.NextDouble() * 2000 - 1000)).ToArray();
        var floatsExpected = (float[])floats.Clone();
        Array.Sort(floatsExpected);
        NetworkSort.Sort(floats, null);
        Assert.Equal(floatsExpected, floats);

        var doubles = Enumerable.Range(0, 27).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
        var doublesExpected = (double[])doubles.Clone();
        Array.Sort(doublesExpected);
        NetworkSort.Sort(doubles, null);
        Assert.Equal(doublesExpected, doubles);

        var chars = Enumerable.Range(0, 27).Select(_ => (char)rng.Next(32, 127)).ToArray();
        var charsExpected = (char[])chars.Clone();
        Array.Sort(charsExpected);
        NetworkSort.Sort(chars, null);
        Assert.Equal(charsExpected, chars);
    }


    [Fact]
    public void Sort_FallsBackForStrings()
    {
        var rng = new Random(42);
        var input = Enumerable.Range(0, 29).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // --- Gap #2: Edge-case patterns for more types ---

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Bytes(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => (byte)i).ToArray();
        var expected = (byte[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Bytes(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => (byte)i).ToArray();
        var expected = Enumerable.Range(0, length).Select(i => (byte)i).ToArray();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates_Bytes(int length)
    {
        var input = Enumerable.Repeat((byte)42, length).ToArray();
        var expected = (byte[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_DuplicateHeavy_Bytes(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (byte)rng.Next(0, 3)).ToArray();
        var expected = (byte[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Floats(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => (float)i).ToArray();
        var expected = (float[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Floats(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => (float)i).ToArray();
        var expected = Enumerable.Range(0, length).Select(i => (float)i).ToArray();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates_Floats(int length)
    {
        var input = Enumerable.Repeat(7.5f, length).ToArray();
        var expected = (float[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_DuplicateHeavy_Floats(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (float)rng.Next(0, 3)).ToArray();
        var expected = (float[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Doubles(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => (double)i).ToArray();
        var expected = (double[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Doubles(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => (double)i).ToArray();
        var expected = Enumerable.Range(0, length).Select(i => (double)i).ToArray();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates_Doubles(int length)
    {
        var input = Enumerable.Repeat(7.5, length).ToArray();
        var expected = (double[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_DuplicateHeavy_Doubles(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (double)rng.Next(0, 3)).ToArray();
        var expected = (double[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_AlreadySorted_Strings(int length)
    {
        var input = Enumerable.Range(0, length).Select(i => i.ToString("D4")).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseSorted_Strings(int length)
    {
        var input = Enumerable.Range(0, length).Reverse().Select(i => i.ToString("D4")).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Duplicates_Strings(int length)
    {
        var input = Enumerable.Repeat("hello", length).ToArray();
        var expected = (string[])input.Clone();

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_DuplicateHeavy_Strings(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 3).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        NetworkSort.Sort(input);

        Assert.Equal(expected, input);
    }

    // --- Gap #3: Generic Sort<T>(T[], IComparer<T>) overload ---

    [Fact]
    public void Sort_Generic_27Elements_Int()
    {
        var rng = new Random(42);
        var input = Enumerable.Range(0, 27).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort<int>(input, Comparer<int>.Default);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Sort_Generic_28Elements_Int()
    {
        var rng = new Random(42);
        var input = Enumerable.Range(0, 28).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort<int>(input, Comparer<int>.Default);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Sort_Generic_FallsBackForLargeArrays()
    {
        var rng = new Random(42);
        var input = Enumerable.Range(0, 100).Select(_ => rng.Next()).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort<int>(input, Comparer<int>.Default);

        Assert.Equal(expected, input);
    }

    [Fact]
    public void Sort_Generic_NullArray_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => NetworkSort.Sort<int>((int[])null!, Comparer<int>.Default));
    }

    [Fact]
    public void Sort_Generic_Strings_WithOrdinalComparer()
    {
        var rng = new Random(42);
        var input = Enumerable.Range(0, 27).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        NetworkSort.Sort<string>(input, StringComparer.Ordinal);

        Assert.Equal(expected, input);
    }

    // --- Gap #4: Span+comparer for more types ---

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Span_WithComparer_Bytes(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (byte)rng.Next(0, 256)).ToArray();
        var expected = (byte[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input.AsSpan(), Comparer<byte>.Default);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Span_WithComparer_Doubles(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.NextDouble() * 2000 - 1000).ToArray();
        var expected = (double[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input.AsSpan(), Comparer<double>.Default);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Span_WithComparer_Longs(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => (long)rng.Next(-10000, 10000)).ToArray();
        var expected = (long[])input.Clone();
        Array.Sort(expected);

        NetworkSort.Sort(input.AsSpan(), Comparer<long>.Default);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_Span_WithComparer_Strings(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);

        NetworkSort.Sort(input.AsSpan(), StringComparer.Ordinal);

        Assert.Equal(expected, input);
    }

    // --- Gap #5: Custom comparer correctness (reverse comparer) ---

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
        NetworkSort.Sort(input, comparer);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseComparer_Span_Int(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);
        Array.Reverse(expected);

        var comparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
        NetworkSort.Sort(input.AsSpan(), comparer);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseComparer_String(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(0, 10000).ToString()).ToArray();
        var expected = (string[])input.Clone();
        Array.Sort(expected, StringComparer.Ordinal);
        Array.Reverse(expected);

        var comparer = Comparer<string>.Create((a, b) => string.Compare(b, a, StringComparison.Ordinal));
        NetworkSort.Sort(input, comparer);

        Assert.Equal(expected, input);
    }

    [Theory]
    [MemberData(nameof(Lengths))]
    public void Sort_ReverseComparer_Generic(int length)
    {
        var rng = new Random(42 + length);
        var input = Enumerable.Range(0, length).Select(_ => rng.Next(-1000, 1000)).ToArray();
        var expected = (int[])input.Clone();
        Array.Sort(expected);
        Array.Reverse(expected);

        var comparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
        NetworkSort.Sort<int>(input, comparer);

        Assert.Equal(expected, input);
    }

    // --- Gap #6: nint/nuint in null-comparer test ---

    [Fact]
    public void Sort_NullComparer_UsesDefault_NIntNUInt()
    {
        var rng = new Random(42);

        var nints = Enumerable.Range(0, 27).Select(_ => (nint)rng.Next(-1000, 1000)).ToArray();
        var nintsExpected = (nint[])nints.Clone();
        Array.Sort(nintsExpected);
        NetworkSort.Sort(nints, null);
        Assert.Equal(nintsExpected, nints);

        var nuints = Enumerable.Range(0, 27).Select(_ => (nuint)rng.Next(0, 2000)).ToArray();
        var nuintsExpected = (nuint[])nuints.Clone();
        Array.Sort(nuintsExpected);
        NetworkSort.Sort(nuints, null);
        Assert.Equal(nuintsExpected, nuints);
    }

    public static TheoryData<int> Lengths => new() { 27, 28 };
}
