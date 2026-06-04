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
        public DoubleParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with a specified range.
        /// </summary>
        public DoubleParameterValue(double min, double max)
            : base()
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with specified nullability and range.
        /// </summary>
        public DoubleParameterValue(bool nullable, double min, double max)
            : base(nullable)
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class with a minimum value.
        /// </summary>
        public DoubleParameterValue(double min)
            : base()
        {
            this.min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class from a JSON object.
        /// </summary>
        public DoubleParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleParameterValue"/> class by copying an existing value.
        /// </summary>
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
        public override ISerializableObject? Clone()
        {
            return new DoubleParameterValue(this);
        }
    }
}