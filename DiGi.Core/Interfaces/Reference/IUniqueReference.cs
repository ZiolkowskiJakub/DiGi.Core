using DiGi.Core.Classes;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a unique reference to an object.</summary>
    /// <remarks>
    /// Compare two <see cref="IUniqueReference"/> values with <see cref="Query.Equals(IReference?, IReference?)"/>,
    /// NEVER with <c>==</c> or <c>!=</c> - between two interface typed operands those operators are plain reference
    /// equality. See <see cref="IReference"/> for the full explanation.
    /// </remarks>
    public interface IUniqueReference : IInstanceRelatedSerializableReference
    {
        /// <summary>Gets the type reference associated with this unique reference.</summary>
        TypeReference? TypeReference { get; }

        /// <summary>Gets the unique identifier of the referenced object.</summary>
        string? UniqueId { get; }
    }
}