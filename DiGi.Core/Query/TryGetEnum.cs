using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetEnum(string? text, out Enum? @enum)
        {
            @enum = default;
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            string[] values = text!.Split(':');
            if (values.Length < 2)
            {
                return false;
            }

            Type? type = Type(values[0]);
            if (type == null)
            {
                return false;
            }

            return TryGetEnum(values[1], type, out @enum);
        }

        /// <summary>
        /// Attempts to parse a string into an enum value by checking names, descriptions, and fuzzy matching.
        /// </summary>
        public static bool TryGetEnum(this string? text, Type? type, out Enum? @enum)
        {
            @enum = null;

            // Guard clauses
            if (string.IsNullOrEmpty(text) || type == null || !type.IsEnum)
            {
                return false;
            }

            // In .NET Standard 2.0, GetValues returns a standard Array.
            // This is an allocation, but inevitable without a cache.
            Array enumValues = System.Enum.GetValues(type);
            Enum? undefinedValue = null;

            // Normalize input once to save allocations during the loop
            string cleanedInput = text!.Replace(" ", string.Empty);

            for (int i = 0; i < enumValues.Length; i++)
            {
                Enum currentValue = (Enum)enumValues.GetValue(i);
                string name = System.Enum.GetName(type, currentValue);

                if (name == null) continue;

                // 1. Precise Match (Case Sensitive)
                if (name.Equals(text, StringComparison.Ordinal))
                {
                    @enum = currentValue;
                    return true;
                }

                // 2. Identify "Undefined" fallback during the main loop
                if (undefinedValue == null && name.Equals("Undefined", StringComparison.OrdinalIgnoreCase))
                {
                    undefinedValue = currentValue;
                }

                // 3. Description Match
                // Note: Description() is assumed to be your extension method
                string? description = currentValue.Description();
                if (description != null)
                {
                    if (description.Equals(text, StringComparison.Ordinal))
                    {
                        @enum = currentValue;
                        return true;
                    }

                    // 4. Fuzzy Match (Description without spaces)
                    // OrdinalIgnoreCase is faster than ToUpper/ToLower in .NET Standard 2.0
                    if (description.Replace(" ", string.Empty).Equals(cleanedInput, StringComparison.OrdinalIgnoreCase))
                    {
                        @enum = currentValue;
                        return true;
                    }
                }

                // 5. Fuzzy Match (Name without spaces)
                if (name.Replace(" ", string.Empty).Equals(cleanedInput, StringComparison.OrdinalIgnoreCase))
                {
                    @enum = currentValue;
                    return true;
                }
            }

            // No match found - fallback to Undefined if it was discovered
            @enum = undefinedValue;
            return false;
        }

        public static bool TryGetEnum<TEnum>(this string? text, out TEnum? @enum) where TEnum : Enum
        {
            @enum = default;
            if (!TryGetEnum(text, typeof(TEnum), out Enum? @enum_Temp))
            {
                return false;
            }

            if (enum_Temp is not TEnum)
            {
                return false;
            }

            @enum = (TEnum)enum_Temp;
            return true;
        }
    }
}