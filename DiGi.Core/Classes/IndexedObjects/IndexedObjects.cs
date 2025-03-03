using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Collections;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class IndexedObjects<T> : SerializableObject, IIndexedObjects<T>
    {
        SortedDictionary<int, T> sortedDictionary = new SortedDictionary<int, T>();

        public IndexedObjects()
        {

        }

        public IndexedObjects(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public IndexedObjects(IEnumerable<T> values)
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

        public IndexedObjects(IEnumerable<T> values, int startIndex)
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

        public IndexedObjects(SortedDictionary<int, T> dictionary)
        {
            if (dictionary != null)
            {
                foreach (KeyValuePair<int, T> keyValuePair in dictionary)
                {
                    sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        public IndexedObjects(IndexedObjects<T> indexedObjects)
            : this(indexedObjects?.sortedDictionary)
        {

        }

        public IndexedObjects(int startIndex, int count, T value)
        {
            int end = startIndex + count;
            for (int i = startIndex; i < end; i++)
            {
                sortedDictionary[i] = value;
            }
        }

        [JsonIgnore]
        public T this[int index]
        {
            get
            {
                if (!sortedDictionary.TryGetValue(index, out T value))
                {
                    return default(T);
                }

                return value;
            }

            set
            {
                sortedDictionary[index] = value;
            }
        }

        public bool TryGetValue(int index, out T result)
        {
            if (!sortedDictionary.ContainsKey(index))
            {
                result = default(T);
                return false;
            }

            result = sortedDictionary[index];
            return true;
        }

        public T GetValue(int index)
        {
            return this[index];
        }

        public List<T> GetValues(Range<int> range)
        {
            if (range == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            for (int i = range.Min; i <= range.Max; i++)
            {
                if (!sortedDictionary.TryGetValue(i, out T value))
                {
                    value = default(T);
                }

                result.Add(value);
            }

            return result;
        }

        public List<T> GetValues(Range<int> range, bool bounded)
        {
            if (range == null)
            {
                return null;
            }

            if (!bounded)
            {
                return GetValues(range);
            }

            Range<int> range_Temp = new Range<int>(GetMinIndex().Value, GetMaxIndex().Value);

            List<T> result = new List<T>();
            for (int i = range.Min; i <= range.Max; i++)
            {
                int index = Query.BoundedIndex(range_Temp, i);

                if (!sortedDictionary.TryGetValue(index, out T value))
                {
                    value = default(T);
                }

                result.Add(value);
            }

            return result;
        }

        public bool Add(int index, T value)
        {
            sortedDictionary[index] = value;
            return true;
        }

        public bool Add(Range<int> range, T value)
        {
            for (int i = range.Min; i <= range.Max; i++)
            {
                sortedDictionary[i] = value;
            }

            return true;
        }

        public bool Remove(int index)
        {
            return sortedDictionary.Remove(index);
        }

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

        [JsonIgnore]
        public int Count
        {
            get
            {
                return sortedDictionary.Count;
            }
        }

        [JsonIgnore]
        public IEnumerable<T> Values
        {
            get
            {
                return sortedDictionary?.Values;
            }
        }

        [JsonIgnore]
        public IEnumerable<int> Keys
        {
            get
            {
                return sortedDictionary?.Keys;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return sortedDictionary?.Values?.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int? GetMinIndex()
        {
            IEnumerable<int> keys = Keys;
            if (keys == null || keys.Count() == 0)
            {
                return null;
            }

            return keys.Min(x => x);
        }

        public int? GetMaxIndex()
        {
            IEnumerable<int> keys = Keys;
            if (keys == null || keys.Count() == 0)
            {
                return null;
            }

            return keys.Max(x => x);
        }

        public override bool FromJsonObject(JsonObject jsonObject)
        {
            bool result = base.FromJsonObject(jsonObject);
            if(!result)
            {
                return result;
            }

            if(jsonObject.TryGetPropertyValue("Values", out JsonNode jsonNode) && jsonNode != null)
            {
                JsonArray jsonArray = jsonNode.AsArray();
                foreach(JsonObject jsonObject_Temp in jsonArray)
                {
                    if(!jsonObject_Temp.TryGetPropertyValue("Index", out JsonNode jsonNode_Index) || !jsonObject_Temp.TryGetPropertyValue("Value", out JsonNode jsonNode_Value))
                    {
                        continue;
                    }

                    object value = Query.Value(jsonNode_Value, typeof(T));
                    if(value is T)
                    {
                        sortedDictionary[(int)jsonNode_Index] = (T)value;
                    }
                }
            }

            return result;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject result = base.ToJsonObject();
            if(result == null)
            {
                return null;
            }

            if(sortedDictionary != null)
            {
                JsonArray jsonArray = new JsonArray();
                foreach(KeyValuePair<int, T> keyValuePair in sortedDictionary)
                {
                    JsonObject jsonObject_Temp = new JsonObject();
                    jsonObject_Temp.Add("Index", keyValuePair.Key);
                    jsonObject_Temp.Add("Value", Create.JsonNode(keyValuePair.Value));

                    jsonArray.Add(jsonObject_Temp);
                }

                result["Values"] = jsonArray;
            }

            return result;
        }
    }
}
