using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToOneRelation : IRelation
    {
        IUniqueReference? UniqueReference_From { get; }

        IUniqueReference? UniqueReference_To { get; }
    }

    public interface IOneToOneRelation<XUniqueObject, YUniqueObject> : IOneToOneRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
    }
}