using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IRelation : ISerializableObject
    {
        List<UniqueReference> UniqueReferences { get; }

        bool Contains(UniqueReference uniqueReference);
    }
}
