using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        internal static HashSet<IWrapperUniqueReference> Replace(this JsonObject jsonObject, IEnumerable<WrapperNode> wrapperNodes)
        {
            return Replace(jsonObject, wrapperNodes, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences);
        }

        internal static HashSet<IWrapperUniqueReference> Replace(this JsonObject jsonObject, IEnumerable<WrapperNode> wrapperNodes, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (jsonObject == null || wrapperNodes == null || wrapperNodes.Count() == 0)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = new HashSet<IWrapperUniqueReference>();
            int count = jsonObject.Count;
            if (count == 0)
            {
                return result;
            }

            missingWrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();
            for (int i = 0; i < count; i++)
            {
                JsonNode jsonNode = jsonObject[i];
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (Query.IsWrapperUniqueReference(jsonObject_Temp, out IWrapperUniqueReference wrapperUniqueReference))
                    {
                        WrapperNode wrapperNode = wrapperNodes.Find(x => x.WrapperUniqueReference == wrapperUniqueReference);
                        if(wrapperNode != null)
                        {
                            jsonObject[i] = wrapperNode.JsonNode;
                            result.Add(wrapperUniqueReference);
                        }
                        else
                        {
                            missingWrapperUniqueReferences.Add(wrapperUniqueReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    JsonArray jsonArray_Temp = (JsonArray)jsonNode;
                    HashSet<IWrapperUniqueReference> wrapperUniqueReferences = Replace(jsonArray_Temp, wrapperNodes, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences_Temp);
                    if (wrapperUniqueReferences != null && wrapperUniqueReferences.Count != 0)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
                        {
                            result.Add(wrapperUniqueReference);
                        }

                        jsonObject[i] = jsonArray_Temp;
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

        internal static HashSet<IWrapperUniqueReference> Replace(this JsonArray jsonArray, IEnumerable<WrapperNode> wrapperNodes)
        {
            return Replace(jsonArray, wrapperNodes, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences);
        }

        internal static HashSet<IWrapperUniqueReference> Replace(this JsonArray jsonArray, IEnumerable<WrapperNode> wrapperNodes, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences)
        {
            missingWrapperUniqueReferences = null;

            if (jsonArray == null || wrapperNodes == null || wrapperNodes.Count() == 0)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = new HashSet<IWrapperUniqueReference>();
            int count = jsonArray.Count;
            if (count == 0)
            {
                return result;
            }

            missingWrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();
            for (int i = 0; i < count; i++)
            {
                JsonNode jsonNode = jsonArray[i];
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (Query.IsWrapperUniqueReference(jsonObject_Temp, out IWrapperUniqueReference wrapperUniqueReference))
                    {
                        WrapperNode wrapperNode = wrapperNodes.Find(x => x.WrapperUniqueReference == wrapperUniqueReference);
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
                else if (jsonNode is JsonArray)
                {
                    JsonArray jsonArray_Temp = (JsonArray)jsonNode;
                    HashSet<IWrapperUniqueReference> wrapperReferences = Replace(jsonArray_Temp, wrapperNodes, out HashSet<IWrapperUniqueReference> missingWrapperUniqueReferences_Temp);
                    if (wrapperReferences != null && wrapperReferences.Count != 0)
                    {
                        foreach (IWrapperUniqueReference wrapperReference in wrapperReferences)
                        {
                            result.Add(wrapperReference);
                        }

                        jsonArray[i] = jsonArray_Temp;
                    }

                    if(missingWrapperUniqueReferences_Temp != null)
                    {
                        foreach(IWrapperUniqueReference wrapperUniqueReference_Temp in missingWrapperUniqueReferences_Temp)
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

