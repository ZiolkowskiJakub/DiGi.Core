using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static HashSet<IWrapperReference> Replace(this JsonObject jsonObject, IEnumerable<WrapperNode> wrapperNodes)
        {
            if (jsonObject == null || wrapperNodes == null || wrapperNodes.Count() == 0)
            {
                return null;
            }

            HashSet<IWrapperReference> result = new HashSet<IWrapperReference>();
            int count = jsonObject.Count;
            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < count; i++)
            {
                JsonNode jsonNode = jsonObject[i];
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (Query.IsWrapperReference(jsonObject_Temp, out IWrapperReference wrapperReference))
                    {
                        WrapperNode wrapperNode = wrapperNodes.Find(x => x.WrapperReference == wrapperReference);
                        if(wrapperNode != null)
                        {
                            jsonObject[i] = wrapperNode.JsonNode;
                            result.Add(wrapperReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    JsonArray jsonArray_Temp = (JsonArray)jsonNode;
                    HashSet<IWrapperReference> wrapperReferences = Replace(jsonArray_Temp, wrapperNodes);
                    if (wrapperReferences != null && wrapperReferences.Count != 0)
                    {
                        foreach (IWrapperReference wrapperReference in wrapperReferences)
                        {
                            result.Add(wrapperReference);
                        }

                        jsonObject[i] = jsonArray_Temp;
                    }
                }
            }

            return result;
        }

        internal static HashSet<IWrapperReference> Replace(this JsonArray jsonArray, IEnumerable<WrapperNode> wrapperNodes)
        {
            if (jsonArray == null || wrapperNodes == null || wrapperNodes.Count() == 0)
            {
                return null;
            }

            HashSet<IWrapperReference> result = new HashSet<IWrapperReference>();
            int count = jsonArray.Count;
            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < count; i++)
            {
                JsonNode jsonNode = jsonArray[i];
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (Query.IsWrapperReference(jsonObject_Temp, out IWrapperReference wrapperReference))
                    {
                        WrapperNode wrapperNode = wrapperNodes.Find(x => x.WrapperReference == wrapperReference);
                        if (wrapperNode != null)
                        {
                            jsonArray[i] = wrapperNode.JsonNode;
                            result.Add(wrapperReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    JsonArray jsonArray_Temp = (JsonArray)jsonNode;
                    HashSet<IWrapperReference> wrapperReferences = Replace(jsonArray_Temp, wrapperNodes);
                    if (wrapperReferences != null && wrapperReferences.Count != 0)
                    {
                        foreach (IWrapperReference wrapperReference in wrapperReferences)
                        {
                            result.Add(wrapperReference);
                        }

                        jsonArray[i] = jsonArray_Temp;
                    }
                }
            }

            return result;
        }
    }
}

