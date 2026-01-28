using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryConvert(this object? @object, out object? result, Type? type)
        {
            result = default;

            if (type == typeof(object))
            {
                result = @object;
                return true;
            }

            Type? type_Object = @object?.GetType();
            if (type_Object == type || type == null)
            {
                result = @object;
                return true;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type) ?? type;
            if (type_Temp == typeof(string))
            {
                if (@object != null)
                {
                    if (@object is ISerializableObject serializableObject)
                    {
                        result = serializableObject.ToJsonObject()?.ToString();
                    }

                    if (result == default)
                    {
                        result = @object.ToString();
                    }
                }

                return true;
            }
            else if (type_Temp == typeof(bool))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string string_Temp)
                {
                    if (bool.TryParse(string_Temp, out bool @bool))
                    {
                        result = @bool;
                        return true;
                    }

                    string @string = string_Temp.Trim().ToUpper();
                    result = (@string.Equals("1") || @string.Equals("YES") || @string.Equals("TRUE"));
                    return true;
                }
                else if (IsNumeric(@object))
                {
                    result = (System.Convert.ToInt64(@object) == 1);
                    return true;
                }
            }
            else if (type_Temp == typeof(double))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (TryParseDouble(@string, out double @double))
                    {
                        result = @double;
                        return true;
                    }
                }
                else if (IsNumeric(@object) && @object is not System.Type)
                {
                    result = System.Convert.ToDouble(@object);
                    return true;
                }
                else if (@object is bool @bool)
                {
                    double @double = 0;
                    if (@bool)
                        @double = 1;

                    result = @double;
                    return true;
                }
                else if (@object is int)
                {
                    int @int = 0;
                    if ((bool)@object)
                        @int = 1;

                    result = System.Convert.ToDouble(@int);
                    return true;
                }
            }
            else if (type_Temp == typeof(decimal))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (TryParseDouble(@string, out double @double))
                    {
                        result = System.Convert.ToDecimal(@double);
                        return true;
                    }
                }
                else if (IsNumeric(@object) && @object is not System.Type)
                {
                    result = System.Convert.ToDecimal(@object);
                    return true;
                }
                else if (@object is bool @bool)
                {
                    decimal @decimal = 0;
                    if (@bool)
                        @decimal = 1;

                    result = @decimal;
                    return true;
                }
                else if (@object is int)
                {
                    int @int = 0;
                    if ((bool)@object)
                        @int = 1;

                    result = System.Convert.ToDecimal(@int);
                    return true;
                }
            }
            else if (type_Temp == typeof(float))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (TryParseDouble(@string, out double @double))
                    {
                        result = System.Convert.ToSingle(@double);
                        return true;
                    }
                }
                else if (IsNumeric(@object) && @object is not System.Type)
                {
                    result = System.Convert.ToSingle(@object);
                    return true;
                }
                else if (@object is bool @bool)
                {
                    float @float = 0;
                    if (@bool)
                        @float = 1;

                    result = @float;
                    return true;
                }
                else if (@object is int)
                {
                    int @int = 0;
                    if ((bool)@object)
                        @int = 1;

                    result = System.Convert.ToSingle(@int);
                    return true;
                }
            }
            else if (type_Temp == typeof(int))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (int.TryParse(@string, out int @int))
                    {
                        result = @int;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToInt32(@object);
                    return true;
                }
                else if (@object is Enum)
                {
                    result = (int)@object;
                    return true;
                }
            }
            else if (type_Temp == typeof(uint))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (uint.TryParse(@string, out uint @uint))
                    {
                        result = @uint;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToUInt32(@object);
                    return true;
                }
                else if (@object is Classes.Color color)
                {
                    result = color.Value;
                    return true;
                }
            }
            else if (type_Temp == typeof(short))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (short.TryParse(@string, out short @short))
                    {
                        result = @short;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToInt16(@object);
                    return true;
                }
            }
            else if (type_Temp == typeof(ushort))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (ushort.TryParse(@string, out ushort @ushort))
                    {
                        result = @ushort;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToUInt16(@object);
                    return true;
                }
            }
            else if (type_Temp == typeof(byte))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (byte.TryParse(@string, out byte @byte))
                    {
                        result = @byte;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToByte(@object);
                    return true;
                }
            }
            else if (type_Temp == typeof(long))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (long.TryParse(@string, out long @long))
                    {
                        result = @long;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToInt32(@object);
                    return true;
                }
            }
            else if (type_Temp == typeof(ulong))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (ulong.TryParse(@string, out ulong @ulong))
                    {
                        result = @ulong;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = System.Convert.ToInt32(@object);
                    return true;
                }
                else if (@object is Enum)
                {
                    result = (int)@object;
                    return true;
                }
            }
            else if (type_Temp == typeof(Guid))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (Guid.TryParse(@string, out Guid guid))
                    {
                        result = guid;
                        return true;
                    }
                }
            }
            else if (type_Temp == typeof(DateTime))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (DateTime.TryParse(@string, out DateTime dateTime))
                    {
                        result = dateTime;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = @object is double @double ? DateTime.FromOADate(@double) : new DateTime(System.Convert.ToInt64(@object));
                    return true;
                }
            }
            else if (type_Temp == typeof(System.Drawing.Color))
            {
                if (@object == null)
                {
                    return false;
                }

                if (@object is Type)
                {
                    return false;
                }

                if (@object is string @string)
                {
                    if (@string.StartsWith("##"))
                    {
                        result = Convert.ToDrawing(@string);
                        if (!result.Equals(System.Drawing.Color.Empty))
                        {
                            return true;
                        }
                    }

                    if (int.TryParse(@string, out int @int))
                    {
                        result = Convert.ToDrawing(@int);
                        return true;
                    }

                    if (uint.TryParse(@string, out uint @uint))
                    {
                        result = Convert.ToDrawing(@uint);
                        return true;
                    }

                    result = Convert.ToDrawing(@string);
                    if (!result.Equals(System.Drawing.Color.Empty))
                        return true;
                }
                else if (@object is Classes.Color color)
                {
                    result = (System.Drawing.Color)color;
                    return true;
                }
                else if (@object is int @int)
                {
                    result = Convert.ToDrawing(@int);
                    return true;
                }
                else if (@object is uint unit)
                {
                    result = Convert.ToDrawing(unit);
                    return true;
                }
            }
            else if (type_Temp == typeof(Enum))
            {
                if (@object != null && @object is Enum)
                {
                    result = @object;
                    return true;
                }
            }
            else if (type_Temp.IsSubclassOf(typeof(Type)) || type_Temp == typeof(Type))
            {
                if (@object is string @string && !string.IsNullOrWhiteSpace(@string))
                {
                    result = Type(@string);
                    return true;
                }
            }
            else if (typeof(ISerializableObject).IsAssignableFrom(type_Temp))
            {
                if (@object is string @string)
                {
                    List<ISerializableObject>? serializableObjects = Convert.ToDiGi<ISerializableObject>(@string);
                    if (serializableObjects != null && serializableObjects.Count != 0)
                    {
                        ISerializableObject serializableObject = serializableObjects.Find(x => x != null && type_Temp.IsAssignableFrom(x.GetType()));
                        if (serializableObject != null)
                        {
                            result = serializableObject;
                            return true;
                        }
                    }
                    else if (typeof(Classes.Color).IsAssignableFrom(type_Temp))
                    {
                        if (int.TryParse(@string, out int int_color))
                        {
                            result = new Classes.Color(Convert.ToDrawing(int_color));
                            return true;
                        }
                        else
                        {
                            string value = @string;
                            if (!string.IsNullOrWhiteSpace(value) && value.Contains(","))
                            {
                                string[] values = value.Split(',');
                                if (values.Length == 3)
                                {
                                    if (int.TryParse(values[0], out int r) && int.TryParse(values[1], out int g) && int.TryParse(values[2], out int b))
                                    {
                                        result = new Classes.Color(System.Drawing.Color.FromArgb(r, g, b));
                                        return true;
                                    }
                                }
                                else if (values.Length == 4)
                                {
                                    if (int.TryParse(values[0], out int a) && int.TryParse(values[1], out int r) && int.TryParse(values[2], out int g) && int.TryParse(values[3], out int b))
                                    {
                                        result = new Classes.Color(System.Drawing.Color.FromArgb(a, r, g, b));
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                }

                if (type_Object == typeof(Classes.Color))
                {
                    System.Drawing.Color color = System.Drawing.Color.Empty;
                    if (TryConvert(@object, out color))
                    {
                        if (color == System.Drawing.Color.Empty)
                        {
                            result = default;
                            return true;
                        }

                        result = new Classes.Color(color);
                        return true;
                    }
                }

                if (type_Object == typeof(System.Drawing.Color))
                {
                    result = new Classes.Color((System.Drawing.Color)@object!);
                    return true;
                }
            }
            else if (typeof(JsonObject).IsAssignableFrom(type_Temp))
            {
                if (@object is string @string)
                {
                    result = JsonNode.Parse(@string);
                    return true;
                }
            }
            else if (result is Enum)
            {
                if (@object == null)
                    return false;

                if (@object is string @string)
                {
                    Type type_Result = result.GetType();

                    Array array = System.Enum.GetValues(type_Result);
                    if (array != null)
                    {
                        foreach (Enum @enum in array)
                        {
                            if (nameof(@enum).Equals(@string))
                            {
                                result = @enum;
                                return true;
                            }
                        }
                    }

                    if (int.TryParse(@string, out int @int))
                    {
                        if (System.Enum.IsDefined(type_Temp, @int))
                        {
                            result = @int;
                            return true;
                        }
                    }
                }
                else if (@object is int)
                {
                    int @int = default;
                    if (System.Enum.IsDefined(result.GetType(), @int))
                    {
                        result = @int;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    int @int = System.Convert.ToInt32(@object);
                    if (System.Enum.IsDefined(result.GetType(), @int))
                    {
                        result = @int;
                        return true;
                    }
                }
            }
            else if (type_Temp.IsEnum)
            {
                if (@object == null)
                {
                    return false;
                }

                Array array = System.Enum.GetValues(type_Temp);
                if (array != null && array.Length != 0)
                {
                    if (@object is string @string_Temp)
                    {
                        string @string = @string_Temp.Replace(" ", string.Empty).ToUpper();
                        if (string.IsNullOrEmpty(@string))
                        {
                            return false;
                        }

                        foreach (Enum @enum in array)
                        {
                            string name = @enum.ToString().ToUpper();
                            if (@string.Equals(name))
                            {
                                result = @enum;
                                return true;
                            }

                            string? description = Description(@enum)?.Replace(" ", string.Empty)?.ToUpper();
                            if (@string.Equals(description))
                            {
                                result = @enum;
                                return true;
                            }
                        }

                        if (int.TryParse(@string, out int index) && System.Enum.IsDefined(type_Temp, index))
                        {
                            result = array.GetValue(@index);
                            return true;
                        }
                    }

                    if (IsNumeric(@object))
                    {
                        if (TryConvert(@object, out int index) && System.Enum.IsDefined(type_Temp, index))
                        {
                            foreach (Enum @enum in array)
                            {
                                if ((int)(object)@enum == index)
                                {
                                    result = @enum;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type_Temp))
            {
                if (type_Temp.IsArray)
                {
                    Type elementType = type_Temp.GetElementType();

                    if (@object is IEnumerable enumerable)
                    {
                        List<object?> objects = [];
                        foreach (object? object_Temp in enumerable)
                        {
                            if (TryConvert(object_Temp, out object? @object_Converted, elementType))
                            {
                                objects.Add(@object_Converted);
                            }
                        }

                        Array array = Array.CreateInstance(elementType, objects.Count);
                        for (int i = 0; i < objects.Count; i++)
                        {
                            array.SetValue(objects[i], i);
                        }

                        result = array;
                        return true;
                    }
                    else if (TryConvert(@object, out object? @object_Converted, elementType))
                    {
                        Array array = Array.CreateInstance(elementType, 1);
                        array.SetValue(object_Converted, 0);
                        result = array;
                        return true;
                    }
                }

                if (type_Temp.IsGenericType)
                {
                    MethodInfo? methodInfo = type_Temp.GetMethod("Add");
                    if (methodInfo is not null)
                    {
                        Type elementType = type_Temp.GetGenericArguments()[0];
                        object enumerable = Activator.CreateInstance(type_Temp);

                        if (@object is IEnumerable enumerable_Temp)
                        {
                            foreach (object? object_Temp in enumerable_Temp)
                            {
                                if (TryConvert(object_Temp, out object? @object_Converted, elementType))
                                {
                                    methodInfo.Invoke(enumerable, [@object_Converted]);
                                }
                            }
                            result = enumerable;
                            return true;
                        }
                        else
                        {
                            if (TryConvert(@object, out object? @object_Converted, elementType))
                            {
                                methodInfo.Invoke(enumerable, [@object_Converted]);
                                result = enumerable;
                                return true;
                            }
                        }
                    }
                }
            }

            result = default;
            return false;
        }

        public static bool TryConvert<T>(this object? @object, out T? result)
        {
            result = default;

            if (!TryConvert(@object, out object? result_Object, typeof(T)))
            {
                return false;
            }

            if (result_Object is null)
            {
                result = default;
            }
            else
            {
                result = (T)result_Object;
            }

            return true;
        }

        public static bool TryConvert(this object? @object, out object? result, DataType dataType)
        {
            result = null;
            if (dataType == Enums.DataType.Undefined)
            {
                return false;
            }

            return TryConvert(@object, out result, Type(dataType));
        }
    }
}