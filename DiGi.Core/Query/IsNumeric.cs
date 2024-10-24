using System;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool IsNumeric(this object @object)
        {
            return IsNumeric(@object, out bool isInteger);
        }


        public static bool IsNumeric(this object @object, out bool isInteger)
        {
            isInteger = false;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return IsNumeric((Type)@object, out isInteger);
            }

            return IsNumeric(@object.GetType(), out isInteger);
        }

        public static bool IsNumeric(this Type type)
        {
            return IsNumeric(type, out bool isInteger);
        }

        public static bool IsNumeric(this Type type, out bool isInteger)
        {
            isInteger = false;
            switch (System.Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    {
                        isInteger = true;
                        return true;
                    }

                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    {
                        return true;
                    }

                case TypeCode.Object:
                    if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        return IsNumeric(Nullable.GetUnderlyingType(type));
                    }
                    return false;

                default:
                    return false;
            }
        }


    }

}
