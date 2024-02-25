using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static T Clone<T>(this T serializableObject) where T: ISerializableObject
        {
            if(serializableObject == null)
            {
                return default(T);
            }

            MethodInfo methodInfo = typeof(ISerializableObject).GetMethod(Constans.Serialization.MethodName.Clone, new Type[] { });
            if(methodInfo == null)
            {
                return default(T);
            }

            object @object = methodInfo.Invoke(serializableObject, new object[] { });
            if(@object is T)
            {
                return (T)@object;
            }

            return default(T);
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
    }

}
