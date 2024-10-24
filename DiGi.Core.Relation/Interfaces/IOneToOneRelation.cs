using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToOneRelation : IRelation
    {
        UniqueReference UniqueReference_From { get; }

        UniqueReference UniqueReference_To { get; }
    }

    public interface IOneToOneRelation<X, Y> : IOneToOneRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
