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
        public static Table.Classes.Table? Table(this IDelimitedDataReader? delimitedDataReader, int columnIndex = 0, int rowIndex = 1)
        {
            if (delimitedDataReader == null)
            {
                return null;
            }

            Table.Classes.Table result = new();
            result.Read(delimitedDataReader, columnIndex, rowIndex);

            return result;
        }

        /// <summary>
        /// Creates a Table from a delimited file using a separator character.
        /// </summary>
        /// <param name="path">The path to the delimited file.</param>
        /// <param name="separator">The character used as a separator in the delimited file.</param>
        /// <param name="columnIndex">The index of the column to start from. Defaults to 0.</param>
        /// <param name="rowIndex">The index of the row to start from. Defaults to 1.</param>
        /// <returns>A Table object if successful; otherwise, null.</returns>
        public static Table.Classes.Table? Table(string? path, char separator, int columnIndex = 0, int rowIndex = 1)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            Table.Classes.Table result = new();
            result.Read(path, separator, columnIndex, rowIndex);

            return result;
        }

        /// <summary>
        /// Creates a Table from a delimited file using a DelimitedDataSeparator enum value.
        /// </summary>
        /// <param name="path">The path to the delimited file.</param>
        /// <param name="delimitedDataSeparator">The separator used in the delimited file.</param>
        /// <param name="columnIndex">The index of the column to start from. Defaults to 0.</param>
        /// <param name="rowIndex">The index of the row to start from. Defaults to 1.</param>
        /// <returns>A Table object if successful; otherwise, null.</returns>
        public static Table.Classes.Table? Table(string? path, DelimitedDataSeparator delimitedDataSeparator, int columnIndex = 0, int rowIndex = 1)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            Table.Classes.Table result = new();
            result.Read(path, delimitedDataSeparator, columnIndex, rowIndex);

            return result;
        }
    }
}