using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperTypeReference : WrapperReference<TypeReference>
    {
        public WrapperTypeReference(TypeReference typeReference)
            :base(typeReference)
        {
            
        }

        public WrapperTypeReference(WrapperTypeReference wrapperTypeReference)
            :base(wrapperTypeReference)
        {

        }

        public WrapperTypeReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

}
