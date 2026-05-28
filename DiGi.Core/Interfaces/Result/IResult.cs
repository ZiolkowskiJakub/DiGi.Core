namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that represents the result of an operation.</summary>
    public interface IResult : IObject
    {
    }
 
    /// <summary>Defines a generic contract for a result containing a value of type T.</summary>
    /// <typeparam name="T">The type of the result value.</typeparam>
    public interface IResult<T> : IResult
    {
    }
}