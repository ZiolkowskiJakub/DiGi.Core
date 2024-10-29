using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class UniqueIdPropertyReference : UniquePropertyReference<UniqueIdReference>
    {
        public UniqueIdPropertyReference(string propertyName, UniqueIdReference reference)
            : base(propertyName, reference)
        {

        }

        public UniqueIdPropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UniqueIdPropertyReference(UniqueIdPropertyReference uniqueIdPropertyReference)
            : base(uniqueIdPropertyReference)
        {

        }

        public override ISerializableObject Clone()
        {
            return new UniqueIdPropertyReference(this);
        }
    }
}