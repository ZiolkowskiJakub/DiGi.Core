using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter.Classes
{
    public class IntegerParameterValue : ParameterValue
    {
        private int min = int.MinValue;
        private int max = int.MaxValue;

        public override ParameterType ParameterType => ParameterType.Integer;

        public IntegerParameterValue()
            : base()
        {

        }

        public IntegerParameterValue(bool nullable)
            : base(nullable)
        {

        }

        public IntegerParameterValue(int min, int max)
            : base()
        {
            this.min = min;
            this.max = max;
        }

        public IntegerParameterValue(bool nullable, int min, int max)
            : base(nullable)
        {
            this.min = min;
            this.max = max;
        }

        public IntegerParameterValue(int min)
            : base()
        {
            this.min = min;
        }

        public IntegerParameterValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public IntegerParameterValue(IntegerParameterValue integerParameterValue)
            : base(integerParameterValue)
        {
            if(integerParameterValue != null)
            {
                min = integerParameterValue.min;
                max = integerParameterValue.max;
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
            if (!(value is int))
            {
                return false;
            }

            bool result = base.IsValid(value);
            if(!result)
            {
                return result;
            }

            int @int = (int)value;

            if (@int < min)
            {
                return false;
            }

            if (@int > max)
            {
                return false;
            }

            return result;
        }

        public override ISerializableObject Clone()
        {
            return new IntegerParameterValue(this);
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
                min = (int)jsonObject["Min"];
            }

            if (jsonObject.ContainsKey("Max"))
            {
                max = (int)jsonObject["Max"];
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

            if (min != int.MinValue)
            {
                result["Min"] = min;
            }

            if (max != int.MaxValue)
            {
                result["Max"] = max;
            }

            return result;
        }
    }
}
