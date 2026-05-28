namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a serializable result that is uniquely identified.</summary>
    public interface IUniqueResult : ISerializableResult, IUniqueObject
    {
    }
 
    /// <summary>Defines a generic contract for a uniquely identified result containing a value of type T.</summary>
    /// <typeparam name="T">The type of the unique result value.</typeparam>
    public interface IUniqueResult<T> : IUniqueResult where T : IUniqueObject
    {
    }
}