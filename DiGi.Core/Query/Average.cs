using System.Collections.Generic;
using System.Numerics;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Calculates the average of a sequence of complex numbers.
        /// </summary>
        /// <param name="values">The sequence of complex numbers to average.</param>
        /// <returns>The average complex number, or <see langword="null"/> if the sequence is null or empty.</returns>
        public static Complex? Average(this IEnumerable<Complex>? values)
        {
            if (values == null)
            {
                return null;
            }

            Complex sum = Complex.Zero;
            int count = 0;

            foreach (Complex value in values)
            {
                sum += value;
                count++;
            }

            if (count == 0)
            {
                return null;
            }

            return sum / count;
        }
    }
}