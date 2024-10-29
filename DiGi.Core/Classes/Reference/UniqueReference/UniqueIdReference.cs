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
            string result = TypeReference?.ToString();
            if (!string.IsNullOrWhiteSpace(result))
            {
                result += Constans.Reference.Separator;
            }

            if (result == null)
            {
                result = string.Empty;
            }

            result += string.Format("\"{0}\"", uniqueId);

            return result;
        }

        public override ISerializableObject Clone()
        {
            return new UniqueIdReference(this);
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