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

        public virtual List<int> GetIndexes<U>(TKey_1 key_1, TKey_2 key_2, Func<U, bool> func) where U : TValue
        {
            if (key_1 == null || key_2 == null)
            {
                return null;
            }

            List<int> result = new List<int>();

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

                if (!(value is U))
                {
                    continue;
                }

                U u = (U)value;

                if (func != null && !func.Invoke(u))
                {
                    continue;
                }

                result.Add(i);
            }

            return result;
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

        public U GetValue<U>(ListClusterReference<TKey_1, TKey_2> listClusterReference) where U : TValue
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

            return values[index] is U ? (U)values[index] : default;
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

        public List<U> GetValues<U>(TKey_1 key_1, TKey_2 key_2, Func<U, bool> func) where U : TValue
        {
            if (key_1 == null || key_2 == null)
            {
                return null;
            }

            List<int> indexes = GetIndexes(key_1, key_2, func);
            if (indexes == null)
            {
                return null;
            }

            return GetValues<U>(key_1, key_2, indexes);
        }

        public List<U> GetValues<U>(TKey_1 key_1, TKey_2 key_2, IEnumerable<int> indexes) where U : TValue
        {
            if (key_1 == null || key_2 == null || indexes == null)
            {
                return null;
            }

            List<U> result = new List<U>();

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
                if (value is U)
                {
                    result.Add((U)value);
                }
            }

            return result;
        }

        public List<U> GetValues<U>(IEnumerable<ListClusterReference<TKey_1, TKey_2>> listClusterReferences) where U : TValue
        {
            if (listClusterReferences == null)
            {
                return null;
            }

            List<U> result = new List<U>();
            foreach (ListClusterReference<TKey_1, TKey_2> listClusterReference in listClusterReferences)
            {
                U u = GetValue<U>(listClusterReference);
                if(u == null)
                {
                    continue;
                }

                result.Add(u);
            }

            return result;
        }

        public List<TValue> Remove(IEnumerable<ListClusterReference<TKey_1, TKey_2>> listClusterReferences)
        {
            if(listClusterReferences == null)
            {
                return null;
            }

            List<ListClusterReference<TKey_1, TKey_2>> listClusterReferences_Temp = new List<ListClusterReference<TKey_1, TKey_2>>(listClusterReferences);

            List<TValue> result = new List<TValue>();

            while (listClusterReferences_Temp.Count > 0)
            {
                ListClusterReference<TKey_1, TKey_2> listClusterReference = listClusterReferences_Temp[0];
                if(listClusterReference == null || listClusterReference.Key_1 == null || listClusterReference.Key_2 == null)
                {
                    listClusterReferences_Temp.RemoveAt(0);
                    continue;
                }

                List<ListClusterReference<TKey_1, TKey_2>> listClusterReferences_Temp_Temp = listClusterReferences_Temp.FindAll(x => listClusterReference.Key_1.Equals(x.Key_1) && listClusterReference.Key_2.Equals(x.Key_2));
                listClusterReferences_Temp.RemoveAll(x => listClusterReferences_Temp_Temp.Contains(x));


                List<TValue> values = Remove(listClusterReference.Key_1, listClusterReference.Key_2, listClusterReferences_Temp_Temp.ConvertAll(x => x.Index));
                if(values != null)
                {
                    result.AddRange(values);
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

            bool result = dictionary_1.Remove(key_2);
            if(dictionary_1.Count == 0)
            {
                dictionary.Remove(key_1);
            }

            return result;
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

            if (values.Count == 0)
            {
                if(dictionary_1.Remove(key_2))
                {
                    if(dictionary_1.Count == 0)
                    {
                        dictionary.Remove(key_1);
                    }
                }
            }

            return result;
        }

        public TValue Remove(TKey_1 key_1, TKey_2 key_2, int index)
        {
            if(index == -1 || key_1 == null || key_2 == null)
            {
                return default;
            }

            List<TValue> values = Remove(key_1, key_2, new int[] { index });

            return values == null || values.Count == 0 ? default : values[0];
        }

        public List<TValue> Remove(TKey_1 key_1, TKey_2 key_2, IEnumerable<int> indexes)
        {
            if(key_1 == null || key_2 == null || indexes == null || indexes.Count() == 0)
            {
                return null;
            }

            List<TValue> result = new List<TValue>();

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            if (!dictionary_1.TryGetValue(key_2, out List<TValue> values) || values == null)
            {
                return result;
            }

            List<int> indexes_Temp = indexes.Distinct().ToList();
            indexes_Temp.Sort((x, y) => y.CompareTo(x));

            for (int i = indexes_Temp.Count - 1; i >= 0; i--)
            {
                if (i >= values.Count)
                {
                    continue;
                }

                result.Add(values[i]);
                values.RemoveAt(i);
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

            if (!dictionary.TryGetValue(key_1, out Dictionary<TKey_2, List<TValue>> dictionary_1) || dictionary_1 == null)
            {
                return result;
            }

            result.AddRange(dictionary_1.Keys);

            return result;
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
    }
}
