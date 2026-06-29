using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the properties and fields of a type that are marked for serialization.
        /// </summary>
        /// <param name="type">The type to reflect on.</param>
        /// <returns>A list of serializable MemberInfo objects.</returns>
        public static List<MemberInfo>? SerializableMemberInfos(this Type? type)
        {
            if (type == null)
            {
                return null;
            }

            List<MemberInfo> result = [];

            List<MemberInfo>? memberInfos = SerializableMemberInfos(type.BaseType);

            List<MemberInfo> memberInfos_Ignored = [];

            PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                object[]? objects = propertyInfos[i]?.GetCustomAttributes(typeof(JsonIgnoreAttribute), false);
                if (objects == null || objects.Length == 0)
                {
                    result.Add(propertyInfos[i]);
                }
                else
                {
                    memberInfos_Ignored.Add(propertyInfos[i]);
                }
            }

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                object[]? objects = fieldInfos[i]?.GetCustomAttributes(typeof(JsonIncludeAttribute), false);
                if (objects != null && objects.Length != 0)
                {
                    result.Add(fieldInfos[i]);
                }
                else
                {
                    memberInfos_Ignored.Add(fieldInfos[i]);
                }
            }

            if (memberInfos != null && memberInfos.Count != 0)
            {
                if (memberInfos_Ignored.Count != 0)
                {
                    HashSet<(Type, string)> ignored = [];
                    for (int i = 0; i < memberInfos_Ignored.Count; i++)
                    {
                        MemberInfo memberInfo_Ignored = memberInfos_Ignored[i];
                        ignored.Add((memberInfo_Ignored.GetType(), memberInfo_Ignored.Name));
                    }

                    memberInfos.RemoveAll(x => ignored.Contains((x.GetType(), x.Name)));
                }

                if (memberInfos.Count != 0)
                {
                    result.InsertRange(0, memberInfos);
                }
            }

            return result;
        }
    }
}