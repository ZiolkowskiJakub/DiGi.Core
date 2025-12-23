using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static string? Description(this Enum? @enum)
        {
            FieldInfo? fieldInfo = @enum?.GetType()?.GetField(@enum?.ToString());
            if (fieldInfo is null)
            {
                return null;
            }

            if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Any())
            {
                return descriptionAttributes[0].Description;
            }

            return @enum!.ToString();
        }

        public static string? Description(this Type? type)
        {
            if (type == null)
            {
                return null;
            }

            object[] objects = type.GetCustomAttributes(typeof(DescriptionAttribute), true);
            if (objects == null || objects.Length == 0)
            {
                return null;
            }

            foreach (object @object in objects)
            {
                if (@object is DescriptionAttribute descriptionAttribute)
                {
                    return descriptionAttribute.Description;
                }
            }

            return null;
        }
    }
}