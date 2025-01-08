using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IManyToOneRelation : IRelation
    {
        List<IUniqueReference> UniqueReferences_From { get; }
        
        IUniqueReference UniqueReference_To{ get; }
    }

    public interface IManyToOneRelation<X, Y> : IManyToOneRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
