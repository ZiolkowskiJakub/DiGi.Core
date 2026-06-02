using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether two double values are approximately equal within a specified tolerance.
        /// </summary>
        /// <param name="value_1">The first value to compare.</param>
        /// <param name="value_2">The second value to compare.</param>
        /// <param name="tolerance">The maximum allowed difference between the values.</param>
        /// <returns>True if the values are approximately equal; otherwise, false.</returns>
        public static bool AlmostEquals(this double value_1, double value_2, double tolerance = Constants.Tolerance.Distance)
        {
            bool isNaN_1 = double.IsNaN(value_1);
            bool isNaN_2 = double.IsNaN(value_2);

            if (isNaN_1 && isNaN_2)
            {
                return true;
            }

            if (isNaN_1 || isNaN_2)
            {
                return false;
            }

            return Math.Abs(value_1 - value_2) <= tolerance;
        }
    }
}