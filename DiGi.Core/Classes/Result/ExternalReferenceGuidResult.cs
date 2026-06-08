using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a result containing an external reference GUID.
    /// </summary>
    /// <typeparam name="TUniqueObject">The type of the unique object.</typeparam>
    /// <typeparam name="UExternalReference">The type of the external reference.</typeparam>
    public abstract class ExternalReferenceGuidResult<TUniqueObject, UExternalReference> : GuidResult<TUniqueObject> where TUniqueObject : IUniqueObject where UExternalReference : IExternalReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly UExternalReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult{TUniqueObject, UExternalReference}"/> class.
        /// </summary>
        public ExternalReferenceGuidResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult{TUniqueObject, UExternalReference}"/> class with the specified external reference.
        /// </summary>
        /// <param name="reference">The external reference to use.</param>
        public ExternalReferenceGuidResult(UExternalReference? reference)
            : base()
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult{TUniqueObject, UExternalReference}"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ExternalReferenceGuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceGuidResult{TUniqueObject, UExternalReference}"/> class from another external reference GUID result.
        /// </summary>
        /// <param name="externalReferenceGuidResult">The external reference GUID result to copy from.</param>
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