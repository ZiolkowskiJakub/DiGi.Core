using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Interfaces;

namespace DiGi.Core.IO.Wrapper.Interfaces
{
    public interface IObjectReference : ISerializableObject, IIOObject
    {
        TypeReference TypeReference { get; }
    }
}
