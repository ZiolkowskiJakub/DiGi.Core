using DiGi.Core.IO.DelimitedData.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Query
    {
        public static List<string> Values(this string line, char separator, Func<string> nextLine = null)
        {
            if (line == null)
            {
                return null;
            }

            int position = 0;
            int rowCount = 0;

            DelimitedDataRow result = new DelimitedDataRow();

            while (position < line.Length)
            {
                string value;

                // Special handling for quoted field
                if (line[position] == '"')
                {
                    // Skip initial quote
                    position++;

                    // Parse quoted value
                    int start = position;
                    while (position < line.Length)
                    {
                        // Test for quote character
                        if (line[position] == '"')
                        {
                            // Found one
                            position++;

                            // If two quotes together, keep one Otherwise, indicates end of value
                            if (position >= line.Length || line[position] != '"')
                            {
                                position--;
                                break;
                            }
                        }
                        position++;

                        //Code which read quoted text with break line symbol
                        while (position == line.Length)
                        {
                            string lineText = nextLine?.Invoke();
                            if (lineText == null)
                            {
                                break;
                            }

                            line += "\n" + lineText;
                        }
                    }
                    value = line.Substring(start, position - start);
                    value = value.Replace("\"\"", "\"");
                }
                else
                {
                    // Parse unquoted value
                    int start = position;
                    while (position < line.Length && line[position] != separator)
                    {
                        position++;
                    }

                    value = line.Substring(start, position - start);
                }

                // Add field to list
                if (rowCount < result.Count)
                {
                    result[rowCount] = value;
                }
                else
                {
                    result.Add(value);
                }
                rowCount++;

                // Eat up to and including next comma
                while (position < line.Length && line[position] != separator)
                {
                    position++;
                }

                if (position < line.Length)
                {
                    position++;
                }
            }
            // Delete any unused items
            while (result.Count > rowCount)
            {
                result.RemoveAt(rowCount);
            }

            // Return true if any columns read
            return result;
        }
    }
}