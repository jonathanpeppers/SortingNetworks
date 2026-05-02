using System;

namespace SortingNetworks
{
    /// <summary>
    /// Marks a partial class for sorting network code generation.
    /// The source generator will emit a <c>Sort</c> method on the class
    /// that uses an optimal sorting network for the specified size and type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class SortingNetworkAttribute : Attribute
    {
        /// <summary>
        /// The number of elements in the sorting network (2–64).
        /// </summary>
        public int Size { get; }

        /// <summary>
        /// The element type to sort (e.g., <c>typeof(int)</c>).
        /// </summary>
        public Type ElementType { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortingNetworkAttribute"/> class.
        /// </summary>
        /// <param name="size">The number of elements in the sorting network.</param>
        /// <param name="elementType">The element type to sort.</param>
        public SortingNetworkAttribute(int size, Type elementType)
        {
            Size = size;
            ElementType = elementType;
        }
    }
}
