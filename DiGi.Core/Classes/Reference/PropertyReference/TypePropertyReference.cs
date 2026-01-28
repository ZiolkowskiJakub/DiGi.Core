using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class TypePropertyReference : PropertyReference<TypeReference>, ITypeRelatedSerializableReference
    {
        public TypePropertyReference(TypeReference reference, string propertyName)
            : base(reference, propertyName)
        {
        }

        public TypePropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public TypePropertyReference(TypePropertyReference typePropertyReference)
            : base(typePropertyReference)
        {
        }

        [JsonIgnore]
        public string? FullTypeName
        {
            get
            {
                return Reference?.FullTypeName;
            }
        }

        public override ISerializableObject Clone()
        {
            return new TypePropertyReference(this);
        }
    }
}