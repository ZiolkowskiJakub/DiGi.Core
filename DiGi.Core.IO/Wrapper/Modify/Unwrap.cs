using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static WrapperNode Unwrap(this WrapperNodeCluster wrapperNodeCluster, WrapperNode wrapperNode, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;
            if (wrapperNode == null)
            {
                return null;
            }

            WrapperNode wrapperNode_Temp = wrapperNode;

            missingWrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();

            if (wrapperNode_Temp.IsWrapperUniqueReference())
            {
                wrapperNode_Temp = wrapperNodeCluster.GetValue(wrapperNode_Temp.WrapperUniqueReference);
                if(wrapperNode_Temp == null)
                {
                    missingWrapperUniqueReferences.Add(wrapperNode.WrapperUniqueReference);
                    return null;
                }
            }

            if(wrapperNode_Temp.IsUnwrapped(out HashSet<WrapperNode> wrapperNodes_Wrapped))
            {
                return wrapperNode_Temp;
            }

            if(wrapperNodes_Wrapped == null || wrapperNodes_Wrapped.Count == 0)
            {
                return wrapperNode_Temp;
            }

            HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences_Temp = null;

            List<WrapperNode> wrapperNodes_Unwrapped = new List<WrapperNode>();
            foreach(WrapperNode wrapperNode_Wrapped in wrapperNodes_Wrapped)
            {
                WrapperNode wrapperNode_Unwrapped = Unwrap(wrapperNodeCluster, wrapperNode_Wrapped, out missingWrapperUniqueReferences_Temp);

                if(missingWrapperUniqueReferences_Temp != null)
                {
                    foreach(IWrapperUniqueReference wrapperUniqueReference in missingWrapperUniqueReferences_Temp)
                    {
                        missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                    }
                }

                if (wrapperNode_Unwrapped == null)
                {
                    continue;
                }

                wrapperNodes_Unwrapped.Add(wrapperNode_Unwrapped);
            }

            JsonNode jsonNode = wrapperNode_Temp.JsonNode;
            if(jsonNode is JsonObject)
            {
                JsonObject jsonObject = (JsonObject)jsonNode;
                Replace(jsonObject, wrapperNodes_Unwrapped, out missingWrapperUniqueReferences_Temp);
                jsonNode = jsonObject;
            }
            else if(jsonNode is JsonArray)
            {
                JsonArray jsonArray = (JsonArray)jsonNode;
                Replace(jsonArray, wrapperNodes_Unwrapped, out missingWrapperUniqueReferences_Temp);
                jsonNode = jsonArray;
            }

            if (missingWrapperUniqueReferences_Temp != null)
            {
                foreach (IWrapperUniqueReference wrapperUniqueReference in missingWrapperUniqueReferences_Temp)
                {
                    missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                }
            }

            WrapperNode result = new WrapperNode(jsonNode);
            wrapperNodeCluster.Add(result);

            return result;
        }

        internal static JsonObject Unwrap(this WrapperNodeCluster wrapperNodeCluster, JsonObject jsonObject, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (wrapperNodeCluster == null || jsonObject == null)
            {
                return null;
            }

            WrapperNode wrapperNode = Unwrap(wrapperNodeCluster, new WrapperNode(jsonObject), out missingWrapperUniqueReferences);

            return wrapperNode.JsonNode as JsonObject;
        }

        internal static JsonArray Unwrap(this WrapperNodeCluster wrapperNodeCluster, JsonArray jsonArray, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (wrapperNodeCluster == null || jsonArray == null)
            {
                return null;
            }

            WrapperNode wrapperNode = Unwrap(wrapperNodeCluster, new WrapperNode(jsonArray), out missingWrapperUniqueReferences);

            return wrapperNode.JsonNode as JsonArray;
        }
    }
}

