using System.Collections.Generic;
using System.Text;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Query
    {
        public static string Text(this IEnumerable<string> values, char separator)
        {
            if (values == null)
            {
                return null;
            }

            StringBuilder stringBuilder = new StringBuilder();
            bool firstColumn = true;
            foreach (string value in values)
            {
                // Add separator if this isn't the first value
                if (!firstColumn)
                {
                    stringBuilder.Append(separator);
                }

                // Implement special handling for values that contain comma or quote Enclose in
                // quotes and double up any double quotes
                if(value == null)
                {
                    stringBuilder.Append(string.Empty);
                }
                else if (value.IndexOfAny(new char[] { '"', separator, '\n' }) != -1)
                {
                    stringBuilder.AppendFormat("\"{0}\"", value.Replace("\"", "\"\""));
                }
                else
                {
                    stringBuilder.Append(value);
                }

                firstColumn = false;
            }

            return stringBuilder.ToString();
        }
    }
}