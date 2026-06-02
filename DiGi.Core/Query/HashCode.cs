namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Computes a hash code from an array of integers.
        /// </summary>
        /// <param name="values">The values to hash.</param>
        /// <returns>The computed hash code.</returns>
        public static int HashCode(params int[]? values)
        {
            if (values == null)
            {
                return 0;
            }

            int result = 17;
            foreach (int value in values)
            {
                result = result * 31 + value;
            }

            return result;
        }
    }
}