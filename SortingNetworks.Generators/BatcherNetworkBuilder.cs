using System.Collections.Generic;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Generates sorting networks using Batcher's odd-even merge sort construction.
    /// Used for sizes not covered by the <see cref="NetworkDatabase"/> (sizes 33+).
    /// Complexity: O(N log²N) comparators, O(log²N) depth.
    /// </summary>
    internal static class BatcherNetworkBuilder
    {
        /// <summary>
        /// Generates a sorting network for the given size using Batcher's odd-even merge sort.
        /// Returns a flat array of comparator pairs: [a0, b0, a1, b1, ...].
        /// </summary>
        internal static int[] Generate(int n)
        {
            // Pad to next power of 2
            int p = 1;
            while (p < n) p <<= 1;

            var pairs = new List<int>();
            BatcherSort(0, p - 1, n, pairs);
            return pairs.ToArray();
        }

        /// <summary>
        /// Generates a sorting network and returns layer sizes (for SIMD step decomposition).
        /// Each layer contains pairs that can be independently scheduled (disjoint matching).
        /// </summary>
        internal static (int[] pairs, int[] layerSizes) GenerateWithLayers(int n)
        {
            var pairs = Generate(n);

            // Decompose into disjoint matching layers using greedy coloring
            var layers = DecomposeIntoLayers(pairs, n);
            return (pairs, layers);
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

        /// <summary>
        /// Decomposes flat comparator pairs into disjoint matching layers.
        /// Uses a greedy approach: assigns each pair to the first layer
        /// where neither element is already used.
        /// </summary>
        private static int[] DecomposeIntoLayers(int[] pairs, int n)
        {
            var layerAssignments = new List<HashSet<int>>();
            var layerCounts = new List<int>();

            for (int i = 0; i < pairs.Length; i += 2)
            {
                int a = pairs[i];
                int b = pairs[i + 1];

                bool placed = false;
                for (int layer = 0; layer < layerAssignments.Count; layer++)
                {
                    if (!layerAssignments[layer].Contains(a) && !layerAssignments[layer].Contains(b))
                    {
                        layerAssignments[layer].Add(a);
                        layerAssignments[layer].Add(b);
                        layerCounts[layer]++;
                        placed = true;
                        break;
                    }
                }

                if (!placed)
                {
                    var newLayer = new HashSet<int> { a, b };
                    layerAssignments.Add(newLayer);
                    layerCounts.Add(1);
                }
            }

            return layerCounts.ToArray();
        }
    }
}
