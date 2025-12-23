using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core
{
    public static partial class Create
    {
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
