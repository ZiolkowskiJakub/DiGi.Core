using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
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