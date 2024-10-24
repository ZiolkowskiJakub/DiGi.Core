using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class SerializableReference : SerializableObject, ISerializableReference
    {
        public SerializableReference()
            :base()
        {

        }

        public SerializableReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
