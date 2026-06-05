using System.Collections.Generic;

namespace DiGi.Core.IO
{
    public static partial class Modify
    {
        /// <summary>
        /// Updates a specific line in the file at the given path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <param name="index">The zero-based index of the line to update.</param>
        /// <param name="line">The new content for the line.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public static bool UpdateLine(string? path, int index, string? line)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path) || index < 0)
            {
                return false;
            }

            HashSet<int>? indexes = UpdateLines(path, new Dictionary<int, string?> { { index, line } });

            return indexes != null && indexes.Contains(index);
        }
    }
}