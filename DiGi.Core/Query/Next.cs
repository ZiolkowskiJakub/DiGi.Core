using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the next element in a sequence, wrapping around if necessary.
        /// </summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="values">The sequence to search.</param>
        /// <param name="index">The current index.</param>
        /// <returns>The next element, or default if the sequence is null or empty.</returns>
        public static T? Next<T>(this IEnumerable<T?>? values, int index)
        {
            if (values == null)
            {
                return default;
            }

            int index_Temp = Next(values.Count(), index);
            if (index_Temp == -1)
            {
                return default;
            }

            return values.ElementAt(index_Temp);
        }

        /// <summary>
        /// Calculates the next index in a circular collection.
        /// </summary>
        /// <param name="count">The total number of elements.</param>
        /// <param name="index">The current index.</param>
        /// <returns>The next index, or -1 if invalid.</returns>
        public static int Next(this int count, int index)
        {
            if (index < 0)
            {
                return -1;
            }

            if (count == 0)
            {
                return -1;
            }

            return (index + 1) % count;

            //int result = index + 1;
            //while (result >= count)
            //{
            //    result -= count;
            //}

            //return result;
        }

        /// <summary>
        /// Gets the next value in an enum, wrapping around to the first if it's the last.
        /// </summary>
        /// <typeparam name="TEnum">The enum type.</typeparam>
        /// <param name="enum">The current enum value.</param>
        /// <returns>The next enum value.</returns>
        public static TEnum? Next<TEnum>(TEnum? @enum) where TEnum : Enum
        {
            if (@enum == null)
            {
                return default;
            }

            List<int> indexes = [];
            foreach (TEnum @enum_Temp in System.Enum.GetValues(typeof(TEnum)))
            {
                indexes.Add((int)(object)enum_Temp);
            }

            indexes.Sort();

            int index = indexes.IndexOf((int)(object)@enum);

            int next = Next(indexes, index);

            return (TEnum)(object)next;
        }
    }
}