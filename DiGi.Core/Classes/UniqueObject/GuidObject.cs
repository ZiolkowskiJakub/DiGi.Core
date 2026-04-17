using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class GuidObject : UniqueObject, IGuidObject
    {
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.Guid)]
        private Guid guid;

        [JsonIgnore]
        private string? uniqueId = null;

        public GuidObject()
            : base()
        {
            guid = Guid.NewGuid();
        }

        public GuidObject(Guid guid)
            : base()
        {
            this.guid = guid;
        }

        public GuidObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
            if(jsonObject is not null)
            {
                if(!jsonObject.ContainsKey(Constants.Serialization.PropertyName.Guid))
                {
                    guid = Guid.NewGuid();
                }
            }
        }

        public GuidObject(GuidObject? guidObject)
            : base(guidObject)
        {
            if(guidObject is not null)
            {
                guid = guidObject.guid;
            }
        }

        public GuidObject(Guid guid, GuidObject? guidObject)
            : base(guidObject)
        {
            this.guid = guid;
        }

        public virtual IGuidObject? Duplicate(Guid? guid = null)
        {
            GuidObject? result = Query.Clone(this);

            result?.guid = guid == null ? Guid.NewGuid() : guid.Value;

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
        public override string? UniqueId
        {
            get
            {
                if (uniqueId == null)
                {
                    uniqueId = guid.ToString("N");
                }

                return uniqueId;
            }
        }
    }
}