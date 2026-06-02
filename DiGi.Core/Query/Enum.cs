using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Parses a string into an Enum value of the specified type.
        /// </summary>
        /// <param name="text">The string representation of the Enum.</param>
        /// <param name="type">The Type of the Enum.</param>
        /// <returns>The parsed Enum value, or null if parsing fails.</returns>
        public static Enum? Enum(string? text, Type? type)
        {
            if (TryGetEnum(text, type, out Enum? @enum))
            {
                return @enum;
            }

            return null;
        }

        /// <summary>
        /// Parses a string into a strongly-typed Enum value, providing a fallback default value.
        /// </summary>
        /// <typeparam name="TEnum">The type of the Enum.</typeparam>
        /// <param name="text">The string representation of the Enum.</param>
        /// <param name="default">The default value to return if parsing fails.</param>
        /// <returns>The parsed Enum value, or the default if parsing fails.</returns>
        public static TEnum? Enum<TEnum>(string? text, TEnum? @default) where TEnum : Enum
        {
            if (TryGetEnum(text, out TEnum? @enum))
            {
                return @enum;
            }

            return @default;
        }

        /// <summary>
        /// Parses a string into a strongly-typed Enum value.
        /// </summary>
        /// <typeparam name="TEnum">The type of the Enum.</typeparam>
        /// <param name="text">The string representation of the Enum.</param>
        /// <returns>The parsed Enum value, or the 'Undefined' enum value if found, or default if parsing fails.</returns>
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