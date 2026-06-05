using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a base abstract value cluster for organizing data by keys.
    /// </summary>
    /// <typeparam name="TKey_1">The type of the first key used for organization.</typeparam>
    /// <typeparam name="TKey_2">The type of the second key used for organization.</typeparam>
    /// <typeparam name="TValue">The type of values stored in the cluster.</typeparam>
    public abstract class ValueCluster<TKey_1, TKey_2, TValue> : Cluster<TKey_1, TKey_2, TValue>
    {
        [JsonIgnore]
        private readonly Dictionary<TKey_1, Dictionary<TKey_2, TValue>> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the ValueCluster class.
        /// </summary>
        public ValueCluster()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueCluster class using the specified collection of values.
        /// </summary>
        /// <param name="values">The collection of values to initialize the cluster with.</param>
        public ValueCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ValueCluster class from another value cluster.
        /// </summary>
        /// <param name="valueCluster">The value cluster to copy from.</param>
        public ValueCluster(ValueCluster<TKey_1, TKey_2, TValue>? valueCluster)
            : base(valueCluster)
        {
        }

        /// <summary>
        /// Adds the specified value to the value cluster.
        /// </summary>
        /// <param name="value">The value to add to the cluster.</param>
        /// <returns>true if the element is successfully added to the cluster; otherwise, false.</returns>
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

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                dictionary_1 = [];
                dictionary[key_1] = dictionary_1;
            }

            dictionary_1[key_2] = value;
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
        /// <returns>true if the cluster contains an element with the specified primary key; otherwise, false.</returns>
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
        /// <param name="key_1">The first part of the key.</param>
        /// <param name="key_2">The second part of the key.</param>
        /// <returns>true if the cluster contains an element with the specified combination of keys; otherwise, false.</returns>
        public override bool Contains(TKey_1? key_1, TKey_2? key_2)
        {
            if (key_1 == null || key_2 == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            return dictionary_1.ContainsKey(key_2);
        }

        /// <summary>
        /// Determines whether the cluster contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate in the cluster.</param>
        /// <returns>true if the cluster contains a specific value; otherwise, false.</returns>
        public override bool Contains(TValue? value)
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

            return Contains(key_1, key_2);
        }

        /// <summary>
        /// Returns a list of all primary keys in the cluster.
        /// </summary>
        /// <returns>A list containing all primary keys present in the cluster, or null if the cluster is empty.</returns>
        public override List<TKey_1>? GetKeys_1()
        {
            return dictionary.Keys?.ToList();
        }

        /// <summary>
        /// Returns a list of secondary keys associated with the specified primary key.
        /// </summary>
        /// <param name="key_1">The primary key used to look up the secondary keys.</param>
        /// <returns>A list of secondary keys associated with the specified primary key, or null if none are found.</returns>
        public override List<TKey_2>? GetKeys_2(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<TKey_2> result = [];

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            result.AddRange(dictionary_1.Keys);

            return result;
        }

        /// <summary>
        /// Retrieves the value associated with the specified combination of keys.
        /// </summary>
        /// <typeparam name="UValue">The type of the value to retrieve.</typeparam>
        /// <param name="key_1">The first key in the combination.</param>
        /// <param name="key_2">The second key in the combination.</param>
        /// <returns>The value associated with the specified keys, or null if no such value exists.</returns>
        public UValue? GetValue<UValue>(TKey_1? key_1, TKey_2? key_2) where UValue : TValue
        {
            if (key_1 == null || key_2 == null)
            {
                return default;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return default;
            }

            if (!dictionary_1.TryGetValue(key_2, out TValue value))
            {
                return default;
            }

            if (value is UValue result)
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Retrieves the first value that satisfies the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value to retrieve.</typeparam>
        /// <param name="func">A function to test each element for a condition.</param>
        /// <returns>The first value that satisfies the specified predicate, or null if no such value is found.</returns>
        public override UValue? GetValue<UValue>(Func<UValue?, bool>? func) where UValue : default
        {
            foreach (Dictionary<TKey_2, TValue> dictionary_1 in dictionary.Values)
            {
                foreach (TValue? value in dictionary_1.Values)
                {
                    if (value == null)
                    {
                        continue;
                    }

                    if (value is not UValue)
                    {
                        continue;
                    }

                    UValue? u = (UValue?)value;

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

            return default;
        }

        /// <summary>
        /// Retrieves all values associated with the specified primary key.
        /// </summary>
        /// <typeparam name="U">The type of values to retrieve.</typeparam>
        /// <param name="key_1">The primary key used to look up the values.</param>
        /// <returns>A list of values associated with the specified key, or null if no values are found.</returns>
        public override List<U>? GetValues<U>(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<U> result = [];
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            foreach (TValue value in dictionary_1.Values)
            {
                if (value == null || value is not U)
                {
                    continue;
                }

                result.Add((U)value);
            }

            return result;
        }

        /// <summary>
        /// Returns all values contained in the cluster.
        /// </summary>
        /// <typeparam name="U">The type of the values returned.</typeparam>
        /// <returns>A list containing all values in the cluster.</returns>
        public override List<U> GetValues<U>()
        {
            List<U> result = [];
            foreach (Dictionary<TKey_2, TValue> dictionary_1 in dictionary.Values)
            {
                foreach (TValue value in dictionary_1.Values)
                {
                    if (value is U u)
                    {
                        result.Add(u);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Removes all elements associated with the specified primary key from the cluster.
        /// </summary>
        /// <param name="key_1">The primary key used to identify the elements to remove.</param>
        /// <returns>true if one or more elements were removed; otherwise, false.</returns>
        public override bool Remove(TKey_1? key_1)
        {
            if (key_1 is null)
            {
                return false;
            }

            return dictionary.Remove(key_1);
        }

        /// <summary>
        /// Removes the element associated with the specified combination of keys from the cluster.
        /// </summary>
        /// <param name="key_1">The first key used to identify the element.</param>
        /// <param name="key_2">The second key used to identify the element.</param>
        /// <returns>true if the element was successfully removed; otherwise, false.</returns>
        public override bool Remove(TKey_1? key_1, TKey_2? key_2)
        {
            if (key_1 is null || key_2 is null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            return dictionary_1.Remove(key_2);
        }

        /// <summary>
        /// Removes the first occurrence of a specific value from the cluster.
        /// </summary>
        /// <param name="value">The value to remove from the cluster.</param>
        /// <returns>true if the value was successfully removed; otherwise, false.</returns>
        public override bool Remove(TValue? value)
        {
            if (value == null)
            {
                return false;
            }

            TKey_1? key_1 = GetKey_1(value);
            if (key_1 is null)
            {
                return false;
            }

            TKey_2? key_2 = GetKey_2(value);
            if (key_2 is null)
            {
                return false;
            }

            return Remove(key_1, key_2);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified combination of keys.
        /// </summary>
        /// <typeparam name="UValue">The type of the value to be retrieved.</typeparam>
        /// <param name="key_1">The first key used to identify the value.</param>
        /// <param name="key_2">The second key used to identify the value.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified keys, if found; otherwise, the default value for the type of the value parameter.</param>
        /// <returns>true if the value was found; otherwise, false.</returns>
        public bool TryGetValue<UValue>(TKey_1? key_1, TKey_2? key_2, out UValue? value) where UValue : TValue
        {
            value = GetValue<UValue>(key_1, key_2);
            return value != null;
        }
    }
}