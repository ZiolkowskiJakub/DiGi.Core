
namespace DiGi.Core.Interfaces
{
    public interface ICloneableObject : IObject
    {

    }

    public interface ICloneableObject<out TCloneableObject> : ICloneableObject where TCloneableObject : ICloneableObject<TCloneableObject>
    {
        TCloneableObject? Clone();
    }
}