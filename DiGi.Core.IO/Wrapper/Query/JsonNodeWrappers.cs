using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Enums;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        public static HashSet<JsonNodeWrapper> JsonNodeWrappers<TJsonNode>(this JsonObject jsonObject, WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if (jsonObject == null)
            {
                return null;
            }

            HashSet<JsonNodeWrapper> result = new HashSet<JsonNodeWrapper>();
            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                JsonNode jsonNode = keyValuePair.Value;
                if(jsonNode == null)
                {
                    continue;
                }

                if (jsonNode is JsonArray)
                {
                    HashSet<JsonNodeWrapper> jsonNodeWrappers = JsonNodeWrappers<TJsonNode>((JsonArray)jsonNode);
                    if(jsonNodeWrappers != null)
                    {
                        foreach(JsonNodeWrapper jsonNodeWrapper in jsonNodeWrappers)
                        {
                            result.Add(jsonNodeWrapper, wrapState);
                        }
                    }
                }

                if (!(jsonNode is TJsonNode))
                {
                    continue;
                }

                result.Add(new JsonNodeWrapper(jsonNode), wrapState);
            }

            return result;
        }

        public static HashSet<JsonNodeWrapper> JsonNodeWrappers<TJsonNode>(this JsonArray jsonArray, WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if(jsonArray == null)
            {
                return null;
            }

            HashSet<JsonNodeWrapper> result = new HashSet<JsonNodeWrapper>();

            foreach (JsonNode jsonNode in jsonArray)
            {
                if (jsonNode is JsonArray)
                {
                    HashSet<JsonNodeWrapper> jsonNodeWrappers = JsonNodeWrappers<TJsonNode>((JsonArray)jsonNode);
                    if (jsonNodeWrappers != null)
                    {
                        foreach (JsonNodeWrapper jsonNodeWrapper in jsonNodeWrappers)
                        {
                            result.Add(jsonNodeWrapper, wrapState);
                        }
                    }
                }

                if (!(jsonNode is TJsonNode))
                {
                    continue;
                }

                result.Add(new JsonNodeWrapper(jsonNode), wrapState);
            }

            return result;
        }
    }
}

