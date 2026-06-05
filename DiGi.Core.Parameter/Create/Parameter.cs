using DiGi.Core.Parameter.Classes;
using DiGi.Core.Parameter.Interfaces;

namespace DiGi.Core.Parameter
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a parameter based on the provided definition and value.
        /// </summary>
        /// <param name="parameterDefinition">The definition of the parameter.</param>
        /// <param name="value">The value to assign to the parameter.</param>
        /// <param name="setValueSettings">Optional settings for setting the value.</param>
        /// <returns>A <see cref="Classes.Parameter"/> instance, or null.</returns>
        public static Classes.Parameter? Parameter(this IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            if (parameterDefinition == null)
            {
                return null;
            }

            Classes.Parameter? result = new(parameterDefinition);
            if (!result.SetValue(value, setValueSettings))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Creates a parameter using a specified name and value.
        /// </summary>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="value">The value to assign to the parameter.</param>
        /// <returns>A <see cref="Classes.Parameter"/> instance, or null.</returns>
        public static Classes.Parameter? Parameter(string? name, object? value)
        {
            if (name == null)
            {
                return null;
            }

            SimpleParameterDefinition simpleParameterDefinition = new(name);
            if (simpleParameterDefinition == null || !simpleParameterDefinition.IsValid(value))
            {
                return null;
            }

            return new Classes.Parameter(simpleParameterDefinition, value);
        }
    }
}