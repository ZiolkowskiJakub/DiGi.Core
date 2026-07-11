using DiGi.Core.Interfaces;
using System;
using System.Text;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the full type name from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object.</param>
        /// <returns>The full type name, or null if not found.</returns>
        public static string? FullTypeName(this JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return null;
            }

            if (!jsonObject.TryGetPropertyValue(Constants.Serialization.PropertyName.Type, out JsonNode? jsonNode) || jsonNode == null)
            {
                return null;
            }

            if (jsonNode is not JsonValue jsonValue || !jsonValue.TryGetValue(out string? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the full, formatted type name of a Type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>The full type name.</returns>
        public static string? FullTypeName(Type? type)
        {
            if (type == null)
            {
                return null;
            }

            if (!type.IsGenericType)
            {
                string assemblyFullName = type.Assembly.FullName;
                int commaIndex = assemblyFullName.IndexOf(',');
                string assemblyName = commaIndex > 0 ? assemblyFullName.Substring(0, commaIndex) : assemblyFullName;
                return string.Concat(type.FullName, ",", assemblyName);
            }

            StringBuilder stringBuilder = new(128);
            Modify.Append(stringBuilder, type);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Retrieves the full type name of an ISerializableObject.
        /// </summary>
        /// <param name="serializableObject">The serializable object.</param>
        /// <returns>The full type name.</returns>
        public static string? FullTypeName(ISerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            return FullTypeName(serializableObject.GetType());
        }
    }
}