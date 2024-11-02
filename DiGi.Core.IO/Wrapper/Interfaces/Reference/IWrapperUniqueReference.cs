using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Wrapper.Classes;

namespace DiGi.Core.IO.Wrapper.Interfaces
{
    internal interface IWrapperUniqueReference : IWrapperReference
    {
        public WrapperTypeReference WrapperTypeReference { get; }
    }

    internal interface IWrapperUniqueReference<TUniqueReference> : IWrapperUniqueReference, IWrapperReference<TUniqueReference> where TUniqueReference : UniqueReference
    {

    }
}
