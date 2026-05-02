using System;
using System.Collections.Generic;
using System.Linq;

using SortingNetworks.Generators;

namespace SortingNetworks.Tests;

public class NetworkDatabaseTests
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(8)]
    [InlineData(9)]
    [InlineData(10)]
    [InlineData(11)]
    [InlineData(12)]
    [InlineData(13)]
    [InlineData(14)]
    [InlineData(15)]
    [InlineData(16)]
    [InlineData(17)]
    [InlineData(18)]
    [InlineData(19)]
    [InlineData(20)]
    [InlineData(21)]
    [InlineData(22)]
    [InlineData(23)]
    [InlineData(24)]
    [InlineData(25)]
    [InlineData(26)]
    [InlineData(27)]
    [InlineData(28)]
    [InlineData(29)]
    [InlineData(30)]
    [InlineData(31)]
    [InlineData(32)]
    [InlineData(33)]
    [InlineData(34)]
    [InlineData(35)]
    [InlineData(36)]
    [InlineData(37)]
    [InlineData(38)]
    [InlineData(39)]
    [InlineData(40)]
    [InlineData(41)]
    [InlineData(42)]
    [InlineData(43)]
    [InlineData(44)]
    [InlineData(45)]
    [InlineData(46)]
    [InlineData(47)]
    [InlineData(48)]
    [InlineData(49)]
    [InlineData(50)]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    [InlineData(54)]
    [InlineData(55)]
    [InlineData(56)]
    [InlineData(57)]
    [InlineData(58)]
    [InlineData(59)]
    [InlineData(60)]
    [InlineData(61)]
    [InlineData(62)]
    [InlineData(63)]
    [InlineData(64)]
    public void Network_SortsCorrectly(int size)
    {
        var network = NetworkDatabase.GetNetwork(size);
        Assert.NotNull(network);

        // Verify the network sorts all permutations for small sizes,
        // or a large random sample for larger sizes
        var random = new Random(42 + size);
        int trials = size <= 8 ? Factorial(size) : 10000;

        for (int trial = 0; trial < trials; trial++)
        {
            int[] input;
            if (size <= 8 && trial < Factorial(size))
            {
                input = GetPermutation(size, trial);
            }
            else
            {
                input = new int[size];
                for (int i = 0; i < size; i++)
                    input[i] = random.Next(0, 1000);
            }

            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            ApplyNetwork(actual, network!);

            Assert.Equal(expected, actual);
        }
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(16)]
    [InlineData(23)]
    [InlineData(24)]
    [InlineData(25)]
    [InlineData(26)]
    [InlineData(27)]
    [InlineData(28)]
    [InlineData(29)]
    [InlineData(30)]
    [InlineData(31)]
    [InlineData(32)]
    [InlineData(33)]
    [InlineData(34)]
    [InlineData(35)]
    [InlineData(36)]
    [InlineData(37)]
    [InlineData(38)]
    [InlineData(39)]
    [InlineData(40)]
    [InlineData(41)]
    [InlineData(42)]
    [InlineData(43)]
    [InlineData(44)]
    [InlineData(45)]
    [InlineData(46)]
    [InlineData(47)]
    [InlineData(48)]
    [InlineData(49)]
    [InlineData(50)]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    [InlineData(54)]
    [InlineData(55)]
    [InlineData(56)]
    [InlineData(57)]
    [InlineData(58)]
    [InlineData(59)]
    [InlineData(60)]
    [InlineData(61)]
    [InlineData(62)]
    [InlineData(63)]
    [InlineData(64)]
    public void Network_HasValidLayerSizes(int size)
    {
        var network = NetworkDatabase.GetNetwork(size);
        var layerSizes = NetworkDatabase.GetLayerSizes(size);
        Assert.NotNull(network);
        Assert.NotNull(layerSizes);

        // Total pairs in layer sizes should match network length / 2
        int totalPairs = layerSizes!.Sum();
        Assert.Equal(network!.Length / 2, totalPairs);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(16)]
    [InlineData(23)]
    [InlineData(24)]
    [InlineData(25)]
    [InlineData(26)]
    [InlineData(27)]
    [InlineData(28)]
    [InlineData(29)]
    [InlineData(30)]
    [InlineData(31)]
    [InlineData(32)]
    [InlineData(33)]
    [InlineData(34)]
    [InlineData(35)]
    [InlineData(36)]
    [InlineData(37)]
    [InlineData(38)]
    [InlineData(39)]
    [InlineData(40)]
    [InlineData(41)]
    [InlineData(42)]
    [InlineData(43)]
    [InlineData(44)]
    [InlineData(45)]
    [InlineData(46)]
    [InlineData(47)]
    [InlineData(48)]
    [InlineData(49)]
    [InlineData(50)]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    [InlineData(54)]
    [InlineData(55)]
    [InlineData(56)]
    [InlineData(57)]
    [InlineData(58)]
    [InlineData(59)]
    [InlineData(60)]
    [InlineData(61)]
    [InlineData(62)]
    [InlineData(63)]
    [InlineData(64)]
    public void Network_LayersAreDisjointMatchings(int size)
    {
        var network = NetworkDatabase.GetNetwork(size);
        var layerSizes = NetworkDatabase.GetLayerSizes(size);
        Assert.NotNull(network);
        Assert.NotNull(layerSizes);

        int pairIndex = 0;
        for (int layer = 0; layer < layerSizes!.Length; layer++)
        {
            var used = new HashSet<int>();
            for (int p = 0; p < layerSizes[layer]; p++)
            {
                int a = network![pairIndex * 2];
                int b = network[pairIndex * 2 + 1];

                Assert.True(used.Add(a), $"Element {a} used twice in layer {layer} of size-{size} network");
                Assert.True(used.Add(b), $"Element {b} used twice in layer {layer} of size-{size} network");

                pairIndex++;
            }
        }
    }

    [Theory]
    [InlineData(65)]
    [InlineData(96)]
    [InlineData(128)]
    public void Batcher_SortsCorrectly(int size)
    {
        var network = BatcherNetworkBuilder.Generate(size);
        Assert.NotNull(network);

        var random = new Random(42 + size);
        for (int trial = 0; trial < 1000; trial++)
        {
            var input = new int[size];
            for (int i = 0; i < size; i++)
                input[i] = random.Next(0, 10000);

            var expected = (int[])input.Clone();
            Array.Sort(expected);

            var actual = (int[])input.Clone();
            ApplyNetwork(actual, network);

            Assert.Equal(expected, actual);
        }
    }

    [Fact]
    public void NetworkDatabase_ReturnsNull_ForOutOfRangeSize()
    {
        Assert.Null(NetworkDatabase.GetNetwork(0));
        Assert.Null(NetworkDatabase.GetNetwork(1));
        Assert.Null(NetworkDatabase.GetNetwork(65));
        Assert.Null(NetworkDatabase.GetNetwork(100));
    }

    /// <summary>
    /// Applies a sorting network (flat pair array) to an int array.
    /// </summary>
    private static void ApplyNetwork(int[] array, int[] network)
    {
        for (int i = 0; i < network.Length; i += 2)
        {
            int a = network[i];
            int b = network[i + 1];
            if (array[a] > array[b])
            {
                int temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            }
        }
    }

    private static int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++) result *= i;
        return result;
    }

    private static int[] GetPermutation(int n, int index)
    {
        var elements = Enumerable.Range(0, n).ToList();
        var result = new int[n];
        for (int i = 0; i < n; i++)
        {
            int fact = Factorial(n - 1 - i);
            int k = index / fact;
            result[i] = elements[k];
            elements.RemoveAt(k);
            index %= fact;
        }
        return result;
    }
}
