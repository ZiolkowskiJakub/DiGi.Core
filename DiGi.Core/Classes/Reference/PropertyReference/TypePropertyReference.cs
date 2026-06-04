using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property by its type.</summary>
    public class TypePropertyReference : PropertyReference<TypeReference>, ITypeRelatedSerializableReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypePropertyReference"/> class using a type reference and a property name.
        /// </summary>
        public TypePropertyReference(TypeReference reference, string propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypePropertyReference"/> class from a JSON object.
        /// </summary>
        public TypePropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypePropertyReference"/> class by copying an existing reference.
        /// </summary>
        public TypePropertyReference(TypePropertyReference typePropertyReference)
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
        public override ISerializableObject Clone()
        {
            return new TypePropertyReference(this);
        }
    }
}