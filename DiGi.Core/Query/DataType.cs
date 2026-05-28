using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    /// <summary>
    /// Provides utility methods for querying and determining data types of objects and types.
    /// </summary>
    public static partial class Query
    {
        /// <summary>Gets the DiGi.Core.Enums.DataType of the specified object.</summary>
        public static DataType DataType(this object? @object)
        {
            return DataType(@object, out _);
        }

        /// <summary>Gets the DiGi.Core.Enums.DataType of the specified object and determines if it is nullable.</summary>
        /// <param name="object">The object for which to get the data type.</param>
        /// <param name="nullable">When this method returns, contains a boolean value indicating whether the type is nullable.</param>
        public static DataType DataType(this object? @object, out bool nullable)
        {
            nullable = false;
            if (@object == null)
            {
                return Enums.DataType.Undefined;
            }

            if (@object is Type type)
            {
                return DataType(type, out nullable);
            }

            return DataType(@object.GetType(), out nullable);
        }

        /// <summary>Gets the DiGi.Core.Enums.DataType of the specified type.</summary>
        public static DataType DataType(this Type? type)
        {
            return DataType(type, out _);
        }

        /// <summary>Gets the DiGi.Core.Enums.DataType of the specified type and determines if it is nullable.</summary>
        /// <param name="type">The type for which to get the data type.</param>
        /// <param name="nullable">When this method returns, contains a boolean value indicating whether the type is nullable.</param>
        public static DataType DataType(this Type? type, out bool nullable)
        {
            nullable = false;
            if (type == null)
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

            TypeCode typeCode = System.Type.GetTypeCode(type_Temp);
            switch (typeCode)
            {
                case TypeCode.String:
                    nullable = true;
                    return Enums.DataType.String;

                case TypeCode.Boolean:
                    return Enums.DataType.Bool;

                case TypeCode.Double:
                    return Enums.DataType.Double;

                case TypeCode.Int32:
                    return Enums.DataType.Int;

                case TypeCode.Single:
                    return Enums.DataType.Float;

                case TypeCode.Decimal:
                    return Enums.DataType.Decimal;

                case TypeCode.SByte:
                    return Enums.DataType.SByte;

                case TypeCode.Byte:
                    return Enums.DataType.Byte;

                case TypeCode.Int16:
                    return Enums.DataType.Short;

                case TypeCode.UInt32:
                    return Enums.DataType.UInt;

                case TypeCode.UInt16:
                    return Enums.DataType.UShort;

                case TypeCode.UInt64:
                    return Enums.DataType.ULong;

                case TypeCode.Int64:
                    return Enums.DataType.Long;
            }

            if (type_Temp.IsEnum)
            {
                return Enums.DataType.Enum;
            }

            if (type_Temp.IsValueType)
            {
                return Enums.DataType.ValueType;
            }

            if (type_Temp == typeof(Guid))
            {
                return Enums.DataType.Guid;
            }

            if (type_Temp == typeof(DateTime))
            {
                return Enums.DataType.DateTime;
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

            if (typeof(JsonNode).IsAssignableFrom(type_Temp))
            {
                nullable = true;
                return Enums.DataType.JsonNode;
            }

            return Enums.DataType.Other;
        }
    }
}