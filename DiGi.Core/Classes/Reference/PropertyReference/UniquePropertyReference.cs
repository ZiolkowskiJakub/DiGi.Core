using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property by its unique reference.</summary>
    public class UniquePropertyReference<UUniquePropertyReference> : PropertyReference<UUniquePropertyReference>, IInstanceRelatedSerializableReference where UUniquePropertyReference : UniqueReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniquePropertyReference"/> class using a unique property reference and a property name.
        /// </summary>
        public UniquePropertyReference(UUniquePropertyReference reference, string propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniquePropertyReference"/> class from a JSON object.
        /// </summary>
        public UniquePropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniquePropertyReference"/> class by copying an existing reference.
        /// </summary>
        public UniquePropertyReference(UniquePropertyReference<UUniquePropertyReference> uniquePropertyReference)
            : base(uniquePropertyReference)
        {
        }
    }
}