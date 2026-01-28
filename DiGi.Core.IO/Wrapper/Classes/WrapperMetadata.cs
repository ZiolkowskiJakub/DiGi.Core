using DiGi.Core.Classes;
using DiGi.Core.IO.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperMetadata : SerializableObject, IMetadata
    {
        public WrapperMetadata()
            : base()
        {
        }

        public WrapperMetadata(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public WrapperMetadata(WrapperMetadata? wrapperMetadata)
            : base(wrapperMetadata)
        {
            if (wrapperMetadata != null)
            {
                if (wrapperMetadata.References != null)
                {
                    References = [.. wrapperMetadata.References];
                }
            }
        }

        [JsonInclude, JsonPropertyName("References")]
        public List<string> References { get; set; } = [];
    }
}