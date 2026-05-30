using DiGi.Core.Parameter.Enums;
using System.Text.Json.Nodes;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>Represents the abstract base class for complex parameter definitions.</summary>
    public abstract class ComplexParameterDefinition : ParameterDefinition
    {
        /// <summary>Creates a new instance of the ComplexParameterDefinition class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object containing the complex parameter definition data.</param>
        public ComplexParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a new instance of the ComplexParameterDefinition class by copying another ComplexParameterDefinition.</summary>
        /// <param name="complexParameterDefinition">The ComplexParameterDefinition to copy.</param>
        public ComplexParameterDefinition(ComplexParameterDefinition? complexParameterDefinition)
            : base(complexParameterDefinition)
        {
        }

        /// <summary>Creates a new instance of the ComplexParameterDefinition class.</summary>
        public ComplexParameterDefinition()
            : base()
        {
        }

        /// <summary>Gets the description of the complex parameter definition.</summary>
        public abstract string? Description { get; }

        /// <summary>Gets the parameter value of the complex parameter definition.</summary>
        public abstract ParameterValue? ParameterValue { get; }

        /// <summary>Gets the associated types of the complex parameter definition.</summary>
        public abstract AssociatedTypes? AssociatedTypes { get; }

        /// <summary>Gets the access type of the complex parameter definition.</summary>
        public abstract AccessType AccessType { get; }

        /// <summary>Gets the type of the parameter.</summary>
        public override ParameterType ParameterType
        {
            get
            {
                ParameterValue? parameterValue = ParameterValue;
                if (parameterValue == null)
                {
                    return ParameterType.Undefined;
                }

                return parameterValue.ParameterType;
            }
        }

        /// <summary>Determines whether the specified value is valid for this complex parameter definition.</summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is valid, false otherwise.</returns>
        public override bool IsValid(object? value)
        {
            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            ParameterValue? parameterValue = ParameterValue;
            if (parameterValue != null)
            {
                result = parameterValue.IsValid(value);
            }

            return result;
        }
    }
}