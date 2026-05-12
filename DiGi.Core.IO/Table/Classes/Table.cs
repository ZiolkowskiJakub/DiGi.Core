using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Table.Classes
{
    public class Table<TColumn> : ITableObject where TColumn : IColumn
    {
        private readonly SortedDictionary<int, TColumn> columns = [];
        private readonly SortedDictionary<int, Row> rows = [];

        public Table()
        {
        }

        public Table(IEnumerable<TColumn> columns)
        {
            if (columns is not null)
            {
                foreach (TColumn column in columns)
                {
                    AddColumn(column);
                }
            }
        }

        public int ColumnCount
        {
            get
            {
                return columns.Keys.Count == 0 ? 0 : columns.Keys.Last() + 1;
            }
        }

        public IEnumerable<TColumn> Columns
        {
            get
            {
                return DiGi.Core.Query.CloneAndFilterNulls(columns.Values) ?? [];
            }
        }

        public int RowCount
        {
            get
            {
                return rows.Keys.Count == 0 ? 0 : rows.Keys.Last() + 1;
            }
        }

        public IEnumerable<Row> Rows
        {
            get
            {
                return rows.Values.ToList().ConvertAll(x => new Row(x));
            }
        }

        public object? this[int columnIndex, int rowIndex]
        {
            get
            {
                if (!TryGetValue(columnIndex, rowIndex, out object? result))
                {
                    if (!columns.TryGetValue(columnIndex, out TColumn column) || column == null)
                    {
                        return null;
                    }

                    return DiGi.Core.Query.Default(column.Type);
                }

                return result;
            }
        }

        public object? this[TColumn? column, Row? row]
        {
            get
            {
                if (column == null)
                {
                    return null;
                }

                int columnIndex = column.Index;
                if (!columns.TryGetValue(columnIndex, out _) || column == null)
                {
                    return null;
                }

                if (row == null)
                {
                    return DiGi.Core.Query.Default(column.Type);
                }

                return this[columnIndex, row.Index];
            }
        }

        public TColumn? AddColumn(TColumn? column)
        {
            if (column == null)
            {
                return default;
            }

            int index = GetNextColumnIndex();
            if (index == -1)
            {
                return default;
            }

            TColumn? column_Temp = DiGi.Core.Query.Clone(column);
            if (column_Temp is null)
            {
                return default;
            }

            column_Temp.Index = index;

            columns[index] = column_Temp;

            return DiGi.Core.Query.Clone(column_Temp);
        }

        public Row AddRow()
        {
            int index = rows.Count == 0 ? 0 : rows.Last().Key + 1;

            Row row = new(index);
            rows[index] = row;

            return row;
        }

        public Row? AddRow(Row? row, bool tryConvert = true)
        {
            if (row == null)
            {
                return null;
            }

            int index_Row_New = rows.Count == 0 ? 0 : rows.Last().Key + 1;

            int index_Row = row.Index;
            if (index_Row > index_Row_New || index_Row < 0)
            {
                index_Row = index_Row_New;
            }

            Dictionary<int, object?> values = [];
            foreach (int index_Column in row.Indexes)
            {
                if (!TryGetValidValue(index_Column, row[index_Column], out object? value, tryConvert))
                {
                    continue;
                }

                values[index_Column] = value;
            }

            Row row_New = new(index_Row, values);

            rows[index_Row] = row_New;

            return new Row(row_New);
        }

        public Row? AddRow(IDictionary<string, object?>? values)
        {
            if (values == null)
            {
                return null;
            }

            Dictionary<int, object?> dictionary = [];
            foreach (KeyValuePair<string, object?> keyValuePair in values)
            {
                int columnIndex = GetColumnIndex(keyValuePair.Key);
                if (columnIndex == -1)
                {
                    continue;
                }

                dictionary[columnIndex] = keyValuePair.Value;
            }

            return AddRow(dictionary);
        }

        public Row? AddRow(IDictionary<string, object?>? values, Func<string?, string?, bool>? func)
        {
            if (values == null)
            {
                return null;
            }

            Dictionary<int, object?> dictionary = [];
            foreach (KeyValuePair<string, object?> keyValuePair in values)
            {
                int index = GetColumnIndex(keyValuePair.Key, func);
                if (index != -1)
                {
                    dictionary[index] = keyValuePair.Value;
                }
            }

            return AddRow(new Row(dictionary));
        }

        public Row? AddRow(IDictionary<string, object?> values, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return AddRow(values, (x, y) => DiGi.Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        public Row? AddRow(IDictionary<int, object?>? values)
        {
            if (values == null)
            {
                return null;
            }

            return AddRow(new Row(values));
        }

        public Row? AddRow(IEnumerable<object?>? values)
        {
            if (values == null)
            {
                return null;
            }

            Dictionary<int, object?> dictionary = [];
            int index = 0;
            foreach (object? value in values)
            {
                dictionary[index] = value;
                index++;
            }

            return AddRow(dictionary);
        }

        public TColumn? GetColumn(int index)
        {
            if (!columns.TryGetValue(index, out TColumn column))
            {
                return default;
            }

            return column == null ? default : DiGi.Core.Query.Clone(column);
        }

        public int GetColumnIndex(string? name, Func<string?, string?, bool>? func = null)
        {
            Func<string?, string?, bool>? func_Temp = func;
            func_Temp ??= (x, y) => x == y;

            foreach (TColumn column in columns.Values)
            {
                if (column == null)
                {
                    continue;
                }

                if (func_Temp.Invoke(column?.Name, name))
                {
                    return column!.Index;
                }
            }

            return -1;
        }

        public int GetColumnIndex(string name, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return GetColumnIndex(name, (x, y) => DiGi.Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        public int GetNextColumnIndex()
        {
            if (columns == null)
            {
                return -1;
            }

            return columns.Count == 0 ? 0 : columns.Last().Key + 1;
        }

        public Row? GetRow(int index)
        {
            if (!rows.TryGetValue(index, out Row row) || row == null)
            {
                return null;
            }

            return new Row(row);
        }

        public object? GetValue(int columnIndex, int rowIndex)
        {
            return this[columnIndex, rowIndex];
        }

        public object? GetValue(TColumn? column, Row? row)
        {
            return this[column, row];
        }

        public T? GetValue<T>(int columnIndex, int rowIndex)
        {
            if (!TryGetValue(columnIndex, rowIndex, out T? result))
            {
                return default;
            }

            return result;
        }

        public T? GetValue<T>(TColumn? column, Row? row)
        {
            if (!TryGetValue(column, row, out T? result))
            {
                return default;
            }

            return result;
        }

        public object?[]? GetValues(int rowIndex)
        {
            if (!rows.TryGetValue(rowIndex, out Row row) || row == null)
            {
                return null;
            }

            return row.GetValues();
        }

        public bool RemoveColumn(int index)
        {
            if (index < 0)
            {
                return false;
            }

            List<int>? indexes = RemoveColumns([index]);
            if (indexes == null || indexes.Count == 0)
            {
                return false;
            }

            return indexes.Contains(index);
        }

        public List<int>? RemoveColumns(IEnumerable<int>? indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            List<int> result = [];
            foreach (int index in indexes)
            {
                if (columns.Remove(index))
                {
                    result.Add(index);
                }
            }

            foreach (Row row in rows.Values)
            {
                row.RemoveValues(result);
            }

            return result;
        }

        public bool RemoveRow(int index)
        {
            if (index < 0)
            {
                return false;
            }

            List<int>? indexes = RemoveRows([index]);
            if (indexes == null || indexes.Count == 0)
            {
                return false;
            }

            return indexes.Contains(index);
        }

        public List<int>? RemoveRows(IEnumerable<int>? indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            List<int> result = [];
            foreach (int index in indexes)
            {
                if (rows.Remove(index))
                {
                    result.Add(index);
                }
            }

            List<Row> rows_All = [.. rows.Values];
            int count = rows_All.Count;

            rows.Clear();

            for (int i = 0; i < count; i++)
            {
                rows[i] = new Row(i, rows_All[i]);
            }

            return result;
        }

        public bool SetValue(int columnIndex, int rowIndex, object? value, bool tryConvert = true)
        {
            if (!rows.TryGetValue(rowIndex, out Row row) || row == null)
            {
                return false;
            }

            if (!TryGetValidValue(columnIndex, value, out object? convertedValue, tryConvert))
            {
                return false;
            }

            row.SetValue(columnIndex, convertedValue);
            return true;
        }

        public bool TryGetColumn(string? name, out TColumn? column, Enums.TextComparisonType textComparisonType = Enums.TextComparisonType.Equals, bool caseSensitive = true)
        {
            column = default;

            if (name == null)
            {
                return false;
            }

            int index = GetColumnIndex(name, textComparisonType, caseSensitive);

            if (index == -1 || !columns.TryGetValue(index, out column) || column == null)
            {
                return false;
            }

            return true;
        }

        public bool TryGetValidValue(int columnIndex, object? @in, out object? @out, bool tryConvert = true)
        {
            @out = null;

            if (!columns.TryGetValue(columnIndex, out TColumn column) || column == null)
            {
                return false;
            }

            return column.TryGetValidValue(@in, out @out, tryConvert);
        }

        public bool TryGetValue<T>(int columnIndex, int rowIndex, out T? value)
        {
            value = default;

            if (!rows.TryGetValue(rowIndex, out Row row) || row == null)
            {
                return false;
            }

            if (!row.TryGetValue(columnIndex, out value))
            {
                return false;
            }

            return true;
        }

        public bool TryGetValue<T>(TColumn? column, Row? row, out T? value)
        {
            value = default;

            if (column == null || row == null)
            {
                return false;
            }

            return TryGetValue(column.Index, row.Index, out value);
        }

        public TColumn? UpdateColumn(int index, TColumn column, bool tryConvert = true)
        {
            TColumn? column_Temp = DiGi.Core.Query.Clone(column);
            if (column_Temp is null)
            {
                return default;
            }

            column_Temp.Index = index;

            if (columns.TryGetValue(index, out TColumn? column_Existing) && column_Existing is not null)
            {
                if ((column_Existing.Type ?? typeof(object)) != (column_Temp.Type ?? typeof(object)))
                {
                    foreach (Row row in rows.Values)
                    {
                        if (!row.TryGetValue(index, out object? value))
                        {
                            continue;
                        }

                        if (!column_Temp.TryGetValidValue(value, out value, tryConvert))
                        {
                            row.RemoveValue(index);
                            continue;
                        }

                        row.SetValue(index, value);
                    }
                }
            }

            columns[index] = column_Temp;

            return DiGi.Core.Query.Clone(column_Temp);
        }

        public Row? UpdateRow(int index, IDictionary<string, object?>? values, Func<string?, string?, bool>? func = null)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return null;
            }

            Dictionary<int, object?> dictionary = [];
            foreach (KeyValuePair<string, object?> keyValuePair in values)
            {
                int index_Column = GetColumnIndex(keyValuePair.Key, func);
                if (index_Column != -1)
                {
                    dictionary[index_Column] = keyValuePair.Value;
                }
            }

            return UpdateRow(index, dictionary);
        }

        public Row? UpdateRow(int index, IDictionary<int, object?>? values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return null;
            }

            return AddRow(new Row(index, values));
        }

        public Row? UpdateRow(int index, IEnumerable<object>? values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return null;
            }

            Dictionary<int, object?> dictionary = [];
            int index_Column = 0;
            foreach (object value in values)
            {
                dictionary[index_Column] = value;
                index_Column++;
            }

            return UpdateRow(index, dictionary);
        }
    }

    public class Table : Table<Column>
    {
        public Table()
        {
        }

        public Table(IEnumerable<Column> columns)
            : base(columns)
        {
        }

        public Column? AddColumn()
        {
            return AddColumn(null as Type);
        }

        public Column? AddColumn(Type? type)
        {
            int index = GetNextColumnIndex();

            return AddColumn(new Column(index, type));
        }

        public Column? AddColumn(string? name, Type? type = null)
        {
            return AddColumn(new Column(name, type));
        }

        public Column? UpdateColumn(int index, string? name, Type? type = null, bool tryConvert = true)
        {
            return UpdateColumn(index, new Column(name, type), tryConvert);
        }
    }
}