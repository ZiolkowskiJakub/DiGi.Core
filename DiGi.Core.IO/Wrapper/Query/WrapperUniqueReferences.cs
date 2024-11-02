using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static HashSet<IWrapperUniqueReference> WrapperUniqueReferences(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = new HashSet<IWrapperUniqueReference>();
            foreach(KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                JsonNode jsonNode = keyValuePair.Value;
                if(jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (IsWrapperUniqueReference(jsonObject_Temp))
                    {
                        result.Add(Create.WrapperUniqueReference(jsonObject_Temp));
                    }
                }
                else if(jsonNode is JsonArray)
                {
                    HashSet<IWrapperUniqueReference> wrapperUniqueReferences = WrapperUniqueReferences((JsonArray)jsonNode);
                    if(wrapperUniqueReferences != null)
                    {
                        foreach(IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
                        {
                            result.Add(wrapperUniqueReference);
                        }
                    }
                }
            }

            return result;
        }

        internal static HashSet<IWrapperUniqueReference> WrapperUniqueReferences(this JsonArray jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> result = new HashSet<IWrapperUniqueReference>();
            foreach (JsonNode jsonNode in jsonArray)
            {
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (IsWrapperUniqueReference(jsonObject_Temp))
                    {
                        result.Add(Create.WrapperUniqueReference(jsonObject_Temp));
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    HashSet<IWrapperUniqueReference> wrapperUniquReferences = WrapperUniqueReferences((JsonArray)jsonNode);
                    if (wrapperUniquReferences != null)
                    {
                        foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniquReferences)
                        {
                            result.Add(wrapperUniqueReference);
                        }
                    }
                }
            }

            return result;
        }
    }
}

