using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class MetadataStorage : UniqueObject, IEnumerable<IMetadata>, IWrapperObject
    {
        [JsonIgnore]
        public Dictionary<TypeReference, IMetadata> dictionary = new Dictionary<TypeReference, IMetadata>();

        public MetadataStorage()
            : base(Constans.MetadataStorage.Guid)
        {

        }

        public MetadataStorage(MetadataStorage metadataStorage)
            : base(Constans.MetadataStorage.Guid, metadataStorage)
        {
            if (metadataStorage != null)
            {
                Metadatas = metadataStorage.Metadatas;
            }
        }

        public TMetadata GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            if(!dictionary.TryGetValue(new TypeReference(typeof(TMetadata)), out IMetadata metadata) || metadata == null)
            {
                return default;
            }

            if(!(metadata is TMetadata))
            {
                return default;
            }

            return (TMetadata)metadata;
        }

        public void SetMetadata(IMetadata metadata)
        {
            if(metadata == null)
            {
                return;
            }

            dictionary[new TypeReference(metadata.GetType())] = metadata;
        }
            

        [JsonInclude, JsonPropertyName("Metadatas")]
        public IEnumerable<IMetadata> Metadatas
        {
            get
            {
                return dictionary.Values.ToList();
            }

            set
            {
                dictionary.Clear();
                if(value == null)
                {
                    return;
                }

                foreach(IMetadata metadata  in value)
                {
                    System.Type type = metadata?.GetType();
                    if(type == null)
                    {
                        continue;
                    }

                    dictionary[type] = metadata;
                }
            }
        }

        public IEnumerator<IMetadata> GetEnumerator()
        {
            IEnumerable<IMetadata> metadatas = Metadatas;
            return metadatas == null ? Enumerable.Empty<IMetadata>().GetEnumerator() : metadatas.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}