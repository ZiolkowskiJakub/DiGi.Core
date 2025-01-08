using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToManyRelation : IRelation
    {
        IUniqueReference UniqueReference_From { get; }

        List<IUniqueReference> UniqueReferences_To { get; }
    }

    public interface IOneToManyRelation<X, Y> : IOneToManyRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
