using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetEnum(string text, out Enum @enum)
        {
            @enum = default;
            if(string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            string[] values = text.Split(':');
            if(values.Length < 2)
            {
                return false;
            }

            Type type = Type(values[0]);
            if(type == null)
            {
                return false;
            }

            return TryGetEnum(values[1], type, out @enum);
        }

        public static bool TryGetEnum(this string text, Type type, out Enum @enum)
        {
            @enum = null;

            if (string.IsNullOrWhiteSpace(text) || type == null || !type.IsEnum)
            {
                return false;
            }

            Array array = Enum.GetValues(type);
            if (array == null || array.Length == 0)
            {
                return false;
            }

            foreach (Enum @enum_Temp in array)
            {
                if (nameof(@enum_Temp).Equals(text))
                {
                    @enum = enum_Temp;
                    return true;
                }
            }

            List<string> texts = new List<string>();
            string text_Temp = null;

            foreach (Enum @enum_Temp in array)
            {
                text_Temp = @enum_Temp.Description();
                texts.Add(text_Temp);
                if (text_Temp.Equals(text))
                {
                    @enum = @enum_Temp;
                    return true;
                }

            }

            text_Temp = text.ToUpper().Replace(" ", string.Empty);
            for (int i = 0; i < array.Length; i++)
            {
                if (texts[i].ToUpper().Replace(" ", string.Empty).Equals(text_Temp))
                {
                    @enum = (Enum)array.GetValue(i);
                    return true;
                }
            }

            foreach (Enum @enum_Temp in array)
            {
                if (nameof(@enum_Temp).ToUpper().Equals("UNDEFINED"))
                {
                    @enum = enum_Temp;
                    return false;
                }
            }

            return false;
        }

        public static bool TryGetEnum<T>(this string text, out T @enum) where T : Enum
        {
            @enum = default;
            if (!TryGetEnum(text, typeof(T), out Enum @enum_Temp))
            {
                return false;
            }

            if (enum_Temp is T)
            {
                @enum = (T)enum_Temp;
                return true;
            }

            return false;
        }
    }

}
