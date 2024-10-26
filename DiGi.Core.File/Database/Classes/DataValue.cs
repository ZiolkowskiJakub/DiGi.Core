using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Classes
{
    public class DataValue : Data<object>
    {
        public DataValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DataValue(DataValue dataValue)
            : base(dataValue)
        {

        }

        public DataValue(double value)
            : base(value)
        {

        }

        public DataValue(bool value)
            : base(value)
        {

        }

        public DataValue(string value)
            : base(value)
        {

        }

        public DataValue(int value)
            : base(value)
        {

        }

        public DataValue(Guid value)
            : base(value)
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
