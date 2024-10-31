using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        public static HashSet<IObjectReference> Replace(this JsonObject jsonObject, IEnumerable<JsonNodeWrapper> jsonNodeWrappers)
        {
            if (jsonObject == null || jsonNodeWrappers == null || jsonNodeWrappers.Count() == 0)
            {
                return null;
            }

            HashSet<IObjectReference> result = new HashSet<IObjectReference>();
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
                    if (Query.IsObjectReference(jsonObject_Temp, out IObjectReference objectReference))
                    {
                        JsonNodeWrapper jsonNodeWrapper = jsonNodeWrappers.Find(x => x.ObjectReference == objectReference);
                        if(jsonNodeWrapper != null)
                        {
                            jsonObject[i] = jsonNodeWrapper.JsonNode;
                            result.Add(objectReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    JsonArray jsonArray_Temp = (JsonArray)jsonNode;
                    HashSet<IObjectReference> objectReferences = Replace(jsonArray_Temp, jsonNodeWrappers);
                    if (objectReferences != null && objectReferences.Count != 0)
                    {
                        foreach (IObjectReference objectReference in objectReferences)
                        {
                            result.Add(objectReference);
                        }

                        jsonObject[i] = jsonArray_Temp;
                    }
                }
            }

            return result;
        }

        public static HashSet<IObjectReference> Replace(this JsonArray jsonArray, IEnumerable<JsonNodeWrapper> jsonNodeWrappers)
        {
            if (jsonArray == null || jsonNodeWrappers == null || jsonNodeWrappers.Count() == 0)
            {
                return null;
            }

            HashSet<IObjectReference> result = new HashSet<IObjectReference>();
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
                    if (Query.IsObjectReference(jsonObject_Temp, out IObjectReference objectReference))
                    {
                        JsonNodeWrapper jsonNodeWrapper = jsonNodeWrappers.Find(x => x.ObjectReference == objectReference);
                        if (jsonNodeWrapper != null)
                        {
                            jsonArray[i] = jsonNodeWrapper.JsonNode;
                            result.Add(objectReference);
                        }
                    }
                }
                else if (jsonNode is JsonArray)
                {
                    JsonArray jsonArray_Temp = (JsonArray)jsonNode;
                    HashSet<IObjectReference> objectReferences = Replace(jsonArray_Temp, jsonNodeWrappers);
                    if (objectReferences != null && objectReferences.Count != 0)
                    {
                        foreach (IObjectReference objectReference in objectReferences)
                        {
                            result.Add(objectReference);
                        }

                        jsonArray[i] = jsonArray_Temp;
                    }
                }
            }

            return result;
        }
    }
}

