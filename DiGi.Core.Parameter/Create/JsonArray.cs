using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter
{
    /// <summary>Provides factory methods for creating parameter-related objects.</summary>
    public static partial class Create
    {
        /// <summary>Converts a collection of types to a JsonArray.</summary>
        /// <param name="types">The collection of types to convert.</param>
        /// <returns>A JsonArray containing the full type names, or null if the input is null.</returns>
        public static JsonArray? JsonArray(this IEnumerable<Type>? types)
        {
            if (types == null)
            {
                return null;
            }

            JsonArray result = [];
            foreach (Type type in types)
            {
                string? fullTypeName = Core.Query.FullTypeName(type);
                if (string.IsNullOrWhiteSpace(fullTypeName))
                {
                    continue;
                }

                result.Add(fullTypeName);
            }

            return result;
        }
    }
}