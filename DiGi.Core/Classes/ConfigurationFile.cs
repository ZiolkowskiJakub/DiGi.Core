using System.Collections.Generic;
using System.Globalization;
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
            if (configurationFile != null)
            {
                if (configurationFile.dictionary != null)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in configurationFile.dictionary)
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

        public bool Add(string name, bool? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            dictionary[name.Trim()] = value.ToString();
            return true;
        }

        public bool Add(string name, string? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            dictionary[name.Trim()] = string.Format("\"{0}\"", value);
            return true;
        }

        public bool Add(string name, double? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            string text = value.Value.ToString(CultureInfo.InvariantCulture);
            if (!text.Contains("."))
            {
                text += ".0";
            }

            dictionary[name.Trim()] = text;
            return true;
        }

        public bool Add(string name, int? value)
        {
            if (name == null)
            {
                return false;
            }

            if (value is null)
            {
                return Remove(name);
            }

            dictionary[name.Trim()] = value.ToString();
            return true;
        }

        public bool Append(ConfigurationFile? configurationFile)
        {
            if (configurationFile?.dictionary is not Dictionary<string, string> dictionary)
            {
                return false;
            }

            bool result = false;

            foreach (KeyValuePair<string, string> keyValuePair in dictionary)
            {
                this.dictionary[keyValuePair.Key] = keyValuePair.Value;
                result = true;
            }

            return result;
        }

        public bool Contains(string? name, bool caseSensitive = false)
        {
            if (name is null)
            {
                return false;
            }

            string name_Temp = name.Trim();

            bool result = dictionary.ContainsKey(name_Temp);
            if(!caseSensitive)
            {
                return dictionary.TryGetFirstKey(name_Temp, out _, x => x?.ToUpper());
            }

            return result;
        }

        public T? GetValue<T>(string name, bool caseSensitive = false)
        {
            if (!TryGetValue(name, out T? result, caseSensitive))
            {
                return default;
            }

            return result;
        }

        public T? GetValue<T>(string name, T? defaultValue, bool caseSensitive = false)
        {
            if (!TryGetValue(name, out T? result, caseSensitive))
            {
                return defaultValue;
            }

            return defaultValue;
        }

        public object? GetValue(string name, bool caseSensitive = false)
        {
            if(!TryGetValue(name, out object? result, caseSensitive))
            {
                return null;
            }

            return result;
        }

        public bool Read(string path)
        {
            if (path == null || !System.IO.File.Exists(path))
            {
                return false;
            }

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines == null || lines.Length == 0)
            {
                return false;
            }

            return Read(lines);
        }

        public bool Read(string[]? lines)
        {
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

                if (text.StartsWith("\"") && text.EndsWith("\""))
                {
                    text = text.Substring(1, text.Length - 2);
                }

                Add(name, text);
                result = true;
            }

            return result;
        }

        public bool Remove(string name)
        {
            if (name == null)
            {
                return false;
            }

            string name_Temp = name.Trim();

            return dictionary.Remove(name_Temp);
        }

        public bool TryGetValue<T>(string name, out T? value, bool caseSensitive = false)
        {
            value = default;

            if (name is null)
            {
                return false;
            }

            string name_Temp = name.Trim();

            if (!dictionary.TryGetValue(name_Temp, out string text))
            {
                if (caseSensitive)
                {
                    return false;
                }

                if (!dictionary.TryGetFirstKey(name_Temp, out string? key, x => x?.ToUpper()) || string.IsNullOrWhiteSpace(key))
                {
                    return false;
                }

                if (!dictionary.TryGetValue(name_Temp, out text))
                {
                    return false;
                }
            }

            if (text.StartsWith("\"") && text.EndsWith("\""))
            {
                text = text.Substring(1, text.Length - 2);
            }

            return Query.TryConvert(text, out value);
        }

        public bool Write(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if (string.IsNullOrEmpty(directory) || !System.IO.Directory.Exists(directory))
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