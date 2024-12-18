namespace DiGi.Core.Interfaces
{
    public interface IObjectPath : IObject
    {
    }

    public interface IObjectPath<T> : IObjectPath where T : IObjectPath<T>
    {

    }
}
