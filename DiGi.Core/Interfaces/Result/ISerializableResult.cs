namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a result object that can be serialized.</summary>
    public interface ISerializableResult : IResult, ISerializableObject
    {
    }

    /// <summary>Defines a generic contract for a serializable result containing a value of type T.</summary>
    /// <typeparam name="T">The type of the serializable result value.</typeparam>
    public interface ISerializableResult<T> : ISerializableResult where T : ISerializableObject
    {
    }
}