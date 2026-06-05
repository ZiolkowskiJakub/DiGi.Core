using DiGi.Core.Parameter.Classes;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the associated types for the specified type.
        /// </summary>
        /// <param name="type">The type for which to retrieve associated types.</param>
        /// <returns>The associated types for the specified type, or null if none are found.</returns>
        public static AssociatedTypes? AssociatedTypes(Type? type)
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
                if (@object is AssociatedTypes parameterTypes)
                {
                    return parameterTypes;
                }
            }

            return null;
        }
    }
}