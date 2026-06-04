using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Base class for references to external resources.
    /// </summary>
    public abstract class ExternalReference : SerializableReference, IExternalReference
    {
        [JsonInclude, JsonPropertyName("Source")]
        private readonly string source = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class with a specified source.
        /// </summary>
        public ExternalReference(string? source)
            : base()
        {
            if (source is not null)
            {
                this.source = source;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class from a JSON object.
        /// </summary>
        public ExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class by copying an existing reference.
        /// </summary>
        public ExternalReference(ExternalReference? externalReference)
        : base(externalReference)
        {
            if (externalReference is not null)
            {
                source = externalReference.Source;
            }
        }

        /// <summary>
        /// Gets or sets the source identifier for the external reference.
        /// </summary>
        [JsonIgnore]
        public string Source
        {
            get
            {
                return source;
            }
        }
    }

    /// <summary>
    /// Base class for references to external resources.
    /// </summary>
    public abstract class ExternalReference<USerializableReference> : ExternalReference where USerializableReference : ISerializableReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly USerializableReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class with a specified source and serializable reference.
        /// </summary>
        public ExternalReference(string? source, USerializableReference? reference)
            : base(source)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class from a JSON object.
        /// </summary>
        public ExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class by copying an existing generic reference.
        /// </summary>
        public ExternalReference(ExternalReference<USerializableReference>? externalReference)
        : base(externalReference)
        {
            if (externalReference is not null)
            {
                reference = externalReference.Reference;
            }
        }

        /// <summary>
        /// Gets or sets the serializable reference object.
        /// </summary>
        [JsonIgnore]
        public USerializableReference? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary>
        /// Returns a string representation of the external reference.
        /// </summary>
        public override string? ToString()
        {
            return Convert.ToSystem_String(reference, Source);
        }
    }
}