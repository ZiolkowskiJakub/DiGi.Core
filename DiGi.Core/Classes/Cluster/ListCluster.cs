using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ListCluster<TKey_1, TKey_2, TValue> : Cluster<TKey_1, TKey_2, TValue>
    {
        [JsonIgnore]
        private Dictionary<TKey_1, Dictionary<TKey_2, List<TValue>>> dictionary = new Dictionary<TKey_1, Dictionary<TKey_2, List<TValue>>>();

        public ListCluster()
        {
        }

        public ListCluster(IEnumerable<TValue> values)
            : base(values)
        {
        }

        public ListCluster(ListCluster<TKey_1, TKey_2, TValue> valueCluster)
            : base(valueCluster)
        {
        }

        public override bool Add(TValue value)
        {
            if (value == null || !IsValid(value))
            {
                return false;
            }

            TKey_1 key_1 = GetKey_1(value);
            if (key_1 == null)
            {
                return false;
            }

            TKey_2 key_2 = GetKey_2(value);
            if (key_2 == null)
            {
                return false;
            }

            if (dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                dictionary_1 = new Dictionary<TKey_2, List<TValue>>();
                dictionary[key_1] = dictionary_1;
            }

            if (dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                values = new List<TValue>();
                dictionary_1[key_2] = values;
            }

            values.Add(value);
            return true;
        }

        public override void Clear()
        {
            dictionary.Clear();
        }

        public override bool Contains(TKey_1 key_1)
        {
            return dictionary.ContainsKey(key_1);
        }

        public override bool Contains(TKey_1 key_1, TKey_2 key_2)
        {
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            return dictionary_1.ContainsKey(key_2);
        }

        public override bool Contains(TValue value)
        {
            if (value == null)
            {
                return false;
            }

            return TryGetIndex(value, out TKey_1 key_1, out TKey_2 key_2, out int index) && index != -1;
        }

        public virtual bool Equals(TValue value_1, TValue value_2)
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

        public override List<U> GetValues<U>(TKey_1 key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<U> result = new List<U>();
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
                    if (values[i] is U)
                    {
                        result.Add((U)values[i]);
                    }
                }
            }

            return result;
        }

        public override bool Remove(TKey_1 key_1)
        {
            return dictionary.Remove(key_1);
        }

        public override bool Remove(TKey_1 key_1, TKey_2 key_2)
        {
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return false;
            }

            return dictionary_1.Remove(key_2);
        }

        public override bool Remove(TValue value)
        {
            if (value == null)
            {
                return false;
            }

            TKey_1 key_1 = GetKey_1(value);
            if (key_1 == null)
            {
                return false;
            }

            TKey_2 key_2 = GetKey_2(value);
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

            return result;
        }

        public bool TryGetIndex(TValue value, out TKey_1 key_1, out TKey_2 key_2, out int index)
        {
            key_1 = default;
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

        protected override List<U> GetValues<U>()
        {
            List<U> result = new List<U>();
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
                        if (values[i] is U)
                        {
                            result.Add((U)values[i]);
                        }
                    }
                }
            }

            return result;
        }

        protected override List<TKey_1> GetKeys_1()
        {
            return dictionary.Keys?.ToList();
        }

        public override U GetValue<U>(Func<U, bool> func)
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

                        if (!(value is U))
                        {
                            continue;
                        }

                        U u = (U)value;

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
    }
}
