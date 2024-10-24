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

        public GuidReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override string ToString()
        {
            return new UniqueIdReference(FullTypeName, Query.UniqueId(guid)).ToString();
        }

        public override ISerializableObject Clone()
        {
            return new GuidReference(this);
        }

        public static bool operator ==(GuidReference guidReference_1, GuidReference guidReference_2)
        {
            return guidReference_1?.ToString() == guidReference_2?.ToString();
        }

        public static bool operator !=(GuidReference guidReference_1, GuidReference guidReference_2)
        {
            return guidReference_1?.ToString() != guidReference_2?.ToString();
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

