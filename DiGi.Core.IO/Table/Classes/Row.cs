using DiGi.Core.IO.Table.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Table.Classes
{
    public abstract class Row<TRow> : IRow<TRow> where TRow : Row<TRow>
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

            set
            {
                values[index] = value;
            }
        }

        public abstract TRow? Clone();

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

        public bool TryGetValue<T>(int index, out T? value)
        {
            value = default;

            if (!values.TryGetValue(index, out object? value_Temp))
            {
                return false;
            }

            if (!DiGi.Core.Query.TryConvert(value_Temp, out value))
            {
                return false;
            }

            return true;
        }
    }

    public sealed class Row : Row<Row>
    {
        public Row(int index, IDictionary<int, object?>? values)
            : base (index, values)
        {

        }

        public Row(Row row)
            : base(row)
        {

        }

        public Row(int index)
            : base(index)
        {

        }

        public override Row? Clone()
        {
            return new Row(this);
        }
    }
}