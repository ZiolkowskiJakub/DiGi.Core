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
    /// <typeparam name="TSerializableObject">The type of object that can be serialized within the archive.</typeparam>
    public class Archive<TSerializableObject> : SerializableObject, IArchive where TSerializableObject : ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Bytes")]
        private readonly byte[]? bytes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive{TSerializableObject}"/> class using the specified byte array.
        /// </summary>
        /// <param name="bytes">The byte array to use for initialization.</param>
        public Archive(byte[] bytes)
            : base()
        {
            this.bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive{TSerializableObject}"/> class by copying an existing generic archive.
        /// </summary>
        /// <param name="archive">The generic archive to copy from.</param>
        public Archive(Archive<TSerializableObject> archive)
            : base(archive)
        {
            if (archive is not null)
            {
                bytes = archive.bytes is not null ? [.. archive.bytes] : null;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive{TSerializableObject}"/> class using the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to use for initialization.</param>
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