using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<T>? CloneAndFilterNulls<T>(this IEnumerable<T?>? serializableObjects) where T : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            List<T> result = [];
            foreach (T? serializableObject in serializableObjects)
            {
                if (Clone(serializableObject) is T t)
                {
                    result.Add(t);
                }
            }

            return result;
        }
    }
}