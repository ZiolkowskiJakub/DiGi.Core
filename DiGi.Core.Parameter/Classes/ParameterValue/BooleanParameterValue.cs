using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter.Classes
{
    public class BooleanParameterValue : ParameterValue
    {
        public override ParameterType ParameterType => ParameterType.Boolean;

        public BooleanParameterValue()
            : base()
        {

        }

        public BooleanParameterValue(bool nullable)
            : base(nullable)
        {

        }

        public BooleanParameterValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public BooleanParameterValue(BooleanParameterValue booleanParameterValue)
            : base(booleanParameterValue)
        {
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
            if (!(value is bool))
            {
                return false;
            }

            return base.IsValid(value);
        }

        public override ISerializableObject Clone()
        {
            return new BooleanParameterValue(this);
        }

        public override bool FromJsonObject(JsonObject jsonObject)
        {
            bool result = base.FromJsonObject(jsonObject);
            if(!result)
            {
                return result;
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

            return result;
        }
    }
}
