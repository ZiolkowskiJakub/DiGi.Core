using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a result containing an external reference GUID.
    /// </summary>
    public abstract class ExternalReferenceGuidResult<TUniqueObject, UExternalReference> : GuidResult<TUniqueObject> where TUniqueObject : IUniqueObject where UExternalReference : IExternalReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly UExternalReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult"/> class.
        /// </summary>
        public ExternalReferenceGuidResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult"/> class with the specified external reference.
        /// </summary>
        public ExternalReferenceGuidResult(UExternalReference? reference)
            : base()
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult"/> class from the specified JSON object.
        /// </summary>
        public ExternalReferenceGuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult"/> class from another external reference GUID result.
        /// </summary>
        public ExternalReferenceGuidResult(ExternalReferenceGuidResult<TUniqueObject, UExternalReference>? externalReferenceGuidResult)
            : base(externalReferenceGuidResult)
        {
            if (externalReferenceGuidResult != null)
            {
                reference = externalReferenceGuidResult.reference;
            }
        }

        /// <summary>
        /// Gets or sets the associated external reference.
        /// </summary>
        [JsonIgnore]
        public UExternalReference? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}