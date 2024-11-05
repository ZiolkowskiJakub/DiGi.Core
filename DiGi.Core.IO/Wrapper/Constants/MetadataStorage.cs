using DiGi.Core.IO.Wrapper.Classes;

namespace DiGi.Core.IO.Wrapper.Constans
{
    public static class MetadataStorage
    {
        public static System.Guid Guid { get; } = new System.Guid("1305e11b-9278-46bc-9993-3c0d8e9f2ba0");

        internal static WrapperGuidReference WrapperGuidReference { get; } = new WrapperGuidReference(typeof(Classes.MetadataStorage), Guid);
    }
}