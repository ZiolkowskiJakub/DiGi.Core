using DiGi.Core.IO.Table.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Modify
    {
        public static bool Append(string path, Table.Classes.Table table, char separator, Func<object, string> func = null)
        {
            if (table == null || string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            IEnumerable<Column> columns_Table = table.Columns;
            if (columns_Table == null)
            {
                return false;
            }

            List<Column> columns = null;
            if (System.IO.File.Exists(path))
            {
                List<string> lines = IO.Query.Lines(path, 1);
                if (lines != null && lines.Count != 0)
                {
                    columns = Create.Columns(Query.Values(lines[0], separator));
                }
            }


            if (columns == null || columns.Count == 0)
            {
                columns = new List<Column>(columns_Table);

                System.IO.File.AppendAllText(path, columns_Table.ToList().ConvertAll(x => x?.Name).Text(separator) + '\n');
            }
            else
            {
                bool updated = false;

                int max = columns.Count == 0 ? 0 : columns.ConvertAll(x => x.Index).Max() + 1;
                foreach (Column column_Table in columns_Table)
                {
                    if (column_Table == null)
                    {
                        continue;
                    }

                    int index = columns.FindIndex(x => x.Name == column_Table.Name);
                    if (index != -1)
                    {
                        continue;
                    }

                    updated = true;
                    columns.Add(new Column(max, column_Table));
                    max++;
                }

                if (updated)
                {
                    IO.Modify.UpdateLine(path, 0, columns.ToList().ConvertAll(x => x?.Name).Text(separator));
                }
            }

            Func<object, string> func_Temp = func;
            if (func_Temp == null)
            {
                func_Temp = x => x?.ToString();
            }

            IEnumerable<Row> rows = table.Rows;
            if (rows != null)
            {
                foreach (Row row in rows)
                {
                    List<string> values = new List<string>();
                    foreach (Column column in columns)
                    {
                        values.Add(func_Temp(row[column.Index]));
                    }

                    System.IO.File.AppendAllText(path, values.Text(separator) + '\n');
                }
            }

            return true;
        }
    }
}
   
