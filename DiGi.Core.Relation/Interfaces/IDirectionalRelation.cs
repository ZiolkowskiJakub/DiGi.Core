using DiGi.Core.Interfaces;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IDirectionalRelation : IRelation
    {

    }

    /// <summary>
    /// Directional Relation
    /// </summary>
    /// <typeparam name="XUniqueObject">Parent Unique Object</typeparam>
    /// <typeparam name="YUniqueObject">Related Unique Object</typeparam>
    public interface IDirectionalRelation<XUniqueObject, YUniqueObject> : IDirectionalRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {

    }
}
