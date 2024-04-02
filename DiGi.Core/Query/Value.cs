using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static object Value(this JsonNode jsonNode, Type type)
        {
            if(jsonNode == null || type == null)
            {
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
                Classes.Color color =  Create.SerializableObject<Classes.Color>(jsonNode.AsObject());
                return (System.Drawing.Color)color;
            }

            if (IsNumeric(type))
            {
                return jsonNode.GetValue<double>();
            }

            if(typeof(Interfaces.ISerializableObject).IsAssignableFrom(type))
            {
                return Create.SerializableObject<Interfaces.ISerializableObject>(jsonNode.AsObject());
            }

            if(typeof(IEnumerable).IsAssignableFrom(type))
            {
                Type genericType = type.GenericTypeArguments?[0];
                if(genericType != null)
                {
                    IList list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(new[] { genericType }));

                    JsonArray jsonArray = jsonNode.AsArray();
                    if(jsonArray != null)
                    {
                        foreach (JsonNode jsonNode_Temp in jsonArray)
                        {
                            object @object = Value(jsonNode_Temp, genericType);
                            if (@object != null && @object.GetType() != genericType)
                            {
                                @object = genericType.GetConstructor(new Type[] { @object.GetType() })?.Invoke(new object[] { @object });
                            }

                            list.Add(@object);
                        }

                        return Activator.CreateInstance(type, list);
                    }
                }
            }

            return null;
        }
    }

}
