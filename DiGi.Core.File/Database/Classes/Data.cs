using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.IO.Database.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database.Classes
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
    }

    public abstract class Data<T> : Data, IData<T>
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
        public DataType DataType
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
