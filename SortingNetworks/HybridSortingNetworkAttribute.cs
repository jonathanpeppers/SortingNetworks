using System;

namespace SortingNetworks
{
    /// <summary>
    /// Marks a partial class for hybrid sorting network code generation.
    /// The source generator will emit <c>Sort</c>, <c>PartialSort</c>,
    /// and <c>NthElement</c> methods that use AVX-512 SIMD partitioning
    /// for large arrays and optimal sorting networks for small sub-arrays.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class HybridSortingNetworkAttribute : Attribute
    {
        /// <summary>
        /// The element type to sort (e.g., <c>typeof(int)</c>).
        /// </summary>
        public Type ElementType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridSortingNetworkAttribute"/> class.
        /// </summary>
        /// <param name="elementType">The element type to sort.</param>
        public HybridSortingNetworkAttribute(Type elementType)
        {
            ElementType = elementType;
        }
    }
}
