using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Interfaces
{
    public interface IArchive : ISerializableObject, IIOObject
    {
        byte[]? Bytes { get; }
    }
}