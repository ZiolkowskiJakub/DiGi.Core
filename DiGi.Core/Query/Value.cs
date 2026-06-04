using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Extracts the value from a <see cref="JsonNode"/> cast to the specified type.
        /// </summary>
        public static object? Value(this JsonNode? jsonNode, Type? type)
        {
            if (jsonNode == null || type == null)
            {
                return null;
            }

            if (jsonNode.GetType() == type)
            {
                return jsonNode;
            }

            bool nullable = true;
            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp == null)
            {
                type_Temp = type;
                nullable = false;
            }

            if (nullable)
            {
                if (jsonNode.GetValueKind() != System.Text.Json.JsonValueKind.Object)
                {
                    object value_Temp = jsonNode.GetValue<object>();
                    if (value_Temp == null)
                    {
                        return null;
                    }
                }
            }

            if (type_Temp.IsEnum)
            {
                if (jsonNode is not JsonValue jsonValue)
                {
                    return null;
                }

                object? value_Temp = null;
                switch (jsonValue.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.String:
                        if (jsonValue.TryGetValue(out string? @string))
                        {
                            value_Temp = @string;
                        }
                        break;

                    case System.Text.Json.JsonValueKind.Number:
                        if (jsonValue.TryGetValue(out int @int))
                        {
                            value_Temp = @int;
                        }
                        break;
                }

                if (value_Temp == null)
                {
                    if (jsonValue.TryGetValue(out int @int))
                    {
                        value_Temp = @int;
                    }

                    if (value_Temp == null)
                    {
                        if (jsonValue.TryGetValue(out string? @string))
                        {
                            value_Temp = @string;
                        }
                    }

                    if (value_Temp == null)
                    {
                        if (!jsonValue.TryGetValue(out value_Temp))
                        {
                            value_Temp = null;
                        }
                    }
                }

                if (nullable && value_Temp == null)
                {
                    return null;
                }

                if (TryConvert(value_Temp, out value_Temp, type_Temp))
                {
                    return value_Temp;
                }

                if (nullable)
                {
                    return null;
                }

                Array array = System.Enum.GetValues(type_Temp);
                if (array != null && array.Length != 0)
                {
                    return array.GetValue(0);
                }

                return null;
            }

            TypeCode typeCode = System.Type.GetTypeCode(type_Temp);

            switch (typeCode)
            {
                case TypeCode.String:
                    if (TryConvert_String(jsonNode, out string? @string))
                    {
                        return @string;
                    }
                    return default(string);

                case TypeCode.Boolean:
                    if (TryConvert_Boolean(jsonNode, out bool? @bool) && @bool is not null)
                    {
                        return @bool.Value;
                    }
                    return default(bool);

                case TypeCode.DateTime:
                    if (TryConvert_DateTime(jsonNode, out DateTime? dateTime) && dateTime is not null)
                    {
                        return dateTime.Value;
                    }
                    return default(DateTime);

                case TypeCode.Int32:
                    if (TryConvert_Int(jsonNode, out int? @int) && @int is not null)
                    {
                        return @int.Value;
                    }
                    return default(int);

                case TypeCode.UInt32:
                    if (TryConvert_Uint(jsonNode, out uint? @uint) && @uint is not null)
                    {
                        return @uint.Value;
                    }
                    return default(uint);

                case TypeCode.Int64:
                    if (TryConvert_Long(jsonNode, out long? @long) && @long is not null)
                    {
                        return @long.Value;
                    }
                    return default(long);

                case TypeCode.UInt64:
                    if (TryConvert_Ulong(jsonNode, out ulong? @ulong) && @ulong is not null)
                    {
                        return @ulong.Value;
                    }
                    return default(ulong);

                case TypeCode.Int16:
                    if (TryConvert_Short(jsonNode, out short? @short) && @short is not null)
                    {
                        return @short.Value;
                    }
                    return default(short);

                case TypeCode.UInt16:
                    if (TryConvert_Ushort(jsonNode, out ushort? @ushort) && @ushort is not null)
                    {
                        return @ushort.Value;
                    }
                    return default(ushort);

                case TypeCode.Double:
                    if (TryConvert_Double(jsonNode, out double? @double) && @double is not null)
                    {
                        return @double.Value;
                    }
                    return default(double);

                case TypeCode.Single:
                    if (TryConvert_Float(jsonNode, out float? @float) && @float is not null)
                    {
                        return @float.Value;
                    }
                    return default(float);

                case TypeCode.Byte:
                    if (TryConvert_Byte(jsonNode, out byte? @byte) && @byte is not null)
                    {
                        return @byte.Value;
                    }
                    return default(byte);
            }

            if (type_Temp == typeof(Guid))
            {
                return jsonNode.GetValue<Guid>();
            }

            if (type_Temp == typeof(System.Drawing.Color))
            {
                Color? color = Create.SerializableObject<Color>(jsonNode.AsObject());
                if (color is null)
                {
                    return System.Drawing.Color.Empty;
                }

                return (System.Drawing.Color)color;
            }

            if (type_Temp == typeof(TimeSpan))
            {
                if (jsonNode is null)
                {
                    return false;
                }

                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        long ticks = jsonNode.GetValue<long>();

                        return TimeSpan.FromTicks(ticks);

                    case System.Text.Json.JsonValueKind.String:
                        object? @object = jsonNode.GetValue<object>();
                        if (@object is TimeSpan timeSpan)
                        {
                            return timeSpan;
                        }

                        if (@object is System.Text.Json.JsonElement)
                        {
                            @object = jsonNode.GetValue<string>();
                            if (TryConvert(@object, out timeSpan))
                            {
                                return timeSpan;
                            }
                        }

                        return null;
                }

                return null;
            }

            if (type_Temp.IsSubclassOf(typeof(Type)) || type_Temp == typeof(Type))
            {
                if (Value(jsonNode, typeof(string)) is not string fullName)
                {
                    return null;
                }

                return Type(fullName);
            }

            if (IsNumeric(type_Temp))
            {
                return jsonNode.GetValue<double>();
            }

            if (typeof(ISerializableObject).IsAssignableFrom(type_Temp))
            {
                return Create.SerializableObject<ISerializableObject>(jsonNode.AsObject());
            }

            if (typeof(Array).IsAssignableFrom(type_Temp))
            {
                Type type_Array = type_Temp.GetElementType();

                JsonArray jsonArray = jsonNode.AsArray();
                if (jsonArray != null)
                {
                    Array array = Array.CreateInstance(type_Array, jsonArray.Count);
                    for (int i = 0; i < jsonArray.Count; i++)
                    {
                        object? @object = Value(jsonArray[i], type_Array);
                        if (@object != null && !type_Array.IsAssignableFrom(@object.GetType()))
                        {
                            @object = type_Array.GetConstructor([@object.GetType()])?.Invoke([@object]);
                        }

                        array.SetValue(@object, i);
                    }

                    return array;
                }
            }

            if (typeof(IList).IsAssignableFrom(type_Temp))
            {
                Type? genericType = type_Temp.GenericTypeArguments?[0];
                if (genericType != null)
                {
                    IList? list = Create.List(genericType);
                    if (list == null)
                    {
                        return null;
                    }

                    JsonArray jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode? jsonNode_Temp in jsonArray)
                        {
                            object? @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && !genericType.IsAssignableFrom(@object.GetType()))
                            {
                                @object = genericType.GetConstructor([@object.GetType()])?.Invoke([@object]);
                            }

                            list.Add(@object);
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            if (typeof(IDictionary).IsAssignableFrom(type_Temp))
            {
                Type? genericType_Key = type.GenericTypeArguments?[0];
                Type? genericType_Value = type.GenericTypeArguments?[1];

                if (genericType_Key != null && genericType_Value != null)
                {
                    IDictionary? dictionary = Create.Dictionary(genericType_Key, genericType_Value);
                    if (dictionary is null)
                    {
                        return null;
                    }

                    switch (jsonNode.GetValueKind())
                    {
                        case System.Text.Json.JsonValueKind.Array:
                            JsonArray jsonArray = jsonNode.AsArray();
                            if (jsonArray != null)
                            {
                                foreach (JsonNode? jsonNode_Temp in jsonArray)
                                {
                                    if (jsonNode_Temp is null)
                                    {
                                        continue;
                                    }

                                    object? key = Value(jsonNode_Temp["Key"], genericType_Key);
                                    if (key != null)
                                    {
                                        dictionary[key] = Value(jsonNode_Temp["Value"], genericType_Value);
                                    }
                                }

                                return Activator.CreateInstance(type, dictionary);
                            }
                            break;

                        case System.Text.Json.JsonValueKind.Object:
                            JsonObject jsonObject = jsonNode.AsObject();
                            if (jsonObject != null)
                            {
                                foreach (KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
                                {
                                    object? key = Value(keyValuePair.Key, genericType_Key);
                                    if (key != null)
                                    {
                                        dictionary[key] = Value(keyValuePair.Value, genericType_Value);
                                    }
                                }

                                return Activator.CreateInstance(type, dictionary);
                            }
                            break;
                    }
                }
            }

            System.Text.Json.JsonValueKind jsonValueKind = jsonNode.GetValueKind();
            if (jsonValueKind is System.Text.Json.JsonValueKind.Object && jsonNode is not JsonObject)
            {
                jsonNode = JsonNode.Parse(jsonNode.ToJsonString())!.AsObject();
            }

            object? value = null;
            switch (jsonValueKind)
            {
                case System.Text.Json.JsonValueKind.String:
                    value = jsonNode.GetValue<string>();
                    break;

                case System.Text.Json.JsonValueKind.True:
                    value = true;
                    break;

                case System.Text.Json.JsonValueKind.Number:
                    value = jsonNode.GetValue<double>();
                    break;

                case System.Text.Json.JsonValueKind.False:
                    value = false;
                    break;

                case System.Text.Json.JsonValueKind.Null:
                    value = null;
                    break;

                case System.Text.Json.JsonValueKind.Object:
                    JsonObject jsonObject = (JsonObject)jsonNode;

                    if (jsonObject.ContainsKey(Constants.Serialization.PropertyName.Type))
                    {
                        ISerializableObject? serializableObject = Create.SerializableObject<ISerializableObject>(jsonObject);
                        if (serializableObject is SerializableObjectWrapper)
                        {
                            value = serializableObject.ToJsonObject();
                        }
                        else
                        {
                            value = serializableObject;
                        }
                    }
                    break;

                case System.Text.Json.JsonValueKind.Array:
                    value = jsonNode;
                    break;
            }

            if (value is not null && TryConvert(value, out object? result, type))
            {
                return result;
            }

            if (typeof(IEnumerable).IsAssignableFrom(type_Temp))
            {
                Type? genericType = type_Temp.GenericTypeArguments?[0];
                if (genericType != null)
                {
                    IList? list = Create.List(genericType);
                    if (list == null)
                    {
                        return null;
                    }

                    JsonArray jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode? jsonNode_Temp in jsonArray)
                        {
                            object? @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && !genericType.IsAssignableFrom(@object.GetType()))
                            {
                                @object = genericType.GetConstructor([@object.GetType()])?.Invoke([@object]);
                            }

                            list.Add(@object);
                        }

                        if (type.IsAbstract)
                        {
                            if (type.IsAssignableFrom(list.GetType()))
                            {
                                return list;
                            }

                            throw new NotImplementedException();
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            if (type_Temp.IsGenericType && type_Temp.GetGenericTypeDefinition() == typeof(KeyValuePair<,>))
            {
                Type[] types_GenericArguments = type_Temp.GetGenericArguments();
                if (types_GenericArguments != null && types_GenericArguments.Length >= 2)
                {
                    Type? type_Key = types_GenericArguments[0];
                    Type? type_Value = types_GenericArguments[1];
                    switch (jsonNode.GetValueKind())
                    {
                        case System.Text.Json.JsonValueKind.Object:
                            JsonObject jsonObject = jsonNode.AsObject();
                            if (jsonObject != null && jsonObject.ContainsKey("Key") && jsonObject.ContainsKey("Value"))
                            {
                                object? key = Value(jsonObject["Key"], type_Key);
                                object? value_Temp = Value(jsonObject["Value"], type_Value);
                                return Activator.CreateInstance(type_Temp, key, value_Temp);
                            }
                            break;
                    }
                }
            }

            return null;
        }
    }
}