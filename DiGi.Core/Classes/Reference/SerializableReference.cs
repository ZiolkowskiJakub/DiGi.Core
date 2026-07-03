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
        /// Initializes a new instance of the <see cref="SerializableReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="serializableReference">The existing reference to copy.</param>
        public SerializableReference(SerializableReference? serializableReference)
            : base(serializableReference)
        {
            if (serializableReference is not null)
            {
                hashCode = serializableReference.hashCode;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the reference from.</param>
        public SerializableReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an <see cref="ISerializableReference"/> for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The object implementing <see cref="ISerializableReference"/> to compare with the serializable reference.</param>
        /// <returns>True if the serializable reference and the object are not equal; otherwise, false.</returns>
        public static bool operator !=(SerializableReference serializableReference_1, ISerializableReference @object)
        {
            return serializableReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an object for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The object to compare with the serializable reference.</param>
        /// <returns>True if the serializable reference and the object are not equal; otherwise, false.</returns>
        public static bool operator !=(SerializableReference serializableReference_1, object @object)
        {
            return serializableReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        /// <summary>
        /// Compares an object and a <see cref="SerializableReference"/> instance for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The object to compare.</param>
        /// <param name="serializableReference_2">The serializable reference to compare with the object.</param>
        /// <returns>True if the object and the serializable reference are not equal; otherwise, false.</returns>
        public static bool operator !=(object serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() != serializableReference_2?.GetHashCode();
        }

        /// <summary>
        /// Compares two <see cref="SerializableReference"/> instances for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The first serializable reference to compare.</param>
        /// <param name="serializableReference_2">The second serializable reference to compare.</param>
        /// <returns>True if the two serializable references are not equal; otherwise, false.</returns>
        public static bool operator !=(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() != serializableReference_2?.GetHashCode();
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an <see cref="ISerializableReference"/> object for equality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The serializable reference object to compare with the first instance.</param>
        /// <returns>True if the serializable reference and the object are equal; otherwise, false.</returns>
        public static bool operator ==(SerializableReference serializableReference_1, ISerializableReference @object)
        {
            return serializableReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an object for equality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The object to compare with the serializable reference.</param>
        /// <returns>True if the serializable reference and the object are equal; otherwise, false.</returns>
        public static bool operator ==(SerializableReference serializableReference_1, object @object)
        {
            return serializableReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        /// <summary>
        /// Compares an object and a <see cref="SerializableReference"/> instance for equality.
        /// </summary>
        /// <param name="serializableReference_1">The object to compare with the serializable reference.</param>
        /// <param name="serializableReference_2">The serializable reference to compare with the object.</param>
        /// <returns>True if the object and the serializable reference are equal; otherwise, false.</returns>
        public static bool operator ==(object serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() == serializableReference_2?.GetHashCode();
        }

        /// <summary>
        /// Compares two <see cref="SerializableReference"/> instances for equality.
        /// </summary>
        /// <param name="serializableReference_1">The first serializable reference to compare.</param>
        /// <param name="serializableReference_2">The second serializable reference to compare.</param>
        /// <returns>True if the two serializable references are equal; otherwise, false.</returns>
        public static bool operator ==(SerializableReference serializableReference_1, SerializableReference serializableReference_2)
        {
            return serializableReference_1?.GetHashCode() == serializableReference_2?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current serializable reference.
        /// </summary>
        /// <param name="object">The object to compare with the current serializable reference.</param>
        /// <returns>True if the specified object is equal to the current serializable reference; otherwise, false.</returns>
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
        /// <param name="reference">The reference to compare with the current serializable reference.</param>
        /// <returns>True if the specified reference is equal to the current serializable reference; otherwise, false.</returns>
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
        /// <returns>The hash code for the current type reference.</returns>
        public override int GetHashCode()
        {
            hashCode ??= ToString().GetHashCode();

            return hashCode.Value;
        }
    }
}