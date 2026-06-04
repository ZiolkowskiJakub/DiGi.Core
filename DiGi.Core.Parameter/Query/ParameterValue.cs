using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the parameter value associated with the specified enumeration.
        /// </summary>
        public static TParameterValue? ParameterValue<TParameterValue>(Enum? @enum) where TParameterValue : ParameterValue
        {
            return Core.Query.CustomAttribute<TParameterValue>(@enum);
        }
    }
}