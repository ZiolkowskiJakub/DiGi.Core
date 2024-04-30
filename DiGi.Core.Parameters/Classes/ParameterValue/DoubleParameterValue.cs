using DiGi.Core.Interfaces;
using DiGi.Core.Parameters.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameters
{
    public class DoubleParameterValue : ParameterValue
    {
        private double min = double.NaN;
        private double max = double.NaN;

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

        public DoubleParameterValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DoubleParameterValue(DoubleParameterValue doubleParameterValue)
            : base(doubleParameterValue)
        {
            if(doubleParameterValue != null)
            {
                min = doubleParameterValue.min;
                max = doubleParameterValue.max;
            }
        }

        public override bool TryConvert(object value_In, out object value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }

        public override bool IsValid(object value)
        {
            if (!(value is double))
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

        public override ISerializableObject Clone()
        {
            return new DoubleParameterValue(this);
        }

        public override bool FromJsonObject(JsonObject jsonObject)
        {
            bool result = base.FromJsonObject(jsonObject);
            if(!result)
            {
                return result;
            }

            if (jsonObject.ContainsKey("Min"))
            {
                min = (double)jsonObject["Min"];
            }

            if (jsonObject.ContainsKey("Max"))
            {
                max = (double)jsonObject["Max"];
            }

            return true;
        }

        public override JsonObject ToJsonObject()
        {
            JsonObject result = base.ToJsonObject();
            if(result == null)
            {
                return result;
            }

            if (!double.IsNaN(min))
            {
                result["Min"] = min;
            }

            if (!double.IsNaN(max))
            {
                result["Max"] = max;
            }

            return result;
        }
    }
}
