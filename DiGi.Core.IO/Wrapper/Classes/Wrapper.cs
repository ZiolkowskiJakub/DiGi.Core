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

            if(wrapperUniqueReference is WrapperUniqueIdReference)
            {
                return (UniqueReference)(WrapperUniqueIdReference)wrapperUniqueReference;
            }

            if(wrapperUniqueReference is WrapperGuidReference)
            {
                return (UniqueReference)(WrapperGuidReference)wrapperUniqueReference;
            }

            throw new NotImplementedException();
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
                return (UniqueIdReference)(WrapperUniqueIdReference)wrapperReference;
            }

            throw new NotImplementedException();
        }

        protected abstract PushResult Push(IEnumerable<WrapperItem> wrapperItems);

        protected abstract PullResult Pull(IEnumerable<UniqueReference> uniqueReferences);

        protected virtual WrapperItem GetWrapperItem(JsonNode jsonNode)
        {
            if(jsonNode == null)
            {
                return null;
            }

            IWrapperUniqueReference wrapperUniqueReference = Create.WrapperUniqueReference(jsonNode);
            if(wrapperUniqueReference == null)
            {
                return null;
            }


            return new WrapperItem(wrapperUniqueReference.ToString(), jsonNode, null);
        }

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

                WrapperItem wrapperItem = GetWrapperItem(wrapperNode.JsonNode);
                if(wrapperItem == null)
                {
                    continue;
                }

                wrapperItems.Add(wrapperItem);
            }

            PushResult pushResult = Push(wrapperItems);
            if(pushResult == null || pushResult.ResultType != Core.Enums.ResultType.Succeeded)
            {
                return null;
            }

            return pushResult.UniqueReferences;

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

            List<UniqueReference> uniqueReferences = new List<UniqueReference>();
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences_Pull)
            {
                uniqueReferences.Add((UniqueReference)wrapperUniqueReference);
            }

            PullResult pullResult = Pull(uniqueReferences);
            if (pullResult == null || pullResult.ResultType != Core.Enums.ResultType.Succeeded)
            {
                return null;
            }

            IEnumerable<WrapperItem> wrapperItems = pullResult.WrapperItems;
            if(wrapperItems != null)
            {
                foreach(WrapperItem wrapperItem in wrapperItems)
                {
                    JsonNode jsonNode = wrapperItem?.JsonNode;
                    if(jsonNode != null)
                    {
                        wrapperNodeCluster.Add(jsonNode);
                    }
                }
            }

            Read(wrapperUniqueReferences);

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
