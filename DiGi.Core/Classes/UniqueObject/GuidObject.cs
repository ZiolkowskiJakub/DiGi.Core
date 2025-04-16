using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class GuidObject : UniqueObject, IGuidObject
    {
        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Guid)]
        private Guid guid;

        public GuidObject()
            : base()
        {
            guid = Guid.NewGuid();
        }

        public GuidObject(Guid guid)
            :base()
        {
            this.guid = guid;
        }

        public GuidObject(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public GuidObject(GuidObject guidObject)
            : base(guidObject)
        {
            guid = guidObject != null ? guidObject.guid : Guid.NewGuid();
        }

        public GuidObject(Guid guid, GuidObject guidObject)
            : base(guidObject)
        {
            this.guid = guid;
        }

        public virtual IGuidObject Duplicate(Guid? guid = null)
        {
            GuidObject result = Query.Clone(this);
            result.guid = guid == null ? Guid.NewGuid() : guid.Value;
            return result;
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
        public override string UniqueId
        {
            get
            {
                return guid.ToString("N");
            }
        }
    }
}
