using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        public static HashSet<IObjectReference> ObjectReferences(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return null;
            }

            HashSet<IObjectReference> result = new HashSet<IObjectReference>();
            foreach(KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                JsonNode jsonNode = keyValuePair.Value;
                if(jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (IsObjectReference(jsonObject_Temp))
                    {
                        result.Add(Create.ObjectReference(jsonObject_Temp));
                    }
                }
                else if(jsonNode is JsonArray)
                {
                    HashSet<IObjectReference> objectReferences = ObjectReferences((JsonArray)jsonNode);
                    if(objectReferences != null)
                    {
                        foreach(IObjectReference objectReference in objectReferences)
                        {
                            result.Add(objectReference);
                        }
                    }
                }
            }

            return result;
        }

        public static HashSet<IObjectReference> ObjectReferences(this JsonArray jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            HashSet<IObjectReference> result = new HashSet<IObjectReference>();
            foreach (JsonNode jsonNode in jsonArray)
            {
                if (jsonNode is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)jsonNode;
                    if (IsObjectReference(jsonObject_Temp))
                    {
                        result.Add(Create.ObjectReference(jsonObject_Temp));
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    HashSet<IObjectReference> objectReferences = ObjectReferences((JsonArray)jsonNode);
                    if (objectReferences != null)
                    {
                        foreach (IObjectReference objectReference in objectReferences)
                        {
                            result.Add(objectReference);
                        }
                    }
                }
            }

            return result;
        }
    }
}

