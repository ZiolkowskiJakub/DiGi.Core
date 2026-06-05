using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>Splits items by counting them as individual units.</summary>
    /// <typeparam name="T">The type of the items to be split.</typeparam>
    public class SizeSplitter<T> : Splitter<T, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SizeSplitter{T}"/> class.
        /// </summary>
        /// <param name="items">The collection of items to be split.</param>
        public SizeSplitter(IEnumerable<T> items)
            : base(items)
        {
        }

        /// <summary>
        /// Gets the size value for the specified item.
        /// </summary>
        /// <param name="item">The item to get the size value for.</param>
        /// <returns>The size value of the specified item.</returns>
        public override int GetValue(T? item)
        {
            return 1;
        }
    }
}