using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameters
{
    public class SimpleParameterDefinition : ParameterDefinition
    {
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private string name;

        public SimpleParameterDefinition(string name)
            : base()
        {
            this.name = name;
        }

        public SimpleParameterDefinition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public SimpleParameterDefinition(SimpleParameterDefinition simpleParameterDefinition)
            : base(simpleParameterDefinition)
        {
            if (simpleParameterDefinition != null)
            {
                name = simpleParameterDefinition.Name;
            }
        }

        [JsonIgnore]
        public override string Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public override Enums.ParameterType ParameterType => Enums.ParameterType.Undefined;

        [JsonIgnore]
        public override string UniqueId 
        {
            get
            {
                return name;
            } 
        }

        [JsonIgnore]
        public override string GroupName => Constans.Names.DefaultGroupName;

        public override bool IsValid(object value)
        {
            return base.IsValid(value);
        }
    }
}
