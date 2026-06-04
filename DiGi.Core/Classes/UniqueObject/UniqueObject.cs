using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for serializable objects with a unique identifier.</summary>
    public abstract class UniqueObject : SerializableObject, IUniqueObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueObject"/> class.
        /// </summary>
        public UniqueObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueObject"/> class using the specified JSON object.
        /// </summary>
        public UniqueObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueObject"/> class by copying an existing instance.
        /// </summary>
        public UniqueObject(UniqueObject? uniqueObject)
            : base(uniqueObject)
        {
        }

        /// <summary>
        /// Gets or sets the unique identifier for the object.
        /// </summary>
        public abstract string? UniqueId { get; }
    }
}