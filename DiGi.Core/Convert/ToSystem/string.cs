using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a serializable object to its JSON string representation using default options.
        /// </summary>
        public static string? ToSystem_String(this ISerializableObject? serializableObject)
        {
            return ToSystem_String(serializableObject, Settings.SerializationManager.JsonSerializerOptions);
        }

        /// <summary>
        /// Converts a collection of serializable objects to a JSON string representation using default options.
        /// </summary>
        public static string? ToSystem_String(this IEnumerable<ISerializableObject>? serializableObjects)
        {
            return ToSystem_String(serializableObjects, null);
        }

        /// <summary>
        /// Converts a collection of objects implementing ISerializableObject to a JSON string representation using default options.
        /// </summary>
        public static string? ToSystem_String<T>(this IEnumerable<T>? serializableObjects) where T : ISerializableObject
        {
            return ToSystem_String(serializableObjects, null);
        }

        /// <summary>
        /// Converts a serializable object to its JSON string representation using specified options.
        /// </summary>
        public static string? ToSystem_String(this ISerializableObject? serializableObject, JsonSerializerOptions? jsonSerializerOptions)
        {
            if (serializableObject == null)
            {
                return null;
            }

            JsonObject? jsonObject = serializableObject.ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return JsonSerializer.Serialize(jsonObject, jsonSerializerOptions);
            //return jsonObject.ToJsonString(jsonSerializerOptions);
        }

        /// <summary>
        /// Converts a collection of serializable objects to a JSON string representation using specified options.
        /// </summary>
        public static string? ToSystem_String(this IEnumerable<ISerializableObject>? serializableObjects, JsonSerializerOptions? jsonSerializerOptions)
        {
            if (serializableObjects == null)
            {
                return null;
            }

            JsonArray jsonArray = [];
            foreach (ISerializableObject serializableObject in serializableObjects)
            {
                jsonArray.Add(serializableObject?.ToJsonObject());
            }

            return JsonSerializer.Serialize(jsonArray, jsonSerializerOptions);
            //return jsonArray.ToJsonString(jsonSerializerOptions);
        }

        /// <summary>
        /// Converts a collection of objects implementing ISerializableObject to a JSON string representation using specified options.
        /// </summary>
        public static string? ToSystem_String<USerializableObject>(this IEnumerable<USerializableObject>? serializableObjects, JsonSerializerOptions? jsonSerializerOptions) where USerializableObject : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            JsonArray jsonArray = [];
            foreach (USerializableObject serializableObject in serializableObjects)
            {
                jsonArray.Add(serializableObject?.ToJsonObject());
            }

            return JsonSerializer.Serialize(jsonArray, jsonSerializerOptions);
            //return jsonArray.ToJsonString(jsonSerializerOptions);
        }

        /// <summary>
        /// Formats a type reference and unique identifier into a system string.
        /// </summary>
        public static string? ToSystem_String(this TypeReference? typeReference, string? uniqueId, string? format)
        {
            string? result = typeReference?.ToString();
            if (!string.IsNullOrWhiteSpace(result))
            {
                result += Constants.Reference.Separator;
            }

            if (string.IsNullOrWhiteSpace(result))
            {
                if (string.IsNullOrWhiteSpace(uniqueId))
                {
                    return null;
                }

                result = string.Empty;
            }

            if (string.IsNullOrWhiteSpace(format))
            {
                result += uniqueId;
            }
            else
            {
                result += string.Format(format, uniqueId);
            }

            return result;
        }

        /// <summary>
        /// Converts a serializable reference to its system string representation with an optional source.
        /// </summary>
        public static string? ToSystem_String(this ISerializableReference? serializableReference, string? source)
        {
            if (serializableReference == null)
            {
                return source;
            }

            if (source == null)
            {
                return serializableReference.ToString();
            }

            string result = string.Format("\"{0}\"", source);
            if (!string.IsNullOrWhiteSpace(result))
            {
                result += Constants.Reference.Separator;
            }

            result += serializableReference.ToString();

            return result;
        }
    }
}