using DiGi.Core.IO.Wrapper.Classes;

namespace DiGi.Core.IO.Wrapper.Constants
{
    /// <summary>
    /// Provides static storage and management for metadata.
    /// </summary>
    public static class MetadataStorage
    {
        internal static WrapperGuidReference WrapperGuidReference { get; } = new WrapperGuidReference(typeof(IO.Classes.MetadataStorage), IO.Constants.MetadataStorage.Guid);
    }
}