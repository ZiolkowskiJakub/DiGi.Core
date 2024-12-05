using DiGi.Core.IO.DelimitedData.Classes;
using DiGi.Core.IO.DelimitedData.Interfaces;
using DiGi.Core.IO.Table.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Modify
    {
        public static bool Write(this Table.Classes.Table table, IDelimitedDataWriter delimitedDataWriter, Func<object, string> func = null)
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
                delimitedDataWriter.Write(new DelimitedDataRow(columns.ToList().ConvertAll(x => x?.Name)));
            }

            Func<object, string> func_Temp = func;
            if(func_Temp == null)
            {
                func = x => x?.ToString();
            }

            IEnumerable<Row> rows = table.Rows;
            if (rows != null)
            {
                foreach (Row row in rows)
                {
                    List<string> values = new List<string>();
                    foreach (Column column in columns)
                    {
                        values.Add(func(row[column.Index]));
                    }

                    delimitedDataWriter.Write(new DelimitedDataRow(values));
                }
            }

            return true;
        }

        public static bool Write(this Table.Classes.Table table, string path, char separator, Func<object, string> func = null)
        {
            if(table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            return Write(table, new DelimitedDataWriter(separator, path), func);
        }
    }
}
