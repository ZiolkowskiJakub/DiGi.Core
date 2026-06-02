using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a 2D array of values by reading and parsing a delimited text file.
        /// </summary>
        /// <typeparam name="T">The type of the array elements.</typeparam>
        /// <param name="path">The file path to read from.</param>
        /// <param name="separator">The string used to separate values in each line.</param>
        /// <param name="removeEmptyLines">If true, ignores empty lines in the file.</param>
        /// <param name="default">The default value to use if parsing fails.</param>
        /// <returns>A 2D array containing the parsed values, or null if the file is invalid.</returns>
        public static T?[,]? Array<T>(string? path, string separator = "\t", bool removeEmptyLines = true, T? @default = default)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
            {
                return null;
            }

            int maxCount = -1;

            List<List<T?>> values = [];
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) && removeEmptyLines)
                {
                    continue;
                }

                string[] valueStrings = line.Split([separator], System.StringSplitOptions.None);
                if (valueStrings.Length > maxCount)
                {
                    maxCount = valueStrings.Length;
                }

                List<T?> row = [];
                foreach (string valueString in valueStrings)
                {
                    if (!Query.TryConvert(valueString, out T? value))
                    {
                        value = @default;
                    }

                    row.Add(value);
                }

                values.Add(row);
            }

            T?[,] result = new T[values.Count, maxCount];
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < values[i].Count; j++)
                {
                    result[i, j] = values[i][j];
                }

                for (int j = values[i].Count; j < maxCount; j++)
                {
                    result[i, j] = @default;
                }
            }

            return result;
        }
    }
}