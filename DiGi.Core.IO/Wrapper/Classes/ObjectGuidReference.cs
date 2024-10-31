using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class ObjectGuidReference : GuidReference, IObjectReference
    {
        public ObjectGuidReference(GuidReference guidReference)
            : base(guidReference)
        {

        }

        public ObjectGuidReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ObjectGuidReference(string fullTypeName, System.Guid guid)
            : base(fullTypeName, guid)
        {

        }
    }
}
