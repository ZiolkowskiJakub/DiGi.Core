using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static object Value(this JsonNode jsonNode, Type type)
        {
            if (jsonNode == null || type == null)
            {
                return null;
            }

            if(jsonNode.GetType() == type)
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

            if(nullable)
            {
                object value_Temp = jsonNode.GetValue<object>();
                if(value_Temp == null)
                {
                    return null;
                }
            }

            if (type_Temp.IsEnum)
            {
                JsonValue jsonValue = jsonNode as JsonValue;
                if (jsonValue == null)
                {
                    return null;
                }

                object value_Temp = null;
                switch(jsonValue.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.String:
                        if (jsonValue.TryGetValue(out string @string))
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
                
                if(value_Temp == null)
                {
                    if (jsonValue.TryGetValue(out int @int))
                    {
                        value_Temp = @int;
                    }

                    if(value_Temp == null)
                    {
                        if (jsonValue.TryGetValue(out string @string))
                        {
                            value_Temp = @string;
                        }
                    }

                    if(value_Temp == null)
                    {
                        if (!jsonValue.TryGetValue(out value_Temp))
                        {
                            value_Temp = null;
                        }
                    }
                }

                if(nullable && value_Temp == null)
                {
                    return null;
                }

                if (TryConvert(value_Temp, out value_Temp, type_Temp))
                {
                    return value_Temp;
                }

                if(nullable)
                {
                    return null;
                }

                Array array = System.Enum.GetValues(type_Temp);
                if(array != null && array.Length != 0)
                {
                    return array.GetValue(0);
                }

                return null;
            }

            if (type_Temp == typeof(Guid))
            {
                return jsonNode.GetValue<Guid>();
            }

            if (type_Temp == typeof(string))
            {
                return jsonNode.GetValue<string>();
            }

            if (type_Temp == typeof(bool))
            {
                return jsonNode.GetValue<bool>();
            }

            if (type_Temp == typeof(DateTime))
            {
                return jsonNode.GetValue<DateTime>();
            }

            if (type_Temp == typeof(int))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<int>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out int @int))
                        {
                            return @int;
                        }
                        break;
                }

                return null;
            }

            if (type_Temp == typeof(uint))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<uint>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out uint @uint))
                        {
                            return @uint;
                        }
                        break;
                }

                return null;
            }

            if (type_Temp == typeof(short))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<short>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out short @short))
                        {
                            return @short;
                        }
                        break;
                }

                return null;
            }

            if (type_Temp == typeof(ushort))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<ushort>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out ushort @ushort))
                        {
                            return @ushort;
                        }
                        break;
                }

                return null;
            }

            if (type_Temp == typeof(double))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<double>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out double @double))
                        {
                            return @double;
                        }
                        break;
                }
                return null;
            }

            if (type_Temp == typeof(float))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<float>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out float @float))
                        {
                            return @float;
                        }
                        break;
                }
                return null;
            }

            if (type_Temp == typeof(byte))
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<byte>();

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out byte @byte))
                        {
                            return @byte;
                        }
                        break;
                }

                return null;
            }

            if (type_Temp == typeof(System.Drawing.Color))
            {
                Color color = Create.SerializableObject<Color>(jsonNode.AsObject());
                return (System.Drawing.Color)color;
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
                        object @object = Value(jsonArray[i], type_Array);
                        if (@object != null && !type_Array.IsAssignableFrom(@object.GetType()))
                        {
                            @object = type_Array.GetConstructor(new Type[] { @object.GetType() })?.Invoke(new object[] { @object });
                        }

                        array.SetValue(@object, i);
                    }

                    return array;
                }
            }

            if (typeof(IList).IsAssignableFrom(type_Temp))
            {
                Type genericType = type_Temp.GenericTypeArguments?[0];
                if (genericType != null)
                {
                    IList list = Create.List(genericType);

                    JsonArray jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode jsonNode_Temp in jsonArray)
                        {
                            object @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && !genericType.IsAssignableFrom(@object.GetType()))
                            {
                                @object = genericType.GetConstructor(new Type[] { @object.GetType() })?.Invoke(new object[] { @object });
                            }

                            list.Add(@object);
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            if (typeof(IDictionary).IsAssignableFrom(type_Temp))
            {
                Type genericType_Key = type.GenericTypeArguments?[0];
                Type genericType_Value = type.GenericTypeArguments?[1];

                if (genericType_Key != null && genericType_Value != null)
                {
                    IDictionary dictionary = Create.Dictionary(genericType_Key, genericType_Value);

                    JsonArray jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode jsonNode_Temp in jsonArray)
                        {
                            object key = Value(jsonNode_Temp["Key"], genericType_Key);
                            if (key != null)
                            {
                                dictionary[key] = Value(jsonNode_Temp["Value"], genericType_Value);
                            }
                        }

                        return Activator.CreateInstance(type, dictionary);
                    }
                }
            }

            object value = null;
            switch (jsonNode.GetValueKind())
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
                    ISerializableObject serializableObject = Create.SerializableObject<ISerializableObject>((JsonObject)jsonNode);
                    if(serializableObject is SerializableObjectWrapper)
                    {
                        value = serializableObject.ToJsonObject();
                    }
                    else
                    {
                        value = serializableObject;
                    }

                    break;
            }

            if (TryConvert(value, out object result, type))
            {
                return result;
            }

            if(typeof(IEnumerable).IsAssignableFrom(type_Temp))
            {
                Type genericType = type_Temp.GenericTypeArguments?[0];
                if (genericType != null)
                {
                    IList list = Create.List(genericType);

                    JsonArray jsonArray = jsonNode.AsArray();
                    if (jsonArray != null)
                    {
                        foreach (JsonNode jsonNode_Temp in jsonArray)
                        {
                            object @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && !genericType.IsAssignableFrom(@object.GetType()))
                            {
                                @object = genericType.GetConstructor(new Type[] { @object.GetType() })?.Invoke(new object[] { @object });
                            }

                            list.Add(@object);
                        }

                        if(type.IsAbstract)
                        {
                            if(type.IsAssignableFrom(list.GetType()))
                            {
                                return list;
                            }

                            throw new NotImplementedException();
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            return null;
        }
    }

}
