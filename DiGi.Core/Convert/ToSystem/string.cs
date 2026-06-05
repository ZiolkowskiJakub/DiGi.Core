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
        /// <param name="serializableObject">The serializable object to convert.</param>
        /// <returns>A JSON string representation of the object, or null if the input is null.</returns>
        public static string? ToSystem_String(this ISerializableObject? serializableObject)
        {
            return ToSystem_String(serializableObject, Settings.SerializationManager.JsonSerializerOptions);
        }

        /// <summary>
        /// Converts a collection of serializable objects to a JSON string representation using default options.
        /// </summary>
        /// <param name="serializableObjects">The collection of serializable objects to convert.</param>
        /// <returns>A JSON string representation of the collection, or null if the input is null.</returns>
        public static string? ToSystem_String(this IEnumerable<ISerializableObject>? serializableObjects)
        {
            return ToSystem_String(serializableObjects, null);
        }

        /// <summary>
        /// Converts a collection of objects implementing ISerializableObject to a JSON string representation using default options.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="serializableObjects">The collection of serializable objects to convert.</param>
        /// <returns>A JSON string representation of the collection, or null if the input is null.</returns>
        public static string? ToSystem_String<T>(this IEnumerable<T>? serializableObjects) where T : ISerializableObject
        {
            return ToSystem_String(serializableObjects, null);
        }

        /// <summary>
        /// Converts a serializable object to its JSON string representation using specified options.
        /// </summary>
        /// <param name="serializableObject">The serializable object to convert.</param>
        /// <param name="jsonSerializerOptions">The options to use for JSON serialization.</param>
        /// <returns>A JSON string representation of the object, or null if applicable.</returns>
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
        /// <param name="serializableObjects">The collection of serializable objects to convert.</param>
        /// <param name="jsonSerializerOptions">The options to use for JSON serialization.</param>
        /// <returns>A JSON string representation of the collection, or null if applicable.</returns>
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
        /// <typeparam name="USerializableObject">The type of the serializable objects in the collection.</typeparam>
        /// <param name="serializableObjects">The collection of serializable objects to convert.</param>
        /// <param name="jsonSerializerOptions">The options to use for JSON serialization.</param>
        /// <returns>A JSON string representation of the collection, or null if applicable.</returns>
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
        /// <param name="typeReference">The type reference to format.</param>
        /// <param name="uniqueId">The unique identifier for the type.</param>
        /// <param name="format">The format string to use.</param>
        /// <returns>The formatted system string, or null if applicable.</returns>
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
        /// <param name="serializableReference">The serializable reference to convert.</param>
        /// <param name="source">The optional source string.</param>
        /// <returns>The system string representation of the serializable reference, or null if applicable.</returns>
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