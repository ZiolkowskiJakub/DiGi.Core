using DiGi.Core.Interfaces;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a normalization factor as a value between 0 and 1.
    /// </summary>
    public readonly struct Factor : IObject, ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Value"), Description("Value [0-1]")]
        private readonly double value = double.NaN;

        /// <summary>
        /// Initializes a new instance of the Factor struct with default values.
        /// </summary>
        public Factor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Factor struct with a specified value clamped between 0 and 1.
        /// </summary>
        /// <param name="value">The factor value.</param>
        public Factor(double value)
        {
            this.value = double.IsNaN(value) ? double.NaN : Query.Clamp(value, 0, 1);
        }

        /// <summary>
        /// Initializes a new instance of the Factor struct by copying another Factor.
        /// </summary>
        /// <param name="factor">The source factor.</param>
        public Factor(Factor factor)
        {
            value = factor.value;
        }

        /// <summary>
        /// Initializes a new instance of the Factor struct from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the factor value.</param>
        public Factor(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Implicitly converts a Factor to its double value.
        /// </summary>
        public static implicit operator double(Factor factor)
        {
            return factor.value;
        }

        /// <summary>
        /// Implicitly converts a double to a Factor.
        /// </summary>
        public static implicit operator Factor(double value)
        {
            return new Factor(value);
        }

        /// <summary>
        /// Implicitly converts a float to a Factor.
        /// </summary>
        public static implicit operator Factor(float value)
        {
            return new Factor(System.Convert.ToDouble(value));
        }

        /// <summary>
        /// Implicitly converts a Factor to its float value.
        /// </summary>
        public static implicit operator float(Factor factor)
        {
            return System.Convert.ToSingle(factor.value);
        }

        /// <summary>
        /// Creates a deep copy of the factor.
        /// </summary>
        /// <returns>A new Factor instance with the same value.</returns>
        public ISerializableObject? Clone()
        {
            return new Factor(value);
        }

        /// <summary>
        /// Populates the factor's value from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data.</param>
        /// <returns>True if successful; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the factor to a JsonObject for serialization.
        /// </summary>
        /// <returns>A JsonObject representation of the factor.</returns>
        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }

        /// <summary>
        /// Returns a string representation of the factor's value.
        /// </summary>
        /// <returns>The numeric value as a string.</returns>
        public override string ToString()
        {
            return value.ToString();
        }
    }
}