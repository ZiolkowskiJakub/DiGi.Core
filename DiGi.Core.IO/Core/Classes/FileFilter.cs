using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Classes
{
    public sealed class FileFilter : SerializableObject, IIOObject
    {
        [JsonInclude, JsonPropertyName("Extensions")]
        private List<string> extensions;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        public FileFilter(string name, IEnumerable<string> extensions)
            : base()
        {
            this.name = name;
            this.extensions = extensions == null ? null : new List<string>(extensions);
        }

        public FileFilter(FileFilter fileFilter)
            : base(fileFilter)
        {
            if (fileFilter != null)
            {
                name = fileFilter.name;
                extensions = fileFilter.extensions == null ? null : new List<string>(fileFilter.extensions);
            }
        }

        public FileFilter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public List<string> Extensions
        {
            get
            {
                return extensions == null ? null : new List<string>(extensions);
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public override ISerializableObject Clone()
        {
            return new FileFilter(this);
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals((obj as FileFilter)?.ToString());
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        
        public override string ToString()
        {
            List<string> values = new List<string>();
            if (extensions != null)
            {
                foreach (string extension in extensions)
                {
                    if (string.IsNullOrWhiteSpace(extension))
                    {
                        continue;
                    }

                    values.Add(string.Format("*.{0}", extension));
                }
            }

            return string.Format("{0} ({1})|{1}", name == null ? string.Empty : name, string.Join(";", values));
        }
    }
}