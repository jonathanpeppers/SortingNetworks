namespace SortingNetworks;

/// <summary>
/// Stores pre-computed sorting network comparator sequences.
/// Networks for sizes 2–26 use Batcher's odd-even merge sort construction.
/// Networks for sizes 27–28 use the depth-13 networks from the paper
/// "Depth-13 Sorting Networks for 28 Channels" (arXiv:2511.04107).
/// </summary>
internal static class NetworkData
{
    internal const int MaxNetworkSize = 28;

    private static readonly int[][] s_networks;

    static NetworkData()
    {
        s_networks = new int[MaxNetworkSize + 1][];

        // Generate Batcher's odd-even merge sort networks for sizes 2–26
        for (int n = 2; n <= 26; n++)
        {
            s_networks[n] = GenerateBatcherNetwork(n);
        }

        // Paper's depth-13 networks for 27 and 28 channels
        s_networks[27] = GenerateNetwork27();
        s_networks[28] = Network28;
    }

    internal static int[] GetNetwork(int n) => s_networks[n];

    #region Batcher's Odd-Even Merge Sort Network Generator

    /// <summary>
    /// Generates a sorting network using Batcher's odd-even merge sort.
    /// Pads to the next power of 2 and filters out comparators with indices >= n.
    /// </summary>
    private static int[] GenerateBatcherNetwork(int n)
    {
        // Find next power of 2
        int p = 1;
        while (p < n) p <<= 1;

        var pairs = new List<int>();
        BatcherSort(0, p - 1, n, pairs);
        return pairs.ToArray();
    }

    private static void BatcherSort(int lo, int hi, int n, List<int> pairs)
    {
        if (lo >= hi) return;
        int mid = lo + (hi - lo) / 2;
        BatcherSort(lo, mid, n, pairs);
        BatcherSort(mid + 1, hi, n, pairs);
        BatcherMerge(lo, hi, 1, n, pairs);
    }

    private static void BatcherMerge(int lo, int hi, int step, int n, List<int> pairs)
    {
        int doubleStep = step * 2;
        if (doubleStep > hi - lo)
        {
            // Base case: single comparator
            if (lo < n && lo + step < n)
            {
                pairs.Add(lo);
                pairs.Add(lo + step);
            }
            return;
        }

        BatcherMerge(lo, hi, doubleStep, n, pairs);
        BatcherMerge(lo + step, hi, doubleStep, n, pairs);

        for (int i = lo + step; i + step <= hi; i += doubleStep)
        {
            if (i < n && i + step < n)
            {
                pairs.Add(i);
                pairs.Add(i + step);
            }
        }
    }

    #endregion

    #region Paper's 28-Channel Depth-13 Sorting Network

    /// <summary>
    /// The 28-channel depth-13 sorting network from
    /// "Depth-13 Sorting Networks for 28 Channels" (arXiv:2511.04107).
    /// Flattened comparator pairs: [i0, j0, i1, j1, ...].
    /// </summary>
    private static readonly int[] Network28 =
    [
        // Layer 1
        0,27, 1,26, 2,25, 3,24, 4,23, 5,22, 6,21, 7,20, 8,9, 10,11, 12,15, 13,14, 16,17, 18,19,
        // Layer 2
        0,1, 2,3, 4,5, 6,7, 8,10, 9,11, 12,14, 13,15, 16,18, 17,19, 20,21, 22,23, 24,25, 26,27,
        // Layer 3
        0,2, 1,3, 4,6, 5,7, 8,19, 9,12, 10,14, 11,16, 13,17, 15,18, 20,22, 21,23, 24,26, 25,27,
        // Layer 4
        0,4, 1,5, 2,20, 3,21, 6,24, 7,25, 8,13, 9,11, 10,17, 12,15, 14,19, 16,18, 22,26, 23,27,
        // Layer 5
        1,2, 3,24, 4,6, 5,22, 7,20, 8,9, 10,12, 11,13, 14,16, 15,17, 18,19, 21,23, 25,26,
        // Layer 6
        0,8, 1,4, 2,6, 3,9, 5,7, 10,11, 12,13, 14,15, 16,17, 18,24, 19,27, 20,22, 21,25, 23,26,
        // Layer 7
        1,10, 2,13, 4,8, 5,12, 6,9, 7,20, 14,25, 15,22, 17,26, 18,21, 19,23,
        // Layer 8
        3,4, 6,14, 7,11, 8,15, 9,17, 10,18, 12,19, 13,21, 16,20, 23,24,
        // Layer 9
        2,4, 5,6, 7,8, 9,13, 11,15, 12,16, 14,18, 19,20, 21,22, 23,25,
        // Layer 10
        2,7, 4,8, 6,10, 9,11, 12,14, 13,15, 16,18, 17,21, 19,23, 20,25,
        // Layer 11
        1,3, 4,7, 5,6, 8,9, 10,12, 11,16, 13,14, 15,17, 18,19, 20,23, 21,22, 24,26,
        // Layer 12
        2,3, 4,5, 6,7, 8,10, 9,12, 11,13, 14,16, 15,18, 17,19, 20,21, 22,23, 24,25,
        // Layer 13
        3,4, 5,6, 7,8, 9,10, 11,12, 13,14, 15,16, 17,18, 19,20, 21,22, 23,24,
    ];

    /// <summary>
    /// Derives the 27-channel network from the 28-channel network
    /// by removing all comparators that involve channel 27.
    /// </summary>
    private static int[] GenerateNetwork27()
    {
        var pairs = new List<int>(Network28.Length);
        for (int i = 0; i < Network28.Length; i += 2)
        {
            int a = Network28[i];
            int b = Network28[i + 1];
            if (a < 27 && b < 27)
            {
                pairs.Add(a);
                pairs.Add(b);
            }
        }
        return pairs.ToArray();
    }

    #endregion
}
