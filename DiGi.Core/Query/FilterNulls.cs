using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Filters out null values from a sequence of items.
        /// </summary>
        /// <typeparam name="T">The type of the elements.</typeparam>
        /// <param name="values">The sequence to filter.</param>
        /// <returns>A list containing only the non-null elements, or null if the input is null.</returns>
        public static List<T>? FilterNulls<T>(this IEnumerable<T?>? values)
        {
            if (values is null)
            {
                return null;
            }

            List<T> result = [];
            foreach (T? value in values)
            {
                if (value is null)
                {
                    continue;
                }

                result.Add(value);
            }

            return result;
        }
    }
}