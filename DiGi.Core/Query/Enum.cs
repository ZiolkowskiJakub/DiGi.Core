using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static Enum? Enum(string? text, Type? type)
        {
            if (TryGetEnum(text, type, out Enum? @enum))
            {
                return @enum;
            }

            return null;
        }

        public static TEnum? Enum<TEnum>(string? text, TEnum? @default) where TEnum : Enum
        {
            if (TryGetEnum(text, out TEnum? @enum))
            {
                return @enum;
            }

            return @default;
        }

        public static TEnum? Enum<TEnum>(string? text) where TEnum : Enum
        {
            if (TryGetEnum(text, out TEnum? @enum))
            {
                return @enum;
            }

            if (TryGetEnum("Undefined", out @enum))
            {
                return @enum;
            }

            return default;
        }
    }

}
