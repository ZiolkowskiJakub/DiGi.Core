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

        public override int GetHashCode()
        {
            if(hashCode == null)
            {
                hashCode = ToString().GetHashCode();
            }

            return hashCode.Value;
        }
        
        public override bool Equals(object @object)
        {
            if (@object == null)
            {
                return false;
            }

            if (@object is IReference)
            {
                return Equals((IReference)@object);
            }

            return false;
        }

        public bool Equals(IReference reference)
        {
            if(reference == null)
            {
                return false;
            }

             return reference.GetHashCode() == GetHashCode();
        }

        public static bool operator ==(SerializableReference serializableReference_1, ISerializableReference @object)
        {
            return serializableReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        public static bool operator !=(SerializableReference serializableReference_1, ISerializableReference @object)
        {
            return serializableReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        public static bool operator ==(SerializableReference serializableReference_1, object @object)
        {
            return serializableReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        public static bool operator !=(SerializableReference serializableReference_1, object @object)
        {
            return serializableReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        public static bool operator ==(object serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() == serializableReference_2?.GetHashCode();
        }

        public static bool operator !=(object serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() != serializableReference_2?.GetHashCode();
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
