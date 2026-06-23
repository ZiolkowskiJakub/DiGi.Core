using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to get the value associated with the nearest key less than or equal to the specified key in a sorted dictionary.
        /// </summary>
        /// <typeparam name="TKey">The type of the keys, which must be comparable.</typeparam>
        /// <typeparam name="TValue">The type of the values.</typeparam>
        /// <param name="sortedDictionary">The sorted dictionary to search.</param>
        /// <param name="key">The key to look up or find the nearest lower key for.</param>
        /// <param name="value">When this method returns, contains the associated value, or default if not found.</param>
        /// <param name="lowerLimit">If true, returns false when the key is below the minimum key. If false, clamps to the minimum.</param>
        /// <param name="upperLimit">If true, returns false when the key is above the maximum key. If false, clamps to the maximum.</param>
        /// <returns>True if a value was found; otherwise, false.</returns>
        public static bool TryGetLowerValue<TKey, TValue>(this SortedDictionary<TKey, TValue>? sortedDictionary, TKey? key, out TValue? value, bool lowerLimit = true, bool upperLimit = false) where TKey : IComparable<TKey>
        {
            value = default;

            if (sortedDictionary == null || sortedDictionary.Count == 0 || key is null)
            {
                return false;
            }

            IEnumerable<TKey> keys = sortedDictionary.Keys;

            TKey min = keys.First();
            TKey max = keys.Last();

            if (key.CompareTo(min) < 0)
            {
                if (lowerLimit)
                {
                    return false;
                }

                value = sortedDictionary[min];
                return true;
            }

            if (key.CompareTo(max) > 0)
            {
                if (upperLimit)
                {
                    return false;
                }

                value = sortedDictionary[max];
                return true;
            }

            if (sortedDictionary.TryGetValue(key, out value))
            {
                return true;
            }

            List<TKey> keysTemp = [.. keys];
            keysTemp.Reverse();

            foreach (TKey keyTemp in keysTemp)
            {
                if (keyTemp.CompareTo(key) < 0)
                {
                    value = sortedDictionary[keyTemp];
                    return true;
                }
            }

            return false;
        }
    }
}