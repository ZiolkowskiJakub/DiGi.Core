using DiGi.Core.Classes;
using DiGi.Core.IO.Classes;

namespace DiGi.Core.IO
{
    public static partial class Create
    {
        public static ConfigurationFile? ConfigurationFile(this FileWatcher? fileWatcher, System.Text.Encoding? encoding = null)
        {
            if(fileWatcher is null)
            {
                return null;
            }

            string[]? lines = fileWatcher?.GetLines(encoding);
            if(lines is null)
            {
                return null;
            }

            ConfigurationFile result = new ();
            result.Read(lines);

            return result;
        }
    }
}