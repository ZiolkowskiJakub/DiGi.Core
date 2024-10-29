using DiGi.Core;
using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database
{
    public static partial class Query
    {
        public static List<Property> Properties<T>(this JsonObject jsonObject, bool includeNested) where T : IData
        {
            if (jsonObject == null)
            {
                return null;
            }

            List<Property> result = new List<Property>();

            List<JsonObject> jsonObjects_Nested = includeNested ? new List<JsonObject>() : null;

            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                JsonNode jsonNode = keyValuePair.Value;
                if(jsonNode == null)
                {
                    continue;
                }

                if(jsonObjects_Nested != null)
                {
                    System.Text.Json.JsonValueKind jsonValueKind = jsonNode.GetValueKind();

                    if (jsonValueKind == System.Text.Json.JsonValueKind.Object)
                    {
                        jsonObjects_Nested.Add(jsonNode.AsObject());
                    }
                    else if (jsonValueKind == System.Text.Json.JsonValueKind.Array)
                    {
                        JsonArray jsonArray = jsonNode.AsArray()?.Flatten();
                        if (jsonArray != null)
                        {
                            foreach (JsonNode jsonNode_JsonArray in jsonArray)
                            {
                                if (jsonNode_JsonArray?.GetValueKind() != System.Text.Json.JsonValueKind.Object)
                                {
                                    continue;
                                }

                                jsonObjects_Nested.Add(jsonNode_JsonArray.AsObject());
                            }
                        }
                    }
                }

                IData data = Create.Data(jsonNode);
                if(data == null)
                {
                    continue;
                }

                if(!(data is T))
                {
                    continue;
                }

                result.Add(new Property(keyValuePair.Key, data));
            }

            if(jsonObjects_Nested != null)
            {
                foreach(JsonObject jsonObject_Nested in jsonObjects_Nested)
                {
                    List<Property> properties = Properties<T>(jsonObject_Nested, includeNested);
                    if(properties != null && properties.Count != 0)
                    {
                        result.AddRange(properties);
                    }
                }
            }

            return result;
        }
    }
}

