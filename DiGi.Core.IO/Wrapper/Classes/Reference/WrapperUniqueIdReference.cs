using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperUniqueIdReference : UniqueIdReference, IWrapperReference
    {
        public WrapperUniqueIdReference(UniqueIdReference uniqueIdReference)
            : base(uniqueIdReference)
        {

        }

        public WrapperUniqueIdReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public WrapperUniqueIdReference(string fullTypeName, string uniqueId)
            : base(fullTypeName, uniqueId)
        {

        }
    }
}
