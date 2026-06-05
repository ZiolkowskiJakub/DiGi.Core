using DiGi.Core.IO.DelimitedData.Classes;
using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using DiGi.Core.IO.Table.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Modify
    {
        /// <summary>
        /// Reads delimited data from a reader into a table.
        /// </summary>
        /// <param name="table">The table to read the data into.</param>
        /// <param name="delimitedDataReader">The reader used to read the delimited data.</param>
        /// <param name="columnIndex">The index of the column to start reading from. Defaults to 0.</param>
        /// <param name="rowIndex">The index of the row to start reading from. Defaults to 1.</param>
        /// <returns>True if the data was read successfully; otherwise, false.</returns>
        public static bool Read(this Table.Classes.Table? table, IDelimitedDataReader? delimitedDataReader, int columnIndex = 0, int rowIndex = 1)
        {
            if (table == null)
            {
                return false;
            }

            List<DelimitedDataRow>? delimitedDataRows = delimitedDataReader?.ReadRows();
            if (delimitedDataRows == null || delimitedDataRows.Count == 0)
            {
                return false;
            }

            if (columnIndex > rowIndex || columnIndex > delimitedDataRows.Count)
            {
                return false;
            }

            int columnCount = -1;

            if (columnIndex >= 0)
            {
                DelimitedDataRow delimitedDataRow_Column = delimitedDataRows[columnIndex];
                if (delimitedDataRow_Column == null)
                {
                    return false;
                }

                columnCount = delimitedDataRow_Column.Count;

                for (int i = 0; i < columnCount; i++)
                {
                    Column? column = table.GetColumn(i);
                    if (column != null)
                    {
                        table.UpdateColumn(i, delimitedDataRow_Column[i], typeof(string));
                    }
                    else
                    {
                        table.AddColumn(delimitedDataRow_Column[i], typeof(string));
                    }
                }
            }
            else
            {
                columnCount = delimitedDataRows.ConvertAll(x => x.Count).Max();
                for (int i = 0; i < columnCount; i++)
                {
                    Column? column = table.GetColumn(i);
                    if (column != null)
                    {
                        table.UpdateColumn(i, column.Name, typeof(string));
                    }
                    else
                    {
                        table.AddColumn(typeof(string));
                    }
                }
            }

            int rowCount = delimitedDataRows.Count;

            for (int i = rowIndex; i < rowCount; i++)
            {
                Dictionary<int, object?> dictionary = [];
                for (int j = 0; j < delimitedDataRows[i].Count; j++)
                {
                    dictionary[j] = delimitedDataRows[i][j];
                }

                table.AddRow(dictionary);
            }

            return true;
        }

        /// <summary>
        /// Reads delimited data from a file using a separator character into a table.
        /// </summary>
        /// <param name="table">The table to read the data into.</param>
        /// <param name="path">The path to the file containing the delimited data.</param>
        /// <param name="separator">The character used as a separator in the delimited data file.</param>
        /// <param name="columnIndex">The index of the column to start reading from. Defaults to 0.</param>
        /// <param name="rowIndex">The index of the row to start reading from. Defaults to 1.</param>
        /// <returns>True if the data was read successfully; otherwise, false.</returns>
        public static bool Read(this Table.Classes.Table? table, string? path, char separator, int columnIndex = 0, int rowIndex = 1)
        {
            if (table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            return Read(table, new DelimitedDataReader(separator, path), columnIndex, rowIndex);
        }

        /// <summary>
        /// Reads delimited data from a file using a DelimitedDataSeparator enum into a table.
        /// </summary>
        /// <param name="table">The table to read the data into.</param>
        /// <param name="path">The path to the file containing the delimited data.</param>
        /// <param name="delimitedDataSeparator">The separator used in the delimited data file.</param>
        /// <param name="columnIndex">The index of the column to start reading from. Defaults to 0.</param>
        /// <param name="rowIndex">The index of the row to start reading from. Defaults to 1.</param>
        /// <returns>True if the data was read successfully; otherwise, false.</returns>
        public static bool Read(this Table.Classes.Table? table, string? path, DelimitedDataSeparator delimitedDataSeparator, int columnIndex = 0, int rowIndex = 1)
        {
            if (table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            return Read(table, new DelimitedDataReader(delimitedDataSeparator, path), columnIndex, rowIndex);
        }
    }
}