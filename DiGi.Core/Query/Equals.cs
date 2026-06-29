using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Compares two byte arrays for equality.
        /// </summary>
        /// <param name="bytes_1">The first byte array.</param>
        /// <param name="bytes_2">The second byte array.</param>
        /// <returns>True if the arrays are equal; otherwise, false.</returns>
        public static bool Equals(this byte[]? bytes_1, byte[]? bytes_2)
        {
            if (bytes_1 == null && bytes_2 == null)
            {
                return true;
            }

            if (bytes_1 == null || bytes_2 == null)
            {
                return false;
            }

            if (bytes_1.Length != bytes_2.Length)
            {
                return false;
            }

            for (int i = 0; i < bytes_1.Length; i++)
            {
                if (!bytes_1[i].Equals(bytes_2[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Compares two non-generic IEnumerable collections for equality.
        /// </summary>
        /// <param name="enumerable_1">The first collection.</param>
        /// <param name="enumerable_2">The second collection.</param>
        /// <returns>True if the collections contain the same elements in the same order; otherwise, false.</returns>
        public static bool Equals(this IEnumerable? enumerable_1, IEnumerable? enumerable_2)
        {
            if (enumerable_1 == null && enumerable_2 == null)
            {
                return true;
            }

            if (enumerable_1 == null || enumerable_2 == null)
            {
                return false;
            }

            IEnumerator enumerator_1 = enumerable_1.GetEnumerator();
            IEnumerator enumerator_2 = enumerable_2.GetEnumerator();

            while (true)
            {
                bool moved_1 = enumerator_1.MoveNext();
                bool moved_2 = enumerator_2.MoveNext();

                if (moved_1 != moved_2)
                {
                    return false;
                }

                if (!moved_1)
                {
                    return true;
                }

                object? object_1 = enumerator_1.Current;
                object? object_2 = enumerator_2.Current;

                if (object_1 == null && object_2 == null)
                {
                    continue;
                }

                if (object_1 == null || object_2 == null)
                {
                    return false;
                }

                if (object_1 is IEnumerable enumerable_1_Temp && object_2 is IEnumerable enumerable_2_Temp)
                {
                    if (!Equals(enumerable_1_Temp, enumerable_2_Temp))
                    {
                        return false;
                    }
                    continue;
                }

                if (!object_1.Equals(object_2))
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Compares two generic IEnumerable collections for equality.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the collections.</typeparam>
        /// <param name="enumerable_1">The first collection.</param>
        /// <param name="enumerable_2">The second collection.</param>
        /// <returns>True if the collections contain the same elements in the same order; otherwise, false.</returns>
        public static bool Equals<T>(this IEnumerable<T>? enumerable_1, IEnumerable<T>? enumerable_2)
        {
            if (enumerable_1 == null && enumerable_2 == null)
            {
                return true;
            }

            if (enumerable_1 == null || enumerable_2 == null)
            {
                return false;
            }

            using IEnumerator<T> enumerator_1 = enumerable_1.GetEnumerator();
            using IEnumerator<T> enumerator_2 = enumerable_2.GetEnumerator();

            while (true)
            {
                bool moved_1 = enumerator_1.MoveNext();
                bool moved_2 = enumerator_2.MoveNext();

                if (moved_1 != moved_2)
                {
                    return false;
                }

                if (!moved_1)
                {
                    return true;
                }

                T object_1 = enumerator_1.Current;
                T object_2 = enumerator_2.Current;

                if (object_1 == null && object_2 == null)
                {
                    continue;
                }

                if (object_1 == null || object_2 == null)
                {
                    return false;
                }

                if (object_1 is IEnumerable enumerable_1_Temp && object_2 is IEnumerable enumerable_2_Temp)
                {
                    if (!Equals(enumerable_1_Temp, enumerable_2_Temp))
                    {
                        return false;
                    }
                    continue;
                }

                if (!object_1.Equals(object_2))
                {
                    return false;
                }
            }
        }
    }
}