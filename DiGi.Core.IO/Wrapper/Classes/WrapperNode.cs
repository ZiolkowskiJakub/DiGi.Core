using DiGi.Core.IO.Wrapper.Enums;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperNode : IWrapperObject
    {
        private IWrapperReference wrapperReference;
        private JsonNode jsonNode;

        public WrapperNode(IWrapperReference wrapperReference, JsonObject jsonObject)
        {
            this.wrapperReference = wrapperReference;
            jsonNode = jsonObject;
        }

        public WrapperNode(WrapperUniqueIdReference wrapperUniqueIdReference, JsonArray jsonArray)
        {
            wrapperReference = wrapperUniqueIdReference;
            jsonNode = jsonArray;
        }

        public WrapperNode(WrapperUniqueIdReference wrapperUniqueIdReference, JsonValue jsonValue)
        {
            wrapperReference = wrapperUniqueIdReference;
            jsonNode = jsonValue;
        }

        public WrapperNode(JsonNode jsonNode)
        {
            this.jsonNode = jsonNode;
            wrapperReference = jsonNode.WrapperReference();
        }

        public IWrapperReference WrapperReference
        {
            get
            {
                return wrapperReference;
            }
        }

        public JsonNode JsonNode
        {
            get
            {
                return jsonNode?.DeepClone();
            }
        }

        public HashSet<IWrapperReference> GetWrapperReferences()
        {
            if (jsonNode == null || jsonNode is JsonValue)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperReferences();
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperReferences();
            }

            return null;
        }

        public HashSet<WrapperNode> GetWrapperNodes<TJsonNode>(WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if (jsonNode == null || jsonNode is JsonValue)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperNodes<TJsonNode>(wrapState);
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperNodes<TJsonNode>(wrapState);
            }

            return null;
        }

        public override bool Equals(object @object)
        {
            WrapperNode WrapperNode = @object as WrapperNode;
            if (WrapperNode == null)
            {
                return false;
            }

            return wrapperReference?.ToString() == WrapperNode.wrapperReference.ToString();
        }

        public override int GetHashCode()
        {
            return wrapperReference.ToString().GetHashCode();
        }

        public bool IsWrapperReference()
        {
            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).IsWrapperReference();
            }

            return false;
        }

        public bool IsWrapped()
        {
            return IsWrapped(out HashSet<WrapperNode> wrapperNodes_Unwrapped);
        }

        public bool IsWrapped(out HashSet<WrapperNode> wrapperNodes_Unwrapped)
        {
            wrapperNodes_Unwrapped = GetWrapperNodes<JsonObject>(WrapState.Unwrapped);
            return wrapperNodes_Unwrapped == null || wrapperNodes_Unwrapped.Count == 0;
        }

        public bool IsUnwrapped()
        {
            return IsUnwrapped(out HashSet<WrapperNode> wrapperNodes_Wrapped);
        }

        public bool IsUnwrapped(out HashSet<WrapperNode> wrapperNodes_Wrapped)
        {
            wrapperNodes_Wrapped = GetWrapperNodes<JsonObject>(WrapState.Wrapped);
            return wrapperNodes_Wrapped == null || wrapperNodes_Wrapped.Count == 0;
        }

        public bool Wrap(out HashSet<WrapperNode> wrapperNodes)
        {
            wrapperNodes = null;
            if(jsonNode == null)
            {
                return false;
            }

            if (jsonNode is JsonValue)
            {
                return false;
            }

            Dictionary<IWrapperReference, JsonObject> dictionary = new Dictionary<IWrapperReference, JsonObject>();
            if (jsonNode is JsonObject)
            {
                jsonNode = Query.Wrap((JsonObject)jsonNode, ref dictionary);
            }
            else if(jsonNode is JsonArray)
            {
                jsonNode = Query.Wrap((JsonArray)jsonNode, ref dictionary);
            }

            if(dictionary == null || dictionary.Count == 0)
            {
                return false;
            }

            wrapperNodes = new HashSet<WrapperNode>();
            foreach (KeyValuePair<IWrapperReference, JsonObject> keyValuePair in dictionary)
            {
                wrapperNodes.Add(new WrapperNode(keyValuePair.Key, keyValuePair.Value));
            }

            return true;
        }

        public bool Unwrap(WrapperNodeCluster wrapperNodeCluster, out List<IWrapperReference> missingWrapperReferences)
        {
            missingWrapperReferences = null;

            if (jsonNode == null)
            {
                return false;
            }

            if (jsonNode is JsonValue)
            {
                return false;
            }

            WrapperNode wrapperNode = Modify.Unwrap(wrapperNodeCluster, this, out missingWrapperReferences);
            if(wrapperNode == null)
            {
                return false;
            }

            jsonNode = wrapperNode.JsonNode;

            return missingWrapperReferences == null || missingWrapperReferences.Count == 0;
        }
    }
}
