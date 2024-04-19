using DiGi.Core.Classes;
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
    }
}
