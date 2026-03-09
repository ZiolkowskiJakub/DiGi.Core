using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Maps an out-of-bounds index back into the specified range using a wrap-around (circular) logic.
        /// If the index is within the range, it returns the index unchanged. 
        /// If the range is null, returns <see cref="int.MinValue"/>.
        /// </summary>
        /// <param name="range">The boundaries within which the index should be contained.</param>
        /// <param name="index">The index to be evaluated or mapped.</param>
        /// <returns>
        /// The original index if it's within bounds; 
        /// the wrapped index if it's outside; 
        /// or <see cref="int.MinValue"/> if the range is null.
        /// </returns>
        public static int BoundedIndex(this Range<int>? range, int index)
        {
            if (range is null)
            {
                return int.MinValue;
            }

            if (range.In(index))
            {
                return index;
            }

            int count = range.Max - range.Min + 1;

            if (index < range.Min)
            {
                int difference = range.Min - index - 1;
                int reminder = difference % count;
                return range.Max - reminder;
            }

            if (index > range.Max)
            {
                int difference = index - range.Max - 1;
                int reminder = difference % count;
                return range.Min + reminder;
            }

            return int.MinValue;
        }

        /// <summary>
        /// Bounded index between 0 and count - 1
        /// </summary>
        /// <param name="count">Items count</param>
        /// <param name="index">Index</param>
        /// <returns>BoundedIndex</returns>
        public static int BoundedIndex(this int count, int index)
        {
            int max = count - 1;

            if (max < 0)
            {
                return int.MinValue;
            }

            return BoundedIndex(new Range<int>(0, max), index);
        }
    }
}