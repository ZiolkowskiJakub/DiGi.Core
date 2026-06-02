using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Modify
    {
        /// <summary>
        /// Sorts the elements of a list using a specified function to extract a comparable key.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="list">The list to sort.</param>
        /// <param name="func">A function to extract the comparable key from an element.</param>
        public static void Sort<T>(this List<T>? list, Func<T, IComparable>? func)
        {
            if (list == null || func == null)
            {
                return;
            }

            List<Tuple<T, IComparable>> tuples = [];
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