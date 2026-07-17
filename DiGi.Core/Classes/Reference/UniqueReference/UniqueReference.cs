using DiGi.Core.Interfaces;
using System.Collections.Generic;
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
        /// <param name="uniqueReference">The unique reference to use.</param>
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
        /// <param name="jsonObject">The JSON object to create a reference from.</param>
        public UniqueReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class using a <see cref="TypeReference"/>.
        /// </summary>
        /// <param name="typeReference">The type reference to use.</param>
        public UniqueReference(TypeReference? typeReference)
            : base()
        {
            this.typeReference = typeReference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueReference"/> class for the specified object.
        /// </summary>
        /// <param name="object">The object to create a reference for.</param>
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

        /// <summary>
        /// Gets the segments of this reference's string form: the nested type reference, then the unique identifier.
        /// <para>Shared by every unique reference, so <see cref="GuidReference"/> and <see cref="UniqueIdReference"/>
        /// differ only by their discriminator - which is what tells them apart on the way back.</para>
        /// </summary>
        [JsonIgnore]
        protected override IEnumerable<string?> Segments
        {
            get
            {
                return [Query.Segment(typeReference), Query.Segment(UniqueId)];
            }
        }
    }
}