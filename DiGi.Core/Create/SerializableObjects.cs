using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a list of serializable objects from the given JSON array.</summary>
        /// <typeparam name="T">The type of elements in the resulting list.</typeparam>
        /// <param name="jsonArray">The JSON array to be converted into a list of serializable objects.</param>
        /// <returns>A list containing the deserialized objects of type <typeparamref name="T"/>, or null if the input is null.</returns>
        public static List<T>? SerializableObjects<T>(this JsonArray? jsonArray) where T : ISerializableObject
        {
            if (jsonArray == null)
            {
                return default;
            }

            List<T> result = [];
            foreach (JsonNode? jsonNode in jsonArray)
            {
                if (jsonNode is not JsonObject)
                {
                    continue;
                }

                T? serializableObject = SerializableObject<T>((JsonObject)jsonNode);
                if (serializableObject != null)
                {
                    result.Add(serializableObject);
                }
            }

            return result;
        }
    }
}