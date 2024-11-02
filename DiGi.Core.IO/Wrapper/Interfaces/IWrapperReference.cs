using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Wrapper.Interfaces
{
    internal interface IWrapperReference : ISerializableObject, IWrapperObject
    {
        TypeReference TypeReference { get; }
    }
}
