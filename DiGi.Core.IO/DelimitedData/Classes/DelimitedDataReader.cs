using DiGi.Core.Enums;
using DiGi.Core.IO.DelimitedData.Enums;
using DiGi.Core.IO.DelimitedData.Interfaces;
using DiGi.Core.IO.DelimitedData.Query;
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
        public bool Read(DelimitedDataRow delimitedDataRow)
        {
            delimitedDataRow.LineText = ReadLine();
            if (delimitedDataRow.LineText == null)
            {
                return false;
            }

            int position = 0;
            int rowCount = 0;

            while (position < delimitedDataRow.LineText.Length)
            {
                string value;

                // Special handling for quoted field
                if (delimitedDataRow.LineText[position] == '"')
                {
                    // Skip initial quote
                    position++;

                    // Parse quoted value
                    int start = position;
                    while (position < delimitedDataRow.LineText.Length)
                    {
                        // Test for quote character
                        if (delimitedDataRow.LineText[position] == '"')
                        {
                            // Found one
                            position++;

                            // If two quotes together, keep one Otherwise, indicates end of value
                            if (position >= delimitedDataRow.LineText.Length || delimitedDataRow.LineText[position] != '"')
                            {
                                position--;
                                break;
                            }
                        }
                        position++;

                        //Code which read quoted text with break line symbol
                        while (position == delimitedDataRow.LineText.Length)
                        {
                            string lineText = ReadLine();
                            if (lineText == null)
                            {
                                break;
                            }

                            delimitedDataRow.LineText += "\n" + lineText;
                        }
                    }
                    value = delimitedDataRow.LineText.Substring(start, position - start);
                    value = value.Replace("\"\"", "\"");
                }
                else
                {
                    // Parse unquoted value
                    int start = position;
                    while (position < delimitedDataRow.LineText.Length && delimitedDataRow.LineText[position] != separator)
                    {
                        position++;
                    }

                    value = delimitedDataRow.LineText.Substring(start, position - start);
                }

                // Add field to list
                if (rowCount < delimitedDataRow.Count)
                {
                    delimitedDataRow[rowCount] = value;
                }
                else
                {
                    delimitedDataRow.Add(value);
                }
                rowCount++;

                // Eat up to and including next comma
                while (position < delimitedDataRow.LineText.Length && delimitedDataRow.LineText[position] != separator)
                {
                    position++;
                }

                if (position < delimitedDataRow.LineText.Length)
                {
                    position++;
                }
            }
            // Delete any unused items
            while (delimitedDataRow.Count > rowCount)
            {
                delimitedDataRow.RemoveAt(rowCount);
            }

            // Return true if any columns read
            return delimitedDataRow.Count > 0;
        }

        /// <summary>
        /// Reads a rows of data from a CSV file
        /// </summary>
        /// <returns>List of the rows</returns>
        public new List<DelimitedDataRow> Read()
        {
            List<DelimitedDataRow> delimitedDataRows = new List<DelimitedDataRow>();
            DelimitedDataRow delimitedDataRow = new DelimitedDataRow();
            while (Read(delimitedDataRow))
            {
                delimitedDataRows.Add(delimitedDataRow);
                delimitedDataRow = new DelimitedDataRow();
            }
            return delimitedDataRows;
        }
    }
}