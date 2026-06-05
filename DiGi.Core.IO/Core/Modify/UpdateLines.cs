using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Modify
    {
        /// <summary>
        /// Updates multiple lines in the file at the given path based on the provided dictionary of indices and content.
        /// </summary>
        /// <param name="path">The path to the file to be updated.</param>
        /// <param name="lineDictionary">A dictionary where keys are line indices and values are the new content for those lines.</param>
        /// <returns>A <see cref="HashSet{T}"/> containing the indices of the lines that were successfully updated, or null if an error occurred.</returns>
        public static HashSet<int>? UpdateLines(string? path, Dictionary<int, string?>? lineDictionary)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path) || lineDictionary == null)
            {
                return null;
            }

            string path_Temp = Path.GetTempFileName();

            HashSet<int>? result = null;

            try
            {
                using StreamReader streamReader = new(path);
                using StreamWriter streamWriter = new(path_Temp);
                result = [];

                int index = 0;

                string? line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (lineDictionary.TryGetValue(index, out string? line_Temp))
                    {
                        line = line_Temp;
                        result.Add(index);
                    }

                    streamWriter.WriteLine(line);
                    index++;
                }
            }
            catch
            {
                System.IO.File.Delete(path_Temp);
            }

            if (System.IO.File.Exists(path_Temp))
            {
                System.IO.File.Delete(path);
                System.IO.File.Move(path_Temp, path);
            }

            return result;
        }
    }
}