using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the calculated processor count based on a specified fraction.
        /// </summary>
        /// <param name="fraction">The fraction of total processors to use.</param>
        /// <returns>The calculated number of processors.</returns>
        public static int ProcessorCount(double fraction = 1.0)
        {
            int result = System.Convert.ToInt32(Environment.ProcessorCount * fraction);
            if (result <= 0)
            {
                result = 1;
            }

            return result;
        }
    }
}