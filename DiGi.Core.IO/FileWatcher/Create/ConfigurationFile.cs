using DiGi.Core.Classes;

namespace DiGi.Core.IO.FileWatcher
{
    public static partial class Create
    {
        public static ConfigurationFile? ConfigurationFile(this Classes.FileWatcher? fileWatcher, System.Text.Encoding? encoding = null)
        {
            if (fileWatcher is null)
            {
                return null;
            }

            string[]? lines = fileWatcher?.GetLines(encoding);
            if (lines is null)
            {
                return null;
            }

            ConfigurationFile result = new();
            result.Read(lines);

            return result;
        }
    }
}