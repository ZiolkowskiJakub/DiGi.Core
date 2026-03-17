using System.Collections.Generic;

namespace DiGi.Core.Classes
{
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