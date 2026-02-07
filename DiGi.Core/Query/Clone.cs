using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static TSerializableObject? Clone<TSerializableObject>(this TSerializableObject? serializableObject) where TSerializableObject : ISerializableObject
        {
            if (serializableObject == null)
            {
                return default;
            }

            MethodInfo methodInfo = typeof(ISerializableObject).GetMethod(Constants.Serialization.MethodName.Clone, []);
            if (methodInfo == null)
            {
                return default;
            }

            object @object = methodInfo.Invoke(serializableObject, []);
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

        public static List<T?>? Clone<T>(this IEnumerable<T?>? serializableObjects) where T : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            List<T?> result = [];
            foreach (T? serializableObject in serializableObjects)
            {
                result.Add(serializableObject == null ? default : Clone(serializableObject));
            }

            return result;
        }

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