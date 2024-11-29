using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static T Next<T>(this IEnumerable<T> values, int index)
        {
            if (values == null)
            {
                return default(T);
            }

            int index_Temp = Next(values.Count(), index);
            if (index_Temp == -1)
            {
                return default;
            }

            return values.ElementAt(index_Temp);
        }

        public static int Next(this int count, int index)
        {
            if (index < 0)
            {
                return -1;
            }

            if (count == 0)
            {
                return -1;
            }

            return (index + 1) % count;

            //int result = index + 1;
            //while (result >= count)
            //{
            //    result -= count;
            //}

            //return result;
        }
    }

}
