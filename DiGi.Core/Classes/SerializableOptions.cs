using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Abstract base class for serializable configuration or option objects.
    /// </summary>
    public abstract class SerializableOptions : SerializableObject, ISerializableOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOptions"/> class.
        /// </summary>
        public SerializableOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOptions"/> class by copying another options instance.
        /// </summary>
        public SerializableOptions(SerializableOptions? serializableOptions)
            : base(serializableOptions)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOptions"/> class from a JSON object.
        /// </summary>
        public SerializableOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}