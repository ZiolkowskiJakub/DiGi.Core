using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class SerializableReference : SerializableObject, ISerializableReference
    {
        [JsonIgnore]
        private int? hashCode = null;
        
        public SerializableReference()
            :base()
        {

        }

        public SerializableReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public SerializableReference(SerializableReference serializableReference)
            : base(serializableReference)
        {
            if(serializableReference != null)
            {
                hashCode = serializableReference.hashCode;
            }
        }

        public override bool Equals(object @object)
        {
            SerializableReference serializableReference = @object as SerializableReference;
            if (serializableReference == null)
            {
                return false;
            }

            return serializableReference.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            if(hashCode == null)
            {
                hashCode = ToString().GetHashCode();
            }

            return hashCode.Value;
        }

        public static bool operator ==(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() == serializableReference_2?.GetHashCode();
        }

        public static bool operator !=(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() != serializableReference_2?.GetHashCode();
        }
    }
}
