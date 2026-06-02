using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a ConfigurationFile object by loading it from the specified path.
        /// </summary>
        /// <param name="path">The file path to the configuration file.</param>
        /// <returns>A ConfigurationFile object loaded with data, or null if the file does not exist.</returns>
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