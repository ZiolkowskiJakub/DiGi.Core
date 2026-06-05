using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a collection of values into a dictionary where each key is associated with a list of values produced by the key function.
        /// </summary>
        /// <typeparam name="T">The type of keys in the resulting dictionary.</typeparam>
        /// <typeparam name="X">The type of elements in the input collection.</typeparam>
        /// <param name="values">The collection of values to convert.</param>
        /// <param name="keyFunc">A function to extract the key for each element.</param>
        /// <returns>A dictionary containing lists of values grouped by the keys produced by the key function, or null if the input is null.</returns>
        public static Dictionary<T, List<X>>? ToSystem_Dictionary<T, X>(this IEnumerable<X> values, Func<X, T?> keyFunc)
        {
            if (values is null || keyFunc is null)
            {
                return null;
            }

            Dictionary<T, List<X>> result = [];
            foreach (X x in values)
            {
                T? t = keyFunc(x);
                if (t is null)
                {
                    continue;
                }

                if (!result.TryGetValue(t, out List<X> xs) || xs is null)
                {
                    xs = [];
                    result[t] = xs;
                }
                xs.Add(x);
            }

            return result;
        }
    }
}