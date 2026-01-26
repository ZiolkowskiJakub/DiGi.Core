using DiGi.Core.Classes;

namespace DiGi.Core.Interfaces
{
    public interface IUniqueReference : IInstanceRelatedSerializableReference
    {
        TypeReference? TypeReference { get; }

        string? UniqueId { get; }
    }
}
