using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ValueCluster<TKey_1, TKey_2, TValue> : Cluster<TKey_1, TKey_2, TValue>
    {
        [JsonIgnore]
        private Dictionary<TKey_1, Dictionary<TKey_2, TValue>> dictionary = new Dictionary<TKey_1, Dictionary<TKey_2, TValue>>();

        public ValueCluster()
        {
        }

        public ValueCluster(IEnumerable<TValue> values)
            : base(values)
        {
        }

        public ValueCluster(ValueCluster<TKey_1, TKey_2, TValue> valueCluster)
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

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                dictionary_1 = new Dictionary<TKey_2, TValue>();
                dictionary[key_1] = dictionary_1;
            }

            dictionary_1[key_2] = value;
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
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
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

            return Contains(key_1, key_2);
        }

        public override List<U> GetValues<U>(TKey_1 key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<U> result = new List<U>();
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            foreach (TValue value in dictionary_1.Values)
            {
                if (value == null || !(Values is U))
                {
                    continue;
                }

                result.Add((U)value);
            }

            return result;
        }

        public override bool Remove(TKey_1 key_1)
        {
            return dictionary.Remove(key_1);
        }

        public override bool Remove(TKey_1 key_1, TKey_2 key_2)
        {
            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
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

            return Remove(key_1, key_2);
        }

        public U GetValue<U>(TKey_1 key_1, TKey_2 key_2) where U : TValue
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

            if (value is U)
            {
                return (U)value;
            }

            return default;
        }

        public bool TryGetValue<U>(TKey_1 key_1, TKey_2 key_2, out U value) where U : TValue
        {
            value = GetValue<U>(key_1, key_2);
            return value != null;
        }

        protected override List<U> GetValues<U>()
        {
            List<U> result = new List<U>();
            foreach (Dictionary<TKey_2, TValue> dictionary_1 in dictionary.Values)
            {
                foreach (TValue value in dictionary_1.Values)
                {
                    if (value is U)
                    {
                        result.Add((U)value);
                    }
                }
            }

            return result;
        }

        protected override List<TKey_1> GetKeys_1()
        {
            return dictionary.Keys?.ToList();
        }

        protected override List<TKey_2> GetKeys_2(TKey_1 key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<TKey_2> result = new List<TKey_2>();

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, TValue> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            result.AddRange(dictionary_1.Keys);

            return result;
        }

        public override U GetValue<U>(Func<U, bool> func)
        {
            foreach (Dictionary<TKey_2, TValue> dictionary_1 in dictionary.Values)
            {
                foreach (TValue value in dictionary_1.Values)
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

            return default;
        }
    }
}