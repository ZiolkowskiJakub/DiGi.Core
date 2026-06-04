using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Classes
{
    /// <summary>
    /// Represents an archive container for storing serialized data.
    /// </summary>
    public class Archive<TSerializableObject> : SerializableObject, IArchive where TSerializableObject : ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Bytes")]
        private readonly byte[]? bytes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive"/> class using the specified byte array.
        /// </summary>
        public Archive(byte[] bytes)
            : base()
        {
            this.bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive"/> class by copying an existing generic archive.
        /// </summary>
        public Archive(Archive<TSerializableObject> archive)
            : base(archive)
        {
            if (archive is not null)
            {
                bytes = archive.bytes is not null ? [.. archive.bytes] : null;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive"/> class using the specified JSON object.
        /// </summary>
        public Archive(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the raw bytes contained within the archive.
        /// </summary>
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