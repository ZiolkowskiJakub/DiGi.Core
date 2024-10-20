using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static Enums.ParameterType ParameterType(Type type, string text)
        {
            ParameterValue parameterValue = Core.Query.CustomAttribute<ParameterValue>(type, text);
            if (parameterValue == null)
            {
                return Enums.ParameterType.Undefined;
            }

            return parameterValue.ParameterType;
        }

        public static Enums.ParameterType ParameterType(Enum @enum)
        {
            ParameterValue parameterValue = Core.Query.CustomAttribute<ParameterValue>(@enum);
            if (parameterValue == null)
            {
                return Enums.ParameterType.Undefined;
            }

            return parameterValue.ParameterType;
        }
    }
}