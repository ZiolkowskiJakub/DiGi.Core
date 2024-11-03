using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static UniqueReference UniqueReference(this IWrapperUniqueReference wrapperUniqueReference)
        {
            if(wrapperUniqueReference == null)
            {
                return null;
            }

            if(wrapperUniqueReference is WrapperGuidReference)
            {
                return ((WrapperGuidReference)wrapperUniqueReference).Reference;
            }

            if (wrapperUniqueReference is WrapperUniqueIdReference)
            {
                return ((WrapperUniqueIdReference)wrapperUniqueReference).Reference;
            }

            throw new System.NotImplementedException();
        }
    }
}

