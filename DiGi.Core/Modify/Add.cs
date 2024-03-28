using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Modify
    {
        /// <summary>
        /// Adds item to the list if condition in func is not meet by any of item on the list
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="list">List</param>
        /// <param name="item">Item to be added</param>
        /// <param name="func">Condition</param>
        /// <returns>True if item has been added</returns>
        public static bool Add<T>(this List<T> list, T item, Func<T, bool> func)
        {
            if(list == null)
            {
                return false;
            }

            if(func == null || list.Count == 0)
            {
                list.Add(item);
                return true;
            }

            for(int i =0; i < list.Count; i++)
            {
                if (func.Invoke(list[i]))
                {
                    return false;
                }
            }

            list.Add(item);
            return true;
        }
    }
}
