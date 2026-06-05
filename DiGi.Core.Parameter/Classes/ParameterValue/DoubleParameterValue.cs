using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a double-precision floating-point value for a parameter.
    /// </summary>
    public class DoubleParameterValue : ParameterValue
    {
        [JsonInclude, JsonPropertyName("Min")]
        private readonly double min = double.NaN;

        [JsonInclude, JsonPropertyName("Max")]
        private readonly double max = double.NaN;

        /// <summary>
        /// Gets the type of the parameter, which is Integer.
        /// </summary>
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Double;

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class.
        /// </summary>
        public DoubleParameterValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with specified nullability.
        /// </summary>
        /// <param name="nullable">A value indicating whether the parameter is nullable.</param>
        public DoubleParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with a specified range.
        /// </summary>
        /// <param name="min">The minimum value for the parameter.</param>
        /// <param name="max">The maximum value for the parameter.</param>
        public DoubleParameterValue(double min, double max)
            : base()
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with specified nullability and range.
        /// </summary>
        /// <param name="nullable">A value indicating whether the parameter is nullable.</param>
        /// <param name="min">The minimum value for the parameter.</param>
        /// <param name="max">The maximum value for the parameter.</param>
        public DoubleParameterValue(bool nullable, double min, double max)
            : base(nullable)
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with a minimum value.
        /// </summary>
        /// <param name="min">The minimum value for the parameter.</param>
        public DoubleParameterValue(double min)
            : base()
        {
            this.min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the value from.</param>
        public DoubleParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class by copying an existing value.
        /// </summary>
        /// <param name="doubleParameterValue">The existing value to copy from.</param>
        public DoubleParameterValue(DoubleParameterValue? doubleParameterValue)
            : base(doubleParameterValue)
        {
            if (doubleParameterValue != null)
            {
                min = doubleParameterValue.min;
                max = doubleParameterValue.max;
            }
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
            if (value is not double)
            {
                return false;
            }

            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            double @double = (double)value;

            if (!double.IsNaN(min) && @double < min)
            {
                return false;
            }

            if (!double.IsNaN(max) && @double > max)
            {
                return false;
            }

            return result;
        }

        /// <summary>
        /// Creates a shallow copy of the current integer parameter value.
        /// </summary>
        /// <returns>A shallow copy of the current integer parameter value.</returns>
        public override ISerializableObject? Clone()
        {
            return new DoubleParameterValue(this);
        }
    }
}