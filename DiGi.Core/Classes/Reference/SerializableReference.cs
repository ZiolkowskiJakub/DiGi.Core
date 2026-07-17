using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Base class for serializable references, owning the rendering of the reference string and equality based on it.
    /// <para>Derived types do not override <see cref="ToString"/>; they declare <see cref="Segments"/> and this class
    /// adds the discriminator, the separators and the caching. That keeps every reference on one grammar - a type
    /// cannot forget its discriminator or its escaping - and lets one rendered string serve
    /// <see cref="ToString"/>, <see cref="Equals(IReference?)"/> and <see cref="GetHashCode"/> alike.</para>
    /// </summary>
    public abstract class SerializableReference : SerializableObject, ISerializableReference
    {
        [JsonIgnore]
        private int? hashCode = null;

        [JsonIgnore]
        private string? @string = null;

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
            // TODO [ReferenceFormat]: The cached hash code used to be copied from the source here. It is deliberately
            // no longer copied, and the rendered-string cache is not copied either: this constructor runs BEFORE the
            // derived constructor assigns the fields the caches are derived from, so copying was only ever correct
            // because every copy constructor happens to reproduce identical state. Both caches rebuild lazily.
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
        public static bool operator !=(SerializableReference? serializableReference_1, ISerializableReference? @object)
        {
            return !(serializableReference_1 == @object);
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an object for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The object to compare with the serializable reference.</param>
        /// <returns>True if the serializable reference and the object are not equal; otherwise, false.</returns>
        public static bool operator !=(SerializableReference? serializableReference_1, object? @object)
        {
            return !(serializableReference_1 == @object);
        }

        /// <summary>
        /// Compares an object and a <see cref="SerializableReference"/> instance for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The object to compare.</param>
        /// <param name="serializableReference_2">The serializable reference to compare with the object.</param>
        /// <returns>True if the object and the serializable reference are not equal; otherwise, false.</returns>
        public static bool operator !=(object? serializableReference_1, SerializableReference? serializableReference_2)
        {
            return !(serializableReference_1 == serializableReference_2);
        }

        /// <summary>
        /// Compares two <see cref="SerializableReference"/> instances for inequality.
        /// </summary>
        /// <param name="serializableReference_1">The first serializable reference to compare.</param>
        /// <param name="serializableReference_2">The second serializable reference to compare.</param>
        /// <returns>True if the two serializable references are not equal; otherwise, false.</returns>
        public static bool operator !=(SerializableReference? serializableReference_1, SerializableReference? serializableReference_2)
        {
            return !(serializableReference_1 == serializableReference_2);
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an <see cref="ISerializableReference"/> object for equality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The serializable reference object to compare with the first instance.</param>
        /// <returns>True if the serializable reference and the object are equal; otherwise, false.</returns>
        public static bool operator ==(SerializableReference? serializableReference_1, ISerializableReference? @object)
        {
            return serializableReference_1 is null ? @object is null : serializableReference_1.Equals(@object);
        }

        /// <summary>
        /// Compares a <see cref="SerializableReference"/> instance and an object for equality.
        /// </summary>
        /// <param name="serializableReference_1">The serializable reference to compare.</param>
        /// <param name="object">The object to compare with the serializable reference.</param>
        /// <returns>True if the serializable reference and the object are equal; otherwise, false.</returns>
        public static bool operator ==(SerializableReference? serializableReference_1, object? @object)
        {
            return serializableReference_1 is null ? @object is null : serializableReference_1.Equals(@object);
        }

        /// <summary>
        /// Compares an object and a <see cref="SerializableReference"/> instance for equality.
        /// </summary>
        /// <param name="serializableReference_1">The object to compare with the serializable reference.</param>
        /// <param name="serializableReference_2">The serializable reference to compare with the object.</param>
        /// <returns>True if the object and the serializable reference are equal; otherwise, false.</returns>
        public static bool operator ==(object? serializableReference_1, SerializableReference? serializableReference_2)
        {
            return serializableReference_2 is null ? serializableReference_1 is null : serializableReference_2.Equals(serializableReference_1);
        }

        /// <summary>
        /// Compares two <see cref="SerializableReference"/> instances for equality.
        /// </summary>
        /// <param name="serializableReference_1">The first serializable reference to compare.</param>
        /// <param name="serializableReference_2">The second serializable reference to compare.</param>
        /// <returns>True if the two serializable references are equal; otherwise, false.</returns>
        public static bool operator ==(SerializableReference? serializableReference_1, SerializableReference? serializableReference_2)
        {
            return serializableReference_1 is null ? serializableReference_2 is null : serializableReference_1.Equals(serializableReference_2);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current serializable reference.
        /// </summary>
        /// <param name="object">The object to compare with the current serializable reference.</param>
        /// <returns>True if the specified object is equal to the current serializable reference; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            return @object is IReference reference && Equals(reference);
        }

        /// <summary>
        /// Determines whether the specified reference is equal to the current serializable reference. References of
        /// different runtime types are never equal, which keeps the comparison symmetric for derived types that
        /// narrow equality further.
        /// </summary>
        /// <param name="reference">The reference to compare with the current serializable reference.</param>
        /// <returns>True if the specified reference is equal to the current serializable reference; otherwise, false.</returns>
        public bool Equals(IReference? reference)
        {
            if (reference is null)
            {
                return false;
            }

            if (ReferenceEquals(this, reference))
            {
                return true;
            }

            if (reference.GetType() != GetType())
            {
                return false;
            }

            return reference.GetHashCode() == GetHashCode() && reference.ToString() == ToString();
        }

        /// <summary>
        /// Gets the segments of this reference's string form, in order and already escaped.
        /// <para>Render a scalar with <see cref="Query.Segment(string?)"/> and a nested reference with
        /// <see cref="Query.Segment(IReference?)"/>. Do NOT include the discriminator, the separators or any
        /// surrounding decoration - <see cref="ToString"/> adds those and caches the result.</para>
        /// <para>The order and count declared here IS the parse contract. The method marked with
        /// <see cref="ReferenceFactoryAttribute"/> for this type must consume exactly these segments, in this order;
        /// changing one without the other silently breaks the round trip.</para>
        /// </summary>
        [JsonIgnore]
        protected abstract IEnumerable<string?> Segments { get; }

        /// <summary>
        /// Returns the reference string: this type's discriminator followed by its <see cref="Segments"/>.
        /// <para>Sealed on purpose. The base owns rendering so that no reference type can drift off the grammar by
        /// omitting its discriminator or its escaping, and so the result can be cached once and reused by
        /// <see cref="Equals(IReference?)"/> and <see cref="GetHashCode"/>. Derived types contribute
        /// <see cref="Segments"/> instead.</para>
        /// <para>Never returns null for a type with a registered factory, because the discriminator is always
        /// emitted.</para>
        /// </summary>
        /// <returns>The reference string.</returns>
        public sealed override string? ToString()
        {
            // TODO [ReferenceFormat]: Sealing ToString() is a breaking change for any subclass outside this solution
            // that overrode it. Such a type must override Segments instead. Unsealing would also cost the cache
            // below, which Equals depends on.
            return @string ??= Convert.ToSystem_String(GetType(), Segments);
        }

        /// <summary>
        /// Gets the hash code for the current reference, derived from its cached string form.
        /// </summary>
        /// <returns>The hash code for the current reference.</returns>
        public override int GetHashCode()
        {
            hashCode ??= (ToString() ?? string.Empty).GetHashCode();

            return hashCode.Value;
        }
    }
}