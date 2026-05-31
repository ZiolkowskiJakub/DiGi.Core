using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that contains a collection of indexed objects.</summary>
    public interface IIndexedObjects : IObject, IEnumerable
    {
    }

    /// <summary>Defines a generic contract for an object that contains a collection of indexed objects of type T.</summary>
    /// <typeparam name="T">The type of the indexed objects.</typeparam>
    public interface IIndexedObjects<T> : IIndexedObjects, IEnumerable<T>
    {
    }
}