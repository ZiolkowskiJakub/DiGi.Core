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

        public Cluster(IEnumerable<TValue> values)
        {
            SetValues(values);
        }

        public Cluster(Cluster<TKey_1, TKey_2, TValue> cluster)
        {
            SetValues(cluster);
        }

        [JsonInclude, JsonPropertyName("Values")]
        public List<TValue> Values
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

        public abstract bool Add(TValue value);

        public List<U> AddRange<U>(IEnumerable<U> values) where U : TValue
        {
            if (values == null)
            {
                return null;
            }

            List<U> result = new List<U>();
            foreach (U value in values)
            {
                if (Add(value))
                {
                    result.Add(value);
                }
            }

            return result;
        }

        public abstract void Clear();

        public abstract bool Contains(TKey_1 key_1);

        public abstract bool Contains(TKey_1 key_1, TKey_2 key_2);

        public abstract bool Contains(TValue value);

        public IEnumerator<TValue> GetEnumerator()
        {
            List<TValue> values = Values;
            if (values == null)
            {
                values = new List<TValue>();
            }

            return values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual List<U> GetValues<U>(TKey_1 key_1) where U : TValue
        {
            List<U> values = GetValues<U>();
            if (values == null)
            {
                return null;
            }

            List<U> result = new List<U>();
            foreach (U value in values)
            {
                if (key_1.Equals(GetKey_1(value)))
                {
                    result.Add(value);
                }
            }

            return result;
        }

        public List<U> GetValues<U>(Func<U, bool> func) where U : TValue
        {
            List<U> result = GetValues<U>();
            if (func == null || result == null || result.Count == 0)
            {
                return result;
            }

            int count = result.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (func.Invoke(result[i]))
                {
                    continue;
                }

                result.RemoveAt(i);
            }

            return result;
        }

        public virtual U GetValue<U>(Func<U, bool> func) where U : TValue
        {
            List<U> values = GetValues(func);
            if (values == null || values.Count == 0)
            {
                return default;
            }

            return values[0];
        }

        public bool TryGetValues<U>(TKey_1 key_1, out List<U> values) where U : TValue
        {
            values = GetValues<U>(key_1);
            return values != null && values.Count != 0;
        }

        public virtual bool IsValid(TValue value)
        {
            return value != null;
        }

        public abstract bool Remove(TKey_1 key_1);

        public abstract bool Remove(TKey_1 key_1, TKey_2 key_2);

        public abstract bool Remove(TValue value);

        protected abstract TKey_1 GetKey_1(TValue value);

        protected abstract TKey_2 GetKey_2(TValue value);

        protected virtual List<TKey_1> GetKeys_1()
        {
            List<TValue> values = GetValues<TValue>();
            if (values == null)
            {
                return null;
            }

            HashSet<TKey_1> result = new HashSet<TKey_1>();
            foreach (TValue value in values)
            {
                TKey_1 key_1 = GetKey_1(value);
                if (key_1 == null)
                {
                    continue;
                }

                result.Add(key_1);
            }

            return result.ToList();
        }

        protected abstract List<U> GetValues<U>() where U : TValue;

        protected bool SetValues(IEnumerable<TValue> values)
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