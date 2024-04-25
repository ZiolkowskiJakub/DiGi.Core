using DiGi.Core.Interfaces;
using DiGi.Core.Parameters.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameters
{
    public class StringParameterValue : ParameterValue
    {
        public override ParameterType ParameterType => ParameterType.String;

        public StringParameterValue()
            : base()
        {

        }

        public StringParameterValue(bool nullable)
            : base(nullable)
        {

        }

        public StringParameterValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public StringParameterValue(StringParameterValue stringParameterValue)
            : base(stringParameterValue)
        {
        }

        public override ISerializableObject Clone()
        {
            return new StringParameterValue(this);
        }
    }
}
