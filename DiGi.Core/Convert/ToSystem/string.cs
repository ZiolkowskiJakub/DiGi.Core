using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static string ToString(this ISerializableObject serializableObject)
        {
            return ToString(serializableObject, null);
        }
        
        public static string ToString(this IEnumerable<ISerializableObject> serializableObjects)
        {
            return ToString(serializableObjects, null);
        }

        public static string ToString<T>(this IEnumerable<T> serializableObjects) where T :ISerializableObject
        {
            return ToString(serializableObjects, null);
        }

        public static string ToString(this ISerializableObject serializableObject, JsonSerializerOptions jsonSerializerOptions)
        {
            if (serializableObject == null)
            {
                return null;
            }

            JsonObject jsonObject = serializableObject.ToJsonObject();
            if(jsonObject == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(jsonObject, jsonSerializerOptions);
            //return jsonObject.ToJsonString(jsonSerializerOptions);
        }

        public static string ToString(this IEnumerable<ISerializableObject> serializableObjects, JsonSerializerOptions jsonSerializerOptions)
        {
            if (serializableObjects == null)
            {
                return null;
            }

            JsonArray jsonArray = new JsonArray();
            foreach(ISerializableObject serializableObject in serializableObjects)
            {
                jsonArray.Add(serializableObject?.ToJsonObject());
            }

            return JsonSerializer.Serialize(jsonArray, jsonSerializerOptions);
            //return jsonArray.ToJsonString(jsonSerializerOptions);
        }

        public static string ToString<T>(this IEnumerable<T> serializableObjects, JsonSerializerOptions jsonSerializerOptions) where T : ISerializableObject 
        {
            if (serializableObjects == null)
            {
                return null;
            }

            JsonArray jsonArray = new JsonArray();
            foreach (ISerializableObject serializableObject in serializableObjects)
            {
                jsonArray.Add(serializableObject?.ToJsonObject());
            }

            return JsonSerializer.Serialize(jsonArray, jsonSerializerOptions);
            //return jsonArray.ToJsonString(jsonSerializerOptions);
        }

        public static string ToString(this TypeReference typeReference, string uniqueId, string format)
        {
            string result = typeReference?.ToString();
            if (!string.IsNullOrWhiteSpace(result))
            {
                result += Constans.Reference.Separator;
            }

            if (string.IsNullOrWhiteSpace(result))
            {
                if(string.IsNullOrWhiteSpace(uniqueId))
                {
                    return null;
                }

                result = string.Empty;
            }

            if(string.IsNullOrWhiteSpace(format))
            {
                result += uniqueId;
            }
            else
            {
                result += string.Format(format, uniqueId);
            }

            return result;
        }

        public static string ToString(this ISerializableReference serializableReference, string source)
        {
            if(serializableReference == null)
            {
                return source;
            }

            if(source == null)
            {
                return serializableReference.ToString();
            }

            string result = string.Format("\"{0}\"", source);
            if (!string.IsNullOrWhiteSpace(result))
            {
                result += Constans.Reference.Separator;
            }

            result += serializableReference.ToString();

            return result;
        }
    }
}
