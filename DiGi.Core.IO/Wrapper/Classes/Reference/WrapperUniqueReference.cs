using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal abstract class WrapperUniqueReference<TUniqueReference> : WrapperReference<TUniqueReference>, IWrapperUniqueReference<TUniqueReference> where TUniqueReference : UniqueReference
    {
        [JsonIgnore]
        private WrapperTypeReference wrapperTypeReference;

        public WrapperUniqueReference(WrapperUniqueReference<TUniqueReference> wrapperUniqueReference)
            :base(wrapperUniqueReference)
        {

        }

        public WrapperUniqueReference(TUniqueReference reference)
            : base(reference)
        {

        }

        [JsonIgnore]
        public WrapperTypeReference WrapperTypeReference
        {
            get
            {
                if(wrapperTypeReference == null)
                {
                    wrapperTypeReference = new WrapperTypeReference(reference.TypeReference);
                }

                return wrapperTypeReference;
            }
        }
    }

}
