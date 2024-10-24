using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IDirectionalRelation : IRelation
    {

    }

    public interface IDirectionalRelation<X, Y> : IDirectionalRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
