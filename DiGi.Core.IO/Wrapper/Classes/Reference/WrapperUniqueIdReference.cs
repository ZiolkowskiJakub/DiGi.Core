using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperUniqueIdReference : WrapperUniqueReference<UniqueIdReference>
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private string fullTypeName;

        [JsonInclude, JsonPropertyName("UniqueId")]
        private string uniqueId;

        public WrapperUniqueIdReference(UniqueIdReference uniqueIdReference)
            : base()
        {
            if (uniqueIdReference != null)
            {
                fullTypeName = uniqueIdReference.TypeReference?.FullTypeName;
                uniqueId = uniqueIdReference.UniqueId;
            }
        }

        public WrapperUniqueIdReference(WrapperUniqueIdReference wrapperUniqueIdReference)
            : base(wrapperUniqueIdReference)
        {
            if (wrapperUniqueIdReference != null)
            {
                fullTypeName = wrapperUniqueIdReference.fullTypeName;
                uniqueId = wrapperUniqueIdReference.uniqueId;
            }
        }

        public WrapperUniqueIdReference(string fullTypeName, string uniqueId)
            : base()
        {
            this.fullTypeName = fullTypeName;
            this.uniqueId = uniqueId;
        }

        public WrapperUniqueIdReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public override UniqueIdReference Reference
        {
            get
            {
                return new UniqueIdReference(fullTypeName, uniqueId);
            }
        }

        public override ISerializableObject Clone()
        {
            return new WrapperUniqueIdReference(this);
        }
    }
}
