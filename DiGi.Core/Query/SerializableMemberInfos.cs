using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DiGi.Core
{
    public static partial class Query
    {
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
                    for (int i = 0; i < memberInfos_Ignored.Count; i++)
                    {
                        MemberInfo memberInfo_Ignored = memberInfos_Ignored[i];

                        Type type_Ignored = memberInfo_Ignored.GetType();

                        int index = memberInfos.FindIndex(x => x.GetType() == type_Ignored && x.Name == memberInfo_Ignored.Name);
                        if (index != -1)
                        {
                            memberInfos.RemoveAt(index);
                            if (memberInfos.Count == 0)
                            {
                                break;
                            }
                        }
                    }
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