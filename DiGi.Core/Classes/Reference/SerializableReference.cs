using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for serializable references with equality comparison based on hash codes.</summary>
    public abstract class SerializableReference : SerializableObject, ISerializableReference
    {
        [JsonIgnore]
        private int? hashCode = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableReference"/> class.
        /// </summary>
        public SerializableReference()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableReference"/> class from a JSON object.
        /// </summary>
        public SerializableReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableReference"/> class by copying an existing reference.
        /// </summary>
        public SerializableReference(SerializableReference? serializableReference)
            : base(serializableReference)
        {
            if (serializableReference is not null)
            {
                hashCode = serializableReference.hashCode;
            }
        }

        public static bool operator !=(SerializableReference serializableReference_1, ISerializableReference @object)
        {
            return serializableReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        public static bool operator !=(SerializableReference serializableReference_1, object @object)
        {
            return serializableReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        public static bool operator !=(object serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() != serializableReference_2?.GetHashCode();
        }

        public static bool operator !=(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() != serializableReference_2?.GetHashCode();
        }

        public static bool operator ==(SerializableReference serializableReference_1, ISerializableReference @object)
        {
            return serializableReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        public static bool operator ==(SerializableReference serializableReference_1, object @object)
        {
            return serializableReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        public static bool operator ==(object serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() == serializableReference_2?.GetHashCode();
        }

        public static bool operator ==(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() == serializableReference_2?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current serializable reference.
        /// </summary>
        public override bool Equals(object @object)
        {
            if (@object == null)
            {
                return false;
            }

            if (@object is IReference reference)
            {
                return Equals(reference);
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified reference is equal to the current serializable reference.
        /// </summary>
        public bool Equals(IReference reference)
        {
            if (reference == null)
            {
                return false;
            }

            return reference.GetHashCode() == GetHashCode();
        }

        /// <summary>
        /// Gets the hash code for the current type reference.
        /// </summary>
        public override int GetHashCode()
        {
            hashCode ??= ToString().GetHashCode();

            return hashCode.Value;
        }
    }
}