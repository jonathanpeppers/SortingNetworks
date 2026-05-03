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
        /// Controls the compare-and-swap strategy for scalar sorting network methods.
        /// When <c>true</c>, emits branchless <c>Math.Min</c>/<c>Math.Max</c> swaps
        /// (optimal on x86/x64 where the JIT lowers to <c>cmov</c>).
        /// When <c>false</c>, emits branching <c>if/swap</c>
        /// (optimal on ARM where branch prediction outperforms <c>csel</c> chains).
        /// When not set (default), the generator emits a runtime platform check
        /// that selects the best strategy automatically.
        /// Only applies to numeric types with <c>Math.Min</c>/<c>Math.Max</c> overloads;
        /// ignored for <c>char</c>, <c>string</c>, and custom types.
        /// </summary>
        public bool Branchless { get; set; }

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
