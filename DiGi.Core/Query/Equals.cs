using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool Equals(this byte[] bytes_1, byte[] bytes_2)
        {
            if(bytes_1 == null && bytes_2 == null)
            {
                return true;
            }

            if(bytes_1 == null || bytes_2 == null)
            {
                return false;
            }

            if(bytes_1.Length != bytes_2.Length)
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

        public static bool Equals(this IEnumerable enumerable_1, IEnumerable enumerable_2)
        {
            if(enumerable_1 == null && enumerable_2 == null)
            {
                return true;
            }

            if (enumerable_1 == null || enumerable_2 == null)
            {
                return false;
            }

            List<object> objects = new List<object>();
            foreach (object @object in enumerable_1)
            {
                objects.Add(@object);
            }
            int index = 0;
            foreach (object object_2 in enumerable_2)
            {
                object object_1 = objects[index];

                if (object_1 == null && object_2 == null)
                {
                    return false;
                }

                if (object_1 == null || object_2 == null)
                {
                    return false;
                }

                if(object_1 is IEnumerable && object_2 is IEnumerable)
                {
                    if(!Equals((IEnumerable)object_1, (IEnumerable)object_2))
                    {
                        return false;
                    }

                    continue;
                }

                if (object_1.Equals(object_2))
                {
                    return false;
                }

                index++;
            }

            if(index != objects.Count)
            {
                return false;
            }

            return true;
        }

        public static bool Equals<T>(this IEnumerable<T> enumerable_1, IEnumerable<T> enumerable_2)
        {
            if(enumerable_1 == null && enumerable_2 == null)
            {
                return true;
            }

            if (enumerable_1 == null || enumerable_2 == null)
            {
                return false;
            }

            int count_1 = enumerable_1.Count();
            int count_2 = enumerable_2.Count();

            if (count_1 != count_2)
            {
                return false;
            }

            for(int i = 0; i < count_1; i++)
            {
                T object_1 = enumerable_1.ElementAt(i);
                T object_2 = enumerable_2.ElementAt(i);

                if(object_1 == null && object_2 == null)
                {
                    continue;
                }

                if(object_1 == null || object_2 == null)
                {
                    return false;
                }

                if(object_1 is IEnumerable && object_2 is IEnumerable)
                {
                    if (!Equals((IEnumerable)object_1, (IEnumerable)object_2))
                    {
                        return false;
                    }
                    continue;
                }

                if(!object_1.Equals(object_2))
                {
                    return false;
                }
            }

            return true;
        }
    }

}
