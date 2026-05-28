using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    /// <summary>Defines the contract for a many-to-one relationship between unique objects.</summary>
    public interface IManyToOneRelation : IRelation
    {
        /// <summary>Gets a list of unique references on the "from" side of the relation.</summary>
        List<IUniqueReference>? UniqueReferences_From { get; }

        /// <summary>Gets the unique reference on the "to" side of the relation.</summary>
        IUniqueReference? UniqueReference_To { get; }
    }

    /// <summary>Defines the contract for a many-to-one relationship between two types of unique objects.</summary>
    public interface IManyToOneRelation<XUniqueObject, YUniqueObject> : IManyToOneRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
    }
}