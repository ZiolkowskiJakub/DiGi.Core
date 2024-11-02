using DiGi.Core.Classes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperUniqueIdReference : WrapperUniqueReference<UniqueIdReference>
    {
        public WrapperUniqueIdReference(UniqueIdReference uniqueIdReference)
            : base(uniqueIdReference)
        {

        }

        public WrapperUniqueIdReference(WrapperUniqueIdReference wrapperUniqueIdReference)
            : base(wrapperUniqueIdReference)
        {

        }

        public WrapperUniqueIdReference(string fullTypeName, string uniqueId)
            : base(new UniqueIdReference(fullTypeName, uniqueId))
        {

        }

        public static explicit operator WrapperUniqueIdReference(UniqueIdReference uniqueIdReference)
        {
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new WrapperUniqueIdReference(uniqueIdReference);
        }

        public static explicit operator UniqueIdReference(WrapperUniqueIdReference wrapperUniqueIdReference)
        {
            if (wrapperUniqueIdReference == null)
            {
                return null;
            }

            return wrapperUniqueIdReference.reference;
        }
    }
}
