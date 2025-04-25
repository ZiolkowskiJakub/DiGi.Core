using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperGuidReference : WrapperUniqueReference<GuidReference>
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private string fullTypeName;

        [JsonInclude, JsonPropertyName("Guid")]
        private System.Guid guid;

        public WrapperGuidReference(GuidReference guidReference)
            : base()
        {
            if (guidReference != null)
            {
                fullTypeName = guidReference.TypeReference?.FullTypeName;
                guid = guidReference.Guid;
            }
        }

        public WrapperGuidReference(string fullTypeName, System.Guid guid)
            : base()
        {
            this.fullTypeName = fullTypeName;
            this.guid = guid;
        }

        public WrapperGuidReference(System.Type type, System.Guid guid)
            : base()
        {
            fullTypeName = DiGi.Core.Query.FullTypeName(type);
            this.guid = guid;
        }

        public WrapperGuidReference(WrapperGuidReference wrapperGuidReference)
            : base(wrapperGuidReference)
        {
            if (wrapperGuidReference != null)
            {
                fullTypeName = wrapperGuidReference.fullTypeName;
                guid = wrapperGuidReference.guid;
            }
        }

        public WrapperGuidReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public override GuidReference Reference
        {
            get
            {
                return new GuidReference(fullTypeName, guid);
            }
        }

        public override ISerializableObject Clone()
        {
            return new WrapperGuidReference(this);
        }
    }
}