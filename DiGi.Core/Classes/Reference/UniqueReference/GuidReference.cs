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
        /// Initializes a new instance of the <see cref="GuidReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="guidReference">The existing reference to copy.</param>
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
        /// <param name="guidObject">The GUID object to initialize from.</param>
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
        /// <param name="typeReference">The type reference to use.</param>
        /// <param name="guid">The GUID value to assign.</param>
        public GuidReference(TypeReference? typeReference, Guid guid)
            : base(typeReference)
        {
            this.guid = guid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
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
        /// <returns>A new <see cref="ISerializableObject"/> that is a copy of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new GuidReference(this);
        }

        /// <summary>
        /// Returns a string representation of the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string? ToString()
        {
            return Convert.ToSystem_String(TypeReference, UniqueId, Constants.Reference.Format.Guid);
        }
    }
}