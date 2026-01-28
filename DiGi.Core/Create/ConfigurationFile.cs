using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static ConfigurationFile? ConfigurationFile(string? path)
        {
            if (path == null || !System.IO.File.Exists(path))
            {
                return null;
            }

            ConfigurationFile result = new();
            result.Read(path);

            return result;
        }
    }
}