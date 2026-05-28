namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that has a unique identifier.</summary>
    public interface IUniqueObject : ISerializableObject
    {
        /// <summary>Gets the unique identifier of the object.</summary>
        string? UniqueId { get; }
    }
}