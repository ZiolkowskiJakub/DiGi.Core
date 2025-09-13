using System;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static TAttribute? CustomAttribute<TAttribute>(Enum? @enum) where TAttribute : Attribute
        {
            if (@enum == null)
            {
                return default;
            }

            MemberInfo[] memberInfos = @enum.GetType().GetMember(@enum.ToString());
            if (memberInfos == null || memberInfos.Length == 0)
            {
                return default;
            }

            return CustomAttribute<TAttribute>(memberInfos[0]);
        }

        public static TAttribute? CustomAttribute<TAttribute>(Type? type, string? text) where TAttribute : Attribute
        {
            if (type == null || string.IsNullOrEmpty(text))
            {
                return default;
            }

            MemberInfo[] memberInfos = type.GetMember(text);
            if (memberInfos == null || memberInfos.Length == 0)
            {
                return default;
            }

            return CustomAttribute<TAttribute>(memberInfos[0]);
        }

        public static TAttribute? CustomAttribute<TAttribute>(this MemberInfo? memberInfo) where TAttribute : Attribute
        {
            if (memberInfo == null)
            {
                return default;
            }

            Attribute[] attributes = Attribute.GetCustomAttributes(memberInfo);
            if (attributes == null || attributes.Length == 0)
            {
                return default;
            }

            foreach (Attribute attribute in attributes)
            {
                if (attribute is not TAttribute)
                {
                    continue;
                }

                return (TAttribute)attribute;
            }

            return default;
        }
    }
}