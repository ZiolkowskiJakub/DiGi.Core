using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static System.Guid Guid<T>(this UniqueObjectValueCluster<T> uniqueObjectValueCluster,  System.Type type) where T: IUniqueObject
        {
            if(uniqueObjectValueCluster == null || type == null)
            {
                return System.Guid.Empty;
            }

            UniqueReference uniqueReference = uniqueObjectValueCluster.UniqueReference(type);
            if(uniqueReference == null)
            {
                return System.Guid.Empty;
            }

            return uniqueReference.Guid;
        }
    }
}