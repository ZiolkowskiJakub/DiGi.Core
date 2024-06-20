using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter
{
    public static partial class Create
    {
        public static List<Type> Types(this JsonArray jsonArray)
        {
            if(jsonArray == null)
            {
                return null;
            }

            List<Type> result = new List<Type>();
            foreach(JsonNode? jsonNode in jsonArray)
            {
                if(jsonNode == null)
                {
                    continue;
                }

                if(jsonNode.GetValueKind() != System.Text.Json.JsonValueKind.String)
                {
                    continue;
                }

                string fullTypeName = jsonNode.GetValue<string>();
                if(string.IsNullOrWhiteSpace(fullTypeName))
                {
                    continue;
                }

                Type type = Core.Query.Type(fullTypeName);
                if(type == null)
                {
                    continue;
                }

                result.Add(type);
            }

            return result;
        }
    }

}
