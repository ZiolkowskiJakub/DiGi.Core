using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Classes
{
    internal sealed class MetadataStorage : GuidObject, IEnumerable<IMetadata>, IIOObject
    {
        [JsonIgnore]
        private readonly Dictionary<TypeReference, IMetadata> dictionary = [];

        public MetadataStorage()
            : base(Constans.MetadataStorage.Guid)
        {
        }

        public MetadataStorage(MetadataStorage? metadataStorage)
            : base(Constans.MetadataStorage.Guid, metadataStorage)
        {
            if (metadataStorage != null)
            {
                Metadatas = metadataStorage.Metadatas;
            }
        }

        public MetadataStorage(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonInclude, JsonPropertyName("Metadatas")]
        public IEnumerable<IMetadata> Metadatas
        {
            get
            {
                return [.. dictionary.Values];
            }

            set
            {
                dictionary.Clear();
                if (value == null)
                {
                    return;
                }

                foreach (IMetadata metadata in value)
                {
                    System.Type? type = metadata?.GetType();
                    if (type == null)
                    {
                        continue;
                    }

                    dictionary[type!] = metadata!;
                }
            }
        }

        public IEnumerator<IMetadata> GetEnumerator()
        {
            return Metadatas?.GetEnumerator() ?? Enumerable.Empty<IMetadata>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public TMetadata? GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            if (!dictionary.TryGetValue(new TypeReference(typeof(TMetadata)), out IMetadata metadata) || metadata == null)
            {
                return default;
            }

            if (metadata is not TMetadata)
            {
                return default;
            }

            return (TMetadata)metadata;
        }

        public void SetMetadata(IMetadata? metadata)
        {
            if (metadata == null)
            {
                return;
            }

            dictionary[new TypeReference(metadata.GetType())] = metadata;
        }
    }
}