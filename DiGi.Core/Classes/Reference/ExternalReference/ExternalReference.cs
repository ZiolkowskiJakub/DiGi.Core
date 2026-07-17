using DiGi.Core.Interfaces;
using System.Collections.Generic;
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
        /// <param name="source">The source string for the external reference.</param>
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
        /// <param name="jsonObject">The JSON object used to initialize the reference.</param>
        public ExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="externalReference">The external reference to copy.</param>
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
    /// <typeparam name="USerializableReference">The type of the serializable reference.</typeparam>
    public abstract class ExternalReference<USerializableReference> : ExternalReference where USerializableReference : ISerializableReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly USerializableReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class with a specified source and serializable reference.
        /// </summary>
        /// <param name="source">The source of the external reference.</param>
        /// <param name="reference">The serializable reference to use.</param>
        public ExternalReference(string? source, USerializableReference? reference)
            : base(source)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReference"/> class by copying an existing generic reference.
        /// </summary>
        /// <param name="externalReference">The external reference to copy from.</param>
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
        /// Gets the segments of this reference's string form: the source, then the nested reference.
        /// </summary>
        [JsonIgnore]
        protected override IEnumerable<string?> Segments
        {
            get
            {
                return [Query.Segment(Source), Query.Segment(reference as IReference)];
            }
        }
    }
}