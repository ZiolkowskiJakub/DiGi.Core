using System.Text.Json.Nodes;

namespace DiGi.Core.Interfaces
{
    public interface ISerializableObject : IObject
    {
        JsonObject ToJsonObject();

        bool FromJsonObject(JsonObject jsonObject);

        ISerializableObject Clone();
    }
}
