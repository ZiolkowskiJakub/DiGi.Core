using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Clones a sequence of serializable objects and filters out any null results.
        /// </summary>
        /// <typeparam name="T">The type of the serializable objects.</typeparam>
        /// <param name="serializableObjects">The sequence of objects to clone.</param>
        /// <returns>A list of non-null cloned objects, or null if the input is null.</returns>
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