using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a GUID reference for the specified object using the given function to retrieve its GUID.</summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="object">The object for which to create a GUID reference.</param>
        /// <param name="func">The function used to retrieve the GUID from the object.</param>
        /// <returns>A <see cref="GuidReference"/> if successful; otherwise, <c>null</c>.</returns>
        public static GuidReference? GuidReference<T>(this T? @object, Func<T?, Guid> func)
        {
            if (@object == null || func == null)
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(@object.GetType());
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return new GuidReference(fullTypeName, func.Invoke(@object));
        }

        /// <summary>Creates a unique GUID reference for the specified type that does not exist in the given cluster.</summary>
        /// <typeparam name="TUniqueObject">The type of the unique object.</typeparam>
        /// <param name="uniqueObjectValueCluster">The cluster to check for existing references.</param>
        /// <param name="type">The type for which to create a GUID reference.</param>
        /// <returns>A <see cref="GuidReference"/> if successful; otherwise, <c>null</c>.</returns>
        public static GuidReference? GuidReference<TUniqueObject>(this UniqueObjectValueCluster<TUniqueObject>? uniqueObjectValueCluster, Type? type) where TUniqueObject : IUniqueObject
        {
            if (uniqueObjectValueCluster == null || type == null)
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            GuidReference? result;
            do
            {
                Guid guid = System.Guid.NewGuid();
                result = new GuidReference(fullTypeName, guid);
            }
            while (result is not null && uniqueObjectValueCluster.Contains(result));

            return result;
        }
    }
}