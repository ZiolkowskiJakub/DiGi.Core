using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Classes
{
    /// <summary>
    /// Provides a filter for selecting files based on a name and a set of extensions.
    /// </summary>
    public sealed class FileFilter : SerializableObject, IIOObject
    {
        [JsonInclude, JsonPropertyName("Extensions")]
        private readonly List<string>? extensions;

        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter"/> class with a specified name and extensions.
        /// </summary>
        public FileFilter(string? name, IEnumerable<string>? extensions)
            : base()
        {
            this.name = name;
            this.extensions = extensions == null ? null : [.. extensions];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter"/> class by copying an existing filter.
        /// </summary>
        public FileFilter(FileFilter? fileFilter)
            : base(fileFilter)
        {
            if (fileFilter != null)
            {
                name = fileFilter.name;
                extensions = fileFilter.extensions == null ? null : [.. fileFilter.extensions];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileFilter"/> class using the specified JSON object.
        /// </summary>
        public FileFilter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the list of file extensions associated with this filter.
        /// </summary>
        public List<string>? Extensions
        {
            get
            {
                return extensions == null ? null : [.. extensions];
            }
        }

        /// <summary>
        /// Gets or sets the descriptive name of the file filter.
        /// </summary>
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Creates a copy of the current object.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new FileFilter(this);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        public override bool Equals(object? obj)
        {
            return ToString().Equals((obj as FileFilter)?.ToString());
        }

        /// <summary>
        /// Returns the hash code for the current object.
        /// </summary>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString()
        {
            List<string> values = [];
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

            return string.Format("{0} ({1})|{1}", name ?? string.Empty, string.Join(";", values));
        }
    }
}