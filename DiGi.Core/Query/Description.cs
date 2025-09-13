using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string? Description(this Enum? @enum)
        {
            Type? type = @enum?.GetType();
            if(type == null)
            {
                return null;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp != null)
            {
                type = type_Temp;
            }

            FieldInfo fieldInfo = type.GetField(@enum!.ToString());

            if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Any())
            {
                return descriptionAttributes[0].Description;
            }

            return @enum.ToString();
        }

        public static string? Description(this Type? type)
        {
            Type type_Temp = Nullable.GetUnderlyingType(type);
            if (type_Temp != null)
            {
                type = type_Temp;
            }

            if(type == null)
            {
                return null;
            }


            if (type.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descriptionAttributes && descriptionAttributes.Any())
            {
                return descriptionAttributes[0].Description;
            }

            return type.Name;
        }
    }

}
