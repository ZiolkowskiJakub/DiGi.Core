using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class JsonNodeWrapperCluster : ValueCluster<TypeReference, IObjectReference, JsonNodeWrapper>
    {
        protected override TypeReference GetKey_1(JsonNodeWrapper value)
        {
            return value?.ObjectReference?.TypeReference;
        }

        protected override IObjectReference GetKey_2(JsonNodeWrapper value)
        {
            return value?.ObjectReference;
        }

        public JsonNodeWrapper GetValue(IObjectReference objectReference)
        {
            if(objectReference == null)
            {
                return null;
            }

            return GetValue<JsonNodeWrapper>(objectReference.TypeReference, objectReference);
        }

        public IObjectReference Add(JsonNode jsonNode)
        {
            if (jsonNode == null)
            {
                return null;
            }

            JsonNodeWrapper jsonNodeWrapper = new JsonNodeWrapper(jsonNode);

            return Add(jsonNodeWrapper) ? jsonNodeWrapper.ObjectReference : null;
        }

        public IObjectReference Add(ISerializableObject serializableObject)
        {
            JsonObject jsonObject = serializableObject?.ToJsonObject();
            if(jsonObject == null)
            {
                return null;
            }

            return Add(jsonObject);
        }

        public JsonNode Wrap(IObjectReference objectReference)
        {
            JsonNodeWrapper jsonNodeWrapper = GetValue(objectReference);
            if(jsonNodeWrapper == null)
            {
                return null;
            }

            jsonNodeWrapper.Wrap(out HashSet<JsonNodeWrapper> jsonNodeWrappers);
            if(jsonNodeWrappers == null || jsonNodeWrappers.Count == 0)
            {
                return jsonNodeWrapper.JsonNode;
            }

            Add(jsonNodeWrapper);

            foreach (JsonNodeWrapper jsonNodeWrapper_Temp in jsonNodeWrappers)
            {
                if (Contains(jsonNodeWrapper_Temp))
                {
                    continue;
                }

                Add(jsonNodeWrapper_Temp);
            }

            return jsonNodeWrapper.JsonNode;
        }

        public List<JsonNode> Wrap(IEnumerable<IObjectReference> objectReferences)
        {
            if (objectReferences == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach (IObjectReference objectReference in objectReferences)
            {
                JsonNode jsonNode = Wrap(objectReference);
                if (jsonNode != null)
                {
                    result.Add(jsonNode);
                }
            }

            return result;
        }

        public JsonNode Unwrap(IObjectReference objectReference)
        {
            JsonNodeWrapper jsonNodeWrapper = GetValue(objectReference);
            if (jsonNodeWrapper == null)
            {
                return null;
            }

            jsonNodeWrapper = Modify.Unwrap(this, jsonNodeWrapper, out List<IObjectReference> misssingObjectReferences);
            if (jsonNodeWrapper == null) 
            {
                return null;
            }

            return jsonNodeWrapper.JsonNode;
        }

        public List<JsonNode> Unwrap(IEnumerable<IObjectReference> objectReferences)
        {
            if(objectReferences == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach (IObjectReference objectReference in objectReferences)
            {
                JsonNode jsonNode = Unwrap(objectReference);
                if (jsonNode != null)
                {
                    result.Add(jsonNode);
                }
            }

            return result;
        }

    }
}
