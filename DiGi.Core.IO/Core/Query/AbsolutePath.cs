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

            string relativePath_Temp = relativePath;
            if (relativePath_Temp.StartsWith("..\\"))
            {
                relativePath_Temp = relativePath_Temp.Substring(3);
            }

            return System.IO.Path.Combine(directory, relativePath_Temp);
        }
    }
}