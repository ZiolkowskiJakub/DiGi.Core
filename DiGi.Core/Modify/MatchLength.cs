using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Modify
    {
        /// <summary>
        /// Matches the length of two lists by duplicating elements cyclically from the shorter list to match the longer list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the first list.</typeparam>
        /// <typeparam name="X">The type of elements in the second list.</typeparam>
        /// <param name="list_1">The first list.</param>
        /// <param name="list_2">The second list.</param>
        /// <returns>True if lengths were successfully matched; otherwise, false.</returns>
        public static bool MatchLength<T, X>(List<T>? list_1, List<X>? list_2)
        {
            if (list_1 == null || list_2 == null)
            {
                return false;
            }

            if ((object)list_1 == (object)list_2)
            {
                return true;
            }

            if (list_1 == null || list_2 == null)
            {
                return false;
            }

            int count_1 = list_1.Count;
            int count_2 = list_2.Count;

            if (count_1 == count_2)
            {
                return true;
            }

            if (count_1 == 0 || count_2 == 0)
            {
                return false;
            }

            int max;
            int min;
            if (count_1 > count_2)
            {
                max = count_1;
                min = count_2;
            }
            else
            {
                max = count_2;
                min = count_1;
            }

            for (int i = min; i < max; i++)
            {
                if (list_1.Count <= i)
                {
                    list_1.Add(list_1[i % count_1]);
                }

                if (list_2.Count <= i)
                {
                    list_2.Add(list_2[i % count_2]);
                }
            }

            return true;
        }
    }
}