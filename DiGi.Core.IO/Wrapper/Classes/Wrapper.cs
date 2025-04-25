using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.Interfaces;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if(value == null)
            {
                return null;
            }

            List<IWrapperUniqueReference> wrapperUniqueReferences = AddRange(new object[] { value });
            if(wrapperUniqueReferences == null || wrapperUniqueReferences.Count == 0)
            {
                return null;
            }

            return wrapperUniqueReferences[0]?.UniqueReference();
        }

        public UniqueIdReference Add(string value)
        {
            if (value == null)
            {
                return null;
            }

            List<IWrapperUniqueReference> wrapperUniqueReferences = AddRange(new object[] { value });
            if (wrapperUniqueReferences == null || wrapperUniqueReferences.Count == 0)
            {
                return null;
            }

            return wrapperUniqueReferences[0]?.UniqueReference() as UniqueIdReference;
        }

        public UniqueIdReference Add(double value)
        {
            List<IWrapperUniqueReference> wrapperUniqueReferences = AddRange(new object[] { value });
            if (wrapperUniqueReferences == null || wrapperUniqueReferences.Count == 0)
            {
                return null;
            }

            return wrapperUniqueReferences[0]?.UniqueReference() as UniqueIdReference;
        }

        public List<UniqueReference> AddRange<TSerializableObject>(IEnumerable<TSerializableObject> serializableObjects) where TSerializableObject : ISerializableObject 
        {
            if(serializableObjects == null)
            {
                return null;
            }

            List<object> objects = new List<object>();
            foreach(TSerializableObject serializableObject in serializableObjects)
            {
                objects.Add(serializableObject);
            }

            List<IWrapperUniqueReference> wrapperUniqueReferences = AddRange(objects);
            if(wrapperUniqueReferences == null)
            {
                return null;
            }

            List<UniqueReference> result = new List<UniqueReference>();
            foreach(IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                result.Add(wrapperUniqueReference.UniqueReference());
            }

            return result;
        }

        private List<IWrapperUniqueReference> AddRange(IEnumerable<object> objects)
        {
            if(objects == null)
            {
                return null;
            }

            WrapperMetadata wrapperMetadata = GetWrapperMetadata();

            List<IWrapperUniqueReference> result = new List<IWrapperUniqueReference>();
            foreach(object @object in objects)
            {
                IWrapperUniqueReference wrapperUniqueReference = wrapperNodeCluster.Add(@object as dynamic);
                result.Add(wrapperUniqueReference);

                wrapperMetadata.References.Add(wrapperUniqueReference?.ToString());
            }

            SetWrapperMetadata(wrapperMetadata);

            return result;
        }

        protected abstract bool Push(IEnumerable<WrapperItem> wrapperItems);

        protected abstract bool Pull(IEnumerable<WrapperItem> wrapperItems);

        protected abstract bool Pull(out IEnumerable<TypeReference> typeReferences);

        protected abstract bool Pull(TypeReference typeReference, out IEnumerable<UniqueReference> uniqueReferences);

        private IEnumerable<IWrapperUniqueReference> Write(IEnumerable<IWrapperUniqueReference> wrapperUniqueReferences)
        {
            if(wrapperUniqueReferences == null)
            {
                return null;
            }

            List<WrapperItem> wrapperItems = new List<WrapperItem>();
            foreach (IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                if (wrapperUniqueReference == null)
                {
                    continue;
                }

                WrapperNode wrapperNode = wrapperNodeCluster.GetValue(wrapperUniqueReference);
                if (wrapperNode == null)
                {
                    continue;
                }

                List<WrapperNode> wrapperNodes_Temp = new List<WrapperNode>() { wrapperNode };

                wrapperNodeCluster.Wrap(true, wrapperNode.WrapperUniqueReference, out HashSet<WrapperNode> wrapperNodes_Wrap);
                if (wrapperNodes_Wrap != null && wrapperNodes_Wrap.Count != 0)
                {
                    foreach (WrapperNode wrapperNode_Wrap in wrapperNodes_Wrap)
                    {
                        wrapperNodes_Temp.Add(wrapperNode_Wrap);
                    }
                }

                foreach (WrapperNode wrapperNode_Temp in wrapperNodes_Temp)
                {
                    WrapperItem wrapperItem = new WrapperItem(wrapperNode_Temp.GetUniqueReference(), wrapperNode_Temp.JsonNode, null);
                    if (wrapperItem == null)
                    {
                        continue;
                    }

                    wrapperItems.Add(wrapperItem);
                }
            }

            if (!Push(wrapperItems))
            {
                return null;
            }

            return wrapperItems.ConvertAll(x => Create.WrapperUniqueReference(x.UniqueReference));
        }

        public IEnumerable<UniqueReference> Write(IEnumerable<UniqueReference> uniqueReferences)
        {
            if(uniqueReferences == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> wrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if(uniqueReference == null)
                {
                    continue;
                }

                wrapperUniqueReferences.Add(Create.WrapperUniqueReference(uniqueReference));
            }

            IEnumerable<IWrapperUniqueReference> wrapperUniqueReferences_Temp = Write(wrapperUniqueReferences);
            if(wrapperUniqueReferences_Temp == null || wrapperUniqueReferences_Temp.Count() == 0)
            {
                return null;
            }


            HashSet<UniqueReference> result = new HashSet<UniqueReference>();
            foreach(IWrapperUniqueReference wrapperUniqueReference_Temp in wrapperUniqueReferences_Temp)
            {
                result.Add(wrapperUniqueReference_Temp.UniqueReference());
            }

            return result;
        }

        private IEnumerable<IWrapperUniqueReference> Write(IEnumerable<WrapperTypeReference> wrapperTypeReferences)
        {
            if(wrapperTypeReferences == null)
            {
                wrapperTypeReferences = wrapperNodeCluster?.GetKeys_1();
                if(wrapperNodeCluster == null)
                {
                    return null;
                }
            }

            HashSet<IWrapperUniqueReference> result = new HashSet<IWrapperUniqueReference>();
            foreach(WrapperTypeReference wrapperTypeReference in wrapperTypeReferences)
            {
                IEnumerable<IWrapperUniqueReference> wrapperUniqueReferences = wrapperNodeCluster?.GetKeys_2(wrapperTypeReference);
                if(wrapperTypeReferences == null)
                {
                    continue;
                }

                wrapperUniqueReferences = Write(wrapperUniqueReferences);
                if (wrapperTypeReferences == null)
                {
                    continue;
                }

                foreach(IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
                {
                    if(wrapperUniqueReference == null)
                    {
                        continue;
                    }

                    result.Add(wrapperUniqueReference);
                }
            }

            return result;
        }

        public IEnumerable<UniqueReference> Write()
        {
            IEnumerable<IWrapperUniqueReference> wrapperUniqueReferences = Write((IEnumerable<WrapperTypeReference>)null);
            if(wrapperUniqueReferences == null)
            {
                return null;
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();
            foreach(IWrapperUniqueReference wrapperUniqueReference in wrapperUniqueReferences)
            {
                UniqueReference uniqueReference = wrapperUniqueReference.UniqueReference();
                if(uniqueReference == null)
                {
                    continue;
                }

                result.Add(uniqueReference);
            }
            return result;
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

        private WrapperNode Read(IWrapperUniqueReference wrapperUniqueReference)
        {
            if(wrapperUniqueReference == null)
            {
                return null;
            }

            HashSet<WrapperNode> wrapperNodes = Read(new HashSet<IWrapperUniqueReference> { wrapperUniqueReference });
            if(wrapperNodes == null || wrapperNodes.Count == 0)
            {
                return null;
            }

            return wrapperNodes.First();
        }

        private HashSet<WrapperNode> Read(IEnumerable<TypeReference> typeReferences)
        {
            if(typeReferences == null)
            {
                if (!Pull(out typeReferences) || typeReferences == null)
                {
                    return null;
                }
            }

            HashSet<WrapperNode> result = new HashSet<WrapperNode>();
            foreach (TypeReference typeReference in typeReferences)
            {
                if (!Pull(typeReference, out IEnumerable<UniqueReference> uniqueReferences) || uniqueReferences == null)
                {
                    continue;
                }

                HashSet<IWrapperUniqueReference> wrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();
                foreach (UniqueReference uniqueReference in uniqueReferences)
                {
                    IWrapperUniqueReference wrapperUniqueReference = uniqueReference.WrapperUniqueReference();
                    if (wrapperUniqueReference == null)
                    {
                        continue;
                    }

                    wrapperUniqueReferences.Add(wrapperUniqueReference);
                }

                HashSet<WrapperNode> wrapperNodes_TypeReference = Read(wrapperUniqueReferences);
                if(wrapperNodes_TypeReference == null)
                {
                    continue;
                }

                foreach(WrapperNode wrapperNode_TypeReference in wrapperNodes_TypeReference)
                {
                    if(wrapperNodes_TypeReference == null)
                    {
                        continue;
                    }

                    result.Add(wrapperNode_TypeReference);
                }
            }

            return result;
        }

        public List<JsonNode> Read() 
        {
            HashSet<WrapperNode> wrapperNodes = Read((IEnumerable<TypeReference>)null);
            if(wrapperNodes == null)
            {
                return null;
            }

            List<JsonNode> result = new List<JsonNode>();
            foreach(WrapperNode wrapperNode in wrapperNodes)
            {
                result.Add(wrapperNode?.JsonNode);
            }

            return result;
        }

        private TSerializableObject Read<TSerializableObject>(IWrapperUniqueReference wrapperUniqueReference) where TSerializableObject : ISerializableObject
        {
            JsonObject jsonObject = Read(wrapperUniqueReference)?.JsonNode as JsonObject;
            if(jsonObject == null)
            {
                return default;
            }

            return DiGi.Core.Create.SerializableObject<TSerializableObject>(jsonObject);
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

                TSerializableObject serializableObject = DiGi.Core.Create.SerializableObject<TSerializableObject>(jsonObject);
                if(serializableObject == null)
                {
                    continue;
                }

                result.Add(serializableObject);
            }

            return result;
        }

        public TSerializableObject Read<TSerializableObject>(UniqueReference uniqueReference) where TSerializableObject : ISerializableObject
        {
            if(uniqueReference == null)
            {
                return default;
            }

            List<TSerializableObject> serializableObjects = Read<TSerializableObject>(new UniqueReference[] { uniqueReference });
            if(serializableObjects == null || serializableObjects.Count == 0)
            {
                return default;
            }

            return serializableObjects[0];
        }

        public List<JsonNode> GetJsonNodes()
        {
            WrapperMetadata wrapperMetadata = GetWrapperMetadata();

            List<string> references = wrapperMetadata?.References;
            if(references == null)
            {
                return null;
            }

            HashSet<IWrapperUniqueReference> wrapperUniqueReferences = new HashSet<IWrapperUniqueReference>();
            foreach (string reference in references)
            {
                if(!Query.TryParse(reference, out IWrapperUniqueReference wrapperUniqueReference) || wrapperUniqueReference == null)
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
            foreach(string reference in references)
            {
                WrapperNode wrapperNode = wrapperNodes.Find(x => x?.WrapperUniqueReference.ToString() == reference);
                result.Add(wrapperNode?.JsonNode);
            }

            return result;
        }

        public List<ISerializableObject> GetSerializableObjects()
        {
            return GetSerializableObjects<ISerializableObject>();
        }
        public List<TSerializableObject> GetSerializableObjects<TSerializableObject>() where TSerializableObject : ISerializableObject
        {
            List<JsonNode> jsonNodes = GetJsonNodes();
            if(jsonNodes == null)
            {
                return null;
            }

            List<TSerializableObject> result = new List<TSerializableObject>();
            foreach (JsonNode jsonNode in jsonNodes) 
            {
                TSerializableObject serializableObject = DiGi.Core.Create.SerializableObject<TSerializableObject>(jsonNode as JsonObject);
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

        private MetadataStorage GetMetadataStorage()
        {
            MetadataStorage result = Read<MetadataStorage>(Constans.MetadataStorage.WrapperGuidReference);
            if (result == null)
            {
                result = new MetadataStorage();
            }

            return result;
        }

        private void SetMetadataStorage(MetadataStorage metadataStorage)
        {
            if(metadataStorage == null)
            {
                return;
            }

            wrapperNodeCluster.Add(metadataStorage);
        }

        private WrapperMetadata GetWrapperMetadata()
        {
            MetadataStorage metadataStorage = GetMetadataStorage();

            WrapperMetadata wrapperMetadata = metadataStorage.GetMetadata<WrapperMetadata>();
            if(wrapperMetadata == null)
            {
                wrapperMetadata = new WrapperMetadata();
                metadataStorage.SetMetadata(wrapperMetadata);
            }

            return wrapperMetadata;
        }

        private void SetWrapperMetadata(WrapperMetadata wrapperMetadata)
        {
            SetMetadata(wrapperMetadata);
        }

        public TMetadata GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            MetadataStorage metadataStorage = GetMetadataStorage();

            return metadataStorage.GetMetadata<TMetadata>();
        }

        public void SetMetadata(IMetadata metadata)
        {
            MetadataStorage metadataStorage = Read<MetadataStorage>(Constans.MetadataStorage.WrapperGuidReference);
            if (metadataStorage == null)
            {
                metadataStorage = new MetadataStorage();
            }

            metadataStorage.SetMetadata(metadata);

            SetMetadataStorage(metadataStorage);
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
