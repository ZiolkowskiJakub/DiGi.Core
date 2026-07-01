using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static HashSet<IWrapperUniqueReference>? Replace(this JsonObject jsonObject, IEnumerable<WrapperNode> wrapperNodes)
        {
            return Replace(jsonObject, wrapperNodes, out HashSet<IWrapperUniqueReference>? _);
        }

        internal static HashSet<IWrapperUniqueReference>? Replace(this JsonObject jsonObject, IEnumerable<WrapperNode> wrapperNodes, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (jsonObject == null || wrapperNodes == null)
            {
                return null;
            }

            Dictionary<IWrapperUniqueReference, WrapperNode> wrapperNodesByUniqueReference = [];
            foreach (WrapperNode wrapperNode_Temp in wrapperNodes)
            {
                if (wrapperNode_Temp?.WrapperUniqueReference is null)
                {
                    continue;
                }

                wrapperNodesByUniqueReference[wrapperNode_Temp.WrapperUniqueReference] = wrapperNode_Temp;
            }

            if (wrapperNodesByUniqueReference.Count == 0)
            {
                return null;
            }

            missingWrapperUniqueReferences = [];

            HashSet<string> names = [];
            foreach (KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
            {
                names.Add(keyValuePair.Key);
            }

            HashSet<IWrapperUniqueReference> result = [];
            foreach (string name in names)
            {
                if (!jsonObject.TryGetPropertyValue(name, out JsonNode? jsonNode))
                {
                    continue;
                }

                if (jsonNode is JsonObject jsonObject_Temp)
                {
                    if (Query.IsWrapperUniqueReference(jsonObject_Temp, out IWrapperUniqueReference? wrapperUniqueReference) && wrapperUniqueReference != null)
                    {
                        wrapperNodesByUniqueReference.TryGetValue(wrapperUniqueReference, out WrapperNode? wrapperNode);
                        if (wrapperNode != null)
                        {
                            jsonObject[name] = wrapperNode.JsonNode;
                            result.Add(wrapperUniqueReference);
                        }
                        else
                        {
                            missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray jsonArray_Temp)
                {
                    HashSet<IWrapperUniqueReference>? wrapperUniqueReferences = Replace(jsonArray_Temp, wrapperNodes, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences_Temp);
                    if (wrapperUniqueReferences != null && wrapperUniqueReferences.Count != 0)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
                        {
                            result.Add(wrapperUniqueReference);
                        }

                        jsonObject[name] = jsonArray_Temp;
                    }

                    if (missingWrapperUniqueReferences_Temp != null)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference_Temp in missingWrapperUniqueReferences_Temp)
                        {
                            missingWrapperUniqueReferences.Add(wrapperUniqueReference_Temp);
                        }
                    }
                }
            }

            return result;
        }

        internal static HashSet<IWrapperUniqueReference>? Replace(this JsonArray? jsonArray, IEnumerable<WrapperNode>? wrapperNodes)
        {
            return Replace(jsonArray, wrapperNodes, out HashSet<IWrapperUniqueReference>? _);
        }

        internal static HashSet<IWrapperUniqueReference>? Replace(this JsonArray? jsonArray, IEnumerable<WrapperNode>? wrapperNodes, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (jsonArray == null || wrapperNodes == null)
            {
                return null;
            }

            Dictionary<IWrapperUniqueReference, WrapperNode> wrapperNodesByUniqueReference = [];
            foreach (WrapperNode wrapperNode_Temp in wrapperNodes)
            {
                if (wrapperNode_Temp?.WrapperUniqueReference is null)
                {
                    continue;
                }

                wrapperNodesByUniqueReference[wrapperNode_Temp.WrapperUniqueReference] = wrapperNode_Temp;
            }

            if (wrapperNodesByUniqueReference.Count == 0)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = [];
            int count = jsonArray.Count;
            if (count == 0)
            {
                return result;
            }

            missingWrapperUniqueReferences = [];
            for (int i = 0; i < count; i++)
            {
                JsonNode? jsonNode = jsonArray[i];
                if (jsonNode is JsonObject jsonObject_Temp)
                {
                    if (Query.IsWrapperUniqueReference(jsonObject_Temp, out IWrapperUniqueReference? wrapperUniqueReference) && wrapperUniqueReference != null)
                    {
                        wrapperNodesByUniqueReference.TryGetValue(wrapperUniqueReference, out WrapperNode? wrapperNode);
                        if (wrapperNode != null)
                        {
                            jsonArray[i] = wrapperNode.JsonNode;
                            result.Add(wrapperUniqueReference);
                        }
                        else
                        {
                            missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray jsonArray_Temp)
                {
                    HashSet<IWrapperUniqueReference>? wrapperReferences = Replace(jsonArray_Temp, wrapperNodes, out HashSet<IWrapperUniqueReference>? missingWrapperUniqueReferences_Temp);
                    if (wrapperReferences != null && wrapperReferences.Count != 0)
                    {
                        foreach (IWrapperUniqueReference wrapperReference in wrapperReferences)
                        {
                            result.Add(wrapperReference);
                        }

                        jsonArray[i] = jsonArray_Temp;
                    }

                    if (missingWrapperUniqueReferences_Temp != null)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference_Temp in missingWrapperUniqueReferences_Temp)
                        {
                            missingWrapperUniqueReferences.Add(wrapperUniqueReference_Temp);
                        }
                    }
                }
            }

            return result;
        }
    }
}