namespace SortingNetworks.Tests;

/// <summary>
/// A simple comparable record struct used to test sorting networks with custom (non-primitive) types.
/// </summary>
public record struct Point(int X, int Y) : IComparable<Point>
{
    public int CompareTo(Point other)
    {
        int cmp = X.CompareTo(other.X);
        return cmp != 0 ? cmp : Y.CompareTo(other.Y);
    }
}
