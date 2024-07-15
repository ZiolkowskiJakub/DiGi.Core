using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IManyToManyRelation : IRelation
    {
        List<UniqueReference> UniqueReferences_From { get; }

        List<UniqueReference> UniqueReferences_To { get; }
    }
}
