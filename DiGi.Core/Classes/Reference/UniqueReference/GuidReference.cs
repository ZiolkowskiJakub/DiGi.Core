using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class GuidReference : UniqueReference
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private Guid guid = Guid.Empty;

        public GuidReference(string fullTypeName, Guid guid)
            : base(fullTypeName)
        {
            this.guid = guid;
        }

        public GuidReference(GuidReference guidReference)
            : base(guidReference)
        {
            if (guidReference != null)
            {
                guid = guidReference.guid;
            }
        }

        public GuidReference(IUniqueObject uniqueObject)
            : base(uniqueObject)
        {
            if(uniqueObject != null)
            {
                guid = uniqueObject.Guid;
            }
        }

        public GuidReference(TypeReference typeReference, Guid guid)
            : base(typeReference)
        {
            this.guid = guid;
        }

        public GuidReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override string ToString()
        {
            return Convert.ToString(TypeReference, Query.UniqueId(guid)?.ToString());
        }

        public override ISerializableObject Clone()
        {
            return new GuidReference(this);
        }

        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }
    }
}

