using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperUniqueIdReference : WrapperUniqueReference<UniqueIdReference>
    {
        public WrapperUniqueIdReference(UniqueIdReference uniqueIdReference)
            : base(uniqueIdReference)
        {

        }

        public WrapperUniqueIdReference(WrapperUniqueIdReference wrapperUniqueIdReference)
            : base(wrapperUniqueIdReference)
        {

        }

        public WrapperUniqueIdReference(string fullTypeName, string uniqueId)
            : base(new UniqueIdReference(fullTypeName, uniqueId))
        {

        }
        public WrapperUniqueIdReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
