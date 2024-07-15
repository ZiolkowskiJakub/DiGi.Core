using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IManyToOneRelation : IRelation
    {
        List<UniqueReference> UniqueReferences_From { get; }
        
        UniqueReference UniqueReference_To{ get; }
    }
}
