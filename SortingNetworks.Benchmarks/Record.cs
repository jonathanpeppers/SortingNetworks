namespace SortingNetworks.Benchmarks;

/// <summary>
/// A simple comparable record struct used to benchmark sorting networks with custom (non-primitive) types.
/// </summary>
public record struct Record(int X, int Y) : IComparable<Record>
{
    public int CompareTo(Record other)
    {
        int cmp = X.CompareTo(other.X);
        return cmp != 0 ? cmp : Y.CompareTo(other.Y);
    }
}
