using DiGi.Core.Interfaces;
using DiGi.Core.Parameters.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameters
{
    public class GuidParameterValue : ParameterValue
    {
        public override ParameterType ParameterType => ParameterType.Guid;

        public GuidParameterValue()
            : base()
        {

        }

        public GuidParameterValue(bool nullable)
            : base(nullable)
        {

        }

        public GuidParameterValue(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public GuidParameterValue(GuidParameterValue guidParameterValue)
            : base(guidParameterValue)
        {
        }

        public override ISerializableObject Clone()
        {
            return new GuidParameterValue(this);
        }
    }
}
