using System;

namespace DiGi.Core.Parameters
{
    public static partial class Query
    {
        public static Type[] Types(Enum @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            AssociatedTypes types_Temp = Attribute.GetCustomAttribute(@enum.GetType(), typeof(AssociatedTypes)) as AssociatedTypes;
            return types_Temp?.Types;
        }
    }
}