using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Filters a sequence of values based on a predicate, splitting them into matching and non-matching lists.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="values">The sequence to filter.</param>
        /// <param name="func">The predicate function to test each element.</param>
        /// <param name="values_In">When this method returns, contains the elements that satisfied the condition.</param>
        /// <param name="values_Out">When this method returns, contains the elements that did not satisfy the condition.</param>
        /// <returns>True if the filtering was successful; otherwise, false.</returns>
        public static bool Filter<T>(this IEnumerable<T>? values, Func<T?, bool> func, out List<T>? values_In, out List<T>? values_Out)
        {
            values_In = null;
            values_Out = null;

            if (values == null || func == null)
            {
                return false;
            }

            values_In = [];
            values_Out = [];

            foreach (T value in values)
            {
                if (func.Invoke(value))
                {
                    values_In.Add(value);
                }
                else
                {
                    values_Out.Add(value);
                }
            }

            return true;
        }
    }
}