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

            if (path_Temp.StartsWith(relativeTo))
            {
                return path_Temp.Substring(relativeTo_Temp.Length + 1);
            }

            return path;

            //Uri uri_RelativeTo = new Uri(relativeTo);
            //Uri uri = new Uri(path);

            //Uri uri_Relative = uri_RelativeTo.MakeRelativeUri(uri);

            //string result = uri_Relative.ToString();
            //result = Uri.UnescapeDataString(result);
            //result = result.Replace("/", "\\");

            //if(path != result)
            //{
            //    result = string.Format("..\\{0}", result);
            //}

            //return result;
        }
    }
}