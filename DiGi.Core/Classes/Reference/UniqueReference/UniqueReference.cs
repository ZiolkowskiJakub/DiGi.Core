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

        public UniqueReference(UniqueReference? uniqueReference)
            : base(uniqueReference)
        {
            if (uniqueReference is not null)
            {
                typeReference = uniqueReference.typeReference;
            }
        }

        public UniqueReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UniqueReference(TypeReference? typeReference)
            : base()
        {
            this.typeReference = typeReference;
        }

        public UniqueReference(string? fullTypeName)
            : base()
        {
            typeReference = new TypeReference(fullTypeName);
        }

        public UniqueReference(IObject? @object)
            : base()
        {
            typeReference = @object == null ? null : new TypeReference(@object);
        }

        [JsonIgnore]
        public TypeReference? TypeReference
        {
            get
            {
                return typeReference;
            }
        }

        [JsonIgnore]
        public abstract string? UniqueId { get; }
    }
}