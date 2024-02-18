﻿using DiGi.Core.Enums;
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
            switch (numberComparisonType)
            {
                case NumberComparisonType.Equals:
                    if (double.IsNaN(value_1) && double.IsNaN(value_2))
                        return true;
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1.Equals(value_2);

                case NumberComparisonType.Greater:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 > value_2;

                case NumberComparisonType.GreaterOrEquals:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 >= value_2;

                case NumberComparisonType.Less:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 < value_2;

                case NumberComparisonType.LessOrEquals:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 <= value_2;

                case NumberComparisonType.NotEquals:
                    if (double.IsNaN(value_1) || double.IsNaN(value_2))
                        return false;
                    return value_1 != value_2;
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
            switch (numberComparisonType)
            {
                case NumberComparisonType.Equals:
                    return value_1.Equals(value_2);

                case NumberComparisonType.Greater:
                    return value_1 > value_2;

                case NumberComparisonType.GreaterOrEquals:
                    return value_1 >= value_2;

                case NumberComparisonType.Less:
                    return value_1 < value_2;

                case NumberComparisonType.LessOrEquals:
                    return value_1 <= value_2;

                case NumberComparisonType.NotEquals:
                    return value_1 != value_2;
            }

            return false;
        }

        /// <summary>
        /// Compares two numbers using TextComparisonType (Example: TextComparisonType.StartsWith returns true if value_1 starts with value_2)
        /// </summary>
        /// <param name="value_1">Base value to be checked, reference text ie.GUID to be found</param>
        /// <param name="value_2">Text to be checked ie. name containing GUID</param>
        /// <param name="textComparisonType">Text Comparison Type</param>
        /// <param name="caseSensitive">Case Sensitive</param>
        /// <returns>Bool</returns>
        public static bool Compare(this string value_1, string value_2, TextComparisonType textComparisonType, bool caseSensitive = true)
        {
            string value_1_Temp = value_1;
            string value_2_Temp = value_2;
            if (!caseSensitive)
            {
                if (!string.IsNullOrEmpty(value_1_Temp))
                    value_1_Temp = value_1_Temp.ToLower();

                if (!string.IsNullOrEmpty(value_2_Temp))
                    value_2_Temp = value_2_Temp.ToLower();
            }

            switch (textComparisonType)
            {
                case TextComparisonType.Equals:
                    if (value_1_Temp == null && value_2_Temp == null)
                        return true;
                    if (value_1_Temp == null || value_2_Temp == null)
                        return false;
                    return value_1_Temp.Equals(value_2_Temp);

                case TextComparisonType.Contains:
                    if (value_1_Temp == null || value_2_Temp == null)
                        return false;
                    return value_1_Temp.Contains(value_2_Temp);

                case TextComparisonType.NotContains:
                    if (value_1_Temp == null || value_2_Temp == null)
                        return false;
                    return !value_1_Temp.Contains(value_2_Temp);

                case TextComparisonType.EndsWith:
                    if (value_1_Temp == null || value_2_Temp == null)
                        return false;
                    return value_1_Temp.EndsWith(value_2_Temp);

                case TextComparisonType.NotEquals:
                    if (value_1_Temp == null && value_2_Temp == null)
                        return false;
                    if (value_1_Temp == null || value_2_Temp == null)
                        return true;
                    return !value_1_Temp.Equals(value_2_Temp);

                case TextComparisonType.StartsWith:
                    if (value_1_Temp == null || value_2_Temp == null)
                        return false;
                    return value_1_Temp.StartsWith(value_2_Temp);
            }

            return false;
        }

        public static List<bool> Compare(this IEnumerable<string> values, string value, TextComparisonType textComparisonType, bool caseSensitive = true)
        {
            if (values == null)
                return null;

            List<bool> result = new List<bool>();
            foreach (string value_Temp in values)
                result.Add(Compare(value_Temp, value, textComparisonType, caseSensitive));

            return result;
        }

        public static List<bool> Compare(this IEnumerable<double> values, double value, NumberComparisonType numberComparisonType)
        {
            if (values == null)
                return null;

            List<bool> result = new List<bool>();
            foreach (double value_Temp in values)
                result.Add(Compare(value_Temp, value, numberComparisonType));

            return result;
        }
    }
}
