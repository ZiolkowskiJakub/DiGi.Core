using DiGi.Core.Enums;
using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Compares two numbers using NumberComparisonType (Example: NumberComparisonType.Greater returns true if value_1 greater than value_2)
        /// </summary>
        /// <param name="value_1">First value</param>
        /// <param name="value_2">Second value</param>
        /// <param name="numberComparisonType">Number Comparison Type example Equals etc.</param>
        /// <returns>Comparison Type Result</returns>
        public static bool Compare(this double value_1, double value_2, NumberComparisonType numberComparisonType)
        {
            return Compare(value_1, value_2, numberComparisonType, 0);
        }

        /// <summary>
        /// Compares two numbers using NumberComparisonType (Example: NumberComparisonType.Greater returns true if value_1 greater than value_2)
        /// </summary>
        /// <param name="value_1">First value</param>
        /// <param name="value_2">Second value</param>
        /// <param name="numberComparisonType">Number Comparison Type example Equals etc.</param>
        /// <param name="tolerance">Comparison tolerance</param>
        /// <returns>Comparison Type Result</returns>
        public static bool Compare(this double value_1, double value_2, NumberComparisonType numberComparisonType, double tolerance)
        {
            switch (numberComparisonType)
            {
                case NumberComparisonType.Equals:
                    if (double.IsNaN(value_1) && double.IsNaN(value_2))
                        return true;
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1.AlmostEquals(value_2, tolerance);

                case NumberComparisonType.Greater:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 > value_2 - tolerance;

                case NumberComparisonType.GreaterOrEquals:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 >= value_2 - tolerance;

                case NumberComparisonType.Less:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 < value_2 + tolerance;

                case NumberComparisonType.LessOrEquals:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 <= value_2 + tolerance;

                case NumberComparisonType.NotEquals:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return !value_1.AlmostEquals(value_2, tolerance);
            }

            return false;
        }

        /// <summary>
        /// Compares two DateTimes using NumberComparisonType (Example: NumberComparisonType.Greater returns true if value_1 greater than value_2)
        /// </summary>
        /// <param name="value_1">First value</param>
        /// <param name="value_2">Second value</param>
        /// <param name="numberComparisonType">Number Comparison Type example Equals etc.</param>
        /// <returns>Comparison Type Result</returns>
        public static bool Compare(this DateTime value_1, DateTime value_2, NumberComparisonType numberComparisonType)
        {
            return numberComparisonType switch
            {
                NumberComparisonType.Equals => value_1.Equals(value_2),
                NumberComparisonType.Greater => value_1 > value_2,
                NumberComparisonType.GreaterOrEquals => value_1 >= value_2,
                NumberComparisonType.Less => value_1 < value_2,
                NumberComparisonType.LessOrEquals => value_1 <= value_2,
                NumberComparisonType.NotEquals => value_1 != value_2,
                _ => false,
            };
        }

        /// <summary>
        /// Compares two numbers using TextComparisonType (Example: TextComparisonType.StartsWith returns true if value_1 starts with value_2)
        /// </summary>
        /// <param name="value_1">Base value to be checked, reference text ie.GUID to be found</param>
        /// <param name="value_2">Text to be checked ie. name containing GUID</param>
        /// <param name="textComparisonType">Text Comparison Type</param>
        /// <param name="caseSensitive">Case Sensitive</param>
        /// <returns>Bool</returns>
        public static bool Compare(this string? value_1, string? value_2, TextComparisonType textComparisonType, bool caseSensitive = true)
        {
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            // Handle Null scenarios first to fix Bug 3 logically and cleanly
            if (value_1 == null && value_2 == null)
            {
                switch (textComparisonType)
                {
                    case TextComparisonType.Equals:
                    case TextComparisonType.Contains:
                    case TextComparisonType.StartsWith:
                    case TextComparisonType.EndsWith:
                        return true;

                    case TextComparisonType.NotEquals:
                    case TextComparisonType.NotContains:
                    case TextComparisonType.NotStartsWith:
                    case TextComparisonType.NotEndsWith:
                        return false;
                }
                return false;
            }

            if (value_1 == null || value_2 == null)
            {
                // One of them is null, the other is not.
                switch (textComparisonType)
                {
                    case TextComparisonType.Equals:
                        return false;

                    case TextComparisonType.NotEquals:
                        return true;

                    case TextComparisonType.Contains:
                    case TextComparisonType.StartsWith:
                    case TextComparisonType.EndsWith:
                        return false;

                    case TextComparisonType.NotContains:
                    case TextComparisonType.NotStartsWith:
                    case TextComparisonType.NotEndsWith:
                        return true;
                }
                return false;
            }

            // Both are non-null. Perform highly optimized, allocation-free comparison
            switch (textComparisonType)
            {
                case TextComparisonType.Equals:
                    return string.Equals(value_1, value_2, comparison);

                case TextComparisonType.NotEquals:
                    return !string.Equals(value_1, value_2, comparison);

                case TextComparisonType.Contains:
                    return value_1.IndexOf(value_2, comparison) >= 0;

                case TextComparisonType.NotContains:
                    return value_1.IndexOf(value_2, comparison) < 0;

                case TextComparisonType.StartsWith:
                    return value_1.StartsWith(value_2, comparison);

                case TextComparisonType.NotStartsWith:
                    return !value_1.StartsWith(value_2, comparison);

                case TextComparisonType.EndsWith:
                    return value_1.EndsWith(value_2, comparison);

                case TextComparisonType.NotEndsWith:
                    return !value_1.EndsWith(value_2, comparison);
            }

            return false;
        }

        /// <summary>
        /// Compares a collection of strings against a single string using the specified comparison type.
        /// </summary>
        /// <param name="values">The collection of strings to compare.</param>
        /// <param name="value">The string to compare against.</param>
        /// <param name="textComparisonType">The comparison type to use.</param>
        /// <param name="caseSensitive">Whether the comparison should be case sensitive.</param>
        /// <returns>A list of booleans representing the comparison results.</returns>
        public static List<bool>? Compare(this IEnumerable<string>? values, string? value, TextComparisonType textComparisonType, bool caseSensitive = true)
        {
            if (values == null)
            {
                return null;
            }

            List<bool> result = [];
            foreach (string value_Temp in values)
            {
                result.Add(Compare(value_Temp, value, textComparisonType, caseSensitive));
            }

            return result;
        }

        /// <summary>
        /// Compares a collection of doubles against a single double using the specified comparison type.
        /// </summary>
        /// <param name="values">The collection of doubles to compare.</param>
        /// <param name="value">The double to compare against.</param>
        /// <param name="numberComparisonType">The numeric comparison type to use.</param>
        /// <returns>A list of booleans representing the comparison results.</returns>
        public static List<bool>? Compare(this IEnumerable<double>? values, double value, NumberComparisonType numberComparisonType)
        {
            if (values == null)
                return null;

            List<bool> result = [];
            foreach (double value_Temp in values)
            {
                result.Add(Compare(value_Temp, value, numberComparisonType));
            }

            return result;
        }
    }
}