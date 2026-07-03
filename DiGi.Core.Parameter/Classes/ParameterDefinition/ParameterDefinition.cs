using DiGi.Core.Classes;
using DiGi.Core.Parameter.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Provides a base class for defining parameters.
    /// </summary>
    public abstract class ParameterDefinition : SerializableObject, IParameterDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
        /// </summary>
        public ParameterDefinition()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class by copying an existing definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to copy from.</param>
        public ParameterDefinition(ParameterDefinition? parameterDefinition)
            : base(parameterDefinition)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the definition from.</param>
        public ParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the name of the parameter.
        /// </summary>
        [JsonIgnore]
        public abstract string? Name { get; }

        /// <summary>
        /// Gets the type of the parameter.
        /// </summary>
        [JsonIgnore]
        public abstract Enums.ParameterType ParameterType { get; }

        /// <summary>
        /// Gets or sets the unique identifier for the parameter.
        /// </summary>
        [JsonIgnore]
        public abstract string? UniqueId { get; }

        /// <summary>
        /// Gets the group name to which the parameter belongs.
        /// </summary>
        [JsonIgnore]
        public abstract string? GroupName { get; }

        /// <summary>
        /// Determines whether the specified parameter definition is equal to the current instance.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to compare with the current instance.</param>
        /// <returns>True if the specified parameter definition is equal to the current instance; otherwise, false.</returns>
        public bool Equals(IParameterDefinition? parameterDefinition)
        {
            return parameterDefinition?.UniqueId == UniqueId;
        }

        /// <summary>
        /// Validates whether the provided value is valid for this parameter definition.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is valid; otherwise, false.</returns>
        public virtual bool IsValid(object? value)
        {
            return Query.IsValid(ParameterType, value);
        }
    }
}