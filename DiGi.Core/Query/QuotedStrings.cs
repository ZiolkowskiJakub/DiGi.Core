using System.Collections.Generic;
using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<string> QuotedStrings(string text, string separator = ",")
        {
            var fields = new List<string>();
            bool inQuotes = false;
            var field = new StringBuilder();
            int separatorLength = separator.Length;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c == '"' && (i + 1 < text.Length && text[i + 1] == '"')) // Escaped quote
                {
                    field.Append('"');
                    i++; // Skip the next quote
                }
                else if (c == '"') // Start or end of quoted field
                {
                    inQuotes = !inQuotes;
                }
                else if (!inQuotes && i + separatorLength <= text.Length && text.Substring(i, separatorLength) == separator) // Field delimiter
                {
                    fields.Add(field.ToString());
                    field.Clear();
                    i += separatorLength - 1; // Skip the separator
                }
                else // Regular character
                {
                    field.Append(c);
                }
            }

            if (field.Length > 0)
            {
                fields.Add(field.ToString()); // Add the last field
            }

            return fields;
        }
    }

}
