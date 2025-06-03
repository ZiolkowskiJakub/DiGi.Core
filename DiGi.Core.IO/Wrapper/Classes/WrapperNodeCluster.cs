using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperNodeCluster : ValueCluster<WrapperTypeReference, IWrapperUniqueReference, WrapperNode>
    {
        protected override WrapperTypeReference GetKey_1(WrapperNode value)
        {
            return value?.WrapperUniqueReference?.WrapperTypeReference;
        }

        protected override IWrapperUniqueReference GetKey_2(WrapperNode value)
        {
            return value?.WrapperUniqueReference;
        }

        public WrapperNode GetValue(IWrapperUniqueReference wrapperUniqueReference)
        {
            if(wrapperUniqueReference == null)
            {
                return null;
            }

            return GetValue<WrapperNode>(wrapperUniqueReference.WrapperTypeReference, wrapperUniqueReference);
        }

        public WrapperNode GetValue(UniqueReference uniqueReference)
        {
            IWrapperUniqueReference wrapperUniqueReference = Create.WrapperUniqueReference(uniqueReference);
            if(wrapperUniqueReference == null)
            {
                return null;
            }

            return GetValue(wrapperUniqueReference);
        }

        public bool Contains(IWrapperUniqueReference wrapperUniqueReference)
        {
            if(wrapperUniqueReference == null)
            {
                return false;
            }

            return Contains(wrapperUniqueReference.WrapperTypeReference, wrapperUniqueReference);
        }

        public IWrapperUniqueReference Add(JsonNode jsonNode)
        {
            if (jsonNode == null)
            {
                return null;
            }

            WrapperNode wrapperNode = new WrapperNode(jsonNode);

            return Add(wrapperNode) ? wrapperNode.WrapperUniqueReference : null;
        }

        public IWrapperUniqueReference Add(ISerializableObject serializableObject)
        {
            JsonObject jsonObject = serializableObject?.ToJsonObject();
            if(jsonObject == null)
            {
                return null;
            }

            return Add(jsonObject);
        }

        public WrapperNode Wrap(IWrapperUniqueReference wrapperUniqueReference)
        {
            return Wrap(false, wrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes);
        }

        public WrapperNode Wrap(IWrapperUniqueReference wrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes)
        {
            return Wrap(false, wrapperUniqueReference, out wrapperNodes);
        }

        public WrapperNode Wrap(bool includeNested, IWrapperUniqueReference wrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes)
        {
            wrapperNodes = null;

            WrapperNode wrapperNode = GetValue(wrapperUniqueReference);
            if (wrapperNode == null)
            {
                return null;
            }

            wrapperNode.Wrap(out HashSet<WrapperNode> wrapperNodes_Temp);
            if (wrapperNodes_Temp == null || wrapperNodes_Temp.Count == 0)
            {
                return wrapperNode;
            }

            Add(wrapperNode);

            wrapperNodes = new HashSet<WrapperNode>();
            foreach (WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
            {
                if (wrapperNode_Temp == null || Contains(wrapperNode_Temp))
                {
                    continue;
                }

                if (Add(wrapperNode_Temp))
                {
                    wrapperNodes.Add(wrapperNode_Temp);
                }

                if (includeNested)
                {
                    Wrap(includeNested, wrapperNode_Temp.WrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes_Nested);
                    if(wrapperNodes_Nested != null)
                    {
                        foreach(WrapperNode wrapperNode_Nested in wrapperNodes_Nested)
                        {
                            wrapperNodes.Add(wrapperNode_Nested);
                        }
                    }
                }
            }

            return wrapperNode;
        }

        public List<WrapperNode> Wrap(IEnumerable<IWrapperUniqueReference> wrapperUniqueReferences)
        {
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            List<WrapperNode> result = new List<WrapperNode>();
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                WrapperNode wrapperNode = Wrap(wrapperUniqueReference);
                if (wrapperNode != null)
                {
                    result.Add(wrapperNode);
                }
            }

            return result;
        }

        public List<WrapperNode> Wrap()
        {
            List<WrapperNode> wrapperNodes = GetValues<WrapperNode>();
            if(wrapperNodes == null)
            {
                return null;
            }

            List<WrapperNode> result = new List<WrapperNode>();
            while(wrapperNodes.Count > 0)
            {
                WrapperNode wrapperNode = wrapperNodes[0];
                wrapperNodes.RemoveAt(0);

                WrapperNode wrapperNode_Wrap = Wrap(wrapperNode.WrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes_Temp);
                if(wrapperNode_Wrap != null)
                {
                    result.Add(wrapperNode_Wrap);
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

        public JsonNode Unwrap(IWrapperUniqueReference wrapperUniqueReference)
        {
            WrapperNode wrapperNode = GetValue(wrapperUniqueReference);
            if (wrapperNode == null)
            {
                return null;
            }

            wrapperNode = Modify.Unwrap(this, wrapperNode, out HashSet<IWrapperUniqueReference> misssingObjectReferences);
            if (wrapperNode == null) 
            {
                return null;
            }

            return wrapperNode.JsonNode;
        }

        public List<JsonNode> Unwrap(IEnumerable<IWrapperUniqueReference> wrapperUniqueReferences)
        {
            if(wrapperUniqueReferences == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                JsonNode jsonNode = Unwrap(wrapperUniqueReference);
                if (jsonNode != null)
                {
                    result.Add(jsonNode);
                }
            }

            return result;
        }
    }
}
