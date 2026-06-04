using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a definition for a simple parameter.
    /// </summary>
    public class SimpleParameterDefinition : ParameterDefinition
    {
        [JsonInclude, JsonPropertyName("Name"), Description("Name")]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleParameterDefinition"/> class with the specified name.
        /// </summary>
        public SimpleParameterDefinition(string? name)
            : base()
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleParameterDefinition"/> class from a JSON object.
        /// </summary>
        public SimpleParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleParameterDefinition"/> class by copying an existing definition.
        /// </summary>
        public SimpleParameterDefinition(SimpleParameterDefinition? simpleParameterDefinition)
            : base(simpleParameterDefinition)
        {
            if (simpleParameterDefinition != null)
            {
                name = simpleParameterDefinition.Name;
            }
        }

        /// <summary>
        /// Gets the name of the group to which this parameter belongs.
        /// </summary>
        [JsonIgnore]
        public override string GroupName => Constants.Names.DefaultGroupName;

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        [JsonIgnore]
        public override string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        [JsonIgnore]
        public override Enums.ParameterType ParameterType => Enums.ParameterType.Undefined;

        /// <summary>
        /// Gets or sets the unique identifier for the parameter.
        /// </summary>
        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Determines whether the specified value is a valid integer parameter value.
        /// </summary>
        public override bool IsValid(object? value)
        {
            return base.IsValid(value);
        }
    }
}