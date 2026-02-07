using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static bool TryParse(string? value, out IWrapperReference? wrapperReference)
        {
            wrapperReference = null;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (!DiGi.Core.Query.TryParse(value, out IReference? reference))
            {
                return false;
            }

            if (reference is TypeReference typeReference)
            {
                wrapperReference = new WrapperTypeReference(typeReference);
                return true;
            }

            if (reference is UniqueIdReference uniqueIdReference)
            {
                wrapperReference = new WrapperUniqueIdReference(uniqueIdReference);
                return true;
            }

            if (reference is GuidReference guidReference)
            {
                wrapperReference = new WrapperGuidReference(guidReference);
                return true;
            }

            return false;
        }

        internal static bool TryParse<TWrapperReference>(string? value, out TWrapperReference? wrapperReference) where TWrapperReference : IWrapperReference
        {
            wrapperReference = default;

            if (!TryParse(value, out IWrapperReference? wrapperReference_Temp))
            {
                return false;
            }

            if (wrapperReference_Temp is TWrapperReference reference)
            {
                wrapperReference = reference;
                return true;
            }

            return false;
        }
    }
}