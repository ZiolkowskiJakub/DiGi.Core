using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public sealed class GuidExternalReference : UniqueExternalReference<GuidReference>
    {

        public GuidExternalReference(string source, IUniqueObject uniqueObject)
            : base(source, uniqueObject == null ? null : new GuidReference(uniqueObject))
        {

        }

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