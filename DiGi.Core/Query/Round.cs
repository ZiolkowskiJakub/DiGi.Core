using DiGi.Core.Enums;
using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Rounds the value to the nearest multiple of the tolerance using decimal precision.
        /// This prevents floating-point artifacts common in double arithmetic.
        /// </summary>
        /// <param name="value">The value to be rounded.</param>
        /// <param name="tolerance">The tolerance used for rounding.</param>
        /// <returns>The rounded value.</returns>
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
                try
                {
                    // 2. Perform calculations using decimal to maintain high precision.
                    // We cast to decimal once per variable to minimize conversion overhead.
                    decimal mValue = (decimal)value;
                    decimal mTolerance = (decimal)tolerance;

                    return (double)(Math.Round(mValue / mTolerance, MidpointRounding.AwayFromZero) * mTolerance);
                }
                catch (OverflowException)
                {
                    // Fall back to double path if decimal division overflows
                }
            }

            // Fallback dla ogromnych wartości - tutaj używamy double,
            // bo decimal i tak by nie pomieścił tych liczb.
            return Math.Round(value / tolerance, MidpointRounding.AwayFromZero) * tolerance;
        }

        /// <summary>
        /// Rounds the value to a multiple of the tolerance using the specified rounding method.
        /// </summary>
        /// <param name="value">The value to be rounded.</param>
        /// <param name="tolerance">The tolerance used for rounding.</param>
        /// <param name="roundingMethod">The rounding method to apply.</param>
        /// <returns>The rounded value, or the original value if roundingMethod is Undefined or inputs are invalid.</returns>
        public static double Round(this double value, double tolerance, RoundingMethod roundingMethod)
        {
            if (roundingMethod == RoundingMethod.Undefined)
            {
                return value;
            }

            if (roundingMethod == RoundingMethod.Nearest)
            {
                return value.Round(tolerance);
            }

            if (double.IsNaN(value) || double.IsInfinity(value) || tolerance == 0.0)
            {
                return value;
            }

            if (value <= (double)decimal.MaxValue && value >= (double)decimal.MinValue &&
                tolerance <= (double)decimal.MaxValue && tolerance >= (double)decimal.MinValue)
            {
                try
                {
                    decimal decimalValue = (decimal)value;
                    decimal decimalTolerance = (decimal)tolerance;

                    switch (roundingMethod)
                    {
                        case RoundingMethod.Ceiling:
                            return (double)(Math.Ceiling(decimalValue / decimalTolerance) * decimalTolerance);
                        case RoundingMethod.Floor:
                            return (double)(Math.Floor(decimalValue / decimalTolerance) * decimalTolerance);
                        case RoundingMethod.Truncate:
                            return (double)(Math.Truncate(decimalValue / decimalTolerance) * decimalTolerance);
                        default:
                            return value;
                    }
                }
                catch (OverflowException)
                {
                    // Fall back to double path if decimal division overflows
                }
            }

            switch (roundingMethod)
            {
                case RoundingMethod.Ceiling:
                    return Math.Ceiling(value / tolerance) * tolerance;
                case RoundingMethod.Floor:
                    return Math.Floor(value / tolerance) * tolerance;
                case RoundingMethod.Truncate:
                    return Math.Truncate(value / tolerance) * tolerance;
                default:
                    return value;
            }
        }
    }
}