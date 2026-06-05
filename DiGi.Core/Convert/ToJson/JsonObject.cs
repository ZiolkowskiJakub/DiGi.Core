using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a serializable object to a JsonObject.
        /// </summary>
        /// <param name="serializableObject">The serializable object to convert.</param>
        /// <returns>A <see cref="JsonObject"/> representation of the object, or <c>null</c> if the input is null.</returns>
        public static JsonObject? ToJson(this ISerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            if (serializableObject is SerializableObjectWrapper)
            {
                return serializableObject.ToJsonObject();
            }

            SerializationMethodCollection? serializationMethodCollection = Settings.SerializationManager.GetSerializationMethodCollection(serializableObject);
            if (serializationMethodCollection == null)
            {
                return null;
            }

            return serializationMethodCollection.Create(serializableObject);
        }
    }
}