using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class ObjectUniqueIdReference : UniqueIdReference, IObjectReference
    {
        public ObjectUniqueIdReference(UniqueIdReference uniqueIdReference)
            : base(uniqueIdReference)
        {

        }

        public ObjectUniqueIdReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ObjectUniqueIdReference(string fullTypeName, string uniqueId)
            : base(fullTypeName, uniqueId)
        {

        }
    }
}
