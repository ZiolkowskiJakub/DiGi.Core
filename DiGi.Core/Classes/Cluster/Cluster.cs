using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class Cluster<TKey_1, TKey_2, TValue> : IObject, IEnumerable<TValue>
    {
        public Cluster()
        {
        }

        public Cluster(IEnumerable<TValue>? values)
        {
            SetValues(values);
        }

        public Cluster(Cluster<TKey_1, TKey_2, TValue>? cluster)
        {
            SetValues(cluster);
        }

        [JsonInclude, JsonPropertyName("Values")]
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

        public abstract bool Add(TValue? value);

        public List<UValue>? AddRange<UValue>(IEnumerable<UValue?>? values) where UValue : TValue
        {
            if (values == null)
            {
                return null;
            }

            List<UValue> result = [];
            foreach (UValue? value in values)
            {
                if (value is null)
                {
                    continue;
                }

                if (Add(value))
                {
                    result.Add(value);
                }
            }

            return result;
        }

        public abstract void Clear();

        public abstract bool Contains(TKey_1? key_1);

        public abstract bool Contains(TKey_1? key_1, TKey_2? key_2);

        public abstract bool Contains(TValue? value);

        public IEnumerator<TValue> GetEnumerator()
        {
            return Values?.GetEnumerator() ?? Enumerable.Empty<TValue>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual List<TKey_1>? GetKeys_1()
        {
            List<TValue>? values = GetValues<TValue>();
            if (values == null)
            {
                return null;
            }

            HashSet<TKey_1> result = [];
            foreach (TValue value in values)
            {
                TKey_1? key_1 = GetKey_1(value);
                if (key_1 == null)
                {
                    continue;
                }

                result.Add(key_1);
            }

            return [.. result];
        }

        public virtual List<TKey_2>? GetKeys_2(TKey_1? key_1)
        {
            if (key_1 == null)
            {
                return null;
            }

            List<TValue>? values = GetValues<TValue>();
            if (values == null)
            {
                return null;
            }

            HashSet<TKey_2> result = [];
            foreach (TValue value in values)
            {
                if (!key_1.Equals(GetKey_1(value)))
                {
                    continue;
                }

                TKey_2? key_2 = GetKey_2(value);
                if (key_2 == null)
                {
                    continue;
                }

                result.Add(key_2);
            }

            return [.. result];
        }

        public virtual UValue? GetValue<UValue>(Func<UValue?, bool>? func) where UValue : TValue
        {
            List<UValue>? values = GetValues(func);
            if (values == null || values.Count == 0)
            {
                return default;
            }

            return values[0];
        }

        public virtual List<UValue>? GetValues<UValue>(TKey_1? key_1) where UValue : TValue
        {
            List<UValue>? values = GetValues<UValue>();
            if (values == null)
            {
                return null;
            }

            List<UValue> result = [];
            foreach (UValue value in values)
            {
                if (key_1 == null || key_1.Equals(GetKey_1(value)))
                {
                    result.Add(value);
                }
            }

            return result;
        }

        public List<UValue>? GetValues<UValue>(Func<UValue?, bool>? func) where UValue : TValue
        {
            List<UValue>? result = GetValues<UValue>();
            if (func == null || result == null || result.Count == 0)
            {
                return result;
            }

            int count = result.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (func != null && func.Invoke(result[i]))
                {
                    continue;
                }

                result.RemoveAt(i);
            }

            return result;
        }

        public abstract List<UValue>? GetValues<UValue>() where UValue : TValue;

        public virtual bool IsValid(TValue? value)
        {
            return value != null;
        }

        public abstract bool Remove(TKey_1? key_1);

        public abstract bool Remove(TKey_1? key_1, TKey_2? key_2);

        public abstract bool Remove(TValue? value);

        public bool TryGetValue<UValue>(out UValue? value, Func<UValue?, bool>? func) where UValue : TValue
        {
            value = GetValue(func);
            return value != null;
        }

        public bool TryGetValues<UValue>(TKey_1? key_1, out List<UValue>? values) where UValue : TValue
        {
            values = GetValues<UValue>(key_1);
            return values != null && values.Count != 0;
        }

        public bool TryGetValues<UValue>(out List<UValue>? values, Func<UValue?, bool>? func) where UValue : TValue
        {
            values = GetValues(func);
            return values != null && values.Count != 0;
        }

        protected abstract TKey_1? GetKey_1(TValue? value);

        protected abstract TKey_2? GetKey_2(TValue? value);

        protected bool SetValues(IEnumerable<TValue>? values)
        {
            if (values == null)
            {
                return false;
            }

            Clear();

            foreach (TValue value in values)
            {
                Add(value);
            }
            return true;
        }
    }
}