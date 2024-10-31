using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Modify
    {
        public static JsonNodeWrapper Unwrap(this JsonNodeWrapperCluster jsonNodeWrapperCluster, JsonNodeWrapper jsonNodeWrapper, out List<IObjectReference> missingObjectReferences)
        {
            missingObjectReferences = null;
            if (jsonNodeWrapper == null)
            {
                return null;
            }

            if(jsonNodeWrapper.IsObjectReference())
            {
                return jsonNodeWrapper;
            }

            if(jsonNodeWrapper.IsUnwrapped(out HashSet<JsonNodeWrapper> jsonNodeWrappers_Wrapped))
            {
                return jsonNodeWrapper;
            }

            if(jsonNodeWrappers_Wrapped == null || jsonNodeWrappers_Wrapped.Count == 0)
            {
                return jsonNodeWrapper;
            }

            List<JsonNodeWrapper> jsonNodeWrappers_Unwrapped = new List<JsonNodeWrapper>();
            foreach(JsonNodeWrapper jsonNodeWrapper_Wrapped in jsonNodeWrappers_Wrapped)
            {
                JsonNodeWrapper jsonNodeWrapper_Unwrapped = Unwrap(jsonNodeWrapperCluster, jsonNodeWrapper_Wrapped, out List<IObjectReference> missingObjectReferences_Temp);
                if(jsonNodeWrapper_Unwrapped != null)
                {
                    continue;
                }

                jsonNodeWrappers_Unwrapped.Add(jsonNodeWrapper_Unwrapped);
            }

            JsonNode jsonNode = jsonNodeWrapper.JsonNode;
            if(jsonNode is JsonObject)
            {
                JsonObject jsonObject = (JsonObject)jsonNode;
                Replace(jsonObject, jsonNodeWrappers_Unwrapped);
                jsonNode = jsonObject;
            }
            else if(jsonNode is JsonArray)
            {
                JsonArray jsonArray = (JsonArray)jsonNode;
                Replace(jsonArray, jsonNodeWrappers_Unwrapped);
                jsonNode = jsonArray;
            }

            JsonNodeWrapper result = new JsonNodeWrapper(jsonNode);
            jsonNodeWrapperCluster.Add(result);

            return result;
        }

        public static JsonObject Unwrap(this JsonNodeWrapperCluster jsonNodeWrapperCluster, JsonObject jsonObject, out List<IObjectReference> missingObjectReferences)
        {
            missingObjectReferences = null;

            if (jsonNodeWrapperCluster == null || jsonObject == null)
            {
                return null;
            }

            JsonNodeWrapper jsonNodeWrapper = Unwrap(jsonNodeWrapperCluster, new JsonNodeWrapper(jsonObject), out missingObjectReferences);

            return jsonNodeWrapper.JsonNode as JsonObject;
        }

        public static JsonArray Unwrap(this JsonNodeWrapperCluster jsonNodeWrapperCluster, JsonArray jsonArray, out List<IObjectReference> missingObjectReferences)
        {
            missingObjectReferences = null;

            if (jsonNodeWrapperCluster == null || jsonArray == null)
            {
                return null;
            }

            JsonNodeWrapper jsonNodeWrapper = Unwrap(jsonNodeWrapperCluster, new JsonNodeWrapper(jsonArray), out missingObjectReferences);

            return jsonNodeWrapper.JsonNode as JsonArray;
        }
    }
}

