using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static UniqueReference UniqueReference<T>(this T @object, Func<T, Guid> func)
        {
            if(@object == null || func == null)
            {
                return null;
            }

            string fullTypeName = Query.FullTypeName(@object.GetType());
            if(string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return new UniqueReference(fullTypeName, func.Invoke(@object));
        }

        public static UniqueReference UniqueReference<T>(this UniqueObjectValueCluster<T> uniqueObjectValueCluster, Type type) where T : IUniqueObject
        {
            if (uniqueObjectValueCluster == null || type == null)
            {
                return null;
            }

            string fullTypeName = Query.FullTypeName(type);
            if(string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            UniqueReference result = null;
            do
            {
                Guid guid = System.Guid.NewGuid();
                result = new UniqueReference(fullTypeName, guid);
            }
            while (result != null && uniqueObjectValueCluster.Contains(result));

            return result;
        }
    }
}
