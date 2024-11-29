using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    public class FileMetadata : UniqueObject, IMetadata
    {
        [JsonInclude, JsonPropertyName("Created"), Description("Date created")]
        private DateTime created;

        [JsonInclude, JsonPropertyName("Modified"), Description("Date modified")]
        private DateTime modified;

        [JsonInclude, JsonPropertyName("Path"), Description("Path")]
        private string path;

        [JsonInclude, JsonPropertyName("Type"), Description("Type")]
        private string type = null;

        public FileMetadata(Type type, string path)
            : base()
        {
            this.type = Core.Query.FullTypeName(type);
            created = DateTime.Now;
            modified = DateTime.Now;
            this.path = path;
        }

        public FileMetadata(Type type)
            : base()
        {
            this.type = Core.Query.FullTypeName(type);
            created = DateTime.Now;
            modified = DateTime.Now;
            path = null;
        }

        public FileMetadata(FileMetadata fileMetadata)
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

        public FileMetadata(JsonObject jsonObject)
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

        public string Type
        {
            get
            {
                return type;
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

        public string Path
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
    }
}
