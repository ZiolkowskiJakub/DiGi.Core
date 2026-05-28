using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for serializable objects identified by a unique string ID.</summary>
    public abstract class UniqueIdObject : UniqueObject, IUniqueIdObject
    {
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.UniqueId)]
        private readonly string? uniqueId;

        public UniqueIdObject()
            : base()
        {
        }

        public UniqueIdObject(string? uniqueId)
            : base()
        {
            this.uniqueId = uniqueId;
        }

        public UniqueIdObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UniqueIdObject(UniqueIdObject? uniqueIdObject)
            : base(uniqueIdObject)
        {
            if (uniqueIdObject != null)
            {
                uniqueId = uniqueIdObject.uniqueId;
            }
        }

        public UniqueIdObject(string uniqueId, GuidObject? guidObject)
            : base(guidObject)
        {
            this.uniqueId = uniqueId;
        }

        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return uniqueId;
            }
        }
    }
}