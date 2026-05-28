using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>Splits items by counting them as individual units.</summary>
    public class SizeSplitter<T> : Splitter<T, int>
    {
        public SizeSplitter(IEnumerable<T> items)
            : base(items)
        {
        }

        public override int GetValue(T? item)
        {
            return 1;
        }
    }
}