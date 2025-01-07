using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class InstanceRelatedExternalReference<TInstanceRelatedSerializableReference> : ExternalReference<TInstanceRelatedSerializableReference> where TInstanceRelatedSerializableReference : IInstanceRelatedSerializableReference
    {
        public InstanceRelatedExternalReference(string source, TInstanceRelatedSerializableReference reference)
            : base(source, reference)
        {

        }

        public InstanceRelatedExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public InstanceRelatedExternalReference(InstanceRelatedExternalReference<TInstanceRelatedSerializableReference> externalReference)
        : base(externalReference)
        {

        }
    }

    public sealed class InstanceRelatedExternalReference : InstanceRelatedExternalReference<IInstanceRelatedSerializableReference>
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
