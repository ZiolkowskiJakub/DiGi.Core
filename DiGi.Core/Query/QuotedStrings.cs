using System.Collections.Generic;
using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Splits a string by a separator, respecting quoted sections.
        /// </summary>
        /// <param name="text">The text to split.</param>
        /// <param name="separator">The separator string.</param>
        /// <returns>A list of extracted strings.</returns>
        public static List<string>? QuotedStrings(string? text, string separator = ",")
        {
            if (text == null)
            {
                return null;
            }

            List<string> fields = [];
            bool inQuotes = false;
            StringBuilder stringBuilder = new();
            int separatorLength = separator.Length;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c == '"' && (i + 1 < text.Length && text[i + 1] == '"')) // Escaped quote
                {
                    stringBuilder.Append('"');
                    i++; // Skip the next quote
                }
                else if (c == '"') // Start or end of quoted field
                {
                    inQuotes = !inQuotes;
                }
                else if (!inQuotes && i + separatorLength <= text.Length && text.Substring(i, separatorLength) == separator) // Field delimiter
                {
                    fields.Add(stringBuilder.ToString());
                    stringBuilder.Clear();
                    i += separatorLength - 1; // Skip the separator
                }
                else // Regular character
                {
                    stringBuilder.Append(c);
                }
            }

            if (stringBuilder.Length > 0)
            {
                fields.Add(stringBuilder.ToString()); // Add the last field
            }

            return fields;
        }
    }
}