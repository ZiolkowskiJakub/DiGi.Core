using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Finds the first element in a sequence that satisfies a specified condition.
        /// </summary>
        /// <typeparam name="T">The type of the elements.</typeparam>
        /// <param name="values">The sequence to search.</param>
        /// <param name="func">The predicate function.</param>
        /// <returns>The first element that matches the condition, or default if not found.</returns>
        public static T? Find<T>(this IEnumerable<T?>? values, Func<T?, bool> func)
        {
            if (func == null || values == null)
            {
                return default;
            }

            foreach (T? t in values)
            {
                if (func.Invoke(t))
                {
                    return t;
                }
            }

            return default;
        }
    }
}