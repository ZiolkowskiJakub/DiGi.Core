using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class SerializableObject : Object, ISerializableObject
    {
        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Type)]
        private string fullTypeName => Query.FullTypeName(GetType());

        public SerializableObject()
            :base()
        {

        }

        public SerializableObject(SerializableObject serializableObject)
        {

        }

        public SerializableObject(JsonObject jsonObject) 
        {
            FromJsonObject(jsonObject);
        }

        public virtual bool FromJsonObject(JsonObject jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public virtual JsonObject ToJsonObject()
        {
            return Convert.ToJson(this);
        }

        public virtual ISerializableObject Clone()
        {
            JsonObject jsonObject = ToJsonObject();
            if(jsonObject == null)
            {
                return null;
            }

            return Create.SerializableObject<ISerializableObject>(jsonObject);
        }

        public static explicit operator SerializableObject(JsonObject jsonObject)
        {
            return Create.SerializableObject<SerializableObject>(jsonObject);
        }

        public static explicit operator JsonObject(SerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            return serializableObject.ToJsonObject();
        }
    }
}
