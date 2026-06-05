using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a result containing an external reference unique identifier.
    /// </summary>
    /// <typeparam name="TUniqueObject">The type of the unique object.</typeparam>
    /// <typeparam name="UExternalReference">The type of the external reference.</typeparam>
    public abstract class ExternalReferenceUniqueResult<TUniqueObject, UExternalReference> : UniqueResult<TUniqueObject> where TUniqueObject : IUniqueObject where UExternalReference : IExternalReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly UExternalReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceUniqueResult"/> class.
        /// </summary>
        public ExternalReferenceUniqueResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceUniqueResult"/> class with the specified external reference.
        /// </summary>
        /// <param name="reference">The external reference to initialize with.</param>
        public ExternalReferenceUniqueResult(UExternalReference? reference)
            : base()
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceUniqueResult"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ExternalReferenceUniqueResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalReferenceUniqueResult"/> class from another external reference unique result.
        /// </summary>
        /// <param name="externalReferenceUniqueResult">The external reference unique result to initialize from.</param>
        public ExternalReferenceUniqueResult(ExternalReferenceUniqueResult<TUniqueObject, UExternalReference>? externalReferenceUniqueResult)
            : base(externalReferenceUniqueResult)
        {
            if (externalReferenceUniqueResult != null)
            {
                reference = externalReferenceUniqueResult.reference;
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