using System.Collections.Generic;
using System.IO;
using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    public class DelimitedDataWriter : StreamWriter, IDelimitedDataWriter
    {
        private char separator;

        public DelimitedDataWriter(char separator, Stream stream)
            : base(stream)
        {
            this.separator = separator;
        }

        public DelimitedDataWriter(char separator, string path)
            : base(path)
        {
            this.separator = separator;
        }

        public DelimitedDataWriter(DelimitedDataSeparator delimitedDataSeparator, string path)
            : base(path)
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
        /// Writes a single row to a CSV file.
        /// </summary>
        /// <param name="delimitedDataRow">The row to be written</param>
        public void WriteRow(DelimitedDataRow delimitedDataRow)
        {
            WriteLine(delimitedDataRow?.Text(separator));
        }

        /// <summary>
        /// Writes a rows to a CSV file.
        /// </summary>
        /// <param name="delimitedDataRows">The rows to be written</param>
        public void WriteRows(IEnumerable<DelimitedDataRow> delimitedDataRows)
        {
            foreach (DelimitedDataRow delimitedDataRow in delimitedDataRows)
            {
                WriteRow(delimitedDataRow);
            }
        }
    }
}