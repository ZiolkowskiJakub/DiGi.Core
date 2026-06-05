using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a boolean value for a parameter.
    /// </summary>
    public class BooleanParameterValue : ParameterValue
    {
        /// <summary>
        /// Gets the type of the parameter, which is Integer.
        /// </summary>
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Boolean;

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanParameterValue"/> class.
        /// </summary>
        public BooleanParameterValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanParameterValue"/> class with specified nullability.
        /// </summary>
        /// <param name="nullable">A value indicating whether the parameter is nullable.</param>
        public BooleanParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanParameterValue"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the current instance from.</param>
        public BooleanParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanParameterValue"/> class by copying an existing value.
        /// </summary>
        /// <param name="booleanParameterValue">The BooleanParameterValue to copy.</param>
        public BooleanParameterValue(BooleanParameterValue? booleanParameterValue)
            : base(booleanParameterValue)
        {
        }

        /// <summary>
        /// Attempts to convert the specified input value to an integer parameter value.
        /// </summary>
        /// <param name="value_In">The input value to be converted.</param>
        /// <param name="value_Out">When this method returns, contains the converted value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public override bool TryConvert(object? value_In, out object? value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }

        /// <summary>
        /// Determines whether the specified value is a valid integer parameter value.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the specified value is a valid integer parameter value; otherwise, false.</returns>
        public override bool IsValid(object? value)
        {
            if (value is not bool)
            {
                return false;
            }

            return base.IsValid(value);
        }

        /// <summary>
        /// Creates a shallow copy of the current integer parameter value.
        /// </summary>
        /// <returns>A shallow copy of the current integer parameter value.</returns>
        public override ISerializableObject? Clone()
        {
            return new BooleanParameterValue(this);
        }
    }
}