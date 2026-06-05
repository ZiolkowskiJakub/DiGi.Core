using DiGi.Core.Classes;
using System.Text;

namespace DiGi.Core.IO.FileWatcher.Classes
{
    /// <summary>
    /// Watches a configuration file for changes and provides access to its content.
    /// </summary>
    public class ConfigurationFileWatcher : FileWatcher
    {
        private ConfigurationFile? configurationFile = null;
        private Encoding? encoding = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationFileWatcher"/> class.
        /// </summary>
        /// <param name="path">The path to the configuration file to watch.</param>
        /// <param name="interval">The interval in milliseconds between checks for changes.</param>
        /// <param name="encoding">The encoding to use when reading the file.</param>
        public ConfigurationFileWatcher(string path, double interval = 5000, Encoding? encoding = null)
            : base(path, interval)
        {
            this.encoding = encoding;
            ContentChanged += ConfigurationFileWatcher_ContentChanged;
        }

        /// <summary>
        /// Gets the configuration file associated with this watcher.
        /// </summary>
        public ConfigurationFile ConfigurationFile
        {
            get
            {
                if (configurationFile is null)
                {
                    configurationFile = Create.ConfigurationFile(this, encoding) ?? new ConfigurationFile();
                }

                return configurationFile;
            }
        }

        public static implicit operator ConfigurationFile?(ConfigurationFileWatcher? configurationFileWatcher)
        {
            return configurationFileWatcher?.ConfigurationFile;
        }

        private void ConfigurationFileWatcher_ContentChanged(object sender, byte[] e)
        {
            configurationFile = null;
        }
    }
}