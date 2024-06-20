using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter.Classes
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
