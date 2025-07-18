using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryParseDouble(this string value, out double result)
        {
            result = double.NaN;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            //Required due to issue parsing values such as "4.9999999999999996E-06"
            int index = value.ToUpper().IndexOf("E");
            if (index != -1)
            {
                string value_Prefix = value.Substring(0, index);
                string value_Sufix = "1" + value.Substring(index);

                if(!double.TryParse(value_Sufix, out double factor))
                {
                    return false;
                }

                if(value_Prefix.Length == 0)
                {
                    result = factor;
                    return true;
                }
                else if (TryParseDouble(value_Prefix, out result))
                {
                    result = result * factor;
                    return true;
                }

                return false;
            }

            string value_1_String = value.Trim().Split(' ')[0];
            if (!double.TryParse(value_1_String, out double value_1))
            {
                if(value_1_String == Constans.Serialization.LiteralName.PositiveInfinity)
                {
                    result = double.PositiveInfinity;
                    return true;
                }

                if (value_1_String == Constans.Serialization.LiteralName.NegativeInfinity)
                {
                    result = double.NegativeInfinity;
                    return true;
                }

                value_1 = double.NaN;
            }
            else
            {
                if(double.IsNaN(value_1))
                {
                    result = value_1;
                    return true;
                }

                if (double.IsInfinity(value_1))
                {
                    result = value_1;
                    return true;
                }
            }

            string value_2_String = value_1_String;
            string value_3_String = value_2_String;

            value_1_String = value_1_String.Replace(",", ".");

            value_2_String = value_2_String.Replace(".", ",");

            if (!double.TryParse(value_2_String, out double value_2))
            {
                value_2 = double.NaN;
            }

            if (!double.TryParse(value_3_String, out double value_3))
            {
                value_3 = double.NaN;
            }

            double truncate_1 = double.MinValue;
            if (!double.IsNaN(value_1))
            {
                truncate_1 = Math.Abs(value_1 % 1);
            }

            double truncate_2 = double.MinValue;
            if (!double.IsNaN(value_2))
            {
                truncate_2 = Math.Abs(value_2 % 1);
            }

            double truncate_3 = double.MinValue;
            if (!double.IsNaN(value_3))
            {
                truncate_3 = Math.Abs(value_3 % 1);
            }

            if (truncate_1 == truncate_2 && truncate_1 == truncate_3 && truncate_1 == double.MinValue)
            {
                return false;
            }

            if (truncate_1 == truncate_2 && truncate_2 == truncate_3)
            {
                result = Math.Min(value_1, value_2);
                result = Math.Min(result, value_3);
                return true;
            }

            if (truncate_1 >= truncate_2 && truncate_1 >= truncate_3)
            {
                result = value_1;
                return true;
            }

            if (truncate_2 >= truncate_1 && truncate_2 >= truncate_3)
            {
                result = value_2;
                return true;
            }

            if (truncate_3 >= truncate_1 && truncate_3 >= truncate_1)
            {
                result = value_2;
                return true;
            }

            return false;
        }
    }

}
