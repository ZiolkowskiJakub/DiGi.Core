using System.Text.Json.Nodes;

namespace DiGi.Core.Interfaces
{
    public interface ISerializableResult : IResult, ISerializableObject
    {

    }

    public interface ISerializableResult<T> : ISerializableResult where T : ISerializableObject
    {

    }
}
