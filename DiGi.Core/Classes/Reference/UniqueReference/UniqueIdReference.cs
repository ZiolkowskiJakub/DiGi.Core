using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class UniqueIdReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("UniqueId")]
        private string uniqueId = Constans.UniqueId.Null;

        public UniqueIdReference(TypeReference typeReference, string uniqueId)
            :base(typeReference)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        public UniqueIdReference(string fullTypeName, string uniqueId)
            : base(fullTypeName)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        public UniqueIdReference(IUniqueIdObject uniqueIdObject)
            : base(uniqueIdObject)
        {
            if (uniqueIdObject != null)
            {
                uniqueId = uniqueIdObject.UniqueId;
            }
        }

        public UniqueIdReference(UniqueIdReference uniqueIdReference)
            : base(uniqueIdReference)
        {
            if (uniqueIdReference != null)
            {
                uniqueId = uniqueIdReference.uniqueId;
            }
        }

        public UniqueIdReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override string ToString()
        {
            return Convert.ToSystem_String(TypeReference, uniqueId, Constans.Reference.Format.UniqueId);
        }

        public override ISerializableObject Clone()
        {
            return new UniqueIdReference(this);
        }

        [JsonIgnore]
        public override string UniqueId
        {
            get
            {
                return uniqueId;
            }
        }
    }
}