﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string Description(this Enum @enum)
        {
            FieldInfo fieldInfo = @enum.GetType().GetField(nameof(@enum));

            DescriptionAttribute[] descriptionAttributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (descriptionAttributes != null && descriptionAttributes.Any())
                return descriptionAttributes[0].Description;

            return @enum.ToString();
        }
    }

}
