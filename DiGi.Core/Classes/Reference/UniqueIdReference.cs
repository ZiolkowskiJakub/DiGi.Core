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
            string result = base.ToString();
            if (!string.IsNullOrWhiteSpace(result))
            {
                result += Constans.UniqueId.Separator;
            }

            if (result == null)
            {
                result = string.Empty;
            }

            result += uniqueId;

            return result;
        }

        public override ISerializableObject Clone()
        {
            return new UniqueIdReference(this);
        }

        public static bool operator ==(UniqueIdReference uniqueIdReference_1, UniqueIdReference uniqueIdReference_2)
        {
            return uniqueIdReference_1?.ToString() == uniqueIdReference_2?.ToString();
        }

        public static bool operator !=(UniqueIdReference uniqueIdReference_1, UniqueIdReference uniqueIdReference_2)
        {
            return uniqueIdReference_1?.ToString() != uniqueIdReference_2?.ToString();
        }

        [JsonIgnore]
        public string UniqueId
        {
            get
            {
                return uniqueId;
            }
        }
    }
}