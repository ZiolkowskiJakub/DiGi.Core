namespace DiGi.Core.Interfaces
{
    public interface IGuidResult : IUniqueResult
    {
    }

    public interface IGuidResult<T> : IUniqueResult<T> where T : IUniqueObject
    {
    }
}
