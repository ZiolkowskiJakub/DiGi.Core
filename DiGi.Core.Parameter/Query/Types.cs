using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the types associated with the specified enumeration.
        /// </summary>
        /// <param name="enum">The enumeration to retrieve types for.</param>
        /// <returns>An array of <see cref="Type"/> objects associated with the specified enumeration, or <c>null</c>.</returns>
        public static Type[]? Types(Enum? @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            AssociatedTypes? types_Temp = Attribute.GetCustomAttribute(@enum.GetType(), typeof(AssociatedTypes)) as AssociatedTypes;
            return types_Temp?.Types;
        }
    }
}