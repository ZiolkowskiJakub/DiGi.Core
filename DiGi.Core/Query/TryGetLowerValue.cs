using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetLowerValue<TKey, T>(this SortedDictionary<TKey, T> sortedDictionary, TKey key, out T value, bool lowerLimit = true, bool upperLimit = false) where TKey : IComparable<TKey>
        {
            value = default;

            if (sortedDictionary == null || sortedDictionary.Count == 0)
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

            if (key.CompareTo(max) >= 0)
            {
                if(upperLimit)
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

            List<TKey> keysTemp = new List<TKey>(keys);
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

