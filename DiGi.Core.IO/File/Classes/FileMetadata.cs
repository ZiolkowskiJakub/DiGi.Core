using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
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

        public FileMetadata(Type? type, string? path)
            : base()
        {
            this.type = Core.Query.FullTypeName(type);
            created = DateTime.Now;
            modified = DateTime.Now;
            this.path = path;
        }

        public FileMetadata(Type? type)
            : base()
        {
            this.type = Core.Query.FullTypeName(type);
            created = DateTime.Now;
            modified = DateTime.Now;
            path = null;
        }

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

        public FileMetadata(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public DateTime Created
        {
            get
            {
                return created;
            }
        }

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

        public string? Type
        {
            get
            {
                return type;
            }
        }
    }
}