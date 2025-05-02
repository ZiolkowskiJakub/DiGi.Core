using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class Options : SerializableObject, IOptions
    {
        public Options()
        {

        }

        public Options(Options options)
            : base(options)
        {

        }

        public Options(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
