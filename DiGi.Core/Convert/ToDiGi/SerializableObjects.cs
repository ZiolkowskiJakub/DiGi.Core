using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Deserializes a JSON string into a list of objects of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A list of objects of type <typeparamref name="T"/>, or null if deserialization fails.</returns>
        public static List<T>? ToDiGi<T>(string? json) where T : ISerializableObject
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            JsonNode? jsonNode;
            try
            {
                jsonNode = JsonNode.Parse(json!);
            }
            catch (JsonException)
            {
                // Not JSON. Callers on the Try* path (e.g. Query.TryConvert of a reference string) rely on a null
                // return rather than an exception when the input is some other string format.
                return null;
            }

            if (jsonNode == null)
            {
                return null;
            }

            if (jsonNode is JsonObject jsonObject)
            {
                T? serializableObject = Create.SerializableObject<T>(jsonObject);
                if (serializableObject == null)
                {
                    return null;
                }

                return [serializableObject];
            }

            List<T>? result = null;

            if (jsonNode is JsonArray jsonArray)
            {
                result = new List<T>(jsonArray.Count);
                foreach (JsonNode? jsonNode_Temp in jsonArray)
                {
                    if (jsonNode_Temp is JsonObject jsonObject_Temp)
                    {
                        T? serializableObject = Create.SerializableObject<T>(jsonObject_Temp);
                        if (serializableObject == null)
                        {
                            continue;
                        }

                        result.Add(serializableObject);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Loads and deserializes a list of objects of type <typeparamref name="T"/> from the specified path.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="path">The path to the source data.</param>
        /// <returns>A list of objects of type <typeparamref name="T"/>, or null if loading fails.</returns>
        public static List<T>? ToDiGi<T>(Classes.Path path) where T : ISerializableObject
        {
            if (path == null)
            {
                return null;
            }

            if (!path.FileExists)
            {
                return null;
            }

            string json = System.IO.File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            return ToDiGi<T>(json);
        }

        /// <summary>
        /// Deserializes a byte array into a list of objects of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="bytes">The byte array to deserialize.</param>
        /// <returns>A list of objects of type <typeparamref name="T"/>, or null if deserialization fails.</returns>
        public static List<T>? ToDiGi<T>(byte[]? bytes) where T : ISerializableObject
        {
            if (bytes == null)
            {
                return null;
            }

            JsonNode? jsonNode = JsonNode.Parse(bytes);
            if (jsonNode is null)
            {
                return null;
            }

            JsonValueKind jsonValueKind = jsonNode.GetValueKind();
            switch (jsonValueKind)
            {
                case JsonValueKind.Object:
                    T? value = Create.SerializableObject<T>(jsonNode.AsObject());
                    if (value is null)
                    {
                        return null;
                    }

                    return [value];

                case JsonValueKind.Array:
                    return Create.SerializableObjects<T>(jsonNode.AsArray());

                case JsonValueKind.String:
                    string? json = jsonNode.AsValue()?.GetValue<string>();
                    return ToDiGi<T>(json);
            }

            return null;
        }
    }
}