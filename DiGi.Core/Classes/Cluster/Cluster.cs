using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// An abstract base class for a two-key-indexed collection of values.
    /// </summary>
    /// <typeparam name="TKey_1">The type of the first key.</typeparam>
    /// <typeparam name="TKey_2">The type of the second key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public abstract class Cluster<TKey_1, TKey_2, TValue> : IObject, IEnumerable<TValue>
    {
        /// <summary>
        /// Initializes a new instance of the Cluster class.
        /// </summary>
        public Cluster()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class with the specified values.
        /// </summary>
        /// <param name="values">The values to populate the cluster with.</param>
        public Cluster(IEnumerable<TValue>? values)
        {
            SetValues(values);
        }

        /// <summary>
        /// Initializes a new instance of the Cluster class by cloning another cluster.
        /// </summary>
        /// <param name="cluster">The cluster to clone.</param>
        public Cluster(Cluster<TKey_1, TKey_2, TValue>? cluster)
        {
            SetValues(cluster);
        }

        /// <summary>
        /// Gets or sets the list of values in the cluster.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Values))]
        public List<TValue>? Values
        {
            get
            {
                return GetValues<TValue>();
            }

            set
            {
                SetValues(value);
            }
        }

        /// <summary>
        /// Adds a value to the cluster.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>True if the value was added; otherwise, false.</returns>
        public abstract bool Add(TValue? value);

        /// <summary>
        /// Adds multiple values to the cluster and returns those that were successfully added.
        /// </summary>
        /// <typeparam name="UValue">The type of the values.</typeparam>
        /// <param name="values">The values to add.</param>
        /// <returns>A list of values that were successfully added.</returns>
        public List<UValue>? AddRange<UValue>(IEnumerable<UValue?>? values) where UValue : TValue
        {
            if (values == null)
            {
                return null;
            }

            List<UValue> uValues = [];
            foreach (UValue? value in values)
            {
                if (value is null)
                {
                    continue;
                }

                if (Add(value))
                {
                    uValues.Add(value);
                }
            }

            return uValues;
        }

        /// <summary>
        /// Clears all values from the cluster.
        /// </summary>
        public abstract void Clear();

        /// <summary>
        /// Determines whether the cluster contains a value with the specified first key.
        /// </summary>
        /// <param name="key_1">The first key to locate.</param>
        /// <returns>True if the cluster contains a value with the specified key; otherwise, false.</returns>
        public abstract bool Contains(TKey_1? key_1);

        /// <summary>
        /// Determines whether the cluster contains a value with the specified first and second keys.
        /// </summary>
        /// <param name="key_1">The first key to locate.</param>
        /// <param name="key_2">The second key to locate.</param>
        /// <returns>True if the cluster contains a value with the specified keys; otherwise, false.</returns>
        public abstract bool Contains(TKey_1? key_1, TKey_2? key_2);

        /// <summary>
        /// Determines whether the cluster contains a specific value.
        /// </summary>
        /// <param name="value">The value to locate.</param>
        /// <returns>True if the cluster contains the value; otherwise, false.</returns>
        public abstract bool Contains(TValue? value);

        /// <summary>
        /// Returns an enumerator that iterates through the cluster values.
        /// <para>Derivatives should override this method with a streaming implementation over their internal storage; the base implementation materializes a list via <see cref="GetValues{UValue}()"/>.</para>
        /// </summary>
        /// <returns>An enumerator for the cluster values.</returns>
        public virtual IEnumerator<TValue> GetEnumerator()
        {
            List<TValue>? values = GetValues<TValue>();
            if (values == null)
            {
                yield break;
            }

            int count = values.Count;
            for (int i = 0; i < count; i++)
            {
                yield return values[i];
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the cluster values.
        /// </summary>
        /// <returns>An enumerator for the cluster values.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets a list of all unique first keys in the cluster.
        /// <para>Values are drawn from the cluster's enumeration (<see cref="GetEnumerator"/>), so derivatives with a streaming enumerator avoid the intermediate list allocation.</para>
        /// </summary>
        /// <returns>A list of first keys; empty if the cluster contains none.</returns>
        public virtual List<TKey_1>? GetKeys_1()
        {
            HashSet<TKey_1> keys_1 = [];
            foreach (TValue value in this)
            {
                TKey_1? key_1 = GetKey_1(value);
                if (key_1 == null)
                {
                    continue;
                }

                keys_1.Add(key_1);
            }

            return [.. keys_1];
        }

        /// <summary>
        /// Gets a list of all unique second keys for values with the specified first key.
        /// <para>Values are drawn from the cluster's enumeration (<see cref="GetEnumerator"/>), so derivatives with a streaming enumerator avoid the intermediate list allocation.</para>
        /// </summary>
        /// <param name="key_1">The first key to filter by.</param>
        /// <returns>A list of second keys; empty if the cluster has no matching values, or null if key_1 is null.</returns>
        public virtual List<TKey_2>? GetKeys_2(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            HashSet<TKey_2> keys_2 = [];
            foreach (TValue value in this)
            {
                TKey_1? key_1_Value = GetKey_1(value);
                if (key_1_Value == null || !EqualityComparer<TKey_1>.Default.Equals(key_1, key_1_Value))
                {
                    continue;
                }

                TKey_2? key_2 = GetKey_2(value);
                if (key_2 == null)
                {
                    continue;
                }

                keys_2.Add(key_2);
            }

            return [.. keys_2];
        }

        /// <summary>
        /// Gets the first value matching the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="func">A predicate function to filter values.</param>
        /// <returns>The first matching value, or default if none found.</returns>
        public virtual UValue? GetValue<UValue>(Func<UValue?, bool>? func) where UValue : TValue
        {
            foreach (TValue value in this)
            {
                if (value is not UValue uValue)
                {
                    continue;
                }

                if (func == null || func.Invoke(uValue))
                {
                    return uValue;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets a list of values filtered by the specified first key.
        /// <para>Values are drawn from the cluster's enumeration (<see cref="GetEnumerator"/>), so derivatives with a streaming enumerator avoid the intermediate list allocation.</para>
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="key_1">The first key to filter by.</param>
        /// <returns>A list of matching values; empty if none match, or null if key_1 is null.</returns>
        public virtual List<UValue>? GetValues<UValue>(TKey_1? key_1) where UValue : TValue
        {
            if (key_1 == null)
            {
                return null;
            }

            List<UValue> uValues = [];
            foreach (TValue value in this)
            {
                if (value is not UValue uValue)
                {
                    continue;
                }

                TKey_1? key_1_Value = GetKey_1(value);
                if (key_1_Value == null || !EqualityComparer<TKey_1>.Default.Equals(key_1, key_1_Value))
                {
                    continue;
                }

                uValues.Add(uValue);
            }

            return uValues;
        }

        /// <summary>
        /// Gets a list of values filtered by the specified predicate.
        /// <para>Values are drawn from the cluster's enumeration (<see cref="GetEnumerator"/>), so derivatives with a streaming enumerator avoid the intermediate list allocation.</para>
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="func">A predicate function to filter values; all values are returned when null.</param>
        /// <returns>A list of matching values; empty if none match.</returns>
        public List<UValue>? GetValues<UValue>(Func<UValue?, bool>? func) where UValue : TValue
        {
            List<UValue> uValues = [];
            foreach (TValue value in this)
            {
                if (value is not UValue uValue)
                {
                    continue;
                }

                if (func == null || func.Invoke(uValue))
                {
                    uValues.Add(uValue);
                }
            }

            return uValues;
        }

        /// <summary>
        /// Gets a list of all values of the specified type.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <returns>A list of values, or null if none found.</returns>
        public abstract List<UValue>? GetValues<UValue>() where UValue : TValue;

        /// <summary>
        /// Determines whether the specified value is valid for this cluster.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is valid; otherwise, false.</returns>
        public virtual bool IsValid(TValue? value)
        {
            return value != null;
        }

        /// <summary>
        /// Removes all values with the specified first key.
        /// </summary>
        /// <param name="key_1">The first key to filter by.</param>
        /// <returns>True if any values were removed; otherwise, false.</returns>
        public abstract bool Remove(TKey_1? key_1);

        /// <summary>
        /// Removes all values with the specified first and second keys.
        /// </summary>
        /// <param name="key_1">The first key to filter by.</param>
        /// <param name="key_2">The second key to filter by.</param>
        /// <returns>True if any values were removed; otherwise, false.</returns>
        public abstract bool Remove(TKey_1? key_1, TKey_2? key_2);

        /// <summary>
        /// Removes a specific value from the cluster.
        /// </summary>
        /// <param name="value">The value to remove.</param>
        /// <returns>True if the value was removed; otherwise, false.</returns>
        public abstract bool Remove(TValue? value);

        /// <summary>
        /// Attempts to get the first value matching the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="value">When this method returns, contains the first matching value, or default if no match was found.</param>
        /// <param name="func">A predicate function to filter values.</param>
        /// <returns>True if a matching value was found; otherwise, false.</returns>
        public bool TryGetValue<UValue>(out UValue? value, Func<UValue?, bool>? func) where UValue : TValue
        {
            value = GetValue(func);
            return value != null;
        }

        /// <summary>
        /// Attempts to get the first value matching the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="func">A predicate function to filter values.</param>
        /// <param name="value">When this method returns, contains the first matching value, or default if no match was found.</param>
        /// <returns>True if a matching value was found; otherwise, false.</returns>
        public bool TryGetValue<UValue>(Func<UValue?, bool>? func, out UValue? value) where UValue : TValue
        {
            return TryGetValue(out value, func);
        }

        /// <summary>
        /// Attempts to get values filtered by the specified first key.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="key_1">The first key to filter by.</param>
        /// <param name="values">When this method returns, contains the matching values, or null if none found.</param>
        /// <returns>True if any matching values were found; otherwise, false.</returns>
        public bool TryGetValues<UValue>(TKey_1? key_1, out List<UValue>? values) where UValue : TValue
        {
            values = GetValues<UValue>(key_1);
            return values != null && values.Count != 0;
        }

        /// <summary>
        /// Attempts to get values filtered by the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="values">When this method returns, contains the matching values, or null if none found.</param>
        /// <param name="func">A predicate function to filter values.</param>
        /// <returns>True if any matching values were found; otherwise, false.</returns>
        public bool TryGetValues<UValue>(out List<UValue>? values, Func<UValue?, bool>? func) where UValue : TValue
        {
            values = GetValues(func);
            return values != null && values.Count != 0;
        }

        /// <summary>
        /// Attempts to get values filtered by the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value.</typeparam>
        /// <param name="func">A predicate function to filter values.</param>
        /// <param name="values">When this method returns, contains the matching values, or null if none found.</param>
        /// <returns>True if any matching values were found; otherwise, false.</returns>
        public bool TryGetValues<UValue>(Func<UValue?, bool>? func, out List<UValue>? values) where UValue : TValue
        {
            return TryGetValues(out values, func);
        }

        /// <summary>
        /// Gets the first key for a given value.
        /// </summary>
        /// <param name="value">The value to get the key from.</param>
        /// <returns>The first key, or null.</returns>
        protected abstract TKey_1? GetKey_1(TValue? value);

        /// <summary>
        /// Gets the second key for a given value.
        /// </summary>
        /// <param name="value">The value to get the key from.</param>
        /// <returns>The second key, or null.</returns>
        protected abstract TKey_2? GetKey_2(TValue? value);

        /// <summary>
        /// Sets the cluster values by clearing existing values and adding the specified ones.
        /// </summary>
        /// <param name="values">The values to set.</param>
        /// <returns>True if values were set successfully; otherwise, false.</returns>
        protected bool SetValues(IEnumerable<TValue>? values)
        {
            if (values == null)
            {
                Clear();
                return true;
            }

            if (ReferenceEquals(values, this))
            {
                return true;
            }

            List<TValue> values_Buffered = [.. values];

            Clear();

            foreach (TValue value in values_Buffered)
            {
                Add(value);
            }

            return true;
        }
    }
}