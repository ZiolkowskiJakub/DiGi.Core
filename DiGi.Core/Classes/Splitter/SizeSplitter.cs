using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>Splits items by counting them as individual units.</summary>
    public class SizeSplitter<T> : Splitter<T, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SizeSplitter{T}"/> class.
        /// </summary>
        public SizeSplitter(IEnumerable<T> items)
            : base(items)
        {
        }

        /// <summary>
        /// Gets the size value for the specified item.
        /// </summary>
        public override int GetValue(T? item)
        {
            return 1;
        }
    }
}