using DiGi.Core.IO.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Joins multiple file filters into a pipe-separated string.
        /// </summary>
        /// <param name="fileFilters">The array of file filters to be joined.</param>
        /// <returns>A pipe-separated string containing the combined filters, or null if no filters are provided.</returns>
        public static string? Filter(params FileFilter[]? fileFilters)
        {
            if (fileFilters == null)
            {
                return null;
            }

            List<string> values = [];
            foreach (FileFilter fileFilter in fileFilters)
            {
                string? value = fileFilter?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                values.Add(value!);
            }

            return string.Join("|", values);
        }
    }
}