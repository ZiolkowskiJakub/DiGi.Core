using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IRelation : ISerializableObject
    {
        System.Type GetType(RelationSide relationSide);

        List<UniqueReference> UniqueReferences { get; }

        bool Contains(RelationSide relationSide, UniqueReference uniqueReference);

        bool Has(RelationSide relationSide);

        bool Remove(RelationSide relationSide, UniqueReference uniqueReference);

        List<UniqueReference> Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference> uniqueReferences) where TUniqueReference : UniqueReference;
    }

    public interface IRelation<From, To> : IRelation where From : IUniqueObject where To : IUniqueObject
    {

    }
}
