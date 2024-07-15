using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToManyRelation : IRelation
    {
        UniqueReference UniqueReference_From { get; }

        List<UniqueReference> UniqueReferences_To { get; }
    }
}
