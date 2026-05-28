using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Table.Interfaces
{
    /// <summary>Defines a contract for table objects that can be serialized.</summary>
    public interface ITableSerializableObject : ITableObject, ISerializableObject
    {
    }
}