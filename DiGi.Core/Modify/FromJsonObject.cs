using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Modify
    {
        /// <summary>
        /// Populates an ISerializableObject from a JSON object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to populate.</param>
        /// <param name="jsonObject">The JSON object containing the data.</param>
        /// <returns>True if the object was successfully populated; otherwise, false.</returns>
        public static bool FromJsonObject(this ISerializableObject? serializableObject, JsonObject? jsonObject)
        {
            if (serializableObject == null || jsonObject == null)
            {
                return false;
            }

            if (serializableObject is SerializableObjectWrapper)
            {
                serializableObject.FromJsonObject(jsonObject);
            }

            SerializationMethodCollection? serializationMethodCollection = Settings.SerializationManager.GetSerializationMethodCollection(serializableObject);
            if (serializationMethodCollection == null)
            {
                return false;
            }

            return serializationMethodCollection.Update(serializableObject, jsonObject);
        }
    }
}