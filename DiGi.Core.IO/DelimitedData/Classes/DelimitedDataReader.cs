using DiGi.Core.Enums;
using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    public class DelimitedDataReader : StreamReader, IDelimitedDataReader
    {
        private char separator;

        public DelimitedDataReader(char separator, Stream stream)
            : base(stream)
        {
            this.separator = separator;
        }

        public DelimitedDataReader(char separator, string path)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            this.separator = separator;
        }

        public DelimitedDataReader(char separator, IEnumerable<string> lines)
            : base(lines.MemoryStream())
        {
            this.separator = separator;
        }

        public DelimitedDataReader(DelimitedDataSeparator delimitedDataSeparator, IEnumerable<string> lines)
            : base(lines.MemoryStream())
        {
            separator = delimitedDataSeparator.Separator();
        }

        public DelimitedDataReader(DelimitedDataSeparator delimitedDataSeparator, string path)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            separator = delimitedDataSeparator.Separator();
        }

        public DelimitedDataReader(DelimitedDataSeparator delimitedDataSeparator, string path, System.Text.Encoding encoding)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), encoding)
        {
            separator = delimitedDataSeparator.Separator();
        }

        public char Separator
        {
            get
            {
                return separator;
            }
        }

        /// <summary>
        /// Reads a row of data from a CSV file
        /// </summary>
        /// <param name="delimitedDataRow"></param>
        /// <returns></returns>
        public DelimitedDataRow ReadRow()
        {
            List<string> values = Query.Values(ReadLine(), separator, () => ReadLine());
            if(values == null)
            {
                return null;
            }

            return new DelimitedDataRow(values);
        }

        /// <summary>
        /// Reads a rows of data from a CSV file
        /// </summary>
        /// <returns>List of the rows</returns>
        public List<DelimitedDataRow> ReadRows()
        {
            List<DelimitedDataRow> delimitedDataRows = new List<DelimitedDataRow>();
            DelimitedDataRow delimitedDataRow = ReadRow();
            while (delimitedDataRow != null )
            {
                delimitedDataRows.Add(delimitedDataRow);
                delimitedDataRow = ReadRow();
            }

            return delimitedDataRows;
        }
    }
}