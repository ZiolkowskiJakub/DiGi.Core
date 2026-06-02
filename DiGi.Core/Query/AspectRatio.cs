using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the aspect ratio of two values.
        /// </summary>
        /// <param name="value_1">The first value.</param>
        /// <param name="value_2">The second value.</param>
        /// <param name="normalized">If true, returns the ratio of the smaller value to the larger value.</param>
        /// <returns>The calculated aspect ratio, or NaN if inputs are invalid.</returns>
        public static double AspectRatio(this double value_1, double value_2, bool normalized = false)
        {
            if (double.IsNaN(value_1) || double.IsNaN(value_2))
            {
                return double.NaN;
            }

            if (!normalized)
            {
                if (value_2 == 0)
                {
                    return double.NaN;
                }

                return value_1 / value_2;
            }

            double max = Math.Max(value_1, value_2);
            if (max == 0)
            {
                return double.NaN;
            }

            double min = Math.Min(value_1, value_2);
            return min / max;
        }
    }
}