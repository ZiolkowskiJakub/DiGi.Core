using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class UniqueIdReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("UniqueId")]
        private readonly string uniqueId = Constants.UniqueId.Null;

        public UniqueIdReference(TypeReference? typeReference, string? uniqueId)
            : base(typeReference)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        public UniqueIdReference(string? fullTypeName, string? uniqueId)
            : base(fullTypeName)
        {
            if (uniqueId != null)
            {
                this.uniqueId = uniqueId;
            }
        }

        public UniqueIdReference(IUniqueIdObject? uniqueIdObject)
            : base(uniqueIdObject)
        {
            if (uniqueIdObject != null)
            {
                if (uniqueIdObject.UniqueId != null)
                {
                    uniqueId = uniqueIdObject.UniqueId;
                }
            }
        }

        public UniqueIdReference(UniqueIdReference? uniqueIdReference)
            : base(uniqueIdReference)
        {
            if (uniqueIdReference is not null)
            {
                uniqueId = uniqueIdReference.uniqueId;
            }
        }

        public UniqueIdReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return uniqueId;
            }
        }

        public override ISerializableObject? Clone()
        {
            return new UniqueIdReference(this);
        }

        public override string? ToString()
        {
            return Convert.ToSystem_String(TypeReference, uniqueId, Constants.Reference.Format.UniqueId);
        }
    }
}