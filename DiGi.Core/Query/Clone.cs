using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a clone of a serializable object.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
        /// <param name="serializableObject">The object to clone.</param>
        /// <returns>A cloned instance of the object, or default if cloning fails.</returns>
        public static TSerializableObject? Clone<TSerializableObject>(this TSerializableObject? serializableObject) where TSerializableObject : ISerializableObject
        {
            if (serializableObject == null)
            {
                return default;
            }

            ISerializableObject? @object = serializableObject.Clone();
            if (@object == null)
            {
                return default;
            }

            if (@object is TSerializableObject serializableObject_Temp)
            {
                return serializableObject_Temp;
            }

            if (!@object.GetType().IsAssignableFrom(typeof(TSerializableObject)))
            {
                return default;
            }

            SerializationConstructor? serializationConstructor = Settings.SerializationManager.GetSerializationConstructor(FullTypeName(serializableObject));
            if (serializationConstructor == null)
            {
                return default;
            }

            JsonObject? jsonObject = serializableObject.ToJsonObject();
            if (jsonObject == null)
            {
                return default;
            }

            return Create.SerializableObject<TSerializableObject>(jsonObject);
        }

        /// <summary>
        /// Clones a sequence of serializable objects into a new list.
        /// </summary>
        /// <typeparam name="T">The type of the serializable objects.</typeparam>
        /// <param name="serializableObjects">The sequence of objects to clone.</param>
        /// <returns>A new list containing the cloned objects, or null if the input is null.</returns>
        public static List<T?>? Clone<T>(this IEnumerable<T?>? serializableObjects) where T : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            List<T?> result = serializableObjects is ICollection<T?> serializableObjects_Collection ? new(serializableObjects_Collection.Count) : [];
            foreach (T? serializableObject in serializableObjects)
            {
                result.Add(serializableObject == null ? default : Clone(serializableObject));
            }

            return result;
        }

        /// <summary>
        /// Clones an array into a new array.
        /// </summary>
        /// <typeparam name="T">The type of the array elements.</typeparam>
        /// <param name="values">The array to clone.</param>
        /// <returns>A new array containing the cloned elements, or null if the input is null.</returns>
        public static T?[]? Clone<T>(this T?[]? values)
        {
            if (values == null)
            {
                return null;
            }

            if (values.Length == 0)
            {
                return [];
            }

            T?[] result = new T[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                result[i] = values[i];
            }

            return result;
        }
    }
}