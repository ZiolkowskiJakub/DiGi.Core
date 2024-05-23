using System.Text.Json.Nodes;

namespace DiGi.Core.Interfaces
{
    public interface ISerializableResult : IResult, ISerializableObject
    {
        JsonObject ToJsonObject();

        bool FromJsonObject(JsonObject jsonObject);

        ISerializableObject Clone();
    }
}
