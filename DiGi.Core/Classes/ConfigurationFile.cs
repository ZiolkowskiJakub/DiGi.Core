using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class ConfigurationFile : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Dictionary")]
        private readonly Dictionary<string, string> dictionary = [];

        public ConfigurationFile(ConfigurationFile? configurationFile)
            : base()
        {
            if(configurationFile != null)
            {
                if(configurationFile.dictionary != null)
                {
                    foreach(KeyValuePair<string, string> keyValuePair in configurationFile.dictionary)
                    {
                        dictionary[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }
        }

        public ConfigurationFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public ConfigurationFile()
        {

        }

        [JsonIgnore]
        public List<string> Names
        {
            get
            {
                return [.. dictionary.Keys];
            }
        }

        public bool Add(string name, bool value)
        {
            if (name == null)
            {
                return false;
            }

            dictionary[name] = value.ToString();
            return true;
        }

        public bool Add(string name, string value)
        {
            if (name == null || value == null)
            {
                return false;
            }

            dictionary[name] = string.Format("\"{0}\"", value);
            return true;
        }

        public bool Add(string name, double value)
        {
            if (name == null)
            {
                return false;
            }

            dictionary[name] = value.ToString();
            return true;
        }

        public bool Add(string name, int value)
        {
            if (name == null)
            {
                return false;
            }

            dictionary[name] = value.ToString();
            return true;
        }

        public bool Contains(string? name)
        {
            if(name is null)
            {
                return false;
            }

            return dictionary.ContainsKey(name);
        }
        
        public T? GetValue<T>(string name)
        {
            if (!TryGetValue(name, out T? result))
            {
                return default;
            }

            return result;
        }

        public bool Read(string path)
        {
            if (path == null || System.IO.File.Exists(path))
            {
                return false;
            }

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
            {
                return false;
            }

            bool result = false;

            foreach (string line in lines)
            {
                int index = line.IndexOf("=");
                if (index == -1)
                {
                    continue;
                }

                string name = line.Substring(0, index);
                string text = line.Substring(index + 1);

                Add(name, text);
                result = true;
            }

            return result;
        }

        public bool TryGetValue<T>(string name, out T? value)
        {
            value = default;

            if (name is null)
            {
                return false;
            }

            if(!dictionary.TryGetValue(name, out string text))
            {
                return false;
            }

            if(text.StartsWith("\"") && text.EndsWith("\""))
            {
                text = text.Substring(1, text.Length - 1);
            }

            return Query.TryConvert(text, out value);
        }
        
        public bool Write(string path)
        {
            if(string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if(string.IsNullOrEmpty(directory) || !System.IO.Directory.Exists(directory))
            {
                return false;
            }

            List<string> lines = [];
            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                lines.Add(string.Format("{0}={1}", keyValuePair.Key, keyValuePair.Value));
            }

            System.IO.File.WriteAllLines(path, lines);
            return true;
        }
    }
}
