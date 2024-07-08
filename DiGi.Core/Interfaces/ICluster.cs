using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    public interface ICluster : ISerializableObject
    {
        List<TypeReference> TypeReferences { get; }
    }

    public interface ICluster<T> : ICluster where T : ISerializableObject
    {
        List<T> Objects { get; }
    }

}
