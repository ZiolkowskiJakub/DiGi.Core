namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that represents a path to another object.</summary>
    public interface IObjectPath : IObject
    {
    }
 
    /// <summary>Defines a generic contract for an object path of type T.</summary>
    /// <typeparam name="T">The type of the object path.</typeparam>
    public interface IObjectPath<T> : IObjectPath where T : IObjectPath<T>
    {
    }
}