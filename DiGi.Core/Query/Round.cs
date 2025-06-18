using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static double Round(this double value, double tolerance)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                return value;
            }

            if (tolerance.Equals(0.0))
            {
                return value;
            }

            double value_Temp = Math.Abs(value / tolerance);
            if(value_Temp < (double)decimal.MaxValue)
            {
                return System.Convert.ToDouble(Math.Round(System.Convert.ToDecimal(value) / System.Convert.ToDecimal(tolerance)) * System.Convert.ToDecimal(tolerance));
            }

            return Math.Round(value_Temp) * tolerance;
        }
    }

}