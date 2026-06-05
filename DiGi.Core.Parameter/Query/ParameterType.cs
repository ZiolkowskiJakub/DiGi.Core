using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the parameter type for the specified type and identifier.
        /// </summary>
        /// <param name="type">The type to evaluate.</param>
        /// <param name="text">The identifier text.</param>
        /// <returns>The corresponding <see cref="Enums.ParameterType"/>.</returns>
        public static Enums.ParameterType ParameterType(Type? type, string? text)
        {
            ParameterValue? parameterValue = Core.Query.CustomAttribute<ParameterValue>(type, text);
            if (parameterValue == null)
            {
                return Enums.ParameterType.Undefined;
            }

            return parameterValue.ParameterType;
        }

        /// <summary>
        /// Gets the parameter type for the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value.</param>
        /// <returns>The corresponding <see cref="Enums.ParameterType"/>.</returns>
        public static Enums.ParameterType ParameterType(Enum? @enum)
        {
            ParameterValue? parameterValue = Core.Query.CustomAttribute<ParameterValue>(@enum);
            if (parameterValue == null)
            {
                return Enums.ParameterType.Undefined;
            }

            return parameterValue.ParameterType;
        }
    }
}