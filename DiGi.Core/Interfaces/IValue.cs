namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that represents a value.</summary>
    public interface IValue : IObject
    {
    }
 
    /// <summary>Defines a generic contract for an object that represents a value of type TValue.</summary>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public interface IValue<TValue> : IValue
    {
        /// <summary>Retrieves the value cast to a specific type XValue.</summary>
        /// <typeparam name="XValue">The target type for casting.</typeparam>
        /// <returns>The value cast to XValue, or null if not possible.</returns>
        XValue? GetValue<XValue>() where XValue : TValue;
 
        /// <summary>Gets the underlying value.</summary>
        TValue? Value { get; }
    }
}