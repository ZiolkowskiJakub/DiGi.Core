using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static DiGi.Core.Constans.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class PropertyReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("PropertyName")]
        private string propertyName;

        public PropertyReference(string propertyName)
        {
            this.propertyName = propertyName;
        }

        public PropertyReference(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public PropertyReference(PropertyReference propertyReference)
            : base(propertyReference)
        {
            if(propertyReference != null)
            {
                propertyName = propertyReference.PropertyName;
            }
        }

        [JsonIgnore]
        public string PropertyName
        {
            get
            {
                return propertyName;
            }
        }
    }

    public abstract class PropertyReference<USerializableReference> : PropertyReference where USerializableReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private USerializableReference reference;

        public PropertyReference(string propertyName, USerializableReference reference)
            :base(propertyName)
        {
            this.reference = reference;
        }

        public PropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public PropertyReference(PropertyReference<USerializableReference> propertyReference)
            : base(propertyReference)
        {
            if (propertyReference != null)
            {
                reference = propertyReference.reference;
            }
        }


        [JsonIgnore]
        public USerializableReference Reference
        {
            get
            {
                return reference;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", reference.ToString(), Constans.Reference.Separator, PropertyName);
        }
    }
}