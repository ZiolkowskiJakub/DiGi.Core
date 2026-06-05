using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a result that can be serialized.
    /// </summary>
    public abstract class SerializableResult : SerializableObject, ISerializableResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableResult"/> class.
        /// </summary>
        public SerializableResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableResult"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public SerializableResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableResult"/> class from another serializable result.
        /// </summary>
        /// <param name="serializableResult">The serializable result to initialize from.</param>
        public SerializableResult(SerializableResult? serializableResult)
            : base(serializableResult)
        {
        }
    }

    /// <summary>
    /// Represents a result that can be serialized.
    /// </summary>
    /// <typeparam name="T">The type of the result.</typeparam>
    public abstract class SerializableResult<T> : SerializableResult, ISerializableResult<T> where T : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableResult"/> class.
        /// </summary>
        public SerializableResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableResult"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public SerializableResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableResult"/> class from a generic serializable result.
        /// </summary>
        /// <param name="serializableResult">The generic serializable result to initialize from.</param>
        public SerializableResult(SerializableResult<T>? serializableResult)
            : base(serializableResult)
        {
        }
    }
}