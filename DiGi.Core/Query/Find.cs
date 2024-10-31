using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static T Find<T>(this IEnumerable<T> values, Func<T, bool> func)
        {
            if(func == null || values == null)
            {
                return default;
            }

            foreach(T t in values)
            {
                if(func.Invoke(t))
                {
                    return t;
                }
            }

            return default;

        }
    }
}