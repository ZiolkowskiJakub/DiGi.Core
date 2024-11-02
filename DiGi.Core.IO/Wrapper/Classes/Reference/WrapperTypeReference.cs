using DiGi.Core.Classes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperTypeReference : WrapperReference<TypeReference>
    {
        public WrapperTypeReference(TypeReference typeReference)
            :base(typeReference)
        {
            
        }

        public WrapperTypeReference(WrapperTypeReference wrapperTypeReference)
            :base(wrapperTypeReference)
        {

        }

        public static explicit operator WrapperTypeReference(TypeReference typeReference)
        {
            if (typeReference == null)
            {
                return null;
            }

            return new WrapperTypeReference(typeReference);
        }

        public static explicit operator TypeReference(WrapperTypeReference wrapperTypeReference)
        {
            if (wrapperTypeReference == null)
            {
                return null;
            }

            return wrapperTypeReference.reference;
        }
    }

}
