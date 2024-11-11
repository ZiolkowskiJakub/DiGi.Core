using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class UniquePropertyReference<UUniquePropertyReference> : PropertyReference<UUniquePropertyReference>, IInstanceRelatedSerializableReference where UUniquePropertyReference : UniqueReference
    {
        public UniquePropertyReference(UUniquePropertyReference reference, string propertyName)
            : base(reference,propertyName)
        {

        }

        public UniquePropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UniquePropertyReference(UniquePropertyReference<UUniquePropertyReference> uniquePropertyReference)
            : base(uniquePropertyReference)
        {

        }
    }
}