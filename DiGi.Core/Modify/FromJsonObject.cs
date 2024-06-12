using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;


namespace DiGi.Core
{
    public static partial class Modify
    {
        public static bool FromJsonObject(this ISerializableObject serializableObject, JsonObject jsonObject)
        {
            if(serializableObject == null || jsonObject == null)
            {
                return false;
            }

            if(serializableObject is SerializableObjectWrapper)
            {
                serializableObject.FromJsonObject(jsonObject);
            }

            SerializationMethodCollection serializationMethodCollection = Settings.SerializationManager.GetSerializationMethodCollection(serializableObject);
            if (serializationMethodCollection == null )
            {
                return false;
            }

            return serializationMethodCollection.Update(serializableObject, jsonObject);
        }
    }
}
