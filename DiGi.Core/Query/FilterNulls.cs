using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<T>? FilterNulls<T>(this IEnumerable<T?>? values)
        {
            if (values is null)
            {
                return null;
            }

            List<T> result = [];
            foreach (T? value in values)
            {
                if (value is null)
                {
                    continue;
                }

                result.Add(value);
            }

            return result;
        }
    }
}