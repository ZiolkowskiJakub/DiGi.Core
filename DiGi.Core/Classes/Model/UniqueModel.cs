using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class UniqueModel : UniqueObject, IUniqueModel
    {
        public UniqueModel() 
        {
            
        }

        public UniqueModel(UniqueModel uniqueModel)
            :base(uniqueModel)
        {

        }

        public UniqueModel(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
