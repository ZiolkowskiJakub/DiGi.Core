using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a range of values into a system list with a specified step.
        /// </summary>
        /// <typeparam name="T">The type of elements in the range.</typeparam>
        /// <param name="range">The range to convert.</param>
        /// <param name="step">The step value used for conversion.</param>
        /// <returns>A list containing the values from the range, or null if the range is null.</returns>
        public static List<T>? ToSystem<T>(this Range<T>? range, T step)
        {
            if (range is null || step is null)
            {
                return null;
            }

            if ((dynamic)step!.Equals(0))
            {
                return null;
            }

            List<T> result = [];

            if ((dynamic)step > 0)
            {
                T value = range.Min;
                T max = range.Max;
                while ((dynamic)value! <= (dynamic)max!)
                {
                    result.Add(value);
                    value += (dynamic)step;
                }
            }
            else
            {
                T value = range.Max;
                T min = range.Min;
                while ((dynamic)value! >= (dynamic)min!)
                {
                    result.Add(value);
                    value -= (dynamic)step;
                }
            }

            return result;
        }
    }
}