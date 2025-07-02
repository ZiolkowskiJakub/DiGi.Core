﻿using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryConvert(this object @object, out object result, Type type)
        {
            result = default;

            if (type == typeof(object))
            {
                result = @object;
                return true;
            }

            Type type_Object = @object?.GetType();
            if (type_Object == type || type == null)
            {
                result = @object;
                return true;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp == null)
            {
                type_Temp = type;
            }

            if (type_Temp == typeof(string))
            {
                if (@object != null)
                {
                    if (@object is ISerializableObject)
                    {
                        result = ((ISerializableObject)@object).ToJsonObject()?.ToString();
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

                if (@object is string)
                {
                    bool @bool;
                    if (bool.TryParse((string)@object, out @bool))
                    {
                        result = @bool;
                        return true;
                    }

                    string @string = ((string)@object).Trim().ToUpper();
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

                if (@object is string)
                {
                    double @double;
                    if (TryParseDouble((string)@object, out @double))
                    {
                        result = @double;
                        return true;
                    }
                }
                else if (IsNumeric(@object) && !(@object is Type))
                {
                    result = System.Convert.ToDouble(@object);
                    return true;
                }
                else if (@object is bool)
                {
                    double @double = 0;
                    if ((bool)@object)
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

                if (@object is string)
                {
                    double @double;
                    if (TryParseDouble((string)@object, out @double))
                    {
                        result = System.Convert.ToSingle(@double);
                        return true;
                    }
                }
                else if (IsNumeric(@object) && !(@object is Type))
                {
                    result = System.Convert.ToSingle(@object);
                    return true;
                }
                else if (@object is bool)
                {
                    float @float = 0;
                    if ((bool)@object)
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

                if (@object is string)
                {
                    int @int;
                    if (int.TryParse((string)@object, out @int))
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

                if (@object is string)
                {
                    uint @uint;
                    if (uint.TryParse((string)@object, out @uint))
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
                else if (@object is Classes.Color)
                {
                    result = ((Classes.Color)@object).Value;
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

                if (@object is string)
                {
                    short @short;
                    if (short.TryParse((string)@object, out @short))
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

                if (@object is string)
                {
                    ushort @ushort;
                    if (ushort.TryParse((string)@object, out @ushort))
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

                if (@object is string)
                {
                    if (byte.TryParse((string)@object, out byte @byte))
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

                if (@object is string)
                {
                    long @long;
                    if (long.TryParse((string)@object, out @long))
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

                if (@object is string)
                {
                    if (ulong.TryParse((string)@object, out ulong @ulong))
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

                if (@object is string)
                {
                    if (Guid.TryParse((string)@object, out Guid guid))
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

                if (@object is string)
                {
                    DateTime dateTime;
                    if (DateTime.TryParse((string)@object, out dateTime))
                    {
                        result = dateTime;
                        return true;
                    }
                }
                else if (IsNumeric(@object))
                {
                    result = @object is double ? DateTime.FromOADate((double)@object) : new DateTime(System.Convert.ToInt64(@object));
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

                if (@object is string)
                {
                    string @string = (string)@object;
                    if (@string.StartsWith("##"))
                    {
                        result = Convert.ToDrawing(@string);
                        if (!result.Equals(System.Drawing.Color.Empty))
                        {
                            return true;
                        }
                    }

                    int @int;
                    if (int.TryParse(@string, out @int))
                    {
                        result = Convert.ToDrawing(@int);
                        return true;
                    }

                    uint @uint;
                    if (uint.TryParse(@string, out @uint))
                    {
                        result = Convert.ToDrawing(@uint);
                        return true;
                    }

                    result = Convert.ToDrawing(@string);
                    if (!result.Equals(System.Drawing.Color.Empty))
                        return true;

                }
                else if (@object is Classes.Color)
                {
                    result = (System.Drawing.Color)((Classes.Color)@object);
                    return true;
                }
                else if (@object is int)
                {
                    result = Convert.ToDrawing((int)@object);
                    return true;
                }
                else if (@object is uint)
                {
                    result = Convert.ToDrawing((uint)@object);
                    return true;
                }
            }
            else if (typeof(ISerializableObject).IsAssignableFrom(type_Temp))
            {
                if (@object is string)
                {
                    List<ISerializableObject> serializableObjects = Convert.ToDiGi<ISerializableObject>((string)@object);
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
                        if (int.TryParse((string)@object, out int int_color))
                        {
                            result = new Classes.Color(Convert.ToDrawing(int_color));
                            return true;
                        }
                        else
                        {
                            string value = (string)@object;
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
                    result = new Classes.Color((System.Drawing.Color)@object);
                    return true;
                }
            }
            else if (typeof(JsonObject).IsAssignableFrom(type_Temp))
            {
                if (@object is string)
                {
                    result = JsonNode.Parse((string)@object);
                    return true;
                }
            }
            else if (result is Enum)
            {
                if (@object == null)
                    return false;

                if (@object is string)
                {
                    string @string = (string)@object;

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

                    int @int;
                    if (int.TryParse(@string, out @int))
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
                if(array != null && array.Length != 0)
                {
                    if (@object is string)
                    {
                        string @string = ((string)@object).Replace(" ", string.Empty).ToUpper();
                        if (string.IsNullOrEmpty(@string))
                        {
                            return false;
                        }

                        foreach (Enum @enum in array)
                        {
                            string name = nameof(@enum).ToUpper();
                            if (@string.Equals(name))
                            {
                                result = @enum;
                                return true;
                            }

                            string description = Description(@enum)?.Replace(" ", string.Empty)?.ToUpper();
                            if (@string.Equals(description))
                            {
                                result = @enum;
                                return true;
                            }
                        }
                    }

                    if (IsNumeric(@object))
                    {
                        if(TryConvert(@object, out int index) && System.Enum.IsDefined(type_Temp, index))
                        {
                            foreach(Enum @enum in array)
                            {
                                if((int)(object)@enum == index)
                                {
                                    result = @enum;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            result = default;
            return false;
        }

        public static bool TryConvert<T>(this object @object, out T result)
        {
            result = default;

            object result_Object;
            if (!TryConvert(@object, out result_Object, typeof(T)))
                return false;

            result = (T)result_Object;
            return true;
        }

        public static bool TryConvert(this object @object, out object result, DataType dataType)
        {
            result = null;
            if(dataType == Enums.DataType.Undefined)
            { 
                return false;
            }

            return TryConvert(@object, out result, Type(dataType));
        }
    }

}
