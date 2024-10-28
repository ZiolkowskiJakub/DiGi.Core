using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Interfaces
{
    public interface IData : ISerializableObject, IDatabaseObject
    {
        UniqueIdReference UniqueIdReference { get; }

        DataType DataType { get; }
    }

    public interface IData<T> : IData where T : JsonNode
    {
        T Value { get; }
    }
}
