namespace DiGi.Core.Interfaces
{
    public interface IResult : ISerializableObject
    {
    }

    public interface IResult<T> : ISerializableObject where T :ISerializableObject
    {
    }
}
