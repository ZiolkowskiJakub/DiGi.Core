using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class UniqueReference : Reference
    {
        [JsonInclude, JsonPropertyName("TypeReference")]
        private TypeReference typeReference;
        
        [JsonInclude, JsonPropertyName("Guid")]
        private Guid guid;

        public UniqueReference(string fullTypeName, Guid guid)
            :base()
        {
            typeReference = new TypeReference(fullTypeName);
            this.guid = guid;
        }

        public UniqueReference(Type type, Guid guid)
            : base()
        {
            typeReference = new TypeReference(type);
            this.guid = guid;
        }

        public UniqueReference(IUniqueObject uniqueObject)
            : base()
        {
            if (uniqueObject != null)
            {
                typeReference = new TypeReference(uniqueObject);
                guid = uniqueObject.Guid;
            }
        }

        public UniqueReference(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public override string ToString()
        {
            string result = base.ToString();
            if(!string.IsNullOrWhiteSpace(result))
            {
                result += "::";
            }

            result += guid.ToString("B");

            return result;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(UniqueReference uniqueReference_1, UniqueReference uniqueReference_2)
        {
            return uniqueReference_1?.ToString() == uniqueReference_2?.ToString();
        }

        public static bool operator !=(UniqueReference uniqueReference_1, UniqueReference uniqueReference_2)
        {
            return uniqueReference_1?.ToString() != uniqueReference_2.ToString();
        }

        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }

        [JsonIgnore]
        public TypeReference TypeReference
        {
            get
            {
                return typeReference;
            }
        }

        public static implicit operator UniqueReference(UniqueObject uniqueObject)
        {
            if (uniqueObject == null)
            {
                return null;
            }

            return new UniqueReference(uniqueObject);
        }
    }
}
