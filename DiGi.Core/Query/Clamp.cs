using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Limits given value to min and max
        /// </summary>
        /// <param name="value">Value to be clamped</param>
        /// <param name="min">Minimal Value</param>
        /// <param name="max">Maximal Value</param>
        /// <returns>Clamp value</returns>
        public static T Clamp<T>(this T value, T min, T max)
        {
            if ((dynamic)value! < (dynamic)min!)
            {
                return min;
            }

            if ((dynamic)value! > (dynamic)max!)
            {
                return max;
            }

            return value;
        }

        /// <summary>
        /// Limits the values of a Range to be within the specified minimum and maximum values.
        /// </summary>
        /// <typeparam name="T">The type of the range elements.</typeparam>
        /// <param name="range">The range to clamp.</param>
        /// <param name="min">The minimal value.</param>
        /// <param name="max">The maximal value.</param>
        /// <returns>A new Range clamped to the specified limits, or null if the input range is null.</returns>
        public static Range<T>? Clamp<T>(this Range<T>? range, T min, T max)
        {
            if (range is null)
            {
                return null;
            }

            return new Range<T>(Clamp(range.Min, min, max), Clamp(range.Max, min, max));
        }
    }
}