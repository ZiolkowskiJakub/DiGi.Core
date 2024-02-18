using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class TypeReference : Reference
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private string fullTypeName;

        public TypeReference(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public TypeReference(string fullTypeName)
            : base()
        {
            this.fullTypeName = fullTypeName;
        }

        public TypeReference(IObject @object)
            :base()
        {
            fullTypeName = Query.FullTypeName(@object.GetType());
        }

        [JsonIgnore]
        public string FullTypeName
        {
            get
            {
                return fullTypeName;
            }
        }

        public override string ToString()
        {
            return fullTypeName == null ? string.Empty : fullTypeName;
        }

        public override bool Equals(object @object)
        {
            TypeReference typeReference = @object as TypeReference;
            if(typeReference == null)
            {
                return false;
            }

            return typeReference.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(TypeReference typeReference_1, TypeReference typeReference_2)
        {
            return typeReference_1?.fullTypeName == typeReference_2?.fullTypeName;
        }

        public static bool operator !=(TypeReference typeReference_1, TypeReference typeReference_2)
        {
            return typeReference_1?.fullTypeName != typeReference_2.fullTypeName;
        }

        public static implicit operator TypeReference(System.Type type)
        {
            return Create.TypeReference(type);
        }

        public static implicit operator System.Type(TypeReference typeReference)
        {
            return Query.Type(typeReference);
        }
    }
}
