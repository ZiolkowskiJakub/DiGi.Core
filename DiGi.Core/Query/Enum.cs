using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static Enum Enum(string text, Type type)
        {
            if(TryGetEnum(text, type, out Enum @enum))
            {
                return @enum;
            }

            return null;
        }

        public static T Enum<T>(string text, T @default) where T : Enum
        {
            if (TryGetEnum(text, out T @enum))
            {
                return @enum;
            }

            return @default;
        }

        public static T Enum<T>(string text) where T : Enum
        {
            if (TryGetEnum(text, out T @enum))
            {
                return @enum;
            }

            if(TryGetEnum("Undefined", out @enum))
            {
                return @enum;
            }

            return default(T);
        }
    }

}
