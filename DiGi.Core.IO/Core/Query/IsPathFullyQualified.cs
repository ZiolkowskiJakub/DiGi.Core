using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
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