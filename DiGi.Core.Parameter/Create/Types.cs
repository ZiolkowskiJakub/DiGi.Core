using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter
{
    /// <summary>Provides factory methods for creating parameter-related objects.</summary>
    public static partial class Create
    {
        /// <summary>Converts a JsonArray to a list of types.</summary>
        /// <param name="jsonArray">The JsonArray to convert.</param>
        /// <returns>A list of types, or null if the input is null.</returns>
        public static List<Type>? Types(this JsonArray? jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            List<Type> result = [];
            foreach (JsonNode? jsonNode in jsonArray)
            {
                if (jsonNode == null)
                {
                    continue;
                }

                if (jsonNode.GetValueKind() != System.Text.Json.JsonValueKind.String)
                {
                    continue;
                }

                string fullTypeName = jsonNode.GetValue<string>();
                if (string.IsNullOrWhiteSpace(fullTypeName))
                {
                    continue;
                }

                Type? type = Core.Query.Type(fullTypeName);
                if (type == null)
                {
                    continue;
                }

                result.Add(type);
            }

            return result;
        }
    }
}