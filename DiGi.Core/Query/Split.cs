using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<List<X>> Split<X>(this IEnumerable<X> values, int maxCount)
        {
            if (values == null || maxCount < 1)
            {
                return null;
            }

            if (values.Count() <= maxCount)
            {
                return new List<List<X>> { new List<X>(values) };
            }

            List<List<X>> result = new List<List<X>>();

            List<X> values_Temp = new List<X>();

            foreach (X value in values)
            {
                values_Temp.Add(value);

                if (values_Temp.Count == maxCount)
                {
                    result.Add(values_Temp);
                    values_Temp = new List<X>();
                }
            }

            if (values_Temp.Count != 0)
            {
                result.Add(values_Temp);
            }

            return result;
        }
    }

}

