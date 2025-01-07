using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public sealed class GuidExternalReference : InstanceRelatedExternalReference<GuidReference>
    {
        public GuidExternalReference(string source, GuidReference reference)
            : base(source, reference)
        {

        }

        public GuidExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public GuidExternalReference(GuidExternalReference externalReference)
        : base(externalReference)
        {

        }
    }
}