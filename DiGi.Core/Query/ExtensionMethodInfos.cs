using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<MethodInfo> ExtensionMethodInfos(Type type = null)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

            List<MethodInfo> result = new List<MethodInfo>();

            foreach (Assembly assembly in assemblies)
            {
                if (assembly.IsDynamic)
                {
                    continue;
                }

                Type[] types_Assembly = null;
                try
                {
                    types_Assembly = assembly.GetTypes();
                }
                catch (Exception exception)
                {
                    continue;
                }

                if (types_Assembly == null)
                {
                    continue;
                }

                foreach (Type type_Assembly in types_Assembly)
                {
                    if (type_Assembly == null || !type_Assembly.IsClass || !type_Assembly.IsSealed || !type_Assembly.IsAbstract)
                    {
                        continue;
                    }

                    MethodInfo[] methodInfos = type_Assembly.GetMethods(BindingFlags.Static | BindingFlags.Public);
                    if (methodInfos == null)
                    {
                        continue;
                    }

                    foreach (MethodInfo methodInfo in methodInfos)
                    {
                        if (!methodInfo.IsDefined(typeof(System.Runtime.CompilerServices.ExtensionAttribute), false))
                        {
                            continue;
                        }

                        if (type != null && methodInfo.GetParameters().FirstOrDefault()?.ParameterType != type)
                        {
                            continue;
                        }

                        result.Add(methodInfo);
                    }
                }
            }

            return result;
        }
    }
}
