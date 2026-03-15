using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class GuidReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private readonly Guid guid = Guid.Empty;

        public GuidReference(string? fullTypeName, Guid guid)
            : base(fullTypeName)
        {
            this.guid = guid;
        }

        public GuidReference(GuidReference? guidReference)
            : base(guidReference)
        {
            if (guidReference is not null)
            {
                guid = guidReference.guid;
            }
        }

        public GuidReference(IGuidObject? guidObject)
            : base(guidObject)
        {
            if (guidObject != null)
            {
                guid = guidObject.Guid;
            }
        }

        public GuidReference(TypeReference? typeReference, Guid guid)
            : base(typeReference)
        {
            this.guid = guid;
        }

        public GuidReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
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
        public override string? UniqueId
        {
            get
            {
                return Query.UniqueId(guid)?.ToString();
            }
        }

        public override ISerializableObject? Clone()
        {
            return new GuidReference(this);
        }

        public override string? ToString()
        {
            return Convert.ToSystem_String(TypeReference, UniqueId, Constants.Reference.Format.Guid);
        }
    }
}