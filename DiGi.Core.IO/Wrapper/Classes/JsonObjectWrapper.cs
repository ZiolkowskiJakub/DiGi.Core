using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Enums;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class JsonNodeWrapper : IObject
    {
        private IObjectReference objectReference;
        private JsonNode jsonNode;

        public JsonNodeWrapper(IObjectReference objectReference, JsonObject jsonObject)
        {
            this.objectReference = objectReference;
            jsonNode = jsonObject;
        }

        public JsonNodeWrapper(ObjectUniqueIdReference objectUniqueIdReference, JsonArray jsonArray)
        {
            objectReference = objectUniqueIdReference;
            jsonNode = jsonArray;
        }

        public JsonNodeWrapper(ObjectUniqueIdReference objectUniqueIdReference, JsonValue jsonValue)
        {
            objectReference = objectUniqueIdReference;
            jsonNode = jsonValue;
        }

        public JsonNodeWrapper(JsonNode jsonNode)
        {
            this.jsonNode = jsonNode;
            objectReference = jsonNode.ObjectReference();
        }

        public IObjectReference ObjectReference
        {
            get
            {
                return objectReference;
            }
        }

        public JsonNode JsonNode
        {
            get
            {
                return jsonNode?.DeepClone();
            }
        }

        public HashSet<IObjectReference> GetObjectReferences()
        {
            if (jsonNode == null || jsonNode is JsonValue)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).ObjectReferences();
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).ObjectReferences();
            }

            return null;
        }

        public HashSet<JsonNodeWrapper> GetJsonNodeWrappers<TJsonNode>(WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if (jsonNode == null || jsonNode is JsonValue)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).JsonNodeWrappers<TJsonNode>(wrapState);
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).JsonNodeWrappers<TJsonNode>(wrapState);
            }

            return null;
        }

        public override bool Equals(object @object)
        {
            JsonNodeWrapper jsonNodeWrapper = @object as JsonNodeWrapper;
            if (jsonNodeWrapper == null)
            {
                return false;
            }

            return objectReference?.ToString() == jsonNodeWrapper.objectReference.ToString();
        }

        public override int GetHashCode()
        {
            return objectReference.ToString().GetHashCode();
        }

        public bool IsObjectReference()
        {
            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).IsObjectReference();
            }

            return false;
        }

        public bool IsWrapped()
        {
            return IsWrapped(out HashSet<JsonNodeWrapper> jsonNodeWrappers_Unwrapped);
        }

        public bool IsWrapped(out HashSet<JsonNodeWrapper> jsonNodeWrappers_Unwrapped)
        {
            jsonNodeWrappers_Unwrapped = GetJsonNodeWrappers<JsonObject>(WrapState.Unwrapped);
            return jsonNodeWrappers_Unwrapped == null || jsonNodeWrappers_Unwrapped.Count == 0;
        }

        public bool IsUnwrapped()
        {
            return IsUnwrapped(out HashSet<JsonNodeWrapper> jsonNodeWrappers_Wrapped);
        }

        public bool IsUnwrapped(out HashSet<JsonNodeWrapper> jsonNodeWrappers_Wrapped)
        {
            jsonNodeWrappers_Wrapped = GetJsonNodeWrappers<JsonObject>(WrapState.Wrapped);
            return jsonNodeWrappers_Wrapped == null || jsonNodeWrappers_Wrapped.Count == 0;
        }

        public bool Wrap(out HashSet<JsonNodeWrapper> jsonNodeWrappers)
        {
            jsonNodeWrappers = null;
            if(jsonNode == null)
            {
                return false;
            }

            if (jsonNode is JsonValue)
            {
                return false;
            }

            Dictionary<IObjectReference, JsonObject> dictionary = new Dictionary<IObjectReference, JsonObject>();
            if (jsonNode is JsonObject)
            {
                jsonNode = Query.Wrap((JsonObject)jsonNode, dictionary);
            }
            else if(jsonNode is JsonArray)
            {
                jsonNode = Query.Wrap((JsonArray)jsonNode, dictionary);
            }

            if(dictionary == null || dictionary.Count == 0)
            {
                return false;
            }

            jsonNodeWrappers = new HashSet<JsonNodeWrapper>();
            foreach (KeyValuePair<IObjectReference, JsonObject> keyValuePair in dictionary)
            {
                jsonNodeWrappers.Add(new JsonNodeWrapper(keyValuePair.Key, keyValuePair.Value));
            }

            return true;
        }

        public bool Unwrap(JsonNodeWrapperCluster jsonNodeWrapperCluster, out List<IObjectReference> missingObjectReferences)
        {
            missingObjectReferences = null;

            if (jsonNode == null)
            {
                return false;
            }

            if (jsonNode is JsonValue)
            {
                return false;
            }

            JsonNodeWrapper jsonNodeWrapper = Modify.Unwrap(jsonNodeWrapperCluster, this, out missingObjectReferences);
            if(jsonNodeWrapper == null)
            {
                return false;
            }

            jsonNode = jsonNodeWrapper.JsonNode;

            return missingObjectReferences == null || missingObjectReferences.Count == 0;
        }
    }
}
