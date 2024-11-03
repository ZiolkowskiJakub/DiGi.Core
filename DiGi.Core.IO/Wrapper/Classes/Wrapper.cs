using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public abstract class Wrapper : IDisposable
    {
        private bool disposed;

        private WrapperNodeCluster wrapperNodeCluster = new WrapperNodeCluster();

        public Wrapper()
        {

        }

        public UniqueReference Add(ISerializableObject value)
        {
            IWrapperUniqueReference wrapperUniqueReference = wrapperNodeCluster.Add(value);
            if(wrapperUniqueReference == null)
            {
                return null;
            }

            return wrapperUniqueReference.UniqueReference();
        }

        public UniqueIdReference Add(string value)
        {
            IWrapperReference wrapperReference = wrapperNodeCluster.Add(value);
            if (wrapperReference == null)
            {
                return null;
            }

            if (wrapperReference is WrapperUniqueIdReference)
            {
                return ((WrapperUniqueIdReference)wrapperReference).Reference;
            }

            throw new NotImplementedException();
        }

        protected abstract bool Push(IEnumerable<WrapperItem> wrapperItems);

        protected abstract bool Pull(IEnumerable<WrapperItem> wrapperItems);

        public IEnumerable<UniqueReference> Write(IEnumerable<UniqueReference> uniqueReferences)
        {
            List<WrapperItem> wrapperItems = new List<WrapperItem>();
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if(uniqueReference == null)
                {
                    continue;
                }

                WrapperNode wrapperNode = wrapperNodeCluster.GetValue(uniqueReference);
                if(wrapperNode == null)
                {
                    continue;
                }

                List<WrapperNode> wrapperNodes_Temp = new List<WrapperNode>() { wrapperNode };

                wrapperNodeCluster.Wrap(true, wrapperNode.WrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes_Wrap);
                if(wrapperNodes_Wrap != null && wrapperNodes_Wrap.Count != 0)
                {
                    foreach(WrapperNode wrapperNode_Wrap in wrapperNodes_Wrap)
                    {
                        wrapperNodes_Temp.Add(wrapperNode_Wrap);
                    }
                }

                foreach(WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
                {
                    WrapperItem wrapperItem = new WrapperItem(wrapperNode_Temp.GetUniqueReference(), wrapperNode_Temp.JsonNode, null);
                    if (wrapperItem == null)
                    {
                        continue;
                    }

                    wrapperItems.Add(wrapperItem);
                }
            }

            if(!Push(wrapperItems))
            {
                return null;
            }

            return wrapperItems.ConvertAll(x => x.UniqueReference);

        }

        private HashSet<WrapperNode> Read(HashSet<IWrapperUniqueReference> wrapperUniqueReferences)
        {
            if (wrapperUniqueReferences == null)
            {
                return null;
            }

            HashSet<WrapperNode> result = new HashSet<WrapperNode>();
            HashSet<IWrapperUniqueReference> wrapperUniqueReferences_Pull = new HashSet<IWrapperUniqueReference>();

            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                if(wrapperUniqueReference == null)
                {
                    return null;
                }

                WrapperNode wrapperNode = wrapperNodeCluster.GetValue(wrapperUniqueReference);
                if (wrapperNode == null)
                {
                    wrapperUniqueReferences_Pull.Add(wrapperUniqueReference);
                    continue;
                }

                wrapperNode.Unwrap(wrapperNodeCluster, out HashSet<IWrapperUniqueReference> wrapperUniqueReferences_Pull_Temp);

                if (wrapperUniqueReferences_Pull_Temp != null && wrapperUniqueReferences_Pull_Temp.Count != 0)
                {
                    foreach (IWrapperUniqueReference wrapperUniqueReference_Pull_Temp in wrapperUniqueReferences_Pull_Temp)
                    {
                        wrapperUniqueReferences_Pull.Add(wrapperUniqueReference_Pull_Temp);
                    }
                }
                else
                {
                    result.Add(wrapperNode);
                }
            }

            if(wrapperUniqueReferences_Pull == null || wrapperUniqueReferences_Pull.Count == 0)
            {
                return result;
            }

            Dictionary<IWrapperUniqueReference, WrapperItem> dictionary = new Dictionary<IWrapperUniqueReference, WrapperItem>();
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences_Pull)
            {
                dictionary[wrapperUniqueReference] = new WrapperItem(wrapperUniqueReference.UniqueReference());
            }

            if(dictionary == null || dictionary.Count == 0)
            {
                return null;
            }

            if (!Pull(dictionary.Values))
            {
                return null;
            }

            foreach (KeyValuePair<IWrapperUniqueReference, WrapperItem> keyValuePair in dictionary)
            {
                WrapperNode wrapperNode = new WrapperNode(keyValuePair.Key, keyValuePair.Value.JsonNode as dynamic);
                wrapperNodeCluster.Add(wrapperNode);
            }

            Read(wrapperUniqueReferences_Pull);

            foreach(IWrapperUniqueReference wrapperUniqueReference_Pull in wrapperUniqueReferences_Pull)
            {
                WrapperNode wrapperNode = wrapperNodeCluster.GetValue(wrapperUniqueReference_Pull);
                if (wrapperNode == null)
                {
                    throw new NotImplementedException();
                }

                wrapperNode.Unwrap(wrapperNodeCluster, out HashSet<IWrapperUniqueReference> wrapperUniqueReferences_Pull_Temp);
                if (wrapperUniqueReferences_Pull_Temp != null && wrapperUniqueReferences_Pull_Temp.Count != 0)
                {
                    throw new NotImplementedException();
                }

                if(wrapperUniqueReferences.Contains(wrapperUniqueReference_Pull))
                {
                    result.Add(wrapperNode);
                }

            }

            return result;
        }

        public List<JsonNode> Read(IEnumerable<UniqueReference> uniqueReferences)
        {
            if(uniqueReferences == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> wrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();
            foreach(UniqueReference uniqueReference in uniqueReferences)
            {
                if(uniqueReference == null)
                {
                    continue;
                }

                IWrapperUniqueReference wrapperUniqueReference = Create.WrapperUniqueReference(uniqueReference);
                if(wrapperUniqueReference == null)
                {
                    continue;
                }

                wrapperUniqueReferences.Add(wrapperUniqueReference);
            }

            HashSet<WrapperNode> wrapperNodes = Read(wrapperUniqueReferences);
            if(wrapperNodes == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach(UniqueReference uniqueReference in uniqueReferences)
            {
                WrapperNode wrapperNode = wrapperNodeCluster.GetValue(uniqueReference);
                result.Add(wrapperNode?.JsonNode);
            }

            return result;
        }

        public List<TSerializableObject> Read<TSerializableObject>(IEnumerable<UniqueReference> uniqueReferences) where TSerializableObject : ISerializableObject
        {
            List<JsonNode> jsonNodes = Read(uniqueReferences);
            if(jsonNodes == null)
            {
                return null;
            }

            List<TSerializableObject> result = new List<TSerializableObject>();
            foreach(JsonNode jsonNode in jsonNodes)
            {
                JsonObject jsonObject = jsonNode as JsonObject;
                if(jsonObject == null)
                {
                    continue;
                }

                TSerializableObject serializableObject = Core.Create.SerializableObject<TSerializableObject>(jsonObject);
                if(serializableObject == null)
                {
                    continue;
                }

                result.Add(serializableObject);
            }

            return result;
        }

        public void Clear()
        {
            wrapperNodeCluster.Clear();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Wrapper()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
