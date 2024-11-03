using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Enums;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static HashSet<WrapperNode> WrapperNodes<TJsonNode>(this JsonObject jsonObject, bool includeNested , WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if (jsonObject == null)
            {
                return null;
            }

            HashSet<WrapperNode> result = new HashSet<WrapperNode>();
            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                JsonNode jsonNode = keyValuePair.Value;
                if (jsonNode == null)
                {
                    continue;
                }

                if (jsonNode is JsonArray)
                {
                    HashSet<WrapperNode> wrapperNodes = WrapperNodes<TJsonNode>((JsonArray)jsonNode, includeNested, wrapState);
                    if (wrapperNodes != null)
                    {
                        foreach (WrapperNode wrapperNode in wrapperNodes)
                        {
                            result.Add(wrapperNode, wrapState);
                        }
                    }
                }

                if (!(jsonNode is TJsonNode))
                {
                    continue;
                }

                if(jsonNode is JsonObject && includeNested)
                {
                    HashSet<WrapperNode> wrapperNodes = WrapperNodes<TJsonNode>((JsonObject)jsonNode, includeNested, wrapState);
                    if(wrapperNodes != null)
                    {
                        foreach(WrapperNode wrapperNode in wrapperNodes)
                        {
                            result.Add(new WrapperNode(jsonNode), wrapState);
                        }
                    }
                }

                result.Add(new WrapperNode(jsonNode), wrapState);
            }

            return result;
        }

        internal static HashSet<WrapperNode> WrapperNodes<TJsonNode>(this JsonArray jsonArray, bool includeNested, WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if (jsonArray == null)
            {
                return null;
            }

            HashSet<WrapperNode> result = new HashSet<WrapperNode>();

            foreach (JsonNode jsonNode in jsonArray)
            {
                if (jsonNode is JsonArray)
                {
                    HashSet<WrapperNode> wrapperNodes = WrapperNodes<TJsonNode>((JsonArray)jsonNode, includeNested, wrapState);
                    if (wrapperNodes != null)
                    {
                        foreach (WrapperNode wrapperNode in wrapperNodes)
                        {
                            result.Add(wrapperNode, wrapState);
                        }
                    }
                }

                if (!(jsonNode is TJsonNode))
                {
                    continue;
                }

                if (jsonNode is JsonObject && includeNested)
                {
                    HashSet<WrapperNode> wrapperNodes = WrapperNodes<TJsonNode>((JsonObject)jsonNode, includeNested, wrapState);
                    if (wrapperNodes != null)
                    {
                        foreach (WrapperNode wrapperNode in wrapperNodes)
                        {
                            result.Add(new WrapperNode(jsonNode), wrapState);
                        }
                    }
                }

                result.Add(new WrapperNode(jsonNode), wrapState);
            }

            return result;
        }

        internal static HashSet<WrapperNode> WrapperNodes<TJsonNode>(this JsonObject jsonObject, WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            return WrapperNodes<TJsonNode>(jsonObject, false, wrapState);
        }

        internal static HashSet<WrapperNode> WrapperNodes<TJsonNode>(this JsonArray jsonArray, WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            return WrapperNodes<TJsonNode>(jsonArray, false, wrapState);
        }
    }
}

