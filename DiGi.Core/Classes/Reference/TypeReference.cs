using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class TypeReference : SerializableReference, ITypeRelatedSerializableReference
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private string fullTypeName;

        public TypeReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public TypeReference(TypeReference typeReference)
            : base()
        {
            fullTypeName = typeReference?.fullTypeName;
        }

        public TypeReference(string fullTypeName)
            : base()
        {
            this.fullTypeName = fullTypeName;
        }

        public TypeReference(Type type)
            : base()
        {
            fullTypeName = Query.FullTypeName(type);
        }

        public TypeReference(IObject @object)
            : base()
        {
            fullTypeName = Query.FullTypeName(@object.GetType());
        }

        public override ISerializableObject Clone()
        {
            return new TypeReference(fullTypeName);
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
            if (typeReference == null)
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
            return typeReference_1?.fullTypeName != typeReference_2?.fullTypeName;
        }

        public static implicit operator TypeReference(Type type) => type.TypeReference();

        public static implicit operator Type(TypeReference typeReference) => Query.Type(typeReference);
    }
}
