using DiGi.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a generic collection of objects mapped to integer indices.
    /// </summary>
    public class IndexedObjects<T> : SerializableObject, IIndexedObjects<T>
    {
        private readonly SortedDictionary<int, T?> sortedDictionary = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class.
        /// </summary>
        public IndexedObjects()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class from a JSON object.
        /// </summary>
        public IndexedObjects(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class from a collection of values.
        /// </summary>
        public IndexedObjects(IEnumerable<T>? values)
        {
            if (values != null)
            {
                int index = 0;
                foreach (T value in values)
                {
                    sortedDictionary[index] = value;
                    index++;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class from a collection of values starting at a specified index.
        /// </summary>
        public IndexedObjects(IEnumerable<T>? values, int startIndex)
        {
            if (values != null)
            {
                int index = startIndex;
                foreach (T value in values)
                {
                    sortedDictionary[index] = value;
                    index++;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class from a sorted dictionary of indices and values.
        /// </summary>
        public IndexedObjects(SortedDictionary<int, T?>? sortedDictionary)
        {
            if (sortedDictionary != null)
            {
                foreach (KeyValuePair<int, T?> keyValuePair in sortedDictionary)
                {
                    this.sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class by copying another instance.
        /// </summary>
        public IndexedObjects(IndexedObjects<T>? indexedObjects)
            : this(indexedObjects?.sortedDictionary)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedObjects"/> class with a range of indices set to the same value.
        /// </summary>
        public IndexedObjects(int startIndex, int count, T? value)
        {
            int end = startIndex + count;
            for (int i = startIndex; i < end; i++)
            {
                sortedDictionary[i] = value;
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return sortedDictionary.Count;
            }
        }

        /// <summary>
        /// Gets the collection of all indices currently stored.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<int>? Keys
        {
            get
            {
                return sortedDictionary?.Keys;
            }
        }

        /// <summary>
        /// Gets the collection of all values currently stored.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<T?>? Values
        {
            get
            {
                return sortedDictionary?.Values;
            }
        }

        [JsonIgnore]
        public T? this[int index]
        {
            get
            {
                if (!sortedDictionary.TryGetValue(index, out T? value))
                {
                    return default;
                }

                return value;
            }

            set
            {
                sortedDictionary[index] = value;
            }
        }

        /// <summary>
        /// Adds or updates a value at the specified index. Returns true if the operation succeeded.
        /// </summary>
        public bool Add(int index, T? value)
        {
            sortedDictionary[index] = value;
            return true;
        }

        /// <summary>
        /// Adds or updates values across a specified range of indices. Returns true if the operation succeeded.
        /// </summary>
        public bool Add(Range<int> range, T? value)
        {
            for (int i = range.Min; i <= range.Max; i++)
            {
                sortedDictionary[i] = value;
            }

            return true;
        }

        /// <summary>
        /// Determines whether the collection contains an element at the specified index.
        /// </summary>
        public bool ContainsIndex(int index)
        {
            if (index == -1)
            {
                return false;
            }

            foreach (int index_Temp in sortedDictionary.Keys)
            {
                if (index == index_Temp)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Populates the current instance from a JSON object. Returns true if successful.
        /// </summary>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject is null)
            {
                return false;
            }

            bool result = base.FromJsonObject(jsonObject);
            if (!result)
            {
                return result;
            }

            if (jsonObject.TryGetPropertyValue("Values", out JsonNode? jsonNode) && jsonNode != null)
            {
                JsonArray jsonArray = jsonNode.AsArray();
                foreach (JsonNode? jsonNode_Temp in jsonArray)
                {
                    if (jsonNode_Temp is not JsonObject jsonObject_Temp)
                    {
                        continue;
                    }

                    if (!jsonObject_Temp.TryGetPropertyValue("Index", out JsonNode? jsonNode_Index) || !jsonObject_Temp.TryGetPropertyValue("Value", out JsonNode? jsonNode_Value))
                    {
                        continue;
                    }

                    if (jsonNode_Index is null)
                    {
                        continue;
                    }

                    object? value = Query.Value(jsonNode_Value, typeof(T));
                    if (value is T t)
                    {
                        sortedDictionary[(int)jsonNode_Index] = t;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of values.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            if (sortedDictionary?.Values is null)
            {
                return Enumerable.Empty<T>().GetEnumerator();
            }

            return sortedDictionary.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the highest index present in the collection, or null if empty.
        /// </summary>
        public int? GetMaxIndex()
        {
            IEnumerable<int>? keys = Keys;
            if (keys == null || keys.Count() == 0)
            {
                return null;
            }

            return keys.Max(x => x);
        }

        /// <summary>
        /// Gets the lowest index present in the collection, or null if empty.
        /// </summary>
        public int? GetMinIndex()
        {
            IEnumerable<int>? keys = Keys;
            if (keys == null || keys.Count() == 0)
            {
                return null;
            }

            return keys.Min(x => x);
        }

        /// <summary>
        /// Retrieves the value at the specified index.
        /// </summary>
        public T? GetValue(int index)
        {
            return this[index];
        }

        /// <summary>
        /// Retrieves a list of values within the specified range.
        /// </summary>
        public List<T?>? GetValues(Range<int>? range)
        {
            if (range is null)
            {
                return null;
            }

            List<T?> result = [];
            for (int i = range.Min; i <= range.Max; i++)
            {
                if (!sortedDictionary.TryGetValue(i, out T? value))
                {
                    value = default;
                }

                result.Add(value);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of values within the specified range, with an option to bound the results.
        /// </summary>
        public List<T?>? GetValues(Range<int>? range, bool bounded)
        {
            if (range is null)
            {
                return null;
            }

            if (!bounded)
            {
                return GetValues(range);
            }

            int? minIndex = GetMinIndex();
            if (minIndex is null)
            {
                return null;
            }

            int? maxIndex = GetMaxIndex();
            if (maxIndex is null)
            {
                return null;
            }

            Range<int> range_Temp = new(minIndex.Value, maxIndex.Value);

            List<T?> result = [];
            for (int i = range.Min; i <= range.Max; i++)
            {
                int index = Query.BoundedIndex(range_Temp, i);

                if (!sortedDictionary.TryGetValue(index, out T? value))
                {
                    value = default;
                }

                result.Add(value);
            }

            return result;
        }

        /// <summary>
        /// Removes the element at the specified index. Returns true if the element was found and removed.
        /// </summary>
        public bool Remove(int index)
        {
            return sortedDictionary.Remove(index);
        }

        /// <summary>
        /// Serializes the current instance into a JSON object.
        /// </summary>
        public override JsonObject? ToJsonObject()
        {
            JsonObject? result = base.ToJsonObject();
            if (result == null)
            {
                return null;
            }

            if (sortedDictionary != null)
            {
                JsonArray jsonArray = [];
                foreach (KeyValuePair<int, T?> keyValuePair in sortedDictionary)
                {
                    JsonObject jsonObject_Temp = new()
                    {
                        { "Index", keyValuePair.Key },
                        { "Value", Create.JsonNode(keyValuePair.Value) }
                    };

                    jsonArray.Add(jsonObject_Temp);
                }

                result["Values"] = jsonArray;
            }

            return result;
        }

        /// <summary>
        /// Attempts to get the value associated with the specified index. Returns true if found.
        /// </summary>
        public bool TryGetValue(int index, out T? result)
        {
            if (!sortedDictionary.ContainsKey(index))
            {
                result = default;
                return false;
            }

            result = sortedDictionary[index];
            return true;
        }
    }
}