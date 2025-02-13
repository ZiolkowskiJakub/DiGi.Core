using System;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static string RelativePath(string relativeTo, string path)
        {
            if (string.IsNullOrWhiteSpace(relativeTo) || string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string relativeTo_Temp = relativeTo.Trim();
            if (relativeTo_Temp.EndsWith("\\"))
            {
                relativeTo_Temp = relativeTo_Temp.Substring(0, relativeTo_Temp.Length - 1);
            }

            string path_Temp = path.Trim();
            if (path_Temp.EndsWith("\\"))
            {
                path_Temp = path_Temp.Substring(0, path_Temp.Length - 1);
            }

            if (relativeTo_Temp.Equals(path_Temp))
            {
                return ".";
            }

            Uri uri_RelativeTo = new Uri(relativeTo.EndsWith("\\") ? relativeTo : relativeTo + "\\");
            Uri uri = new Uri(path_Temp);

            return Uri.UnescapeDataString(uri_RelativeTo.MakeRelativeUri(uri).ToString().Replace('/', '\\'));

            //if (path_Temp.StartsWith(relativeTo))
            //{
            //    return path_Temp.Substring(relativeTo_Temp.Length + 1);
            //}

            //return path;
        }
    }
}