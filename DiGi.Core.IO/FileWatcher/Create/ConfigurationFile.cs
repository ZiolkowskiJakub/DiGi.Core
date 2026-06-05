using DiGi.Core.Classes;

namespace DiGi.Core.IO.FileWatcher
{
    public static partial class Create
    {
        /// <summary>
        /// Converts a <see cref="Classes.FileWatcher"/> to a <see cref="ConfigurationFile"/>.
        /// </summary>
        /// <param name="fileWatcher">The file watcher instance to convert.</param>
        /// <param name="encoding">The encoding to use for the conversion, if any.</param>
        /// <returns>A <see cref="ConfigurationFile"/> object, or null if the input is null.</returns>
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