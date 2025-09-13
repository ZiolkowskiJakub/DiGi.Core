using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToManyRelation : IRelation
    {
        IUniqueReference? UniqueReference_From { get; }

        List<IUniqueReference>? UniqueReferences_To { get; }
    }

    public interface IOneToManyRelation<XUniqueObject, YUniqueObject> : IOneToManyRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {

    }
}
