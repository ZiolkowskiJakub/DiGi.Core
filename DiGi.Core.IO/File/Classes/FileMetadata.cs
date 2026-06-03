using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    /// <summary>
    /// Stores metadata for a file, including creation and modification dates, path, and type.
    /// </summary>
    public class FileMetadata : GuidObject, IMetadata
    {
        [JsonInclude, JsonPropertyName("Created"), Description("Date created")]
        private readonly DateTime created;

        [JsonInclude, JsonPropertyName("Type"), Description("Type")]
        private readonly string? type = null;

        [JsonInclude, JsonPropertyName("Modified"), Description("Date modified")]
        private DateTime modified;

        [JsonInclude, JsonPropertyName("Path"), Description("Path")]
        private string? path;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata"/> class with type and path.
        /// </summary>
        public FileMetadata(Type? type, string? path)
            : base()
        {
            this.type = DiGi.Core.Query.FullTypeName(type);
            created = DateTime.Now;
            modified = DateTime.Now;
            this.path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata"/> class with type.
        /// </summary>
        public FileMetadata(Type? type)
            : base()
        {
            this.type = DiGi.Core.Query.FullTypeName(type);
            created = DateTime.Now;
            modified = DateTime.Now;
            path = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata"/> class by cloning another metadata object.
        /// </summary>
        public FileMetadata(FileMetadata? fileMetadata)
            : base(fileMetadata)
        {
            if (fileMetadata != null)
            {
                type = fileMetadata.type;
                created = fileMetadata.created;
                modified = fileMetadata.modified;
                path = fileMetadata.path;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMetadata"/> class from a JSON object.
        /// </summary>
        public FileMetadata(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the date and time when the file was created.
        /// </summary>
        public DateTime Created
        {
            get
            {
                return created;
            }
        }

        /// <summary>
        /// Gets or sets the date and time when the file was last modified.
        /// </summary>
        public DateTime Modified
        {
            get
            {
                return modified;
            }

            set
            {
                modified = value;
            }
        }

        /// <summary>
        /// Gets or sets the path of the file.
        /// </summary>
        public string? Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }

        /// <summary>
        /// Gets the full type name of the file.
        /// </summary>
        public string? Type
        {
            get
            {
                return type;
            }
        }
    }
}