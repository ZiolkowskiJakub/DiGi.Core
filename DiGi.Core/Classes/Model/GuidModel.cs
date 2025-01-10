using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class GuidModel : GuidObject, IGuidModel
    {
        public GuidModel() 
        {
            
        }

        public GuidModel(GuidModel guidModel)
            :base(guidModel)
        {

        }

        public GuidModel(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
