using DiGi.Core.Interfaces;
using DiGi.Core.Parameters.Enums;
using System;

namespace DiGi.Core.Parameters
{
    public static partial class Query
    {
        public static bool IsValid(this ParameterType parameterType, object value)
        {
            if(parameterType == Enums.ParameterType.Undefined)
            {
                return true;
            }

            switch(parameterType)
            {
                case Enums.ParameterType.Boolean:
                    return value is bool;

                case Enums.ParameterType.Integer:
                    return value is int;

                case Enums.ParameterType.DateTime:
                    return value is DateTime;

                case Enums.ParameterType.Object:
                    return value is ISerializableObject || value is null;

                case Enums.ParameterType.Double:
                    return value is double;

                case Enums.ParameterType.Color:
                    return value is System.Drawing.Color;

                case Enums.ParameterType.String:
                    return value is string || value is null;
            }

            return false;
        }
    }

}
