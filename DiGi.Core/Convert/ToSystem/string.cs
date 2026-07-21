using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text;
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

        // TODO [ReferenceFormat]: Two overloads were removed here - ToSystem_String(TypeReference?, string?, string?)
        // and ToSystem_String(ISerializableReference?, string?). They built the pre-discriminator format, which
        // encoded a reference's type by shape, escaped nothing, and could return null. ToSystem_String(Type?,
        // IEnumerable<string?>) below replaces both. Legacy strings are READ by Query.TryParseLegacy; restore these
        // only if the old format must be WRITTEN again.

        /// <summary>
        /// Renders a reference type and its ordered, already-escaped segments into a reference string.
        /// <para>Prefixes the type's discriminator - its <see cref="Constants.Reference.Kind"/> token when it
        /// declares one, otherwise its assembly-qualified full type name - so the result identifies exactly one
        /// reference type and can be parsed back by <see cref="Query.TryParse(string?, out Interfaces.IReference?)"/>.</para>
        /// </summary>
        /// <param name="type">The concrete reference type being rendered.</param>
        /// <param name="segments">The segments, already escaped via <see cref="Query.Segment(string?)"/> or <see cref="Query.Segment(Interfaces.IReference?)"/>.</param>
        /// <returns>The reference string, or null when <paramref name="type"/> has no registered factory.</returns>
        public static string? ToSystem_String(this System.Type? type, IEnumerable<string?>? segments)
        {
            string? discriminator = Settings.ReferenceManager.GetReferenceConstructor(type)?.Discriminator;
            if (string.IsNullOrWhiteSpace(discriminator))
            {
                return null;
            }

            StringBuilder stringBuilder = new(discriminator);

            if (segments != null)
            {
                foreach (string? segment in segments)
                {
                    stringBuilder.Append(Constants.Reference.Separator);
                    stringBuilder.Append(segment ?? Constants.Reference.Null);
                }
            }

            return stringBuilder.ToString();
        }
    }
}