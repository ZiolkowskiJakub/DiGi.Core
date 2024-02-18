using System;
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

            return null;
        }
    }

}
