using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class BooleanParameterValue : ParameterValue
    {
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Boolean;

        public BooleanParameterValue()
            : base()
        {
        }

        public BooleanParameterValue(bool nullable)
            : base(nullable)
        {
        }

        public BooleanParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public BooleanParameterValue(BooleanParameterValue? booleanParameterValue)
            : base(booleanParameterValue)
        {
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
            if (value is not bool)
            {
                return false;
            }

            return base.IsValid(value);
        }

        public override ISerializableObject? Clone()
        {
            return new BooleanParameterValue(this);
        }
    }
}