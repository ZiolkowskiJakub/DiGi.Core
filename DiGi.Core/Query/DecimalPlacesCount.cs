using DiGi.Core.Classes;
using System.Globalization;

namespace DiGi.Core
{
    public static partial class Query
    {
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