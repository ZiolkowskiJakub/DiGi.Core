using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Represents a reference to a .NET type by its full name.</summary>
    public class TypeReference : SerializableReference, ITypeRelatedSerializableReference
    {
        [JsonInclude, JsonPropertyName("FullTypeName")]
        private readonly string? fullTypeName;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the type reference.</param>
        public TypeReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeReference"/> class by copying an existing type reference.
        /// </summary>
        /// <param name="typeReference">The existing type reference to copy.</param>
        public TypeReference(TypeReference? typeReference)
            : base(typeReference)
        {
            fullTypeName = typeReference?.fullTypeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeReference"/> class using the specified full type name.
        /// </summary>
        /// <param name="fullTypeName">The full name of the type.</param>
        public TypeReference(string? fullTypeName)
            : base()
        {
            this.fullTypeName = fullTypeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeReference"/> class for the specified type.
        /// </summary>
        /// <param name="type">The type to reference.</param>
        public TypeReference(Type? type)
            : base()
        {
            fullTypeName = Query.FullTypeName(type);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeReference"/> class based on the provided object.
        /// </summary>
        /// <param name="object">The object to use for initializing the current type reference.</param>
        public TypeReference(IObject? @object)
            : base()
        {
            fullTypeName = Query.FullTypeName(@object?.GetType());
        }

        /// <summary>
        /// Gets or sets the full name of the referenced type.
        /// </summary>
        [JsonIgnore]
        public string? FullTypeName
        {
            get
            {
                return fullTypeName;
            }
        }

        /// <summary>
        /// Implicitly converts a <see cref="TypeReference"/> to a <see cref="Type"/>.
        /// </summary>
        /// <param name="typeReference">The <see cref="TypeReference"/> instance to convert.</param>
        /// <returns>The <see cref="Type"/> corresponding to the specified type reference, or null if the provided type reference is null.</returns>
        public static implicit operator Type?(TypeReference? typeReference) => Query.Type(typeReference);

        /// <summary>
        /// Implicitly converts a <see cref="Type"/> to a <see cref="TypeReference"/>.
        /// </summary>
        /// <param name="type">The <see cref="Type"/> instance to convert.</param>
        /// <returns>A <see cref="TypeReference"/> representing the specified type, or null if the provided type is null.</returns>
        public static implicit operator TypeReference?(Type? type) => type?.TypeReference();

        /// <summary>
        /// Compares two <see cref="TypeReference"/> instances for inequality based on their full type names.
        /// </summary>
        /// <param name="typeReference_1">The first <see cref="TypeReference"/> to compare.</param>
        /// <param name="typeReference_2">The second <see cref="TypeReference"/> to compare.</param>
        /// <returns>True if the two type references are not equal; otherwise, false.</returns>
        public static bool operator !=(TypeReference? typeReference_1, TypeReference? typeReference_2)
        {
            return !(typeReference_1 == typeReference_2);
        }

        /// <summary>
        /// Compares two <see cref="TypeReference"/> instances for equality based on their full type names.
        /// </summary>
        /// <param name="typeReference_1">The first <see cref="TypeReference"/> to compare.</param>
        /// <param name="typeReference_2">The second <see cref="TypeReference"/> to compare.</param>
        /// <returns>True if the two type references are equal; otherwise, false.</returns>
        public static bool operator ==(TypeReference? typeReference_1, TypeReference? typeReference_2)
        {
            if (typeReference_1 is null)
            {
                return typeReference_2 is null;
            }

            if (typeReference_2 is null)
            {
                return false;
            }

            return typeReference_1.fullTypeName == typeReference_2.fullTypeName;
        }

        /// <summary>
        /// Creates a shallow copy of the current type reference.
        /// </summary>
        /// <returns>A shallow copy of the current type reference.</returns>
        public override ISerializableObject? Clone()
        {
            return new TypeReference(fullTypeName);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current type reference.
        /// </summary>
        /// <param name="obj">The object to compare with the current type reference.</param>
        /// <returns>True if the specified object is equal to the current type reference; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            return obj is TypeReference reference &&
                   base.Equals(obj) &&
                   fullTypeName == reference.fullTypeName;
        }

        /// <summary>
        /// Gets the hash code for the current type reference.
        /// </summary>
        /// <returns>The hash code for the current type reference.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Returns a string representation of the current type reference.
        /// </summary>
        /// <returns>A string that represents the current type reference.</returns>
        public override string? ToString()
        {
            return fullTypeName ?? string.Empty;
        }
    }
}