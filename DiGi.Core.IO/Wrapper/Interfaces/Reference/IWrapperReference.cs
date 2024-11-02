using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Wrapper.Interfaces
{
    internal interface IWrapperReference : ISerializableReference, IWrapperObject
    {

    }

    internal interface IWrapperReference<TSerializableReference> where TSerializableReference : SerializableReference
    {

    }
}
