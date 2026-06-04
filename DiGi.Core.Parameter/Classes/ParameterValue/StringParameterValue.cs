using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a parameter value that holds a string.
    /// </summary>
    public class StringParameterValue : ParameterValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterValue"/> class.
        /// </summary>
        public StringParameterValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterValue"/> class with specified nullability.
        /// </summary>
        public StringParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterValue"/> class from a JSON object.
        /// </summary>
        public StringParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterValue"/> class by copying an existing instance.
        /// </summary>
        public StringParameterValue(StringParameterValue? stringParameterValue)
            : base(stringParameterValue)
        {
        }

        /// <summary>
        /// Gets the parameter type associated with this string parameter value.
        /// </summary>
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.String;

        /// <summary>
        /// Creates a clone of the current string parameter value.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new StringParameterValue(this);
        }
    }
}