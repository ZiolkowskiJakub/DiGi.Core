using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public sealed class TypeRelatedExternalReference : ExternalReference<ITypeRelatedSerializableReference>
    {

        public TypeRelatedExternalReference(string source, ITypeRelatedSerializableReference reference)
            : base(source, reference)
        {

        }

        public TypeRelatedExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public TypeRelatedExternalReference(TypeRelatedExternalReference externalReference)
        : base(externalReference)
        {

        }
    }
}
