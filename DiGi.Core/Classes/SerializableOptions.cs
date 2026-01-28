using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class SerializableOptions : SerializableObject, ISerializableOptions
    {
        public SerializableOptions()
        {
        }

        public SerializableOptions(SerializableOptions? serializableOptions)
            : base(serializableOptions)
        {
        }

        public SerializableOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}