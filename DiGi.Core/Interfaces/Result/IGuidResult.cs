namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a result uniquely identified by a GUID.</summary>
    public interface IGuidResult : IUniqueResult
    {
    }

    /// <summary>Defines a generic contract for a GUID-identified result containing a value of type T.</summary>
    /// <typeparam name="T">The type of the GUID result value.</typeparam>
    public interface IGuidResult<T> : IUniqueResult<T> where T : IUniqueObject
    {
    }
}