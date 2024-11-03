using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class SerializableObjectValueCluster<TKey_1, TKey_2, TValue> : ValueCluster<TKey_1, TKey_2, TValue>, ISerializableObject where TValue : ISerializableObject
    {
        public SerializableObjectValueCluster()
            : base()
        {
        }

        public SerializableObjectValueCluster(IEnumerable<TValue> values)
            : base(values)
        {
        }

        public SerializableObjectValueCluster(SerializableObjectValueCluster<TKey_1, TKey_2, TValue> serializableObjectValueCluster)
            : base(serializableObjectValueCluster)
        {
        }

        public SerializableObjectValueCluster(JsonObject jsonObject)
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

