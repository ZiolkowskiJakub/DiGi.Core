using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IBidirectionalRelation : IRelation
    {

    }

    public interface IBidirectionalRelation<X, Y> : IBidirectionalRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
