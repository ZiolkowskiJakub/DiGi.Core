using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public class WrapperItemValueCluster : ValueCluster<TypeReference, UniqueReference, WrapperItem>
    {
        public WrapperItemValueCluster()
        {

        }

        protected override TypeReference GetKey_1(WrapperItem value)
        {
            return value.UniqueReference?.TypeReference;
        }

        protected override UniqueReference GetKey_2(WrapperItem value)
        {
            return value.UniqueReference;
        }

        public JsonNode GetValue(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return GetValue<WrapperItem>(uniqueReference.TypeReference, uniqueReference)?.JsonNode;
        }

        public TJsonNode GetValue<TJsonNode>(UniqueReference uniqueReference) where TJsonNode : JsonNode
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return GetValue<WrapperItem>(uniqueReference.TypeReference, uniqueReference)?.JsonNode as TJsonNode;
        }
    }
}