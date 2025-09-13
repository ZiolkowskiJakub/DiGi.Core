using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class IntegerParameterValue : ParameterValue
    {
        [JsonInclude, JsonPropertyName("Max")]
        private readonly int max = int.MaxValue;

        [JsonInclude, JsonPropertyName("Min")]
        private readonly int min = int.MinValue;
        
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

        public IntegerParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public IntegerParameterValue(IntegerParameterValue? integerParameterValue)
            : base(integerParameterValue)
        {
            if (integerParameterValue != null)
            {
                min = integerParameterValue.min;
                max = integerParameterValue.max;
            }
        }

        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Integer;
        
        public override ISerializableObject? Clone()
        {
            return new IntegerParameterValue(this);
        }

        public override bool IsValid(object? value)
        {
            if (value is not int)
            {
                return false;
            }

            bool result = base.IsValid(value);
            if (!result)
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

        public override bool TryConvert(object? value_In, out object? value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }
    }
}
