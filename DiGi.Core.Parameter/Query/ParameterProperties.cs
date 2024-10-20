using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static ParameterProperties ParameterProperties(Enum @enum)
        {
            return Core.Query.CustomAttribute<ParameterProperties>(@enum);
        }

        public static ParameterProperties ParameterProperties(Type type, string text)
        {
            return Core.Query.CustomAttribute<ParameterProperties>(type, text);
        }
    }
}