using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    /// <summary>Defines the contract for a relationship between unique objects.</summary>
    public interface IRelation : ISerializableObject
    {
        /// <summary>Gets the type of the object on the specified side of the relation.</summary>
        System.Type? GetType(RelationSide relationSide);

        /// <summary>Gets a list containing all unique references in this relation.</summary>
        List<IUniqueReference>? UniqueReferences { get; }

        /// <summary>Determines whether the relation contains the specified unique reference on the given side.</summary>
        bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Determines whether the relation has a reference on the specified side.</summary>
        bool Has(RelationSide relationSide);

        /// <summary>Removes a unique reference from the specified side of the relation.</summary>
        bool Remove(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Removes multiple unique references from the specified side of the relation.</summary>
        List<TUniqueReference>? Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference>? uniqueReferences) where TUniqueReference : IUniqueReference;
    }

    /// <summary>Defines the contract for a relationship between two types of unique objects.</summary>
    public interface IRelation<From, To> : IRelation where From : IUniqueObject where To : IUniqueObject
    {
    }
}