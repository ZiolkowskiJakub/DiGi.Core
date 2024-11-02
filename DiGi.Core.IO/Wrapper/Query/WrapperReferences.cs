using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static HashSet<IWrapperReference> WrapperReferences(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return null;
            }

            HashSet<IWrapperReference> result = new HashSet<IWrapperReference>();
            foreach(KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                JsonNode jsonNode = keyValuePair.Value;
                if(jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (IsWrapperReference(jsonObject_Temp))
                    {
                        result.Add(Create.WrapperReference(jsonObject_Temp));
                    }
                }
                else if(jsonNode is JsonArray)
                {
                    HashSet<IWrapperReference> wrapperReferences = WrapperReferences((JsonArray)jsonNode);
                    if(wrapperReferences != null)
                    {
                        foreach(IWrapperReference wrapperReference in wrapperReferences)
                        {
                            result.Add(wrapperReference);
                        }
                    }
                }
            }

            return result;
        }

        internal static HashSet<IWrapperReference> WrapperReferences(this JsonArray jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            HashSet<IWrapperReference> result = new HashSet<IWrapperReference>();
            foreach (JsonNode jsonNode in jsonArray)
            {
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (IsWrapperReference(jsonObject_Temp))
                    {
                        result.Add(Create.WrapperReference(jsonObject_Temp));
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    HashSet<IWrapperReference> wrapperReferences = WrapperReferences((JsonArray)jsonNode);
                    if (wrapperReferences != null)
                    {
                        foreach (IWrapperReference wrapperReference in wrapperReferences)
                        {
                            result.Add(wrapperReference);
                        }
                    }
                }
            }

            return result;
        }
    }
}

