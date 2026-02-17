using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static byte[]? ToSystem_Bytes(this ISerializableObject? serializableObject)
        {
            JsonObject? jsonObject = serializableObject?.ToJsonObject();
            if (jsonObject is null)
            {
                return null;
            }

            return JsonSerializer.SerializeToUtf8Bytes(jsonObject);
        }

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