using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Rounds the value to the nearest multiple of the tolerance using decimal precision.
        /// This prevents floating-point artifacts common in double arithmetic.
        /// </summary>
        public static double Round(this double value, double tolerance)
        {
            // 1. Quick check for invalid inputs or zero tolerance to avoid DivisionByZero
            if (double.IsNaN(value) || double.IsInfinity(value) || tolerance == 0.0)
            {
                return value;
            }

            try
            {
                // 2. Perform calculations using decimal to maintain high precision.
                // We cast to decimal once per variable to minimize conversion overhead.
                decimal mValue = (decimal)value;
                decimal mTolerance = (decimal)tolerance;

                // 3. Using MidpointRounding.AwayFromZero as it is standard in engineering (0.5 -> 1)
                decimal quotient = mValue / mTolerance;
                decimal roundedQuotient = Math.Round(quotient, MidpointRounding.AwayFromZero);

                decimal result = roundedQuotient * mTolerance;

                return (double)result;
            }
            catch (OverflowException)
            {
                // 4. Fallback for values outside decimal range (e.g., very large coordinates)
                // In such cases, we revert to double-based math.
                double quotient = value / tolerance;
                return Math.Round(quotient, MidpointRounding.AwayFromZero) * tolerance;
            }
        }
    }
}