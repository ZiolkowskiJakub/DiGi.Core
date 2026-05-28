namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a reference related to a specific type.</summary>
    public interface ITypeRelatedReference : IReference
    {
        /// <summary>Gets the full name of the referenced type.</summary>
        string? FullTypeName { get; }
    }
}