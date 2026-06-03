using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Checks if a path is fully qualified (absolute).
        /// </summary>
        public static bool IsPathFullyQualified(string? path)
        {
            string root = Path.GetPathRoot(path);
            if (string.IsNullOrWhiteSpace(root))
            {
                return false;
            }

            return root.StartsWith(@"\\") || root.EndsWith(@"\") && root != @"\";
        }
    }
}