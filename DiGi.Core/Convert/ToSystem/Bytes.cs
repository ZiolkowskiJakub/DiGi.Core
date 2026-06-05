using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a serializable object to its UTF-8 byte representation.
        /// </summary>
        /// <param name="serializableObject">The serializable object to convert.</param>
        /// <returns>A byte array representing the UTF-8 encoded data, or null if the input is null.</returns>
        public static byte[]? ToSystem_Bytes(this ISerializableObject? serializableObject)
        {
            JsonObject? jsonObject = serializableObject?.ToJsonObject();
            if (jsonObject is null)
            {
                return null;
            }

            return JsonSerializer.SerializeToUtf8Bytes(jsonObject);
        }

        /// <summary>
        /// Converts a collection of serializable objects to their UTF-8 byte representation.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="serializableObjects">The collection of serializable objects to convert.</param>
        /// <returns>A byte array representing the UTF-8 encoded data, or null if the input is null.</returns>
        public static byte[]? ToSystem_Bytes<T>(this IEnumerable<T>? serializableObjects) where T : ISerializableObject
        {
            JsonArray? jsonArray = serializableObjects?.ToJson();
            if (jsonArray is null)
            {
                return null;
            }

            return JsonSerializer.SerializeToUtf8Bytes(jsonArray);
        }
    }
}