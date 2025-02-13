namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static string AbsolutePath(this string directory, string relativePath)
        {
            if (string.IsNullOrWhiteSpace(directory) || string.IsNullOrWhiteSpace(relativePath))
            {
                return null;
            }

            string directory_Temp = directory.Trim();
            if (directory_Temp.EndsWith("\\"))
            {
                directory_Temp = directory_Temp.Substring(0, directory_Temp.Length - 1);
            }

            string relativePath_Temp = relativePath.Trim();
            if (relativePath_Temp.EndsWith("\\"))
            {
                relativePath_Temp = relativePath_Temp.Substring(0, relativePath_Temp.Length - 1);
            }

            return System.IO.Path.GetFullPath(System.IO.Path.Combine(directory_Temp, relativePath_Temp));
        }
    }
}