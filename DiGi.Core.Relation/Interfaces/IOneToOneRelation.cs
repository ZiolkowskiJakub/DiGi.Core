using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    /// <summary>Defines the contract for a one-to-one relationship between unique objects.</summary>
    public interface IOneToOneRelation : IRelation
    {
        /// <summary>Gets the unique reference on the "from" side of the relation.</summary>
        IUniqueReference? UniqueReference_From { get; }

        /// <summary>Gets the unique reference on the "to" side of the relation.</summary>
        IUniqueReference? UniqueReference_To { get; }
    }

    /// <summary>Defines the contract for a one-to-one relationship between two types of unique objects.</summary>
    public interface IOneToOneRelation<XUniqueObject, YUniqueObject> : IOneToOneRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
    }
}