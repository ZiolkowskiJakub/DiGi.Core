using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class UniqueObject : SerializableObject, IUniqueObject
    {
        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Guid)]
        private Guid guid;

        public UniqueObject()
            : base()
        {
            guid = Guid.NewGuid();
        }

        public UniqueObject(Guid guid)
            :base()
        {
            this.guid = guid;
        }

        public UniqueObject(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueObject(UniqueObject uniqueObject)
            : base()
        {
            guid = uniqueObject != null ? uniqueObject.guid : Guid.NewGuid();
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
