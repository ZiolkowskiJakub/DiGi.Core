using System;
using System.Text.RegularExpressions;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string RelativePath(this string relativeTo, string path)
        {
            if(string.IsNullOrWhiteSpace(relativeTo) || string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            Uri uri_RelativeTo = new Uri(relativeTo);
            Uri uri = new Uri(path);

            Uri uri_Relative = uri_RelativeTo.MakeRelativeUri(uri);
            
            string result = uri_Relative.ToString();
            result = Uri.UnescapeDataString(result);
            result = result.Replace("/", "\\");

            if(path != result)
            {
                result = string.Format("..\\{0}", result);
            }

            return result;
        }
    }
}