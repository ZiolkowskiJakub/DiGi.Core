using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    /// <summary>Defines the contract for a bidirectional relation between unique objects.</summary>
    public interface IBidirectionalRelation : IRelation
    {
    }

    /// <summary>Defines the contract for a bidirectional relation between two types of unique objects.</summary>
    public interface IBidirectionalRelation<X, Y> : IBidirectionalRelation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {
    }
}