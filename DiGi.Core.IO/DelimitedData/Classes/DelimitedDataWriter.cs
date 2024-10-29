using System.Collections.Generic;
using System.IO;
using System.Text;
using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using DiGi.Core.IO.DelimitedData.Query;

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
        public void Write(DelimitedDataRow delimitedDataRow)
        {
            if (delimitedDataRow == null)
                return;

            StringBuilder stringBuilder = new StringBuilder();
            bool firstColumn = true;
            foreach (string value in delimitedDataRow)
            {
                // Add separator if this isn't the first value
                if (!firstColumn)
                {
                    stringBuilder.Append(Separator);
                }

                // Implement special handling for values that contain comma or quote Enclose in
                // quotes and double up any double quotes
                if (value.IndexOfAny(new char[] { '"', separator }) != -1)
                {
                    stringBuilder.AppendFormat("\"{0}\"", value.Replace("\"", "\"\""));
                }
                else
                {
                    stringBuilder.Append(value);
                }

                firstColumn = false;
            }
            delimitedDataRow.LineText = stringBuilder.ToString();
            WriteLine(delimitedDataRow.LineText);
        }

        /// <summary>
        /// Writes a rows to a CSV file.
        /// </summary>
        /// <param name="delimitedDataRows">The rows to be written</param>
        public void Write(IEnumerable<DelimitedDataRow> delimitedDataRows)
        {
            foreach (DelimitedDataRow delimitedDataRow in delimitedDataRows)
            {
                Write(delimitedDataRow);
            }
        }

        public void Write(DelimitedDataTable delimitedDataTable)
        {
            if (delimitedDataTable == null)
            {
                return;
            }

            delimitedDataTable.Write(this);
        }
    }
}