using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class SerializableModel : SerializableObject, ISerializableModel
    {
        public SerializableModel()
        {

        }

        public SerializableModel(SerializableModel serializableModel)
            : base()
        {

        }

        public SerializableModel(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
