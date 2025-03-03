using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool Filter<T>(this IEnumerable<T> values, Func<T, bool> func, out List<T> values_In, out List<T> values_Out)
        {
            values_In = null;
            values_Out = null;

            if (values == null || func == null)
            {
                return false;
            }

            values_In = new List<T>();
            values_Out = new List<T>();

            foreach(T value in values)
            {
                if(func.Invoke(value))
                {
                    values_In.Add(value);
                }
                else
                {
                    values_Out.Add(value);
                }
            }

            return true;
        }
    }
}