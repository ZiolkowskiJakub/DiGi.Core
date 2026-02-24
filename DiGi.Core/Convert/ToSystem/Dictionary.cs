using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static Dictionary<T, List<X>>? ToSystem_Dictionary<T, X>(this IEnumerable<X> values, Func<X, T?> keyFunc)
        {
            if (values is null || keyFunc is null)
            {
                return null;
            }

            Dictionary<T, List<X>> result = [];
            foreach (X x in values)
            {
                T? t = keyFunc(x);
                if (t is null)
                {
                    continue;
                }

                if (!result.TryGetValue(t, out List<X> xs) || xs is null)
                {
                    xs = [];
                    result[t] = xs;
                }
                xs.Add(x);
            }

            return result;
        }
    }
}