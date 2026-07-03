using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperMetadata : SerializableObject, IMetadata
    {
        [JsonInclude, JsonPropertyName(nameof(References))]
        private readonly List<string> references = [];

        public WrapperMetadata()
            : base()
        {
        }

        public WrapperMetadata(WrapperMetadata? wrapperMetadata)
            : base(wrapperMetadata)
        {
            if (wrapperMetadata != null)
            {
                if (wrapperMetadata.references != null)
                {
                    references.AddRange(wrapperMetadata.references);
                }
            }
        }

        public WrapperMetadata(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public List<string> References
        {
            get
            {
                return references;
            }
        }
    }
}