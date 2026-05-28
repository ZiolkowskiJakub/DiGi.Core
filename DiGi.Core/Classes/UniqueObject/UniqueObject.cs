using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for serializable objects with a unique identifier.</summary>
    public abstract class UniqueObject : SerializableObject, IUniqueObject
    {
        public UniqueObject()
            : base()
        {
        }

        public UniqueObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UniqueObject(UniqueObject? uniqueObject)
            : base(uniqueObject)
        {
        }

        public abstract string? UniqueId { get; }
    }
}