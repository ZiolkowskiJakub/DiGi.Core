using DiGi.Core.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    public class DelimitedDataTable : IDisposable, IEnumerable<object[]>
    {
        private bool disposed = false;

        private string[] names;
        private List<object[]> header;
        private List<object[]> values;

        private DelimitedDataTable()
        {
        }

        public DelimitedDataTable(DelimitedDataTable delimitedDataTable)
        {
            if (delimitedDataTable == null)
            {
                return;
            }

            if (delimitedDataTable.names != null)
            {
                names = new List<string>(delimitedDataTable.names).ToArray();
            }

            if (delimitedDataTable.header != null)
            {
                header = new List<object[]>();
                foreach (object[] objects in delimitedDataTable.header)
                {
                    if (objects == null)
                    {
                        header.Add(null);
                    }
                    else
                    {
                        header.Add(new List<object>(objects).ToArray());
                    }
                }
            }

            if (delimitedDataTable.values != null)
            {
                values = new List<object[]>();
                foreach (object[] objects in delimitedDataTable.values)
                {
                    if (objects == null)
                    {
                        values.Add(null);
                    }
                    else
                    {
                        values.Add(new List<object>(objects).ToArray());
                    }
                }
            }
        }

        public DelimitedDataTable(IDelimitedDataReader delimitedDataReader, int namesIndex = 0, int headerCount = 0)
        {
            Read(delimitedDataReader, namesIndex, headerCount);
        }

        public DelimitedDataTable(List<DelimitedDataRow> delimitedDataRows, int namesIndex = 0, int headerCount = 0)
        {
            Read(delimitedDataRows, namesIndex, headerCount);
        }

        public DelimitedDataTable(object[,] data, int namesIndex = 0, int headerCount = 0)
        {
            Read(data, namesIndex, headerCount);
        }

        public bool Read(object[,] data, int namesIndex = 0, int headerCount = 0)
        {
            if (data == null)
            {
                return false;
            }

            int rowsStart = data.GetLowerBound(0);
            int rowsEnd = data.GetUpperBound(0);
            int rowsCount = rowsEnd - rowsStart + 1;
            if (rowsCount <= 0)
            {
                return true;
            }

            int columnsStart = data.GetLowerBound(1);
            int columnsEnd = data.GetUpperBound(1);
            int columnsCount = columnsEnd - columnsStart + 1;
            if (columnsCount <= 0)
            {
                return true;
            }

            names = new string[columnsCount];
            for (int i = columnsStart; i < columnsCount + columnsStart; i++)
            {
                names[i - columnsStart] = data[namesIndex, i] as string;
            }

            if (rowsCount == 1)
            {
                return true;
            }

            int min;

            header = new List<object[]>();
            if (headerCount > 0)
            {
                min = Math.Min(headerCount + rowsStart + 1, rowsEnd);
                for (int i = rowsStart + 1; i < min + rowsStart; i++)
                {
                    object[] values = new object[columnsCount];
                    for (int j = columnsStart; j < columnsCount + columnsStart; j++)
                    {
                        values[j - columnsStart] = data[i, j];
                    }
                    header.Add(values);
                }
            }

            int max = Math.Max(namesIndex, rowsStart);

            values = new List<object[]>();
            for (int i = max + headerCount + 1; i < rowsCount + rowsStart; i++)
            {
                object[] values = new object[columnsCount];
                for (int j = columnsStart; j < columnsCount + columnsStart; j++)
                {
                    values[j - columnsStart] = data[i, j];
                }
                this.values.Add(values);
            }

            return true;
        }

        public bool Read(List<DelimitedDataRow> delimitedDataRows, int namesIndex = 0, int headerCount = 0)
        {
            int count = delimitedDataRows.Count;

            if (count <= namesIndex)
            {
                return true;
            }

            if (delimitedDataRows[namesIndex] != null)
            {
                names = delimitedDataRows[namesIndex].ToArray();
            }

            header = new List<object[]>();
            int min = namesIndex + 1;
            for (int i = min; i < min + headerCount; i++)
            {
                if (delimitedDataRows[i] != null)
                {
                    header.Add(delimitedDataRows[i].ToArray());
                }
            }

            min = namesIndex + headerCount + 1;
            values = new List<object[]>();
            for (int i = min; i < count; i++)
            {
                if (delimitedDataRows[i] != null)
                {
                    object[] row = new object[delimitedDataRows[i].Count];
                    for (int j = 0; j < delimitedDataRows[i].Count; j++)
                    {
                        row[j] = delimitedDataRows[i][j];
                    }
                    values.Add(row);
                }
            }

            return true;
        }

        public bool Read(IDelimitedDataReader delimitedDataReader, int namesIndex = 0, int headerCount = 0)
        {
            if (delimitedDataReader == null)
            {
                return false;
            }

            List<DelimitedDataRow> delimitedDataRows = delimitedDataReader.Read();
            if (delimitedDataRows == null)
            {
                return false;
            }

            return Read(delimitedDataRows, namesIndex, headerCount);
        }

        public bool Write(IDelimitedDataWriter delimitedDataWriter)
        {
            if (names == null || names.Length == 0 || delimitedDataWriter == null)
            {
                return false;
            }

            delimitedDataWriter.Write(new DelimitedDataRow(Extract<string>(names)));

            if (header != null && header.Count > 0)
            {
                header.ForEach(x => delimitedDataWriter.Write(new DelimitedDataRow(Extract(x))));
            }

            if (values != null && values.Count > 0)
            {
                values.ForEach(x => delimitedDataWriter.Write(new DelimitedDataRow(Extract(x))));
            }

            return true;
        }

        public object this[int row, int column]
        {
            get
            {
                if (row >= values.Count)
                {
                    return null;
                }

                if (column >= values[row].Length)
                {
                    return null;
                }

                return values[row][column];
            }
        }

        public object this[int row, string columnName]
        {
            get
            {
                if (row >= values.Count)
                {
                    return null;
                }

                int index = GetColumnIndex(columnName);
                if (index == -1)
                {
                    return null;
                }

                if (index >= values[row].Length)
                {
                    return null;
                }

                return this[row, index];
            }
        }

        public object[] this[int row]
        {
            get
            {
                return values[row];
            }
        }

        public int GetColumnIndex(string columnName)
        {
            if (names == null || columnName == null)
            {
                return -1;
            }

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == columnName)
                {
                    return i;
                }
            }

            return -1;
        }

        public object[,] GetValues()
        {
            int rowCount = 0;
            int columnCount = 0;
            if (names != null && names.Length != 0)
            {
                rowCount++;
                columnCount = names.Length;
            }

            if (header != null && header.Count != 0)
            {
                rowCount += header.Count;
                columnCount = Math.Max(columnCount, header.ConvertAll(x => x == null ? 0 : x.Length).Max());
            }

            if (values != null && values.Count != 0)
            {
                rowCount += values.Count;
                columnCount = Math.Max(columnCount, values.ConvertAll(x => x == null ? 0 : x.Length).Max());
            }

            object[,] result = new object[rowCount, columnCount];

            int rowIndex = 0;
            if (names != null && names.Length != 0)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    result[rowIndex, i] = names[i];
                }
                rowIndex++;
            }

            if (header != null && header.Count != 0)
            {
                foreach (object[] row in header)
                {
                    if (row != null)
                    {
                        for (int i = 0; i < row.Length; i++)
                        {
                            result[rowIndex, i] = row[i];
                        }
                    }
                    rowIndex++;
                }
            }

            if (values != null && values.Count != 0)
            {
                foreach (object[] row in values)
                {
                    if (row != null)
                    {
                        for (int i = 0; i < row.Length; i++)
                        {
                            result[rowIndex, i] = row[i];
                        }
                    }
                    rowIndex++;
                }
            }

            return result;
        }

        public void Sort(string columnName)
        {
            Sort(GetColumnIndex(columnName));
        }

        public void Sort(int index)
        {
            if (index == -1)
            {
                return;
            }

            if (values == null || values.Count == 0)
            {
                return;
            }

            List<object[]> values_Valid = new List<object[]>();
            List<object[]> values_Invalid = new List<object[]>();

            foreach (object[] value in values)
            {
                if (value == null || value.Length <= index || !(value[index] is IComparable))
                {
                    values_Invalid.Add(value);
                }
                else
                {
                    values_Valid.Add(value);
                }
            }

            values_Valid.Sort((x, y) => ((IComparable)x[index]).CompareTo((IComparable)y[index]));
            values = values_Valid;
            values.AddRange(values_Invalid);
        }

        public string GetColumnName(int index)
        {
            TryGetColumnName(index, out string result);
            return result;
        }

        public bool SetColumnName(int index, string name)
        {
            if (names == null)
            {
                return false;
            }

            if (index < 0 || index >= names.Length)
            {
                return false;
            }

            names[index] = name;
            return true;
        }

        public bool SetColumnName(string columnName_Old, string columnName_New)
        {
            int index = GetColumnIndex(columnName_Old);
            if (index == -1)
            {
                return false;
            }

            return SetColumnName(index, columnName_New);
        }

        public bool TryGetColumnName(int index, out string name)
        {
            name = null;

            if (names == null)
            {
                return false;
            }

            if (index < 0 || index >= names.Length)
            {
                return false;
            }

            name = names[index];
            return true;
        }

        public bool SetValue(object value, int row = -1, int column = -1)
        {
            if (column == -1 && row == -1)
            {
                return false;
            }

            if (row != -1 && column != -1)
            {
                if (row >= values.Count)
                {
                    return false;
                }

                if (column >= values[row].Length)
                {
                    return false;
                }

                values[row][column] = value;
                return true;
            }

            if (row != -1)
            {
                if (row >= values.Count)
                {
                    return false;
                }

                for (int i = 0; i < values[row].Length; i++)
                {
                    values[row][i] = value;
                }

                return true;
            }

            if (column >= values[row].Length)
            {
                return false;
            }

            bool result = false;
            foreach (object[] row_Values in values)
            {
                if (column >= row_Values.Length)
                {
                    continue;
                }

                row_Values[column] = value;
                result = true;
            }
            return result;
        }

        public List<int> GetColumnIndexes(string columnText, TextComparisonType textComparisonType, bool caseSensitive = true)
        {
            if (columnText == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Compare(columnText, textComparisonType, caseSensitive))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<int> GetRowIndexes(int columnIndex, string text, TextComparisonType textComparisonType, bool caseSensitive = true)
        {
            if (columnIndex >= ColumnCount || columnIndex < 0)
            {
                return null;
            }

            List<int> result = new List<int>();
            for (int i = 0; i < RowCount; i++)
            {
                string value = ToString(i, columnIndex);
                if (value.Compare(text, textComparisonType, caseSensitive))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public int GetColumnIndex(object value, int headerIndex)
        {
            if (header == null && header.Count >= headerIndex)
            {
                return -1;
            }

            object[] values = header[headerIndex];
            if (values == null || values.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == null)
                {
                    if (value == null)
                    {
                        return i;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (values[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public object[] GetColumnValues(int index)
        {
            if (index >= names.Length || index < 0)
            {
                return null;
            }

            object[] result = new object[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                result[i] = values[i][index];
            }

            return result;
        }

        public object[] GetColumnValues(string columnName)
        {
            if (columnName == null)
            {
                return null;
            }

            return GetColumnValues(GetColumnIndex(columnName));
        }

        public object[,] GetColumnValues(IEnumerable<int> indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            object[,] result = new object[values.Count, indexes.Count()];

            int count = 0;
            foreach (int index in indexes)
            {
                object[] values = GetColumnValues(index);
                if (values == null || values.Length == 0)
                {
                    count++;
                    continue;
                }

                for (int i = 0; i < values.Length; i++)
                {
                    result[i, count] = values[i];
                }

                count++;
            }

            return result;
        }

        public object[] GetRowValues(int index)
        {
            if (index < 0 || index >= names.Length)
            {
                return null;
            }

            return values[index];
        }

        public bool TryGetValue<T>(int row, int column, out T value)
        {
            value = default;

            if (row >= values.Count)
            {
                return false;
            }

            if (column >= values[row].Length)
            {
                return false;
            }

            value = (T)values[row][column];
            return true;
        }

        public bool TryConvert<T>(int row, int column, out T value)
        {
            value = default;

            object @object_value;
            if (!TryGetValue(row, column, out object_value))
            {
                return false;
            }

            return @object_value.TryConvert(out value);
        }

        public string ToString(int row, int column)
        {
            if (row >= values.Count)
            {
                return null;
            }

            if (column >= values[row].Length)
            {
                return null;
            }

            object value = values[row][column];
            if (value == null)
            {
                return null;
            }

            return value.ToString();
        }

        public int RowCount
        {
            get
            {
                if (values == null)
                {
                    return -1;
                }

                return values.Count;
            }
        }

        public int ColumnCount
        {
            get
            {
                if (names == null)
                {
                    return -1;
                }

                return names.Length;
            }
        }

        public List<Tuple<string, object>> GetTupleList(int row)
        {
            if (names == null)
            {
                return null;
            }

            if (row >= values.Count)
            {
                return null;
            }

            if (row < 0)
            {
                return null;
            }

            List<Tuple<string, object>> tuples = new List<Tuple<string, object>>();
            for (int j = 0; j < names.Length; j++)
            {
                if (j < values[row].Length)
                {
                    tuples.Add(new Tuple<string, object>(names[j], values[row][j]));
                }
                else
                {
                    tuples.Add(new Tuple<string, object>(names[j], null));
                }
            }

            return tuples;
        }

        public List<string> GetColumnNames()
        {
            if (names == null)
            {
                return null;
            }

            return names.ToList();
        }

        public IEnumerable<object> GetUnqueValues(string columnName)
        {
            int index = GetColumnIndex(columnName);
            if (index == -1)
            {
                return null;
            }

            HashSet<object> result = new HashSet<object>();
            foreach (object[] values_Row in values)
            {
                result.Add(values_Row[index]);
            }

            return result;
        }

        public DelimitedDataTable Extract(params string[] columnNames)
        {
            if (names == null)
            {
                return null;
            }

            DelimitedDataTable delimitedDataTable = new DelimitedDataTable();
            delimitedDataTable.names = columnNames;

            if (values == null)
            {
                return delimitedDataTable;
            }

            delimitedDataTable.values = new List<object[]>();

            if (values.Count == 0 || columnNames.Length == 0)
            {
                return delimitedDataTable;
            }

            List<int> indexes = columnNames.ToList().ConvertAll(x => GetColumnIndex(x));

            foreach (object[] values_Row_Old in values)
            {
                object[] values_Row_New = new object[indexes.Count];
                for (int i = 0; i < indexes.Count; i++)
                {
                    int index = indexes[i];
                    if (index == -1 || values_Row_Old.Length <= index)
                    {
                        values_Row_New[i] = null;
                    }
                    else
                    {
                        values_Row_New[i] = values_Row_Old[index];
                    }
                }
                delimitedDataTable.values.Add(values_Row_New);
            }

            return delimitedDataTable;
        }

        public DelimitedDataTable Filter(IEnumerable<int> rowIndexes)
        {
            DelimitedDataTable delimitedDataTable = new DelimitedDataTable();
            delimitedDataTable.names = names;
            delimitedDataTable.header = header;
            delimitedDataTable.values = new List<object[]>();

            foreach (int aIndex in rowIndexes)
            {
                delimitedDataTable.values.Add(values[aIndex]);
            }

            return delimitedDataTable;
        }

        public DelimitedDataTable Filter(string columnName, TextComparisonType textComparisonType, string text, bool caseSensitive = true, bool tryConvert = true)
        {
            if (names == null)
            {
                return null;
            }

            DelimitedDataTable delimitedDataTable = new DelimitedDataTable();
            delimitedDataTable.names = names;

            if (values == null)
            {
                return delimitedDataTable;
            }

            delimitedDataTable.values = new List<object[]>();

            if (values.Count == 0)
            {
                return delimitedDataTable;
            }

            int index = GetColumnIndex(columnName);
            if (index == -1)
            {
                return delimitedDataTable;
            }

            foreach (object[] values_Row in values)
            {
                if (values_Row == null || values_Row.Length <= index)
                {
                    continue;
                }

                object value = values_Row[index];

                if (tryConvert)
                {
                    string @string = null;
                    if (value.TryConvert(out @string))
                    {
                        value = @string;
                    }
                }

                if (!(value is string || value == null))
                {
                    continue;
                }

                if (!(value as string).Compare(text, textComparisonType, caseSensitive))
                {
                    continue;
                }

                delimitedDataTable.values.Add(values_Row);
            }

            return delimitedDataTable;
        }

        public DelimitedDataTable Filter(string columnName, NumberComparisonType numberComparisonType, double value, bool tryConvert = true)
        {
            if (names == null)
            {
                return null;
            }

            DelimitedDataTable delimitedDataTable = new DelimitedDataTable();
            delimitedDataTable.names = names;

            if (values == null)
            {
                return delimitedDataTable;
            }

            delimitedDataTable.values = new List<object[]>();

            if (values.Count == 0)
            {
                return delimitedDataTable;
            }

            int index = GetColumnIndex(columnName);
            if (index == -1)
            {
                return delimitedDataTable;
            }

            foreach (object[] values_Row in values)
            {
                if (values_Row == null || values_Row.Length <= index)
                {
                    continue;
                }

                object value_Temp = values_Row[index];

                if (tryConvert)
                {
                    double @double = double.NaN;
                    if (value.TryConvert(out @double))
                    {
                        value = @double;
                    }
                }

                if (!(value_Temp is double))
                {
                    continue;
                }

                if (!((double)value_Temp).Compare(value, numberComparisonType))
                {
                    continue;
                }

                delimitedDataTable.values.Add(values_Row);
            }

            return delimitedDataTable;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                names = null;
                values = null;

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return ((IEnumerable<object[]>)values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<object[]>)values).GetEnumerator();
        }

        public bool ConvertValues<T>(int columnIndex, T @default = default)
        {
            if (names == null || values == null)
            {
                return false;
            }

            if (columnIndex < 0)
            {
                return false;
            }

            if (columnIndex >= names.Length)
            {
                return false;
            }

            foreach (object[] row in values)
            {
                if (row == null || row.Length <= columnIndex)
                {
                    continue;
                }

                if (row[columnIndex].TryConvert(out T value))
                {
                    row[columnIndex] = value;
                }
                else
                {
                    row[columnIndex] = @default;
                }
            }

            return true;
        }

        private static string[] Extract<T>(T[] values)
        {
            if (values == null)
            {
                return null;
            }

            string[] result = new string[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == null)
                {
                    result[i] = string.Empty;
                }
                else
                {
                    result[i] = values[i].ToString();
                }
            }
            return result;
        }
    }
}