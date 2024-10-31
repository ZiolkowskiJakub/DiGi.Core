using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public abstract class Data : SerializableObject, IData
    {
        public Data()
            : base()
        {

        }

        public Data(Data data)
            : base()
        {

        }

        public Data(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public abstract UniqueIdReference UniqueIdReference { get; }

        public abstract DataType DataType { get; }
    }

    public abstract class Data<T> : Data, IData<T> where T : JsonNode
    {
        [JsonInclude, JsonPropertyName("Value")]
        protected T value;

        [JsonIgnore]
        private UniqueIdReference uniqueIdReference = null;

        public Data(T value)
            :base()
        {
            this.value = value;
        }

        public Data(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Data(Data<T> data)
            : base(data)
        {
            if (data != null)
            {
                value = data.value;
            }
        }

        public Data()
            :base()
        {
            value = default;
        }

        [JsonIgnore]
        public override DataType DataType
        {
            get
            {
                return Core.Query.DataType(value);
            }
        }

        [JsonIgnore]
        public override UniqueIdReference UniqueIdReference
        {
            get
            {
                if (value == null)
                {
                    return null;
                }

                if (uniqueIdReference == null)
                {
                    uniqueIdReference = Core.Create.UniqueIdReference(value);
                }

                return uniqueIdReference?.Clone() as UniqueIdReference;
            }
        }

        [JsonIgnore]
        public T Value
        {
            get
            {
                return value;
            }
        }
    }
}
