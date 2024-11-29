using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static List<T> ToSystem<T>(this Range<T> range, T step)
        {
            if(range == null)
            {
                return null;
            }

            if ((dynamic)step.Equals(0))
            {
                return null;
            }

            List<T> result = new List<T>();

            if((dynamic)step > 0)
            {
                T value = range.Min;
                T max = range.Max;
                while ((dynamic)value <= (dynamic)max)
                {
                    result.Add(value);
                    value += (dynamic)step;
                }
            }
            else
            {
                T value = range.Max;
                T min = range.Min;
                while ((dynamic)value >= (dynamic)min)
                {
                    result.Add(value);
                    value -= (dynamic)step;
                }
            }

            return result;
        }
    }
}
