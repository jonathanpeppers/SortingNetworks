using SortingNetworks;

var data = new int[] {
    27, 26, 25, 24, 23, 22, 21, 20, 19,
    18, 17, 16, 15, 14, 13, 12, 11, 10,
    9, 8, 7, 6, 5, 4, 3, 2, 1,
};
MySorter.Sort(data);

var expected = Enumerable.Range(1, 27).ToArray();
if (!data.SequenceEqual(expected))
{
    Console.Error.WriteLine("Sort failed!");
    return 1;
}
Console.WriteLine("Sort succeeded!");
return 0;

[SortingNetwork(27, typeof(int))]
partial class MySorter { }
