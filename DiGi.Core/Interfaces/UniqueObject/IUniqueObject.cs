using System;


namespace DiGi.Core.Interfaces
{
    public interface IUniqueObject : ISerializableObject
    {
        string UniqueId { get; }
    }
}
