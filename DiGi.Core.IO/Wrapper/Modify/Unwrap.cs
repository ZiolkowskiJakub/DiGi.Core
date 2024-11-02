using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static WrapperNode Unwrap(this WrapperNodeCluster wrapperNodeCluster, WrapperNode wrapperNode, out List<IWrapperReference> missingWrapperReferences)
        {
            missingWrapperReferences = null;
            if (wrapperNode == null)
            {
                return null;
            }

            if(wrapperNode.IsWrapperReference())
            {
                return wrapperNode;
            }

            if(wrapperNode.IsUnwrapped(out HashSet<WrapperNode> wrapperNodes_Wrapped))
            {
                return wrapperNode;
            }

            if(wrapperNodes_Wrapped == null || wrapperNodes_Wrapped.Count == 0)
            {
                return wrapperNode;
            }

            List<WrapperNode> wrapperNodes_Unwrapped = new List<WrapperNode>();
            foreach(WrapperNode wrapperNode_Wrapped in wrapperNodes_Wrapped)
            {
                WrapperNode wrapperNode_Unwrapped = Unwrap(wrapperNodeCluster, wrapperNode_Wrapped, out List<IWrapperReference> missingWrapperReferences_Temp);
                if(wrapperNode_Unwrapped != null)
                {
                    continue;
                }

                wrapperNodes_Unwrapped.Add(wrapperNode_Unwrapped);
            }

            JsonNode jsonNode = wrapperNode.JsonNode;
            if(jsonNode is JsonObject)
            {
                JsonObject jsonObject = (JsonObject)jsonNode;
                Replace(jsonObject, wrapperNodes_Unwrapped);
                jsonNode = jsonObject;
            }
            else if(jsonNode is JsonArray)
            {
                JsonArray jsonArray = (JsonArray)jsonNode;
                Replace(jsonArray, wrapperNodes_Unwrapped);
                jsonNode = jsonArray;
            }

            WrapperNode result = new WrapperNode(jsonNode);
            wrapperNodeCluster.Add(result);

            return result;
        }

        internal static JsonObject Unwrap(this WrapperNodeCluster wrapperNodeCluster, JsonObject jsonObject, out List<IWrapperReference> missingWrapperReferences)
        {
            missingWrapperReferences = null;

            if (wrapperNodeCluster == null || jsonObject == null)
            {
                return null;
            }

            WrapperNode wrapperNode = Unwrap(wrapperNodeCluster, new WrapperNode(jsonObject), out missingWrapperReferences);

            return wrapperNode.JsonNode as JsonObject;
        }

        internal static JsonArray Unwrap(this WrapperNodeCluster wrapperNodeCluster, JsonArray jsonArray, out List<IWrapperReference> missingWrapperReferences)
        {
            missingWrapperReferences = null;

            if (wrapperNodeCluster == null || jsonArray == null)
            {
                return null;
            }

            WrapperNode wrapperNode = Unwrap(wrapperNodeCluster, new WrapperNode(jsonArray), out missingWrapperReferences);

            return wrapperNode.JsonNode as JsonArray;
        }
    }
}

