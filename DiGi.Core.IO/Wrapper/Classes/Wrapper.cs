using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public abstract class Wrapper : IDisposable
    {
        private bool disposed;

        private WrapperNodeCluster wrapperNodeCluster = new WrapperNodeCluster();

        public event PushEventHandler Push;

        public event PullEventHandler Pull;

        public Wrapper()
        {

        }

        public UniqueReference Add(ISerializableObject value)
        {
            IWrapperReference wrapperReference = wrapperNodeCluster.Add(value);
            if(wrapperReference == null)
            {
                return null;
            }

            if(wrapperReference is WrapperUniqueIdReference)
            {
                return new UniqueIdReference((WrapperUniqueIdReference)wrapperReference);
            }

            if(wrapperReference is WrapperGuidReference)
            {
                return new GuidReference((WrapperGuidReference)wrapperReference);
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
                return new UniqueIdReference((WrapperUniqueIdReference)wrapperReference);
            }

            throw new NotImplementedException();
        }

        //public List<T> Read<T>(IEnumerable<UniqueReference> uniqueReferences)
        //{

        //}

        //public IEnumerable<UniqueReference> Write(IEnumerable<UniqueReference> uniqueReferences)
        //{

        //}

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
