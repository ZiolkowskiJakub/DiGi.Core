using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class GuidParameterValue : ParameterValue
    {
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Guid;

        public GuidParameterValue()
            : base()
        {
        }

        public GuidParameterValue(bool nullable)
            : base(nullable)
        {
        }

        public GuidParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public GuidParameterValue(GuidParameterValue? guidParameterValue)
            : base(guidParameterValue)
        {
        }

        public override ISerializableObject? Clone()
        {
            return new GuidParameterValue(this);
        }
    }
}