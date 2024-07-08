using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    public interface IRelation : ISerializableObject
    {
        List<UniqueReference> UniqueReferences { get; }

        bool Contains(UniqueReference uniqueReference);
    }
}
