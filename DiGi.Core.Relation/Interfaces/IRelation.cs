using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IRelation : ISerializableObject
    {
        System.Type GetType(RelationSide relationSide);

        List<IUniqueReference> UniqueReferences { get; }

        bool Contains(RelationSide relationSide, IUniqueReference uniqueReference);

        bool Has(RelationSide relationSide);

        bool Remove(RelationSide relationSide, IUniqueReference uniqueReference);

        List<TUniqueReference> Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference> uniqueReferences) where TUniqueReference : IUniqueReference;
    }

    public interface IRelation<From, To> : IRelation where From : IUniqueObject where To : IUniqueObject
    {

    }
}
