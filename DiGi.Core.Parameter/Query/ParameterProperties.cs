using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static ParameterProperties ParameterProperties(Enum @enum)
        {
            return CustomAttribute<ParameterProperties>(@enum);
        }

        public static ParameterProperties ParameterProperties(Type type, string text)
        {
            return CustomAttribute<ParameterProperties>(type, text);
        }
    }
}