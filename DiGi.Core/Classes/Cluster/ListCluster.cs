using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a base abstract list implementation.
    /// </summary>
    /// <typeparam name="TKey_1">The type of the first primary key.</typeparam>
    /// <typeparam name="TKey_2">The type of the second primary key.</typeparam>
    /// <typeparam name="TValue">The type of values contained in the list.</typeparam>
    public abstract class List<TKey_1, TKey_2, TValue> : Cluster<TKey_1, TKey_2, TValue>
    {
        [JsonIgnore]
        private readonly Dictionary<TKey_1, Dictionary<TKey_2, List<TValue>>> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the List class.
        /// </summary>
        public List()
        {
        }

        /// <summary>
        /// Initializes a new instance of the List class using the specified collection of values.
        /// </summary>
        /// <param name="values">The collection of values used to initialize the list.</param>
        public List(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the List class from an existing value cluster.
        /// </summary>
        /// <param name="valueCluster">The existing value cluster to initialize the list from.</param>
        public List(List<TKey_1, TKey_2, TValue>? valueCluster)
            : base(valueCluster)
        {
        }

        /// <summary>
        /// Adds the specified value to the value cluster.
        /// </summary>
        /// <param name="value">The value to add to the cluster.</param>
        /// <returns>True if the element is successfully added; otherwise, false.</returns>
        public override bool Add(TValue? value)
        {
            if (value == null || !IsValid(value))
            {
                return false;
            }

            TKey_1? key_1 = GetKey_1(value);
            if (key_1 == null)
            {
                return false;
            }

            TKey_2? key_2 = GetKey_2(value);
            if (key_2 == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                dictionary_1 = [];
                dictionary[key_1] = dictionary_1;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                values = [];
                dictionary_1[key_2] = values;
            }

            values.Add(value);
            return true;
        }

        /// <summary>
        /// Removes all elements from the value cluster.
        /// </summary>
        public override void Clear()
        {
            dictionary.Clear();
        }

        /// <summary>
        /// Determines whether the cluster contains an element with the specified primary key.
        /// </summary>
        /// <param name="key_1">The primary key to locate in the cluster.</param>
        /// <returns>True if the cluster contains an element with the specified primary key; otherwise, false.</returns>
        public override bool Contains(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return false;
            }

            return dictionary.ContainsKey(key_1);
        }

        /// <summary>
        /// Determines whether the cluster contains an element with the specified combination of keys.
        /// </summary>
        /// <param name="key_1">The first key to search for.</param>
        /// <param name="key_2">The second key to search for.</param>
        /// <returns>True if the cluster contains an element with the specified keys; otherwise, false.</returns>
        public override bool Contains(TKey_1? key_1, TKey_2? key_2)
        {
            if (key_1 == null || key_2 == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            return dictionary_1.ContainsKey(key_2);
        }

        /// <summary>
        /// Determines whether the cluster contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the cluster.</param>
        /// <returns>True if the cluster contains the specified value; otherwise, false.</returns>
        public override bool Contains(TValue? value)
        {
            if (value == null)
            {
                return false;
            }

            return TryGetIndex(value, out _, out _, out int index) && index != -1;
        }

        /// <summary>
        /// Determines whether two specified values are equal.
        /// </summary>
        /// <param name="value_1">The first value to compare.</param>
        /// <param name="value_2">The second value to compare.</param>
        /// <returns>True if the specified values are equal; otherwise, false.</returns>
        public virtual bool Equals(TValue? value_1, TValue? value_2)
        {
            if (value_1 == null && value_2 == null)
            {
                return true;
            }

            if (value_1 == null || value_2 == null)
            {
                return false;
            }

            return value_1.Equals(value_2);
        }

        /// <summary>
        /// Retrieves the indexes of elements that match the specified keys and predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value being evaluated by the predicate.</typeparam>
        /// <param name="key_1">The first key to search for.</param>
        /// <param name="key_2">The second key to search for.</param>
        /// <param name="func">A predicate function used to filter elements based on their value.</param>
        /// <returns>A list of indexes that match the criteria, or null if no matches are found.</returns>
        public virtual List<int>? GetIndexes<UValue>(TKey_1? key_1, TKey_2? key_2, Func<UValue?, bool>? func) where UValue : TValue
        {
            if (key_1 == null || key_2 == null)
            {
                return null;
            }

            List<int> result = [];

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                return result;
            }

            for (int i = 0; i < values.Count; i++)
            {
                TValue value = values[i];

                if (value is not UValue)
                {
                    continue;
                }

                UValue u = (UValue)value;

                if (func != null && !func.Invoke(u))
                {
                    continue;
                }

                result.Add(i);
            }

            return result;
        }

        /// <summary>
        /// Returns a list of all primary keys in the cluster.
        /// </summary>
        /// <returns>A list containing all primary keys, or null if none exist.</returns>
        public override List<TKey_1>? GetKeys_1()
        {
            return dictionary.Keys?.ToList();
        }

        /// <summary>
        /// Returns a list of secondary keys associated with the specified primary key.
        /// </summary>
        /// <param name="key_1">The primary key used to retrieve the secondary keys.</param>
        /// <returns>A list of secondary keys associated with the specified primary key, or null if none are found.</returns>
        public override List<TKey_2>? GetKeys_2(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<TKey_2> result = [];

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            result.AddRange(dictionary_1.Keys);

            return result;
        }

        /// <summary>
        /// Retrieves the first value that satisfies the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of value to retrieve.</typeparam>
        /// <param name="func">A predicate function used to find a matching value.</param>
        /// <returns>The first value that satisfies the predicate, or null if no match is found.</returns>
        public override UValue? GetValue<UValue>(Func<UValue?, bool>? func) where UValue : default
        {
            foreach (Dictionary<TKey_2, List<TValue>> dictionary_1 in dictionary.Values)
            {
                foreach (List<TValue> values in dictionary_1.Values)
                {
                    if (values == null)
                    {
                        continue;
                    }

                    foreach (TValue value in values)
                    {
                        if (value == null)
                        {
                            continue;
                        }

                        if (value is not UValue)
                        {
                            continue;
                        }

                        UValue u = (UValue)value;

                        if (func == null)
                        {
                            return u;
                        }

                        if (func.Invoke(u))
                        {
                            return u;
                        }
                    }
                }
            }

            return default;
        }

        /// <summary>
        /// Retrieves a value using the provided cluster reference.
        /// </summary>
        /// <typeparam name="UValue">The type of value to retrieve.</typeparam>
        /// <param name="listClusterReference">The cluster reference used to locate the value.</param>
        /// <returns>The retrieved value, or null if not found.</returns>
        public UValue? GetValue<UValue>(ListClusterReference<TKey_1, TKey_2>? listClusterReference) where UValue : TValue
        {
            if (listClusterReference == null || listClusterReference.Key_1 == null || listClusterReference.Key_2 == null || listClusterReference.Index < 0)
            {
                return default;
            }

            if (!dictionary.TryGetValue(listClusterReference.Key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return default;
            }

            if (!dictionary_1.TryGetValue(listClusterReference.Key_2, out List<TValue> values) || values == null)
            {
                return default;
            }

            int index = listClusterReference.Index;

            if (index >= values.Count || index < 0)
            {
                return default;
            }

            TValue value = values[index];
            if (value is UValue result)
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Retrieves all values associated with the specified primary key.
        /// </summary>
        /// <typeparam name="UValue">The type of value to retrieve.</typeparam>
        /// <param name="key_1">The primary key used for lookup.</param>
        /// <returns>A list of values associated with the specified primary key, or null if none are found.</returns>
        public override List<UValue>? GetValues<UValue>(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<UValue> result = [];
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            foreach (List<TValue> values in dictionary_1.Values)
            {
                if (values == null)
                {
                    continue;
                }

                int count = values.Count;
                for (int i = 0; i < count; i++)
                {
                    if (values[i] is UValue)
                    {
                        result.Add((UValue)values[i]!);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves values that match the specified keys and predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of value to retrieve.</typeparam>
        /// <param name="key_1">The first key used for lookup.</param>
        /// <param name="key_2">The second key used for lookup.</param>
        /// <param name="func">A predicate function to filter the values.</param>
        /// <returns>A list of values that match the specified keys and predicate, or null if none are found.</returns>
        public List<UValue>? GetValues<UValue>(TKey_1? key_1, TKey_2? key_2, Func<UValue?, bool> func) where UValue : TValue
        {
            if (key_1 == null || key_2 == null)
            {
                return null;
            }

            List<int>? indexes = GetIndexes(key_1, key_2, func);
            if (indexes == null)
            {
                return null;
            }

            return GetValues<UValue>(key_1, key_2, indexes);
        }

        /// <summary>
        /// Retrieves values at the specified indexes for the given keys.
        /// </summary>
        /// <param name="key_1">The primary key used to locate the cluster.</param>
        /// <param name="key_2">The secondary key used to locate the element within the cluster.</param>
        /// <param name="indexes">The collection of indexes from which to retrieve values.</param>
        /// <typeparam name="UValue">The type of values being retrieved.</typeparam>
        /// <returns>A list of values found at the specified indexes, or null if no values were found.</returns>
        public List<UValue>? GetValues<UValue>(TKey_1? key_1, TKey_2? key_2, IEnumerable<int> indexes) where UValue : TValue
        {
            if (key_1 == null || key_2 == null || indexes == null)
            {
                return null;
            }

            List<UValue> result = [];

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                return result;
            }

            int count = values.Count;

            foreach (int index in indexes)
            {
                if (index >= count || index < 0)
                {
                    continue;
                }

                TValue value = values[index];
                if (value is UValue value_Temp)
                {
                    result.Add(value_Temp);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves values associated with a collection of cluster references.
        /// </summary>
        /// <param name="listClusterReferences">The collection of cluster references to retrieve values for.</param>
        /// <typeparam name="UValue">The type of values being retrieved.</typeparam>
        /// <returns>A list of retrieved values, or null if no values were found.</returns>
        public List<UValue>? GetValues<UValue>(IEnumerable<ListClusterReference<TKey_1, TKey_2>>? listClusterReferences) where UValue : TValue
        {
            if (listClusterReferences == null)
            {
                return null;
            }

            List<UValue> result = [];
            foreach (ListClusterReference<TKey_1, TKey_2> listClusterReference in listClusterReferences)
            {
                UValue? u = GetValue<UValue>(listClusterReference);
                if (u == null)
                {
                    continue;
                }

                result.Add(u);
            }

            return result;
        }

        /// <summary>
        /// Returns all values contained in the list.
        /// </summary>
        /// <typeparam name="UValue">The type of values stored in the list.</typeparam>
        /// <returns>A list containing all values currently held in the cluster.</returns>
        public override List<UValue> GetValues<UValue>() where UValue : default
        {
            List<UValue> result = [];
            foreach (Dictionary<TKey_2, List<TValue>> dictionary_1 in dictionary.Values)
            {
                foreach (List<TValue> values in dictionary_1.Values)
                {
                    if (values == null)
                    {
                        continue;
                    }

                    int count = values.Count;

                    for (int i = 0; i < count; i++)
                    {
                        if (values[i] is UValue)
                        {
                            result.Add((UValue)values[i]!);
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Removes and returns values associated with the specified cluster references.
        /// </summary>
        /// <param name="listClusterReferences">The collection of cluster references to remove.</param>
        /// <returns>A list of removed values, or null if no values were found for the provided references.</returns>
        public List<TValue>? Remove(IEnumerable<ListClusterReference<TKey_1, TKey_2>>? listClusterReferences)
        {
            if (listClusterReferences == null)
            {
                return null;
            }

            List<ListClusterReference<TKey_1, TKey_2>> listClusterReferences_Temp = [.. listClusterReferences];

            List<TValue> result = [];

            while (listClusterReferences_Temp.Count > 0)
            {
                ListClusterReference<TKey_1, TKey_2> listClusterReference = listClusterReferences_Temp[0];
                if (listClusterReference == null || listClusterReference.Key_1 == null || listClusterReference.Key_2 == null)
                {
                    listClusterReferences_Temp.RemoveAt(0);
                    continue;
                }

                List<ListClusterReference<TKey_1, TKey_2>> listClusterReferences_Temp_Temp = listClusterReferences_Temp.FindAll(x => listClusterReference.Key_1.Equals(x.Key_1) && listClusterReference.Key_2.Equals(x.Key_2));
                HashSet<ListClusterReference<TKey_1, TKey_2>> listClusterReferences_Temp_Temp_Set = [.. listClusterReferences_Temp_Temp];
                listClusterReferences_Temp.RemoveAll(x => listClusterReferences_Temp_Temp_Set.Contains(x));

                List<TValue>? values = Remove(listClusterReference.Key_1, listClusterReference.Key_2, listClusterReferences_Temp_Temp.ConvertAll(x => x.Index));
                if (values != null)
                {
                    result.AddRange(values);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes all elements associated with the specified primary key from the cluster.
        /// </summary>
        /// <param name="key_1">The primary key of the elements to remove.</param>
        /// <returns>True if one or more elements were removed; otherwise, false.</returns>
        public override bool Remove(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return false;
            }

            return dictionary.Remove(key_1);
        }

        /// <summary>
        /// Removes the element associated with the specified combination of keys from the cluster.
        /// </summary>
        /// <param name="key_1">The primary key of the element to remove.</param>
        /// <param name="key_2">The secondary key of the element to remove.</param>
        /// <returns>True if the element was successfully removed; otherwise, false.</returns>
        public override bool Remove(TKey_1? key_1, TKey_2? key_2)
        {
            if (key_1 == null || key_2 == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            bool result = dictionary_1.Remove(key_2);
            if (dictionary_1.Count == 0)
            {
                dictionary.Remove(key_1);
            }

            return result;
        }

        /// <summary>
        /// Removes the first occurrence of a specific value from the cluster.
        /// </summary>
        /// <param name="value">The value to remove from the cluster.</param>
        /// <returns>True if the value was successfully removed; otherwise, false.</returns>
        public override bool Remove(TValue? value)
        {
            if (value == null)
            {
                return false;
            }

            TKey_1? key_1 = GetKey_1(value);
            if (key_1 == null)
            {
                return false;
            }

            TKey_2? key_2 = GetKey_2(value);
            if (key_2 == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                return false;
            }

            bool result = false;
            for (int i = values.Count - 1; i >= 0; i--)
            {
                if (value.Equals(values[i]))
                {
                    values.RemoveAt(i);
                    result = true;
                }
            }

            if (values.Count == 0)
            {
                if (dictionary_1.Remove(key_2))
                {
                    if (dictionary_1.Count == 0)
                    {
                        dictionary.Remove(key_1);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Removes and returns the value at the specified index for the given keys.
        /// </summary>
        /// <param name="key_1">The primary key associated with the value to remove.</param>
        /// <param name="key_2">The secondary key associated with the value to remove.</param>
        /// <param name="index">The index of the value to remove.</param>
        /// <returns>The removed value, or the default value of TValue if the element was not found.</returns>
        public TValue? Remove(TKey_1? key_1, TKey_2? key_2, int index)
        {
            if (index == -1 || key_1 == null || key_2 == null)
            {
                return default;
            }

            List<TValue>? values = Remove(key_1, key_2, [index]);

            return values == null || values.Count == 0 ? default : values[0];
        }

        /// <summary>
        /// Removes and returns values at the specified indexes for the given keys.
        /// </summary>
        /// <param name="key_1">The primary key associated with the values to remove.</param>
        /// <param name="key_2">The secondary key associated with the values to remove.</param>
        /// <param name="indexes">A collection of indexes specifying which values to remove.</param>
        /// <returns>A list containing the removed values, or null if no values were removed.</returns>
        public List<TValue>? Remove(TKey_1? key_1, TKey_2? key_2, IEnumerable<int> indexes)
        {
            if (key_1 == null || key_2 == null || indexes == null || !indexes.Any())
            {
                return null;
            }

            List<TValue> result = [];

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                return result;
            }

            List<int> indexes_Temp = [.. indexes.Distinct()];
            indexes_Temp.Sort((x, y) => y.CompareTo(x));

            foreach (int index in indexes_Temp)
            {
                if (index < 0 || index >= values.Count)
                {
                    continue;
                }

                result.Add(values[index]);
                values.RemoveAt(index);
            }

            if (values.Count == 0)
            {
                if (dictionary_1.Remove(key_2))
                {
                    if (dictionary_1.Count == 0)
                    {
                        dictionary.Remove(key_1);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Attempts to find the primary key, secondary key, and index of a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the cluster.</param>
        /// <param name="key_1">When this method returns, contains the primary key associated with the specified value, if found; otherwise, the default value of TKey_1.</param>
        /// <param name="key_2">When this method returns, contains the secondary key associated with the specified value, if found; otherwise, the default value of TKey_2.</param>
        /// <param name="index">When this method returns, contains the index of the specified value, if found; otherwise, 0.</param>
        /// <returns>True if the primary key, secondary key, and index were found; otherwise, false.</returns>
        public bool TryGetIndex(TValue? value, out TKey_1? key_1, out TKey_2? key_2, out int index)
        {
            key_2 = default;
            index = -1;

            key_1 = GetKey_1(value);
            if (key_1 == null)
            {
                return false;
            }

            key_2 = GetKey_2(value);
            if (key_2 == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                return false;
            }

            for (int i = 0; i < values.Count; i++)
            {
                if (Equals(value, values[i]))
                {
                    index = i;
                    return true;
                }
            }

            return false;
        }
    }
}