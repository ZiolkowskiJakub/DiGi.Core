using DiGi.Core.Interfaces;
using System;
using System.Text;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string? FullTypeName(this JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return null;
            }

            if (!jsonObject.TryGetPropertyValue(Constants.Serialization.PropertyName.Type, out JsonNode? jsonNode) || jsonNode == null)
            {
                return null;
            }

            JsonValue jsonValue = jsonNode.AsValue();
            if (jsonValue == null)
            {
                return null;
            }

            if (!jsonValue.TryGetValue(out string? result))
            {
                return null;
            }

            return result;
        }

        public static string? FullTypeName(Type? type)
        {
            if (type == null)
            {
                return null;
            }

            StringBuilder stringBuilder = new();

            void BuildName(Type type_Temp)
            {
                if (type_Temp.IsPrimitive)
                {
                    stringBuilder.Append(type_Temp.FullName);
                }
                else if (type_Temp.IsGenericType)
                {
                    stringBuilder.Append(type_Temp.Namespace).Append('.').Append(type_Temp.Name);

                    Type[] types_Generic = type_Temp.GetGenericArguments();
                    if (types_Generic != null && types_Generic.Length > 0)
                    {
                        stringBuilder.Append('[');
                        for (int i = 0; i < types_Generic.Length; i++)
                        {
                            if (i > 0)
                            {
                                stringBuilder.Append(',');
                            }

                            stringBuilder.Append('[');
                            BuildName(types_Generic[i]);
                            stringBuilder.Append(']');
                        }
                        stringBuilder.Append(']');
                    }
                }
                else
                {
                    stringBuilder.Append(type_Temp.FullName);
                }

                stringBuilder.Append(',');
                string assemblyFullName = type_Temp.Assembly.FullName;
                int commaIndex = assemblyFullName.IndexOf(',');
                if (commaIndex > 0)
                {
                    stringBuilder.Append(assemblyFullName.Substring(0, commaIndex));
                }
                else
                {
                    stringBuilder.Append(assemblyFullName);
                }
            }

            BuildName(type);
            return stringBuilder.ToString();
        }

        //public static string? FullTypeName(Type? type)
        //{
        //    if (type == null)
        //    {
        //        return null;
        //    }

        //    if (type.IsPrimitive)
        //    {
        //        return type.FullName;
        //    }

        //    if (type.IsGenericType)
        //    {
        //        Type[] types_Generic = type.GetGenericArguments();
        //        if (types_Generic != null && types_Generic.Length != 0)
        //        {
        //            List<string> typeNames = [];
        //            foreach (Type type_Generic in types_Generic)
        //            {
        //                typeNames.Add(string.Format("[{0}]", FullTypeName(type_Generic)));
        //            }

        //            return string.Format("{0}.{1}[{2}],{3}", type.Namespace, type.UnderlyingSystemType.Name, string.Join(",", typeNames), type.Assembly.GetName().Name);
        //        }
        //    }

        //    return string.Format("{0},{1}", type.FullName, type.Assembly.GetName().Name);
        //}

        public static string? FullTypeName(ISerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            return FullTypeName(serializableObject.GetType());
        }
    }
}