using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the default value for a given Type.
        /// </summary>
        /// <param name="type">The type to get the default value for.</param>
        /// <returns>The default value, or null for reference types.</returns>
        public static object? Default(this Type? type)
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