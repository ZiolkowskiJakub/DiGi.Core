using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Enums;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperNode : IWrapperObject
    {
        private IWrapperUniqueReference wrapperUniqueReference;
        private JsonNode jsonNode;

        public WrapperNode(IWrapperUniqueReference wrapperUniqueReference, JsonObject jsonObject)
        {
            this.wrapperUniqueReference = wrapperUniqueReference;
            jsonNode = jsonObject;
        }

        public WrapperNode(WrapperUniqueIdReference wrapperUniqueIdReference, JsonArray jsonArray)
        {
            wrapperUniqueReference = wrapperUniqueIdReference;
            jsonNode = jsonArray;
        }

        public WrapperNode(WrapperUniqueIdReference wrapperUniqueIdReference, JsonValue jsonValue)
        {
            wrapperUniqueReference = wrapperUniqueIdReference;
            jsonNode = jsonValue;
        }

        public WrapperNode(JsonNode jsonNode)
        {
            this.jsonNode = jsonNode;
            wrapperUniqueReference = jsonNode.WrapperUniqueReference();
        }

        public IWrapperUniqueReference WrapperUniqueReference
        {
            get
            {
                return wrapperUniqueReference;
            }
        }

        public UniqueReference GetUniqueReference()
        {
            return wrapperUniqueReference?.UniqueReference();
        }

        public JsonNode JsonNode
        {
            get
            {
                return jsonNode?.DeepClone();
            }
        }

        public HashSet<IWrapperUniqueReference> GetWrapperUniqueReferences()
        {
            if (jsonNode == null || jsonNode is JsonValue)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperUniqueReferences();
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperUniqueReferences();
            }

            return null;
        }

        public HashSet<WrapperNode> GetWrapperNodes<TJsonNode>(bool includeNested, WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            if (jsonNode == null || jsonNode is JsonValue)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperNodes<TJsonNode>(includeNested, wrapState);
            }

            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).WrapperNodes<TJsonNode>(includeNested, wrapState);
            }

            return null;
        }

        public HashSet<WrapperNode> GetWrapperNodes<TJsonNode>(WrapState wrapState = WrapState.Undefined) where TJsonNode : JsonNode
        {
            return GetWrapperNodes<TJsonNode>(false, wrapState);
        }

        public override bool Equals(object @object)
        {
            WrapperNode WrapperNode = @object as WrapperNode;
            if (WrapperNode == null)
            {
                return false;
            }

            return GetHashCode() == WrapperNode.GetHashCode();
        }

        public override int GetHashCode()
        {
            return wrapperUniqueReference.ToString().GetHashCode();
        }

        public bool IsWrapperUniqueReference()
        {
            if (jsonNode is JsonObject)
            {
                return ((JsonObject)jsonNode).IsWrapperUniqueReference();
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

        public bool IsWrapped(bool includeNested, out HashSet<WrapperNode> wrapperNodes_Unwrapped)
        {
            wrapperNodes_Unwrapped = GetWrapperNodes<JsonObject>(includeNested, WrapState.Unwrapped);
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

        public bool IsUnwrapped(bool includeNested, out HashSet<WrapperNode> wrapperNodes_Wrapped)
        {
            wrapperNodes_Wrapped = GetWrapperNodes<JsonObject>(includeNested, WrapState.Wrapped);
            return wrapperNodes_Wrapped == null || wrapperNodes_Wrapped.Count == 0;
        }

        public bool Wrap()
        {
            return Wrap(out HashSet<WrapperNode> wrapperNodes);
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

            Dictionary<IWrapperUniqueReference, JsonObject> dictionary = new Dictionary<IWrapperUniqueReference, JsonObject>();
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
            foreach (KeyValuePair<IWrapperUniqueReference, JsonObject> keyValuePair in dictionary)
            {
                wrapperNodes.Add(new WrapperNode(keyValuePair.Key, keyValuePair.Value));
            }

            return true;
        }

        public bool Unwrap(WrapperNodeCluster wrapperNodeCluster, out HashSet<IWrapperUniqueReference> missingWrapperUniquReferences)
        {
            missingWrapperUniquReferences = null;

            if (jsonNode == null)
            {
                return false;
            }

            if (jsonNode is JsonValue)
            {
                return false;
            }

            WrapperNode wrapperNode = Modify.Unwrap(wrapperNodeCluster, this, out missingWrapperUniquReferences);
            if(wrapperNode == null)
            {
                return false;
            }

            jsonNode = wrapperNode.JsonNode;

            return missingWrapperUniquReferences == null || missingWrapperUniquReferences.Count == 0;
        }
    }
}
