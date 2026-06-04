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
        public static List<T>? ToDiGi<T>(string? json) where T : ISerializableObject
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            JsonNode? jsonNode = JsonNode.Parse(json!);
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
                result = [];
                foreach (object? @object in jsonArray)
                {
                    if (@object is JsonObject jsonObject_Temp)
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
                    string? json = jsonNode?.AsValue()?.GetValue<string>();
                    return ToDiGi<T>(json);
            }

            return null;
        }
    }
}