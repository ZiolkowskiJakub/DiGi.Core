using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for external references that identify objects by a unique ID.</summary>
    /// <typeparam name="TUniqueReference">The type of the unique reference identifier.</typeparam>
    public abstract class UniqueExternalReference<TUniqueReference> : InstanceRelatedExternalReference<TUniqueReference>, IUniqueReference where TUniqueReference : UniqueReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueExternalReference"/> class with the specified source and unique reference.
        /// </summary>
        /// <param name="source">The source identifier.</param>
        /// <param name="reference">The unique reference value.</param>
        public UniqueExternalReference(string? source, TUniqueReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueExternalReference"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public UniqueExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueExternalReference"/> class by copying an existing generic reference.
        /// </summary>
        /// <param name="externalReference">The external reference to copy.</param>
        public UniqueExternalReference(UniqueExternalReference<TUniqueReference>? externalReference)
        : base(externalReference)
        {
        }

        /// <summary>
        /// Gets or sets the type reference associated with this object.
        /// </summary>
        public TypeReference? TypeReference
        {
            get
            {
                return Reference?.TypeReference;
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier for this reference.
        /// </summary>
        public string? UniqueId
        {
            get
            {
                return Reference?.UniqueId;
            }
        }
    }
}