using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperMetadata : SerializableObject, IMetadata
    {
        [JsonInclude, JsonPropertyName("References")]
        public List<string> References { get; set; }

        public WrapperMetadata()
            : base()
        {

        }

        public WrapperMetadata(WrapperMetadata wrapperMetadata)
            : base(wrapperMetadata)
        {
            if (wrapperMetadata != null)
            {
                References = wrapperMetadata.References == null ? null : new List<string>(wrapperMetadata.References);
            }
        }
    }
}

