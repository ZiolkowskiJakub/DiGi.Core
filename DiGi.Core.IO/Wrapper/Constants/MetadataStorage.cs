using DiGi.Core.IO.Wrapper.Classes;

namespace DiGi.Core.IO.Wrapper.Constans
{
    public static class MetadataStorage
    {
        internal static WrapperGuidReference WrapperGuidReference { get; } = new WrapperGuidReference(typeof(IO.Classes.MetadataStorage), IO.Constans.MetadataStorage.Guid);
    }
}