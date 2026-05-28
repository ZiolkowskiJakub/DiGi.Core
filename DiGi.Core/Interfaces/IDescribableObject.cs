namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that has a description.</summary>
    public interface IDescribableObject : IObject
    {
        /// <summary>Gets the description of the object.</summary>
        string? Description { get; }
    }
}