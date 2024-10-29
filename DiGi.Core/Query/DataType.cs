using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static DataType DataType(this object @object)
        {
            return DataType(@object, out bool nullable);
        }

        public static DataType DataType(this object @object, out bool nullable)
        {
            nullable = false;
            if(@object == null)
            {
                return Enums.DataType.Undefined;
            }

            if(@object is System.Type)
            {
                return DataType((System.Type)@object, out nullable);
            }

            return DataType(@object.GetType(), out nullable);

        }

        public static DataType DataType(this Type type)
        {
            return DataType(type, out bool nullable);
        }

        public static DataType DataType(this Type type, out bool nullable)
        {
            nullable = false;
            if(type == null)
            {
                return Enums.DataType.Undefined;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp == null)
            {
                type_Temp = type;
            }
            else
            {
                nullable = true;
            }

            if (type_Temp == typeof(string))
            {
                nullable = true;
                return Enums.DataType.String;
            }

            if (type_Temp == typeof(double))
            {
                return Enums.DataType.Double;
            }

            if (type_Temp == typeof(int))
            {
                return Enums.DataType.Int;
            }

            if (type_Temp == typeof(bool))
            {
                return Enums.DataType.Bool;
            }

            if (type_Temp == typeof(Guid))
            {
                return Enums.DataType.Guid;
            }

            if (type_Temp == typeof(DateTime))
            {
                return Enums.DataType.DateTime;
            }

            if (type_Temp.IsEnum)
            {
                return Enums.DataType.Enum;
            }

            if (type_Temp.IsValueType)
            {
                return Enums.DataType.ValueType;
            }

            if (typeof(ISerializableObject).IsAssignableFrom(type_Temp))
            {
                nullable = true;
                return Enums.DataType.SerializableObject;
            }

            if (typeof(IObject).IsAssignableFrom(type_Temp))
            {
                nullable = true;
                return Enums.DataType.Object;
            }

            if (type_Temp == typeof(float))
            {
                return Enums.DataType.Float;
            }

            if (type_Temp == typeof(decimal))
            {
                return Enums.DataType.Decimal;
            }

            if (type_Temp == typeof(sbyte))
            {
                return Enums.DataType.SByte;
            }

            if (type_Temp == typeof(byte))
            {
                return Enums.DataType.Byte;
            }

            if (type_Temp == typeof(short))
            {
                return Enums.DataType.Short;
            }

            if (type_Temp == typeof(ushort))
            {
                return Enums.DataType.UShort;
            }

            if (type_Temp == typeof(uint))
            {
                return Enums.DataType.UInt;
            }

            if (type_Temp == typeof(long))
            {
                return Enums.DataType.ULong;
            }

            if (type_Temp == typeof(ulong))
            {
                return Enums.DataType.ULong;
            }

            if (typeof(JsonNode).IsAssignableFrom(type_Temp))
            {
                nullable = true;
                return Enums.DataType.JsonNode;
            }

            return Enums.DataType.Other;
        }
    }
}