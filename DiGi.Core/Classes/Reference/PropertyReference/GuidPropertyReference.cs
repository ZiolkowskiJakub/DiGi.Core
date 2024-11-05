using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class GuidPropertyReference : UniquePropertyReference<GuidReference>
    {
        public GuidPropertyReference(GuidReference reference, string propertyName)
            : base(reference, propertyName)
        {

        }

        public GuidPropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public GuidPropertyReference(GuidPropertyReference guidPropertyReference)
            : base(guidPropertyReference)
        {

        }

        public override ISerializableObject Clone()
        {
            return new GuidPropertyReference(this);
        }
    }
}