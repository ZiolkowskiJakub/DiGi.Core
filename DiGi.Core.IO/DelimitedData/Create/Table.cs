using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Create
    {
        /// <summary>
        /// Converts DelimitedDataReader to Table
        /// </summary>
        /// <param name="delimitedDataReader">DelimitedDataReader</param>
        /// <param name="columnIndex">Header index (column names). If data has no header then set to -1</param>
        /// <param name="rowIndex">Row Index where data starts</param>
        /// <returns></returns>
        public static Table.Classes.Table Table(this IDelimitedDataReader delimitedDataReader, int columnIndex = 0, int rowIndex = 1)
        {
            if(delimitedDataReader == null)
            {
                return null;
            }

            Table.Classes.Table result = new Table.Classes.Table();
            result.Read(delimitedDataReader, columnIndex, rowIndex);

            return result;
        }

        public static Table.Classes.Table Table(string path, char separator, int columnIndex = 0, int rowIndex = 1)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            Table.Classes.Table result = new Table.Classes.Table();
            result.Read(path, separator, columnIndex, rowIndex);

            return result;
        }

        public static Table.Classes.Table Table(string path, DelimitedDataSeparator delimitedDataSeparator, int columnIndex = 0, int rowIndex = 1)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            Table.Classes.Table result = new Table.Classes.Table();
            result.Read(path, delimitedDataSeparator, columnIndex, rowIndex);

            return result;
        }
    }
}
