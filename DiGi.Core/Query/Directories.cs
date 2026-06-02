using System.Collections.Generic;
using System.IO;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of all parent directories up to the root for a given directory path.
        /// </summary>
        /// <param name="directory">The starting directory path.</param>
        /// <returns>A list of directory paths, or null if the path is invalid.</returns>
        public static List<string>? Directories(string? directory)
        {
            if (string.IsNullOrWhiteSpace(directory))
            {
                return null;
            }

            List<string> result = [];

            DirectoryInfo directoryInfo = new(directory);
            result.Add(directoryInfo.ToString());

            while (directoryInfo != null)
            {
                directoryInfo = directoryInfo.Parent;
                if (directoryInfo != null)
                {
                    result.Add(directoryInfo.ToString());
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of all parent directories up to the root for a given DirectoryInfo.
        /// </summary>
        /// <param name="directoryInfo">The DirectoryInfo object.</param>
        /// <returns>A list of directory paths, or null if the DirectoryInfo is null.</returns>
        public static List<string>? Directories(DirectoryInfo? directoryInfo)
        {
            if (directoryInfo == null)
            {
                return null;
            }

            return Directories(directoryInfo.FullName);
        }
    }
}