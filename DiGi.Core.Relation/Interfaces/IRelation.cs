using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IRelation : ISerializableObject
    {
        System.Type GetType_From();

        System.Type GetType_To();

        List<UniqueReference> UniqueReferences { get; }

        bool Contains(UniqueReference uniqueReference);

        bool Contains_From(UniqueReference uniqueReference);

        bool Contains_To(UniqueReference uniqueReference);

        bool Has_From();

        bool Has_To();

        bool Remove(UniqueReference uniqueReference);

        List<UniqueReference> Remove<TUniqueReference>(IEnumerable<TUniqueReference> uniqueReferences) where TUniqueReference : UniqueReference;
    }

    public interface IRelation<X, Y> : IRelation where X : IUniqueObject where Y : IUniqueObject
    {

    }
}
