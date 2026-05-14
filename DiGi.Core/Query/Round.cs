using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Rounds the value to the nearest multiple of the tolerance using decimal precision.
        /// This prevents floating-point artifacts common in double arithmetic.
        /// </summary>
        /// public static double Round(this double value, double tolerance)
        public static double Round(this double value, double tolerance)
        {
            // 1. Quick check for invalid inputs or zero tolerance to avoid DivisionByZero
            if (double.IsNaN(value) || double.IsInfinity(value) || tolerance == 0.0)
            {
                return value;
            }

            if (value <= (double)decimal.MaxValue && value >= (double)decimal.MinValue &&
                tolerance <= (double)decimal.MaxValue && tolerance >= (double)decimal.MinValue)
            {
                // 2. Perform calculations using decimal to maintain high precision.
                // We cast to decimal once per variable to minimize conversion overhead.
                decimal mValue = (decimal)value;
                decimal mTolerance = (decimal)tolerance;

                return (double)(Math.Round(mValue / mTolerance, MidpointRounding.AwayFromZero) * mTolerance);
            }

            // Fallback dla ogromnych wartości - tutaj używamy double, 
            // bo decimal i tak by nie pomieścił tych liczb.
            return Math.Round(value / tolerance, MidpointRounding.AwayFromZero) * tolerance;
        }
    }
}