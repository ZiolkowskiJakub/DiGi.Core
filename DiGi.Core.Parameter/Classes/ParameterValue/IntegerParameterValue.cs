using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents an integer value for a parameter.
    /// </summary>
    public class IntegerParameterValue : ParameterValue
    {
        [JsonInclude, JsonPropertyName("Max")]
        private readonly int max = int.MaxValue;

        [JsonInclude, JsonPropertyName("Min")]
        private readonly int min = int.MinValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class.
        /// </summary>
        public IntegerParameterValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class with specified nullability.
        /// </summary>
        public IntegerParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class with a specified range.
        /// </summary>
        public IntegerParameterValue(int min, int max)
            : base()
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class with specified nullability and range.
        /// </summary>
        public IntegerParameterValue(bool nullable, int min, int max)
            : base(nullable)
        {
            this.min = min;
            this.max = max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class with a minimum value.
        /// </summary>
        public IntegerParameterValue(int min)
            : base()
        {
            this.min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class from a JSON object.
        /// </summary>
        public IntegerParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerParameterValue"/> class by copying an existing value.
        /// </summary>
        public IntegerParameterValue(IntegerParameterValue? integerParameterValue)
            : base(integerParameterValue)
        {
            if (integerParameterValue != null)
            {
                min = integerParameterValue.min;
                max = integerParameterValue.max;
            }
        }

        /// <summary>
        /// Gets the type of the parameter, which is Integer.
        /// </summary>
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Integer;

        /// <summary>
        /// Creates a shallow copy of the current integer parameter value.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new IntegerParameterValue(this);
        }

        /// <summary>
        /// Determines whether the specified value is a valid integer parameter value.
        /// </summary>
        public override bool IsValid(object? value)
        {
            if (value is not int)
            {
                return false;
            }

            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            int @int = (int)value;

            if (@int < min)
            {
                return false;
            }

            if (@int > max)
            {
                return false;
            }

            return result;
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
    }
}