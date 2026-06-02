using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the previous element in a sequence, wrapping around if necessary.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="values">The sequence to search.</param>
        /// <param name="index">The current index.</param>
        /// <returns>The previous element, or default if the sequence is null or empty.</returns>
        public static T? Previous<T>(this IEnumerable<T?>? values, int index)
        {
            if (values == null)
            {
                return default;
            }

            int index_Temp = Previous(values.Count(), index);
            if (index_Temp == -1)
            {
                return default;
            }

            return values.ElementAt(index_Temp);
        }

        /// <summary>
        /// Calculates the previous index in a circular collection.
        /// </summary>
        /// <param name="count">The total number of elements.</param>
        /// <param name="index">The current index.</param>
        /// <returns>The previous index, or -1 if invalid.</returns>
        public static int Previous(this int count, int index)
        {
            if (index < 0)
            {
                return -1;
            }

            if (count == 0)
            {
                return -1;
            }

            int result = index;
            while (result >= count)
            {
                result -= count;
            }

            result = result == 0 ? count - 1 : result - 1;

            return result;
        }

        /// <summary>
        /// Gets the previous value in an enum, wrapping around to the last if it's the first.
        /// </summary>
        /// <typeparam name="TENum">The enum type.</typeparam>
        /// <param name="enum">The current enum value.</param>
        /// <returns>The previous enum value.</returns>
        public static TENum? Previous<TENum>(TENum? @enum) where TENum : Enum
        {
            if (@enum == null)
            {
                return default;
            }

            List<int> indexes = [];
            foreach (TENum @enum_Temp in System.Enum.GetValues(typeof(TENum)))
            {
                indexes.Add((int)(object)enum_Temp);
            }

            indexes.Sort();

            int index = indexes.IndexOf((int)(object)@enum);

            int next = Previous(indexes, index);

            return (TENum)(object)next;
        }
    }
}