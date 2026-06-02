using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    /// <summary>
    /// Represents a base table structure with generic column and row types.
    /// </summary>
    public abstract class Table<TColumn, TRow> : ITable<TColumn, TRow> where TColumn : IColumn where TRow : IRow<TRow>
    {
        private readonly SortedDictionary<int, TColumn> columns = [];
        private readonly SortedDictionary<int, TRow> rows = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="Table{TColumn, TRow}"/> class.
        /// </summary>
        public Table()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table{TColumn, TRow}"/> class with specified columns.
        /// </summary>
        /// <param name="columns">The collection of columns to add to the table.</param>
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

        /// <summary>
        /// Gets the number of columns in the table.
        /// </summary>
        [JsonIgnore]
        public int ColumnCount
        {
            get
            {
                return columns.Keys.Count == 0 ? 0 : columns.Keys.Last() + 1;
            }
        }

        /// <summary>
        /// Gets the collection of columns in the table.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Columns))]
        public IEnumerable<TColumn> Columns
        {
            get
            {
                return DiGi.Core.Query.CloneAndFilterNulls(columns.Values) ?? [];
            }
        }

        /// <summary>
        /// Gets the number of rows in the table.
        /// </summary>
        [JsonIgnore]
        public int RowCount
        {
            get
            {
                return rows.Keys.Count == 0 ? 0 : rows.Keys.Last() + 1;
            }
        }

        /// <summary>
        /// Gets the collection of rows in the table.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Rows))]
        public IEnumerable<TRow> Rows
        {
            get
            {
                return rows.Values.ToList().ConvertAll(x => x.Clone()!);
            }
        }

        /// <summary>
        /// Gets or sets the value at the specified row and column indices.
        /// </summary>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <returns>The value at the specified position, or a default value for the column type if not found.</returns>
        [JsonIgnore]
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

        /// <summary>
        /// Gets or sets the value for the specified row and column objects.
        /// </summary>
        /// <param name="row">The row object.</param>
        /// <param name="column">The column object.</param>
        /// <returns>The value at the intersection of the specified row and column, or a default value if the row is null.</returns>
        [JsonIgnore]
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

        /// <summary>
        /// Adds a new column to the table.
        /// </summary>
        /// <param name="column">The column to add.</param>
        /// <returns>A clone of the added column with its index assigned, or null if addition failed.</returns>
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

        /// <summary>
        /// Adds a new row to the table with default values.
        /// </summary>
        /// <returns>The newly created row.</returns>
        public TRow AddRow()
        {
            int index = GetNextRowIndex();

            TRow row = CreateRow(index);
            rows[index] = row;

            return row;
        }

        /// <summary>
        /// Adds a new row to the table based on an existing row object.
        /// </summary>
        /// <param name="row">The source row.</param>
        /// <param name="tryConvert">Whether to attempt value conversion if types differ.</param>
        /// <returns>A clone of the added row, or null if addition failed.</returns>
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

        /// <summary>
        /// Adds a new row to the table using column names and values.
        /// </summary>
        /// <param name="values">A dictionary of column names and their corresponding values.</param>
        /// <returns>The added row, or null if addition failed.</returns>
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

        /// <summary>
        /// Adds a new row to the table using column names and values, with a custom column matching function.
        /// </summary>
        /// <param name="values">A dictionary of column names and their corresponding values.</param>
        /// <param name="matchColumnFunc">A function to determine if a provided key matches a column name.</param>
        /// <returns>The added row, or null if addition failed.</returns>
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

        /// <summary>
        /// Adds a new row to the table using column names and values, with specific text comparison settings.
        /// </summary>
        /// <param name="values">A dictionary of column names and their corresponding values.</param>
        /// <param name="textComparisonType">The type of text comparison to use for matching columns.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>The added row, or null if addition failed.</returns>
        public TRow? AddRow(IDictionary<string, object?> values, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return AddRow(values, (x, y) => DiGi.Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        /// <summary>
        /// Adds a new row to the table using column indices and values.
        /// </summary>
        /// <param name="values">A dictionary of column indices and their corresponding values.</param>
        /// <returns>The added row, or null if addition failed.</returns>
        public TRow? AddRow(IDictionary<int, object?>? values)
        {
            if (values == null)
            {
                return default;
            }

            return AddRow(CreateRow(GetNextRowIndex(), values));
        }

        /// <summary>
        /// Adds a new row to the table using an ordered collection of values.
        /// </summary>
        /// <param name="values">A sequence of values corresponding to columns in order.</param>
        /// <returns>The added row, or null if addition failed.</returns>
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

        /// <summary>
        /// Clears all rows and columns from the table.
        /// </summary>
        public void Clear()
        {
            rows.Clear();
            columns.Clear();
        }

        /// <summary>
        /// Clears all rows from the table, keeping the columns intact.
        /// </summary>
        public void ClearRows()
        {
            rows.Clear();
        }

        /// <summary>
        /// Gets a column by its index.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <returns>A clone of the column if found; otherwise, default.</returns>
        public TColumn? GetColumn(int index)
        {
            if (!columns.TryGetValue(index, out TColumn column))
            {
                return default;
            }

            return column == null ? default : DiGi.Core.Query.Clone(column);
        }

        /// <summary>
        /// Gets the index of a column based on its name.
        /// </summary>
        /// <param name="name">The name of the column to search for.</param>
        /// <param name="matchColumnFunc">An optional custom function to match the name.</param>
        /// <returns>The zero-based index of the column, or -1 if not found.</returns>
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

        /// <summary>
        /// Gets the index of a column based on its name and specific text comparison settings.
        /// </summary>
        /// <param name="name">The name of the column to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>The zero-based index of the column, or -1 if not found.</returns>
        public int GetColumnIndex(string name, Enums.TextComparisonType textComparisonType, bool caseSensitive)
        {
            return GetColumnIndex(name, (x, y) => DiGi.Core.Query.Compare(x, y, textComparisonType, caseSensitive));
        }

        /// <summary>
        /// Gets all values for a specific column index across all rows.
        /// </summary>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <returns>An array containing the values of the specified column for each row.</returns>
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

        /// <summary>
        /// Gets all values for a specific column across all rows.
        /// </summary>
        /// <param name="column">The column object.</param>
        /// <returns>An array containing the values of the specified column for each row, or null if the column is null.</returns>
        public object?[]? GetColumnValues(TColumn? column)
        {
            if (column is null)
            {
                return null;
            }

            return GetColumnValues(column.Index);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the rows of the table.
        /// </summary>
        /// <returns>An enumerator for the rows.</returns>
        public IEnumerator<TRow> GetEnumerator()
        {
            return Rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the next available index for a column.
        /// </summary>
        /// <returns>The next index, or -1 if columns cannot be accessed.</returns>
        public int GetNextColumnIndex()
        {
            if (columns == null)
            {
                return -1;
            }

            return columns.Count == 0 ? 0 : columns.Last().Key + 1;
        }

        /// <summary>
        /// Gets the next available index for a row.
        /// </summary>
        /// <returns>The next index, or -1 if rows cannot be accessed.</returns>
        public int GetNextRowIndex()
        {
            if (rows == null)
            {
                return -1;
            }

            return rows.Count == 0 ? 0 : rows.Last().Key + 1;
        }

        /// <summary>
        /// Gets a row by its index.
        /// </summary>
        /// <param name="index">The zero-based index of the row.</param>
        /// <returns>A clone of the row if found; otherwise, default.</returns>
        public TRow? GetRow(int index)
        {
            if (!rows.TryGetValue(index, out TRow row) || row == null)
            {
                return default;
            }

            return row.Clone();
        }

        /// <summary>
        /// Gets the value at the specified row and column indices.
        /// </summary>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <returns>The value at the specified position.</returns>
        public object? GetValue(int rowIndex, int columnIndex)
        {
            return this[rowIndex, columnIndex];
        }

        /// <summary>
        /// Gets the value for the specified row and column objects.
        /// </summary>
        /// <param name="row">The row object.</param>
        /// <param name="column">The column object.</param>
        /// <returns>The value at the intersection of the specified row and column.</returns>
        public object? GetValue(TRow? row, TColumn? column)
        {
            return this[row, column];
        }

        /// <summary>
        /// Gets the value at the specified row and column indices, cast to the specified type.
        /// </summary>
        /// <typeparam name="T">The expected type of the value.</typeparam>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <returns>The value cast to specified type, or default if not available or cast failed.</returns>
        public T? GetValue<T>(int rowIndex, int columnIndex)
        {
            if (!TryGetValue(rowIndex, columnIndex, out T? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Gets the value for the specified row and column objects, cast to the specified type.
        /// </summary>
        /// <typeparam name="T">The expected type of the value.</typeparam>
        /// <param name="row">The row object.</param>
        /// <param name="column">The column object.</param>
        /// <returns>The value cast to specified type, or default if not available or cast failed.</returns>
        public T? GetValue<T>(TRow? row, TColumn? column)
        {
            if (!TryGetValue(row, column, out T? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Gets all values for the specified row index.
        /// </summary>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <returns>An array containing the values of the specified row, or null if the row is not found.</returns>
        public object?[]? GetValues(int rowIndex)
        {
            if (!rows.TryGetValue(rowIndex, out TRow row) || row == null)
            {
                return null;
            }

            return row.GetValues();
        }

        /// <summary>
        /// Gets all values for all rows in the table.
        /// </summary>
        /// <returns>A jagged array containing all values of all rows.</returns>
        public object?[]?[]? GetValues()
        {
            List<object?[]?> rows = [];

            int rowCount = RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                object?[]? row = GetValues(i);
                if (row != null)
                {
                    rows.Add(row);
                }
            }

            return [.. rows];
        }

        /// <summary>
        /// Removes a column at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the column to remove.</param>
        /// <returns>True if the column was removed; otherwise, false.</returns>
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

        /// <summary>
        /// Removes columns at the specified indices and shifts remaining columns to fill gaps.
        /// </summary>
        /// <param name="indexes">The collection of zero-based indices of the columns to remove.</param>
        /// <returns>A list of indices that were successfully removed, or null if input was null.</returns>
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

        /// <summary>
        /// Removes a row at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the row to remove.</param>
        /// <returns>True if the row was removed; otherwise, false.</returns>
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

        /// <summary>
        /// Removes rows at the specified indices and shifts remaining rows to fill gaps.
        /// </summary>
        /// <param name="indexes">The collection of zero-based indices of the rows to remove.</param>
        /// <returns>A list of indices that were successfully removed, or null if input was null.</returns>
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
                if (row is not null)
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

        /// <summary>
        /// Sets the value at the specified row and column indices.
        /// </summary>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <param name="value">The value to set.</param>
        /// <param name="tryConvert">Whether to attempt conversion of the value to the column type.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
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

        /// <summary>
        /// Attempts to get a column by its name.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="column">When this method returns, contains the column if found; otherwise, null.</param>
        /// <param name="textComparisonType">The type of text comparison to use.</param>
        /// <param name="caseSensitive">Whether the search should be case-sensitive.</param>
        /// <returns>True if the column was found; otherwise, false.</returns>
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

        /// <summary>
        /// Attempts to get a valid value for the specified column index.
        /// </summary>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <param name="in">The value to validate/convert.</param>
        /// <param name="out">When this method returns, contains the validated/converted value if successful; otherwise, null.</param>
        /// <param name="tryConvert">Whether to attempt conversion of the value to the column type.</param>
        /// <returns>True if a valid value was obtained; otherwise, false.</returns>
        public bool TryGetValidValue(int columnIndex, object? @in, out object? @out, bool tryConvert = true)
        {
            @out = null;

            if (!columns.TryGetValue(columnIndex, out TColumn column) || column == null)
            {
                return false;
            }

            return column.TryGetValidValue(@in, out @out, tryConvert);
        }

        /// <summary>
        /// Attempts to get a value from the specified row and column indices, cast to type T.
        /// </summary>
        /// <typeparam name="T">The expected type of the value.</typeparam>
        /// <param name="rowIndex">The zero-based index of the row.</param>
        /// <param name="columnIndex">The zero-based index of the column.</param>
        /// <param name="value">When this method returns, contains the value if found and cast successfully; otherwise, default.</param>
        /// <returns>True if the value was found and cast successfully; otherwise, false.</returns>
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

        /// <summary>
        /// Attempts to get a value for the specified row and column objects, cast to type T.
        /// </summary>
        /// <typeparam name="T">The expected type of the value.</typeparam>
        /// <param name="row">The row object.</param>
        /// <param name="column">The column object.</param>
        /// <param name="value">When this method returns, contains the value if found and cast successfully; otherwise, default.</param>
        /// <returns>True if the value was found and cast successfully; otherwise, false.</returns>
        public bool TryGetValue<T>(TRow? row, TColumn? column, out T? value)
        {
            value = default;

            if (column == null || row == null)
            {
                return false;
            }

            return TryGetValue(row.Index, column.Index, out value);
        }

        /// <summary>
        /// Updates an existing column at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the column to update.</param>
        /// <param name="column">The new column definition.</param>
        /// <param name="tryConvert">Whether to attempt conversion of existing row values to the new column type.</param>
        /// <returns>A clone of the updated column, or null if update failed.</returns>
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

        /// <summary>
        /// Updates a row at the specified index using column names and values.
        /// </summary>
        /// <param name="index">The zero-based index of the row to update.</param>
        /// <param name="values">A dictionary of column names and their corresponding values.</param>
        /// <param name="func">An optional custom function to match column names.</param>
        /// <returns>The updated row, or null if update failed.</returns>
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

        /// <summary>
        /// Updates a row at the specified index using column indices and values.
        /// </summary>
        /// <param name="index">The zero-based index of the row to update.</param>
        /// <param name="values">A dictionary of column indices and their corresponding values.</param>
        /// <returns>The updated row, or null if update failed.</returns>
        public TRow? UpdateRow(int index, IDictionary<int, object?>? values)
        {
            if (values == null || index > rows.Keys.Last())
            {
                return default;
            }

            return AddRow(CreateRow(index, values));
        }

        /// <summary>
        /// Updates a row at the specified index using an ordered collection of values.
        /// </summary>
        /// <param name="index">The zero-based index of the row to update.</param>
        /// <param name="values">A sequence of values corresponding to columns in order.</param>
        /// <returns>The updated row, or null if update failed.</returns>
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

        /// <summary>
        /// Creates a new row instance for the table. Must be implemented by derived classes.
        /// </summary>
        /// <param name="index">The index to assign to the new row.</param>
        /// <param name="values">Optional initial values for the row.</param>
        /// <returns>A newly created row instance.</returns>
        protected abstract TRow CreateRow(int index, IDictionary<int, object?>? values = null);
    }

    /// <summary>
    /// Represents a table with columns of type <typeparamref name="TColumn"/> and rows of type <see cref="Row"/>.
    /// </summary>
    public class Table<TColumn> : Table<TColumn, Row> where TColumn : IColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Table{TColumn}"/> class.
        /// </summary>
        public Table()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table{TColumn}"/> class with specified columns.
        /// </summary>
        /// <param name="columns">The collection of columns to add to the table.</param>
        public Table(IEnumerable<TColumn> columns)
            : base(columns)
        {
        }

        /// <summary>
        /// Creates a new <see cref="Row"/> for this table.
        /// </summary>
        /// <param name="index">The index to assign to the new row.</param>
        /// <param name="values">Optional initial values for the row.</param>
        /// <returns>A newly created row instance.</returns>
        protected override Row CreateRow(int index, IDictionary<int, object?>? values = null)
        {
            return new Row(index, values);
        }
    }

    /// <summary>
    /// Represents a standard table with default <see cref="Column"/> and <see cref="Row"/> types.
    /// </summary>
    public class Table : Table<Column>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class.
        /// </summary>
        public Table()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Table"/> class with specified columns.
        /// </summary>
        /// <param name="columns">The collection of columns to add to the table.</param>
        public Table(IEnumerable<Column> columns)
            : base(columns)
        {
        }

        /// <summary>
        /// Adds a new column with default settings.
        /// </summary>
        /// <returns>The added column, or null if addition failed.</returns>
        public Column? AddColumn()
        {
            return AddColumn(null as Type);
        }

        /// <summary>
        /// Adds a new column with the specified type.
        /// </summary>
        /// <param name="type">The type of the new column.</param>
        /// <returns>The added column, or null if addition failed.</returns>
        public Column? AddColumn(Type? type)
        {
            int index = GetNextColumnIndex();

            return AddColumn(new Column(index, type));
        }

        /// <summary>
        /// Adds a new column with the specified name and type.
        /// </summary>
        /// <param name="name">The name of the new column.</param>
        /// <param name="type">The type of the new column.</param>
        /// <returns>The added column, or null if addition failed.</returns>
        public Column? AddColumn(string? name, Type? type = null)
        {
            return AddColumn(new Column(name, type));
        }

        /// <summary>
        /// Updates an existing column with a new name and type.
        /// </summary>
        /// <param name="index">The zero-based index of the column to update.</param>
        /// <param name="name">The new name for the column.</param>
        /// <param name="type">The new type for the column.</param>
        /// <param name="tryConvert">Whether to attempt conversion of existing row values to the new column type.</param>
        /// <returns>A clone of the updated column, or null if update failed.</returns>
        public Column? UpdateColumn(int index, string? name, Type? type = null, bool tryConvert = true)
        {
            return UpdateColumn(index, new Column(name, type), tryConvert);
        }
    }
}