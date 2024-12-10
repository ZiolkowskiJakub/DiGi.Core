using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static T Clone<T>(this T serializableObject) where T: ISerializableObject
        {
            if(serializableObject == null)
            {
                return default;
            }

            MethodInfo methodInfo = typeof(ISerializableObject).GetMethod(Constans.Serialization.MethodName.Clone, new Type[] { });
            if(methodInfo == null)
            {
                return default(T);
            }

            object @object = methodInfo.Invoke(serializableObject, new object[] { });
            if(@object == null)
            {
                return default;
            }

            if(@object is T)
            {
                return (T)@object;
            }

            if(!@object.GetType().IsAssignableFrom(typeof(T)))
            {
                return default;
            }

            SerializationConstructor serializationConstructor = Settings.SerializationManager.GetSerializationConstructor(FullTypeName(serializableObject));
            if(serializationConstructor == null)
            {
                return default;
            }

            JsonObject jsonObject = serializableObject.ToJsonObject();
            if (jsonObject == null)
            {
                return default;
            }

            return Create.SerializableObject<T>(jsonObject);
        }

        public static List<T> Clone<T>(this IEnumerable<T> serializableObjects) where T : ISerializableObject
        {
            if(serializableObjects == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            foreach(T serializableObject in serializableObjects)
            {
                result.Add(serializableObject == null ? default(T) : Clone(serializableObject));
            }

            return result;
        }

        public static T[] Clone<T>(this T[] values)
        {
            if(values == null)
            {
                return null;
            }

            if(values.Length == 0)
            {
                return new T[0];
            }

            T[] result = new T[values.Length];
            for(int i =0; i < values.Length; i++)
            {
                result[i] = values[i];
            }

            return result;
        }
    }

}
