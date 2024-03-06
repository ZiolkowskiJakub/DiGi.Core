using System.Collections.Generic;
using System.Text.Json.Nodes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static JsonArray ToJson<T>(this IEnumerable<T> serializableObjects) where T : ISerializableObject
        {
            if(serializableObjects == null)
            {
                return null;
            }

            JsonArray result = new JsonArray();
            foreach(T serializableObject in serializableObjects)
            {
                JsonObject jsonObject = serializableObject?.ToJsonObject();
                result.Add(jsonObject);
            }

            return result;
        }
    }
}
