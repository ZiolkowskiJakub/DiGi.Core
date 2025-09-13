using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class StringParameterValue : ParameterValue
    {
        public StringParameterValue()
            : base()
        {

        }

        public StringParameterValue(bool nullable)
            : base(nullable)
        {

        }

        public StringParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public StringParameterValue(StringParameterValue? stringParameterValue)
            : base(stringParameterValue)
        {
        }

        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.String;
        
        public override ISerializableObject? Clone()
        {
            return new StringParameterValue(this);
        }
    }
}
