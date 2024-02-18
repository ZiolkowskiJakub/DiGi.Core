using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    public interface IIndexedObjects : IObject, IEnumerable
    {
    }

    public interface IIndexedObjects<T> : IIndexedObjects, IEnumerable<T>
    {
    }
}
