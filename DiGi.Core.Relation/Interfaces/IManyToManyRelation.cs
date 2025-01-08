using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IManyToManyRelation : IRelation
    {
        List<IUniqueReference> UniqueReferences_From { get; }

        List<IUniqueReference> UniqueReferences_To { get; }
    }

    public interface IManyToManyRelation<X, Y> : IManyToManyRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
