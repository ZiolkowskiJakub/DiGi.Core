namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for options that are both serializable and behave as options.</summary>
    public interface ISerializableOptions : ISerializableObject, IOptions
    {
    }
}