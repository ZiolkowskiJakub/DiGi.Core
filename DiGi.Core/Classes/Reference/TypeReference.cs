using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class TypeReference : SerializableReference, ITypeRelatedSerializableReference
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private readonly string? fullTypeName;

        public TypeReference(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public TypeReference(TypeReference? typeReference)
            : base(typeReference)
        {
            fullTypeName = typeReference?.fullTypeName;
        }

        public TypeReference(string? fullTypeName)
            : base()
        {
            this.fullTypeName = fullTypeName;
        }

        public TypeReference(Type? type)
            : base()
        {
            fullTypeName = Query.FullTypeName(type);
        }

        public TypeReference(IObject? @object)
            : base()
        {
            fullTypeName = Query.FullTypeName(@object?.GetType());
        }

        [JsonIgnore]
        public string? FullTypeName
        {
            get
            {
                return fullTypeName;
            }
        }

        public static implicit operator Type?(TypeReference? typeReference) => Query.Type(typeReference);

        public static implicit operator TypeReference?(Type? type) => type?.TypeReference();

        public static bool operator !=(TypeReference? typeReference_1, TypeReference? typeReference_2)
        {
            return typeReference_1?.fullTypeName != typeReference_2?.fullTypeName;
        }

        public static bool operator ==(TypeReference? typeReference_1, TypeReference? typeReference_2)
        {
            return typeReference_1?.fullTypeName == typeReference_2?.fullTypeName;
        }

        public override ISerializableObject? Clone()
        {
            return new TypeReference(fullTypeName);
        }

        public override bool Equals(object? obj)
        {
            return obj is TypeReference reference &&
                   base.Equals(obj) &&
                   fullTypeName == reference.fullTypeName &&
                   FullTypeName == reference.FullTypeName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return fullTypeName ?? string.Empty;
        }
    }
}
