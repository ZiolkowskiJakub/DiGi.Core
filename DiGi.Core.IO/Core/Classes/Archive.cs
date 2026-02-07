using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Classes
{
    public class Archive<TSerializableObject> : SerializableObject, IArchive where TSerializableObject : ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Bytes")]
        private readonly byte[]? bytes;

        public Archive(byte[] bytes)
            : base()
        {
            this.bytes = bytes;
        }

        public Archive(Archive<TSerializableObject> archive)
            : base(archive)
        {
            if (archive is not null)
            {
                bytes = archive.bytes is not null ? [.. archive.bytes] : null;
            }
        }

        public Archive(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public byte[]? Bytes
        {
            get
            {
                if (bytes is null)
                {
                    return null;
                }

                return (byte[])bytes.Clone();
            }
        }
    }
}