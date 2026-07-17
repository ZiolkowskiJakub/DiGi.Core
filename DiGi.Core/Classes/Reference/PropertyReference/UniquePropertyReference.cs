using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property by its unique reference.</summary>
    /// <typeparam name="UUniquePropertyReference">The type of the unique property reference.</typeparam>
    /// <remarks>
    /// TODO [ReferenceFormat]: This type was made abstract as part of the discriminated format. A closed instance
    /// would render identically to the matching concrete subclass - <see cref="GuidPropertyReference"/> or
    /// <see cref="UniqueIdPropertyReference"/> - because the discriminator is the only thing separating them, and a
    /// generic type has no stable short discriminator. External code that instantiated it directly no longer compiles
    /// and must use a subclass.
    /// </remarks>
    public abstract class UniquePropertyReference<UUniquePropertyReference> : PropertyReference<UUniquePropertyReference>, IInstanceRelatedSerializableReference where UUniquePropertyReference : UniqueReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniquePropertyReference{UUniquePropertyReference}"/> class using a unique property reference and a property name.
        /// </summary>
        /// <param name="reference">The unique property reference.</param>
        /// <param name="propertyName">The name of the property.</param>
        public UniquePropertyReference(UUniquePropertyReference? reference, string? propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniquePropertyReference{UUniquePropertyReference}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the reference from.</param>
        public UniquePropertyReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniquePropertyReference{UUniquePropertyReference}"/> class by copying an existing reference.
        /// </summary>
        /// <param name="uniquePropertyReference">The unique property reference to copy.</param>
        public UniquePropertyReference(UniquePropertyReference<UUniquePropertyReference>? uniquePropertyReference)
            : base(uniquePropertyReference)
        {
        }
    }
}