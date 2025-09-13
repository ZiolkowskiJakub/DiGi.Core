using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static T? Next<T>(this IEnumerable<T?>? values, int index)
        {
            if (values == null)
            {
                return default;
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

        public static TEnum? Next<TEnum>(TEnum? @enum) where TEnum: Enum
        {
            if(@enum == null)
            {
                return default;
            }

            List<int> indexes = [];
            foreach(TEnum @enum_Temp in System.Enum.GetValues(typeof(TEnum)))
            {
                indexes.Add((int)(object)enum_Temp);
            }

            indexes.Sort();

            int index = indexes.IndexOf((int)(object)@enum);

            int next = Next(indexes, index);

            return (TEnum)(object)next;
        }
    }

}
