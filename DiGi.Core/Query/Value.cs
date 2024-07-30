using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Text.Json.Nodes;
using System.Xml.Linq;


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

            if (type.IsEnum)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        return jsonNode.GetValue<Enum>();
                    //return Enum.GetValues(type).GetValue(jsonNode.GetValue<int>());

                    case System.Text.Json.JsonValueKind.String:
                        return Enum.Parse(type, jsonNode.GetValue<string>());
                }

                return null;
            }

            if (type == typeof(Guid))
            {
                return jsonNode.GetValue<Guid>();
            }

            if (type == typeof(string))
            {
                return jsonNode.GetValue<string>();
            }

            if (type == typeof(bool))
            {
                return jsonNode.GetValue<bool>();
            }

            if (type == typeof(DateTime))
            {
                return jsonNode.GetValue<DateTime>();
            }

            if (type == typeof(int))
            {
                return jsonNode.GetValue<int>();
            }

            if (type == typeof(double))
            {
                return jsonNode.GetValue<double>();
            }

            if (type == typeof(byte))
            {
                return jsonNode.GetValue<byte>();
            }

            if (type == typeof(System.Drawing.Color))
            {
                Color color = Create.SerializableObject<Color>(jsonNode.AsObject());
                return (System.Drawing.Color)color;
            }

            if (IsNumeric(type))
            {
                return jsonNode.GetValue<double>();
            }

            if (typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return Create.SerializableObject<ISerializableObject>(jsonNode.AsObject());
            }

            if (typeof(IList).IsAssignableFrom(type))
            {
                Type genericType = type.GenericTypeArguments?[0];
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

            if (typeof(IDictionary).IsAssignableFrom(type))
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

            return null;
        }
    }

}
