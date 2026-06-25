using DiGi.Core.IO.DelimitedData.Classes;
using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using DiGi.Core.IO.Table.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Modify
    {
        /// <summary>
        /// Writes a table to a delimited data writer.
        /// </summary>
        /// <param name="table">The table to write.</param>
        /// <param name="delimitedDataWriter">The delimited data writer to use.</param>
        /// <param name="func">An optional function to convert objects to strings.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(this Table.Classes.Table? table, IDelimitedDataWriter? delimitedDataWriter, Func<object?, string?>? func = null)
        {
            if (table == null || delimitedDataWriter == null)
            {
                return false;
            }

            IEnumerable<Column> columns = table.Columns;
            if (columns == null)
            {
                return false;
            }

            if (columns.Any(x => x?.Name != null))
            {
                delimitedDataWriter.WriteRow([.. columns.ToList().ConvertAll(x => x?.Name ?? string.Empty)]);
            }

            Func<object?, string?>? func_Temp = func;
            func_Temp ??= x => x?.ToString();

            IEnumerable<Row> rows = table.Rows;
            if (rows != null)
            {
                foreach (Row row in rows)
                {
                    List<string> values = [];
                    foreach (Column column in columns)
                    {
                        values.Add(func_Temp(row[column.Index]) ?? string.Empty);
                    }

                    delimitedDataWriter.WriteRow([.. values]);
                }
            }

            return true;
        }

        /// <summary>
        /// Writes a table to a delimited file using a separator character.
        /// </summary>
        /// <param name="table">The table to write.</param>
        /// <param name="path">The path where the file will be written.</param>
        /// <param name="separator">The character to use as a separator.</param>
        /// <param name="func">An optional function to convert objects to strings.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(this Table.Classes.Table? table, string? path, char separator, Func<object?, string?>? func = null)
        {
            if (table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            bool result = false;
            using (DelimitedDataWriter delimitedDataWriter = new(separator, path!))
            {
                result = Write(table, delimitedDataWriter, func);
            }

            return result;
        }

        /// <summary>
        /// Writes a table to a delimited file using a DelimitedDataSeparator enum.
        /// </summary>
        /// <param name="table">The table to write.</param>
        /// <param name="path">The path where the file will be written.</param>
        /// <param name="delimitedDataSeparator">The separator to use for the delimited data.</param>
        /// <param name="func">An optional function to convert objects to strings.</param>
        /// <returns>True if the write operation was successful; otherwise, false.</returns>
        public static bool Write(this Table.Classes.Table? table, string? path, DelimitedDataSeparator delimitedDataSeparator, Func<object?, string?>? func = null)
        {
            if (table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            bool result = false;
            using (DelimitedDataWriter delimitedDataWriter = new(delimitedDataSeparator.Separator(), path!))
            {
                result = Write(table, delimitedDataWriter, func);
            }

            return result;
        }
    }
}