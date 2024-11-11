using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public sealed class InstanceRelatedExternalReference : ExternalReference<IInstanceRelatedSerializableReference>
    {

        public InstanceRelatedExternalReference(string source, IInstanceRelatedSerializableReference reference)
            : base(source, reference)
        {

        }

        public InstanceRelatedExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public InstanceRelatedExternalReference(InstanceRelatedExternalReference externalReference)
        : base(externalReference)
        {

        }
    }
}
