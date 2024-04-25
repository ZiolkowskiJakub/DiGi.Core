using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameters
{
    public static partial class Create
    {
        public static JsonArray JsonArray(this IEnumerable<Type> types)
        {
            if(types == null)
            {
                return null;
            }

            JsonArray result = new JsonArray();
            foreach(Type type in types)
            {
                string fullTypeName = Core.Query.FullTypeName(type);
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
