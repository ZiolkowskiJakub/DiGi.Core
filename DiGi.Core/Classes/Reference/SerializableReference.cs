using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class SerializableReference : SerializableObject, ISerializableReference
    {
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

        }

        public override bool Equals(object @object)
        {
            SerializableReference serializableReference = @object as SerializableReference;
            if (serializableReference == null)
            {
                return false;
            }

            return serializableReference.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.ToString() == serializableReference_2?.ToString();
        }

        public static bool operator !=(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.ToString() != serializableReference_2?.ToString();
        }
    }
}
