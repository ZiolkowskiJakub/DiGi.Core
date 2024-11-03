using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal sealed class WrapperGuidReference : WrapperUniqueReference<GuidReference>
    {
        public WrapperGuidReference(GuidReference guidReference)
            : base(guidReference)
        {

        }

        public WrapperGuidReference(string fullTypeName, System.Guid guid)
            : base(new GuidReference(fullTypeName, guid))
        {

        }

        public WrapperGuidReference(WrapperGuidReference wrapperGuidReference)
            : base(wrapperGuidReference)
        {

        }

        public WrapperGuidReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
