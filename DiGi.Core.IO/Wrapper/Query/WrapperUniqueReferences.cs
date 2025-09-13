using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static HashSet<IWrapperUniqueReference>? WrapperUniqueReferences(this JsonObject? jsonObject)
        {
            if(jsonObject == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = [];
            foreach(KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
            {
                JsonNode? jsonNode = keyValuePair.Value;
                if (jsonNode is JsonObject jsonObject_Temp)
                {
                    if (IsWrapperUniqueReference(jsonObject_Temp))
                    {
                        IWrapperUniqueReference? wrapperUniqueReference = Create.WrapperUniqueReference(jsonObject_Temp);
                        if (wrapperUniqueReference == null)
                        {
                            continue;
                        }

                        result.Add(wrapperUniqueReference);
                    }
                }
                else if (jsonNode is JsonArray jsonArray_Temp)
                {
                    HashSet<IWrapperUniqueReference>? wrapperUniqueReferences = WrapperUniqueReferences(jsonArray_Temp);
                    if (wrapperUniqueReferences != null)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
                        {
                            if (wrapperUniqueReference == null)
                            {
                                continue;
                            }

                            result.Add(wrapperUniqueReference);
                        }
                    }
                }
            }

            return result;
        }

        internal static HashSet<IWrapperUniqueReference>? WrapperUniqueReferences(this JsonArray? jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = [];
            foreach (JsonNode? jsonNode in jsonArray)
            {
                if (jsonNode is JsonObject jsonObject_Temp)
                {
                    if (IsWrapperUniqueReference(jsonObject_Temp))
                    {
                        IWrapperUniqueReference? wrapperUniqueReference = Create.WrapperUniqueReference(jsonObject_Temp);
                        if (wrapperUniqueReference == null)
                        {
                            continue;
                        }

                        result.Add(wrapperUniqueReference);
                    }
                }
                else if (jsonNode is JsonArray jsonArray_Temp)
                {
                    HashSet<IWrapperUniqueReference>? wrapperUniquReferences = WrapperUniqueReferences(jsonArray_Temp);
                    if (wrapperUniquReferences != null)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniquReferences)
                        {
                            if (wrapperUniqueReference == null)
                            {
                                continue;
                            }

                            result.Add(wrapperUniqueReference);
                        }
                    }
                }
            }

            return result;
        }
    }
}

