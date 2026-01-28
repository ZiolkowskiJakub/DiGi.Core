using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class SerializableObject : Object, ISerializableObject
    {
        public SerializableObject()
            : base()
        {
        }

        public SerializableObject(SerializableObject? serializableObject)
            : base()
        {
            if (serializableObject != null)
            {
            }
        }

        public SerializableObject(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        [JsonInclude, JsonPropertyName(Constans.Serialization.PropertyName.Type)]
        private string? FullTypeName => Query.FullTypeName(GetType());

        public static explicit operator JsonObject?(SerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            return serializableObject.ToJsonObject();
        }

        public static explicit operator SerializableObject?(JsonObject? jsonObject)
        {
            return Create.SerializableObject<SerializableObject>(jsonObject);
        }

        public virtual ISerializableObject? Clone()
        {
            JsonObject? jsonObject = ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return Create.SerializableObject<ISerializableObject>(jsonObject);
        }

        public virtual bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        public virtual JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }
    }
}