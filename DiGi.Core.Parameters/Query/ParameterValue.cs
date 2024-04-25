using System;

namespace DiGi.Core.Parameters
{
    public static partial class Query
    {
        public static T ParameterValue<T>(Enum @enum) where T : ParameterValue
        {
            return CustomAttribute<T>(@enum);
        }
    }
}