using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Modify
    {
        public static void Sort<T>(this List<T> list, Func<T, IComparable> func)
        {
            if (list == null || func == null)
            {
                return;
            }

            List<Tuple<T, IComparable>> tuples = new List<Tuple<T, IComparable>>();
            for (int i = 0; i < list.Count; i++)
            {
                tuples.Add(new Tuple<T, IComparable>(list[i], func.Invoke(list[i])));
            }

            tuples.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            list.Clear();
            for (int i = 0; i < tuples.Count; i++)
            {
                list.Add(tuples[i].Item1);
            }
        }
    }
}
