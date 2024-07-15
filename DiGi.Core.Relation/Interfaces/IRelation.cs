using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IRelation : ISerializableObject
    {
        List<UniqueReference> UniqueReferences { get; }

        bool Contains(UniqueReference uniqueReference);

        bool Contains_From(UniqueReference uniqueReference);

        bool Contains_To(UniqueReference uniqueReference);

        bool Remove(UniqueReference uniqueReference);

        bool Remove_From(UniqueReference uniqueReference);

        bool Remove_To(UniqueReference uniqueReference);
    }
}
