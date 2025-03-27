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
        public static bool Read(this Table.Classes.Table table, IDelimitedDataReader delimitedDataReader, int columnIndex = 0, int rowIndex = 1)
        {
            List<DelimitedDataRow> delimitedDataRows = delimitedDataReader?.ReadRows();
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
                    Column column = table.GetColumn(i);
                    if(column != null)
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
                    Column column = table.GetColumn(i);
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
                Dictionary<int, object> dictionary = new Dictionary<int, object>();
                for (int j = 0; j < delimitedDataRows[i].Count; j++)
                {
                    dictionary[j] = delimitedDataRows[i][j];
                }

                table.AddRow(dictionary);
            }

            return true;
        }

        public static bool Read(this Table.Classes.Table table, string path, char separator, int columnIndex = 0, int rowIndex = 1)
        {
            if(table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            return Read(table, new DelimitedDataReader(separator, path), columnIndex, rowIndex);
        }

        public static bool Read(this Table.Classes.Table table, string path, DelimitedDataSeparator delimitedDataSeparator, int columnIndex = 0, int rowIndex = 1)
        {
            if (table == null || string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            return Read(table, new DelimitedDataReader(delimitedDataSeparator, path), columnIndex, rowIndex);
        }
    }
}
