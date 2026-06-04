using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a reference to an object identified by a GUID.
    /// </summary>
    public class GuidReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidReference"/> class using a type name and a GUID.
        /// </summary>
        public GuidReference(string? fullTypeName, Guid guid)
            : base(fullTypeName)
        {
            this.guid = guid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidReference"/> class by copying an existing reference.
        /// </summary>
        public GuidReference(GuidReference? guidReference)
            : base(guidReference)
        {
            if (guidReference is not null)
            {
                guid = guidReference.guid;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidReference"/> class from a GUID object.
        /// </summary>
        public GuidReference(IGuidObject? guidObject)
            : base(guidObject)
        {
            if (guidObject != null)
            {
                guid = guidObject.Guid;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidReference"/> class using a type reference and a GUID.
        /// </summary>
        public GuidReference(TypeReference? typeReference, Guid guid)
            : base(typeReference)
        {
            this.guid = guid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidReference"/> class from a JSON object.
        /// </summary>
        public GuidReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the GUID value of the reference.
        /// </summary>
        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }

        /// <summary>
        /// Gets the unique identifier for the reference.
        /// </summary>
        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return Query.UniqueId(guid)?.ToString();
            }
        }

        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new GuidReference(this);
        }

        /// <summary>
        /// Returns a string representation of the current object.
        /// </summary>
        public override string? ToString()
        {
            return Convert.ToSystem_String(TypeReference, UniqueId, Constants.Reference.Format.Guid);
        }
    }
}