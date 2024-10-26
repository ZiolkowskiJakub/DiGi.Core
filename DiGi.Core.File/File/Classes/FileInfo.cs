using DiGi.Core.Classes;
using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    public class FileInfo : UniqueObject
    {
        [JsonInclude, JsonPropertyName("Created"), Description("Date created")]
        private DateTime created;

        [JsonInclude, JsonPropertyName("Modified"), Description("Date modified")]
        private DateTime modified;

        [JsonInclude, JsonPropertyName("Path"), Description("Path")]
        private string path;

        public FileInfo(string path)
            : base()
        {
            created = DateTime.Now;
            modified = DateTime.Now;
            this.path = path;
        }

        public FileInfo()
            : base()
        {
            created = DateTime.Now;
            modified = DateTime.Now;
            path = null;
        }

        public FileInfo(FileInfo fileInfo)
            : base(fileInfo)
        {
            if (fileInfo != null)
            {
                created = fileInfo.created;
                modified = fileInfo.modified;
                path = fileInfo.path;
            }
        }

        public FileInfo(JsonObject jsonObject)
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
