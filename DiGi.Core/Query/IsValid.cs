using System.Numerics;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Checks that a complex number carries finite real and imaginary components.
        /// </summary>
        /// <param name="complex">The complex number to check.</param>
        /// <returns><see langword="true"/> when both components are finite; otherwise, <see langword="false"/>.</returns>
        public static bool IsValid(this Complex complex)
        {
            double real = complex.Real;
            double imaginary = complex.Imaginary;

            return !double.IsNaN(real) && !double.IsInfinity(real) && !double.IsNaN(imaginary) && !double.IsInfinity(imaginary);
        }
    }
}
