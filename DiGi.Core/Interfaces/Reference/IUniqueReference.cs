using DiGi.Core.Classes;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a unique reference to an object.</summary>
    public interface IUniqueReference : IInstanceRelatedSerializableReference
    {
        /// <summary>Gets the type reference associated with this unique reference.</summary>
        TypeReference? TypeReference { get; }

        /// <summary>Gets the unique identifier of the referenced object.</summary>
        string? UniqueId { get; }
    }
}