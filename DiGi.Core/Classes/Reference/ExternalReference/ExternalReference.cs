using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ExternalReference : SerializableReference, IExternalReference
    {
        [JsonInclude, JsonPropertyName("Source")]
        private readonly string source = string.Empty;

        public ExternalReference(string? source)
            : base()
        {
            if (source is not null)
            {
                this.source = source;
            }
        }

        public ExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalReference(ExternalReference? externalReference)
        : base(externalReference)
        {
            if (externalReference is not null)
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
        private readonly USerializableReference? reference;

        public ExternalReference(string? source, USerializableReference? reference)
            : base(source)
        {
            this.reference = reference;
        }

        public ExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalReference(ExternalReference<USerializableReference>? externalReference)
        : base(externalReference)
        {
            if (externalReference is not null)
            {
                reference = externalReference.Reference;
            }
        }

        [JsonIgnore]
        public USerializableReference? Reference
        {
            get
            {
                return reference;
            }
        }

        public override string? ToString()
        {
            return Convert.ToSystem_String(reference, Source);
        }
    }
}
