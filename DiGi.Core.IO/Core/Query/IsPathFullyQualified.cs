using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static bool IsPathFullyQualified(string path)
        {
            var root = Path.GetPathRoot(path);
            return root.StartsWith(@"\\") || root.EndsWith(@"\") && root != @"\";
        }
    }
}