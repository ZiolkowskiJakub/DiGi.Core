using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the parameter value associated with the specified enumeration.
        /// </summary>
        /// <typeparam name="TParameterValue">The type of the parameter value.</typeparam>
        /// <param name="enum">The enumeration for which to retrieve the parameter value.</param>
        /// <returns>The parameter value associated with the specified enumeration, or null if not found.</returns>
        public static TParameterValue? ParameterValue<TParameterValue>(Enum? @enum) where TParameterValue : ParameterValue
        {
            return Core.Query.CustomAttribute<TParameterValue>(@enum);
        }
    }
}