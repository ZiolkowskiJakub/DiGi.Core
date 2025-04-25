using DiGi.Core.Classes;
using DiGi.Core.Constans;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static bool TryParse(string value, out IWrapperReference wrapperReference)
        {
            wrapperReference = null;

            if(string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if(!DiGi.Core.Query.TryParse(value, out IReference reference))
            {
                return false;
            }

            if(reference is TypeReference)
            {
                wrapperReference = new WrapperTypeReference((TypeReference)reference);
                return true;
            }

            if (reference is UniqueIdReference)
            {
                wrapperReference = new WrapperUniqueIdReference((UniqueIdReference)reference);
                return true;
            }

            if (reference is GuidReference)
            {
                wrapperReference = new WrapperGuidReference((GuidReference)reference);
                return true;
            }

            return false;
        }

        internal static bool TryParse<TWrapperReference>(string value, out TWrapperReference wrapperReference) where TWrapperReference : IWrapperReference
        {
            wrapperReference = default;

            if (!TryParse(value, out IWrapperReference wrapperReference_Temp))
            {
                return false;
            }

            if (wrapperReference_Temp is TWrapperReference)
            {
                wrapperReference = (TWrapperReference)wrapperReference_Temp;
                return true;
            }

            return false;
        }
    }
}

