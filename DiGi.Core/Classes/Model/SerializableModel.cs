using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Base class for models that support serialization.
    /// </summary>
    public abstract class SerializableModel : SerializableObject, ISerializableModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableModel"/> class.
        /// </summary>
        public SerializableModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableModel"/> class by copying an existing model.
        /// </summary>
        /// <param name="serializableModel">The source model to copy from.</param>
        public SerializableModel(SerializableModel serializableModel)
            : base(serializableModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableModel"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the model.</param>
        public SerializableModel(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}