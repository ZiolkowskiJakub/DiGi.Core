using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<MemberInfo> SerializableMemberInfos(this Type type)
        {
            if(type == null)
            {
                return null;
            }

            List<MemberInfo> result = new List<MemberInfo>();

            List<MemberInfo> memberInfos = SerializableMemberInfos(type.BaseType);
            if(memberInfos != null)
            {
                result.AddRange(memberInfos);
            }

            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                object[] objects = propertyInfos[i]?.GetCustomAttributes(typeof(JsonIgnoreAttribute), false);
                if (objects == null || objects.Length == 0)
                {
                    result.Add(propertyInfos[i]);
                }
            }

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                object[] objects = fieldInfos[i]?.GetCustomAttributes(typeof(JsonIncludeAttribute), false);
                if (objects != null && objects.Length != 0)
                {
                    result.Add(fieldInfos[i]);
                }
            }

            return result;
        }
    }
}
