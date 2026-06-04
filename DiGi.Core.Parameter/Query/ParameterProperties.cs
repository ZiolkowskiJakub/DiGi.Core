using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the properties associated with the specified enumeration value.
        /// </summary>
        public static ParameterProperties? ParameterProperties(Enum? @enum)
        {
            return Core.Query.CustomAttribute<ParameterProperties>(@enum);
        }

        /// <summary>
        /// Retrieves the properties associated with the specified type and identifier.
        /// </summary>
        public static ParameterProperties? ParameterProperties(Type? type, string? text)
        {
            return Core.Query.CustomAttribute<ParameterProperties>(type, text);
        }
    }
}