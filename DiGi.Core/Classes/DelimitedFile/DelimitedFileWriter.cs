using DiGi.Core.Classes;
using DiGi.Core;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;

namespace DiGi.Core.Classes
{
    public class DelimitedFileWriter : StreamWriter, IDelimitedFileWriter
    {
        private char separator;

        public DelimitedFileWriter(char separator, Stream stream)
            : base(stream)
        {
            this.separator = separator;
        }

        public DelimitedFileWriter(char separator, string path)
            : base(path)
        {
            this.separator = separator;
        }

        public DelimitedFileWriter(DelimitedFileType delimitedFileType, string path)
            : base(path)
        {
            separator = Query.Separator(delimitedFileType);
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
        /// <param name="delimitedFileRow">The row to be written</param>
        public void Write(DelimitedFileRow delimitedFileRow)
        {
            if (delimitedFileRow == null)
                return;

            StringBuilder stringBuilder = new StringBuilder();
            bool firstColumn = true;
            foreach (string value in delimitedFileRow)
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
            delimitedFileRow.LineText = stringBuilder.ToString();
            WriteLine(delimitedFileRow.LineText);
        }

        /// <summary>
        /// Writes a rows to a CSV file.
        /// </summary>
        /// <param name="delimitedFileRows">The rows to be written</param>
        public void Write(IEnumerable<DelimitedFileRow> delimitedFileRows)
        {
            foreach (DelimitedFileRow delimitedFileRow in delimitedFileRows)
            {
                Write(delimitedFileRow);
            }
        }

        public void Write(DelimitedFileTable delimitedFileTable)
        {
            if (delimitedFileTable == null)
            {
                return;
            }

            delimitedFileTable.Write(this);
        }
    }
}