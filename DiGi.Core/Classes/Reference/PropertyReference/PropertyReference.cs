using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property within a serializable object.</summary>
    public abstract class PropertyReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("PropertyName")]
        private readonly string? propertyName;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class with the specified property name.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public PropertyReference(string? propertyName)
        {
            this.propertyName = propertyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class from the specified nullable JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to create the reference from.</param>
        public PropertyReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="propertyReference">The property reference to copy.</param>
        public PropertyReference(PropertyReference? propertyReference)
            : base(propertyReference)
        {
            if (propertyReference is not null)
            {
                propertyName = propertyReference.PropertyName;
            }
        }

        /// <summary>
        /// Gets or sets the name of the referenced property.
        /// </summary>
        [JsonIgnore]
        public string? PropertyName
        {
            get
            {
                return propertyName;
            }
        }
    }

    /// <summary>Represents a typed reference to a property within a serializable object.</summary>
    /// <typeparam name="USerializableReference">The type of the serializable reference.</typeparam>
    public abstract class PropertyReference<USerializableReference> : PropertyReference where USerializableReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly USerializableReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class with the specified serializable reference and property name.
        /// </summary>
        /// <param name="reference">The serializable reference.</param>
        /// <param name="propertyName">The name of the property.</param>
        public PropertyReference(USerializableReference? reference, string? propertyName)
            : base(propertyName)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public PropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class by copying an existing generic reference.
        /// </summary>
        /// <param name="propertyReference">The generic property reference to copy.</param>
        public PropertyReference(PropertyReference<USerializableReference>? propertyReference)
            : base(propertyReference)
        {
            if (propertyReference is not null)
            {
                reference = propertyReference.reference;
            }
        }

        /// <summary>
        /// Gets or sets the serializable reference associated with this property reference.
        /// </summary>
        [JsonIgnore]
        public USerializableReference? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string representation of the current object.</returns>
        public override string? ToString()
        {
            return string.Format("{0}{1}", reference?.ToString(), Constants.Reference.Separator) + string.Format(Constants.Reference.Format.Property, PropertyName);
        }
    }
}