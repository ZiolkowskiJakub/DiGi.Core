using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class DoubleParameterValue : ParameterValue
    {
        [JsonInclude, JsonPropertyName("Min")]
        private readonly double min = double.NaN;

        [JsonInclude, JsonPropertyName("Max")]
        private readonly double max = double.NaN;

        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Double;

        public DoubleParameterValue()
            : base()
        {

        }

        public DoubleParameterValue(bool nullable)
            : base(nullable)
        {

        }

        public DoubleParameterValue(double min, double max)
            : base()
        {
            this.min = min;
            this.max = max;
        }

        public DoubleParameterValue(bool nullable, double min, double max)
            : base(nullable)
        {
            this.min = min;
            this.max = max;
        }

        public DoubleParameterValue(double min)
            : base()
        {
            this.min = min;
        }

        public DoubleParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public DoubleParameterValue(DoubleParameterValue? doubleParameterValue)
            : base(doubleParameterValue)
        {
            if(doubleParameterValue != null)
            {
                min = doubleParameterValue.min;
                max = doubleParameterValue.max;
            }
        }

        public override bool TryConvert(object? value_In, out object? value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }

        public override bool IsValid(object? value)
        {
            if (value is not double)
            {
                return false;
            }

            bool result = base.IsValid(value);
            if(!result)
            {
                return result;
            }

            double @double = (double)value;

            if (!double.IsNaN(min) && @double < min)
            {
                return false;
            }

            if (!double.IsNaN(max) && @double > max)
            {
                return false;
            }

            return result;
        }

        public override ISerializableObject? Clone()
        {
            return new DoubleParameterValue(this);
        }
    }
}
