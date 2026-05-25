using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Table.Classes
{
    public abstract class Table<TColumn, TRow> : ITable<TColumn, TRow> where TColumn : IColumn where TRow : IRow<TRow>
    {
        private readonly SortedDictionary<int, TColumn> columns = [];
        private readonly SortedDictionary<int, TRow> rows = [];

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

        public IEnumerable<TRow> Rows
        {
            get
            {
                return rows.Values.ToList().ConvertAll(x => x.Clone()!);
            }
        }

        public object? this[int rowIndex, int columnIndex]
        {
            get
            {
                    if (!TryGetValue(rowIndex, columnIndex, out object? result))
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

        public object? this[TRow? row, TColumn? column]
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

                    return this[row.Index, columnIndex];
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

        public TRow AddRow()
        {
            int index = GetNextRowIndex();

            TRow row = CreateRow(index);
            rows[index] = row;

            return row;
        }

        public TRow? AddRow(TRow? row, bool tryConvert = true)
        {
            if (row == null)
            {
                return default;
            }

            int index_Row_New = GetNextRowIndex();

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

            TRow row_New = CreateRow(index_Row, values);

            rows[index_Row] = row_New;

            return row_New.Clone();
        }

        public TRow? AddRow(IDictionary<string, object?>? values)
        {
            if (values == null)
            {
                return default;
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

        public TRow? AddRow(IDictionary<string, object?>? values, Func<string?, string?, bool>? matchColumnFunc)
        {
            if (values == null)
            {
                return default;
            }

            Dictionary<int, object?> dictionary = [];
            foreach (KeyValuePair<string, object?> keyValuePair in values)
            {
                int index = GetColumnIndex(keyValuePair.Key, matchColumnFunc);
                if (index != -1)
                {
                    dictionary[index] = keyValuePair.Value;
                }
            }

            return AddRow(CreateRow(GetNextRowIndex(), dictionary));
        }

        public TRow? AddRow(IDictionary<string, object?> values, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return AddRow(values, (x, y) => DiGi.Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        public TRow? AddRow(IDictionary<int, object?>? values)
        {
            if (values == null)
            {
                return default;
            }

            return AddRow(CreateRow(GetNextRowIndex(), values));
        }

        public TRow? AddRow(IEnumerable<object?>? values)
        {
            if (values == null)
            {
                return default;
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

        public void Clear()
        {
            rows.Clear();
            columns.Clear();
        }

        public void ClearRows()
        {
            rows.Clear();
        }
        
        public TColumn? GetColumn(int index)
        {
            if (!columns.TryGetValue(index, out TColumn column))
            {
                return default;
            }

            return column == null ? default : DiGi.Core.Query.Clone(column);
        }

        public int GetColumnIndex(string? name, Func<string?, string?, bool>? matchColumnFunc = null)
        {
            Func<string?, string?, bool>? func_Temp = matchColumnFunc;
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

        public object?[]? GetColumnValues(int columnIndex)
        {
            if (rows.Count == 0)
            {
                return [];
            }

            int count = rows.Keys.Last() + 1;

            object?[] result = new object[count];

            foreach (int index in rows.Keys)
            {
                result[index] = rows[index][columnIndex];
            }

            return result;
        }

        public object?[]? GetColumnValues(TColumn? column)
        {
            if (column is null)
            {
                return null;
            }

            return GetColumnValues(column.Index);
        }

        public IEnumerator<TRow> GetEnumerator()
        {
            return Rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetNextColumnIndex()
        {
            if (columns == null)
            {
                return -1;
            }

            return columns.Count == 0 ? 0 : columns.Last().Key + 1;
        }

        public int GetNextRowIndex()
        {
            if (rows == null)
            {
                return -1;
            }

            return rows.Count == 0 ? 0 : rows.Last().Key + 1;
        }

        public TRow? GetRow(int index)
        {
            if (!rows.TryGetValue(index, out TRow row) || row == null)
            {
                return default;
            }

            return row.Clone();
        }

        public object? GetValue(int rowIndex, int columnIndex)
        {
            return this[rowIndex, columnIndex];
        }

        public object? GetValue(TRow? row, TColumn? column)
        {
            return this[row, column];
        }

        public T? GetValue<T>(int rowIndex, int columnIndex)
        {
            if (!TryGetValue(rowIndex, columnIndex, out T ? result))
            {
                return default;
            }

            return result;
        }

        public T? GetValue<T>(TRow? row, TColumn? column)
        {
            if (!TryGetValue(row, column, out T ? result))
            {
                return default;
            }

            return result;
        }

        public object?[]? GetValues(int rowIndex)
        {
            if (!rows.TryGetValue(rowIndex, out TRow row) || row == null)
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

            // 1. Identify unique indices to remove and sort them for consistency
            List<int> targets = [.. Enumerable.Distinct(indexes).OrderBy(x => x)];
            if (targets.Count == 0)
            {
                return [];
            }

            // 2. Remove targeted columns from the dictionary
            List<int> removedSuccessfully = [];
            foreach (int index in targets)
            {
                if (columns.Remove(index))
                {
                    removedSuccessfully.Add(index);
                }
            }

            if (removedSuccessfully.Count == 0)
            {
                return removedSuccessfully;
            }

            // 3. Create a mapping from Old Index -> New Index for surviving columns
            // This is necessary to shift data inside the Rows
            Dictionary<int, int> indexMap = [];
            List<TColumn> remainingColumns = [.. columns.Values];

            columns.Clear();

            for (int i = 0; i < remainingColumns.Count; i++)
            {
                TColumn column = remainingColumns[i];
                int oldIndex = column.Index;
                int newIndex = i;

                // Update the internal Index property of the column object
                column.Index = newIndex;

                // Re-insert into the sorted dictionary with the new shifted key
                columns[newIndex] = column;

                // Store the mapping to update rows later
                indexMap[oldIndex] = newIndex;
            }

            // 4. Update all rows: shift values to match new column indices
            foreach (TRow row in rows.Values)
            {
                if (row == null) continue;

                // Capture current row data in a temporary dictionary to avoid overwrite conflicts during shifting
                Dictionary<int, object?> tempRowData = [];
                foreach (int colIndex in row.Indexes)
                {
                    tempRowData[colIndex] = row[colIndex];
                }

                // Remove values that belonged to the deleted columns
                foreach (int targetIdx in targets)
                {
                    row.RemoveValue(targetIdx);
                }

                // Shift remaining values based on the indexMap
                foreach (KeyValuePair<int, int> mapping in indexMap)
                {
                    int oldIdx = mapping.Key;
                    int newIdx = mapping.Value;

                    if (oldIdx != newIdx && tempRowData.ContainsKey(oldIdx))
                    {
                        object? value = tempRowData[oldIdx];
                        row[newIdx] = value; // Move to new position
                        row.RemoveValue(oldIdx); // Remove from old position
                    }
                }
            }

            return removedSuccessfully;
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

            List<TRow> rows_All = [.. rows.Values];
            int count = rows_All.Count;

            rows.Clear();

            
            for (int i = 0; i < count; i++)
            {
                Dictionary<int, object?> dictionary = [];
                TRow row = rows_All[i];
                if(row is not null)
                {
                    foreach (int index in row.Indexes)
                    {
                        dictionary[index] = row[index];
                    }
                }

                rows[i] = CreateRow(i, dictionary);
            }

            return result;
        }

        public bool SetValue(int rowIndex, int columnIndex, object? value, bool tryConvert = true)
        {
            if (!rows.TryGetValue(rowIndex, out TRow row) || row == null)
            {
                return false;
            }

            if (!TryGetValidValue(columnIndex, value, out object? convertedValue, tryConvert))
            {
                return false;
            }

            row[columnIndex] = convertedValue;
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

        public bool TryGetValue<T>(int rowIndex, int columnIndex, out T? value)
        {
            value = default;

            if (!rows.TryGetValue(rowIndex, out TRow row) || row == null)
            {
                return false;
            }

            if (!row.TryGetValue(columnIndex, out value))
            {
                return false;
            }

            return true;
        }

        public bool TryGetValue<T>(TRow? row, TColumn? column, out T? value)
        {
            value = default;

            if (column == null || row == null)
            {
                return false;
            }

            return TryGetValue(row.Index, column.Index, out value);
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
                    foreach (TRow row in rows.Values)
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

                        row[index] = value;
                    }
                }
            }

            columns[index] = column_Temp;

            return DiGi.Core.Query.Clone(column_Temp);
        }

        public TRow? UpdateRow(int index, IDictionary<string, object?>? values, Func<string?, string?, bool>? func = null)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return default;
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

        public TRow? UpdateRow(int index, IDictionary<int, object?>? values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return default;
            }

            return AddRow(CreateRow(index, values));
        }

        public TRow? UpdateRow(int index, IEnumerable<object>? values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return default;
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

        protected abstract TRow CreateRow(int index, IDictionary<int, object?>? values = null);
    }

    public class Table<TColumn> : Table<TColumn, Row> where TColumn : IColumn
    {
        public Table()
        {

        }

        public Table(IEnumerable<TColumn> columns)
            : base(columns)
        {
        }

        protected override Row CreateRow(int index, IDictionary<int, object?>? values = null)
        {
            return new Row(index, values);
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