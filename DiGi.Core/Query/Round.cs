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

            return (double)(Math.Round((decimal)value / (decimal)tolerance) * (decimal)tolerance);
        }
    }

}
