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
        /// <param name="serializableOptions">The source options instance to copy from.</param>
        public SerializableOptions(SerializableOptions? serializableOptions)
            : base(serializableOptions)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize options from.</param>
        public SerializableOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}