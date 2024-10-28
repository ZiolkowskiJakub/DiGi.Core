using DiGi.Core.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database.Classes
{
    public class DatabaseType : SerializableObject, IDatabaseSystemObject
    {
        [JsonInclude, JsonPropertyName("Id")]
        private int id;

        [JsonInclude, JsonPropertyName("FullTypeName")]
        private string fullTypeName;

        [JsonIgnore]
        private System.Type type;

        public DatabaseType(int id, string fullTypeName)
        {
            this.id = id;
            this.fullTypeName = fullTypeName;
        }

        public DatabaseType(int id, TypeReference typeReference)
        {
            this.id = id;
            fullTypeName = typeReference.FullTypeName;
        }

        [JsonIgnore]
        public System.Type Type
        {
            get
            {
                if(type == null)
                {
                    type = Core.Query.Type(fullTypeName);
                }

                return type;
            }
        }

        [JsonIgnore]
        public TypeReference TypeReference
        {
            get
            {
                if(string.IsNullOrWhiteSpace(fullTypeName))
                {
                    return null;
                }

                return new TypeReference(fullTypeName);
            }
        }
    }
}