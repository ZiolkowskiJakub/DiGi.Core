using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to parse the specified string into a double-precision floating-point number.
        /// </summary>
        /// <param name="value">The string containing the double-precision floating-point number to parse.</param>
        /// <param name="result">When this method returns, contains the parsed value if the conversion was successful; otherwise, zero.</param>
        /// <returns>true if the string was successfully parsed; otherwise, false.</returns>
        public static bool TryParseDouble(this string value, out double result)
        {
            result = double.NaN;

            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            // Find trimmed bounds without allocating
            int start = 0;
            while (start < value.Length && char.IsWhiteSpace(value[start]))
            {
                start++;
            }

            int end = value.Length;
            while (end > start && char.IsWhiteSpace(value[end - 1]))
            {
                end--;
            }

            if (start >= end)
            {
                return false;
            }

            // Check if there is an exponent 'E' or 'e'
            int expIndex = -1;
            for (int i = start; i < end; i++)
            {
                char c = value[i];
                if (c == 'E' || c == 'e')
                {
                    expIndex = i;
                    break;
                }
            }

            if (expIndex != -1)
            {
                // Parse prefix and suffix
                string value_Prefix = value.Substring(start, expIndex - start);
                string value_Suffix = "1" + value.Substring(expIndex, end - expIndex);

                if (!double.TryParse(value_Suffix, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double factor))
                {
                    return false;
                }

                if (value_Prefix.Length == 0)
                {
                    result = factor;
                    return true;
                }
                else if (TryParseDouble(value_Prefix, out result))
                {
                    result *= factor;
                    return true;
                }

                return false;
            }

            // Find the first word bounds (split by space)
            int firstSpace = -1;
            for (int i = start; i < end; i++)
            {
                if (value[i] == ' ')
                {
                    firstSpace = i;
                    break;
                }
            }

            int firstWordEnd = (firstSpace != -1) ? firstSpace : end;
            int firstWordLength = firstWordEnd - start;

            if (firstWordLength > 0)
            {
                char firstChar = value[start];
                if (firstChar == 'I' || firstChar == 'i' || firstChar == 'N' || firstChar == 'n' ||
                    (firstChar == '-' && firstWordLength > 1 && (value[start + 1] == 'I' || value[start + 1] == 'i')))
                {
                    string firstWord = value.Substring(start, firstWordLength);
                    if (firstWord == Constants.Serialization.LiteralName.PositiveInfinity)
                    {
                        result = double.PositiveInfinity;
                        return true;
                    }
                    if (firstWord == Constants.Serialization.LiteralName.NegativeInfinity)
                    {
                        result = double.NegativeInfinity;
                        return true;
                    }
                    if (double.TryParse(firstWord, out double val1))
                    {
                        if (double.IsNaN(val1) || double.IsInfinity(val1))
                        {
                            result = val1;
                            return true;
                        }
                    }
                }
            }

            // Normal number parsing (no E/e, not NaN/Infinity)
            int lastDot = -1;
            int lastComma = -1;
            bool hasSpace = false;
            bool hasNonDigit = false;

            for (int i = start; i < end; i++)
            {
                char c = value[i];
                if (c == '.')
                {
                    lastDot = i;
                }
                else if (c == ',')
                {
                    lastComma = i;
                }
                else if (c == ' ')
                {
                    hasSpace = true;
                }
                else if (c == '-' || c == '+')
                {
                    if (i != start)
                    {
                        hasNonDigit = true;
                    }
                }
                else if (!char.IsDigit(c))
                {
                    hasNonDigit = true;
                }
            }

            // Fast path: no spaces, no commas, at most one dot, and optionally a sign at the start.
            if (!hasSpace && lastComma == -1 && !hasNonDigit)
            {
                string sub = (start == 0 && end == value.Length) ? value : value.Substring(start, end - start);
                return double.TryParse(sub, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out result);
            }

            // Slow/Normalization path
            int separatorIndex = Math.Max(lastDot, lastComma);
            char? decimalSeparator = null;
            if (separatorIndex >= 0)
            {
                decimalSeparator = value[separatorIndex];
            }

            int maxLen = end - start + 1;
            char[] buffer = new char[maxLen];
            int dest = 0;

            for (int i = start; i < end; i++)
            {
                char c = value[i];
                if (c == ' ')
                {
                    continue;
                }

                if (i < separatorIndex)
                {
                    if (decimalSeparator == '.')
                    {
                        if (c == ',') continue;
                    }
                    else if (decimalSeparator == ',')
                    {
                        if (c == '.') continue;
                    }
                    else
                    {
                        if (c == '.' || c == ',') continue;
                    }
                }
                else if (i == separatorIndex)
                {
                    c = '.';
                }

                buffer[dest++] = c;
            }

            // Ensure only digits + '.' and leading '+' or '-' remain
            for (int i = 0; i < dest; i++)
            {
                char c = buffer[i];
                if (i == 0 && (c == '-' || c == '+'))
                {
                    continue;
                }
                if (!(char.IsDigit(c) || c == '.'))
                {
                    return false;
                }
            }

            string normalized = new(buffer, 0, dest);
            return double.TryParse(normalized, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out result);

            //string value_2_String = value_1_String;
            //string value_3_String = value_2_String;

            //value_1_String = value_1_String.Replace(",", ".");

            //value_2_String = value_2_String.Replace(".", ",");

            //if (!double.TryParse(value_2_String, out double value_2))
            //{
            //    value_2 = double.NaN;
            //}

            //if (!double.TryParse(value_3_String, out double value_3))
            //{
            //    value_3 = double.NaN;
            //}

            //double truncate_1 = double.MinValue;
            //if (!double.IsNaN(value_1))
            //{
            //    truncate_1 = Math.Abs(value_1 % 1);
            //}

            //double truncate_2 = double.MinValue;
            //if (!double.IsNaN(value_2))
            //{
            //    truncate_2 = Math.Abs(value_2 % 1);
            //}

            //double truncate_3 = double.MinValue;
            //if (!double.IsNaN(value_3))
            //{
            //    truncate_3 = Math.Abs(value_3 % 1);
            //}

            //if (truncate_1 == truncate_2 && truncate_1 == truncate_3 && truncate_1 == double.MinValue)
            //{
            //    return false;
            //}

            //if (truncate_1 == truncate_2 && truncate_2 == truncate_3)
            //{
            //    result = Math.Min(value_1, value_2);
            //    result = Math.Min(result, value_3);
            //    return true;
            //}

            //if (truncate_1 >= truncate_2 && truncate_1 >= truncate_3)
            //{
            //    result = value_1;
            //    return true;
            //}

            //if (truncate_2 >= truncate_1 && truncate_2 >= truncate_3)
            //{
            //    result = value_2;
            //    return true;
            //}

            //if (truncate_3 >= truncate_1 && truncate_3 >= truncate_1)
            //{
            //    result = value_2;
            //    return true;
            //}

            //return false;
        }
    }
}