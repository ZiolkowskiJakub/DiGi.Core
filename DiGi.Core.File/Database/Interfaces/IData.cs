using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Database.Interfaces
{
    public interface IData : ISerializableObject, IDatabaseObject
    {
        public UniqueIdReference UniqueIdReference { get; }
    }

    public interface IData<T> : IData
    {
        public T Value { get; }
    }
}
