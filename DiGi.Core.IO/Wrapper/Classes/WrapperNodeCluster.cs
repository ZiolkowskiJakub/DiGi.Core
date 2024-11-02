using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperNodeCluster : ValueCluster<TypeReference, IWrapperReference, WrapperNode>
    {
        protected override TypeReference GetKey_1(WrapperNode value)
        {
            return value?.WrapperReference?.TypeReference;
        }

        protected override IWrapperReference GetKey_2(WrapperNode value)
        {
            return value?.WrapperReference;
        }

        public WrapperNode GetValue(IWrapperReference wrapperReference)
        {
            if(wrapperReference == null)
            {
                return null;
            }

            return GetValue<WrapperNode>(wrapperReference.TypeReference, wrapperReference);
        }

        public IWrapperReference Add(JsonNode jsonNode)
        {
            if (jsonNode == null)
            {
                return null;
            }

            WrapperNode wrapperNode = new WrapperNode(jsonNode);

            return Add(wrapperNode) ? wrapperNode.WrapperReference : null;
        }

        public IWrapperReference Add(ISerializableObject serializableObject)
        {
            JsonObject jsonObject = serializableObject?.ToJsonObject();
            if(jsonObject == null)
            {
                return null;
            }

            return Add(jsonObject);
        }

        public JsonNode Wrap(IWrapperReference wrapperReference)
        {
            return Wrap(wrapperReference, out HashSet<WrapperNode> wrapperNodes);
        }

        public JsonNode Wrap(IWrapperReference wrapperReference, out HashSet<WrapperNode> wrapperNodes)
        {
            wrapperNodes = null;

            WrapperNode wrapperNode = GetValue(wrapperReference);
            if (wrapperNode == null)
            {
                return null;
            }

            wrapperNode.Wrap(out HashSet<WrapperNode> wrapperNodes_Temp);
            if (wrapperNodes_Temp == null || wrapperNodes_Temp.Count == 0)
            {
                return wrapperNode.JsonNode;
            }

            Add(wrapperNode);

            wrapperNodes = new HashSet<WrapperNode>();
            foreach (WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
            {
                if (wrapperNode_Temp == null || Contains(wrapperNode_Temp))
                {
                    continue;
                }

                if(Add(wrapperNode_Temp))
                {
                    wrapperNodes.Add(wrapperNode_Temp);
                }
            }

            return wrapperNode.JsonNode;
        }

        public List<JsonNode> Wrap(IEnumerable<IWrapperReference> wrapperReferences)
        {
            if (wrapperReferences == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach (IWrapperReference wrapperReference in wrapperReferences)
            {
                JsonNode jsonNode = Wrap(wrapperReference);
                if (jsonNode != null)
                {
                    result.Add(jsonNode);
                }
            }

            return result;
        }

        public List<JsonNode> Wrap()
        {
            List<WrapperNode> wrapperNodes = GetValues<WrapperNode>();
            if(wrapperNodes == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            while(wrapperNodes.Count > 0)
            {
                WrapperNode wrapperNode = wrapperNodes[0];
                wrapperNodes.RemoveAt(0);

                JsonNode jsonNode = Wrap(wrapperNode.WrapperReference, out HashSet<WrapperNode> wrapperNodes_Temp);
                if(jsonNode != null)
                {
                    result.Add(jsonNode);
                }

                if(wrapperNodes_Temp != null && wrapperNodes_Temp.Count != 0)
                {
                    foreach(WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
                    {
                        wrapperNodes.Add(wrapperNode_Temp);
                    }
                }
            }

            return result;
        }

        public JsonNode Unwrap(IWrapperReference wrapperReference)
        {
            WrapperNode wrapperNode = GetValue(wrapperReference);
            if (wrapperNode == null)
            {
                return null;
            }

            wrapperNode = Modify.Unwrap(this, wrapperNode, out List<IWrapperReference> misssingObjectReferences);
            if (wrapperNode == null) 
            {
                return null;
            }

            return wrapperNode.JsonNode;
        }

        public List<JsonNode> Unwrap(IEnumerable<IWrapperReference> owrapperReferences)
        {
            if(owrapperReferences == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach (IWrapperReference wrapperReference in owrapperReferences)
            {
                JsonNode jsonNode = Unwrap(wrapperReference);
                if (jsonNode != null)
                {
                    result.Add(jsonNode);
                }
            }

            return result;
        }
    }
}
