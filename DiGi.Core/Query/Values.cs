using DiGi.Core.Classes;

namespace DiGi.Core
{
    /// <summary>
    /// Provides utility methods for querying and manipulating data within the DiGi.Core library.
    /// </summary>
    public static partial class Query
    {
        /// <summary>
        /// Generates an array of integers within the specified range.
        /// </summary>
        /// <param name="range">The range from which to generate values.</param>
        /// <returns>An array containing all integer values in the range, or null if the range is null.</returns>
        public static int[]? Values(this Range<int>? range)
        {
            if (range is null)
            {
                return null;
            }
            int[] result = new int[range.Max - range.Min];
            for (int i = range.Min; i <= range.Max; i++)
            {
                result[i] = i;
            }

            return result;
        }
    }
}