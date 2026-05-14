using System.Text.Json.Nodes;

namespace DiGi.Core.Interfaces
{
    public interface ISerializableObject : ICloneableObject<ISerializableObject>
    {
        JsonObject? ToJsonObject();

        bool FromJsonObject(JsonObject? jsonObject);
    }
}