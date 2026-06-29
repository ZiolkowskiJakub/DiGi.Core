using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Splits a sequence into a list of smaller lists, each containing at most <paramref name="maxCount"/> elements.
        /// </summary>
        /// <typeparam name="X">The type of elements in the sequence.</typeparam>
        /// <param name="values">The sequence to split.</param>
        /// <param name="maxCount">The maximum number of elements per chunk.</param>
        /// <returns>A list of lists, or null if the input is null or maxCount is less than 1.</returns>
        public static List<List<X>>? Split<X>(this IEnumerable<X>? values, int maxCount)
        {
            if (values == null || maxCount < 1)
            {
                return null;
            }

            List<X> values_All = [.. values];

            if (values_All.Count <= maxCount)
            {
                return [values_All];
            }

            List<List<X>> result = [];

            List<X> values_Temp = [];

            foreach (X value in values_All)
            {
                values_Temp.Add(value);

                if (values_Temp.Count == maxCount)
                {
                    result.Add(values_Temp);
                    values_Temp = [];
                }
            }

            if (values_Temp.Count != 0)
            {
                result.Add(values_Temp);
            }

            return result;
        }
    }
}