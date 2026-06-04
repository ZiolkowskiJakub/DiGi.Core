using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for references to objects with a unique identifier.</summary>
    public abstract class UniqueReference : SerializableReference, IUniqueReference
    {
        [JsonInclude, JsonPropertyName("TypeReference")]
        private readonly TypeReference? typeReference;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class using another <see cref="UniqueReference"/>.
        /// </summary>
        public UniqueReference(UniqueReference? uniqueReference)
            : base(uniqueReference)
        {
            if (uniqueReference is not null)
            {
                typeReference = uniqueReference.typeReference;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class from a <see cref="JsonObject"/>.
        /// </summary>
        public UniqueReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class using a <see cref="TypeReference"/>.
        /// </summary>
        public UniqueReference(TypeReference? typeReference)
            : base()
        {
            this.typeReference = typeReference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class using the specified full type name.
        /// </summary>
        public UniqueReference(string? fullTypeName)
            : base()
        {
            typeReference = new TypeReference(fullTypeName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class for the specified object.
        /// </summary>
        public UniqueReference(IObject? @object)
            : base()
        {
            typeReference = @object == null ? null : new TypeReference(@object);
        }

        /// <summary>
        /// Gets or sets the associated type reference.
        /// </summary>
        [JsonIgnore]
        public TypeReference? TypeReference
        {
            get
            {
                return typeReference;
            }
        }

        /// <summary>
        /// Gets the unique identifier of the reference.
        /// </summary>
        [JsonIgnore]
        public abstract string? UniqueId { get; }
    }
}