using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class ConvertOptions : SerializableObject, IConvertOptions
    {
        public ConvertOptions()
            : base()
        {

        }

        public ConvertOptions(ConvertOptions convertOptions)
            : base(convertOptions)
        {

        }

        public ConvertOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
