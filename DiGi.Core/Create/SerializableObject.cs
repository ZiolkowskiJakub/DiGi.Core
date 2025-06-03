using System.Collections.Generic;
using System.Text.Json.Nodes;
using DiGi.Core.Interfaces;


namespace DiGi.Core
{
    public static partial class Create
    {
        public static List<T> SerializableObjects<T>(this JsonArray jsonArray) where T : ISerializableObject
        {
            if (jsonArray == null)
            {
                return default;
            }

            List < T > result = new List<T> ();
            foreach (JsonNode jsonNode in jsonArray)
            {
                if(!(jsonNode is JsonObject))
                {
                    continue;
                }

                T serializableObject = SerializableObject<T>((JsonObject)jsonNode);
                if(serializableObject != null)
                {
                    result.Add(serializableObject);
                }
            }

            return result;
        }
    }
}