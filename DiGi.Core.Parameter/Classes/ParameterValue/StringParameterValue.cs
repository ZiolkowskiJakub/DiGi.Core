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
        /// <param name="nullable">A value indicating whether the parameter is nullable.</param>
        public StringParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterValue"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public StringParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringParameterValue"/> class by copying an existing instance.
        /// </summary>
        /// <param name="stringParameterValue">The existing instance to copy.</param>
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
        /// <returns>A clone of the current string parameter value.</returns>
        public override ISerializableObject? Clone()
        {
            return new StringParameterValue(this);
        }
    }
}