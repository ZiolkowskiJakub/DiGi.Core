using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    /// <summary>
    /// Reader for delimited data files.
    /// </summary>
    public class DelimitedDataReader : StreamReader, IDelimitedDataReader
    {
        private readonly char separator;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataReader"/> class.
        /// </summary>
        public DelimitedDataReader(char separator, Stream? stream)
            : base(stream)
        {
            this.separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataReader"/> class.
        /// </summary>
        public DelimitedDataReader(char separator, string? path)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            this.separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataReader"/> class.
        /// </summary>
        public DelimitedDataReader(char separator, IEnumerable<string>? lines)
            : base(lines?.MemoryStream())
        {
            this.separator = separator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataReader"/> class.
        /// </summary>
        public DelimitedDataReader(DelimitedDataSeparator delimitedDataSeparator, IEnumerable<string>? lines)
            : base(lines?.MemoryStream())
        {
            separator = delimitedDataSeparator.Separator();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataReader"/> class.
        /// </summary>
        public DelimitedDataReader(DelimitedDataSeparator delimitedDataSeparator, string? path)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            separator = delimitedDataSeparator.Separator();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataReader"/> class.
        /// </summary>
        public DelimitedDataReader(DelimitedDataSeparator delimitedDataSeparator, string? path, System.Text.Encoding encoding)
            : base(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), encoding)
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
        /// Reads a row of data from a CSV file
        /// </summary>
        /// <returns>DelimitedDataRow</returns>
        public DelimitedDataRow? ReadRow()
        {
            List<string>? values = Query.Values(ReadLine(), separator, () => ReadLine());
            if (values == null)
            {
                return null;
            }

            return [.. values];
        }

        /// <summary>
        /// Reads a rows of data from a CSV file
        /// </summary>
        /// <returns>List of the rows</returns>
        public List<DelimitedDataRow> ReadRows()
        {
            List<DelimitedDataRow> delimitedDataRows = [];
            DelimitedDataRow? delimitedDataRow = ReadRow();
            while (delimitedDataRow != null)
            {
                delimitedDataRows.Add(delimitedDataRow);
                delimitedDataRow = ReadRow();
            }

            return delimitedDataRows;
        }
    }
}