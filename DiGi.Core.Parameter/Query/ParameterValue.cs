using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static T ParameterValue<T>(Enum @enum) where T : ParameterValue
        {
            return Core.Query.CustomAttribute<T>(@enum);
        }
    }
}