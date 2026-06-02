using DiGi.Core.IO.Table.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Table.Classes
{
    /// <summary>
    /// Represents a base row in a table, providing functionality to manage column values by index.
    /// </summary>
    /// <typeparam name="TRow">The type of the row.</typeparam>
    public abstract class Row<TRow> : IRow<TRow> where TRow : Row<TRow>
    {
        private readonly int index = -1;
        private readonly SortedDictionary<int, object?> values = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="Row{TRow}"/> class with a specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        public Row(int index)
        {
            this.index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row{TRow}"/> class with a specified index and initial values.
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="values">A dictionary containing column indices and their corresponding values.</param>
        public Row(int index, IDictionary<int, object?>? values)
            : this(index)
        {
            if (values != null)
            {
                this.values = new SortedDictionary<int, object?>(values);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row{TRow}"/> class with initial values.
        /// </summary>
        /// <param name="values">A dictionary containing column indices and their corresponding values.</param>
        public Row(IDictionary<int, object?>? values)
        {
            if (values != null)
            {
                this.values = new SortedDictionary<int, object?>(values);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row{TRow}"/> class by copying another row.
        /// </summary>
        /// <param name="row">The source row to copy from.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Row{TRow}"/> class with a specified index and values copied from another row.
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="row">The source row to copy properties from.</param>
        public Row(int index, Row? row)
        {
            this.index = index;
            if (row != null)
            {
                values = new SortedDictionary<int, object?>(row.values);
            }
        }

        /// <summary>
        /// Gets the number of values currently stored in the row.
        /// </summary>
        public int Count
        {
            get
            {
                return values.Count;
            }
        }

        /// <summary>
        /// Gets the zero-based index of the row.
        /// </summary>
        public int Index
        {
            get
            {
                return index;
            }
        }

        /// <summary>
        /// Gets a set of all column indices that have values assigned in this row.
        /// </summary>
        public HashSet<int> Indexes
        {
            get
            {
                return [.. values.Keys];
            }
        }

        /// <summary>
        /// Gets or sets the value for the specified column index.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
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

        /// <summary>
        /// Creates a shallow copy of the current row.
        /// </summary>
        /// <returns>A new instance of the row with copied values.</returns>
        public abstract TRow? Clone();

        /// <summary>
        /// Retrieves the value for the specified index, optionally converting it to the requested type.
        /// </summary>
        /// <typeparam name="T">The target type of the value.</typeparam>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="defaultValue">The value to return if no value is found or conversion fails.</param>
        /// <param name="tryConvert">Whether to attempt converting the value to type <typeparam typeparamref="T"/>.</param>
        /// <returns>The value at the specified index converted to <typeparam typeparamref="T"/>, or the defaultValue.</returns>
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

        /// <summary>
        /// Retrieves all values in the row as an array.
        /// </summary>
        /// <returns>An array of values where the array index corresponds to the column index.</returns>
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

        /// <summary>
        /// Removes the value for the specified index from the row.
        /// </summary>
        /// <param name="index">The zero-based index of the column to remove.</param>
        /// <returns>True if the value was successfully removed; otherwise, false.</returns>
        public bool RemoveValue(int index)
        {
            return values.Remove(index);
        }

        /// <summary>
        /// Attempts to retrieve and convert the value for the specified index to the requested type.
        /// </summary>
        /// <typeparam name="T">The target type of the value.</typeparam>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="value">When this method returns, contains the value if retrieval and conversion succeeded; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <returns>True if the value was successfully retrieved and converted; otherwise, false.</returns>
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

    /// <summary>
    /// Represents a concrete implementation of a table row.
    /// </summary>
    public sealed class Row : Row<Row>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Row"/> class with a specified index and initial values.
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <param name="values">A dictionary containing column indices and their corresponding values.</param>
        public Row(int index, IDictionary<int, object?>? values)
            : base(index, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row"/> class by copying another row.
        /// </summary>
        /// <param name="row">The source row to copy from.</param>
        public Row(Row row)
            : base(row)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Row"/> class with a specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        public Row(int index)
            : base(index)
        {
        }

        /// <summary>
        /// Creates a shallow copy of the current row.
        /// </summary>
        /// <returns>A new instance of the row with copied values.</returns>
        public override Row? Clone()
        {
            return new Row(this);
        }
    }
}