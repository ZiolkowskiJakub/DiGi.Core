using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.Core.Parameters
{
    public static partial class Query
    {
        public static string Description(this Enum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(@enum.ToString());

            DescriptionAttribute[] descriptionAttributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (descriptionAttributes != null && descriptionAttributes.Any())
            {
                return descriptionAttributes[0].Description;
            }

            return @enum.ToString();
        }

        public static string Description(this Type type)
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
                DescriptionAttribute descriptionAttribute = @object as DescriptionAttribute;
                if (descriptionAttribute != null)
                {
                    return descriptionAttribute.Description;
                }
            }

            return null;
        }
    }
}