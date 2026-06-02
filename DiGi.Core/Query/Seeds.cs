using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a sequence of seeds.
        /// </summary>
        /// <param name="count">The number of seeds to generate.</param>
        /// <param name="seed">The starting seed value.</param>
        /// <returns>A list of integers representing the seeds.</returns>
        public static List<int> Seeds(this int count, int seed = -1)
        {
            if (seed == -1)
            {
                return [.. Enumerable.Repeat(-1, count)];
            }

            List<int> result = [];
            result.Add(seed);
            for (int i = 1; i < count; i++)
            {
                result.Add(seed + i);
            }

            return result;
        }
    }
}