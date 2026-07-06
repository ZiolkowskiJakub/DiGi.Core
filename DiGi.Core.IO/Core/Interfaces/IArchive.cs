using DiGi.Core.Interfaces;
using DiGi.Core.IO.Interfaces;

namespace DiGi.Core.IO.Interfaces
{
    public interface IArchive : ISerializableObject, IIOObject
    {
        byte[]? Bytes { get; }
    }
}