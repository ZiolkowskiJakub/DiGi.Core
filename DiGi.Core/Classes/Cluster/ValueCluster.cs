using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ValueCluster<TKey_1, TKey_2, TValue> : Cluster<TKey_1, TKey_2, TValue>
    {
        [JsonIgnore]
        private readonly Dictionary<TKey_1, Dictionary<TKey_2, TValue>> dictionary = [];

        public ValueCluster()
        {
        }

        public ValueCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        public ValueCluster(ValueCluster<TKey_1, TKey_2, TValue>? valueCluster)
            : base(valueCluster)
        {
        }

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

        public override void Clear()
        {
            dictionary.Clear();
        }

        public override bool Contains(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return false;
            }

            return dictionary.ContainsKey(key_1);
        }

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

        public override List<TKey_1>? GetKeys_1()
        {
            return dictionary.Keys?.ToList();
        }

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

        public override bool Remove(TKey_1? key_1)
        {
            if (key_1 is null)
            {
                return false;
            }

            return dictionary.Remove(key_1);
        }

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

        public bool TryGetValue<UValue>(TKey_1? key_1, TKey_2? key_2, out UValue? value) where UValue : TValue
        {
            value = GetValue<UValue>(key_1, key_2);
            return value != null;
        }
    }
}