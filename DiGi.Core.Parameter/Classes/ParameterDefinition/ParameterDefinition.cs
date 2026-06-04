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
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class from a JSON object.
        /// </summary>
        public ParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class by copying an existing definition.
        /// </summary>
        public ParameterDefinition(ParameterDefinition? parameterDefinition)
            : base(parameterDefinition)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterDefinition"/> class.
        /// </summary>
        public ParameterDefinition()
            : base()
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
        public bool Equals(IParameterDefinition? parameterDefinition)
        {
            return parameterDefinition?.UniqueId == UniqueId;
        }

        /// <summary>
        /// Validates whether the provided value is valid for this parameter definition.
        /// </summary>
        public virtual bool IsValid(object? value)
        {
            return Query.IsValid(ParameterType, value);
        }
    }
}