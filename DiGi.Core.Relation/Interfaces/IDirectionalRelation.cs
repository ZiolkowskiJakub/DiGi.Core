using DiGi.Core.Interfaces;
 
namespace DiGi.Core.Relation.Interfaces
{
    /// <summary>Defines the contract for a directional relation between unique objects.</summary>
    public interface IDirectionalRelation : IRelation
    {
    }
 
    /// <summary>Defines the contract for a directional relation between two types of unique objects.</summary>
    /// <typeparam name="XUniqueObject">The type of the source unique object.</typeparam>
    /// <typeparam name="YUniqueObject">The type of the target unique object.</typeparam>
    public interface IDirectionalRelation<XUniqueObject, YUniqueObject> : IDirectionalRelation, IRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
    }
}