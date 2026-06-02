using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified type is nullable.
        /// </summary>
        /// <param name="type">The type to check.</param>
        /// <returns>True if the type is nullable; otherwise, false.</returns>
        public static bool IsNullable(this Type type)
        {
            if (type == null)
            {
                return false;
            }

            if (!type.IsValueType)
            {
                return true;
            }

            return Nullable.GetUnderlyingType(type) != null;
        }
    }
}