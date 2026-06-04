using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property by its unique ID.</summary>
    public class UniqueIdPropertyReference : UniquePropertyReference<UniqueIdReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdPropertyReference"/> class using a unique ID reference and a property name.
        /// </summary>
        public UniqueIdPropertyReference(UniqueIdReference reference, string propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdPropertyReference"/> class from a JSON object.
        /// </summary>
        public UniqueIdPropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdPropertyReference"/> class by copying an existing reference.
        /// </summary>
        public UniqueIdPropertyReference(UniqueIdPropertyReference uniqueIdPropertyReference)
            : base(uniqueIdPropertyReference)
        {
        }

        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        public override ISerializableObject Clone()
        {
            return new UniqueIdPropertyReference(this);
        }
    }
}