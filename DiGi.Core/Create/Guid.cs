using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static System.Guid Guid<T>(this UniqueObjectCluster<T> uniqueObjectCluster,  System.Type type) where T: IUniqueObject
        {
            if(uniqueObjectCluster == null || type == null)
            {
                return System.Guid.Empty;
            }

            UniqueReference uniqueReference = uniqueObjectCluster.UniqueReference(type);
            if(uniqueReference == null)
            {
                return System.Guid.Empty;
            }

            return uniqueReference.Guid;
        }
    }
}