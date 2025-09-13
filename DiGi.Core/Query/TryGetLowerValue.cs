using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetLowerValue<TKey, TValue>(this SortedDictionary<TKey, TValue>? sortedDictionary, TKey? key, out TValue? value, bool lowerLimit = true, bool upperLimit = false) where TKey : IComparable<TKey>
        {
            value = default;

            if (sortedDictionary == null || sortedDictionary.Count == 0|| key is null)
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

