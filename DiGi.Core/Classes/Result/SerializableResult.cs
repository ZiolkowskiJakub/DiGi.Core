using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class SerializableResult : SerializableObject, ISerializableResult
    {
        public SerializableResult()
            : base()
        {

        }

        public SerializableResult(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public SerializableResult(SerializableResult serializableResult)
            : base(serializableResult)
        {

        }
    }

    public abstract class SerializableResult<T> : SerializableResult, ISerializableResult<T> where T: ISerializableObject
    {
        public SerializableResult()
            : base()
        {

        }

        public SerializableResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public SerializableResult(SerializableResult<T> serializableResult)
            : base(serializableResult)
        {

        }
    }
}
