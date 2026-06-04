using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for external references that identify objects by a unique ID.</summary>
    public abstract class UniqueExternalReference<TUniqueReference> : InstanceRelatedExternalReference<TUniqueReference>, IUniqueReference where TUniqueReference : UniqueReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueExternalReference"/> class with the specified source and unique reference.
        /// </summary>
        public UniqueExternalReference(string? source, TUniqueReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueExternalReference"/> class from the specified JSON object.
        /// </summary>
        public UniqueExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueExternalReference"/> class by copying an existing generic reference.
        /// </summary>
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