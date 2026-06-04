using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to an object identified by a unique string ID.</summary>
    public class UniqueIdReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("UniqueId")]
        private readonly string uniqueId = Constants.UniqueId.Null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class using a type reference and a unique identifier.
        /// </summary>
        public UniqueIdReference(TypeReference? typeReference, string? uniqueId)
            : base(typeReference)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class using a type name and a unique identifier.
        /// </summary>
        public UniqueIdReference(string? fullTypeName, string? uniqueId)
            : base(fullTypeName)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class from a unique ID object.
        /// </summary>
        public UniqueIdReference(IUniqueIdObject? uniqueIdObject)
            : base(uniqueIdObject)
        {
            if (uniqueIdObject != null)
            {
                if (uniqueIdObject.UniqueId != null)
                {
                    uniqueId = uniqueIdObject.UniqueId;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class by copying an existing reference.
        /// </summary>
        public UniqueIdReference(UniqueIdReference? uniqueIdReference)
            : base(uniqueIdReference)
        {
            if (uniqueIdReference is not null)
            {
                uniqueId = uniqueIdReference.uniqueId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class from a JSON object.
        /// </summary>
        public UniqueIdReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the unique identifier for the reference.
        /// </summary>
        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return uniqueId;
            }
        }

        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new UniqueIdReference(this);
        }

        /// <summary>
        /// Returns a string representation of the current object.
        /// </summary>
        public override string? ToString()
        {
            return Convert.ToSystem_String(TypeReference, uniqueId, Constants.Reference.Format.UniqueId);
        }
    }
}