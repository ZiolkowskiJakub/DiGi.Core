using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperGuidReference : GuidReference, IWrapperReference
    {
        public WrapperGuidReference(GuidReference guidReference)
            : base(guidReference)
        {

        }

        public WrapperGuidReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public WrapperGuidReference(string fullTypeName, System.Guid guid)
            : base(fullTypeName, guid)
        {

        }
    }
}
