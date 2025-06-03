using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToOneRelation : IRelation
    {
        IUniqueReference UniqueReference_From { get; }

        IUniqueReference UniqueReference_To { get; }
    }

    public interface IOneToOneRelation<X, Y> : IOneToOneRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
