using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a property within a serializable object.</summary>
    public abstract class PropertyReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("PropertyName")]
        private readonly string? propertyName;

        public PropertyReference(string? propertyName)
        {
            this.propertyName = propertyName;
        }

        public PropertyReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public PropertyReference(PropertyReference? propertyReference)
            : base(propertyReference)
        {
            if (propertyReference is not null)
            {
                propertyName = propertyReference.PropertyName;
            }
        }

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

        public PropertyReference(USerializableReference? reference, string? propertyName)
            : base(propertyName)
        {
            this.reference = reference;
        }

        public PropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public PropertyReference(PropertyReference<USerializableReference>? propertyReference)
            : base(propertyReference)
        {
            if (propertyReference is not null)
            {
                reference = propertyReference.reference;
            }
        }

        [JsonIgnore]
        public USerializableReference? Reference
        {
            get
            {
                return reference;
            }
        }

        public override string? ToString()
        {
            return string.Format("{0}{1}", reference?.ToString(), Constants.Reference.Separator) + string.Format(Constants.Reference.Format.Property, PropertyName);
        }
    }
}