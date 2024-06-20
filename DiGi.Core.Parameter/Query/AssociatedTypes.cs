using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static AssociatedTypes AssociatedTypes(Type type)
        {
            if (type == null)
            {
                return null;
            }

            if (!type.IsEnum)
            {
                return null;
            }

            object[] objects = type.GetCustomAttributes(typeof(AssociatedTypes), true);
            if (objects == null || objects.Length == 0)
            {
                return null;
            }

            foreach (object @object in objects)
            {
                AssociatedTypes parameterTypes = @object as AssociatedTypes;
                if (parameterTypes != null)
                {
                    return parameterTypes;
                }
            }

            return null;
        }
    }
}