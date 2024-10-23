using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IManyToOneRelation : IRelation
    {
        List<UniqueReference> UniqueReferences_From { get; }
        
        UniqueReference UniqueReference_To{ get; }
    }

    public interface IManyToOneRelation<X, Y> : IManyToOneRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
