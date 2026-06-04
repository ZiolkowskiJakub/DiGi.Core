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
        public BooleanParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanParameterValue"/> class from a JSON object.
        /// </summary>
        public BooleanParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanParameterValue"/> class by copying an existing value.
        /// </summary>
        public BooleanParameterValue(BooleanParameterValue? booleanParameterValue)
            : base(booleanParameterValue)
        {
        }

        /// <summary>
        /// Attempts to convert the specified input value to an integer parameter value.
        /// </summary>
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
        public override ISerializableObject? Clone()
        {
            return new BooleanParameterValue(this);
        }
    }
}