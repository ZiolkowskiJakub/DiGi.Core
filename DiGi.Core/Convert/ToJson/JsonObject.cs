using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static JsonObject ToJson(this ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            if(serializableObject is SerializableObjectWrapper)
            {
                return serializableObject.ToJsonObject();
            }

            SerializationMethodCollection serializationMethodCollection = Settings.SerializationManager.GetSerializationMethodCollection(serializableObject);
            if(serializationMethodCollection == null)
            {
                return null;
            }

            return serializationMethodCollection.Create(serializableObject);
        }
    }
}
