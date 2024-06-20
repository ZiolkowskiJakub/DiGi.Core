using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class SerializableObjectWrapper : SerializableObject
    {
        private JsonObject jsonObject;

        public SerializableObjectWrapper()
            :base()
        {

        }

        public SerializableObjectWrapper(JsonObject jsonObject) 
        {
            this.jsonObject = jsonObject?.DeepClone() as JsonObject;
        }

        public static explicit operator JsonObject(SerializableObjectWrapper serializableObjectWrapper)
        {
            if (serializableObjectWrapper == null)
            {
                return null;
            }

            return serializableObjectWrapper.ToJsonObject();
        }

        public static explicit operator SerializableObjectWrapper(JsonObject jsonObject)
        {
            return new SerializableObjectWrapper(jsonObject);
        }

        public override ISerializableObject Clone()
        {
            return new SerializableObjectWrapper(jsonObject);
        }

        public override bool FromJsonObject(JsonObject jsonObject)
        {
            jsonObject = jsonObject?.DeepClone() as JsonObject;
            return jsonObject != null;
        }

        public override JsonObject ToJsonObject()
        {
            return jsonObject?.DeepClone() as JsonObject;
        }

        public bool TryGetFullTypeName(out string fullTypeName)
        {
            fullTypeName = Query.FullTypeName(jsonObject);
            return !string.IsNullOrWhiteSpace(fullTypeName);
        }
    }
}
