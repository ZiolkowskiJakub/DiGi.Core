using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static string FullTypeName(this JsonObject jsonObject)
        {
            if (jsonObject == null)
            {
                return null;
            }

            if(!jsonObject.TryGetPropertyValue(Constans.Serialization.PropertyName.Type, out JsonNode jsonNode) || jsonNode == null || jsonNode.GetValueKind() != System.Text.Json.JsonValueKind.String)
            {
                return null;
            }

            return (string)jsonNode;
        }

        public static string FullTypeName(Type type)
        {
            if (type == null)
            {
                return null;
            }

            if (type.IsPrimitive)
            {
                return type.FullName;
            }

            if (type.IsGenericType)
            {
                Type[] types_Generic = type.GetGenericArguments();
                if (types_Generic != null && types_Generic.Length != 0)
                {
                    List<string> typeNames = new List<string>();
                    foreach (Type type_Generic in types_Generic)
                    {
                        typeNames.Add(string.Format("[{0}]", FullTypeName(type_Generic)));
                    }

                    return string.Format("{0}.{1}[{2}],{3}", type.Namespace, type.UnderlyingSystemType.Name, string.Join(",", typeNames), type.Assembly.GetName().Name);
                }
            }

            return string.Format("{0},{1}", type.FullName, type.Assembly.GetName().Name);
        }

        public static string FullTypeName(ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            return FullTypeName(serializableObject.GetType());
        }
    }
}
