using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static object Default(this Type type)
        {
            if (type != null && type.IsValueType && Nullable.GetUnderlyingType(type) == null)
            {
                return Activator.CreateInstance(type);
            }

            // Reference types or nullable types return null
            return null;
        }
    }
}