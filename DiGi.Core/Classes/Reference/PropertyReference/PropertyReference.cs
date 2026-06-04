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
        public PropertyReference(string? propertyName)
        {
            this.propertyName = propertyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class from the specified nullable JSON object.
        /// </summary>
        public PropertyReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class by copying an existing reference.
        /// </summary>
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
    public abstract class PropertyReference<USerializableReference> : PropertyReference where USerializableReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly USerializableReference? reference;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class with the specified serializable reference and property name.
        /// </summary>
        public PropertyReference(USerializableReference? reference, string? propertyName)
            : base(propertyName)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class from the specified JSON object.
        /// </summary>
        public PropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyReference"/> class by copying an existing generic reference.
        /// </summary>
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
        public override string? ToString()
        {
            return string.Format("{0}{1}", reference?.ToString(), Constants.Reference.Separator) + string.Format(Constants.Reference.Format.Property, PropertyName);
        }
    }
}