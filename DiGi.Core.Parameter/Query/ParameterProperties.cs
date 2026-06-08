using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the properties associated with the specified enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to retrieve properties for.</param>
        /// <returns>The <see cref="DiGi.Core.Parameter.Classes.ParameterProperties"/> associated with the specified enumeration, or <c>null</c> if not found.</returns>
        public static ParameterProperties? ParameterProperties(Enum? @enum)
        {
            return Core.Query.CustomAttribute<ParameterProperties>(@enum);
        }

        /// <summary>
        /// Retrieves the properties associated with the specified type and identifier.
        /// </summary>
        /// <param name="type">The type to retrieve properties for.</param>
        /// <param name="text">The identifier text used to look up the properties.</param>
        /// <returns>The <see cref="DiGi.Core.Parameter.Classes.ParameterProperties"/> associated with the specified type and text, or <c>null</c> if not found.</returns>
        public static ParameterProperties? ParameterProperties(Type? type, string? text)
        {
            return Core.Query.CustomAttribute<ParameterProperties>(type, text);
        }
    }
}