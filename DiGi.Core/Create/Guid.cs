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

            GuidReference guidReference = uniqueObjectValueCluster.GuidReference(type);
            if(guidReference == null)
            {
                return System.Guid.Empty;
            }

            return guidReference.Guid;
        }
    }
}