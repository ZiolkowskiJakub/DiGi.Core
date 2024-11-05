using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperTypeReference : WrapperReference<TypeReference>
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private string fullTypeName;

        public WrapperTypeReference(TypeReference typeReference)
            : base()
        {
            if(typeReference != null)
            {
                fullTypeName = typeReference.FullTypeName;
            }
        }

        public WrapperTypeReference(WrapperTypeReference wrapperTypeReference)
            :base(wrapperTypeReference)
        {
            if(wrapperTypeReference != null)
            {
                fullTypeName = wrapperTypeReference.fullTypeName;
            }
        }

        public WrapperTypeReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public override TypeReference Reference
        {
            get
            {
                return new TypeReference(fullTypeName);
            }
        }

        public override ISerializableObject Clone()
        {
            return new WrapperTypeReference(this);
        }
    }

}
