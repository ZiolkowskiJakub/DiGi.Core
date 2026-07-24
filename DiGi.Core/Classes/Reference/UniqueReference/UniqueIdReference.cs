using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to an object identified by a unique string ID.</summary>
    /// <example>
    /// Renders and parses (via <see cref="Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// nested type reference, then the unique identifier:
    /// <code>UniqueId::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::BLD-001</code>
    /// </example>
    public class UniqueIdReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("UniqueId")]
        private readonly string uniqueId = Constants.UniqueId.Null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class using a type reference and a unique identifier.
        /// </summary>
        /// <param name="typeReference">The type reference.</param>
        /// <param name="uniqueId">The unique identifier.</param>
        public UniqueIdReference(TypeReference? typeReference, string? uniqueId)
            : base(typeReference)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdReference"/> class from a unique ID object.
        /// </summary>
        /// <param name="uniqueIdObject">The unique ID object to initialize from.</param>
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
        /// <param name="uniqueIdReference">The existing reference to copy.</param>
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
        /// <param name="jsonObject">The JSON object to initialize from.</param>
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
        /// <returns>A deep copy of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new UniqueIdReference(this);
        }
    }
}