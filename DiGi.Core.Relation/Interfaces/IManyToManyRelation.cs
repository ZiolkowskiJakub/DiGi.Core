using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IManyToManyRelation : IRelation
    {
        List<IUniqueReference>? UniqueReferences_From { get; }

        List<IUniqueReference>? UniqueReferences_To { get; }
    }

    public interface IManyToManyRelation<XUniqueObject, YUniqueObject> : IManyToManyRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {

    }
}
