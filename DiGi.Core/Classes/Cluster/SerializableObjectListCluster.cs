using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class SerializableObjectListCluster<TKey_1, TKey_2, TValue> : List<TKey_1, TKey_2, TValue>, ISerializableObject where TValue : ISerializableObject
    {
        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Type)]
        private string fullTypeName => Query.FullTypeName(GetType());

        public SerializableObjectListCluster()
            : base()
        {
        }

        public SerializableObjectListCluster(IEnumerable<TValue> values)
            : base(values)
        {
        }

        public SerializableObjectListCluster(SerializableObjectListCluster<TKey_1, TKey_2, TValue> serializableObjectListCluster)
            : base(serializableObjectListCluster)
        {
        }

        public SerializableObjectListCluster(JsonObject jsonObject)
            : base()
        {
            FromJsonObject(jsonObject);
        }

        public virtual ISerializableObject Clone()
        {
            JsonObject jsonObject = ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return Create.SerializableObject<ISerializableObject>(jsonObject);
        }

        public bool FromJsonObject(JsonObject jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public JsonObject ToJsonObject()
        {
            return Convert.ToJson((ISerializableObject)this);
        }
    }
}