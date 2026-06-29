using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperNodeCluster : ValueCluster<WrapperTypeReference, IWrapperUniqueReference, WrapperNode>
    {
        public IWrapperUniqueReference? Add(JsonNode? jsonNode)
        {
            if (jsonNode == null)
            {
                return null;
            }

            WrapperNode wrapperNode = new(jsonNode);

            return Add(wrapperNode) ? wrapperNode.WrapperUniqueReference : null;
        }

        public IWrapperUniqueReference? Add(ISerializableObject? serializableObject)
        {
            JsonObject? jsonObject = serializableObject?.ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return Add(jsonObject);
        }

        public bool Contains(IWrapperUniqueReference? wrapperUniqueReference)
        {
            if (wrapperUniqueReference == null)
            {
                return false;
            }

            return Contains(wrapperUniqueReference.WrapperTypeReference, wrapperUniqueReference);
        }

        public WrapperNode? GetValue(IWrapperUniqueReference? wrapperUniqueReference)
        {
            if (wrapperUniqueReference == null)
            {
                return null;
            }

            return GetValue<WrapperNode>(wrapperUniqueReference.WrapperTypeReference, wrapperUniqueReference);
        }

        public WrapperNode? GetValue(UniqueReference? uniqueReference)
        {
            IWrapperUniqueReference? wrapperUniqueReference = Create.WrapperUniqueReference(uniqueReference);
            if (wrapperUniqueReference == null)
            {
                return null;
            }

            return GetValue(wrapperUniqueReference);
        }

        public JsonNode? Unwrap(IWrapperUniqueReference? wrapperUniqueReference)
        {
            WrapperNode? wrapperNode = GetValue(wrapperUniqueReference);
            if (wrapperNode == null)
            {
                return null;
            }

            wrapperNode = Modify.Unwrap(this, wrapperNode, out _);
            if (wrapperNode == null)
            {
                return null;
            }

            return wrapperNode.JsonNode;
        }

        public List<JsonNode>? Unwrap(IEnumerable<IWrapperUniqueReference>? wrapperUniqueReferences)
        {
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            List<JsonNode> result = [];
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                JsonNode? jsonNode = Unwrap(wrapperUniqueReference);
                if (jsonNode != null)
                {
                    result.Add(jsonNode);
                }
            }

            return result;
        }

        public WrapperNode? Wrap(IWrapperUniqueReference? wrapperUniqueReference)
        {
            return Wrap(false, wrapperUniqueReference, out _);
        }

        public WrapperNode? Wrap(IWrapperUniqueReference? wrapperUniqueReference, out HashSet<WrapperNode>? wrapperNodes)
        {
            return Wrap(false, wrapperUniqueReference, out wrapperNodes);
        }

        public WrapperNode? Wrap(bool includeNested, IWrapperUniqueReference? wrapperUniqueReference, out HashSet<WrapperNode>? wrapperNodes)
        {
            wrapperNodes = null;

            WrapperNode? wrapperNode = GetValue(wrapperUniqueReference);
            if (wrapperNode == null)
            {
                return null;
            }

            wrapperNode.Wrap(out HashSet<WrapperNode>? wrapperNodes_Temp);
            if (wrapperNodes_Temp == null || wrapperNodes_Temp.Count == 0)
            {
                return wrapperNode;
            }

            Add(wrapperNode);

            wrapperNodes = [];
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
                    Wrap(includeNested, wrapperNode_Temp.WrapperUniqueReference, out HashSet<WrapperNode>? wrapperNodes_Nested);
                    if (wrapperNodes_Nested != null)
                    {
                        foreach (WrapperNode wrapperNode_Nested in wrapperNodes_Nested)
                        {
                            wrapperNodes.Add(wrapperNode_Nested);
                        }
                    }
                }
            }

            return wrapperNode;
        }

        public List<WrapperNode>? Wrap(IEnumerable<IWrapperUniqueReference>? wrapperUniqueReferences)
        {
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            List<WrapperNode> result = [];
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                WrapperNode? wrapperNode = Wrap(wrapperUniqueReference);
                if (wrapperNode != null)
                {
                    result.Add(wrapperNode);
                }
            }

            return result;
        }

        public List<WrapperNode>? Wrap()
        {
            List<WrapperNode> wrapperNodes = GetValues<WrapperNode>();
            if (wrapperNodes == null)
            {
                return null;
            }

            Queue<WrapperNode> wrapperNodes_Queue = new(wrapperNodes);

            List<WrapperNode> result = [];
            while (wrapperNodes_Queue.Count > 0)
            {
                WrapperNode wrapperNode = wrapperNodes_Queue.Dequeue();

                WrapperNode? wrapperNode_Wrap = Wrap(wrapperNode.WrapperUniqueReference, out HashSet<WrapperNode>? wrapperNodes_Temp);
                if (wrapperNode_Wrap != null)
                {
                    result.Add(wrapperNode_Wrap);
                }

                if (wrapperNodes_Temp != null && wrapperNodes_Temp.Count != 0)
                {
                    foreach (WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
                    {
                        wrapperNodes_Queue.Enqueue(wrapperNode_Temp);
                    }
                }
            }

            return result;
        }

        protected override WrapperTypeReference? GetKey_1(WrapperNode? value)
        {
            return value?.WrapperUniqueReference?.WrapperTypeReference;
        }

        protected override IWrapperUniqueReference? GetKey_2(WrapperNode? value)
        {
            return value?.WrapperUniqueReference;
        }
    }
}