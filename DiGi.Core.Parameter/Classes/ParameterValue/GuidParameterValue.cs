using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a GUID value for a parameter.
    /// </summary>
    public class GuidParameterValue : ParameterValue
    {
        /// <summary>
        /// Gets the type of the parameter, which is Integer.
        /// </summary>
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Guid;

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidParameterValue"/> class.
        /// </summary>
        public GuidParameterValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidParameterValue"/> class with specified nullability.
        /// </summary>
        /// <param name="nullable">A value indicating whether the parameter is nullable.</param>
        public GuidParameterValue(bool nullable)
            : base(nullable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidParameterValue"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public GuidParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidParameterValue"/> class by copying an existing value.
        /// </summary>
        /// <param name="guidParameterValue">The existing value to copy.</param>
        public GuidParameterValue(GuidParameterValue? guidParameterValue)
            : base(guidParameterValue)
        {
        }

        /// <summary>
        /// Creates a shallow copy of the current integer parameter value.
        /// </summary>
        /// <returns>A shallow copy of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new GuidParameterValue(this);
        }
    }
}