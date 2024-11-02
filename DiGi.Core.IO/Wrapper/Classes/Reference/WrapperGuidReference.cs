using DiGi.Core.Classes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperGuidReference : WrapperUniqueReference<GuidReference>
    {
        public WrapperGuidReference(GuidReference guidReference)
            : base(guidReference)
        {

        }

        public WrapperGuidReference(string fullTypeName, System.Guid guid)
            : base(new GuidReference(fullTypeName, guid))
        {

        }

        public WrapperGuidReference(WrapperGuidReference wrapperGuidReference)
            : base(wrapperGuidReference)
        {

        }

        public static explicit operator WrapperGuidReference(GuidReference guidReference)
        {
            if (guidReference == null)
            {
                return null;
            }

            return new WrapperGuidReference(guidReference);
        }

        public static explicit operator GuidReference(WrapperGuidReference wrapperGuidReference)
        {
            if (wrapperGuidReference == null)
            {
                return null;
            }

            return wrapperGuidReference.reference;
        }
    }
}
