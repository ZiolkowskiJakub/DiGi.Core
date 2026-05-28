using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    /// <summary>Defines the contract for a many-to-many relationship between unique objects.</summary>
    public interface IManyToManyRelation : IRelation
    {
        /// <summary>Gets a list of unique references on the "from" side of the relation.</summary>
        List<IUniqueReference>? UniqueReferences_From { get; }

        /// <summary>Gets a list of unique references on the "to" side of the relation.</summary>
        List<IUniqueReference>? UniqueReferences_To { get; }
    }

    /// <summary>Defines the contract for a many-to-many relationship between two types of unique objects.</summary>
    public interface IManyToManyRelation<XUniqueObject, YUniqueObject> : IManyToManyRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
    }
}