using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates an instance of the specified type using the provided arguments.</summary>
        /// <typeparam name="T">The type of the object to create.</typeparam>
        /// <param name="objects">The arguments to be passed to the constructor of the created object.</param>
        /// <returns>An instance of type <typeparamref name="T"/>, or null if the operation fails.</returns>
        public static T? Object<T>(params object[] objects)
        {
            Type type = typeof(T);

            ConstructorInfo[] constructorInfos = type.GetConstructors();
            if (constructorInfos == null || constructorInfos.Length == 0)
            {
                return default;
            }

            int count = objects == null ? 0 : objects.Length;

            object? result = null;

            ConstructorInfo constructorInfo = type.GetConstructor([.. objects.ToList().ConvertAll(x => x?.GetType())]);
            if (constructorInfo != null)
            {
                result = constructorInfo.Invoke(objects);
                if (result is T t)
                {
                    return t;
                }
            }

            foreach (ConstructorInfo constructorInfo_Temp in constructorInfos)
            {
                ParameterInfo[] parameterInfos = constructorInfo_Temp.GetParameters();
                if ((parameterInfos == null || parameterInfos.Length == 0) && count == 0)
                {
                    result = constructorInfo_Temp.Invoke([]);
                    if (result is T t_Temp)
                    {
                        return t_Temp;
                    }
                }

                if (parameterInfos!.Length != count)
                {
                    continue;
                }

                List<object> objects_Temp = objects == null ? [] : [.. objects];
                List<object> parameteres = [];
                foreach (ParameterInfo parameterInfo in parameterInfos)
                {
                    object parameter = objects_Temp.Find(x => parameterInfo.ParameterType.IsAssignableFrom(x.GetType()));
                    if (parameter == null)
                    {
                        break;
                    }

                    objects_Temp.Remove(parameter);
                    parameteres.Add(parameter);
                }

                if (parameterInfos.Length != parameteres.Count)
                {
                    continue;
                }

                result = constructorInfo_Temp.Invoke([.. parameteres]);
                if (result is T t)
                {
                    return t;
                }
            }

            return default;
        }
    }
}