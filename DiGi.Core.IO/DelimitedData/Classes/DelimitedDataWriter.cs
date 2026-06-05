using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    /// <summary>
    /// Writer for delimited data files.
    /// </summary>
    public class DelimitedDataWriter : StreamWriter, IDelimitedDataWriter
    {
        private readonly char separator;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataWriter"/> class.
        /// </summary>
        /// <param name="separator">The character to use as a separator.</param>
        /// <param name="stream">The stream where data will be written.</param>
        public DelimitedDataWriter(char separator, Stream? stream)
            : base(stream)
        {
            this.separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataWriter"/> class.
        /// </summary>
        /// <param name="separator">The character to use as a separator.</param>
        /// <param name="path">The path to the file where data will be written.</param>
        public DelimitedDataWriter(char separator, string? path)
            : base(path)
        {
            this.separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataWriter"/> class.
        /// </summary>
        /// <param name="delimitedDataSeparator">The separator to use for delimited data.</param>
        /// <param name="path">The path to the file where data will be written.</param>
        public DelimitedDataWriter(DelimitedDataSeparator delimitedDataSeparator, string? path)
            : base(path)
        {
            separator = delimitedDataSeparator.Separator();
        }

        /// <summary>
        /// Gets the character used as a separator in the delimited data file.
        /// </summary>
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
        public void WriteRow(DelimitedDataRow? delimitedDataRow)
        {
            WriteLine(delimitedDataRow?.Text(separator));
        }

        /// <summary>
        /// Writes a rows to a CSV file.
        /// </summary>
        /// <param name="delimitedDataRows">The rows to be written</param>
        public void WriteRows(IEnumerable<DelimitedDataRow>? delimitedDataRows)
        {
            if (delimitedDataRows == null)
            {
                return;
            }

            foreach (DelimitedDataRow delimitedDataRow in delimitedDataRows)
            {
                WriteRow(delimitedDataRow);
            }
        }
    }
}