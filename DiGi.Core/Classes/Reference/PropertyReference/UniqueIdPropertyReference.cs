using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property by its unique ID.</summary>
    /// <example>
    /// Renders and parses (via <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// nested unique identifier reference, then the property name:
    /// <code>UniqueIdProperty::(UniqueId::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::BLD-001)::Name</code>
    /// </example>
    public class UniqueIdPropertyReference : UniquePropertyReference<UniqueIdReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdPropertyReference"/> class using a unique ID reference and a property name.
        /// </summary>
        /// <param name="reference">The unique ID reference.</param>
        /// <param name="propertyName">The name of the property.</param>
        public UniqueIdPropertyReference(UniqueIdReference? reference, string? propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdPropertyReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public UniqueIdPropertyReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdPropertyReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="uniqueIdPropertyReference">The existing reference to copy.</param>
        public UniqueIdPropertyReference(UniqueIdPropertyReference? uniqueIdPropertyReference)
            : base(uniqueIdPropertyReference)
        {
        }

        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        /// <returns>A deep copy of the current object.</returns>
        public override ISerializableObject Clone()
        {
            return new UniqueIdPropertyReference(this);
        }
    }
}