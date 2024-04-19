using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class Reference : SerializableObject, IReference
    {
        public Reference()
            :base()
        {

        }

        public Reference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
