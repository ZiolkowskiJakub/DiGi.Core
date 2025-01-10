using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class UniqueIdObject : UniqueObject, IUniqueIdObject
    {
        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.UniqueId)]
        private string uniqueId;

        public UniqueIdObject()
            : base()
        {

        }

        public UniqueIdObject(string uniqueId)
            :base()
        {
            this.uniqueId = uniqueId;
        }

        public UniqueIdObject(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueIdObject(UniqueIdObject uniqueIdObject)
            : base(uniqueIdObject)
        {
            uniqueId = uniqueIdObject?.uniqueId;
        }

        public UniqueIdObject(string uniqueId, GuidObject guidObject)
            : base(guidObject)
        {
            this.uniqueId = uniqueId;
        }

        [JsonIgnore]
        public override string UniqueId
        {
            get
            {
                return uniqueId;
            }
        }
    }
}
