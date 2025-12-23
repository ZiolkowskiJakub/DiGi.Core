using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static WrapperNode? Unwrap(this WrapperNodeCluster? wrapperNodeCluster, WrapperNode? wrapperNode, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;
            if (wrapperNode?.JsonNode == null || wrapperNodeCluster == null)
            {
                return null;
            }

            if (wrapperNode.JsonNode is JsonValue)
            {
                return new WrapperNode(wrapperNode.JsonNode);
            }

            WrapperNode? wrapperNode_Temp = wrapperNode!;

            missingWrapperUniqueReferences = [];

            if (wrapperNode_Temp.IsWrapperUniqueReference())
            {
                wrapperNode_Temp = wrapperNodeCluster.GetValue(wrapperNode_Temp.WrapperUniqueReference);
                if (wrapperNode_Temp == null)
                {
                    IWrapperUniqueReference? wrapperUniqueReference = wrapperNode.WrapperUniqueReference;
                    if (wrapperUniqueReference != null)
                    {
                        missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                    }

                    return null;
                }
            }

            if (wrapperNode_Temp.IsUnwrapped(out HashSet<WrapperNode>? wrapperNodes_Wrapped))
            {
                return wrapperNode_Temp;
            }

            if (wrapperNodes_Wrapped == null || wrapperNodes_Wrapped.Count == 0)
            {
                return wrapperNode_Temp;
            }

            List<WrapperNode> wrapperNodes_Unwrapped = [];

            HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences_Temp;
            foreach (WrapperNode wrapperNode_Wrapped in wrapperNodes_Wrapped)
            {
                WrapperNode? wrapperNode_Unwrapped = Unwrap(wrapperNodeCluster, wrapperNode_Wrapped, out missingWrapperUniqueReferences_Temp);

                if (missingWrapperUniqueReferences_Temp != null)
                {
                    foreach (IWrapperUniqueReference wrapperUniqueReference in missingWrapperUniqueReferences_Temp)
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

            JsonNode? jsonNode = wrapperNode_Temp.JsonNode;

            WrapperNode? result;
            if (jsonNode is JsonObject jsonObject)
            {
                Replace(jsonObject, wrapperNodes_Unwrapped, out missingWrapperUniqueReferences_Temp);
                result = new WrapperNode(wrapperNode.WrapperUniqueReference, jsonObject);
            }
            else if (jsonNode is JsonArray jsonArray)
            {
                Replace(jsonArray, wrapperNodes_Unwrapped, out missingWrapperUniqueReferences_Temp);
                result = new WrapperNode(wrapperNode.WrapperUniqueReference as WrapperUniqueIdReference, jsonArray);
            }
            else
            {
                throw new System.NotImplementedException();
            }

            if (missingWrapperUniqueReferences_Temp != null)
            {
                foreach (IWrapperUniqueReference wrapperUniqueReference in missingWrapperUniqueReferences_Temp)
                {
                    missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                }
            }

            wrapperNodeCluster.Add(result);

            return result;
        }

        internal static JsonObject? Unwrap(this WrapperNodeCluster? wrapperNodeCluster, JsonObject? jsonObject, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (wrapperNodeCluster == null || jsonObject == null)
            {
                return null;
            }

            WrapperNode? wrapperNode = Unwrap(wrapperNodeCluster, new WrapperNode(jsonObject), out missingWrapperUniqueReferences);

            return wrapperNode?.JsonNode as JsonObject;
        }

        internal static JsonArray? Unwrap(this WrapperNodeCluster? wrapperNodeCluster, JsonArray? jsonArray, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (wrapperNodeCluster == null || jsonArray == null)
            {
                return null;
            }

            WrapperNode? wrapperNode = Unwrap(wrapperNodeCluster, new WrapperNode(jsonArray), out missingWrapperUniqueReferences);

            return wrapperNode?.JsonNode as JsonArray;
        }
    }
}

