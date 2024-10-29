using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Classes
{
    public class DataValue : Data<JsonValue>
    {
        public DataValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DataValue(DataValue dataValue)
            : base(dataValue)
        {

        }

        public DataValue(JsonValue jsonValue)
            : base(jsonValue)
        {

        }

        public DataValue(double value)
            : base(JsonValue.Create(value))
        {

        }

        public DataValue(bool value)
            : base(JsonValue.Create(value))
        {

        }

        public DataValue(string value)
            : base(JsonValue.Create(value))
        {

        }

        public DataValue(int value)
            : base(JsonValue.Create(value))
        {

        }

        public DataValue(Guid value)
            : base(JsonValue.Create(value))
        {

        }

        public DataValue()
            : base()
        {

        }

        public override ISerializableObject Clone()
        {
            return new DataValue(this);
        }

    }
}
