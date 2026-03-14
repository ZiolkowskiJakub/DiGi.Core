using DiGi.Core.Classes;
using System.Text;

namespace DiGi.Core.IO.FileWatcher.Classes
{
    public class ConfigurationFileWatcher : FileWatcher
    {
        private ConfigurationFile? configurationFile = null;
        private Encoding? encoding = null;
        
        public ConfigurationFileWatcher(string path, double interval = 5000, Encoding? encoding = null)
            : base(path, interval)
        {
            this.encoding = encoding;
            ContentChanged += ConfigurationFileWatcher_ContentChanged;
        }

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
