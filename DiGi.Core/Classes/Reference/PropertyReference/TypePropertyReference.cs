using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property by its type.</summary>
    /// <example>
    /// Renders and parses (via <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// nested type reference, then the property name:
    /// <code>TypeProperty::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::Name</code>
    /// </example>
    public class TypePropertyReference : PropertyReference<TypeReference>, ITypeRelatedSerializableReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypePropertyReference"/> class using a type reference and a property name.
        /// </summary>
        /// <param name="reference">The type reference.</param>
        /// <param name="propertyName">The name of the property.</param>
        public TypePropertyReference(TypeReference? reference, string? propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypePropertyReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public TypePropertyReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypePropertyReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="typePropertyReference">The existing reference to copy.</param>
        public TypePropertyReference(TypePropertyReference? typePropertyReference)
            : base(typePropertyReference)
        {
        }

        /// <summary>
        /// Gets the full name of the referenced type.
        /// </summary>
        [JsonIgnore]
        public string? FullTypeName
        {
            get
            {
                return Reference?.FullTypeName;
            }
        }

        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        /// <returns>A deep copy of the current object.</returns>
        public override ISerializableObject Clone()
        {
            return new TypePropertyReference(this);
        }
    }
}