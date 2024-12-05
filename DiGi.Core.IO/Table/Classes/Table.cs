using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    public class Table : ITableObject
    {
        private SortedDictionary<int, Column> columns = new SortedDictionary<int, Column>();
        private SortedDictionary<int, Row> rows = new SortedDictionary<int, Row>();

        public Table()
        {

        }

        public Column AddColumn()
        {
            return AddColumn((Type)null);
        }

        public Column AddColumn(Type type)
        {
            int index = columns.Count == 0 ? 0 : columns.Last().Key + 1;

            Column column = new Column(index, type);

            columns[index] = column;

            return new Column(column);
        }

        public Column AddColumn(Column column)
        {
            if(column == null)
            {
                return null;
            }

            int index = columns.Count == 0 ? 0 : columns.Last().Key + 1;
            column = new Column(index, column);

            columns[index] = column;

            return new Column(column);
        }

        public Column AddColumn(string name, Type type = null)
        {
            return AddColumn(new Column(name, type));
        }

        public Column UpdateColumn(int index, string name, Type type = null)
        {
            if(!columns.TryGetValue(index, out Column column))
            {
                return null;
            }

            Type type_Temp = type == null ? typeof(object) : type;

            bool typeUpdate = column.Type != type_Temp; 

            column = new Column(index, name, type_Temp);

            columns[index] = column;

            if(typeUpdate)
            {
                foreach(Row row in rows.Values)
                {
                    if(!row.TryGetValue(index, out object value))
                    {
                        continue;
                    }

                    if(!TryGetValidValue(index, value, out value))
                    {
                        row.RemoveValue(index);
                        continue;
                    }

                    row.SetValue(index, value);
                }
            }

            return new Column(column);
        }

        public int GetColumnIndex(string name, Func<string, string, bool> func = null)
        {
            Func<string, string, bool> func_Temp = func;
            if (func_Temp == null)
            {
                func_Temp = (x, y) => x == y;
            }

            foreach(Column column in columns.Values)
            {
                if(func_Temp.Invoke(column?.Name, name))
                {
                    return column.Index;
                }
            }

            return -1;
        }

        public int GetColumnIndex(string name, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return GetColumnIndex(name, (x, y) => Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        public Column GetColumn(int index)
        {
            if(!columns.TryGetValue(index, out Column column))
            {
                return null;
            }

            return column == null ? null : new Column(column);
        }

        public IEnumerable<Column> Columns
        {
            get
            {
                return columns.Values.ToList().ConvertAll(x => new Column(x));
            }
        }

        public IEnumerable<Row> Rows
        {
            get
            {
                return rows.Values.ToList().ConvertAll(x => new Row(x));
            }
        }

        public object this[int columnIndex, int rowIndex]
        {
            get
            {
                if(!TryGetValue(columnIndex, rowIndex, out object result))
                {
                    if(!columns.TryGetValue(columnIndex, out Column column) || column == null)
                    {
                        return null;
                    }

                    return Core.Query.Default(column.Type);
                }

                return result;
            }
        }

        public object this[Column column, Row row]
        {
            get
            {
                if(column == null)
                {
                    return null;
                }

                int columnIndex = column.Index;

                if (!columns.TryGetValue(columnIndex, out Column column_Table) || column == null)
                {
                    return null;
                }

                if(row == null)
                {
                    return Core.Query.Default(column.Type);
                }

                return this[columnIndex, row.Index];
            }
        }

        public object GetValue(int columnIndex, int rowIndex)
        {
            return this[columnIndex, rowIndex];
        }

        public object GetValue(Column column, Row row)
        {
            return this[column, row];
        }

        public bool TryGetValue<T>(int columnIndex, int rowIndex, out T value)
        {
            value = default;

            if(!rows.TryGetValue(rowIndex, out Row row) || row == null)
            {
                return false;
            }

            if(!row.TryGetValue(columnIndex, out value))
            {
                return false;
            }

            return true;
        }

        public bool TryGetValue<T>(Column column, Row row, out T value)
        {
            value = default;

            if(column == null || row == null)
            {
                return false;
            }

            return TryGetValue(column.Index, row.Index, out value);
        }

        public T GetValue<T>(int columnIndex, int rowIndex)
        {
            if(!TryGetValue(columnIndex, rowIndex, out T result))
            {
                return default;
            }

            return result;
        }

        public T GetValue<T>(Column column, Row row)
        {
            if (!TryGetValue(column, row, out T result))
            {
                return default;
            }

            return result;
        }

        public object[] GetValues(int rowIndex)
        {
            if (!rows.TryGetValue(rowIndex, out Row row) || row == null)
            {
                return null;
            }

            return row.GetValues();
        }

        public bool SetValue(int columnIndex, int rowIndex, object value, bool tryConvert = true)
        {
            if (!rows.TryGetValue(rowIndex, out Row row) || row == null)
            {
                return false;
            }

            if(!TryGetValidValue(columnIndex, value, out object convertedValue, tryConvert))
            {
                return false;
            }

            row.SetValue(columnIndex, convertedValue);
            return true;
        }

        public Row GetRow(int index)
        {
            if(!rows.TryGetValue(index, out Row row) || row == null)
            {
                return null;
            }

            return new Row(row);
        }

        public bool TryGetValidValue(int columnIndex, object @in, out object @out, bool tryConvert = true)
        {
            @out = null;

            if (!columns.TryGetValue(columnIndex, out Column column) || column == null)
            {
                return false;
            }

            return column.TryGetValidValue(@in, out @out, tryConvert);
        }

        public Row AddRow()
        {
            int index = rows.Count == 0 ? 0 : rows.Last().Key + 1;
            
            Row row = new Row(index);
            rows[index] = row;

            return row;
        }

        public Row AddRow(Row row, bool tryConvert = true)
        {
            if(row == null)
            {
                return null;
            }

            int index_Row_New = rows.Count == 0 ? 0 : rows.Last().Key + 1;

            int index_Row = row.Index;
            if(index_Row > index_Row_New || index_Row < 0)
            {
                index_Row = index_Row_New;
            }

            Dictionary<int, object> values = new Dictionary<int, object>();
            foreach (int index_Column in row.Indexes)
            {
                if(!TryGetValidValue(index_Column, row[index_Column], out object value, tryConvert))
                {
                    continue;
                }

                values[index_Column] = value;
            }

            Row row_New = new Row(index_Row, values);

            rows[index_Row] = row_New;

            return new Row(row_New);
        }

        public Row AddRow(IDictionary<string, object> values, bool addMissingColumns = true)
        {
            if(values == null)
            {
                return null;
            }

            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            foreach(KeyValuePair<string, object> keyValuePair in values)
            {
                int columnIndex = GetColumnIndex(keyValuePair.Key);
                if(columnIndex == -1 && addMissingColumns)
                {
                    Column column = AddColumn(keyValuePair.Key);
                    if(column != null)
                    {
                        columnIndex = column.Index;
                    }
                }

                if(columnIndex == -1)
                {
                    continue;
                }

                dictionary[columnIndex] = keyValuePair.Value;
            }

            return AddRow(dictionary);
        }

        public Row AddRow(IDictionary<string, object> values, Func<string, string, bool> func)
        {
            if(values == null)
            {
                return null;
            }

            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            foreach(KeyValuePair<string, object> keyValuePair in values)
            {
                int index = GetColumnIndex(keyValuePair.Key, func);
                if(index != -1)
                {
                    dictionary[index] = keyValuePair.Value;
                }
            }

            return AddRow(new Row(dictionary));
        }

        public Row AddRow(IDictionary<string, object> values, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return AddRow(values, (x, y) => Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        public Row AddRow(IDictionary<int, object> values)
        {
            if(values == null)
            {
                return null;
            }

            return AddRow(new Row(values));
        }

        public Row AddRow(IEnumerable<object> values)
        {
            if(values == null)
            {
                return null;
            }

            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            int index = 0;
            foreach (object value in values)
            {
                dictionary[index] = value;
                index++;
            }

            return AddRow(dictionary);
        }

        public Row UpdateRow(int index, IDictionary<string, object> values, Func<string, string, bool> func = null)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return null;
            }

            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            foreach (KeyValuePair<string, object> keyValuePair in values)
            {
                int index_Column = GetColumnIndex(keyValuePair.Key, func);
                if (index_Column != -1)
                {
                    dictionary[index_Column] = keyValuePair.Value;
                }
            }

            return UpdateRow(index, dictionary);
        }

        public Row UpdateRow(int index, IDictionary<int, object> values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return null;
            }

            return AddRow(new Row(index, values));
        }

        public Row UpdateRow(int index, IEnumerable<object> values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return null;
            }

            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            int index_Column = 0;
            foreach (object value in values)
            {
                dictionary[index_Column] = value;
                index_Column++;
            }

            return UpdateRow(index, dictionary);
        }

        public List<int> RemoveColumns(IEnumerable<int> indexes)
        {
            if(indexes == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            foreach (int index in indexes)
            {
                if(columns.Remove(index))
                {
                    result.Add(index);
                }
            }

            foreach(Row row in rows.Values)
            {
                row.RemoveValues(result);
            }

            return result;
        }

        public bool RemoveColumn(int index)
        {
            if(index < 0)
            {
                return false;
            }

            List<int> indexes = RemoveColumns(new int[] { index });
            if(indexes == null || indexes.Count == 0)
            {
                return false;
            }

            return indexes.Contains(index);
        }

        public List<int> RemoveRows(IEnumerable<int> indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            foreach (int index in indexes)
            {
                if (rows.Remove(index))
                {
                    result.Add(index);
                }
            }

            List<Row> rows_All = new List<Row>(rows.Values);
            int count = rows_All.Count;

            rows.Clear();

            for (int i = 0; i < count; i++)
            {
                rows[i] = new Row(i, rows_All[i]);
            }

            return result;
        }

        public bool RemoveRow(int index)
        {
            if (index < 0)
            {
                return false;
            }

            List<int> indexes = RemoveRows(new int[] { index });
            if (indexes == null || indexes.Count == 0)
            {
                return false;
            }

            return indexes.Contains(index);
        }

        public int RowCount
        {
            get
            {
                return rows.Keys.Last();
            }
        }

        public int ColumnCount
        {
            get
            {
                return columns.Keys.Last();
            }
        }
    }
}