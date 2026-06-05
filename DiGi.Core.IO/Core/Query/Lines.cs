using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Reads a specified number of lines from a file.
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        /// <param name="count">The number of lines to read from the file.</param>
        /// <returns>A list of strings containing the lines read, or null if the operation fails.</returns>
        public static List<string>? Lines(string? path, int count)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path) || count < 0)
            {
                return null;
            }

            List<string> result = [];
            if (count == 0)
            {
                return result;
            }

            int count_Temp = 0;
            using (StreamReader reader = new(path))
            {
                while (count_Temp < count && !reader.EndOfStream)
                {
                    result.Add(reader.ReadLine());
                    count_Temp++;
                }
            }

            return result;
        }
    }
}