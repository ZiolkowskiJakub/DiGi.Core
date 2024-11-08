namespace DiGi.Core.Interfaces
{
    public interface IUniqueResult : ISerializableResult, IUniqueObject
    {
    }

    public interface IUniqueResult<T> : IUniqueResult where T : IUniqueObject
    {
    }
}
