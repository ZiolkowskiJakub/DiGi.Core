using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static T Previous<T>(this IEnumerable<T> values, int index)
        {
            if (values == null)
            {
                return default(T);
            }

            int index_Temp = Previous(values.Count(), index);
            if (index_Temp == -1)
            {
                return default;
            }

            return values.ElementAt(index_Temp);
        }

        public static int Previous(this int count, int index)
        {
            if (index < 0)
            {
                return -1;
            }

            if (count == 0)
            {
                return -1;
            }

            int result = index;
            while (result >= count)
            {
                result -= count;
            }

            result = result == 0 ? count - 1 : result - 1;

            return result;
        }
    }

}
