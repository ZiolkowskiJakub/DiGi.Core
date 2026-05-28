using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for external references that identify objects by a unique ID.</summary>
    public abstract class UniqueExternalReference<TUniqueReference> : InstanceRelatedExternalReference<TUniqueReference>, IUniqueReference where TUniqueReference : UniqueReference
    {
        public UniqueExternalReference(string? source, TUniqueReference? reference)
            : base(source, reference)
        {
        }

        public UniqueExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UniqueExternalReference(UniqueExternalReference<TUniqueReference>? externalReference)
        : base(externalReference)
        {
        }

        public TypeReference? TypeReference
        {
            get
            {
                return Reference?.TypeReference;
            }
        }

        public string? UniqueId
        {
            get
            {
                return Reference?.UniqueId;
            }
        }
    }
}