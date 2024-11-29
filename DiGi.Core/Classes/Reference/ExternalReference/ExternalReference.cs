using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ExternalReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("Source")]
        private string source;

        public ExternalReference(string source)
            : base()
        {
            this.source = source;
        }

        public ExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalReference(ExternalReference externalReference)
        : base(externalReference)
        {
            if (externalReference != null)
            {
                source = externalReference.Source;
            }
        }

        [JsonIgnore]
        public string Source
        {
            get
            {
                return source;
            }
        }
    }

    public abstract class ExternalReference<USerializableReference> : ExternalReference where USerializableReference : ISerializableReference
    {

        [JsonInclude, JsonPropertyName("Reference")]
        private USerializableReference reference;

        public ExternalReference(string source, USerializableReference reference)
            : base(source)
        {
            this.reference = reference;
        }

        public ExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalReference(ExternalReference<USerializableReference> externalReference)
        : base(externalReference)
        {
            if (externalReference != null)
            {
                reference = externalReference.Reference;
            }
        }

        public override string ToString()
        {
            return Convert.ToSystem_String(reference, Source);
        }

        [JsonIgnore]
        public USerializableReference Reference
        {
            get
            {
                return reference;
            }
        }
    }
}
