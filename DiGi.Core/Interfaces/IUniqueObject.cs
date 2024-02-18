using System;


namespace DiGi.Core.Interfaces
{
    public interface IUniqueObject : ISerializableObject
    {
        Guid Guid { get; }
    }
}
