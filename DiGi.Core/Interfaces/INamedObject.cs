namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for objects that have a name.</summary>
    public interface INamedObject : IObject
    {
        /// <summary>Gets the name of the object.</summary>
        string? Name { get; }
    }
}