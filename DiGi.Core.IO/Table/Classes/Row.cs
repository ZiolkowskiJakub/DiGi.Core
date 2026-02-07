using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Table.Classes
{
    public class Row : ITableObject
    {
        private readonly int index = -1;
        private readonly SortedDictionary<int, object?> values = [];

        public Row(int index)
        {
            this.index = index;
        }

        public Row(int index, IDictionary<int, object?>? values)
            : this(index)
        {
            if (values != null)
            {
                this.values = new SortedDictionary<int, object?>(values);
            }
        }

        public Row(IDictionary<int, object?>? values)
        {
            if (values != null)
            {
                this.values = new SortedDictionary<int, object?>(values);
            }
        }

        public Row(Row? row)
        {
            if (row != null)
            {
                index = row.index;
                if (row.values != null)
                {
                    values = new SortedDictionary<int, object?>(row.values);
                }
            }
        }

        public Row(int index, Row? row)
        {
            this.index = index;
            if (row != null)
            {
                values = new SortedDictionary<int, object?>(row.values);
            }
        }

        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
        }

        public HashSet<int> Indexes
        {
            get
            {
                return [.. values.Keys];
            }
        }

        public object? this[int index]
        {
            get
            {
                if (!values.TryGetValue(index, out object? result))
                {
                    return null;
                }

                return result;
            }
        }

        public T? GetValue<T>(int index, T? defaultValue = default, bool tryConvert = true)
        {
            if (!values.TryGetValue(index, out object? value))
            {
                return defaultValue;
            }

            if (value is T t)
            {
                return t;
            }

            if (!tryConvert)
            {
                return defaultValue;
            }

            if (!DiGi.Core.Query.TryConvert(value, out T? result))
            {
                return defaultValue;
            }

            return result;
        }

        public object?[] GetValues()
        {
            int count = values.Keys.Last() + 1;

            object?[] result = new object[count];

            foreach (int index in values.Keys)
            {
                result[index] = values[index];
            }

            return result;
        }

        public bool RemoveValue(int index)
        {
            return values.Remove(index);
        }

        public List<int>? RemoveValues(IEnumerable<int>? indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            List<int> result = [];
            if (values.Count == 0)
            {
                return result;
            }

            foreach (int index in indexes)
            {
                if (values.Remove(index))
                {
                    result.Add(index);
                }
            }

            return result;
        }

        public void SetValue(int index, object? value)
        {
            values[index] = value;
        }

        public bool TryGetValue<T>(int index, out T? value)
        {
            if (!DiGi.Core.Query.TryConvert(this[index], out value))
            {
                return false;
            }

            return true;
        }
    }
}