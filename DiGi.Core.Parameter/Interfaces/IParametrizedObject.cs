using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Parameter.Interfaces
{
    /// <summary>Defines the contract for an object that can be parameterized.</summary>
    public interface IParametrizedObject : ISerializableObject
    {
        /// <summary>Gets a list of parameter definitions of the specified type.</summary>
        /// <typeparam name="TParameterDefinition">The type of the parameter definition.</typeparam>
        /// <returns>A list containing the matching parameter definitions, or null.</returns>
        List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition;
 
        /// <summary>Removes the specified parameter definition from the object.</summary>
        /// <param name="parameterDefinition">The parameter definition to remove.</param>
        /// <returns>True if the parameter was removed, false otherwise.</returns>
        bool Remove(IParameterDefinition? parameterDefinition);
 
        /// <summary>Sets the value of the specified parameter.</summary>
        /// <param name="parameterDefinition">The parameter definition to set.</param>
        /// <param name="value">The value to set.</param>
        /// <param name="setValueSettings">Optional settings for setting the value.</param>
        /// <returns>True if the value was successfully set, false otherwise.</returns>
        bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null);
 
        /// <summary>Tries to get the value of the specified parameter.</summary>
        /// <typeparam name="T">The expected type of the parameter value.</typeparam>
        /// <param name="parameterDefinition">The parameter definition to retrieve.</param>
        /// <param name="value">The retrieved value, or default if not found.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved, false otherwise.</returns>
        bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null);
    }
}