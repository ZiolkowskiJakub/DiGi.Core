using System.Globalization;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Counts the number of decimal places in a double value.
        /// </summary>
        /// <param name="value">The value to evaluate.</param>
        /// <returns>The number of decimal places.</returns>
        public static int DecimalPlacesCount(this double value)
        {
            string @string = value.ToString("G17", CultureInfo.InvariantCulture);
            int index = @string.IndexOf('.');
            if (index < 0)
            {
                return 0;
            }

            return @string.Length - index - 1;
        }
    }
}