using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class UniqueReference : SerializableReference, IInstanceRelatedReference
    {
        [JsonInclude, JsonPropertyName("TypeReference")]
        private TypeReference typeReference;

        public UniqueReference(UniqueReference uniqueReference)
            : base(uniqueReference)
        {
            if (uniqueReference != null)
            {
                typeReference = uniqueReference.typeReference;
            }
        }

        public UniqueReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UniqueReference(TypeReference typeReference)
            : base()
        {
            this.typeReference = typeReference;
        }

        public UniqueReference(string fullTypeName)
            : base()
        {
            typeReference = new TypeReference(fullTypeName);
        }

        public UniqueReference(IObject @object)
            : base()
        {
            typeReference = @object == null ? null : new TypeReference(@object);
        }

        [JsonIgnore]
        public TypeReference TypeReference
        {
            get
            {
                return typeReference;
            }
        }

        [JsonIgnore]
        public abstract string UniqueId { get; }
    }
}
