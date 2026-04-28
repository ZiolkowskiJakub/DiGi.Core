using System;

namespace DiGi.Core
{
    public static partial class Query
    {
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