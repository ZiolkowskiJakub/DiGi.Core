using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class TypePropertyReference : PropertyReference<TypeReference>, ITypeRelatedSerializableReference
    {
        [JsonIgnore]
        public string FullTypeName
        {
            get
            {
                return Reference?.FullTypeName;
            }
        }

        public TypePropertyReference(string propertyName, TypeReference reference)
            : base(propertyName, reference)
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

        public override ISerializableObject Clone()
        {
            return new TypePropertyReference(this);
        }
    }
}