using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a collection of serializable objects to a JsonArray.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="serializableObjects">The collection of serializable objects to convert.</param>
        /// <returns>A <see cref="JsonArray"/> containing the serialized objects, or <c>null</c> if the input is null.</returns>
        public static JsonArray? ToJson<T>(this IEnumerable<T>? serializableObjects) where T : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            JsonArray result = [];
            foreach (T serializableObject in serializableObjects)
            {
                JsonObject? jsonObject = serializableObject?.ToJsonObject();
                result.Add(jsonObject);
            }

            return result;
        }
    }
}